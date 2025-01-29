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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            navigationPanel = new Panel();
            panel3 = new Panel();
            notificationBtn = new PictureBox();
            logoutNavigationButton = new Button();
            settingsNavigationButton = new Button();
            archiveNavigationButton = new Button();
            supplierNavigationButton = new Button();
            stockInOutNavigationButton = new Button();
            companyLogo = new PictureBox();
            searchItemTxt = new TextBox();
            categoryComboBox = new ComboBox();
            supplierComboBox = new ComboBox();
            unitComboBox = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            importExcelBtn = new Button();
            refreshData = new Button();
            label5 = new Label();
            exportItemsButton = new Button();
            archiveItemButton = new Button();
            updateItemButton = new Button();
            addItemButton = new Button();
            panel2 = new Panel();
            dataGridViewItems = new DataGridView();
            Column8 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            navigationPanel.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)notificationBtn).BeginInit();
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
            navigationPanel.Controls.Add(panel3);
            navigationPanel.Controls.Add(logoutNavigationButton);
            navigationPanel.Controls.Add(settingsNavigationButton);
            navigationPanel.Controls.Add(archiveNavigationButton);
            navigationPanel.Controls.Add(supplierNavigationButton);
            navigationPanel.Controls.Add(stockInOutNavigationButton);
            navigationPanel.Controls.Add(companyLogo);
            navigationPanel.Dock = DockStyle.Top;
            navigationPanel.Location = new Point(0, 0);
            navigationPanel.Name = "navigationPanel";
            navigationPanel.Size = new Size(1604, 146);
            navigationPanel.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(notificationBtn);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(1364, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(238, 144);
            panel3.TabIndex = 9;
            // 
            // notificationBtn
            // 
            notificationBtn.Anchor = AnchorStyles.Top;
            notificationBtn.BackColor = Color.Transparent;
            notificationBtn.Cursor = Cursors.Hand;
            notificationBtn.Image = Properties.Resources.bell__1_;
            notificationBtn.Location = new Point(155, 40);
            notificationBtn.Name = "notificationBtn";
            notificationBtn.Size = new Size(64, 64);
            notificationBtn.SizeMode = PictureBoxSizeMode.AutoSize;
            notificationBtn.TabIndex = 7;
            notificationBtn.TabStop = false;
            notificationBtn.Visible = false;
            notificationBtn.Click += notificationBtn_Click;
            // 
            // logoutNavigationButton
            // 
            logoutNavigationButton.BackColor = Color.Transparent;
            logoutNavigationButton.Cursor = Cursors.Hand;
            logoutNavigationButton.FlatAppearance.BorderSize = 0;
            logoutNavigationButton.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            logoutNavigationButton.FlatStyle = FlatStyle.Flat;
            logoutNavigationButton.Font = new Font("Calibri", 18F);
            logoutNavigationButton.ForeColor = SystemColors.ButtonHighlight;
            logoutNavigationButton.Image = Properties.Resources.logout;
            logoutNavigationButton.ImageAlign = ContentAlignment.TopCenter;
            logoutNavigationButton.Location = new Point(835, 30);
            logoutNavigationButton.Name = "logoutNavigationButton";
            logoutNavigationButton.Size = new Size(139, 102);
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
            settingsNavigationButton.Font = new Font("Calibri", 18F);
            settingsNavigationButton.ForeColor = SystemColors.ButtonHighlight;
            settingsNavigationButton.Image = Properties.Resources.settings__2_;
            settingsNavigationButton.ImageAlign = ContentAlignment.TopCenter;
            settingsNavigationButton.Location = new Point(674, 30);
            settingsNavigationButton.Name = "settingsNavigationButton";
            settingsNavigationButton.Size = new Size(146, 102);
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
            archiveNavigationButton.Font = new Font("Calibri", 18F);
            archiveNavigationButton.ForeColor = SystemColors.ButtonHighlight;
            archiveNavigationButton.Image = Properties.Resources.file;
            archiveNavigationButton.ImageAlign = ContentAlignment.TopCenter;
            archiveNavigationButton.Location = new Point(522, 30);
            archiveNavigationButton.Name = "archiveNavigationButton";
            archiveNavigationButton.Size = new Size(146, 102);
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
            supplierNavigationButton.Font = new Font("Calibri", 18F);
            supplierNavigationButton.ForeColor = SystemColors.ButtonHighlight;
            supplierNavigationButton.Image = Properties.Resources.supplier;
            supplierNavigationButton.ImageAlign = ContentAlignment.TopCenter;
            supplierNavigationButton.Location = new Point(370, 30);
            supplierNavigationButton.Name = "supplierNavigationButton";
            supplierNavigationButton.Size = new Size(146, 102);
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
            stockInOutNavigationButton.Font = new Font("Calibri", 18F);
            stockInOutNavigationButton.ForeColor = SystemColors.ButtonHighlight;
            stockInOutNavigationButton.Image = Properties.Resources.transaction;
            stockInOutNavigationButton.ImageAlign = ContentAlignment.TopCenter;
            stockInOutNavigationButton.Location = new Point(203, 30);
            stockInOutNavigationButton.Name = "stockInOutNavigationButton";
            stockInOutNavigationButton.Size = new Size(146, 102);
            stockInOutNavigationButton.TabIndex = 2;
            stockInOutNavigationButton.Text = "Stock In/Out";
            stockInOutNavigationButton.TextAlign = ContentAlignment.BottomCenter;
            stockInOutNavigationButton.TextImageRelation = TextImageRelation.ImageAboveText;
            stockInOutNavigationButton.UseVisualStyleBackColor = false;
            stockInOutNavigationButton.Click += stockInOutNavigationButton_Click;
            // 
            // companyLogo
            // 
            companyLogo.Image = Properties.Resources.company_logo;
            companyLogo.Location = new Point(21, 12);
            companyLogo.Name = "companyLogo";
            companyLogo.Size = new Size(148, 120);
            companyLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            companyLogo.TabIndex = 0;
            companyLogo.TabStop = false;
            // 
            // searchItemTxt
            // 
            searchItemTxt.Font = new Font("Calibri", 18F);
            searchItemTxt.Location = new Point(20, 56);
            searchItemTxt.Name = "searchItemTxt";
            searchItemTxt.PlaceholderText = "Search item...";
            searchItemTxt.Size = new Size(400, 37);
            searchItemTxt.TabIndex = 1;
            searchItemTxt.TextChanged += searchItemTxt_TextChanged;
            // 
            // categoryComboBox
            // 
            categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryComboBox.Font = new Font("Calibri", 18F);
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(461, 56);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(306, 37);
            categoryComboBox.TabIndex = 2;
            categoryComboBox.SelectedIndexChanged += categoryComboBox_SelectedIndexChanged;
            // 
            // supplierComboBox
            // 
            supplierComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            supplierComboBox.Font = new Font("Calibri", 18F);
            supplierComboBox.FormattingEnabled = true;
            supplierComboBox.Location = new Point(818, 56);
            supplierComboBox.Name = "supplierComboBox";
            supplierComboBox.Size = new Size(325, 37);
            supplierComboBox.TabIndex = 3;
            supplierComboBox.SelectedIndexChanged += supplierComboBox_SelectedIndexChanged;
            // 
            // unitComboBox
            // 
            unitComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            unitComboBox.Font = new Font("Calibri", 18F);
            unitComboBox.FormattingEnabled = true;
            unitComboBox.Location = new Point(1194, 56);
            unitComboBox.Name = "unitComboBox";
            unitComboBox.Size = new Size(163, 37);
            unitComboBox.TabIndex = 4;
            unitComboBox.SelectedIndexChanged += unitComboBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 16F);
            label2.Location = new Point(461, 26);
            label2.Name = "label2";
            label2.Size = new Size(99, 27);
            label2.TabIndex = 5;
            label2.Text = "Category:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 16F);
            label3.Location = new Point(836, 26);
            label3.Name = "label3";
            label3.Size = new Size(93, 27);
            label3.TabIndex = 6;
            label3.Text = "Supplier:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 16F);
            label4.Location = new Point(1194, 26);
            label4.Name = "label4";
            label4.Size = new Size(56, 27);
            label4.TabIndex = 7;
            label4.Text = "Unit:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(importExcelBtn);
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
            panel1.Location = new Point(0, 146);
            panel1.Name = "panel1";
            panel1.Size = new Size(1604, 192);
            panel1.TabIndex = 8;
            // 
            // importExcelBtn
            // 
            importExcelBtn.BackColor = Color.FromArgb(64, 64, 64);
            importExcelBtn.Font = new Font("Calibri", 14F);
            importExcelBtn.ForeColor = SystemColors.ButtonHighlight;
            importExcelBtn.Image = Properties.Resources.import__2_;
            importExcelBtn.ImageAlign = ContentAlignment.MiddleLeft;
            importExcelBtn.Location = new Point(892, 121);
            importExcelBtn.Name = "importExcelBtn";
            importExcelBtn.Padding = new Padding(10, 4, 10, 4);
            importExcelBtn.Size = new Size(181, 55);
            importExcelBtn.TabIndex = 23;
            importExcelBtn.Text = "Import Items";
            importExcelBtn.TextAlign = ContentAlignment.MiddleRight;
            importExcelBtn.UseVisualStyleBackColor = false;
            importExcelBtn.Click += importExcelBtn_Click;
            // 
            // refreshData
            // 
            refreshData.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            refreshData.BackColor = SystemColors.ButtonHighlight;
            refreshData.Font = new Font("Calibri", 16F);
            refreshData.Image = Properties.Resources.refresh__1_;
            refreshData.ImageAlign = ContentAlignment.MiddleLeft;
            refreshData.Location = new Point(1434, 120);
            refreshData.Name = "refreshData";
            refreshData.Padding = new Padding(10, 4, 10, 4);
            refreshData.Size = new Size(150, 53);
            refreshData.TabIndex = 22;
            refreshData.Text = "Refresh";
            refreshData.TextImageRelation = TextImageRelation.ImageBeforeText;
            refreshData.UseVisualStyleBackColor = false;
            refreshData.Click += refreshData_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 16F);
            label5.Location = new Point(20, 25);
            label5.Name = "label5";
            label5.Size = new Size(126, 27);
            label5.TabIndex = 12;
            label5.Text = "Search Item:";
            // 
            // exportItemsButton
            // 
            exportItemsButton.BackColor = Color.FromArgb(64, 64, 64);
            exportItemsButton.Font = new Font("Calibri", 14F);
            exportItemsButton.ForeColor = SystemColors.ButtonHighlight;
            exportItemsButton.Image = Properties.Resources.upload;
            exportItemsButton.ImageAlign = ContentAlignment.MiddleLeft;
            exportItemsButton.Location = new Point(675, 120);
            exportItemsButton.Name = "exportItemsButton";
            exportItemsButton.Padding = new Padding(10, 4, 10, 4);
            exportItemsButton.Size = new Size(181, 56);
            exportItemsButton.TabIndex = 11;
            exportItemsButton.Text = "Export Items";
            exportItemsButton.TextAlign = ContentAlignment.MiddleRight;
            exportItemsButton.UseVisualStyleBackColor = false;
            exportItemsButton.Click += exportItemsButton_Click;
            // 
            // archiveItemButton
            // 
            archiveItemButton.BackColor = Color.Red;
            archiveItemButton.Font = new Font("Calibri", 14F);
            archiveItemButton.ForeColor = SystemColors.ButtonHighlight;
            archiveItemButton.Image = Properties.Resources.archive_button_icon;
            archiveItemButton.ImageAlign = ContentAlignment.MiddleLeft;
            archiveItemButton.Location = new Point(461, 120);
            archiveItemButton.Name = "archiveItemButton";
            archiveItemButton.Padding = new Padding(10, 4, 10, 4);
            archiveItemButton.Size = new Size(181, 56);
            archiveItemButton.TabIndex = 10;
            archiveItemButton.Text = "Archive Item";
            archiveItemButton.TextAlign = ContentAlignment.MiddleRight;
            archiveItemButton.UseVisualStyleBackColor = false;
            archiveItemButton.Click += archiveItemButton_Click;
            // 
            // updateItemButton
            // 
            updateItemButton.BackColor = Color.DarkGoldenrod;
            updateItemButton.Font = new Font("Calibri", 14F);
            updateItemButton.ForeColor = SystemColors.ButtonHighlight;
            updateItemButton.Image = Properties.Resources.pen;
            updateItemButton.ImageAlign = ContentAlignment.MiddleLeft;
            updateItemButton.Location = new Point(239, 121);
            updateItemButton.Name = "updateItemButton";
            updateItemButton.Padding = new Padding(10, 4, 10, 4);
            updateItemButton.Size = new Size(181, 54);
            updateItemButton.TabIndex = 9;
            updateItemButton.Text = "Update Item";
            updateItemButton.TextAlign = ContentAlignment.MiddleRight;
            updateItemButton.UseVisualStyleBackColor = false;
            updateItemButton.Click += updateItemButton_Click;
            // 
            // addItemButton
            // 
            addItemButton.BackColor = Color.ForestGreen;
            addItemButton.Font = new Font("Calibri", 14F);
            addItemButton.ForeColor = SystemColors.ButtonHighlight;
            addItemButton.Image = Properties.Resources.plus;
            addItemButton.ImageAlign = ContentAlignment.MiddleLeft;
            addItemButton.Location = new Point(22, 120);
            addItemButton.Name = "addItemButton";
            addItemButton.Padding = new Padding(10, 4, 10, 4);
            addItemButton.Size = new Size(181, 53);
            addItemButton.TabIndex = 8;
            addItemButton.Text = "Add Item";
            addItemButton.UseVisualStyleBackColor = false;
            addItemButton.Click += addItemButton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.Controls.Add(dataGridViewItems);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 338);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(20, 0, 20, 30);
            panel2.Size = new Size(1604, 470);
            panel2.TabIndex = 9;
            // 
            // dataGridViewItems
            // 
            dataGridViewItems.AllowUserToAddRows = false;
            dataGridViewItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewItems.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewItems.BorderStyle = BorderStyle.None;
            dataGridViewItems.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Calibri", 18F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewItems.ColumnHeadersHeight = 65;
            dataGridViewItems.Columns.AddRange(new DataGridViewColumn[] { Column8, Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Calibri", 16F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewItems.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewItems.Dock = DockStyle.Fill;
            dataGridViewItems.EnableHeadersVisualStyles = false;
            dataGridViewItems.GridColor = SystemColors.ScrollBar;
            dataGridViewItems.Location = new Point(20, 0);
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
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewItems.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewItems.RowTemplate.Height = 33;
            dataGridViewItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewItems.Size = new Size(1564, 440);
            dataGridViewItems.TabIndex = 0;
            dataGridViewItems.CellClick += SelectedItemCodeRowClick;
            // 
            // Column8
            // 
            Column8.HeaderText = "Item ID";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "Item Code";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Name";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Quantity";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Unit";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Supplier";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "Category";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.HeaderText = "Minimum Stock Level";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
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
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)notificationBtn).EndInit();
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
        private Button archiveItemButton;
        private Button updateItemButton;
        private Button addItemButton;
        private Button exportItemsButton;
        private Label label5;
        private Button refreshData;
        private Button importExcelBtn;
        private PictureBox notificationBtn;
        private Panel panel3;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}
