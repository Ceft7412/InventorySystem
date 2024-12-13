namespace InventorySystem.Views.Modals.InventoryUser
{
    partial class UpdateItemModal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateItemModal));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            updateItemSupplierInput = new ComboBox();
            label6 = new Label();
            updateItemUnitInput = new ComboBox();
            updateMinimumStockLevelInput = new TextBox();
            label5 = new Label();
            label3 = new Label();
            updateItemCategoryInput = new TextBox();
            label4 = new Label();
            cancelUpdateItemButton = new Button();
            updateItemButton = new Button();
            updateItemCodeInput = new TextBox();
            label2 = new Label();
            updateItemDescriptionInput = new TextBox();
            label7 = new Label();
            updateItemIdInput = new TextBox();
            label8 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.panelBackground1;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(598, 78);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 20F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(37, 25);
            label1.Name = "label1";
            label1.Size = new Size(152, 33);
            label1.TabIndex = 0;
            label1.Text = "Update Item";
            // 
            // panel2
            // 
            panel2.Controls.Add(updateItemIdInput);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(updateItemSupplierInput);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(updateItemUnitInput);
            panel2.Controls.Add(updateMinimumStockLevelInput);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(updateItemCategoryInput);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(cancelUpdateItemButton);
            panel2.Controls.Add(updateItemButton);
            panel2.Controls.Add(updateItemCodeInput);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(updateItemDescriptionInput);
            panel2.Controls.Add(label7);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 78);
            panel2.Name = "panel2";
            panel2.Size = new Size(598, 631);
            panel2.TabIndex = 4;
            // 
            // updateItemSupplierInput
            // 
            updateItemSupplierInput.DropDownStyle = ComboBoxStyle.DropDownList;
            updateItemSupplierInput.Font = new Font("Calibri", 17F);
            updateItemSupplierInput.FormattingEnabled = true;
            updateItemSupplierInput.Location = new Point(40, 397);
            updateItemSupplierInput.Name = "updateItemSupplierInput";
            updateItemSupplierInput.Size = new Size(514, 36);
            updateItemSupplierInput.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 18F);
            label6.Location = new Point(38, 277);
            label6.Name = "label6";
            label6.Size = new Size(55, 29);
            label6.TabIndex = 15;
            label6.Text = "Unit";
            // 
            // updateItemUnitInput
            // 
            updateItemUnitInput.DropDownStyle = ComboBoxStyle.DropDownList;
            updateItemUnitInput.Font = new Font("Calibri", 17F);
            updateItemUnitInput.FormattingEnabled = true;
            updateItemUnitInput.Items.AddRange(new object[] { "PCS", "FT", "SETS", "UNITS", "MTRS", "ROLLS", "PC", "DOZEN", "LEGNTH", "BOXES" });
            updateItemUnitInput.Location = new Point(38, 312);
            updateItemUnitInput.Name = "updateItemUnitInput";
            updateItemUnitInput.Size = new Size(516, 36);
            updateItemUnitInput.TabIndex = 14;
            // 
            // updateMinimumStockLevelInput
            // 
            updateMinimumStockLevelInput.Font = new Font("Calibri", 17F);
            updateMinimumStockLevelInput.Location = new Point(38, 481);
            updateMinimumStockLevelInput.Name = "updateMinimumStockLevelInput";
            updateMinimumStockLevelInput.Size = new Size(516, 35);
            updateMinimumStockLevelInput.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 18F);
            label5.Location = new Point(38, 446);
            label5.Name = "label5";
            label5.Size = new Size(224, 29);
            label5.TabIndex = 12;
            label5.Text = "Minimum Stock Level";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 18F);
            label3.Location = new Point(38, 362);
            label3.Name = "label3";
            label3.Size = new Size(145, 29);
            label3.TabIndex = 10;
            label3.Text = "Item Supplier";
            // 
            // updateItemCategoryInput
            // 
            updateItemCategoryInput.Font = new Font("Calibri", 17F);
            updateItemCategoryInput.Location = new Point(38, 224);
            updateItemCategoryInput.Name = "updateItemCategoryInput";
            updateItemCategoryInput.Size = new Size(516, 35);
            updateItemCategoryInput.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 18F);
            label4.Location = new Point(38, 189);
            label4.Name = "label4";
            label4.Size = new Size(151, 29);
            label4.TabIndex = 8;
            label4.Text = "Item Category";
            // 
            // cancelUpdateItemButton
            // 
            cancelUpdateItemButton.BackColor = Color.Firebrick;
            cancelUpdateItemButton.Cursor = Cursors.Hand;
            cancelUpdateItemButton.FlatStyle = FlatStyle.Flat;
            cancelUpdateItemButton.Font = new Font("Calibri", 15F);
            cancelUpdateItemButton.ForeColor = SystemColors.ButtonHighlight;
            cancelUpdateItemButton.Location = new Point(248, 550);
            cancelUpdateItemButton.Name = "cancelUpdateItemButton";
            cancelUpdateItemButton.Size = new Size(142, 54);
            cancelUpdateItemButton.TabIndex = 7;
            cancelUpdateItemButton.Text = "CANCEL";
            cancelUpdateItemButton.UseVisualStyleBackColor = false;
            cancelUpdateItemButton.Click += cancelUpdateItemButton_Click;
            // 
            // updateItemButton
            // 
            updateItemButton.BackColor = Color.SeaGreen;
            updateItemButton.Cursor = Cursors.Hand;
            updateItemButton.FlatStyle = FlatStyle.Flat;
            updateItemButton.Font = new Font("Calibri", 15F);
            updateItemButton.ForeColor = SystemColors.ButtonHighlight;
            updateItemButton.Location = new Point(408, 550);
            updateItemButton.Name = "updateItemButton";
            updateItemButton.Size = new Size(142, 54);
            updateItemButton.TabIndex = 6;
            updateItemButton.Text = "UPDATE";
            updateItemButton.UseVisualStyleBackColor = false;
            updateItemButton.Click += updateItemButton_Click;
            // 
            // updateItemCodeInput
            // 
            updateItemCodeInput.Font = new Font("Calibri", 17F);
            updateItemCodeInput.Location = new Point(316, 55);
            updateItemCodeInput.Name = "updateItemCodeInput";
            updateItemCodeInput.ReadOnly = true;
            updateItemCodeInput.Size = new Size(238, 35);
            updateItemCodeInput.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 18F);
            label2.Location = new Point(316, 20);
            label2.Name = "label2";
            label2.Size = new Size(114, 29);
            label2.TabIndex = 2;
            label2.Text = "Item Code";
            // 
            // updateItemDescriptionInput
            // 
            updateItemDescriptionInput.Font = new Font("Calibri", 17F);
            updateItemDescriptionInput.Location = new Point(38, 144);
            updateItemDescriptionInput.Name = "updateItemDescriptionInput";
            updateItemDescriptionInput.Size = new Size(516, 35);
            updateItemDescriptionInput.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 18F);
            label7.Location = new Point(38, 109);
            label7.Name = "label7";
            label7.Size = new Size(175, 29);
            label7.TabIndex = 0;
            label7.Text = "Item Description";
            // 
            // updateItemIdInput
            // 
            updateItemIdInput.Font = new Font("Calibri", 17F);
            updateItemIdInput.Location = new Point(40, 55);
            updateItemIdInput.Name = "updateItemIdInput";
            updateItemIdInput.ReadOnly = true;
            updateItemIdInput.Size = new Size(238, 35);
            updateItemIdInput.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 18F);
            label8.Location = new Point(40, 20);
            label8.Name = "label8";
            label8.Size = new Size(84, 29);
            label8.TabIndex = 17;
            label8.Text = "Item ID";
            // 
            // UpdateItemModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 709);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UpdateItemModal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory - Update Item";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private ComboBox updateItemSupplierInput;
        private Label label6;
        private ComboBox updateItemUnitInput;
        private TextBox updateMinimumStockLevelInput;
        private Label label5;
        private Label label3;
        private TextBox updateItemCategoryInput;
        private Label label4;
        private Button cancelUpdateItemButton;
        private Button updateItemButton;
        private TextBox updateItemCodeInput;
        private Label label2;
        private TextBox updateItemDescriptionInput;
        private Label label7;
        private TextBox updateItemIdInput;
        private Label label8;
    }
}