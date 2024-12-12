namespace InventorySystem.Views.Modals.InventoryUser
{
    partial class UpdateSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateSupplier));
            panel1 = new Panel();
            cancelUpdateSupplierButton = new Button();
            updateSupplierButton = new Button();
            updateSupplierAddressInput = new TextBox();
            label4 = new Label();
            updateSupplierContactInput = new TextBox();
            label3 = new Label();
            updateSupplierNameInput = new TextBox();
            label1 = new Label();
            updateSupplierIdInput = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(cancelUpdateSupplierButton);
            panel1.Controls.Add(updateSupplierButton);
            panel1.Controls.Add(updateSupplierAddressInput);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(updateSupplierContactInput);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(updateSupplierNameInput);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(updateSupplierIdInput);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(555, 506);
            panel1.TabIndex = 0;
            // 
            // cancelUpdateSupplierButton
            // 
            cancelUpdateSupplierButton.BackColor = Color.Firebrick;
            cancelUpdateSupplierButton.Cursor = Cursors.Hand;
            cancelUpdateSupplierButton.FlatStyle = FlatStyle.Flat;
            cancelUpdateSupplierButton.Font = new Font("Calibri", 15F);
            cancelUpdateSupplierButton.ForeColor = SystemColors.ButtonHighlight;
            cancelUpdateSupplierButton.Location = new Point(233, 434);
            cancelUpdateSupplierButton.Name = "cancelUpdateSupplierButton";
            cancelUpdateSupplierButton.Size = new Size(142, 54);
            cancelUpdateSupplierButton.TabIndex = 33;
            cancelUpdateSupplierButton.Text = "CANCEL";
            cancelUpdateSupplierButton.UseVisualStyleBackColor = false;
            cancelUpdateSupplierButton.Click += cancelUpdateSupplierButton_Click;
            // 
            // updateSupplierButton
            // 
            updateSupplierButton.BackColor = Color.SeaGreen;
            updateSupplierButton.Cursor = Cursors.Hand;
            updateSupplierButton.FlatStyle = FlatStyle.Flat;
            updateSupplierButton.Font = new Font("Calibri", 15F);
            updateSupplierButton.ForeColor = SystemColors.ButtonHighlight;
            updateSupplierButton.Location = new Point(393, 434);
            updateSupplierButton.Name = "updateSupplierButton";
            updateSupplierButton.Size = new Size(142, 54);
            updateSupplierButton.TabIndex = 32;
            updateSupplierButton.Text = "UPDATE";
            updateSupplierButton.UseVisualStyleBackColor = false;
            updateSupplierButton.Click += updateSupplierButton_Click;
            // 
            // updateSupplierAddressInput
            // 
            updateSupplierAddressInput.Font = new Font("Calibri", 17F);
            updateSupplierAddressInput.Location = new Point(19, 346);
            updateSupplierAddressInput.Name = "updateSupplierAddressInput";
            updateSupplierAddressInput.Size = new Size(516, 35);
            updateSupplierAddressInput.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 18F);
            label4.Location = new Point(19, 311);
            label4.Name = "label4";
            label4.Size = new Size(91, 29);
            label4.TabIndex = 30;
            label4.Text = "Address";
            // 
            // updateSupplierContactInput
            // 
            updateSupplierContactInput.Font = new Font("Calibri", 17F);
            updateSupplierContactInput.Location = new Point(19, 242);
            updateSupplierContactInput.Name = "updateSupplierContactInput";
            updateSupplierContactInput.Size = new Size(516, 35);
            updateSupplierContactInput.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 18F);
            label3.Location = new Point(19, 207);
            label3.Name = "label3";
            label3.Size = new Size(90, 29);
            label3.TabIndex = 28;
            label3.Text = "Contact";
            // 
            // updateSupplierNameInput
            // 
            updateSupplierNameInput.Font = new Font("Calibri", 17F);
            updateSupplierNameInput.Location = new Point(19, 148);
            updateSupplierNameInput.Name = "updateSupplierNameInput";
            updateSupplierNameInput.Size = new Size(516, 35);
            updateSupplierNameInput.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 18F);
            label1.Location = new Point(19, 113);
            label1.Name = "label1";
            label1.Size = new Size(159, 29);
            label1.TabIndex = 26;
            label1.Text = "Supplier Name";
            // 
            // updateSupplierIdInput
            // 
            updateSupplierIdInput.Font = new Font("Calibri", 17F);
            updateSupplierIdInput.Location = new Point(19, 54);
            updateSupplierIdInput.Name = "updateSupplierIdInput";
            updateSupplierIdInput.ReadOnly = true;
            updateSupplierIdInput.Size = new Size(516, 35);
            updateSupplierIdInput.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 18F);
            label2.Location = new Point(19, 19);
            label2.Name = "label2";
            label2.Size = new Size(121, 29);
            label2.TabIndex = 24;
            label2.Text = "Supplier ID";
            // 
            // UpdateSupplier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 506);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UpdateSupplier";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateSupplier";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button cancelUpdateSupplierButton;
        private Button updateSupplierButton;
        private TextBox updateSupplierAddressInput;
        private Label label4;
        private TextBox updateSupplierContactInput;
        private Label label3;
        private TextBox updateSupplierNameInput;
        private Label label1;
        private TextBox updateSupplierIdInput;
        private Label label2;
    }
}