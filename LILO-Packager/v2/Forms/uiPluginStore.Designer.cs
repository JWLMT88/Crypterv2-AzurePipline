﻿namespace LILO_Packager.v2.Forms
{
    partial class uiPluginStore
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblText = new Label();
            sPanel2 = new Sipaa.Framework.SPanel();
            bntCancel = new Guna.UI2.WinForms.Guna2Button();
            sPanel1 = new Sipaa.Framework.SPanel();
            progress = new Guna.UI2.WinForms.Guna2ProgressBar();
            plainPlugin = new Controls.DynamicPluginListItem();
            encryptenPlugin = new Controls.DynamicPluginListItem();
            label1 = new Label();
            pnlNetworkError = new Sipaa.Framework.SPanel();
            lblMes = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            lblExc = new Label();
            imgImage = new Guna.UI2.WinForms.Guna2Panel();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            sPanel2.SuspendLayout();
            sPanel1.SuspendLayout();
            pnlNetworkError.SuspendLayout();
            imgImage.SuspendLayout();
            SuspendLayout();
            // 
            // lblText
            // 
            lblText.BackColor = Color.Transparent;
            lblText.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblText.ForeColor = Color.White;
            lblText.Location = new Point(19, 0);
            lblText.Name = "lblText";
            lblText.Size = new Size(154, 70);
            lblText.TabIndex = 1;
            lblText.Text = "Plugin Shop";
            lblText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sPanel2
            // 
            sPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            sPanel2.BackColor = Color.Black;
            sPanel2.BackgroundImage = Properties.Resources.Aqua_Marine_180degree;
            sPanel2.BackgroundImageLayout = ImageLayout.Stretch;
            sPanel2.BorderColor = Color.Black;
            sPanel2.BorderRadius = 20;
            sPanel2.BorderSize = 0;
            sPanel2.Controls.Add(lblText);
            sPanel2.Controls.Add(bntCancel);
            sPanel2.ForeColor = Color.White;
            sPanel2.Location = new Point(19, 26);
            sPanel2.Name = "sPanel2";
            sPanel2.Size = new Size(736, 70);
            sPanel2.TabIndex = 13;
            // 
            // bntCancel
            // 
            bntCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bntCancel.Animated = true;
            bntCancel.BackColor = Color.Transparent;
            bntCancel.BorderColor = Color.Gainsboro;
            bntCancel.BorderRadius = 20;
            bntCancel.BorderThickness = 2;
            bntCancel.DisabledState.BorderColor = Color.DarkGray;
            bntCancel.DisabledState.CustomBorderColor = Color.DarkGray;
            bntCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            bntCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            bntCancel.FillColor = Color.Transparent;
            bntCancel.FocusedColor = Color.FromArgb(100, 170, 209);
            bntCancel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            bntCancel.ForeColor = Color.White;
            bntCancel.Location = new Point(621, 13);
            bntCancel.Margin = new Padding(2);
            bntCancel.Name = "bntCancel";
            bntCancel.Size = new Size(102, 46);
            bntCancel.TabIndex = 14;
            bntCancel.Text = "Cancel";
            bntCancel.Click += bntCancel_Click;
            // 
            // sPanel1
            // 
            sPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            sPanel1.BackColor = Color.White;
            sPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            sPanel1.BorderColor = Color.Gainsboro;
            sPanel1.BorderRadius = 20;
            sPanel1.BorderSize = 2;
            sPanel1.Controls.Add(progress);
            sPanel1.Controls.Add(plainPlugin);
            sPanel1.Controls.Add(encryptenPlugin);
            sPanel1.ForeColor = Color.White;
            sPanel1.Location = new Point(19, 128);
            sPanel1.Name = "sPanel1";
            sPanel1.Size = new Size(736, 608);
            sPanel1.TabIndex = 13;
            // 
            // progress
            // 
            progress.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            progress.BackColor = Color.Transparent;
            progress.BorderColor = Color.Gainsboro;
            progress.BorderRadius = 20;
            progress.BorderThickness = 2;
            progress.FillColor = Color.Transparent;
            progress.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            progress.Location = new Point(26, 538);
            progress.Margin = new Padding(2);
            progress.Name = "progress";
            progress.ProgressColor = Color.White;
            progress.ProgressColor2 = Color.SlateGray;
            progress.Size = new Size(685, 45);
            progress.TabIndex = 16;
            progress.Text = "guna2ProgressBar1";
            progress.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            progress.Visible = false;
            // 
            // plainPlugin
            // 
            plainPlugin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            plainPlugin.BackColor = Color.White;
            plainPlugin.BorderColor = Color.Gainsboro;
            plainPlugin.BorderRadius = 20;
            plainPlugin.BorderThickness = 2;
            plainPlugin.ButtonVisible = true;
            plainPlugin.ControlBackgroundColor = Color.White;
            plainPlugin.DataContext = null;
            plainPlugin.DownloadButtonBackColor = Color.White;
            plainPlugin.DownloadButtonForeColor = Color.Black;
            plainPlugin.Location = new Point(26, 147);
            plainPlugin.Margin = new Padding(2, 2, 2, 2);
            plainPlugin.Name = "plainPlugin";
            plainPlugin.Plugin_State = v2.Controls.DynamicPluginListItem.PluginState.Available;
            plainPlugin.PluginDescription = "Can view plainbased files.";
            plainPlugin.PluginDescriptionForeColor = Color.DimGray;
            plainPlugin.PluginIcon = Properties.Resources.plainLib;
            plainPlugin.PluginName = "Textpreview";
            plainPlugin.PluginNameForeColor = Color.Black;
            plainPlugin.PluginVersion = "0.2.12-alpha";
            plainPlugin.PluginVersionForeColor = Color.DarkGray;
            plainPlugin.Size = new Size(691, 96);
            plainPlugin.TabIndex = 0;
            plainPlugin.ClickedDownload += plainPlugin_ClickedDownload;
            // 
            // encryptenPlugin
            // 
            encryptenPlugin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            encryptenPlugin.BackColor = Color.White;
            encryptenPlugin.BorderColor = Color.Gainsboro;
            encryptenPlugin.BorderRadius = 20;
            encryptenPlugin.BorderThickness = 2;
            encryptenPlugin.ButtonVisible = true;
            encryptenPlugin.ControlBackgroundColor = Color.White;
            encryptenPlugin.DataContext = null;
            encryptenPlugin.DownloadButtonBackColor = Color.White;
            encryptenPlugin.DownloadButtonForeColor = Color.Black;
            encryptenPlugin.Location = new Point(26, 38);
            encryptenPlugin.Margin = new Padding(2, 2, 2, 2);
            encryptenPlugin.Name = "encryptenPlugin";
            encryptenPlugin.Plugin_State = v2.Controls.DynamicPluginListItem.PluginState.Available;
            encryptenPlugin.PluginDescription = "Installs encryption Librarys.";
            encryptenPlugin.PluginDescriptionForeColor = Color.DimGray;
            encryptenPlugin.PluginIcon = Properties.Resources.logo_sync;
            encryptenPlugin.PluginName = "EncLib Installer";
            encryptenPlugin.PluginNameForeColor = Color.Black;
            encryptenPlugin.PluginVersion = "0.1.11-alpha";
            encryptenPlugin.PluginVersionForeColor = Color.DarkGray;
            encryptenPlugin.Size = new Size(691, 96);
            encryptenPlugin.TabIndex = 0;
            encryptenPlugin.ClickedDownload += encryptenPlugin_ClickedDownload;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(38, 115);
            label1.Name = "label1";
            label1.Size = new Size(154, 32);
            label1.TabIndex = 1;
            label1.Text = "   Availlabel";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlNetworkError
            // 
            pnlNetworkError.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlNetworkError.BackColor = Color.White;
            pnlNetworkError.BackgroundImageLayout = ImageLayout.Stretch;
            pnlNetworkError.BorderColor = Color.Black;
            pnlNetworkError.BorderRadius = 0;
            pnlNetworkError.BorderSize = 0;
            pnlNetworkError.Controls.Add(lblMes);
            pnlNetworkError.Controls.Add(guna2Button1);
            pnlNetworkError.Controls.Add(lblExc);
            pnlNetworkError.Controls.Add(imgImage);
            pnlNetworkError.ForeColor = Color.White;
            pnlNetworkError.Location = new Point(19, 104);
            pnlNetworkError.Name = "pnlNetworkError";
            pnlNetworkError.Size = new Size(736, 648);
            pnlNetworkError.TabIndex = 13;
            // 
            // lblMes
            // 
            lblMes.Anchor = AnchorStyles.None;
            lblMes.AutoEllipsis = true;
            lblMes.BackColor = Color.Transparent;
            lblMes.Font = new Font("Segoe UI", 12F);
            lblMes.ForeColor = Color.Black;
            lblMes.Location = new Point(166, 421);
            lblMes.Name = "lblMes";
            lblMes.Size = new Size(397, 45);
            lblMes.TabIndex = 28;
            lblMes.Text = "Try again with a different Network.";
            lblMes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // guna2Button1
            // 
            guna2Button1.Anchor = AnchorStyles.None;
            guna2Button1.Animated = true;
            guna2Button1.BackColor = Color.Transparent;
            guna2Button1.BorderColor = Color.Gainsboro;
            guna2Button1.BorderRadius = 12;
            guna2Button1.BorderThickness = 2;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.White;
            guna2Button1.FocusedColor = Color.FromArgb(100, 170, 209);
            guna2Button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            guna2Button1.ForeColor = Color.DimGray;
            guna2Button1.Location = new Point(234, 485);
            guna2Button1.Margin = new Padding(2);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.Size = new Size(262, 32);
            guna2Button1.TabIndex = 29;
            guna2Button1.Text = "&Retry";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // lblExc
            // 
            lblExc.Anchor = AnchorStyles.None;
            lblExc.AutoEllipsis = true;
            lblExc.BackColor = Color.Transparent;
            lblExc.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblExc.ForeColor = Color.Black;
            lblExc.Location = new Point(170, 369);
            lblExc.Name = "lblExc";
            lblExc.Size = new Size(390, 45);
            lblExc.TabIndex = 15;
            lblExc.Text = "Huh, strange.";
            lblExc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // imgImage
            // 
            imgImage.Anchor = AnchorStyles.None;
            imgImage.BackColor = Color.Transparent;
            imgImage.BackgroundImage = Properties.Resources.image_removebg_preview__2_;
            imgImage.BackgroundImageLayout = ImageLayout.Zoom;
            imgImage.BorderColor = SystemColors.ActiveBorder;
            imgImage.BorderRadius = 20;
            imgImage.Controls.Add(guna2Panel2);
            imgImage.FillColor = Color.Transparent;
            imgImage.Location = new Point(237, 126);
            imgImage.Margin = new Padding(2);
            imgImage.Name = "imgImage";
            imgImage.Size = new Size(256, 250);
            imgImage.TabIndex = 14;
            // 
            // guna2Panel2
            // 
            guna2Panel2.Anchor = AnchorStyles.None;
            guna2Panel2.BackColor = Color.Transparent;
            guna2Panel2.BackgroundImage = Properties.Resources.Close;
            guna2Panel2.BackgroundImageLayout = ImageLayout.Zoom;
            guna2Panel2.BorderColor = SystemColors.ActiveBorder;
            guna2Panel2.BorderRadius = 20;
            guna2Panel2.FillColor = Color.Transparent;
            guna2Panel2.Location = new Point(134, 122);
            guna2Panel2.Margin = new Padding(2);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.Size = new Size(96, 109);
            guna2Panel2.TabIndex = 11;
            // 
            // uiPluginStore
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(775, 766);
            Controls.Add(pnlNetworkError);
            Controls.Add(label1);
            Controls.Add(sPanel1);
            Controls.Add(sPanel2);
            Margin = new Padding(2);
            MinimumSize = new Size(793, 813);
            Name = "uiPluginStore";
            Text = "uiPluginStore";
            Load += uiPluginStore_Load;
            sPanel2.ResumeLayout(false);
            sPanel1.ResumeLayout(false);
            pnlNetworkError.ResumeLayout(false);
            imgImage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label lblText;
        private Sipaa.Framework.SPanel sPanel2;
        private Guna.UI2.WinForms.Guna2Button bntCancel;
        private Sipaa.Framework.SPanel sPanel1;
        private Label label1;
        private Controls.DynamicPluginListItem dynamicPluginListItem3;
        private Controls.DynamicPluginListItem plainPlugin;
        private Controls.DynamicPluginListItem encryptenPlugin;
        private Guna.UI2.WinForms.Guna2ProgressBar progress;
        private Sipaa.Framework.SPanel pnlNetworkError;
        private Label lblExc;
        private Guna.UI2.WinForms.Guna2Panel imgImage;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Label lblMes;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}