using InventorySystem.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem.Views.Modals.Admin
{
    public partial class SettingsBackup : Form
    {
        private SettingsController SettingsController = new SettingsController();
        public SettingsBackup()
        {
            InitializeComponent();
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

                string backupFilePath = Path.Combine(folderpathLbl.Text, databasenameTxt.Text + ".sql");
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
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to backup database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
