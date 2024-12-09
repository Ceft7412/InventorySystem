namespace InventorySystem.Views.Modals.Auth
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            container = new Panel();
            showpasswordChk = new CheckBox();
            cancelBtn = new Button();
            changeBtn = new Button();
            newpasswordTxt = new TextBox();
            label3 = new Label();
            currentpasswordTxt = new TextBox();
            label2 = new Label();
            usernameTxt = new TextBox();
            label1 = new Label();
            container.SuspendLayout();
            SuspendLayout();
            // 
            // container
            // 
            container.Controls.Add(showpasswordChk);
            container.Controls.Add(cancelBtn);
            container.Controls.Add(changeBtn);
            container.Controls.Add(newpasswordTxt);
            container.Controls.Add(label3);
            container.Controls.Add(currentpasswordTxt);
            container.Controls.Add(label2);
            container.Controls.Add(usernameTxt);
            container.Controls.Add(label1);
            container.Dock = DockStyle.Fill;
            container.Location = new Point(0, 0);
            container.Name = "container";
            container.Size = new Size(455, 438);
            container.TabIndex = 0;
            // 
            // showpasswordChk
            // 
            showpasswordChk.AutoSize = true;
            showpasswordChk.Font = new Font("Segoe UI", 12F);
            showpasswordChk.Location = new Point(305, 318);
            showpasswordChk.Name = "showpasswordChk";
            showpasswordChk.Size = new Size(138, 25);
            showpasswordChk.TabIndex = 8;
            showpasswordChk.Text = "Show Password";
            showpasswordChk.UseVisualStyleBackColor = true;
            showpasswordChk.CheckedChanged += showpasswordChk_CheckedChanged;
            // 
            // cancelBtn
            // 
            cancelBtn.Font = new Font("Segoe UI", 12F);
            cancelBtn.Location = new Point(201, 368);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(111, 50);
            cancelBtn.TabIndex = 7;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // changeBtn
            // 
            changeBtn.BackColor = Color.ForestGreen;
            changeBtn.Font = new Font("Segoe UI", 12F);
            changeBtn.ForeColor = SystemColors.ButtonHighlight;
            changeBtn.Location = new Point(332, 368);
            changeBtn.Name = "changeBtn";
            changeBtn.Size = new Size(111, 50);
            changeBtn.TabIndex = 6;
            changeBtn.Text = "CHANGE";
            changeBtn.UseVisualStyleBackColor = false;
            changeBtn.Click += changeBtn_Click;
            // 
            // newpasswordTxt
            // 
            newpasswordTxt.Font = new Font("Segoe UI", 16F);
            newpasswordTxt.Location = new Point(12, 262);
            newpasswordTxt.Name = "newpasswordTxt";
            newpasswordTxt.PasswordChar = '*';
            newpasswordTxt.Size = new Size(431, 36);
            newpasswordTxt.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(12, 229);
            label3.Name = "label3";
            label3.Size = new Size(153, 30);
            label3.TabIndex = 4;
            label3.Text = "New Password";
            // 
            // currentpasswordTxt
            // 
            currentpasswordTxt.Font = new Font("Segoe UI", 16F);
            currentpasswordTxt.Location = new Point(12, 158);
            currentpasswordTxt.Name = "currentpasswordTxt";
            currentpasswordTxt.PasswordChar = '*';
            currentpasswordTxt.Size = new Size(431, 36);
            currentpasswordTxt.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(12, 125);
            label2.Name = "label2";
            label2.Size = new Size(182, 30);
            label2.TabIndex = 2;
            label2.Text = "Current Password";
            // 
            // usernameTxt
            // 
            usernameTxt.Enabled = false;
            usernameTxt.Font = new Font("Segoe UI", 16F);
            usernameTxt.Location = new Point(12, 69);
            usernameTxt.Name = "usernameTxt";
            usernameTxt.Size = new Size(431, 36);
            usernameTxt.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(12, 36);
            label1.Name = "label1";
            label1.Size = new Size(111, 30);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 438);
            Controls.Add(container);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ChangePassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChangePassword";
            Load += ChangePassword_Load_1;
            container.ResumeLayout(false);
            container.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel container;
        private Label label1;
        private TextBox usernameTxt;
        private TextBox currentpasswordTxt;
        private Label label2;
        private TextBox newpasswordTxt;
        private Label label3;
        private Button changeBtn;
        private Button cancelBtn;
        private CheckBox showpasswordChk;
    }
}