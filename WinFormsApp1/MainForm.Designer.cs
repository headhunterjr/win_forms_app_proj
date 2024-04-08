﻿namespace WinFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnlHeader = new Panel();
            headerControl1 = new Controls.HeaderControl();
            pnlNavigation = new Panel();
            lsbEmployees = new ListBox();
            pnlRefresh = new Panel();
            btnRefresh = new Button();
            pnlMainArea = new Panel();
            btnSave = new Button();
            chkIsCoffeeDrinker = new CheckBox();
            cboJobRole = new ComboBox();
            dtpEntryDate = new DateTimePicker();
            txtFirstName = new TextBox();
            lblJobRole = new Label();
            lblEntryDate = new Label();
            lblFirstName = new Label();
            employeeBindingSource = new BindingSource(components);
            pnlHeader.SuspendLayout();
            pnlNavigation.SuspendLayout();
            pnlRefresh.SuspendLayout();
            pnlMainArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(headerControl1);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1200, 125);
            pnlHeader.TabIndex = 0;
            // 
            // headerControl1
            // 
            headerControl1.BackColor = Color.FromArgb(240, 90, 40);
            headerControl1.Dock = DockStyle.Fill;
            headerControl1.Location = new Point(0, 0);
            headerControl1.Name = "headerControl1";
            headerControl1.Size = new Size(1200, 125);
            headerControl1.TabIndex = 0;
            // 
            // pnlNavigation
            // 
            pnlNavigation.Controls.Add(lsbEmployees);
            pnlNavigation.Controls.Add(pnlRefresh);
            pnlNavigation.Dock = DockStyle.Left;
            pnlNavigation.Location = new Point(0, 125);
            pnlNavigation.Name = "pnlNavigation";
            pnlNavigation.Size = new Size(276, 550);
            pnlNavigation.TabIndex = 1;
            // 
            // lsbEmployees
            // 
            lsbEmployees.Dock = DockStyle.Fill;
            lsbEmployees.FormattingEnabled = true;
            lsbEmployees.ItemHeight = 30;
            lsbEmployees.Location = new Point(0, 87);
            lsbEmployees.Name = "lsbEmployees";
            lsbEmployees.Size = new Size(276, 463);
            lsbEmployees.TabIndex = 1;
            // 
            // pnlRefresh
            // 
            pnlRefresh.Controls.Add(btnRefresh);
            pnlRefresh.Dock = DockStyle.Top;
            pnlRefresh.Location = new Point(0, 0);
            pnlRefresh.Name = "pnlRefresh";
            pnlRefresh.Size = new Size(276, 87);
            pnlRefresh.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnRefresh.Location = new Point(37, 19);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(199, 49);
            btnRefresh.TabIndex = 0;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // pnlMainArea
            // 
            pnlMainArea.Controls.Add(btnSave);
            pnlMainArea.Controls.Add(chkIsCoffeeDrinker);
            pnlMainArea.Controls.Add(cboJobRole);
            pnlMainArea.Controls.Add(dtpEntryDate);
            pnlMainArea.Controls.Add(txtFirstName);
            pnlMainArea.Controls.Add(lblJobRole);
            pnlMainArea.Controls.Add(lblEntryDate);
            pnlMainArea.Controls.Add(lblFirstName);
            pnlMainArea.Dock = DockStyle.Fill;
            pnlMainArea.Location = new Point(276, 125);
            pnlMainArea.Name = "pnlMainArea";
            pnlMainArea.Size = new Size(924, 550);
            pnlMainArea.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSave.Location = new Point(56, 399);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(170, 75);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // chkIsCoffeeDrinker
            // 
            chkIsCoffeeDrinker.AutoSize = true;
            chkIsCoffeeDrinker.Location = new Point(56, 324);
            chkIsCoffeeDrinker.Name = "chkIsCoffeeDrinker";
            chkIsCoffeeDrinker.Size = new Size(187, 34);
            chkIsCoffeeDrinker.TabIndex = 6;
            chkIsCoffeeDrinker.Text = "Coffee Drinker?";
            chkIsCoffeeDrinker.UseVisualStyleBackColor = true;
            // 
            // cboJobRole
            // 
            cboJobRole.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboJobRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cboJobRole.FormattingEnabled = true;
            cboJobRole.Location = new Point(56, 239);
            cboJobRole.Name = "cboJobRole";
            cboJobRole.Size = new Size(807, 38);
            cboJobRole.TabIndex = 5;
            // 
            // dtpEntryDate
            // 
            dtpEntryDate.Location = new Point(56, 149);
            dtpEntryDate.Name = "dtpEntryDate";
            dtpEntryDate.Size = new Size(376, 36);
            dtpEntryDate.TabIndex = 4;
            // 
            // txtFirstName
            // 
            txtFirstName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFirstName.Location = new Point(56, 61);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(807, 36);
            txtFirstName.TabIndex = 3;
            txtFirstName.TextChanged += txtFirstName_TextChanged;
            // 
            // lblJobRole
            // 
            lblJobRole.AutoSize = true;
            lblJobRole.Location = new Point(56, 206);
            lblJobRole.Name = "lblJobRole";
            lblJobRole.Size = new Size(95, 30);
            lblJobRole.TabIndex = 2;
            lblJobRole.Text = "Job Role";
            // 
            // lblEntryDate
            // 
            lblEntryDate.AutoSize = true;
            lblEntryDate.Location = new Point(56, 116);
            lblEntryDate.Name = "lblEntryDate";
            lblEntryDate.Size = new Size(111, 30);
            lblEntryDate.TabIndex = 1;
            lblEntryDate.Text = "Entry date";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(56, 28);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(113, 30);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First name";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 675);
            Controls.Add(pnlMainArea);
            Controls.Add(pnlNavigation);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 13F);
            Margin = new Padding(4);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlNavigation.ResumeLayout(false);
            pnlRefresh.ResumeLayout(false);
            pnlMainArea.ResumeLayout(false);
            pnlMainArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Panel pnlNavigation;
        private Panel pnlRefresh;
        private Panel pnlMainArea;
        private ListBox lsbEmployees;
        private Button btnRefresh;
        private Label lblJobRole;
        private Label lblEntryDate;
        private Label lblFirstName;
        private CheckBox chkIsCoffeeDrinker;
        private ComboBox cboJobRole;
        private DateTimePicker dtpEntryDate;
        private TextBox txtFirstName;
        private Button btnSave;
        private Controls.HeaderControl headerControl1;
        private BindingSource employeeBindingSource;
    }
}
