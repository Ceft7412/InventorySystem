﻿namespace InventorySystem.Views.Modals.InventoryUser
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
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(40, 22);
            label1.Name = "label1";
            label1.Size = new Size(165, 37);
            label1.TabIndex = 0;
            label1.Text = "Update Item";
            // 
            // panel2
            // 
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
            updateItemSupplierInput.Font = new Font("Segoe UI", 13F);
            updateItemSupplierInput.FormattingEnabled = true;
            updateItemSupplierInput.Location = new Point(40, 397);
            updateItemSupplierInput.Name = "updateItemSupplierInput";
            updateItemSupplierInput.Size = new Size(514, 31);
            updateItemSupplierInput.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(38, 277);
            label6.Name = "label6";
            label6.Size = new Size(58, 32);
            label6.TabIndex = 15;
            label6.Text = "Unit";
            // 
            // updateItemUnitInput
            // 
            updateItemUnitInput.DropDownStyle = ComboBoxStyle.DropDownList;
            updateItemUnitInput.Font = new Font("Segoe UI", 13F);
            updateItemUnitInput.FormattingEnabled = true;
            updateItemUnitInput.Items.AddRange(new object[] { "PCS", "FT", "SETS", "UNITS", "MTRS", "ROLLS", "PC", "DOZEN", "LEGNTH", "BOXES" });
            updateItemUnitInput.Location = new Point(38, 312);
            updateItemUnitInput.Name = "updateItemUnitInput";
            updateItemUnitInput.Size = new Size(516, 31);
            updateItemUnitInput.TabIndex = 14;
            // 
            // updateMinimumStockLevelInput
            // 
            updateMinimumStockLevelInput.Font = new Font("Segoe UI", 13F);
            updateMinimumStockLevelInput.Location = new Point(38, 481);
            updateMinimumStockLevelInput.Name = "updateMinimumStockLevelInput";
            updateMinimumStockLevelInput.Size = new Size(516, 31);
            updateMinimumStockLevelInput.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(38, 446);
            label5.Name = "label5";
            label5.Size = new Size(244, 32);
            label5.TabIndex = 12;
            label5.Text = "Minimum Stock Level";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(38, 362);
            label3.Name = "label3";
            label3.Size = new Size(157, 32);
            label3.TabIndex = 10;
            label3.Text = "Item Supplier";
            // 
            // updateItemCategoryInput
            // 
            updateItemCategoryInput.Font = new Font("Segoe UI", 13F);
            updateItemCategoryInput.Location = new Point(38, 224);
            updateItemCategoryInput.Name = "updateItemCategoryInput";
            updateItemCategoryInput.Size = new Size(516, 31);
            updateItemCategoryInput.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(38, 189);
            label4.Name = "label4";
            label4.Size = new Size(165, 32);
            label4.TabIndex = 8;
            label4.Text = "Item Category";
            // 
            // cancelUpdateItemButton
            // 
            cancelUpdateItemButton.BackColor = Color.Firebrick;
            cancelUpdateItemButton.Cursor = Cursors.Hand;
            cancelUpdateItemButton.FlatStyle = FlatStyle.Flat;
            cancelUpdateItemButton.Font = new Font("Segoe UI", 15F);
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
            updateItemButton.Font = new Font("Segoe UI", 15F);
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
            updateItemCodeInput.Font = new Font("Segoe UI", 13F);
            updateItemCodeInput.Location = new Point(38, 56);
            updateItemCodeInput.Name = "updateItemCodeInput";
            updateItemCodeInput.ReadOnly = true;
            updateItemCodeInput.Size = new Size(516, 31);
            updateItemCodeInput.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(38, 21);
            label2.Name = "label2";
            label2.Size = new Size(125, 32);
            label2.TabIndex = 2;
            label2.Text = "Item Code";
            // 
            // updateItemDescriptionInput
            // 
            updateItemDescriptionInput.Font = new Font("Segoe UI", 13F);
            updateItemDescriptionInput.Location = new Point(38, 144);
            updateItemDescriptionInput.Name = "updateItemDescriptionInput";
            updateItemDescriptionInput.Size = new Size(516, 31);
            updateItemDescriptionInput.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(38, 109);
            label7.Name = "label7";
            label7.Size = new Size(190, 32);
            label7.TabIndex = 0;
            label7.Text = "Item Description";
            // 
            // UpdateItemModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 709);
            Controls.Add(panel2);
            Controls.Add(panel1);
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
    }
}