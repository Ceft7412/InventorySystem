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
            topbarStockInOutPanel = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            addEmployeeBtnRedirect = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            dataGridViewEmployees = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            topbarStockInOutPanel.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployees).BeginInit();
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
            topbarStockInOutPanel.Size = new Size(1112, 99);
            topbarStockInOutPanel.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 26F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(24, 31);
            label1.Name = "label1";
            label1.Size = new Size(166, 40);
            label1.TabIndex = 0;
            label1.Text = "Employee";
            // 
            // panel1
            // 
            panel1.Controls.Add(addEmployeeBtnRedirect);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 99);
            panel1.Name = "panel1";
            panel1.Size = new Size(1112, 97);
            panel1.TabIndex = 3;
            // 
            // addEmployeeBtnRedirect
            // 
            addEmployeeBtnRedirect.BackColor = Color.ForestGreen;
            addEmployeeBtnRedirect.Font = new Font("Segoe UI", 14F);
            addEmployeeBtnRedirect.ForeColor = SystemColors.ButtonHighlight;
            addEmployeeBtnRedirect.Location = new Point(902, 23);
            addEmployeeBtnRedirect.Name = "addEmployeeBtnRedirect";
            addEmployeeBtnRedirect.Size = new Size(185, 52);
            addEmployeeBtnRedirect.TabIndex = 0;
            addEmployeeBtnRedirect.Text = "Add Employee";
            addEmployeeBtnRedirect.UseVisualStyleBackColor = false;
            addEmployeeBtnRedirect.Click += addEmployeeBtnRedirect_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 196);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(25);
            panel2.Size = new Size(1112, 765);
            panel2.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.Controls.Add(dataGridViewEmployees);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(25, 25);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(10, 0, 10, 10);
            panel3.Size = new Size(1062, 715);
            panel3.TabIndex = 0;
            // 
            // dataGridViewEmployees
            // 
            dataGridViewEmployees.AllowUserToAddRows = false;
            dataGridViewEmployees.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewEmployees.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new Font("Arial", 16F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewEmployees.ColumnHeadersHeight = 40;
            dataGridViewEmployees.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column4, Column3 });
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
            dataGridViewEmployees.Location = new Point(10, 0);
            dataGridViewEmployees.Name = "dataGridViewEmployees";
            dataGridViewEmployees.ReadOnly = true;
            dataGridViewEmployees.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewEmployees.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = SystemColors.ButtonHighlight;
            dataGridViewEmployees.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewEmployees.RowTemplate.Height = 30;
            dataGridViewEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewEmployees.Size = new Size(1042, 705);
            dataGridViewEmployees.TabIndex = 2;
            dataGridViewEmployees.CellContentClick += dataGridViewEmployees_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Employee ID";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 200;
            // 
            // Column2
            // 
            Column2.HeaderText = "Name";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 250;
            // 
            // Column4
            // 
            Column4.HeaderText = "Contact";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 230;
            // 
            // Column3
            // 
            Column3.HeaderText = "Address";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 220;
            // 
            // EmployeeAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 961);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(topbarStockInOutPanel);
            Name = "EmployeeAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin - Employee";
            Load += EmployeeAdmin_Load;
            topbarStockInOutPanel.ResumeLayout(false);
            topbarStockInOutPanel.PerformLayout();
            panel1.ResumeLayout(false);
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
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column3;
    }
}