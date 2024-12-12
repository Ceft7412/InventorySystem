namespace InventorySystem.Views.Modals.Admin
{
    partial class InventoryAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryAdmin));
            topbarStockInOutPanel = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            panel4 = new Panel();
            refreshData = new Button();
            panel3 = new Panel();
            label6 = new Label();
            label2 = new Label();
            supplierComboBox = new ComboBox();
            label5 = new Label();
            unitComboBox = new ComboBox();
            label3 = new Label();
            searchItemTxt = new TextBox();
            categoryComboBox = new ComboBox();
            label4 = new Label();
            panel2 = new Panel();
            dataGridViewItems = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            topbarStockInOutPanel.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItems).BeginInit();
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
            topbarStockInOutPanel.Size = new Size(1579, 99);
            topbarStockInOutPanel.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 26F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(24, 31);
            label1.Name = "label1";
            label1.Size = new Size(153, 42);
            label1.TabIndex = 0;
            label1.Text = "Inventory";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 99);
            panel1.Name = "panel1";
            panel1.Size = new Size(1579, 169);
            panel1.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(refreshData);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 102);
            panel4.Name = "panel4";
            panel4.Size = new Size(1579, 67);
            panel4.TabIndex = 23;
            // 
            // refreshData
            // 
            refreshData.Font = new Font("Segoe UI", 16F);
            refreshData.Image = Properties.Resources.refresh__1_;
            refreshData.Location = new Point(12, 8);
            refreshData.Name = "refreshData";
            refreshData.Size = new Size(140, 47);
            refreshData.TabIndex = 21;
            refreshData.Text = "Refresh";
            refreshData.TextImageRelation = TextImageRelation.ImageBeforeText;
            refreshData.UseVisualStyleBackColor = true;
            refreshData.Click += refreshData_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(supplierComboBox);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(unitComboBox);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(searchItemTxt);
            panel3.Controls.Add(categoryComboBox);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1579, 104);
            panel3.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 16F);
            label6.Location = new Point(1175, 25);
            label6.Name = "label6";
            label6.Size = new Size(56, 27);
            label6.TabIndex = 21;
            label6.Text = "Unit:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 16F);
            label2.Location = new Point(427, 25);
            label2.Name = "label2";
            label2.Size = new Size(99, 27);
            label2.TabIndex = 17;
            label2.Text = "Category:";
            // 
            // supplierComboBox
            // 
            supplierComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            supplierComboBox.Font = new Font("Calibri", 18F);
            supplierComboBox.FormattingEnabled = true;
            supplierComboBox.Location = new Point(812, 58);
            supplierComboBox.Name = "supplierComboBox";
            supplierComboBox.Size = new Size(319, 37);
            supplierComboBox.TabIndex = 15;
            supplierComboBox.SelectedIndexChanged += supplierComboBox_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 16F);
            label5.Location = new Point(12, 27);
            label5.Name = "label5";
            label5.Size = new Size(126, 27);
            label5.TabIndex = 20;
            label5.Text = "Search Item:";
            // 
            // unitComboBox
            // 
            unitComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            unitComboBox.Font = new Font("Calibri", 18F);
            unitComboBox.FormattingEnabled = true;
            unitComboBox.Location = new Point(1175, 58);
            unitComboBox.Name = "unitComboBox";
            unitComboBox.Size = new Size(141, 37);
            unitComboBox.TabIndex = 16;
            unitComboBox.SelectedIndexChanged += unitComboBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 16F);
            label3.Location = new Point(812, 25);
            label3.Name = "label3";
            label3.Size = new Size(93, 27);
            label3.TabIndex = 18;
            label3.Text = "Supplier:";
            // 
            // searchItemTxt
            // 
            searchItemTxt.Font = new Font("Calibri", 18F);
            searchItemTxt.Location = new Point(12, 60);
            searchItemTxt.Name = "searchItemTxt";
            searchItemTxt.PlaceholderText = "Search item...";
            searchItemTxt.Size = new Size(370, 37);
            searchItemTxt.TabIndex = 13;
            searchItemTxt.TextChanged += searchItemTxt_TextChanged;
            // 
            // categoryComboBox
            // 
            categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryComboBox.Font = new Font("Calibri", 18F);
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(427, 58);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(340, 37);
            categoryComboBox.TabIndex = 14;
            categoryComboBox.SelectedIndexChanged += categoryComboBox_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(1523, 30);
            label4.Name = "label4";
            label4.Size = new Size(73, 37);
            label4.TabIndex = 19;
            label4.Text = "Unit:";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(dataGridViewItems);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 268);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(30, 10, 30, 25);
            panel2.Size = new Size(1579, 493);
            panel2.TabIndex = 3;
            // 
            // dataGridViewItems
            // 
            dataGridViewItems.AllowUserToAddRows = false;
            dataGridViewItems.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewItems.BorderStyle = BorderStyle.None;
            dataGridViewItems.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Calibri", 16F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewItems.ColumnHeadersHeight = 40;
            dataGridViewItems.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 16F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewItems.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewItems.Dock = DockStyle.Fill;
            dataGridViewItems.EnableHeadersVisualStyles = false;
            dataGridViewItems.GridColor = SystemColors.ScrollBar;
            dataGridViewItems.Location = new Point(30, 10);
            dataGridViewItems.Name = "dataGridViewItems";
            dataGridViewItems.ReadOnly = true;
            dataGridViewItems.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Calibri", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewItems.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = SystemColors.ButtonHighlight;
            dataGridViewItems.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewItems.RowTemplate.Height = 30;
            dataGridViewItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewItems.Size = new Size(1519, 458);
            dataGridViewItems.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "Item Code";
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
            // Column3
            // 
            Column3.HeaderText = "Quantity";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "Unit";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 150;
            // 
            // Column5
            // 
            Column5.HeaderText = "Supplier";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 200;
            // 
            // Column6
            // 
            Column6.HeaderText = "Category";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 200;
            // 
            // Column7
            // 
            Column7.HeaderText = "Minimum Stock Level";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 250;
            // 
            // InventoryAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1579, 761);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(topbarStockInOutPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "InventoryAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin - Inventory";
            Load += InventoryAdmin_Load;
            topbarStockInOutPanel.ResumeLayout(false);
            topbarStockInOutPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewItems).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel topbarStockInOutPanel;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridViewItems;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private Label label5;
        private TextBox searchItemTxt;
        private Label label4;
        private ComboBox categoryComboBox;
        private Label label3;
        private ComboBox supplierComboBox;
        private Label label2;
        private ComboBox unitComboBox;
        private Button refreshData;
        private Panel panel3;
        private Label label6;
        private Panel panel4;
    }
}