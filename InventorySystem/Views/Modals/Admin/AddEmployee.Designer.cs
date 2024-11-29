namespace InventorySystem.Views.Modals.Admin
{
    partial class AddEmployee
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
            cancelBtn = new Button();
            addBtn = new Button();
            addressTxt = new TextBox();
            label5 = new Label();
            contactTxt = new TextBox();
            label4 = new Label();
            lastnameTxt = new TextBox();
            label3 = new Label();
            firstnameTxt = new TextBox();
            label2 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
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
            label1.Location = new Point(22, 22);
            label1.Name = "label1";
            label1.Size = new Size(190, 37);
            label1.TabIndex = 0;
            label1.Text = "Add Employee";
            // 
            // panel2
            // 
            panel2.Controls.Add(cancelBtn);
            panel2.Controls.Add(addBtn);
            panel2.Controls.Add(addressTxt);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(contactTxt);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(lastnameTxt);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(firstnameTxt);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 78);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(15, 5, 15, 5);
            panel2.Size = new Size(598, 538);
            panel2.TabIndex = 2;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.Red;
            cancelBtn.Font = new Font("Segoe UI", 16F);
            cancelBtn.ForeColor = SystemColors.ButtonHighlight;
            cancelBtn.Location = new Point(217, 452);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(172, 63);
            cancelBtn.TabIndex = 9;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.ForestGreen;
            addBtn.Font = new Font("Segoe UI", 16F);
            addBtn.ForeColor = SystemColors.ButtonHighlight;
            addBtn.Location = new Point(408, 452);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(172, 63);
            addBtn.TabIndex = 8;
            addBtn.Text = "ADD";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // addressTxt
            // 
            addressTxt.Font = new Font("Segoe UI", 18F);
            addressTxt.Location = new Point(22, 386);
            addressTxt.Name = "addressTxt";
            addressTxt.Size = new Size(558, 39);
            addressTxt.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F);
            label5.Location = new Point(18, 351);
            label5.Name = "label5";
            label5.Size = new Size(98, 32);
            label5.TabIndex = 6;
            label5.Text = "Address";
            // 
            // contactTxt
            // 
            contactTxt.Font = new Font("Segoe UI", 18F);
            contactTxt.Location = new Point(22, 272);
            contactTxt.Name = "contactTxt";
            contactTxt.Size = new Size(558, 39);
            contactTxt.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F);
            label4.Location = new Point(18, 237);
            label4.Name = "label4";
            label4.Size = new Size(96, 32);
            label4.TabIndex = 4;
            label4.Text = "Contact";
            // 
            // lastnameTxt
            // 
            lastnameTxt.Font = new Font("Segoe UI", 18F);
            lastnameTxt.Location = new Point(22, 165);
            lastnameTxt.Name = "lastnameTxt";
            lastnameTxt.Size = new Size(558, 39);
            lastnameTxt.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F);
            label3.Location = new Point(18, 130);
            label3.Name = "label3";
            label3.Size = new Size(115, 32);
            label3.TabIndex = 2;
            label3.Text = "Lastname";
            // 
            // firstnameTxt
            // 
            firstnameTxt.Font = new Font("Segoe UI", 18F);
            firstnameTxt.Location = new Point(22, 66);
            firstnameTxt.Name = "firstnameTxt";
            firstnameTxt.Size = new Size(558, 39);
            firstnameTxt.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F);
            label2.Location = new Point(18, 31);
            label2.Name = "label2";
            label2.Size = new Size(118, 32);
            label2.TabIndex = 0;
            label2.Text = "Firstname";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // AddEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 616);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AddEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee - Add Employee";
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
        private TextBox firstnameTxt;
        private Label label2;
        private TextBox lastnameTxt;
        private Label label3;
        private TextBox contactTxt;
        private Label label4;
        private TextBox addressTxt;
        private Label label5;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button addBtn;
        private Button cancelBtn;
    }
}