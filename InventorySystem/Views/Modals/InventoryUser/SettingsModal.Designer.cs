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
            panel1 = new Panel();
            closeSettingsWindow = new Button();
            label1 = new Label();
            panel2 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label7 = new Label();
            label8 = new Label();
            label3 = new Label();
            label2 = new Label();
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
            panel1.Size = new Size(800, 570);
            panel1.TabIndex = 0;
            // 
            // closeSettingsWindow
            // 
            closeSettingsWindow.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            closeSettingsWindow.Image = Properties.Resources.close_circle_icon_256x255_7gelhh31__1_;
            closeSettingsWindow.ImageAlign = ContentAlignment.MiddleLeft;
            closeSettingsWindow.Location = new Point(668, 516);
            closeSettingsWindow.Name = "closeSettingsWindow";
            closeSettingsWindow.Padding = new Padding(10, 0, 10, 0);
            closeSettingsWindow.Size = new Size(118, 45);
            closeSettingsWindow.TabIndex = 9;
            closeSettingsWindow.TabStop = false;
            closeSettingsWindow.Text = "Close";
            closeSettingsWindow.TextImageRelation = TextImageRelation.ImageBeforeText;
            closeSettingsWindow.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(138, 45);
            label1.TabIndex = 8;
            label1.Text = "Settings";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 66);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 439);
            panel2.TabIndex = 2;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Image = Properties.Resources.restoreIcon;
            button3.ImageAlign = ContentAlignment.TopCenter;
            button3.Location = new Point(163, 290);
            button3.Name = "button3";
            button3.Size = new Size(110, 105);
            button3.TabIndex = 7;
            button3.TabStop = false;
            button3.Text = "Restore";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.TextImageRelation = TextImageRelation.ImageAboveText;
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Image = Properties.Resources.backupIcon;
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.Location = new Point(21, 290);
            button2.Name = "button2";
            button2.Size = new Size(110, 105);
            button2.TabIndex = 2;
            button2.TabStop = false;
            button2.Text = "Backup";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.TextImageRelation = TextImageRelation.ImageAboveText;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Image = Properties.Resources.dateAndTimeIcon__3_;
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(21, 85);
            button1.Name = "button1";
            button1.Size = new Size(110, 105);
            button1.TabIndex = 1;
            button1.TabStop = false;
            button1.Text = "Date and Time";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.BorderStyle = BorderStyle.Fixed3D;
            label7.Location = new Point(21, 267);
            label7.Name = "label7";
            label7.Size = new Size(734, 1);
            label7.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16F);
            label8.Location = new Point(16, 228);
            label8.Name = "label8";
            label8.Size = new Size(204, 30);
            label8.TabIndex = 5;
            label8.Text = "Backup and Restore";
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(21, 66);
            label3.Name = "label3";
            label3.Size = new Size(734, 1);
            label3.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(16, 27);
            label2.Name = "label2";
            label2.Size = new Size(220, 30);
            label2.TabIndex = 0;
            label2.Text = "System Configuration";
            // 
            // SettingsModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 570);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
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
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label7;
        private Label label8;
        private Label label3;
        private Label label2;
    }
}