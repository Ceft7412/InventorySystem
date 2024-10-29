namespace InventoryManagementSystem
{
    partial class LoginWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label2 = new Label();
            userNameInput = new TextBox();
            usernameLabel = new Label();
            label1 = new Label();
            passwordInput = new TextBox();
            loginButton = new Button();
            pictureBox1 = new PictureBox();
            showPasswordCheckBox = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(398, 95);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(21, 20);
            label2.Name = "label2";
            label2.Size = new Size(361, 60);
            label2.TabIndex = 6;
            label2.Text = "SANGREE INDUSTRIAL SALES, INC.\r\nINVENTORY SYSTEM";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // userNameInput
            // 
            userNameInput.Font = new Font("Segoe UI", 16F);
            userNameInput.Location = new Point(12, 236);
            userNameInput.Name = "userNameInput";
            userNameInput.Size = new Size(370, 36);
            userNameInput.TabIndex = 1;
            userNameInput.KeyDown += username_KeyDown;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI", 14F);
            usernameLabel.Location = new Point(12, 212);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(109, 25);
            usernameLabel.TabIndex = 2;
            usernameLabel.Text = "User Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(12, 289);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 4;
            label1.Text = "Password:";
            // 
            // passwordInput
            // 
            passwordInput.Font = new Font("Segoe UI", 16F);
            passwordInput.Location = new Point(12, 313);
            passwordInput.Name = "passwordInput";
            passwordInput.PasswordChar = '*';
            passwordInput.Size = new Size(370, 36);
            passwordInput.TabIndex = 3;
            passwordInput.KeyDown += password_KeyDown;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.MidnightBlue;
            loginButton.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginButton.ForeColor = SystemColors.ButtonHighlight;
            loginButton.Location = new Point(33, 393);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(323, 54);
            loginButton.TabIndex = 5;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cart;
            pictureBox1.Location = new Point(152, 112);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // showPasswordCheckBox
            // 
            showPasswordCheckBox.AutoSize = true;
            showPasswordCheckBox.Font = new Font("Segoe UI", 12F);
            showPasswordCheckBox.Location = new Point(244, 351);
            showPasswordCheckBox.Name = "showPasswordCheckBox";
            showPasswordCheckBox.Size = new Size(138, 25);
            showPasswordCheckBox.TabIndex = 7;
            showPasswordCheckBox.Text = "Show Password";
            showPasswordCheckBox.UseVisualStyleBackColor = true;
            showPasswordCheckBox.CheckedChanged += showPasswordCheckBox_CheckedChanged;
            // 
            // LoginWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 459);
            Controls.Add(showPasswordCheckBox);
            Controls.Add(pictureBox1);
            Controls.Add(loginButton);
            Controls.Add(label1);
            Controls.Add(passwordInput);
            Controls.Add(usernameLabel);
            Controls.Add(userNameInput);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox userNameInput;
        private Label usernameLabel;
        private Label label1;
        private TextBox passwordInput;
        private Button loginButton;
        private Label label2;
        private PictureBox pictureBox1;
        private CheckBox showPasswordCheckBox;
    }
}
