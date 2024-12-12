namespace InventorySystem.Views.Modals.InventoryUser
{
    partial class ArchiveModal
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArchiveModal));
            topbarStockInOutPanel = new Panel();
            label1 = new Label();
            panel25 = new Panel();
            archivePanelsComboBox = new ComboBox();
            archiveComboBox = new ComboBox();
            archiveSearchSupplierId = new TextBox();
            archiveSearchByItemCode = new TextBox();
            panel1 = new Panel();
            unarchiveSupplierButton = new Button();
            unarchiveProductButton = new Button();
            archivePanels = new Panel();
            productmaterialArchivePanel = new Panel();
            dataGridViewProductArchive = new DataGridView();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn15 = new DataGridViewTextBoxColumn();
            supplierArchivePanel = new Panel();
            dataGridViewArchiveSupplier = new DataGridView();
            dataGridViewTextBoxColumn16 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn17 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn18 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn19 = new DataGridViewTextBoxColumn();
            topbarStockInOutPanel.SuspendLayout();
            panel25.SuspendLayout();
            panel1.SuspendLayout();
            archivePanels.SuspendLayout();
            productmaterialArchivePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductArchive).BeginInit();
            supplierArchivePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewArchiveSupplier).BeginInit();
            SuspendLayout();
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
            topbarStockInOutPanel.Size = new Size(1565, 99);
            topbarStockInOutPanel.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 26F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(24, 31);
            label1.Name = "label1";
            label1.Size = new Size(123, 42);
            label1.TabIndex = 0;
            label1.Text = "Archive";
            // 
            // panel25
            // 
            panel25.BackColor = SystemColors.Control;
            panel25.BorderStyle = BorderStyle.FixedSingle;
            panel25.Controls.Add(archivePanelsComboBox);
            panel25.Controls.Add(archiveComboBox);
            panel25.Controls.Add(archiveSearchSupplierId);
            panel25.Controls.Add(archiveSearchByItemCode);
            panel25.Dock = DockStyle.Top;
            panel25.Location = new Point(0, 99);
            panel25.Name = "panel25";
            panel25.Size = new Size(1565, 76);
            panel25.TabIndex = 4;
            // 
            // archivePanelsComboBox
            // 
            archivePanelsComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            archivePanelsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            archivePanelsComboBox.Font = new Font("Calibri", 18F);
            archivePanelsComboBox.FormattingEnabled = true;
            archivePanelsComboBox.Items.AddRange(new object[] { "Items/Materials", "Suppliers" });
            archivePanelsComboBox.Location = new Point(1199, 19);
            archivePanelsComboBox.Name = "archivePanelsComboBox";
            archivePanelsComboBox.Size = new Size(334, 37);
            archivePanelsComboBox.TabIndex = 3;
            archivePanelsComboBox.SelectedIndexChanged += archivePanelsComboBox_SelectedIndexChanged;
            // 
            // archiveComboBox
            // 
            archiveComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            archiveComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            archiveComboBox.Font = new Font("Segoe UI", 25F);
            archiveComboBox.FormattingEnabled = true;
            archiveComboBox.Items.AddRange(new object[] { "Product/Materials", "Suppliers" });
            archiveComboBox.Location = new Point(2679, 12);
            archiveComboBox.Name = "archiveComboBox";
            archiveComboBox.Size = new Size(334, 53);
            archiveComboBox.TabIndex = 0;
            // 
            // archiveSearchSupplierId
            // 
            archiveSearchSupplierId.Font = new Font("Calibri", 18F);
            archiveSearchSupplierId.Location = new Point(30, 19);
            archiveSearchSupplierId.Name = "archiveSearchSupplierId";
            archiveSearchSupplierId.PlaceholderText = "Supplier Id";
            archiveSearchSupplierId.Size = new Size(338, 37);
            archiveSearchSupplierId.TabIndex = 2;
            archiveSearchSupplierId.Visible = false;
            archiveSearchSupplierId.TextChanged += archiveSearchSupplierId_TextChanged;
            // 
            // archiveSearchByItemCode
            // 
            archiveSearchByItemCode.Font = new Font("Calibri", 18F);
            archiveSearchByItemCode.Location = new Point(30, 19);
            archiveSearchByItemCode.Name = "archiveSearchByItemCode";
            archiveSearchByItemCode.PlaceholderText = "Item code";
            archiveSearchByItemCode.Size = new Size(338, 37);
            archiveSearchByItemCode.TabIndex = 1;
            archiveSearchByItemCode.TextChanged += archiveSearchByItemCode_TextChanged;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(unarchiveSupplierButton);
            panel1.Controls.Add(unarchiveProductButton);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 676);
            panel1.Name = "panel1";
            panel1.Size = new Size(1565, 85);
            panel1.TabIndex = 7;
            // 
            // unarchiveSupplierButton
            // 
            unarchiveSupplierButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            unarchiveSupplierButton.BackColor = Color.ForestGreen;
            unarchiveSupplierButton.FlatStyle = FlatStyle.Flat;
            unarchiveSupplierButton.Font = new Font("Segoe UI", 14F);
            unarchiveSupplierButton.ForeColor = SystemColors.ButtonHighlight;
            unarchiveSupplierButton.Image = Properties.Resources.file__2_;
            unarchiveSupplierButton.Location = new Point(1333, 13);
            unarchiveSupplierButton.Name = "unarchiveSupplierButton";
            unarchiveSupplierButton.Padding = new Padding(10, 4, 10, 4);
            unarchiveSupplierButton.Size = new Size(200, 59);
            unarchiveSupplierButton.TabIndex = 3;
            unarchiveSupplierButton.Text = "Set to Active";
            unarchiveSupplierButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            unarchiveSupplierButton.UseVisualStyleBackColor = false;
            unarchiveSupplierButton.Visible = false;
            unarchiveSupplierButton.Click += unarchiveSupplierButton_Click;
            // 
            // unarchiveProductButton
            // 
            unarchiveProductButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            unarchiveProductButton.BackColor = Color.ForestGreen;
            unarchiveProductButton.FlatStyle = FlatStyle.Flat;
            unarchiveProductButton.Font = new Font("Segoe UI", 14F);
            unarchiveProductButton.ForeColor = SystemColors.ButtonHighlight;
            unarchiveProductButton.Image = Properties.Resources.file__2_;
            unarchiveProductButton.Location = new Point(1333, 13);
            unarchiveProductButton.Name = "unarchiveProductButton";
            unarchiveProductButton.Padding = new Padding(10, 4, 10, 4);
            unarchiveProductButton.Size = new Size(199, 59);
            unarchiveProductButton.TabIndex = 2;
            unarchiveProductButton.Text = "Set to Active";
            unarchiveProductButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            unarchiveProductButton.UseVisualStyleBackColor = false;
            unarchiveProductButton.Click += unarchiveProductButton_Click;
            // 
            // archivePanels
            // 
            archivePanels.Controls.Add(productmaterialArchivePanel);
            archivePanels.Controls.Add(supplierArchivePanel);
            archivePanels.Dock = DockStyle.Fill;
            archivePanels.Location = new Point(0, 175);
            archivePanels.Name = "archivePanels";
            archivePanels.Size = new Size(1565, 501);
            archivePanels.TabIndex = 8;
            // 
            // productmaterialArchivePanel
            // 
            productmaterialArchivePanel.Controls.Add(dataGridViewProductArchive);
            productmaterialArchivePanel.Dock = DockStyle.Fill;
            productmaterialArchivePanel.Location = new Point(0, 0);
            productmaterialArchivePanel.Name = "productmaterialArchivePanel";
            productmaterialArchivePanel.Padding = new Padding(30, 10, 30, 30);
            productmaterialArchivePanel.Size = new Size(1565, 501);
            productmaterialArchivePanel.TabIndex = 3;
            // 
            // dataGridViewProductArchive
            // 
            dataGridViewProductArchive.AllowUserToAddRows = false;
            dataGridViewProductArchive.BackgroundColor = SystemColors.Control;
            dataGridViewProductArchive.BorderStyle = BorderStyle.None;
            dataGridViewProductArchive.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 15F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewProductArchive.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewProductArchive.ColumnHeadersHeight = 40;
            dataGridViewProductArchive.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11, dataGridViewTextBoxColumn12, dataGridViewTextBoxColumn13, dataGridViewTextBoxColumn15 });
            dataGridViewProductArchive.Dock = DockStyle.Fill;
            dataGridViewProductArchive.EnableHeadersVisualStyles = false;
            dataGridViewProductArchive.GridColor = SystemColors.ScrollBar;
            dataGridViewProductArchive.Location = new Point(30, 10);
            dataGridViewProductArchive.Name = "dataGridViewProductArchive";
            dataGridViewProductArchive.ReadOnly = true;
            dataGridViewProductArchive.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Arial", 30F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewProductArchive.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewProductArchive.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 15F);
            dataGridViewProductArchive.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewProductArchive.RowTemplate.Height = 33;
            dataGridViewProductArchive.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProductArchive.Size = new Size(1505, 461);
            dataGridViewProductArchive.TabIndex = 4;
            dataGridViewProductArchive.CellClick += rowArchiveItemCodeClick;
            dataGridViewProductArchive.CellContentClick += dataGridViewProductArchive_CellContentClick_1;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Item Code";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.HeaderText = "Description";
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            dataGridViewTextBoxColumn9.Width = 500;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.HeaderText = "Quantity";
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.HeaderText = "Unit";
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.HeaderText = "Supplier";
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            dataGridViewTextBoxColumn12.ReadOnly = true;
            dataGridViewTextBoxColumn12.Width = 200;
            // 
            // dataGridViewTextBoxColumn13
            // 
            dataGridViewTextBoxColumn13.HeaderText = "Category";
            dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            dataGridViewTextBoxColumn13.ReadOnly = true;
            dataGridViewTextBoxColumn13.Width = 150;
            // 
            // dataGridViewTextBoxColumn15
            // 
            dataGridViewTextBoxColumn15.HeaderText = "Minimum Stock Level";
            dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            dataGridViewTextBoxColumn15.ReadOnly = true;
            dataGridViewTextBoxColumn15.Width = 250;
            // 
            // supplierArchivePanel
            // 
            supplierArchivePanel.Controls.Add(dataGridViewArchiveSupplier);
            supplierArchivePanel.Dock = DockStyle.Fill;
            supplierArchivePanel.Location = new Point(0, 0);
            supplierArchivePanel.Name = "supplierArchivePanel";
            supplierArchivePanel.Padding = new Padding(30, 10, 30, 10);
            supplierArchivePanel.Size = new Size(1565, 501);
            supplierArchivePanel.TabIndex = 2;
            supplierArchivePanel.Visible = false;
            // 
            // dataGridViewArchiveSupplier
            // 
            dataGridViewArchiveSupplier.AllowUserToAddRows = false;
            dataGridViewArchiveSupplier.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewArchiveSupplier.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.ControlLight;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 15F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewArchiveSupplier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewArchiveSupplier.ColumnHeadersHeight = 40;
            dataGridViewArchiveSupplier.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn16, dataGridViewTextBoxColumn17, dataGridViewTextBoxColumn18, dataGridViewTextBoxColumn19 });
            dataGridViewArchiveSupplier.Dock = DockStyle.Fill;
            dataGridViewArchiveSupplier.EnableHeadersVisualStyles = false;
            dataGridViewArchiveSupplier.Location = new Point(30, 10);
            dataGridViewArchiveSupplier.Name = "dataGridViewArchiveSupplier";
            dataGridViewArchiveSupplier.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 30F);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridViewArchiveSupplier.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewArchiveSupplier.RowHeadersVisible = false;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 15F);
            dataGridViewArchiveSupplier.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewArchiveSupplier.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewArchiveSupplier.Size = new Size(1505, 481);
            dataGridViewArchiveSupplier.TabIndex = 5;
            dataGridViewArchiveSupplier.CellClick += rowArchiveSupplierClick;
            // 
            // dataGridViewTextBoxColumn16
            // 
            dataGridViewTextBoxColumn16.HeaderText = "Supplier ID";
            dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            dataGridViewTextBoxColumn16.ReadOnly = true;
            dataGridViewTextBoxColumn16.Width = 200;
            // 
            // dataGridViewTextBoxColumn17
            // 
            dataGridViewTextBoxColumn17.HeaderText = "Supplier Name";
            dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            dataGridViewTextBoxColumn17.ReadOnly = true;
            dataGridViewTextBoxColumn17.Width = 500;
            // 
            // dataGridViewTextBoxColumn18
            // 
            dataGridViewTextBoxColumn18.HeaderText = "Contact";
            dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            dataGridViewTextBoxColumn18.ReadOnly = true;
            dataGridViewTextBoxColumn18.Width = 200;
            // 
            // dataGridViewTextBoxColumn19
            // 
            dataGridViewTextBoxColumn19.HeaderText = "Address";
            dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            dataGridViewTextBoxColumn19.ReadOnly = true;
            dataGridViewTextBoxColumn19.Width = 200;
            // 
            // ArchiveModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1565, 761);
            Controls.Add(archivePanels);
            Controls.Add(panel1);
            Controls.Add(panel25);
            Controls.Add(topbarStockInOutPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ArchiveModal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory - Archive";
            topbarStockInOutPanel.ResumeLayout(false);
            topbarStockInOutPanel.PerformLayout();
            panel25.ResumeLayout(false);
            panel25.PerformLayout();
            panel1.ResumeLayout(false);
            archivePanels.ResumeLayout(false);
            productmaterialArchivePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductArchive).EndInit();
            supplierArchivePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewArchiveSupplier).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel topbarStockInOutPanel;
        private Label label1;
        private Panel panel25;
        private ComboBox archiveComboBox;
        private TextBox archiveSearchByItemCode;
        private TextBox archiveSearchSupplierId;
        private ComboBox archivePanelsComboBox;
        private Panel panel1;
        private Panel archivePanels;
        private Panel supplierArchivePanel;
        private DataGridView dataGridViewArchiveSupplier;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private Panel productmaterialArchivePanel;
        private DataGridView dataGridViewProductArchive;
        private Button unarchiveProductButton;
        private Button unarchiveSupplierButton;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
    }
}