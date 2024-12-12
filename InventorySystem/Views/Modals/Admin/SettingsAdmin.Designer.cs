namespace InventorySystem.Views.Modals.Admin
{
    partial class SettingsAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsAdmin));
            panel1 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            accountBtn = new Button();
            label2 = new Label();
            label3 = new Label();
            restoreBtn = new Button();
            backupBtn = new Button();
            label7 = new Label();
            label8 = new Label();
            panel3 = new Panel();
            closeSettingsWindow = new Button();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(772, 514);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 65);
            panel4.Name = "panel4";
            panel4.Size = new Size(772, 392);
            panel4.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ControlLightLight;
            panel5.Controls.Add(accountBtn);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(restoreBtn);
            panel5.Controls.Add(backupBtn);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(label8);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(772, 392);
            panel5.TabIndex = 3;
            // 
            // accountBtn
            // 
            accountBtn.Font = new Font("Calibri", 12F);
            accountBtn.Image = Properties.Resources.user__1_;
            accountBtn.ImageAlign = ContentAlignment.TopCenter;
            accountBtn.Location = new Point(24, 260);
            accountBtn.Name = "accountBtn";
            accountBtn.Size = new Size(110, 105);
            accountBtn.TabIndex = 10;
            accountBtn.TabStop = false;
            accountBtn.Text = "Account";
            accountBtn.TextAlign = ContentAlignment.BottomCenter;
            accountBtn.TextImageRelation = TextImageRelation.ImageAboveText;
            accountBtn.UseVisualStyleBackColor = true;
            accountBtn.Click += accountBtn_Click;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(22, 240);
            label2.Name = "label2";
            label2.Size = new Size(734, 1);
            label2.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 16F);
            label3.Location = new Point(17, 201);
            label3.Name = "label3";
            label3.Size = new Size(71, 27);
            label3.TabIndex = 8;
            label3.Text = "Profile";
            // 
            // restoreBtn
            // 
            restoreBtn.Font = new Font("Calibri", 12F);
            restoreBtn.Image = Properties.Resources.restoreIcon;
            restoreBtn.ImageAlign = ContentAlignment.TopCenter;
            restoreBtn.Location = new Point(164, 74);
            restoreBtn.Name = "restoreBtn";
            restoreBtn.Size = new Size(110, 105);
            restoreBtn.TabIndex = 7;
            restoreBtn.TabStop = false;
            restoreBtn.Text = "Restore";
            restoreBtn.TextAlign = ContentAlignment.BottomCenter;
            restoreBtn.TextImageRelation = TextImageRelation.ImageAboveText;
            restoreBtn.UseVisualStyleBackColor = true;
            restoreBtn.Click += restoreBtn_Click;
            // 
            // backupBtn
            // 
            backupBtn.Font = new Font("Calibri", 12F);
            backupBtn.Image = Properties.Resources.backupIcon;
            backupBtn.ImageAlign = ContentAlignment.TopCenter;
            backupBtn.Location = new Point(22, 74);
            backupBtn.Name = "backupBtn";
            backupBtn.Size = new Size(110, 105);
            backupBtn.TabIndex = 2;
            backupBtn.TabStop = false;
            backupBtn.Text = "Backup";
            backupBtn.TextAlign = ContentAlignment.BottomCenter;
            backupBtn.TextImageRelation = TextImageRelation.ImageAboveText;
            backupBtn.UseVisualStyleBackColor = true;
            backupBtn.Click += backupBtn_Click;
            // 
            // label7
            // 
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.Location = new Point(22, 51);
            label7.Name = "label7";
            label7.Size = new Size(734, 1);
            label7.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 16F);
            label8.Location = new Point(17, 12);
            label8.Name = "label8";
            label8.Size = new Size(193, 27);
            label8.TabIndex = 5;
            label8.Text = "Backup and Restore";
            // 
            // panel3
            // 
            panel3.Controls.Add(closeSettingsWindow);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 457);
            panel3.Name = "panel3";
            panel3.Size = new Size(772, 57);
            panel3.TabIndex = 1;
            // 
            // closeSettingsWindow
            // 
            closeSettingsWindow.Font = new Font("Calibri", 14.25F);
            closeSettingsWindow.Image = Properties.Resources.close_circle_icon_256x255_7gelhh31__1_;
            closeSettingsWindow.ImageAlign = ContentAlignment.MiddleLeft;
            closeSettingsWindow.Location = new Point(642, 6);
            closeSettingsWindow.Name = "closeSettingsWindow";
            closeSettingsWindow.Padding = new Padding(10, 0, 10, 0);
            closeSettingsWindow.Size = new Size(118, 45);
            closeSettingsWindow.TabIndex = 10;
            closeSettingsWindow.TabStop = false;
            closeSettingsWindow.Text = "Close";
            closeSettingsWindow.TextImageRelation = TextImageRelation.ImageBeforeText;
            closeSettingsWindow.UseVisualStyleBackColor = true;
            closeSettingsWindow.Click += closeSettingsWindow_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(772, 65);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 20.25F, FontStyle.Bold);
            label1.Location = new Point(17, 16);
            label1.Name = "label1";
            label1.Size = new Size(104, 33);
            label1.TabIndex = 0;
            label1.Text = "Settings";
            // 
            // SettingsAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 514);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "SettingsAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin - Settings";
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Button restoreBtn;
        private Button backupBtn;
        private Label label7;
        private Label label8;
        private Label label2;
        private Label label3;
        private Button accountBtn;
        private Button closeSettingsWindow;
    }
}