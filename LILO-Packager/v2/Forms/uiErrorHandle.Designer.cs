﻿namespace LILO_Packager.v2.Forms
{
    partial class uiErrorHandle
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
            pnlPreview = new Guna.UI2.WinForms.Guna2Panel();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            lblName = new Label();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            lblMes = new Label();
            lblExc = new Label();
            bntTrouble = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            lblAddtional = new Label();
            pnlPreview.SuspendLayout();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPreview
            // 
            pnlPreview.Anchor = AnchorStyles.None;
            pnlPreview.BackColor = Color.White;
            pnlPreview.BorderColor = SystemColors.ActiveBorder;
            pnlPreview.BorderRadius = 15;
            pnlPreview.Controls.Add(guna2Panel2);
            pnlPreview.Controls.Add(lblName);
            pnlPreview.FillColor = Color.White;
            pnlPreview.Location = new Point(288, 112);
            pnlPreview.Margin = new Padding(2);
            pnlPreview.Name = "pnlPreview";
            pnlPreview.Size = new Size(488, 368);
            pnlPreview.TabIndex = 12;
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
            guna2Panel2.Location = new Point(120, 32);
            guna2Panel2.Margin = new Padding(2);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.Size = new Size(232, 248);
            guna2Panel2.TabIndex = 11;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.None;
            lblName.AutoEllipsis = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.ForeColor = Color.Black;
            lblName.Location = new Point(-8, 304);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(488, 64);
            lblName.TabIndex = 13;
            lblName.Text = "Huh, strange.";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // guna2Panel1
            // 
            guna2Panel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            guna2Panel1.BorderColor = SystemColors.ActiveBorder;
            guna2Panel1.BorderRadius = 15;
            guna2Panel1.BorderThickness = 2;
            guna2Panel1.Controls.Add(lblMes);
            guna2Panel1.FillColor = Color.Transparent;
            guna2Panel1.Location = new Point(280, 528);
            guna2Panel1.Margin = new Padding(2);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.Size = new Size(496, 160);
            guna2Panel1.TabIndex = 14;
            // 
            // lblMes
            // 
            lblMes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblMes.AutoEllipsis = true;
            lblMes.BackColor = Color.Transparent;
            lblMes.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblMes.ForeColor = Color.Black;
            lblMes.Location = new Point(8, 16);
            lblMes.Margin = new Padding(4, 0, 4, 0);
            lblMes.Name = "lblMes";
            lblMes.Size = new Size(480, 128);
            lblMes.TabIndex = 13;
            lblMes.Text = "This Feature is not availlabel.";
            lblMes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblExc
            // 
            lblExc.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblExc.BackColor = Color.Transparent;
            lblExc.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblExc.ForeColor = Color.Black;
            lblExc.Location = new Point(216, 32);
            lblExc.Margin = new Padding(4, 0, 4, 0);
            lblExc.Name = "lblExc";
            lblExc.Size = new Size(616, 40);
            lblExc.TabIndex = 1;
            lblExc.Text = "FeatureNullException";
            lblExc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bntTrouble
            // 
            bntTrouble.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bntTrouble.Animated = true;
            bntTrouble.BackColor = Color.Transparent;
            bntTrouble.BorderColor = Color.Gainsboro;
            bntTrouble.BorderRadius = 12;
            bntTrouble.BorderThickness = 2;
            bntTrouble.DisabledState.BorderColor = Color.DarkGray;
            bntTrouble.DisabledState.CustomBorderColor = Color.DarkGray;
            bntTrouble.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            bntTrouble.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            bntTrouble.FillColor = Color.White;
            bntTrouble.FocusedColor = Color.FromArgb(100, 170, 209);
            bntTrouble.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bntTrouble.ForeColor = Color.DimGray;
            bntTrouble.Location = new Point(904, 24);
            bntTrouble.Margin = new Padding(2);
            bntTrouble.Name = "bntTrouble";
            bntTrouble.Size = new Size(160, 40);
            bntTrouble.TabIndex = 27;
            bntTrouble.Text = "Learn more...";
            bntTrouble.Click += bntTrouble_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.WindowFrame;
            label1.Location = new Point(432, 752);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(200, 40);
            label1.TabIndex = 28;
            label1.Text = "JW Limited ©️ 2023";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAddtional
            // 
            lblAddtional.BackColor = Color.Transparent;
            lblAddtional.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddtional.ForeColor = Color.Black;
            lblAddtional.Location = new Point(32, 32);
            lblAddtional.Margin = new Padding(4, 0, 4, 0);
            lblAddtional.Name = "lblAddtional";
            lblAddtional.Size = new Size(176, 656);
            lblAddtional.TabIndex = 1;
            // 
            // uiErrorHandle
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1083, 826);
            Controls.Add(label1);
            Controls.Add(lblExc);
            Controls.Add(lblAddtional);
            Controls.Add(bntTrouble);
            Controls.Add(guna2Panel1);
            Controls.Add(pnlPreview);
            Name = "uiErrorHandle";
            Text = "uiFeatureNullException";
            Load += uiFeatureNullException_Load;
            pnlPreview.ResumeLayout(false);
            guna2Panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlPreview;
        private Label lblName;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label lblMes;
        private Label lblExc;
        private Guna.UI2.WinForms.Guna2Button bntTrouble;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Label lblAddtional;
    }
}