namespace InventorySystem.Views.Modals.InventoryUser
{
    partial class AddItemModal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItemModal));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            itemSupplierInput = new ComboBox();
            label6 = new Label();
            itemUnitInput = new ComboBox();
            itemMSLInput = new TextBox();
            label5 = new Label();
            label3 = new Label();
            itemCategoryInput = new TextBox();
            label4 = new Label();
            cancelCreateItemButton = new Button();
            createNewItemButton = new Button();
            itemCodeInput = new TextBox();
            label2 = new Label();
            itemDescriptionInput = new TextBox();
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
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 20F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(40, 24);
            label1.Name = "label1";
            label1.Size = new Size(116, 33);
            label1.TabIndex = 0;
            label1.Text = "Add Item";
            // 
            // panel2
            // 
            panel2.Controls.Add(itemSupplierInput);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(itemUnitInput);
            panel2.Controls.Add(itemMSLInput);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(itemCategoryInput);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(cancelCreateItemButton);
            panel2.Controls.Add(createNewItemButton);
            panel2.Controls.Add(itemCodeInput);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(itemDescriptionInput);
            panel2.Controls.Add(label7);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 78);
            panel2.Name = "panel2";
            panel2.Size = new Size(598, 631);
            panel2.TabIndex = 3;
            // 
            // itemSupplierInput
            // 
            itemSupplierInput.DropDownStyle = ComboBoxStyle.DropDownList;
            itemSupplierInput.Font = new Font("Calibri", 16F);
            itemSupplierInput.FormattingEnabled = true;
            itemSupplierInput.Location = new Point(40, 397);
            itemSupplierInput.Name = "itemSupplierInput";
            itemSupplierInput.Size = new Size(514, 34);
            itemSupplierInput.TabIndex = 16;
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
            // itemUnitInput
            // 
            itemUnitInput.DropDownStyle = ComboBoxStyle.DropDownList;
            itemUnitInput.Font = new Font("Calibri", 16F);
            itemUnitInput.FormattingEnabled = true;
            itemUnitInput.Items.AddRange(new object[] { "PCS", "FT", "SETS", "UNITS", "MTRS", "ROLLS", "PC", "DOZEN", "LEGNTH", "BOXES" });
            itemUnitInput.Location = new Point(38, 312);
            itemUnitInput.Name = "itemUnitInput";
            itemUnitInput.Size = new Size(516, 34);
            itemUnitInput.TabIndex = 14;
            // 
            // itemMSLInput
            // 
            itemMSLInput.Font = new Font("Calibri", 16F);
            itemMSLInput.Location = new Point(38, 481);
            itemMSLInput.Name = "itemMSLInput";
            itemMSLInput.Size = new Size(516, 34);
            itemMSLInput.TabIndex = 13;
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
            // itemCategoryInput
            // 
            itemCategoryInput.Font = new Font("Calibri", 16F);
            itemCategoryInput.Location = new Point(38, 224);
            itemCategoryInput.Name = "itemCategoryInput";
            itemCategoryInput.Size = new Size(516, 34);
            itemCategoryInput.TabIndex = 9;
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
            // cancelCreateItemButton
            // 
            cancelCreateItemButton.BackColor = Color.Firebrick;
            cancelCreateItemButton.Cursor = Cursors.Hand;
            cancelCreateItemButton.FlatStyle = FlatStyle.Flat;
            cancelCreateItemButton.Font = new Font("Calibri", 15F);
            cancelCreateItemButton.ForeColor = SystemColors.ButtonHighlight;
            cancelCreateItemButton.Location = new Point(248, 550);
            cancelCreateItemButton.Name = "cancelCreateItemButton";
            cancelCreateItemButton.Size = new Size(142, 54);
            cancelCreateItemButton.TabIndex = 7;
            cancelCreateItemButton.Text = "CANCEL";
            cancelCreateItemButton.UseVisualStyleBackColor = false;
            cancelCreateItemButton.Click += cancelCreateItemButton_Click;
            // 
            // createNewItemButton
            // 
            createNewItemButton.BackColor = Color.SeaGreen;
            createNewItemButton.Cursor = Cursors.Hand;
            createNewItemButton.FlatStyle = FlatStyle.Flat;
            createNewItemButton.Font = new Font("Calibri", 15F);
            createNewItemButton.ForeColor = SystemColors.ButtonHighlight;
            createNewItemButton.Location = new Point(408, 550);
            createNewItemButton.Name = "createNewItemButton";
            createNewItemButton.Size = new Size(142, 54);
            createNewItemButton.TabIndex = 6;
            createNewItemButton.Text = "CREATE";
            createNewItemButton.UseVisualStyleBackColor = false;
            createNewItemButton.Click += createNewItemButton_Click;
            // 
            // itemCodeInput
            // 
            itemCodeInput.Font = new Font("Calibri", 16F);
            itemCodeInput.Location = new Point(38, 56);
            itemCodeInput.Name = "itemCodeInput";
            itemCodeInput.Size = new Size(516, 34);
            itemCodeInput.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 18F);
            label2.Location = new Point(38, 21);
            label2.Name = "label2";
            label2.Size = new Size(114, 29);
            label2.TabIndex = 2;
            label2.Text = "Item Code";
            // 
            // itemDescriptionInput
            // 
            itemDescriptionInput.Font = new Font("Calibri", 16F);
            itemDescriptionInput.Location = new Point(38, 144);
            itemDescriptionInput.Name = "itemDescriptionInput";
            itemDescriptionInput.Size = new Size(516, 34);
            itemDescriptionInput.TabIndex = 1;
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
            // AddItemModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 709);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddItemModal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory - Add Item";
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
        private ComboBox itemSupplierInput;
        private Label label6;
        private ComboBox itemUnitInput;
        private TextBox itemMSLInput;
        private Label label5;
        private Label label3;
        private TextBox itemCategoryInput;
        private Label label4;
        private Button cancelCreateItemButton;
        private Button createNewItemButton;
        private TextBox itemCodeInput;
        private Label label2;
        private TextBox itemDescriptionInput;
        private Label label7;
    }
}