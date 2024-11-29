namespace InventorySystem.Views.Auth
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            loginBtn = new Button();
            showpasswordChk = new CheckBox();
            passwordTxt = new TextBox();
            label3 = new Label();
            usernameTxt = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.navigationBackground;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(609, 139);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.company_logo;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(138, 121);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(156, 36);
            label1.Name = "label1";
            label1.Size = new Size(444, 74);
            label1.TabIndex = 0;
            label1.Text = "SANGREE INDUSTRIAL SALES, INC.\r\nINVENTORY SYSTEM";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.Controls.Add(loginBtn);
            panel2.Controls.Add(showpasswordChk);
            panel2.Controls.Add(passwordTxt);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(usernameTxt);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 139);
            panel2.Name = "panel2";
            panel2.Size = new Size(609, 375);
            panel2.TabIndex = 1;
            // 
            // loginBtn
            // 
            loginBtn.BackgroundImage = Properties.Resources.navigationBackground;
            loginBtn.Font = new Font("Segoe UI", 16F);
            loginBtn.ForeColor = SystemColors.ButtonHighlight;
            loginBtn.Location = new Point(97, 295);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(415, 53);
            loginBtn.TabIndex = 5;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // showpasswordChk
            // 
            showpasswordChk.AutoSize = true;
            showpasswordChk.Font = new Font("Segoe UI", 16F);
            showpasswordChk.Location = new Point(406, 241);
            showpasswordChk.Name = "showpasswordChk";
            showpasswordChk.Size = new Size(181, 34);
            showpasswordChk.TabIndex = 4;
            showpasswordChk.Text = "Show Password";
            showpasswordChk.UseVisualStyleBackColor = true;
            showpasswordChk.CheckedChanged += showpasswordChk_CheckedChanged;
            // 
            // passwordTxt
            // 
            passwordTxt.Font = new Font("Segoe UI", 18F);
            passwordTxt.Location = new Point(21, 177);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.PasswordChar = '*';
            passwordTxt.Size = new Size(566, 39);
            passwordTxt.TabIndex = 3;
            passwordTxt.KeyDown += passwordKeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(21, 144);
            label3.Name = "label3";
            label3.Size = new Size(108, 30);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // usernameTxt
            // 
            usernameTxt.Font = new Font("Segoe UI", 18F);
            usernameTxt.Location = new Point(21, 70);
            usernameTxt.Name = "usernameTxt";
            usernameTxt.Size = new Size(566, 39);
            usernameTxt.TabIndex = 1;
            usernameTxt.KeyDown += username;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(21, 37);
            label2.Name = "label2";
            label2.Size = new Size(116, 30);
            label2.TabIndex = 0;
            label2.Text = "Username:";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 514);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label2;
        private TextBox passwordTxt;
        private Label label3;
        private TextBox usernameTxt;
        private CheckBox showpasswordChk;
        private Button loginBtn;
    }
}