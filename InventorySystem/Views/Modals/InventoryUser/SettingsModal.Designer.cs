namespace InventorySystem.Views.Modals.InventoryUser
{
    partial class SettingsModal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsModal));
            panel1 = new Panel();
            closeSettingsWindow = new Button();
            label1 = new Label();
            panel2 = new Panel();
            accountBtn = new Button();
            label2 = new Label();
            label3 = new Label();
            restoreBtn = new Button();
            backupBtn = new Button();
            label7 = new Label();
            label8 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(closeSettingsWindow);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 540);
            panel1.TabIndex = 0;
            // 
            // closeSettingsWindow
            // 
            closeSettingsWindow.Font = new Font("Calibri", 14.25F);
            closeSettingsWindow.Image = Properties.Resources.close_circle_icon_256x255_7gelhh31__1_;
            closeSettingsWindow.ImageAlign = ContentAlignment.MiddleLeft;
            closeSettingsWindow.Location = new Point(676, 483);
            closeSettingsWindow.Name = "closeSettingsWindow";
            closeSettingsWindow.Padding = new Padding(10, 4, 10, 4);
            closeSettingsWindow.Size = new Size(112, 45);
            closeSettingsWindow.TabIndex = 9;
            closeSettingsWindow.TabStop = false;
            closeSettingsWindow.Text = "Close";
            closeSettingsWindow.TextImageRelation = TextImageRelation.ImageBeforeText;
            closeSettingsWindow.UseVisualStyleBackColor = true;
            closeSettingsWindow.Click += closeSettingsWindow_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 24F, FontStyle.Bold);
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(122, 39);
            label1.TabIndex = 8;
            label1.Text = "Settings";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(accountBtn);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(restoreBtn);
            panel2.Controls.Add(backupBtn);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label8);
            panel2.Location = new Point(12, 66);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 402);
            panel2.TabIndex = 2;
            // 
            // accountBtn
            // 
            accountBtn.Font = new Font("Calibri", 12F);
            accountBtn.Image = Properties.Resources.user__1_;
            accountBtn.ImageAlign = ContentAlignment.TopCenter;
            accountBtn.Location = new Point(24, 267);
            accountBtn.Name = "accountBtn";
            accountBtn.Size = new Size(110, 105);
            accountBtn.TabIndex = 13;
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
            label2.Location = new Point(22, 247);
            label2.Name = "label2";
            label2.Size = new Size(734, 1);
            label2.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 16F);
            label3.Location = new Point(17, 208);
            label3.Name = "label3";
            label3.Size = new Size(71, 27);
            label3.TabIndex = 11;
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
            // SettingsModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 540);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "SettingsModal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory - Settings";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button closeSettingsWindow;
        private Label label1;
        private Panel panel2;
        private Button restoreBtn;
        private Button backupBtn;
        private Label label7;
        private Label label8;
        private Button accountBtn;
        private Label label2;
        private Label label3;
    }
}