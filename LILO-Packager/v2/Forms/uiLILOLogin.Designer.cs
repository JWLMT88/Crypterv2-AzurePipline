﻿namespace LILO_Packager.v2.Forms
{
    partial class uiLILOLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uiLILOLogin));
            lblVerison = new Label();
            label2 = new Label();
            label1 = new Label();
            bntCancel = new Guna.UI2.WinForms.Guna2Button();
            pnlImg = new Sipaa.Framework.SPanel();
            pnlPreview = new Guna.UI2.WinForms.Guna2Panel();
            pnlLoginLoad = new Guna.UI2.WinForms.Guna2Panel();
            progressSpinner = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
            bntLogin = new Guna.UI2.WinForms.Guna2Button();
            label5 = new Label();
            showPsw = new Guna.UI2.WinForms.Guna2Button();
            txtPsw = new Sipaa.Framework.STextBox();
            txtUsr = new Sipaa.Framework.STextBox();
            pnlSucces = new Guna.UI2.WinForms.Guna2Panel();
            sPanel1 = new Sipaa.Framework.SPanel();
            label3 = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            pnlPreview.SuspendLayout();
            pnlLoginLoad.SuspendLayout();
            pnlSucces.SuspendLayout();
            SuspendLayout();
            // 
            // lblVerison
            // 
            lblVerison.BackColor = Color.Transparent;
            lblVerison.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblVerison.ForeColor = Color.Silver;
            lblVerison.Location = new Point(26, 19);
            lblVerison.Name = "lblVerison";
            lblVerison.Size = new Size(140, 32);
            lblVerison.TabIndex = 37;
            lblVerison.Text = "v/n";
            lblVerison.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(486, 691);
            label2.Name = "label2";
            label2.Size = new Size(109, 24);
            label2.TabIndex = 38;
            label2.Text = "powered by ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.ForeColor = SystemColors.WindowFrame;
            label1.Location = new Point(460, 710);
            label1.Name = "label1";
            label1.Size = new Size(160, 32);
            label1.TabIndex = 36;
            label1.Text = "JW Limited ©️ 2023";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bntCancel
            // 
            bntCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bntCancel.Animated = true;
            bntCancel.BackColor = Color.Transparent;
            bntCancel.BorderColor = Color.Gainsboro;
            bntCancel.BorderRadius = 12;
            bntCancel.BorderThickness = 2;
            bntCancel.DisabledState.BorderColor = Color.DarkGray;
            bntCancel.DisabledState.CustomBorderColor = Color.DarkGray;
            bntCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            bntCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            bntCancel.FillColor = Color.White;
            bntCancel.FocusedColor = Color.FromArgb(100, 170, 209);
            bntCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            bntCancel.ForeColor = Color.DimGray;
            bntCancel.Location = new Point(947, 19);
            bntCancel.Margin = new Padding(2);
            bntCancel.Name = "bntCancel";
            bntCancel.Size = new Size(113, 32);
            bntCancel.TabIndex = 35;
            bntCancel.Text = "Register";
            bntCancel.Click += bntCancel_Click;
            // 
            // pnlImg
            // 
            pnlImg.Anchor = AnchorStyles.None;
            pnlImg.BackColor = Color.White;
            pnlImg.BackgroundImage = Properties.Resources.Screenshot_2023_10_13_052005;
            pnlImg.BackgroundImageLayout = ImageLayout.Zoom;
            pnlImg.BorderColor = Color.Gainsboro;
            pnlImg.BorderRadius = 20;
            pnlImg.BorderSize = 2;
            pnlImg.ForeColor = Color.White;
            pnlImg.Location = new Point(493, 173);
            pnlImg.Name = "pnlImg";
            pnlImg.Size = new Size(102, 96);
            pnlImg.TabIndex = 40;
            // 
            // pnlPreview
            // 
            pnlPreview.Anchor = AnchorStyles.None;
            pnlPreview.BackColor = Color.Transparent;
            pnlPreview.BorderColor = Color.Gainsboro;
            pnlPreview.BorderRadius = 15;
            pnlPreview.BorderThickness = 2;
            pnlPreview.Controls.Add(pnlLoginLoad);
            pnlPreview.Controls.Add(bntLogin);
            pnlPreview.Controls.Add(label5);
            pnlPreview.Controls.Add(showPsw);
            pnlPreview.Controls.Add(txtPsw);
            pnlPreview.Controls.Add(txtUsr);
            pnlPreview.FillColor = Color.White;
            pnlPreview.Location = new Point(335, 218);
            pnlPreview.Margin = new Padding(2);
            pnlPreview.Name = "pnlPreview";
            pnlPreview.Size = new Size(410, 346);
            pnlPreview.TabIndex = 41;
            // 
            // pnlLoginLoad
            // 
            pnlLoginLoad.Anchor = AnchorStyles.None;
            pnlLoginLoad.BackColor = Color.Transparent;
            pnlLoginLoad.BorderColor = Color.Gainsboro;
            pnlLoginLoad.BorderRadius = 15;
            pnlLoginLoad.BorderThickness = 2;
            pnlLoginLoad.Controls.Add(progressSpinner);
            pnlLoginLoad.FillColor = Color.White;
            pnlLoginLoad.Location = new Point(0, 0);
            pnlLoginLoad.Margin = new Padding(2);
            pnlLoginLoad.Name = "pnlLoginLoad";
            pnlLoginLoad.Size = new Size(410, 346);
            pnlLoginLoad.TabIndex = 15;
            pnlLoginLoad.Visible = false;
            // 
            // progressSpinner
            // 
            progressSpinner.Anchor = AnchorStyles.None;
            progressSpinner.AutoStart = true;
            progressSpinner.BackColor = Color.White;
            progressSpinner.Location = new Point(154, 128);
            progressSpinner.Margin = new Padding(2, 2, 2, 2);
            progressSpinner.Name = "progressSpinner";
            progressSpinner.Size = new Size(109, 108);
            progressSpinner.TabIndex = 8;
            // 
            // bntLogin
            // 
            bntLogin.Animated = true;
            bntLogin.BackColor = Color.Transparent;
            bntLogin.BorderColor = Color.Gainsboro;
            bntLogin.BorderRadius = 15;
            bntLogin.BorderThickness = 2;
            bntLogin.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            bntLogin.DisabledState.BorderColor = Color.DarkGray;
            bntLogin.DisabledState.CustomBorderColor = Color.DarkGray;
            bntLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            bntLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            bntLogin.FillColor = Color.White;
            bntLogin.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            bntLogin.ForeColor = Color.Black;
            bntLogin.HoverState.FillColor = Color.FromArgb(94, 148, 255);
            bntLogin.HoverState.ForeColor = Color.White;
            bntLogin.Location = new Point(51, 262);
            bntLogin.Name = "bntLogin";
            bntLogin.PressedColor = Color.DarkGray;
            bntLogin.Size = new Size(320, 38);
            bntLogin.TabIndex = 18;
            bntLogin.Text = "Anmeldung";
            bntLogin.UseTransparentBackground = true;
            bntLogin.Click += bntLogin_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(154, 64);
            label5.Name = "label5";
            label5.Size = new Size(102, 30);
            label5.TabIndex = 6;
            label5.Text = "Login";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // showPsw
            // 
            showPsw.Animated = true;
            showPsw.BackColor = Color.Transparent;
            showPsw.BorderColor = Color.FromArgb(224, 224, 224);
            showPsw.BorderRadius = 15;
            showPsw.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            showPsw.CheckedState.Image = (Image)resources.GetObject("resource.Image");
            showPsw.DisabledState.BorderColor = Color.DarkGray;
            showPsw.DisabledState.CustomBorderColor = Color.DarkGray;
            showPsw.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            showPsw.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            showPsw.FillColor = Color.Transparent;
            showPsw.Font = new Font("Segoe UI", 9F);
            showPsw.ForeColor = Color.White;
            showPsw.Image = (Image)resources.GetObject("showPsw.Image");
            showPsw.Location = new Point(333, 190);
            showPsw.Name = "showPsw";
            showPsw.PressedColor = Color.DarkGray;
            showPsw.Size = new Size(30, 32);
            showPsw.TabIndex = 18;
            showPsw.UseTransparentBackground = true;
            showPsw.Click += pswVisible_Click;
            // 
            // txtPsw
            // 
            txtPsw.BackColor = Color.White;
            txtPsw.BorderColor = Color.Gainsboro;
            txtPsw.BorderFocusColor = Color.DimGray;
            txtPsw.BorderRadius = 20;
            txtPsw.BorderSize = 1;
            txtPsw.Font = new Font("Century Gothic", 12F);
            txtPsw.ForeColor = Color.Black;
            txtPsw.Location = new Point(51, 186);
            txtPsw.Margin = new Padding(4, 4, 4, 4);
            txtPsw.Multiline = false;
            txtPsw.Name = "txtPsw";
            txtPsw.Padding = new Padding(10, 7, 10, 7);
            txtPsw.PasswordChar = true;
            txtPsw.PlaceholderColor = Color.DarkGray;
            txtPsw.PlaceholderText = "Password";
            txtPsw.Size = new Size(318, 39);
            txtPsw.TabIndex = 15;
            txtPsw.Texts = "";
            txtPsw.UnderlinedStyle = false;
            // 
            // txtUsr
            // 
            txtUsr.BackColor = Color.White;
            txtUsr.BorderColor = Color.Gainsboro;
            txtUsr.BorderFocusColor = Color.DimGray;
            txtUsr.BorderRadius = 20;
            txtUsr.BorderSize = 1;
            txtUsr.Font = new Font("Century Gothic", 12F);
            txtUsr.ForeColor = Color.Black;
            txtUsr.Location = new Point(51, 128);
            txtUsr.Margin = new Padding(4, 4, 4, 4);
            txtUsr.Multiline = false;
            txtUsr.Name = "txtUsr";
            txtUsr.Padding = new Padding(10, 7, 10, 7);
            txtUsr.PasswordChar = false;
            txtUsr.PlaceholderColor = Color.DarkGray;
            txtUsr.PlaceholderText = "Email";
            txtUsr.Size = new Size(318, 39);
            txtUsr.TabIndex = 15;
            txtUsr.Texts = "";
            txtUsr.UnderlinedStyle = false;
            // 
            // pnlSucces
            // 
            pnlSucces.Anchor = AnchorStyles.None;
            pnlSucces.BackColor = Color.Transparent;
            pnlSucces.BorderColor = Color.Gainsboro;
            pnlSucces.BorderRadius = 15;
            pnlSucces.BorderThickness = 2;
            pnlSucces.Controls.Add(sPanel1);
            pnlSucces.Controls.Add(label3);
            pnlSucces.Controls.Add(guna2Button1);
            pnlSucces.FillColor = Color.White;
            pnlSucces.Location = new Point(333, 218);
            pnlSucces.Margin = new Padding(2);
            pnlSucces.Name = "pnlSucces";
            pnlSucces.Size = new Size(410, 346);
            pnlSucces.TabIndex = 15;
            pnlSucces.Visible = false;
            // 
            // sPanel1
            // 
            sPanel1.Anchor = AnchorStyles.None;
            sPanel1.BackColor = Color.White;
            sPanel1.BackgroundImage = Properties.Resources.icons8_verified_badge_96;
            sPanel1.BackgroundImageLayout = ImageLayout.Zoom;
            sPanel1.BorderColor = Color.Gainsboro;
            sPanel1.BorderRadius = 20;
            sPanel1.BorderSize = 0;
            sPanel1.ForeColor = Color.White;
            sPanel1.Location = new Point(122, 96);
            sPanel1.Name = "sPanel1";
            sPanel1.Size = new Size(179, 115);
            sPanel1.TabIndex = 42;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label3.ForeColor = SystemColors.WindowFrame;
            label3.Location = new Point(115, 218);
            label3.Name = "label3";
            label3.Size = new Size(186, 32);
            label3.TabIndex = 36;
            label3.Text = "Logged in Successfully";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // guna2Button1
            // 
            guna2Button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
            guna2Button1.Location = new Point(147, 269);
            guna2Button1.Margin = new Padding(2);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.Size = new Size(128, 32);
            guna2Button1.TabIndex = 35;
            guna2Button1.Text = "Start Now";
            guna2Button1.Click += bntGo;
            // 
            // uiLILOLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1080, 782);
            Controls.Add(pnlImg);
            Controls.Add(pnlSucces);
            Controls.Add(lblVerison);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(bntCancel);
            Controls.Add(pnlPreview);
            Margin = new Padding(2, 2, 2, 2);
            Name = "uiLILOLogin";
            Text = "uiLILOLogin";
            Load += uiLILOLogin_Load;
            pnlPreview.ResumeLayout(false);
            pnlLoginLoad.ResumeLayout(false);
            pnlSucces.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblVerison;
        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button bntCancel;
        private Sipaa.Framework.SPanel pnlImg;
        private Guna.UI2.WinForms.Guna2Panel pnlPreview;
        private Guna.UI2.WinForms.Guna2Panel pnlLoginLoad;
        private Guna.UI2.WinForms.Guna2WinProgressIndicator progressSpinner;
        private Label label5;
        private Guna.UI2.WinForms.Guna2Button bntLogin;
        private Guna.UI2.WinForms.Guna2Button showPsw;
        private Sipaa.Framework.STextBox txtPsw;
        private Sipaa.Framework.STextBox txtUsr;
        private Guna.UI2.WinForms.Guna2Panel pnlSucces;
        private Label label3;
        private Sipaa.Framework.SPanel sPanel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}