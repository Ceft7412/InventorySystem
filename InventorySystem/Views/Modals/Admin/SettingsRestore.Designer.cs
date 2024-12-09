namespace InventorySystem.Views.Modals.Admin
{
    partial class SettingsRestore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsRestore));
            panel1 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            cancelBtn = new Button();
            restoreBtn = new Button();
            statusLabel = new Label();
            backupfilePath = new Label();
            selectbackupfileBtn = new Button();
            panel2 = new Panel();
            label3 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
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
            panel1.Size = new Size(551, 212);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(statusLabel);
            panel3.Controls.Add(backupfilePath);
            panel3.Controls.Add(selectbackupfileBtn);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 58);
            panel3.Name = "panel3";
            panel3.Size = new Size(551, 154);
            panel3.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.Controls.Add(cancelBtn);
            panel4.Controls.Add(restoreBtn);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 87);
            panel4.Name = "panel4";
            panel4.Size = new Size(551, 67);
            panel4.TabIndex = 11;
            // 
            // cancelBtn
            // 
            cancelBtn.Font = new Font("Segoe UI", 11F);
            cancelBtn.Location = new Point(263, 10);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(125, 50);
            cancelBtn.TabIndex = 8;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // restoreBtn
            // 
            restoreBtn.BackColor = Color.SteelBlue;
            restoreBtn.Font = new Font("Segoe UI", 11F);
            restoreBtn.ForeColor = SystemColors.ButtonHighlight;
            restoreBtn.Location = new Point(404, 10);
            restoreBtn.Name = "restoreBtn";
            restoreBtn.Size = new Size(125, 50);
            restoreBtn.TabIndex = 7;
            restoreBtn.Text = "Restore";
            restoreBtn.UseVisualStyleBackColor = false;
            restoreBtn.Click += restoreBtn_Click;
            // 
            // statusLabel
            // 
            statusLabel.Location = new Point(21, 97);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(300, 35);
            statusLabel.TabIndex = 10;
            statusLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // backupfilePath
            // 
            backupfilePath.Font = new Font("Segoe UI", 11.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            backupfilePath.ForeColor = SystemColors.ControlDarkDark;
            backupfilePath.Location = new Point(186, 33);
            backupfilePath.Name = "backupfilePath";
            backupfilePath.Size = new Size(310, 26);
            backupfilePath.TabIndex = 9;
            backupfilePath.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // selectbackupfileBtn
            // 
            selectbackupfileBtn.Font = new Font("Segoe UI", 11F);
            selectbackupfileBtn.Location = new Point(21, 26);
            selectbackupfileBtn.Name = "selectbackupfileBtn";
            selectbackupfileBtn.Size = new Size(142, 40);
            selectbackupfileBtn.TabIndex = 6;
            selectbackupfileBtn.Text = "Select backup file";
            selectbackupfileBtn.UseVisualStyleBackColor = true;
            selectbackupfileBtn.Click += selectbackupfileBtn_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(551, 58);
            panel2.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Location = new Point(0, 57);
            label3.Name = "label3";
            label3.Size = new Size(1207, 1);
            label3.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 14);
            label1.Name = "label1";
            label1.Size = new Size(205, 32);
            label1.TabIndex = 0;
            label1.Text = "Restore Database";
            // 
            // SettingsRestore
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 212);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "SettingsRestore";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings - Restore";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label3;
        private Label label1;
        private Panel panel3;
        private Panel panel4;
        private Button cancelBtn;
        private Button restoreBtn;
        private Label statusLabel;
        private Label backupfilePath;
        private Button selectbackupfileBtn;
    }
}