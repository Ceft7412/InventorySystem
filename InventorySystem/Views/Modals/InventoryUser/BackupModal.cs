using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using InventorySystem.Controllers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics.Contracts;
using System.IO;

namespace InventorySystem.Views.Modals.InventoryUser
{
    public partial class BackupModal : Form
    {
        private SettingsController SettingsController = new SettingsController();
        public BackupModal()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(BackupModal));
            panel1 = new Panel();
            panel3 = new Panel();
            cancelBtn = new Button();
            backupBtn = new Button();
            folderpathLbl = new Label();
            selectfolderBtn = new Button();
            label2 = new Label();
            databasenameTxt = new TextBox();
            panel2 = new Panel();
            label3 = new Label();
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
            panel1.Size = new Size(505, 312);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(cancelBtn);
            panel3.Controls.Add(backupBtn);
            panel3.Controls.Add(folderpathLbl);
            panel3.Controls.Add(selectfolderBtn);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(databasenameTxt);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 58);
            panel3.Name = "panel3";
            panel3.Size = new Size(505, 254);
            panel3.TabIndex = 2;
            // 
            // cancelBtn
            // 
            cancelBtn.Font = new Font("Segoe UI", 11F);
            cancelBtn.Location = new Point(211, 188);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(125, 50);
            cancelBtn.TabIndex = 5;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // backupBtn
            // 
            backupBtn.BackColor = Color.SteelBlue;
            backupBtn.Font = new Font("Segoe UI", 11F);
            backupBtn.ForeColor = SystemColors.ButtonHighlight;
            backupBtn.Location = new Point(356, 188);
            backupBtn.Name = "backupBtn";
            backupBtn.Size = new Size(125, 50);
            backupBtn.TabIndex = 4;
            backupBtn.Text = "BACKUP";
            backupBtn.UseVisualStyleBackColor = false;
            backupBtn.Click += backupBtn_Click;
            // 
            // folderpathLbl
            // 
            folderpathLbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            folderpathLbl.ForeColor = SystemColors.ControlDarkDark;
            folderpathLbl.Location = new Point(144, 122);
            folderpathLbl.Name = "folderpathLbl";
            folderpathLbl.Size = new Size(337, 26);
            folderpathLbl.TabIndex = 3;
            folderpathLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // selectfolderBtn
            // 
            selectfolderBtn.Font = new Font("Segoe UI", 11F);
            selectfolderBtn.Location = new Point(23, 115);
            selectfolderBtn.Name = "selectfolderBtn";
            selectfolderBtn.Size = new Size(106, 40);
            selectfolderBtn.TabIndex = 2;
            selectfolderBtn.Text = "Select folder";
            selectfolderBtn.UseVisualStyleBackColor = true;
            selectfolderBtn.Click += selectfolderBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(23, 24);
            label2.Name = "label2";
            label2.Size = new Size(167, 30);
            label2.TabIndex = 1;
            label2.Text = "Database name:";
            // 
            // databasenameTxt
            // 
            databasenameTxt.Font = new Font("Segoe UI", 16F);
            databasenameTxt.Location = new Point(23, 57);
            databasenameTxt.Name = "databasenameTxt";
            databasenameTxt.Size = new Size(458, 36);
            databasenameTxt.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(505, 58);
            panel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Location = new Point(0, 57);
            label3.Name = "label3";
            label3.Size = new Size(505, 1);
            label3.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 14);
            label1.Name = "label1";
            label1.Size = new Size(203, 32);
            label1.TabIndex = 0;
            label1.Text = "Backup Database";
            // 
            // BackupModal
            // 
            ClientSize = new Size(505, 312);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "BackupModal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Backup Database";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private TextBox databasenameTxt;
        private Button selectfolderBtn;
        private Label folderpathLbl;
        private Button backupBtn;
        private Button cancelBtn;
        private Label label3;

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backupBtn_Click(object sender, EventArgs e)
        {
            var message = MessageBox.Show("Are you sure you want to backup the database?", "Backup", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (message == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(databasenameTxt.Text))
                {
                    MessageBox.Show("Please enter database name.", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(folderpathLbl.Text))
                {
                    MessageBox.Show("Please select folder to save backup file.", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
  
                string backupFilePath = Path.Combine(folderpathLbl.Text, databasenameTxt.Text + ".bak");
                try
                {
                    bool result = SettingsController.BackupDatabase(backupFilePath);
                    if (result)
                    {
                        MessageBox.Show("Database backup completed successfully.", "Backup Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close(); return;
                    }
                    else
                    {
                        MessageBox.Show("Failed to backup database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex) // Assuming BackupDatabase might throw an exception
                {
                    MessageBox.Show("Failed to backup database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void selectfolderBtn_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Select folder to save backup file";
                folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;
                folderBrowserDialog.ShowNewFolderButton = true;

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    folderpathLbl.Text = folderBrowserDialog.SelectedPath;
                }
            }



        }
    }
}
