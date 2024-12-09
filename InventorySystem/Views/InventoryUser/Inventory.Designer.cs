namespace InventorySystem
{
    partial class Inventory
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            navigationPanel = new Panel();
            logoutNavigationButton = new Button();
            settingsNavigationButton = new Button();
            archiveNavigationButton = new Button();
            supplierNavigationButton = new Button();
            stockInOutNavigationButton = new Button();
            label1 = new Label();
            companyLogo = new PictureBox();
            searchItemTxt = new TextBox();
            categoryComboBox = new ComboBox();
            supplierComboBox = new ComboBox();
            unitComboBox = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            refreshData = new Button();
            label5 = new Label();
            exportItemsButton = new Button();
            archiveItemButton = new Button();
            updateItemButton = new Button();
            addItemButton = new Button();
            panel2 = new Panel();
            dataGridViewItems = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            navigationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)companyLogo).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItems).BeginInit();
            SuspendLayout();
            // 
            // navigationPanel
            // 
            navigationPanel.BackgroundImage = Properties.Resources.navigationBackground;
            navigationPanel.BorderStyle = BorderStyle.FixedSingle;
            navigationPanel.Controls.Add(logoutNavigationButton);
            navigationPanel.Controls.Add(settingsNavigationButton);
            navigationPanel.Controls.Add(archiveNavigationButton);
            navigationPanel.Controls.Add(supplierNavigationButton);
            navigationPanel.Controls.Add(stockInOutNavigationButton);
            navigationPanel.Controls.Add(label1);
            navigationPanel.Controls.Add(companyLogo);
            navigationPanel.Dock = DockStyle.Top;
            navigationPanel.Location = new Point(0, 0);
            navigationPanel.Name = "navigationPanel";
            navigationPanel.Size = new Size(1604, 170);
            navigationPanel.TabIndex = 0;
            // 
            // logoutNavigationButton
            // 
            logoutNavigationButton.BackColor = Color.Transparent;
            logoutNavigationButton.Cursor = Cursors.Hand;
            logoutNavigationButton.FlatAppearance.BorderSize = 0;
            logoutNavigationButton.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            logoutNavigationButton.FlatStyle = FlatStyle.Flat;
            logoutNavigationButton.Font = new Font("Segoe UI", 16F);
            logoutNavigationButton.ForeColor = SystemColors.ButtonHighlight;
            logoutNavigationButton.Image = Properties.Resources.LogoutIcon;
            logoutNavigationButton.ImageAlign = ContentAlignment.TopCenter;
            logoutNavigationButton.Location = new Point(870, 25);
            logoutNavigationButton.Name = "logoutNavigationButton";
            logoutNavigationButton.Size = new Size(146, 131);
            logoutNavigationButton.TabIndex = 6;
            logoutNavigationButton.Text = "Logout";
            logoutNavigationButton.TextAlign = ContentAlignment.BottomCenter;
            logoutNavigationButton.TextImageRelation = TextImageRelation.ImageAboveText;
            logoutNavigationButton.UseVisualStyleBackColor = false;
            logoutNavigationButton.Click += logoutNavigationButton_Click;
            // 
            // settingsNavigationButton
            // 
            settingsNavigationButton.BackColor = Color.Transparent;
            settingsNavigationButton.Cursor = Cursors.Hand;
            settingsNavigationButton.FlatAppearance.BorderSize = 0;
            settingsNavigationButton.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            settingsNavigationButton.FlatStyle = FlatStyle.Flat;
            settingsNavigationButton.Font = new Font("Segoe UI", 16F);
            settingsNavigationButton.ForeColor = SystemColors.ButtonHighlight;
            settingsNavigationButton.Image = Properties.Resources.SettingsIcon;
            settingsNavigationButton.ImageAlign = ContentAlignment.TopCenter;
            settingsNavigationButton.Location = new Point(709, 25);
            settingsNavigationButton.Name = "settingsNavigationButton";
            settingsNavigationButton.Size = new Size(146, 131);
            settingsNavigationButton.TabIndex = 5;
            settingsNavigationButton.Text = "Settings";
            settingsNavigationButton.TextAlign = ContentAlignment.BottomCenter;
            settingsNavigationButton.TextImageRelation = TextImageRelation.ImageAboveText;
            settingsNavigationButton.UseVisualStyleBackColor = false;
            settingsNavigationButton.Click += settingsNavigationButton_Click;
            // 
            // archiveNavigationButton
            // 
            archiveNavigationButton.BackColor = Color.Transparent;
            archiveNavigationButton.Cursor = Cursors.Hand;
            archiveNavigationButton.FlatAppearance.BorderSize = 0;
            archiveNavigationButton.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            archiveNavigationButton.FlatStyle = FlatStyle.Flat;
            archiveNavigationButton.Font = new Font("Segoe UI", 16F);
            archiveNavigationButton.ForeColor = SystemColors.ButtonHighlight;
            archiveNavigationButton.Image = Properties.Resources.ArchiveIcon;
            archiveNavigationButton.ImageAlign = ContentAlignment.TopCenter;
            archiveNavigationButton.Location = new Point(557, 25);
            archiveNavigationButton.Name = "archiveNavigationButton";
            archiveNavigationButton.Size = new Size(146, 131);
            archiveNavigationButton.TabIndex = 4;
            archiveNavigationButton.Text = "Archive";
            archiveNavigationButton.TextAlign = ContentAlignment.BottomCenter;
            archiveNavigationButton.TextImageRelation = TextImageRelation.ImageAboveText;
            archiveNavigationButton.UseVisualStyleBackColor = false;
            archiveNavigationButton.Click += archiveNavigationButton_Click;
            // 
            // supplierNavigationButton
            // 
            supplierNavigationButton.BackColor = Color.Transparent;
            supplierNavigationButton.Cursor = Cursors.Hand;
            supplierNavigationButton.FlatAppearance.BorderSize = 0;
            supplierNavigationButton.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            supplierNavigationButton.FlatStyle = FlatStyle.Flat;
            supplierNavigationButton.Font = new Font("Segoe UI", 16F);
            supplierNavigationButton.ForeColor = SystemColors.ButtonHighlight;
            supplierNavigationButton.Image = Properties.Resources.SupplierIcon;
            supplierNavigationButton.ImageAlign = ContentAlignment.TopCenter;
            supplierNavigationButton.Location = new Point(405, 25);
            supplierNavigationButton.Name = "supplierNavigationButton";
            supplierNavigationButton.Size = new Size(146, 131);
            supplierNavigationButton.TabIndex = 3;
            supplierNavigationButton.Text = "Supplier";
            supplierNavigationButton.TextAlign = ContentAlignment.BottomCenter;
            supplierNavigationButton.TextImageRelation = TextImageRelation.ImageAboveText;
            supplierNavigationButton.UseVisualStyleBackColor = false;
            supplierNavigationButton.Click += supplierNavigationButton_Click;
            // 
            // stockInOutNavigationButton
            // 
            stockInOutNavigationButton.BackColor = Color.Transparent;
            stockInOutNavigationButton.Cursor = Cursors.Hand;
            stockInOutNavigationButton.FlatAppearance.BorderSize = 0;
            stockInOutNavigationButton.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            stockInOutNavigationButton.FlatStyle = FlatStyle.Flat;
            stockInOutNavigationButton.Font = new Font("Segoe UI", 16F);
            stockInOutNavigationButton.ForeColor = SystemColors.ButtonHighlight;
            stockInOutNavigationButton.Image = Properties.Resources.StockInOutIcon__1_;
            stockInOutNavigationButton.ImageAlign = ContentAlignment.TopCenter;
            stockInOutNavigationButton.Location = new Point(253, 25);
            stockInOutNavigationButton.Name = "stockInOutNavigationButton";
            stockInOutNavigationButton.Size = new Size(146, 131);
            stockInOutNavigationButton.TabIndex = 2;
            stockInOutNavigationButton.Text = "Stock In/Out";
            stockInOutNavigationButton.TextAlign = ContentAlignment.BottomCenter;
            stockInOutNavigationButton.TextImageRelation = TextImageRelation.ImageAboveText;
            stockInOutNavigationButton.UseVisualStyleBackColor = false;
            stockInOutNavigationButton.Click += stockInOutNavigationButton_Click;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(229, 12);
            label1.Name = "label1";
            label1.Size = new Size(1, 144);
            label1.TabIndex = 1;
            // 
            // companyLogo
            // 
            companyLogo.Image = Properties.Resources.company_logo;
            companyLogo.Location = new Point(21, 12);
            companyLogo.Name = "companyLogo";
            companyLogo.Size = new Size(176, 144);
            companyLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            companyLogo.TabIndex = 0;
            companyLogo.TabStop = false;
            // 
            // searchItemTxt
            // 
            searchItemTxt.Font = new Font("Segoe UI", 16F);
            searchItemTxt.Location = new Point(20, 58);
            searchItemTxt.Name = "searchItemTxt";
            searchItemTxt.PlaceholderText = "Search item...";
            searchItemTxt.Size = new Size(400, 36);
            searchItemTxt.TabIndex = 1;
            searchItemTxt.TextChanged += searchItemTxt_TextChanged;
            // 
            // categoryComboBox
            // 
            categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryComboBox.Font = new Font("Segoe UI", 16F);
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(461, 56);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(306, 38);
            categoryComboBox.TabIndex = 2;
            categoryComboBox.SelectedIndexChanged += categoryComboBox_SelectedIndexChanged;
            // 
            // supplierComboBox
            // 
            supplierComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            supplierComboBox.Font = new Font("Segoe UI", 16F);
            supplierComboBox.FormattingEnabled = true;
            supplierComboBox.Location = new Point(818, 56);
            supplierComboBox.Name = "supplierComboBox";
            supplierComboBox.Size = new Size(325, 38);
            supplierComboBox.TabIndex = 3;
            supplierComboBox.SelectedIndexChanged += supplierComboBox_SelectedIndexChanged;
            // 
            // unitComboBox
            // 
            unitComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            unitComboBox.Font = new Font("Segoe UI", 16F);
            unitComboBox.FormattingEnabled = true;
            unitComboBox.Location = new Point(1194, 56);
            unitComboBox.Name = "unitComboBox";
            unitComboBox.Size = new Size(163, 38);
            unitComboBox.TabIndex = 4;
            unitComboBox.SelectedIndexChanged += unitComboBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(461, 20);
            label2.Name = "label2";
            label2.Size = new Size(107, 30);
            label2.TabIndex = 5;
            label2.Text = "Category:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(818, 25);
            label3.Name = "label3";
            label3.Size = new Size(98, 30);
            label3.TabIndex = 6;
            label3.Text = "Supplier:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(1194, 25);
            label4.Name = "label4";
            label4.Size = new Size(57, 30);
            label4.TabIndex = 7;
            label4.Text = "Unit:";
            // 
            // panel1
            // 
            panel1.Controls.Add(refreshData);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(searchItemTxt);
            panel1.Controls.Add(exportItemsButton);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(categoryComboBox);
            panel1.Controls.Add(archiveItemButton);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(updateItemButton);
            panel1.Controls.Add(supplierComboBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(addItemButton);
            panel1.Controls.Add(unitComboBox);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 170);
            panel1.Name = "panel1";
            panel1.Size = new Size(1604, 258);
            panel1.TabIndex = 8;
            // 
            // refreshData
            // 
            refreshData.Font = new Font("Segoe UI", 16F);
            refreshData.Location = new Point(20, 113);
            refreshData.Name = "refreshData";
            refreshData.Size = new Size(123, 47);
            refreshData.TabIndex = 22;
            refreshData.Text = "Refresh";
            refreshData.UseVisualStyleBackColor = true;
            refreshData.Click += refreshData_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F);
            label5.Location = new Point(20, 25);
            label5.Name = "label5";
            label5.Size = new Size(133, 30);
            label5.TabIndex = 12;
            label5.Text = "Search Item:";
            // 
            // exportItemsButton
            // 
            exportItemsButton.BackColor = Color.ForestGreen;
            exportItemsButton.Font = new Font("Segoe UI", 14F);
            exportItemsButton.ForeColor = SystemColors.ButtonHighlight;
            exportItemsButton.Location = new Point(547, 184);
            exportItemsButton.Name = "exportItemsButton";
            exportItemsButton.Size = new Size(142, 55);
            exportItemsButton.TabIndex = 11;
            exportItemsButton.Text = "Export Excel";
            exportItemsButton.UseVisualStyleBackColor = false;
            exportItemsButton.Click += exportItemsButton_Click;
            // 
            // archiveItemButton
            // 
            archiveItemButton.BackColor = Color.Red;
            archiveItemButton.Font = new Font("Segoe UI", 14F);
            archiveItemButton.ForeColor = SystemColors.ButtonHighlight;
            archiveItemButton.Location = new Point(368, 182);
            archiveItemButton.Name = "archiveItemButton";
            archiveItemButton.Size = new Size(142, 57);
            archiveItemButton.TabIndex = 10;
            archiveItemButton.Text = "Archive Item";
            archiveItemButton.UseVisualStyleBackColor = false;
            archiveItemButton.Click += archiveItemButton_Click;
            // 
            // updateItemButton
            // 
            updateItemButton.BackColor = Color.DarkGoldenrod;
            updateItemButton.Font = new Font("Segoe UI", 14F);
            updateItemButton.ForeColor = SystemColors.ButtonHighlight;
            updateItemButton.Location = new Point(190, 180);
            updateItemButton.Name = "updateItemButton";
            updateItemButton.Size = new Size(142, 59);
            updateItemButton.TabIndex = 9;
            updateItemButton.Text = "Update Item";
            updateItemButton.UseVisualStyleBackColor = false;
            updateItemButton.Click += updateItemButton_Click;
            // 
            // addItemButton
            // 
            addItemButton.BackColor = Color.ForestGreen;
            addItemButton.Font = new Font("Segoe UI", 14F);
            addItemButton.ForeColor = SystemColors.ButtonHighlight;
            addItemButton.Location = new Point(20, 180);
            addItemButton.Name = "addItemButton";
            addItemButton.Size = new Size(142, 59);
            addItemButton.TabIndex = 8;
            addItemButton.Text = "Add Item";
            addItemButton.UseVisualStyleBackColor = false;
            addItemButton.Click += addItemButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridViewItems);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 428);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(20, 0, 20, 10);
            panel2.Size = new Size(1604, 380);
            panel2.TabIndex = 9;
            // 
            // dataGridViewItems
            // 
            dataGridViewItems.AllowUserToAddRows = false;
            dataGridViewItems.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewItems.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new Font("Arial", 16F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
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
            dataGridViewItems.Location = new Point(20, 0);
            dataGridViewItems.Name = "dataGridViewItems";
            dataGridViewItems.ReadOnly = true;
            dataGridViewItems.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewItems.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = SystemColors.ButtonHighlight;
            dataGridViewItems.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewItems.Size = new Size(1564, 370);
            dataGridViewItems.TabIndex = 0;
            dataGridViewItems.CellClick += SelectedItemCodeRowClick;
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
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1604, 808);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(navigationPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Inventory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory";
            WindowState = FormWindowState.Maximized;
            FormClosing += Inventory_FormClosing;
            FormClosed += Inventory_FormClosed;
            navigationPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)companyLogo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewItems).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel navigationPanel;
        private PictureBox companyLogo;
        private Label label1;
        private Button stockInOutNavigationButton;
        private Button supplierNavigationButton;
        private Button archiveNavigationButton;
        private Button settingsNavigationButton;
        private Button logoutNavigationButton;
        private TextBox searchItemTxt;
        private ComboBox categoryComboBox;
        private ComboBox supplierComboBox;
        private ComboBox unitComboBox;
        private Label label2;
        private Label label3;
        private Label label4;
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
        private Button archiveItemButton;
        private Button updateItemButton;
        private Button addItemButton;
        private Button exportItemsButton;
        private Label label5;
        private Button refreshData;
    }
}
