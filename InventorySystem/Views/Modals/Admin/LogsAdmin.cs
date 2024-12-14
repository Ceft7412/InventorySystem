using InventorySystem.Controllers;
using InventorySystem.Models;
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
    public partial class LogsAdmin : Form
    {
        private LogController LogController = new LogController();
        public LogsAdmin()
        {
            InitializeComponent();
            LoadLogs();
        }

        private void LoadLogs()
        {
            try
            {
                List<Log> logs = LogController.GetLogsFromDatabase();
                if (logs != null && logs.Count > 0)
                {
                    foreach (var log in logs)
                    {
                        // Add rows to DataGridView by accessing Item properties
                        dataGridViewLogs.Rows.Add(
                            log.LogID.ToString(),
                            log.TimeStamp,
                            log.UserID.ToString(),
                            log.ActionType,
                            log.RecordID.ToString(),
                            log.ModuleName,
                            log.Description,
                            log.Status
                            );
                    }
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
