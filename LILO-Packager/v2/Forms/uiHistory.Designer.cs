﻿namespace LILO_Packager.v2.Forms
{
    partial class uiHistory
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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "12345", "Encryption", "Library Based", "v2", "C:File", "C:File.lsf" }, -1);
            tableLayoutPanel1 = new TableLayoutPanel();
            listViewHistory = new HTAlt.WinForms.HTListView();
            ColId = new ColumnHeader();
            ColOperation = new ColumnHeader();
            ColMode = new ColumnHeader();
            ColVersion = new ColumnHeader();
            ColInput = new ColumnHeader();
            ColOutput = new ColumnHeader();
            conmenu = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            viewToolStripMenuItem = new ToolStripMenuItem();
            compareToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            reportToolStripMenuItem = new ToolStripMenuItem();
            sPanel2 = new Sipaa.Framework.SPanel();
            bntPlugin = new Guna.UI2.WinForms.Guna2Button();
            bntCancel = new Guna.UI2.WinForms.Guna2Button();
            lblText = new Label();
            pnlLoginLoad = new Guna.UI2.WinForms.Guna2Panel();
            progressSpinner = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
            label5 = new Label();
            tableLayoutPanel1.SuspendLayout();
            conmenu.SuspendLayout();
            sPanel2.SuspendLayout();
            pnlLoginLoad.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(listViewHistory, 0, 1);
            tableLayoutPanel1.Location = new Point(32, 83);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 16F));
            tableLayoutPanel1.Size = new Size(762, 659);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // listViewHistory
            // 
            listViewHistory.Activation = ItemActivation.OneClick;
            listViewHistory.Alignment = ListViewAlignment.Default;
            listViewHistory.AllowColumnReorder = true;
            listViewHistory.BorderStyle = BorderStyle.None;
            listViewHistory.Columns.AddRange(new ColumnHeader[] { ColId, ColOperation, ColMode, ColVersion, ColInput, ColOutput });
            listViewHistory.ContextMenuStrip = conmenu;
            listViewHistory.Dock = DockStyle.Fill;
            listViewHistory.FullRowSelect = true;
            listViewHistory.GridLines = true;
            listViewHistory.HeaderBackColor = Color.FromArgb(235, 235, 235);
            listViewHistory.HeaderBorderThickness = 2;
            listViewHistory.HeaderForeColor = Color.Black;
            listViewHistory.HideSelection = true;
            listViewHistory.HoverSelection = true;
            listViewHistory.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listViewHistory.Location = new Point(2, 42);
            listViewHistory.Margin = new Padding(2);
            listViewHistory.MultiSelect = false;
            listViewHistory.Name = "listViewHistory";
            listViewHistory.OverlayColor = Color.DodgerBlue;
            listViewHistory.ShowGroups = false;
            listViewHistory.ShowItemToolTips = true;
            listViewHistory.Size = new Size(758, 615);
            listViewHistory.TabIndex = 0;
            listViewHistory.UseCompatibleStateImageBehavior = false;
            listViewHistory.View = View.Details;
            listViewHistory.SelectedIndexChanged += listViewBerechtigungen_SelectedIndexChanged;
            // 
            // ColId
            // 
            ColId.Tag = "ID";
            ColId.Text = "ID";
            ColId.Width = 90;
            // 
            // ColOperation
            // 
            ColOperation.Tag = "Opration";
            ColOperation.Text = "Opration";
            ColOperation.Width = 160;
            // 
            // ColMode
            // 
            ColMode.Text = "Core";
            ColMode.Width = 160;
            // 
            // ColVersion
            // 
            ColVersion.Text = "Algorithm - Version";
            // 
            // ColInput
            // 
            ColInput.Text = "Input File";
            ColInput.Width = 250;
            // 
            // ColOutput
            // 
            ColOutput.Text = "Output File";
            ColOutput.Width = 250;
            // 
            // conmenu
            // 
            conmenu.BackColor = Color.White;
            conmenu.ImageScalingSize = new Size(24, 24);
            conmenu.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem, toolStripSeparator1, viewToolStripMenuItem, compareToolStripMenuItem, toolStripSeparator2, reportToolStripMenuItem });
            conmenu.Name = "ConMenu";
            conmenu.RenderStyle.ArrowColor = Color.FromArgb(125, 100, 255);
            conmenu.RenderStyle.BorderColor = Color.Black;
            conmenu.RenderStyle.ColorTable = null;
            conmenu.RenderStyle.RoundedEdges = true;
            conmenu.RenderStyle.SelectionArrowColor = Color.White;
            conmenu.RenderStyle.SelectionBackColor = Color.FromArgb(94, 148, 255);
            conmenu.RenderStyle.SelectionForeColor = Color.White;
            conmenu.RenderStyle.SeparatorColor = Color.LightGray;
            conmenu.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            conmenu.Size = new Size(140, 112);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(139, 24);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(136, 6);
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(139, 24);
            viewToolStripMenuItem.Text = "View";
            viewToolStripMenuItem.Click += viewToolStripMenuItem_Click;
            // 
            // compareToolStripMenuItem
            // 
            compareToolStripMenuItem.Name = "compareToolStripMenuItem";
            compareToolStripMenuItem.Size = new Size(139, 24);
            compareToolStripMenuItem.Text = "Compare";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(136, 6);
            // 
            // reportToolStripMenuItem
            // 
            reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            reportToolStripMenuItem.Size = new Size(139, 24);
            reportToolStripMenuItem.Text = "Report";
            reportToolStripMenuItem.Click += reportToolStripMenuItem_Click;
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
            sPanel2.Controls.Add(bntPlugin);
            sPanel2.Controls.Add(bntCancel);
            sPanel2.Controls.Add(lblText);
            sPanel2.ForeColor = Color.White;
            sPanel2.Location = new Point(19, 26);
            sPanel2.Name = "sPanel2";
            sPanel2.Size = new Size(774, 70);
            sPanel2.TabIndex = 13;
            // 
            // bntPlugin
            // 
            bntPlugin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bntPlugin.Animated = true;
            bntPlugin.BackColor = Color.Transparent;
            bntPlugin.BackgroundImageLayout = ImageLayout.Zoom;
            bntPlugin.BorderColor = Color.Gainsboro;
            bntPlugin.BorderRadius = 20;
            bntPlugin.BorderThickness = 2;
            bntPlugin.DisabledState.BorderColor = Color.DarkGray;
            bntPlugin.DisabledState.CustomBorderColor = Color.DarkGray;
            bntPlugin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            bntPlugin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            bntPlugin.FillColor = Color.Transparent;
            bntPlugin.FocusedColor = Color.FromArgb(100, 170, 209);
            bntPlugin.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            bntPlugin.ForeColor = Color.White;
            bntPlugin.Location = new Point(666, 13);
            bntPlugin.Margin = new Padding(2);
            bntPlugin.Name = "bntPlugin";
            bntPlugin.Size = new Size(96, 46);
            bntPlugin.TabIndex = 15;
            bntPlugin.Text = "Refresh";
            bntPlugin.Click += bntPlugin_Click;
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
            bntCancel.Location = new Point(1894, 13);
            bntCancel.Margin = new Padding(2);
            bntCancel.Name = "bntCancel";
            bntCancel.Size = new Size(102, 46);
            bntCancel.TabIndex = 14;
            bntCancel.Text = "Cancel";
            bntCancel.Visible = false;
            // 
            // lblText
            // 
            lblText.BackColor = Color.Transparent;
            lblText.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblText.ForeColor = Color.White;
            lblText.Location = new Point(19, 0);
            lblText.Name = "lblText";
            lblText.Size = new Size(115, 70);
            lblText.TabIndex = 1;
            lblText.Text = "History";
            lblText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlLoginLoad
            // 
            pnlLoginLoad.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlLoginLoad.BackColor = Color.Transparent;
            pnlLoginLoad.BorderColor = Color.Silver;
            pnlLoginLoad.BorderRadius = 15;
            pnlLoginLoad.Controls.Add(progressSpinner);
            pnlLoginLoad.Controls.Add(label5);
            pnlLoginLoad.FillColor = Color.White;
            pnlLoginLoad.Location = new Point(26, 120);
            pnlLoginLoad.Margin = new Padding(2);
            pnlLoginLoad.Name = "pnlLoginLoad";
            pnlLoginLoad.Size = new Size(768, 623);
            pnlLoginLoad.TabIndex = 16;
            // 
            // progressSpinner
            // 
            progressSpinner.Anchor = AnchorStyles.None;
            progressSpinner.AutoStart = true;
            progressSpinner.BackColor = Color.White;
            progressSpinner.Location = new Point(323, 205);
            progressSpinner.Margin = new Padding(2);
            progressSpinner.Name = "progressSpinner";
            progressSpinner.Size = new Size(108, 108);
            progressSpinner.TabIndex = 8;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(320, 333);
            label5.Name = "label5";
            label5.Size = new Size(115, 24);
            label5.TabIndex = 6;
            label5.Text = "Loading...";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // uiHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(816, 758);
            Controls.Add(pnlLoginLoad);
            Controls.Add(sPanel2);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2);
            Name = "uiHistory";
            Text = "uiHistory";
            Load += uiHistory_Load;
            tableLayoutPanel1.ResumeLayout(false);
            conmenu.ResumeLayout(false);
            sPanel2.ResumeLayout(false);
            pnlLoginLoad.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ContextMenuStrip conmenu;
        private TableLayoutPanel tableLayoutPanel1;
        private HTAlt.WinForms.HTListView listViewHistory;
        private ColumnHeader ColId;
        private ColumnHeader ColOperation;
        private ColumnHeader ColMode;
        private ColumnHeader ColVersion;
        private ColumnHeader ColInput;
        private ColumnHeader ColOutput;
        private Sipaa.Framework.SPanel sPanel2;
        private Guna.UI2.WinForms.Guna2Button bntCancel;
        private Label lblText;
        private Guna.UI2.WinForms.Guna2Button bntPlugin;
        private Guna.UI2.WinForms.Guna2Panel pnlLoginLoad;
        private Guna.UI2.WinForms.Guna2WinProgressIndicator progressSpinner;
        private Label label5;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem compareToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem reportToolStripMenuItem;
    }
}