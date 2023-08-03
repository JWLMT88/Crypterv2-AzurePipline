﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Formats.Tar;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace LILO_Packager.v2.Forms;
public partial class uiDecrypt : Form
{
    private static uiDecrypt _encrypt;
    private static object _lock = new object();
    public Color SignalColor = Color.FromArgb(94, 148, 255);
    public static List<string> _arFiles = new List<string>();
    public int fileCounter = 1;
    public shared.FileOperations sharedFile = new();

    public static uiDecrypt Instance()
    {
        lock (_lock)
        {
            if (_encrypt is null)
            {
                _encrypt = new uiDecrypt();
            }

            return _encrypt;
        }
    }

    public uiDecrypt()
    {
        InitializeComponent();

        this.FormClosing += (sender, e) =>
        {
            if (fileCounter == 1)
            {
                e.Cancel = true;
                this.Hide();
            }
        };
    }

    public enum TaskStatus
    {
        FileChoose,
        Decrypting,
        DeCompress,
        Ready
    }


    private async void panel2_DragEnter(object sender, DragEventArgs e)
    {
        if (e.Data.GetDataPresent(DataFormats.FileDrop))
        {
            e.Effect = DragDropEffects.All;
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
        }
    }

    private async void panel2_DragDrop(object sender, DragEventArgs e)
    {
        var files = e.Data.GetData(DataFormats.FileDrop) as string[];
        _arFiles.AddRange(files);
        //_arFiles.Add(files.All<string>);

        if (files != null)
        {
            foreach (var file in files)
            {
                if (file is not null)
                {
                    if (File.Exists(file))
                    {
                        _arFiles.Add(file);

                        var info = new FileInfo(file);

                        chblistFiles.Items.Add("  " + info.Name);

                        chblistFiles.SetItemCheckState(fileCounter - 1, CheckState.Checked);

                        fileCounter++;
                    }
                }
            }
        }
    }

    public void MarkStatus(TaskStatus status)
    {
        Label[] lblList =
        {
            lblComb,
            lblDecrypt,
            lblFile,
            lblReady
        };

        Guna2CirclePictureBox[] pnlList =
        {
            pnlComb,
            pnlDecrypt,
            pnlFile,
            pnlReady
        };

        foreach (var item in pnlList)
        {
            item.FillColor = Color.White;
        }

        foreach (var item in lblList)
        {
            item.ForeColor = Color.White;
        }

        switch (status)
        {
            case TaskStatus.FileChoose:
                lblFile.ForeColor = SignalColor;
                pnlFile.FillColor = SignalColor;
                break;
            case TaskStatus.Decrypting:
                lblDecrypt.ForeColor = SignalColor;
                pnlDecrypt.FillColor = SignalColor;
                break;
            case TaskStatus.Ready:
                lblReady.ForeColor = SignalColor;
                pnlReady.FillColor = SignalColor;
                break;
            case TaskStatus.DeCompress:
                lblComb.ForeColor = SignalColor;
                pnlComb.FillColor = SignalColor;
                break;
        }

    }

    private void uiDecrypt_Load(object sender, EventArgs e)
    {
        MarkStatus(TaskStatus.FileChoose);
    }

    public string GetPasswordFrromUser()
    {
        if (pswDialog.ShowDialog() == DialogResult.OK)
        {
            return pswDialog.Input;
        }

        return null;
    }

    private void UpdateProgress(double progres)
    {
        progress1.Value = Convert.ToInt32(progres);
        taskBarProgress.State = Guna.UI2.WinForms.Guna2TaskBarProgress.TaskbarStates.Normal;
        taskBarProgress.Value = Convert.ToInt32(progres);
    }

    public void ControlEnable(bool disable)
    {
        pnlChild.Enabled = disable;
        guna2Button1.Enabled = disable;
        pnlFiles.Enabled = disable;
        bntOpen.Enabled = disable;

        progress1.Visible = !disable;
        bntCancel.Visible = !disable;
    }

    private void guna2Button1_Click(object sender, EventArgs e)
    {
        var psw = GetPasswordFrromUser();
        var current = new TaskStatus();

        if (psw is not null or "")
        {
            ControlEnable(false);

            try
            {

                foreach (string item in _arFiles)
                {
                    Task.Run(() =>
                    {

                        Services.DecryptAndDecompressFileAsync(item, item.Replace(".lsf", ""), psw,
                        progress =>
                        {
                            UpdateProgress(progress);
                        },
                        error =>
                        {
                            //ShowError("Encryption Error", error.Message);
                        },
                        currentTask =>
                        {

                            if (currentTask.StartsWith("Decompress") && current is not TaskStatus.DeCompress)
                            {
                                MarkStatus(TaskStatus.DeCompress);

                                current = TaskStatus.DeCompress;
                            }

                            if (currentTask.StartsWith("Decrypting") && current is not TaskStatus.Decrypting)
                            {
                                MarkStatus(TaskStatus.Decrypting);

                                current = TaskStatus.Decrypting;
                            }


                            if (currentTask == "success")
                            {
                                MarkStatus(TaskStatus.Ready);

                                taskBarProgress.Value = 0;
                                taskBarProgress.State = Guna.UI2.WinForms.Guna2TaskBarProgress.TaskbarStates.NoProgress;

                                ControlEnable(true);

                                _arFiles.Remove(item);

                                var info = new FileInfo(item);

                                chblistFiles.Items.Remove("  " + info.Name);

                                fileCounter--;
                            }
                        });
                    });
                }



            }
            catch (Exception ey)
            {
                ControlEnable(true);

                ShowError("Error", ey.Message);
            }
        }
        else
        {
            ShowError("Error", "Please Insert a valid Key.");
        }
    }

    private void ShowError(string title, string message)
    {
        MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    private void bntOpen_Click(object sender, EventArgs e)
    {
        var files = sharedFile.GetFilesFromDialog();

        if (files != null)
        {
            foreach (var file in files)
            {
                if (file is not null)
                {
                    if (File.Exists(file))
                    {
                        _arFiles.Add(file);

                        var info = new FileInfo(file);

                        chblistFiles.Items.Add("  " + info.Name);

                        chblistFiles.SetItemCheckState(fileCounter - 1, CheckState.Checked);

                        fileCounter++;
                    }
                }
            }
        }
    }
}
