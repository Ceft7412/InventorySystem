namespace InventorySystem.Views.Modals.Admin
{
    partial class ArchiveEmployeeAdmin
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArchiveEmployeeAdmin));
            panel1 = new Panel();
            panel2 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            dataGridViewEmployees = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            exportExcelBtn = new Button();
            unarchiveEmployeeBtn = new Button();
            topbarStockInOutPanel = new Panel();
            label1 = new Label();
            employeeTxt = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).BeginInit();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            topbarStockInOutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(topbarStockInOutPanel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1665, 828);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(1665, 748);
            panel2.TabIndex = 4;
            // 
            // panel6
            // 
            panel6.BackColor = SystemColors.ControlLight;
            panel6.Controls.Add(panel7);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 91);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(25);
            panel6.Size = new Size(1665, 657);
            panel6.TabIndex = 5;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ButtonHighlight;
            panel7.Controls.Add(dataGridViewEmployees);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(25, 25);
            panel7.Name = "panel7";
            panel7.Size = new Size(1615, 607);
            panel7.TabIndex = 0;
            // 
            // dataGridViewEmployees
            // 
            dataGridViewEmployees.AllowUserToAddRows = false;
            dataGridViewEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEmployees.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewEmployees.BorderStyle = BorderStyle.None;
            dataGridViewEmployees.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Calibri", 16F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewEmployees.ColumnHeadersHeight = 40;
            dataGridViewEmployees.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column5, Column4, Column3 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 16F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewEmployees.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewEmployees.Dock = DockStyle.Fill;
            dataGridViewEmployees.EnableHeadersVisualStyles = false;
            dataGridViewEmployees.GridColor = SystemColors.ScrollBar;
            dataGridViewEmployees.Location = new Point(0, 0);
            dataGridViewEmployees.Name = "dataGridViewEmployees";
            dataGridViewEmployees.ReadOnly = true;
            dataGridViewEmployees.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Calibri", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewEmployees.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewEmployees.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = SystemColors.ButtonHighlight;
            dataGridViewEmployees.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewEmployees.RowTemplate.Height = 30;
            dataGridViewEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEmployees.Size = new Size(1615, 607);
            dataGridViewEmployees.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.HeaderText = "Employee ID";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Name";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Username";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Contact";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Address";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1665, 91);
            panel3.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.Control;
            panel5.Controls.Add(employeeTxt);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(615, 91);
            panel5.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(exportExcelBtn);
            panel4.Controls.Add(unarchiveEmployeeBtn);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(615, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1050, 91);
            panel4.TabIndex = 1;
            // 
            // exportExcelBtn
            // 
            exportExcelBtn.BackColor = Color.FromArgb(64, 64, 64);
            exportExcelBtn.Font = new Font("Segoe UI", 14F);
            exportExcelBtn.ForeColor = SystemColors.ButtonHighlight;
            exportExcelBtn.Image = Properties.Resources.upload;
            exportExcelBtn.Location = new Point(811, 19);
            exportExcelBtn.Name = "exportExcelBtn";
            exportExcelBtn.Padding = new Padding(10, 4, 10, 4);
            exportExcelBtn.Size = new Size(214, 53);
            exportExcelBtn.TabIndex = 3;
            exportExcelBtn.Text = "Export Employee";
            exportExcelBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            exportExcelBtn.UseVisualStyleBackColor = false;
            exportExcelBtn.Click += exportExcelBtn_Click;
            // 
            // unarchiveEmployeeBtn
            // 
            unarchiveEmployeeBtn.BackColor = Color.Red;
            unarchiveEmployeeBtn.Font = new Font("Segoe UI", 14F);
            unarchiveEmployeeBtn.ForeColor = SystemColors.ButtonHighlight;
            unarchiveEmployeeBtn.Image = Properties.Resources.archive_button_icon;
            unarchiveEmployeeBtn.Location = new Point(522, 19);
            unarchiveEmployeeBtn.Name = "unarchiveEmployeeBtn";
            unarchiveEmployeeBtn.Padding = new Padding(10, 4, 10, 4);
            unarchiveEmployeeBtn.Size = new Size(259, 53);
            unarchiveEmployeeBtn.TabIndex = 2;
            unarchiveEmployeeBtn.Text = "Unarchive Employee";
            unarchiveEmployeeBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            unarchiveEmployeeBtn.UseVisualStyleBackColor = false;
            unarchiveEmployeeBtn.Click += unarchiveEmployeeBtn_Click;
            // 
            // topbarStockInOutPanel
            // 
            topbarStockInOutPanel.BackColor = Color.Transparent;
            topbarStockInOutPanel.BackgroundImage = Properties.Resources.panelBackground;
            topbarStockInOutPanel.BorderStyle = BorderStyle.FixedSingle;
            topbarStockInOutPanel.Controls.Add(label1);
            topbarStockInOutPanel.Dock = DockStyle.Top;
            topbarStockInOutPanel.Location = new Point(0, 0);
            topbarStockInOutPanel.Name = "topbarStockInOutPanel";
            topbarStockInOutPanel.Size = new Size(1665, 80);
            topbarStockInOutPanel.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 26F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(11, 18);
            label1.Name = "label1";
            label1.Size = new Size(123, 42);
            label1.TabIndex = 0;
            label1.Text = "Archive";
            // 
            // employeeTxt
            // 
            employeeTxt.Font = new Font("Segoe UI", 16F);
            employeeTxt.Location = new Point(25, 26);
            employeeTxt.Name = "employeeTxt";
            employeeTxt.PlaceholderText = "Search employee";
            employeeTxt.Size = new Size(335, 36);
            employeeTxt.TabIndex = 1;
            employeeTxt.TextChanged += employeeTxt_TextChanged;
            // 
            // ArchiveEmployeeAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1665, 828);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ArchiveEmployeeAdmin";
            Text = "Employee - Archive";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).EndInit();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            topbarStockInOutPanel.ResumeLayout(false);
            topbarStockInOutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel topbarStockInOutPanel;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel5;
        private Panel panel4;
        private Button exportExcelBtn;
        private Button unarchiveEmployeeBtn;
        private Panel panel6;
        private Panel panel7;
        private DataGridView dataGridViewEmployees;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column3;
        private TextBox employeeTxt;
    }
}