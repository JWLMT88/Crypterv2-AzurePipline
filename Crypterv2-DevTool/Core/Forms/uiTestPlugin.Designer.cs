﻿namespace Crypterv2_DevTool.Core.Forms
{
    partial class uiTestPlugin
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
            cmbPlugins = new ComboBox();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            lblDirectory = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            pnlChild = new Guna.UI2.WinForms.Guna2Panel();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cmbPlugins
            // 
            cmbPlugins.Anchor = AnchorStyles.Right;
            cmbPlugins.FormattingEnabled = true;
            cmbPlugins.Location = new Point(640, 24);
            cmbPlugins.Name = "cmbPlugins";
            cmbPlugins.Size = new Size(198, 33);
            cmbPlugins.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.White;
            guna2Panel1.BorderColor = SystemColors.ActiveBorder;
            guna2Panel1.BorderRadius = 15;
            guna2Panel1.BorderThickness = 2;
            guna2Panel1.Controls.Add(lblDirectory);
            guna2Panel1.Controls.Add(cmbPlugins);
            guna2Panel1.Controls.Add(guna2Button1);
            guna2Panel1.Controls.Add(guna2Button2);
            guna2Panel1.Dock = DockStyle.Top;
            guna2Panel1.FillColor = SystemColors.ButtonHighlight;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Margin = new Padding(2);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.Size = new Size(856, 80);
            guna2Panel1.TabIndex = 25;
            // 
            // lblDirectory
            // 
            lblDirectory.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblDirectory.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblDirectory.Location = new Point(248, 24);
            lblDirectory.Name = "lblDirectory";
            lblDirectory.Size = new Size(288, 32);
            lblDirectory.TabIndex = 17;
            lblDirectory.Text = "label1";
            lblDirectory.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // guna2Button1
            // 
            guna2Button1.Anchor = AnchorStyles.Left;
            guna2Button1.Animated = true;
            guna2Button1.BackColor = Color.Transparent;
            guna2Button1.BorderColor = Color.Gainsboro;
            guna2Button1.BorderRadius = 5;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.White;
            guna2Button1.FocusedColor = Color.FromArgb(100, 170, 209);
            guna2Button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.DimGray;
            guna2Button1.Location = new Point(24, 24);
            guna2Button1.Margin = new Padding(2);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.Size = new Size(224, 32);
            guna2Button1.TabIndex = 16;
            guna2Button1.Text = "Choose Directory";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // guna2Button2
            // 
            guna2Button2.Anchor = AnchorStyles.Right;
            guna2Button2.Animated = true;
            guna2Button2.BackColor = Color.Transparent;
            guna2Button2.BorderColor = Color.Gainsboro;
            guna2Button2.BorderRadius = 5;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.White;
            guna2Button2.FocusedColor = Color.FromArgb(100, 170, 209);
            guna2Button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button2.ForeColor = Color.DimGray;
            guna2Button2.Location = new Point(544, 24);
            guna2Button2.Margin = new Padding(2);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.Size = new Size(88, 32);
            guna2Button2.TabIndex = 16;
            guna2Button2.Text = "Show";
            guna2Button2.Click += guna2Button2_Click;
            // 
            // pnlChild
            // 
            pnlChild.BackColor = SystemColors.Control;
            pnlChild.BorderColor = SystemColors.ActiveBorder;
            pnlChild.BorderRadius = 15;
            pnlChild.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            pnlChild.BorderThickness = 2;
            pnlChild.Dock = DockStyle.Fill;
            pnlChild.FillColor = Color.White;
            pnlChild.Location = new Point(0, 80);
            pnlChild.Margin = new Padding(2);
            pnlChild.Name = "pnlChild";
            pnlChild.Size = new Size(856, 553);
            pnlChild.TabIndex = 24;
            // 
            // uiTestPlugin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 633);
            Controls.Add(pnlChild);
            Controls.Add(guna2Panel1);
            MinimumSize = new Size(878, 689);
            Name = "uiTestPlugin";
            Text = "uiTestPlugin";
            Load += uiTestPlugin_Load;
            guna2Panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbPlugins;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel pnlChild;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Label lblDirectory;
    }
}