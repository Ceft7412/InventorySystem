﻿namespace InventorySystem.Views.Modals.Admin
{
    partial class LogsAdmin
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogsAdmin));
            topbarStockInOutPanel = new Panel();
            label1 = new Label();
            dataGridViewLogs = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            label2 = new Label();
            statusCmb = new ComboBox();
            logAndemployeeTxt = new TextBox();
            panel3 = new Panel();
            topbarStockInOutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLogs).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // topbarStockInOutPanel
            // 
            topbarStockInOutPanel.BackColor = Color.Transparent;
            topbarStockInOutPanel.BackgroundImage = Properties.Resources.panelBackground;
            topbarStockInOutPanel.Controls.Add(label1);
            topbarStockInOutPanel.Dock = DockStyle.Top;
            topbarStockInOutPanel.Location = new Point(0, 0);
            topbarStockInOutPanel.Name = "topbarStockInOutPanel";
            topbarStockInOutPanel.Size = new Size(1505, 79);
            topbarStockInOutPanel.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 26F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(22, 18);
            label1.Name = "label1";
            label1.Size = new Size(81, 42);
            label1.TabIndex = 0;
            label1.Text = "Logs";
            // 
            // dataGridViewLogs
            // 
            dataGridViewLogs.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 16F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewLogs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewLogs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewLogs.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewLogs.BorderStyle = BorderStyle.None;
            dataGridViewLogs.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewLogs.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.SteelBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 16F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewLogs.ColumnHeadersHeight = 70;
            dataGridViewLogs.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8 });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 16F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridViewLogs.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewLogs.Dock = DockStyle.Fill;
            dataGridViewLogs.EnableHeadersVisualStyles = false;
            dataGridViewLogs.GridColor = SystemColors.ScrollBar;
            dataGridViewLogs.Location = new Point(30, 10);
            dataGridViewLogs.Name = "dataGridViewLogs";
            dataGridViewLogs.ReadOnly = true;
            dataGridViewLogs.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 8.25F);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridViewLogs.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewLogs.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 16F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewLogs.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewLogs.RowTemplate.Height = 100;
            dataGridViewLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewLogs.Size = new Size(1445, 639);
            dataGridViewLogs.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.FillWeight = 75.5360641F;
            Column1.HeaderText = "Log ID";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.FillWeight = 149.106964F;
            Column2.HeaderText = "Time Stamp";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.FillWeight = 99.15268F;
            Column3.HeaderText = "Employee ID";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.FillWeight = 121.827423F;
            Column4.HeaderText = "Action Type";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.FillWeight = 65.85765F;
            Column5.HeaderText = "RecordID";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.FillWeight = 65.85765F;
            Column6.HeaderText = "Module";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            dataGridViewCellStyle3.Padding = new Padding(0, 0, 10, 0);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            Column7.DefaultCellStyle = dataGridViewCellStyle3;
            Column7.FillWeight = 156.80397F;
            Column7.HeaderText = "Description";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.FillWeight = 65.85765F;
            Column8.HeaderText = "Status";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(statusCmb);
            panel2.Controls.Add(logAndemployeeTxt);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 79);
            panel2.Name = "panel2";
            panel2.Size = new Size(1505, 70);
            panel2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(1078, 25);
            label2.Name = "label2";
            label2.Size = new Size(75, 30);
            label2.TabIndex = 4;
            label2.Text = "Status:";
            // 
            // statusCmb
            // 
            statusCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            statusCmb.Font = new Font("Segoe UI", 16F);
            statusCmb.FormattingEnabled = true;
            statusCmb.Items.AddRange(new object[] { "All", "Success", "Failure" });
            statusCmb.Location = new Point(1159, 20);
            statusCmb.Name = "statusCmb";
            statusCmb.Size = new Size(309, 38);
            statusCmb.TabIndex = 3;
            statusCmb.SelectedIndexChanged += statusCmb_SelectedIndexChanged;
            // 
            // logAndemployeeTxt
            // 
            logAndemployeeTxt.Font = new Font("Segoe UI", 17F);
            logAndemployeeTxt.Location = new Point(29, 17);
            logAndemployeeTxt.Name = "logAndemployeeTxt";
            logAndemployeeTxt.PlaceholderText = "Search log and employee id";
            logAndemployeeTxt.Size = new Size(335, 38);
            logAndemployeeTxt.TabIndex = 2;
            logAndemployeeTxt.TextChanged += logAndemployeeTxt_TextChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridViewLogs);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 149);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(30, 10, 30, 30);
            panel3.Size = new Size(1505, 679);
            panel3.TabIndex = 6;
            // 
            // LogsAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1505, 828);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(topbarStockInOutPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LogsAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin - Logs";
            topbarStockInOutPanel.ResumeLayout(false);
            topbarStockInOutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLogs).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel topbarStockInOutPanel;
        private Label label1;
        private DataGridView dataGridViewLogs;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private Panel panel2;
        private Panel panel3;
        private TextBox logAndemployeeTxt;
        private ComboBox statusCmb;
        private Label label2;
    }
}