namespace InventorySystem.Views.Modals.InventoryUser
{
    partial class SupplierModal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierModal));
            topbarStockInOutPanel = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            panel20 = new Panel();
            dataGridViewSuppliers = new DataGridView();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            panel21 = new Panel();
            label5 = new Label();
            archiveSupplierButton = new Button();
            searchSupplierBox = new TextBox();
            updateSupplierButton = new Button();
            newSupplierButton = new Button();
            exportSupplierButton = new Button();
            topbarStockInOutPanel.SuspendLayout();
            panel1.SuspendLayout();
            panel20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSuppliers).BeginInit();
            panel21.SuspendLayout();
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
            topbarStockInOutPanel.Size = new Size(1352, 99);
            topbarStockInOutPanel.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 26F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(24, 31);
            label1.Name = "label1";
            label1.Size = new Size(133, 42);
            label1.TabIndex = 0;
            label1.Text = "Supplier";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel20);
            panel1.Controls.Add(panel21);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 99);
            panel1.Name = "panel1";
            panel1.Size = new Size(1352, 662);
            panel1.TabIndex = 2;
            // 
            // panel20
            // 
            panel20.BorderStyle = BorderStyle.FixedSingle;
            panel20.Controls.Add(dataGridViewSuppliers);
            panel20.Dock = DockStyle.Fill;
            panel20.Location = new Point(0, 188);
            panel20.Name = "panel20";
            panel20.Padding = new Padding(30, 10, 30, 30);
            panel20.Size = new Size(1352, 474);
            panel20.TabIndex = 10;
            // 
            // dataGridViewSuppliers
            // 
            dataGridViewSuppliers.AllowUserToAddRows = false;
            dataGridViewSuppliers.BackgroundColor = SystemColors.Control;
            dataGridViewSuppliers.BorderStyle = BorderStyle.None;
            dataGridViewSuppliers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Calibri", 15F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewSuppliers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewSuppliers.ColumnHeadersHeight = 40;
            dataGridViewSuppliers.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, Column8 });
            dataGridViewSuppliers.Dock = DockStyle.Fill;
            dataGridViewSuppliers.EnableHeadersVisualStyles = false;
            dataGridViewSuppliers.GridColor = SystemColors.ScrollBar;
            dataGridViewSuppliers.Location = new Point(30, 10);
            dataGridViewSuppliers.Name = "dataGridViewSuppliers";
            dataGridViewSuppliers.ReadOnly = true;
            dataGridViewSuppliers.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Calibri", 30F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewSuppliers.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewSuppliers.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new Font("Calibri", 15F);
            dataGridViewSuppliers.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewSuppliers.RowTemplate.Height = 33;
            dataGridViewSuppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSuppliers.Size = new Size(1290, 432);
            dataGridViewSuppliers.TabIndex = 4;
            dataGridViewSuppliers.CellClick += supplierRowClick;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Supplier ID";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 200;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Supplier Name";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Width = 500;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Contact";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.Width = 200;
            // 
            // Column8
            // 
            Column8.HeaderText = "Address";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 200;
            // 
            // panel21
            // 
            panel21.BorderStyle = BorderStyle.FixedSingle;
            panel21.Controls.Add(label5);
            panel21.Controls.Add(archiveSupplierButton);
            panel21.Controls.Add(searchSupplierBox);
            panel21.Controls.Add(updateSupplierButton);
            panel21.Controls.Add(newSupplierButton);
            panel21.Controls.Add(exportSupplierButton);
            panel21.Dock = DockStyle.Top;
            panel21.Location = new Point(0, 0);
            panel21.Name = "panel21";
            panel21.Size = new Size(1352, 188);
            panel21.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 17F);
            label5.Location = new Point(25, 20);
            label5.Name = "label5";
            label5.Size = new Size(160, 28);
            label5.TabIndex = 13;
            label5.Text = "Search supplier:";
            // 
            // archiveSupplierButton
            // 
            archiveSupplierButton.BackColor = Color.Red;
            archiveSupplierButton.Cursor = Cursors.Hand;
            archiveSupplierButton.Font = new Font("Calibri", 14F);
            archiveSupplierButton.ForeColor = SystemColors.ButtonHighlight;
            archiveSupplierButton.Image = Properties.Resources.archive_button_icon1;
            archiveSupplierButton.Location = new Point(456, 112);
            archiveSupplierButton.Name = "archiveSupplierButton";
            archiveSupplierButton.Padding = new Padding(10, 4, 10, 4);
            archiveSupplierButton.Size = new Size(195, 53);
            archiveSupplierButton.TabIndex = 5;
            archiveSupplierButton.Text = "Archive Supplier";
            archiveSupplierButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            archiveSupplierButton.UseVisualStyleBackColor = false;
            archiveSupplierButton.Click += archiveSupplierButton_Click;
            // 
            // searchSupplierBox
            // 
            searchSupplierBox.BackColor = SystemColors.ControlLightLight;
            searchSupplierBox.Font = new Font("Calibri", 18F);
            searchSupplierBox.Location = new Point(30, 53);
            searchSupplierBox.Name = "searchSupplierBox";
            searchSupplierBox.PlaceholderText = "Supplier";
            searchSupplierBox.Size = new Size(406, 37);
            searchSupplierBox.TabIndex = 0;
            searchSupplierBox.TextChanged += searchSupplierBox_TextChanged;
            // 
            // updateSupplierButton
            // 
            updateSupplierButton.BackColor = Color.Goldenrod;
            updateSupplierButton.Cursor = Cursors.Hand;
            updateSupplierButton.Font = new Font("Calibri", 14F);
            updateSupplierButton.ForeColor = SystemColors.ButtonHighlight;
            updateSupplierButton.Image = Properties.Resources.pen;
            updateSupplierButton.Location = new Point(229, 112);
            updateSupplierButton.Name = "updateSupplierButton";
            updateSupplierButton.Padding = new Padding(10, 4, 10, 4);
            updateSupplierButton.Size = new Size(207, 53);
            updateSupplierButton.TabIndex = 4;
            updateSupplierButton.Text = "Update Supplier";
            updateSupplierButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            updateSupplierButton.UseVisualStyleBackColor = false;
            updateSupplierButton.Click += updateSupplierButton_Click;
            // 
            // newSupplierButton
            // 
            newSupplierButton.BackColor = SystemColors.MenuHighlight;
            newSupplierButton.Cursor = Cursors.Hand;
            newSupplierButton.Font = new Font("Calibri", 14F);
            newSupplierButton.ForeColor = SystemColors.ButtonHighlight;
            newSupplierButton.Image = Properties.Resources.plus;
            newSupplierButton.ImageAlign = ContentAlignment.MiddleLeft;
            newSupplierButton.Location = new Point(31, 111);
            newSupplierButton.Name = "newSupplierButton";
            newSupplierButton.Padding = new Padding(10, 4, 10, 4);
            newSupplierButton.Size = new Size(181, 53);
            newSupplierButton.TabIndex = 2;
            newSupplierButton.Text = "New Supplier";
            newSupplierButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            newSupplierButton.UseVisualStyleBackColor = false;
            newSupplierButton.Click += newSupplierButton_Click;
            // 
            // exportSupplierButton
            // 
            exportSupplierButton.BackColor = Color.FromArgb(64, 64, 64);
            exportSupplierButton.Cursor = Cursors.Hand;
            exportSupplierButton.Font = new Font("Calibri", 14F);
            exportSupplierButton.ForeColor = SystemColors.ButtonHighlight;
            exportSupplierButton.Image = Properties.Resources.upload;
            exportSupplierButton.Location = new Point(671, 112);
            exportSupplierButton.Name = "exportSupplierButton";
            exportSupplierButton.Padding = new Padding(10, 4, 10, 4);
            exportSupplierButton.Size = new Size(181, 53);
            exportSupplierButton.TabIndex = 3;
            exportSupplierButton.Text = "Export Excel";
            exportSupplierButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            exportSupplierButton.UseVisualStyleBackColor = false;
            exportSupplierButton.Click += exportSupplierButton_Click;
            // 
            // SupplierModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1352, 761);
            Controls.Add(panel1);
            Controls.Add(topbarStockInOutPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SupplierModal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory - Supplier";
            topbarStockInOutPanel.ResumeLayout(false);
            topbarStockInOutPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel20.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewSuppliers).EndInit();
            panel21.ResumeLayout(false);
            panel21.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel topbarStockInOutPanel;
        private Label label1;
        private Panel panel1;
        private Panel panel20;
        private DataGridView dataGridViewSuppliers;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn Column8;
        private TextBox searchSupplierBox;
        private Panel panel21;
        private Button archiveSupplierButton;
        private Button updateSupplierButton;
        private Button newSupplierButton;
        private Button exportSupplierButton;
        private Label label5;
    }
}