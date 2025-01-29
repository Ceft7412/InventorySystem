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
            statusCmb.SelectedIndex = 0;
        }

        private void SearchLogs(string searchTerm)
        {
            try
            {
                // Call the controller method to get filtered logs based on the search term
                List<Log> logs = LogController.SearchLogsByLogIdOrUserId(searchTerm);

                if (logs != null && logs.Count > 0)
                {
                    dataGridViewLogs.Rows.Clear(); // Clear the existing rows before adding new data

                    // Add the retrieved logs to the DataGridView
                    foreach (var log in logs)
                    {
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
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadLogs(string statusFilter = null)
        {
            try
            {
                List<Log> logs = LogController.GetLogsFromDatabase(statusFilter);

                if (logs != null && logs.Count > 0)
                {
                    dataGridViewLogs.Rows.Clear(); // Clear the existing rows before adding new data

                    foreach (var log in logs)
                    {
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
                else
                {
                    MessageBox.Show("No logs found for the selected filter.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void statusCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedStatus = statusCmb.SelectedItem.ToString();

                // If "All" is selected, load all logs, otherwise filter by selected status
                if (selectedStatus == "All")
                {
                    LoadLogs();  // No filter, load all logs
                }
                else
                {
                    LoadLogs(selectedStatus);  // Load logs with selected status
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void logAndemployeeTxt_TextChanged(object sender, EventArgs e)
        {
            // Get the search term entered by the user
            string searchTerm = logAndemployeeTxt.Text.Trim();

            // Call the SearchLogs method with the search term
            SearchLogs(searchTerm);
        }
    }
}       
