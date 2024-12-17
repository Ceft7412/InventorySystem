using InventorySystem.Controllers;
using InventorySystem.Models;
using InventorySystem.Views.Modals.Admin;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
 using System.Configuration;
using InventorySystem.Views.Auth;
using InventorySystem.Services;

namespace InventorySystem.Views.Admin
{
    public partial class Admin : Form
    {
        private AuthenticationService AuthenticationService = new AuthenticationService();
        private string connectionString = ConfigurationManager.ConnectionStrings["InventoryDb"].ConnectionString;
        private DashboardController InventoryProcessor = new DashboardController();
        private BatchController BatchController = new BatchController();
        private AuthenticationService AuthService = new AuthenticationService();
        private ItemController ItemController = new ItemController();
        private BatchItemController BatchItemController = new BatchItemController();
        private bool alreadyAsked = false;
        private bool isLoggingOut = false;
        public Admin()
        {
            InitializeComponent();

            // Check authentication
            if (!AuthenticationService.IsAuthenticated)
            {
                MessageBox.Show("You are not authenticated. Please login.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Load += (s, e) => this.Close(); // Close the form if not authenticated
                Login login = new Login();
                login.Show();
            }
            else
            {
                // Load user-specific data or configurations
                //lblUsername.Text = AuthenticationService.CurrentUser.Username;
            }
            InitializeChart("daily");
            InitializePieChart();

            totalPullOutCmb.SelectedIndex = 0; // Set "Daily" as default selected item
            filterComboBox.SelectedIndex = 0;
            // Load data for the default filter
            LoadPullOutData("Daily");
            // Set default filter to Daily

            // Load the total transactions for the "Daily" filter on form load
            LoadTransactionData("Daily");
            //InitializeRecentTransactionData();
            InitializeBestSellerData("weekly");
            ITEM_BELOW_MIN_LEVEL();
            TOTAL_ITEMS();
            inventoryRestockingCmb.SelectedIndex = 0;
            periodCmb.SelectedIndex = 0;


        }

        private void TOTAL_ITEMS()
        {
            try
            {
                totalItems.Text = ItemController.CountItems().ToString();
                damagedItems.Text = ItemController.GetDamagedItemCount().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }



        private void ITEM_BELOW_MIN_LEVEL()
        {
            try
            {
                NUMBER_MIN_STOCK_LEVEL.Text = ItemController.CountBelowMinimumStock().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            // Check why the form is closing, decide if the application should exit
            //if (e.CloseReason == CloseReason.UserClosing)
            //{
            //    AuthenticationService.Destroy();
            //    Application.Exit(); // Exit application only if the user explicitly closes the form
            //}
            if (!isLoggingOut)  // If not logging out, then ask for confirmation
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    if (!alreadyAsked)  // Check if the user has not already been asked
                    {
                        var response = MessageBox.Show(this, "Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (response == DialogResult.No)
                        {
                            e.Cancel = true;  // Cancel the form close
                                              // Do not set the flag here because we want to ask again next time
                        }
                        else
                        {
                            alreadyAsked = true; // User wants to close, allow the form to close without asking again
                            Application.Exit();

                        }
                    }
                }
            }
            // Reset the flag always
            isLoggingOut = false;
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            alreadyAsked = false;
        }



        //private void InitializeRecentTransactionData()
        //{
        //    try
        //    {
        //        List<Batch> batches = BatchController.GetBatches();
        //        recentTransactionsGrid.Rows.Clear();
        //        foreach (var batch in batches)
        //        {
        //            recentTransactionsGrid.Rows.Add(batch.BatchID, batch.date, batch.TransactionType);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }
        //}

        private void InitializeBestSellerData(string period)
        {
            try
            {
                var batchItemController = new BatchItemController();
                var batchItems = batchItemController.FetchBatchItems();
                var items = batchItemController.FetchItems();

                List<Item> bestSellers = period.ToLower() switch
                {
                    "weekly" => batchItemController.GroupByWeekly(batchItems, items),
                    "monthly" => batchItemController.GroupByMonthly(batchItems, items),
                    "yearly" => batchItemController.GroupByYearly(batchItems, items),
                    _ => throw new ArgumentException("Invalid period specified")
                };

                bestSellerGrid.Rows.Clear();
                int index = 1;

                foreach (var product in bestSellers)
                {
                    // Calculate the total sold quantity for the current period (weekly, monthly, yearly)
                    int totalSold = batchItemController.GetTotalSoldForProductInPeriod(product.ProductCode, period);

                    // Add the product data along with the total sold value to the DataGridView
                    bestSellerGrid.Rows.Add(index, product.ProductCode, product.ProductDescription, totalSold);
                    index++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void InitializeChart(string timePeriod)
        {
            chartInventory.Series["Inventory Restocking"].Points.Clear();

            // Fetch raw data
            List<StockRecord> stockRecords = InventoryProcessor.FetchStockRecordsFromDatabase();

            // Process data based on time period
            Dictionary<string, int> groupedData = timePeriod.ToLower() switch
            {
                "daily" => InventoryProcessor.GroupByDaily(stockRecords),
                "weekly" => InventoryProcessor.GroupByWeekly(stockRecords),
                "monthly" => InventoryProcessor.GroupByMonthly(stockRecords),
                _ => throw new ArgumentException("Invalid time period specified")
            };

            // Populate the chart
            if (groupedData.Count > 0)
            {
                foreach (var entry in groupedData)
                {
                    chartInventory.Series["Inventory Restocking"].Points.AddXY(entry.Key, entry.Value);
                }
            }
            else
            {
                chartInventory.Series["Inventory Restocking"].Points.AddXY("No Data", 0);
                chartInventory.Series["Inventory Restocking"].Points[0].Label = "No Stock-In Events";
            }
        }



        private void InitializePieChart()
        {
            List<ProductRecord> products = InventoryProcessor.FetchInventoryData();

            int inStock = 0;
            int lowStock = 0;
            int outOfStock = 0;

            // Categorize the data
            foreach (var product in products)
            {
                if (product.ProductQuantity == 0)
                {
                    outOfStock++;
                }
                else if (product.ProductQuantity <   product.MinimumStockLevel)
                {
                    lowStock++;
                }
                else
                {
                    inStock++;
                }
            }

            // Calculate totals for the pie chart
            int totalProducts = inStock + lowStock + outOfStock;

            // Clear existing data in the pie chart
            pieChartInventory.Series["pieChart"].Points.Clear();

            // Add slices only if the percentage is greater than 0
            if (inStock > 0)
            {
                double inStockPercentage = (double)inStock / totalProducts;
                pieChartInventory.Series["pieChart"].Points.AddXY("In Stock", inStockPercentage);
            }

            if (lowStock > 0)
            {
                double lowStockPercentage = (double)lowStock / totalProducts;
                pieChartInventory.Series["pieChart"].Points.AddXY("Low Stock", lowStockPercentage);
            }

            if (outOfStock > 0)
            {
                double outOfStockPercentage = (double)outOfStock / totalProducts;
                pieChartInventory.Series["pieChart"].Points.AddXY("Out of Stock", outOfStockPercentage);
            }

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            InitializeChart("daily");
            InitializePieChart();
            //InitializeRecentTransactionData();
            inventoryRestockingCmb.SelectedIndex = 0;
        }

        private void transactionsBtn_Click(object sender, EventArgs e)
        {
            TransactionsAdmin transactions = new TransactionsAdmin();
            transactions.ShowDialog();
        }

        private void inventoryBtn_Click(object sender, EventArgs e)
        {
            InventoryAdmin inventory = new InventoryAdmin();
            inventory.ShowDialog();
        }

        private void inventoryRestockingCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string timePeriod = inventoryRestockingCmb.SelectedItem.ToString().ToLower();
            InitializeChart(timePeriod);

        }

        private void periodCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string period = periodCmb.SelectedItem.ToString().ToLower();
            InitializeBestSellerData(period);
        }

        private void linkTransaction_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TransactionsAdmin transactions = new TransactionsAdmin();
            transactions.ShowDialog();
        }

        private void employeeBtn_Click(object sender, EventArgs e)
        {
            EmployeeAdmin employeeAdmin = new EmployeeAdmin();
            employeeAdmin.ShowDialog();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Are you sure you want to logout?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    isLoggingOut = true;
                    AuthenticationService.Destroy();
                    this.Close();
                    Login login = new Login();
                    login.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            SettingsAdmin settingAdmin = new SettingsAdmin();
            settingAdmin.ShowDialog();
        }

        private void logsBtn_Click(object sender, EventArgs e)
        {
            LogsAdmin logsAdmin = new LogsAdmin();
            logsAdmin.ShowDialog();

        }

        private void panel33_Paint(object sender, PaintEventArgs e)
        {

        }

        private void totalPullOutCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFilter = totalPullOutCmb.SelectedItem.ToString();
            int pullOuts = InventoryProcessor.GetPullOutTotalsByFilter(selectedFilter);

            labelPullOuts.Text = pullOuts.ToString();
        }

        private void LoadPullOutData(string filter)
        {
            int pullOuts = InventoryProcessor.GetPullOutTotalsByFilter(filter);
            labelPullOuts.Text = pullOuts.ToString();
        }

        private void filterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Load transaction data based on the selected filter
            string selectedFilter = filterComboBox.SelectedItem.ToString();
            LoadTransactionData(selectedFilter);
        }

        private void LoadTransactionData(string filter)
        {
            try
            {
                // Fetch the total transactions based on the filter
                int totalTransactions = InventoryProcessor.GetTransactionTotalsByFilter(filter);

                // Update the dashboard label or display area
                transactionCountLabel.Text = totalTransactions.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading data: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

    }
}
