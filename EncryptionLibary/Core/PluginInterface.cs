﻿using LILO_Packager.v2.Plugins.PluginCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptionLibary.Core;
public partial class PluginInterface : Form
{
    public string Version;
    public PluginID id;
    public string Name;

    private static object _lock = new object();

    private static PluginInterface _encrypt;


    public PluginID Id => throw new NotImplementedException();

    public static PluginInterface Instance(string Version, PluginID id, string Name)
    {
        lock (_lock)
        {
            if (_encrypt is null || _encrypt.IsDisposed)
            {
                _encrypt = new PluginInterface(Version, id, Name);
            }

            return _encrypt;
        }
    }


    private PluginInterface(string Version, PluginID id, string Name)
    {
        InitializeComponent();

        this.id = id;
        this.Version = Version;
        this.Name = Name;

        this.FormClosing += (sender, e) =>
        {
            e.Cancel = true;
            this.Hide();
        };
    }

    private void uiSettings_Load(object sender, EventArgs e)
    {
        lblVersion.Text = Version;
        this.Text = "Plugin: " + Name;
    }

    private void guna2Button1_Click(object sender, EventArgs e)
    {
        MessageBox.Show("You cant deinstall this model.", "PluginManager", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    private void guna2Button2_Click(object sender, EventArgs e)
    {
        progress.Visible = true;
    }
}
