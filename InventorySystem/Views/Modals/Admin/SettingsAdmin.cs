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
    public partial class SettingsAdmin : Form
    {
        public SettingsAdmin()
        {
            InitializeComponent();
        }

        private void backupBtn_Click(object sender, EventArgs e)
        {
            SettingsBackup settingsBackup = new SettingsBackup();
            settingsBackup.ShowDialog();
        }

        private void restoreBtn_Click(object sender, EventArgs e)
        {
            SettingsRestore settingsRestore = new SettingsRestore();
            settingsRestore.ShowDialog();
        }

        private void accountBtn_Click(object sender, EventArgs e)
        {
            SettingsAccount settingsAccount = new SettingsAccount();
            settingsAccount.ShowDialog();
        }

        private void closeSettingsWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
