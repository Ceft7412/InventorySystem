namespace InventorySystem.Views.Modals.Admin
{
    partial class ChangePasswordAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordAdmin));
            panel1 = new Panel();
            panel3 = new Panel();
            cancelBtn = new Button();
            updateBtn = new Button();
            confirmPasswordTxt = new TextBox();
            label4 = new Label();
            newPasswordTxt = new TextBox();
            label3 = new Label();
            currentPasswordTxt = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            showpasswordChk = new CheckBox();
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
            panel1.Size = new Size(544, 428);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(showpasswordChk);
            panel3.Controls.Add(cancelBtn);
            panel3.Controls.Add(updateBtn);
            panel3.Controls.Add(confirmPasswordTxt);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(newPasswordTxt);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(currentPasswordTxt);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 50);
            panel3.Name = "panel3";
            panel3.Size = new Size(544, 378);
            panel3.TabIndex = 1;
            // 
            // cancelBtn
            // 
            cancelBtn.Font = new Font("Segoe UI", 12F);
            cancelBtn.Location = new Point(254, 313);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(122, 53);
            cancelBtn.TabIndex = 7;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.ForestGreen;
            updateBtn.Font = new Font("Segoe UI", 12F);
            updateBtn.ForeColor = SystemColors.ButtonHighlight;
            updateBtn.Location = new Point(396, 313);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(122, 53);
            updateBtn.TabIndex = 6;
            updateBtn.Text = "UPDATE";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // confirmPasswordTxt
            // 
            confirmPasswordTxt.Font = new Font("Segoe UI", 14F);
            confirmPasswordTxt.Location = new Point(24, 201);
            confirmPasswordTxt.Name = "confirmPasswordTxt";
            confirmPasswordTxt.PasswordChar = '*';
            confirmPasswordTxt.Size = new Size(494, 32);
            confirmPasswordTxt.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(24, 177);
            label4.Name = "label4";
            label4.Size = new Size(137, 21);
            label4.TabIndex = 4;
            label4.Text = "Confirm Password";
            // 
            // newPasswordTxt
            // 
            newPasswordTxt.Font = new Font("Segoe UI", 14F);
            newPasswordTxt.Location = new Point(24, 116);
            newPasswordTxt.Name = "newPasswordTxt";
            newPasswordTxt.PasswordChar = '*';
            newPasswordTxt.Size = new Size(494, 32);
            newPasswordTxt.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(24, 92);
            label3.Name = "label3";
            label3.Size = new Size(112, 21);
            label3.TabIndex = 2;
            label3.Text = "New Password";
            // 
            // currentPasswordTxt
            // 
            currentPasswordTxt.Font = new Font("Segoe UI", 14F);
            currentPasswordTxt.Location = new Point(24, 40);
            currentPasswordTxt.Name = "currentPasswordTxt";
            currentPasswordTxt.PasswordChar = '*';
            currentPasswordTxt.Size = new Size(494, 32);
            currentPasswordTxt.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(24, 16);
            label2.Name = "label2";
            label2.Size = new Size(133, 21);
            label2.TabIndex = 0;
            label2.Text = "Current Password";
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(544, 50);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(205, 32);
            label1.TabIndex = 0;
            label1.Text = "Change Password";
            // 
            // showpasswordChk
            // 
            showpasswordChk.AutoSize = true;
            showpasswordChk.Font = new Font("Segoe UI", 12F);
            showpasswordChk.Location = new Point(380, 256);
            showpasswordChk.Name = "showpasswordChk";
            showpasswordChk.Size = new Size(138, 25);
            showpasswordChk.TabIndex = 9;
            showpasswordChk.Text = "Show Password";
            showpasswordChk.UseVisualStyleBackColor = true;
            showpasswordChk.CheckedChanged += showpasswordChk_CheckedChanged;
            // 
            // ChangePasswordAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 428);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ChangePasswordAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Account - Change Password";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Label label1;
        private TextBox currentPasswordTxt;
        private Label label2;
        private TextBox newPasswordTxt;
        private Label label3;
        private TextBox confirmPasswordTxt;
        private Label label4;
        private Button updateBtn;
        private Button cancelBtn;
        private CheckBox showpasswordChk;
    }
}