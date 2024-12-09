namespace InventorySystem.Views.Modals.InventoryUser
{
    partial class NewSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewSupplier));
            panel1 = new Panel();
            cancelCreateSupplierButton = new Button();
            createNewSupplierButton = new Button();
            supplierAddressInput = new TextBox();
            label4 = new Label();
            supplierContactInput = new TextBox();
            label3 = new Label();
            supplierNameInput = new TextBox();
            label1 = new Label();
            supplierIdInput = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(555, 506);
            panel1.TabIndex = 0;
            // 
            // cancelCreateSupplierButton
            // 
            cancelCreateSupplierButton.BackColor = Color.Firebrick;
            cancelCreateSupplierButton.Cursor = Cursors.Hand;
            cancelCreateSupplierButton.FlatStyle = FlatStyle.Flat;
            cancelCreateSupplierButton.Font = new Font("Segoe UI", 15F);
            cancelCreateSupplierButton.ForeColor = SystemColors.ButtonHighlight;
            cancelCreateSupplierButton.Location = new Point(233, 434);
            cancelCreateSupplierButton.Name = "cancelCreateSupplierButton";
            cancelCreateSupplierButton.Size = new Size(142, 54);
            cancelCreateSupplierButton.TabIndex = 23;
            cancelCreateSupplierButton.Text = "CANCEL";
            cancelCreateSupplierButton.UseVisualStyleBackColor = false;
            cancelCreateSupplierButton.Click += cancelCreateSupplierButton_Click;
            // 
            // createNewSupplierButton
            // 
            createNewSupplierButton.BackColor = Color.SeaGreen;
            createNewSupplierButton.Cursor = Cursors.Hand;
            createNewSupplierButton.FlatStyle = FlatStyle.Flat;
            createNewSupplierButton.Font = new Font("Segoe UI", 15F);
            createNewSupplierButton.ForeColor = SystemColors.ButtonHighlight;
            createNewSupplierButton.Location = new Point(393, 434);
            createNewSupplierButton.Name = "createNewSupplierButton";
            createNewSupplierButton.Size = new Size(142, 54);
            createNewSupplierButton.TabIndex = 22;
            createNewSupplierButton.Text = "CREATE";
            createNewSupplierButton.UseVisualStyleBackColor = false;
            createNewSupplierButton.Click += createNewSupplierButton_Click;
            // 
            // supplierAddressInput
            // 
            supplierAddressInput.Font = new Font("Segoe UI", 13F);
            supplierAddressInput.Location = new Point(19, 346);
            supplierAddressInput.Name = "supplierAddressInput";
            supplierAddressInput.Size = new Size(516, 31);
            supplierAddressInput.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(19, 311);
            label4.Name = "label4";
            label4.Size = new Size(98, 32);
            label4.TabIndex = 20;
            label4.Text = "Address";
            // 
            // supplierContactInput
            // 
            supplierContactInput.Font = new Font("Segoe UI", 13F);
            supplierContactInput.Location = new Point(19, 242);
            supplierContactInput.Name = "supplierContactInput";
            supplierContactInput.Size = new Size(516, 31);
            supplierContactInput.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 207);
            label3.Name = "label3";
            label3.Size = new Size(96, 32);
            label3.TabIndex = 18;
            label3.Text = "Contact";
            // 
            // supplierNameInput
            // 
            supplierNameInput.Font = new Font("Segoe UI", 13F);
            supplierNameInput.Location = new Point(19, 148);
            supplierNameInput.Name = "supplierNameInput";
            supplierNameInput.Size = new Size(516, 31);
            supplierNameInput.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 113);
            label1.Name = "label1";
            label1.Size = new Size(173, 32);
            label1.TabIndex = 16;
            label1.Text = "Supplier Name";
            // 
            // supplierIdInput
            // 
            supplierIdInput.Font = new Font("Segoe UI", 13F);
            supplierIdInput.Location = new Point(19, 54);
            supplierIdInput.Name = "supplierIdInput";
            supplierIdInput.Size = new Size(516, 31);
            supplierIdInput.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 19);
            label2.Name = "label2";
            label2.Size = new Size(132, 32);
            label2.TabIndex = 14;
            label2.Text = "Supplier ID";
            // 
            // NewSupplier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 506);
            Controls.Add(cancelCreateSupplierButton);
            Controls.Add(createNewSupplierButton);
            Controls.Add(supplierAddressInput);
            Controls.Add(label4);
            Controls.Add(supplierContactInput);
            Controls.Add(label3);
            Controls.Add(supplierNameInput);
            Controls.Add(label1);
            Controls.Add(supplierIdInput);
            Controls.Add(label2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "NewSupplier";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Supplier - New Supplier";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button cancelCreateSupplierButton;
        private Button createNewSupplierButton;
        private TextBox supplierAddressInput;
        private Label label4;
        private TextBox supplierContactInput;
        private Label label3;
        private TextBox supplierNameInput;
        private Label label1;
        private TextBox supplierIdInput;
        private Label label2;
    }
}