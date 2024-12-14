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

namespace InventorySystem.Views.Modals.InventoryUser
{
    public partial class NotificationModal : Form
    {
        private NotificationController NotificationController = new NotificationController();
        public NotificationModal()
        {
            InitializeComponent();
            LoadActiveStockAlerts();
        }

        private void LoadActiveStockAlerts()
        {
            try
            {
                var alerts = NotificationController.GetActiveStockAlerts();
                if (alerts != null && alerts.Count > 0)
                {
                    // Bind the list of alerts to the DataGridView
                    dataGridViewAlerts.DataSource = new BindingList<StockAlert>(alerts);
                    
                }
                else
                {
                    dataGridViewAlerts.DataSource = new BindingList<StockAlert>();
                }

                // Set column headers for better readability
                // Set column headers and widths
                var columns = dataGridViewAlerts.Columns;

                columns["ItemId"].HeaderText = "Item ID";
                //columns["ItemId"].Width = 200;

                columns["ProductCode"].HeaderText = "Item Code";
                //columns["ProductCode"].Width = 200;

                columns["ProductDescription"].HeaderText = "Name";
                //columns["ProductDescription"].Width = 390;

                columns["Quantity"].HeaderText = "Quantity";
                //columns["Quantity"].Width = 150;

                columns["MinimumStockLevel"].HeaderText = "Minimum Stock Level";
                //columns["MinimumStockLevel"].Width = 130;

                columns["DateTime"].HeaderText = "Date";
                //columns["DateTime"].Width = 200;

                columns["Status"].HeaderText = "Status";
                //columns["Status"].Width = 160;

                columns["Severity"].HeaderText = "Severity";
                //columns["Severity"].Width = 150;
                // Customize column appearance
                FormatSeverityColors();

                // Disable row adding
                dataGridViewAlerts.AllowUserToAddRows = false;
                // Clear any default selection
                dataGridViewAlerts.ClearSelection();
                dataGridViewAlerts.CurrentCell = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatSeverityColors()
        {
            foreach (DataGridViewRow row in dataGridViewAlerts.Rows)
            {
                if (row.Cells["Severity"].Value != null)
                {
                    string severity = row.Cells["Severity"].Value.ToString();
                    switch (severity)
                    {
                        case "High":
                            row.DefaultCellStyle.BackColor = Color.Red;
                            row.DefaultCellStyle.ForeColor = Color.White;
                            break;
                        case "Medium":
                            row.DefaultCellStyle.BackColor = Color.Orange;
                            row.DefaultCellStyle.ForeColor = Color.Black;
                            break;
                        case "Low":
                            row.DefaultCellStyle.BackColor = Color.Yellow;
                            row.DefaultCellStyle.ForeColor = Color.Black;
                            break;
                    }
                }
            }
        }




        private void Alerts_OnDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridViewAlerts.ClearSelection();
        }

        private void dataGridViewAlerts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewAlerts.Columns[e.ColumnIndex].Name == "Severity" && e.Value != null)
            {
                string severity = e.Value.ToString();
                switch (severity)
                {
                    case "High":
                        e.CellStyle.BackColor = Color.Red;
                        e.CellStyle.ForeColor = Color.White;
                        break;
                    case "Medium":
                        e.CellStyle.BackColor = Color.Orange;
                        e.CellStyle.ForeColor = Color.Black;
                        break;
                    case "Low":
                        e.CellStyle.BackColor = Color.Yellow;
                        e.CellStyle.ForeColor = Color.Black;
                        break;
                }
            }
        }
    }


}
