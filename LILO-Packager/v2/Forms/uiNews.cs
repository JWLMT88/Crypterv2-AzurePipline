﻿using CommonMark;
using LILO_Packager.v2.Core.Updates;
using System.Diagnostics;

namespace LILO_Packager.v2.Forms
{
    public partial class uiNews : Form
    {
        public uiNews()
        {
            InitializeComponent();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void uiNews_Load(object sender, EventArgs e)
        {
            try
            {
                lblVersion.Text = Program.Version;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/JW-Limited/Crypterv2";

            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }

        private void ReportBug_CLick(object sender, EventArgs e)
        {
            string url = "https://github.com/JW-Limited/Crypterv2/issues/new?assignees=&labels=&projects=&template=bug_report.md&title=Error";

            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }

        private async void bntRefrewsh(object sender, EventArgs e)
        {
            string markdownText = await Updater.Instance().GetLatestChanges(MainHost.Instance().Owner, MainHost.Instance().Repository);
            string html = CommonMarkConverter.Convert(markdownText);
            richText.Text = html;
        }
    }

}
