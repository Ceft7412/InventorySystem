﻿namespace InventorySystem.Views.Modals.Admin
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            topbarStockInOutPanel = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            searchItemTxt = new TextBox();
            label4 = new Label();
            categoryComboBox = new ComboBox();
            label3 = new Label();
            supplierComboBox = new ComboBox();
            label2 = new Label();
            unitComboBox = new ComboBox();
            panel2 = new Panel();
            dataGridViewItems = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            refreshData = new Button();
            topbarStockInOutPanel.SuspendLayout();
            panel1.SuspendLayout();
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
            topbarStockInOutPanel.Size = new Size(1887, 99);
            topbarStockInOutPanel.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 26F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(24, 31);
            label1.Name = "label1";
            label1.Size = new Size(156, 40);
            label1.TabIndex = 0;
            label1.Text = "Inventory";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(refreshData);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(searchItemTxt);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(categoryComboBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(supplierComboBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(unitComboBox);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 99);
            panel1.Name = "panel1";
            panel1.Size = new Size(1887, 205);
            panel1.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F);
            label5.Location = new Point(16, 30);
            label5.Name = "label5";
            label5.Size = new Size(161, 37);
            label5.TabIndex = 20;
            label5.Text = "Search Item:";
            // 
            // searchItemTxt
            // 
            searchItemTxt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            searchItemTxt.Font = new Font("Segoe UI", 22F);
            searchItemTxt.Location = new Point(24, 70);
            searchItemTxt.Name = "searchItemTxt";
            searchItemTxt.PlaceholderText = "Search item...";
            searchItemTxt.Size = new Size(542, 47);
            searchItemTxt.TabIndex = 13;
            searchItemTxt.TextChanged += searchItemTxt_TextChanged;
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
            // categoryComboBox
            // 
            categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryComboBox.Font = new Font("Segoe UI", 20F);
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(619, 70);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(408, 45);
            categoryComboBox.TabIndex = 14;
            categoryComboBox.SelectedIndexChanged += categoryComboBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(1062, 30);
            label3.Name = "label3";
            label3.Size = new Size(121, 37);
            label3.TabIndex = 18;
            label3.Text = "Supplier:";
            // 
            // supplierComboBox
            // 
            supplierComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            supplierComboBox.Font = new Font("Segoe UI", 20F);
            supplierComboBox.FormattingEnabled = true;
            supplierComboBox.Location = new Point(1072, 68);
            supplierComboBox.Name = "supplierComboBox";
            supplierComboBox.Size = new Size(408, 45);
            supplierComboBox.TabIndex = 15;
            supplierComboBox.SelectedIndexChanged += supplierComboBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(610, 30);
            label2.Name = "label2";
            label2.Size = new Size(131, 37);
            label2.TabIndex = 17;
            label2.Text = "Category:";
            // 
            // unitComboBox
            // 
            unitComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            unitComboBox.Font = new Font("Segoe UI", 20F);
            unitComboBox.FormattingEnabled = true;
            unitComboBox.Location = new Point(1528, 68);
            unitComboBox.Name = "unitComboBox";
            unitComboBox.Size = new Size(321, 45);
            unitComboBox.TabIndex = 16;
            unitComboBox.SelectedIndexChanged += unitComboBox_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(dataGridViewItems);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 304);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(30, 10, 30, 10);
            panel2.Size = new Size(1887, 657);
            panel2.TabIndex = 3;
            // 
            // dataGridViewItems
            // 
            dataGridViewItems.AllowUserToAddRows = false;
            dataGridViewItems.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewItems.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.ControlLight;
            dataGridViewCellStyle7.Font = new Font("Arial", 16F);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridViewItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewItems.ColumnHeadersHeight = 40;
            dataGridViewItems.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 16F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataGridViewItems.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewItems.Dock = DockStyle.Fill;
            dataGridViewItems.EnableHeadersVisualStyles = false;
            dataGridViewItems.Location = new Point(30, 10);
            dataGridViewItems.Name = "dataGridViewItems";
            dataGridViewItems.ReadOnly = true;
            dataGridViewItems.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewItems.RowHeadersVisible = false;
            dataGridViewCellStyle9.BackColor = SystemColors.ButtonHighlight;
            dataGridViewItems.RowsDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewItems.RowTemplate.Height = 30;
            dataGridViewItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewItems.Size = new Size(1827, 637);
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
            // refreshData
            // 
            refreshData.Font = new Font("Segoe UI", 16F);
            refreshData.Location = new Point(24, 140);
            refreshData.Name = "refreshData";
            refreshData.Size = new Size(123, 47);
            refreshData.TabIndex = 21;
            refreshData.Text = "Refresh";
            refreshData.UseVisualStyleBackColor = true;
            refreshData.Click += refreshData_Click;
            // 
            // InventoryAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1887, 961);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(topbarStockInOutPanel);
            Name = "InventoryAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin - Inventory";
            Load += InventoryAdmin_Load;
            topbarStockInOutPanel.ResumeLayout(false);
            topbarStockInOutPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
    }
}