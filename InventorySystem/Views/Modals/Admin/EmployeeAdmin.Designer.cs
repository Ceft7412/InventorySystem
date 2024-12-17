namespace InventorySystem.Views.Modals.Admin
{
    partial class EmployeeAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeAdmin));
            topbarStockInOutPanel = new Panel();
            archivedEmployeeBtn = new Button();
            label1 = new Label();
            panel1 = new Panel();
            panel5 = new Panel();
            employeeTxt = new TextBox();
            panel4 = new Panel();
            exportExcelBtn = new Button();
            archiveEmployeeBtn = new Button();
            updateEmployeeBtnRedirect = new Button();
            addEmployeeBtnRedirect = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            dataGridViewEmployees = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            topbarStockInOutPanel.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).BeginInit();
            SuspendLayout();
            // 
            // topbarStockInOutPanel
            // 
            topbarStockInOutPanel.BackColor = Color.Transparent;
            topbarStockInOutPanel.BackgroundImage = Properties.Resources.panelBackground;
            topbarStockInOutPanel.BorderStyle = BorderStyle.FixedSingle;
            topbarStockInOutPanel.Controls.Add(archivedEmployeeBtn);
            topbarStockInOutPanel.Controls.Add(label1);
            topbarStockInOutPanel.Dock = DockStyle.Top;
            topbarStockInOutPanel.Location = new Point(0, 0);
            topbarStockInOutPanel.Name = "topbarStockInOutPanel";
            topbarStockInOutPanel.Size = new Size(1665, 137);
            topbarStockInOutPanel.TabIndex = 2;
            // 
            // archivedEmployeeBtn
            // 
            archivedEmployeeBtn.Cursor = Cursors.Hand;
            archivedEmployeeBtn.FlatAppearance.BorderSize = 0;
            archivedEmployeeBtn.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            archivedEmployeeBtn.FlatStyle = FlatStyle.Flat;
            archivedEmployeeBtn.Font = new Font("Calibri", 18F);
            archivedEmployeeBtn.ForeColor = SystemColors.ButtonHighlight;
            archivedEmployeeBtn.Image = Properties.Resources.employee;
            archivedEmployeeBtn.ImageAlign = ContentAlignment.TopCenter;
            archivedEmployeeBtn.Location = new Point(218, 11);
            archivedEmployeeBtn.Name = "archivedEmployeeBtn";
            archivedEmployeeBtn.Padding = new Padding(5);
            archivedEmployeeBtn.Size = new Size(164, 109);
            archivedEmployeeBtn.TabIndex = 5;
            archivedEmployeeBtn.Text = "Archive";
            archivedEmployeeBtn.TextAlign = ContentAlignment.BottomCenter;
            archivedEmployeeBtn.TextImageRelation = TextImageRelation.ImageAboveText;
            archivedEmployeeBtn.UseVisualStyleBackColor = true;
            archivedEmployeeBtn.Click += archivedEmployeeBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 26F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(24, 50);
            label1.Name = "label1";
            label1.Size = new Size(157, 42);
            label1.TabIndex = 0;
            label1.Text = "Employee";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 137);
            panel1.Name = "panel1";
            panel1.Size = new Size(1665, 91);
            panel1.TabIndex = 3;
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
            // employeeTxt
            // 
            employeeTxt.Font = new Font("Segoe UI", 16F);
            employeeTxt.Location = new Point(25, 36);
            employeeTxt.Name = "employeeTxt";
            employeeTxt.PlaceholderText = "Search employee";
            employeeTxt.Size = new Size(335, 36);
            employeeTxt.TabIndex = 0;
            employeeTxt.TextChanged += employeeTxt_TextChanged;
            // 
            // panel4
            // 
            panel4.Controls.Add(exportExcelBtn);
            panel4.Controls.Add(archiveEmployeeBtn);
            panel4.Controls.Add(updateEmployeeBtnRedirect);
            panel4.Controls.Add(addEmployeeBtnRedirect);
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
            // archiveEmployeeBtn
            // 
            archiveEmployeeBtn.BackColor = Color.Red;
            archiveEmployeeBtn.Font = new Font("Segoe UI", 14F);
            archiveEmployeeBtn.ForeColor = SystemColors.ButtonHighlight;
            archiveEmployeeBtn.Image = Properties.Resources.archive_button_icon;
            archiveEmployeeBtn.Location = new Point(556, 19);
            archiveEmployeeBtn.Name = "archiveEmployeeBtn";
            archiveEmployeeBtn.Padding = new Padding(10, 4, 10, 4);
            archiveEmployeeBtn.Size = new Size(225, 53);
            archiveEmployeeBtn.TabIndex = 2;
            archiveEmployeeBtn.Text = "Archive Employee";
            archiveEmployeeBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            archiveEmployeeBtn.UseVisualStyleBackColor = false;
            archiveEmployeeBtn.Click += archiveEmployeeBtn_Click;
            // 
            // updateEmployeeBtnRedirect
            // 
            updateEmployeeBtnRedirect.BackColor = Color.Goldenrod;
            updateEmployeeBtnRedirect.Font = new Font("Segoe UI", 14F);
            updateEmployeeBtnRedirect.ForeColor = SystemColors.ButtonHighlight;
            updateEmployeeBtnRedirect.Image = Properties.Resources.pen;
            updateEmployeeBtnRedirect.Location = new Point(300, 19);
            updateEmployeeBtnRedirect.Name = "updateEmployeeBtnRedirect";
            updateEmployeeBtnRedirect.Padding = new Padding(10, 4, 10, 4);
            updateEmployeeBtnRedirect.Size = new Size(222, 53);
            updateEmployeeBtnRedirect.TabIndex = 1;
            updateEmployeeBtnRedirect.Text = "Update Employee";
            updateEmployeeBtnRedirect.TextImageRelation = TextImageRelation.ImageBeforeText;
            updateEmployeeBtnRedirect.UseVisualStyleBackColor = false;
            updateEmployeeBtnRedirect.Click += updateEmployeeBtnRedirect_Click;
            // 
            // addEmployeeBtnRedirect
            // 
            addEmployeeBtnRedirect.BackColor = Color.ForestGreen;
            addEmployeeBtnRedirect.Font = new Font("Segoe UI", 14F);
            addEmployeeBtnRedirect.ForeColor = SystemColors.ButtonHighlight;
            addEmployeeBtnRedirect.Image = Properties.Resources.plus;
            addEmployeeBtnRedirect.Location = new Point(70, 19);
            addEmployeeBtnRedirect.Name = "addEmployeeBtnRedirect";
            addEmployeeBtnRedirect.Padding = new Padding(10, 4, 10, 4);
            addEmployeeBtnRedirect.Size = new Size(198, 53);
            addEmployeeBtnRedirect.TabIndex = 0;
            addEmployeeBtnRedirect.Text = "Add Employee";
            addEmployeeBtnRedirect.TextImageRelation = TextImageRelation.ImageBeforeText;
            addEmployeeBtnRedirect.UseVisualStyleBackColor = false;
            addEmployeeBtnRedirect.Click += addEmployeeBtnRedirect_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 228);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(25);
            panel2.Size = new Size(1665, 600);
            panel2.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.Controls.Add(dataGridViewEmployees);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(25, 25);
            panel3.Name = "panel3";
            panel3.Size = new Size(1615, 550);
            panel3.TabIndex = 0;
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
            dataGridViewEmployees.Size = new Size(1615, 550);
            dataGridViewEmployees.TabIndex = 2;
            dataGridViewEmployees.CellClick += selectedRowCellClick;
            dataGridViewEmployees.CellContentClick += dataGridViewEmployees_CellContentClick;
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
            // EmployeeAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1665, 828);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(topbarStockInOutPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EmployeeAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin - Employee";
            Load += EmployeeAdmin_Load;
            topbarStockInOutPanel.ResumeLayout(false);
            topbarStockInOutPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel topbarStockInOutPanel;
        private Label label1;
        private Panel panel1;
        private Button addEmployeeBtnRedirect;
        private Panel panel2;
        private Panel panel3;
        private DataGridView dataGridViewEmployees;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column3;
        private Panel panel4;
        private Button updateEmployeeBtnRedirect;
        private Button archiveEmployeeBtn;
        private Button exportExcelBtn;
        private Panel panel5;
        private Button archivedEmployeeBtn;
        private TextBox employeeTxt;
    }
}