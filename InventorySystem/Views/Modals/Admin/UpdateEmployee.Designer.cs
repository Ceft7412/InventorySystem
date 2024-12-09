namespace InventorySystem.Views.Modals.Admin
{
    partial class UpdateEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateEmployee));
            panel1 = new Panel();
            panel3 = new Panel();
            updateEmployeeIDInput = new TextBox();
            label6 = new Label();
            cancelBtn = new Button();
            updateBtn = new Button();
            updateEmployeeAddressInput = new TextBox();
            label5 = new Label();
            updateEmployeeContactInput = new TextBox();
            label4 = new Label();
            updateEmployeeLastnameInput = new TextBox();
            label3 = new Label();
            updateEmployeeFirstnameInput = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(598, 713);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(updateEmployeeIDInput);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(cancelBtn);
            panel3.Controls.Add(updateBtn);
            panel3.Controls.Add(updateEmployeeAddressInput);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(updateEmployeeContactInput);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(updateEmployeeLastnameInput);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(updateEmployeeFirstnameInput);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 78);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(15, 5, 15, 5);
            panel3.Size = new Size(598, 635);
            panel3.TabIndex = 3;
            // 
            // updateEmployeeIDInput
            // 
            updateEmployeeIDInput.Font = new Font("Segoe UI", 18F);
            updateEmployeeIDInput.Location = new Point(22, 60);
            updateEmployeeIDInput.Name = "updateEmployeeIDInput";
            updateEmployeeIDInput.ReadOnly = true;
            updateEmployeeIDInput.Size = new Size(558, 39);
            updateEmployeeIDInput.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F);
            label6.Location = new Point(30, 25);
            label6.Name = "label6";
            label6.Size = new Size(149, 32);
            label6.TabIndex = 10;
            label6.Text = "Employee ID";
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.Red;
            cancelBtn.Font = new Font("Segoe UI", 16F);
            cancelBtn.ForeColor = SystemColors.ButtonHighlight;
            cancelBtn.Location = new Point(216, 548);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(172, 63);
            cancelBtn.TabIndex = 9;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.ForestGreen;
            updateBtn.Font = new Font("Segoe UI", 16F);
            updateBtn.ForeColor = SystemColors.ButtonHighlight;
            updateBtn.Location = new Point(408, 548);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(172, 63);
            updateBtn.TabIndex = 8;
            updateBtn.Text = "UPDATE";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // updateEmployeeAddressInput
            // 
            updateEmployeeAddressInput.Font = new Font("Segoe UI", 18F);
            updateEmployeeAddressInput.Location = new Point(22, 467);
            updateEmployeeAddressInput.Name = "updateEmployeeAddressInput";
            updateEmployeeAddressInput.Size = new Size(558, 39);
            updateEmployeeAddressInput.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F);
            label5.Location = new Point(33, 437);
            label5.Name = "label5";
            label5.Size = new Size(98, 32);
            label5.TabIndex = 6;
            label5.Text = "Address";
            // 
            // updateEmployeeContactInput
            // 
            updateEmployeeContactInput.Font = new Font("Segoe UI", 18F);
            updateEmployeeContactInput.Location = new Point(22, 353);
            updateEmployeeContactInput.Name = "updateEmployeeContactInput";
            updateEmployeeContactInput.Size = new Size(558, 39);
            updateEmployeeContactInput.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F);
            label4.Location = new Point(33, 323);
            label4.Name = "label4";
            label4.Size = new Size(96, 32);
            label4.TabIndex = 4;
            label4.Text = "Contact";
            // 
            // updateEmployeeLastnameInput
            // 
            updateEmployeeLastnameInput.Font = new Font("Segoe UI", 18F);
            updateEmployeeLastnameInput.Location = new Point(22, 246);
            updateEmployeeLastnameInput.Name = "updateEmployeeLastnameInput";
            updateEmployeeLastnameInput.Size = new Size(558, 39);
            updateEmployeeLastnameInput.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F);
            label3.Location = new Point(33, 216);
            label3.Name = "label3";
            label3.Size = new Size(115, 32);
            label3.TabIndex = 2;
            label3.Text = "Lastname";
            // 
            // updateEmployeeFirstnameInput
            // 
            updateEmployeeFirstnameInput.Font = new Font("Segoe UI", 18F);
            updateEmployeeFirstnameInput.Location = new Point(22, 147);
            updateEmployeeFirstnameInput.Name = "updateEmployeeFirstnameInput";
            updateEmployeeFirstnameInput.Size = new Size(558, 39);
            updateEmployeeFirstnameInput.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F);
            label2.Location = new Point(33, 117);
            label2.Name = "label2";
            label2.Size = new Size(118, 32);
            label2.TabIndex = 0;
            label2.Text = "Firstname";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = Properties.Resources.panelBackground1;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(598, 78);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(22, 22);
            label1.Name = "label1";
            label1.Size = new Size(229, 37);
            label1.TabIndex = 0;
            label1.Text = "Update Employee";
            // 
            // UpdateEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 713);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "UpdateEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee - Update Employee";
            Load += UpdateEmployee_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Button cancelBtn;
        private Button addBtn;
        private TextBox updateEmployeeAddressInput;
        private Label label5;
        private TextBox updateEmployeeContactInput;
        private Label label4;
        private TextBox updateEmployeeLastnameInput;
        private Label label3;
        private TextBox updateEmployeeFirstnameInput;
        private Label label2;
        private TextBox updateEmployeeIDInput;
        private Label label6;
        private Button updateBtn;
    }
}