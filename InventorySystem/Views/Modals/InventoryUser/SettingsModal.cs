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

namespace InventorySystem.Views.Modals.InventoryUser
{
    public partial class SettingsModal : Form
    {
        private SettingsController SettingsController = new SettingsController();
        public SettingsModal()
        {
            InitializeComponent();
        }

        private void closeSettingsWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backupBtn_Click(object sender, EventArgs e)
        {

            BackupModal backupModal = new BackupModal();
            backupModal.ShowDialog();
            //try
            //{
            //    using(SaveFileDialog saveFileDialog = new SaveFileDialog())
            //    {
            //        saveFileDialog.Filter = "SQL Server database backup files|*.bak";
            //        saveFileDialog.Title = "Backup Database";
            //        saveFileDialog.FileName = "InventorySystemDB_" + DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".bak";
            //        saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            //        if (saveFileDialog.ShowDialog() == DialogResult.OK)
            //        {   
            //            string databaseName = "inventoryDB.mdf";
            //            string backupFilePath = saveFileDialog.FileName;

            //            try
            //            {
            //                SettingsController.BackupDatabase(databaseName, backupFilePath);
            //            }
            //            catch (Exception ex)
            //            {
            //                MessageBox.Show($"Failed to backup database. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            }
            //        }
            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
        }

        private void restoreBtn_Click(object sender, EventArgs e)
        {
            RestoreModal restoreModal = new RestoreModal();
            restoreModal.ShowDialog();
        }

        private void accountBtn_Click(object sender, EventArgs e)
        {
            SettingsAccountInventory settingsAccountInventory = new SettingsAccountInventory();
            settingsAccountInventory.ShowDialog();
        }
    }
}
