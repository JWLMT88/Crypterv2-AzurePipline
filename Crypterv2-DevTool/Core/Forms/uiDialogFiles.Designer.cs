﻿namespace Crypterv2.DevTool.Core.Forms
{
    partial class uiDialogFiles
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
            lblMessageText = new Label();
            bntOk = new Guna.UI2.WinForms.Guna2Button();
            sPanel2 = new Sipaa.Framework.SPanel();
            bntCancel = new Guna.UI2.WinForms.Guna2Button();
            listViewHistory = new HTAlt.WinForms.HTListView();
            ColId = new ColumnHeader();
            ColOperation = new ColumnHeader();
            ColMode = new ColumnHeader();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            pnlLoad = new Guna.UI2.WinForms.Guna2Panel();
            progressSpinner = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
            sPanel2.SuspendLayout();
            pnlLoad.SuspendLayout();
            SuspendLayout();
            // 
            // lblMessageText
            // 
            lblMessageText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblMessageText.BackColor = Color.Transparent;
            lblMessageText.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMessageText.ForeColor = Color.Black;
            lblMessageText.Location = new Point(16, 8);
            lblMessageText.Name = "lblMessageText";
            lblMessageText.Size = new Size(568, 56);
            lblMessageText.TabIndex = 17;
            lblMessageText.Text = "Dependencie Manager";
            lblMessageText.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // bntOk
            // 
            bntOk.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bntOk.Animated = true;
            bntOk.BackColor = Color.Transparent;
            bntOk.BackgroundImageLayout = ImageLayout.Zoom;
            bntOk.BorderColor = Color.Gainsboro;
            bntOk.BorderRadius = 14;
            bntOk.BorderThickness = 2;
            bntOk.DisabledState.BorderColor = Color.Gainsboro;
            bntOk.DisabledState.CustomBorderColor = Color.DarkGray;
            bntOk.DisabledState.FillColor = Color.White;
            bntOk.DisabledState.ForeColor = Color.Gray;
            bntOk.FillColor = Color.Transparent;
            bntOk.FocusedColor = Color.FromArgb(100, 170, 209);
            bntOk.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            bntOk.ForeColor = Color.Black;
            bntOk.Location = new Point(488, 12);
            bntOk.Margin = new Padding(2);
            bntOk.Name = "bntOk";
            bntOk.Size = new Size(93, 38);
            bntOk.TabIndex = 15;
            bntOk.Text = "Cancel";
            bntOk.Click += bntOk_Click;
            // 
            // sPanel2
            // 
            sPanel2.BackColor = Color.WhiteSmoke;
            sPanel2.BackgroundImageLayout = ImageLayout.Stretch;
            sPanel2.BorderColor = Color.Black;
            sPanel2.BorderRadius = 0;
            sPanel2.BorderSize = 0;
            sPanel2.Controls.Add(bntOk);
            sPanel2.Controls.Add(bntCancel);
            sPanel2.Dock = DockStyle.Bottom;
            sPanel2.ForeColor = Color.White;
            sPanel2.Location = new Point(0, 548);
            sPanel2.Name = "sPanel2";
            sPanel2.Size = new Size(601, 66);
            sPanel2.TabIndex = 18;
            // 
            // bntCancel
            // 
            bntCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bntCancel.Animated = true;
            bntCancel.BackColor = Color.Transparent;
            bntCancel.BackgroundImageLayout = ImageLayout.Zoom;
            bntCancel.BorderColor = Color.Gainsboro;
            bntCancel.BorderRadius = 14;
            bntCancel.BorderThickness = 2;
            bntCancel.DisabledState.BorderColor = Color.Gainsboro;
            bntCancel.DisabledState.CustomBorderColor = Color.DarkGray;
            bntCancel.DisabledState.FillColor = Color.White;
            bntCancel.DisabledState.ForeColor = Color.Gray;
            bntCancel.FocusedColor = Color.FromArgb(100, 170, 209);
            bntCancel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            bntCancel.ForeColor = Color.White;
            bntCancel.Location = new Point(328, 12);
            bntCancel.Margin = new Padding(2);
            bntCancel.Name = "bntCancel";
            bntCancel.Size = new Size(144, 38);
            bntCancel.TabIndex = 15;
            bntCancel.Text = "Submit";
            bntCancel.Click += bntCancel_Click;
            // 
            // listViewHistory
            // 
            listViewHistory.Activation = ItemActivation.OneClick;
            listViewHistory.Alignment = ListViewAlignment.Default;
            listViewHistory.AllowColumnReorder = true;
            listViewHistory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listViewHistory.BorderStyle = BorderStyle.None;
            listViewHistory.Columns.AddRange(new ColumnHeader[] { ColId, ColOperation, ColMode });
            listViewHistory.FullRowSelect = true;
            listViewHistory.GridLines = true;
            listViewHistory.HeaderBackColor = Color.FromArgb(235, 235, 235);
            listViewHistory.HeaderBorderThickness = 2;
            listViewHistory.HeaderForeColor = Color.Black;
            listViewHistory.HideSelection = true;
            listViewHistory.HoverSelection = true;
            listViewHistory.Location = new Point(16, 72);
            listViewHistory.Margin = new Padding(2);
            listViewHistory.MultiSelect = false;
            listViewHistory.Name = "listViewHistory";
            listViewHistory.OverlayColor = Color.DodgerBlue;
            listViewHistory.ShowGroups = false;
            listViewHistory.ShowItemToolTips = true;
            listViewHistory.Size = new Size(568, 464);
            listViewHistory.TabIndex = 19;
            listViewHistory.UseCompatibleStateImageBehavior = false;
            listViewHistory.View = View.Details;
            // 
            // ColId
            // 
            ColId.Tag = "ID";
            ColId.Text = "ID";
            ColId.Width = 50;
            // 
            // ColOperation
            // 
            ColOperation.Tag = "Opration";
            ColOperation.Text = "Name";
            ColOperation.Width = 320;
            // 
            // ColMode
            // 
            ColMode.Text = "Type";
            ColMode.Width = 160;
            // 
            // guna2Button1
            // 
            guna2Button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2Button1.Animated = true;
            guna2Button1.BackColor = Color.Transparent;
            guna2Button1.BackgroundImageLayout = ImageLayout.Zoom;
            guna2Button1.BorderColor = Color.Gainsboro;
            guna2Button1.BorderRadius = 14;
            guna2Button1.BorderThickness = 2;
            guna2Button1.DisabledState.BorderColor = Color.Gainsboro;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.White;
            guna2Button1.DisabledState.ForeColor = Color.Gray;
            guna2Button1.FillColor = Color.Transparent;
            guna2Button1.FocusedColor = Color.FromArgb(100, 170, 209);
            guna2Button1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            guna2Button1.ForeColor = Color.Black;
            guna2Button1.Location = new Point(496, 16);
            guna2Button1.Margin = new Padding(2);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.Size = new Size(88, 38);
            guna2Button1.TabIndex = 15;
            guna2Button1.Text = "Add";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // pnlLoad
            // 
            pnlLoad.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlLoad.BackColor = Color.Transparent;
            pnlLoad.BorderColor = Color.Silver;
            pnlLoad.BorderRadius = 15;
            pnlLoad.Controls.Add(progressSpinner);
            pnlLoad.FillColor = Color.White;
            pnlLoad.Location = new Point(8, 64);
            pnlLoad.Margin = new Padding(2);
            pnlLoad.Name = "pnlLoad";
            pnlLoad.Size = new Size(584, 472);
            pnlLoad.TabIndex = 20;
            pnlLoad.Visible = false;
            // 
            // progressSpinner
            // 
            progressSpinner.Anchor = AnchorStyles.None;
            progressSpinner.AutoStart = true;
            progressSpinner.BackColor = Color.White;
            progressSpinner.CircleSize = 2F;
            progressSpinner.Location = new Point(232, 160);
            progressSpinner.Margin = new Padding(2);
            progressSpinner.Name = "progressSpinner";
            progressSpinner.Size = new Size(136, 128);
            progressSpinner.TabIndex = 8;
            // 
            // uiDialogFiles
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(601, 614);
            ControlBox = false;
            Controls.Add(pnlLoad);
            Controls.Add(listViewHistory);
            Controls.Add(guna2Button1);
            Controls.Add(lblMessageText);
            Controls.Add(sPanel2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "uiDialogFiles";
            Text = "uiDialogFiles";
            Load += uiDialogFiles_Load;
            sPanel2.ResumeLayout(false);
            pnlLoad.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblMessageText;
        private Guna.UI2.WinForms.Guna2Button bntOk;
        private Sipaa.Framework.SPanel sPanel2;
        private Guna.UI2.WinForms.Guna2Button bntCancel;
        private HTAlt.WinForms.HTListView listViewHistory;
        private ColumnHeader ColId;
        private ColumnHeader ColOperation;
        private ColumnHeader ColMode;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Panel pnlLoad;
        private Guna.UI2.WinForms.Guna2WinProgressIndicator progressSpinner;
    }
}