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

namespace InventorySystem.Views.Admin
{
    public partial class Admin : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\cedri\Documents\inventoryDB.mdf;Integrated Security=True;Connect Timeout=30";
        private DashboardController InventoryProcessor = new DashboardController();
        private BatchController BatchController = new BatchController();
        private BatchItemController BatchItemController = new BatchItemController();
        public Admin()
        {
            InitializeComponent();
            InitializeChart("daily");
            InitializePieChart();
            InitializeRecentTransactionData();
            InitializeBestSellerData("weekly");
            inventoryRestockingCmb.SelectedIndex = 0;
            periodCmb.SelectedIndex = 0;


        }

        private void InitializeRecentTransactionData()
        {
            try
            {
                List<Batch> batches = BatchController.GetBatches();
                recentTransactionsGrid.Rows.Clear();
                foreach (var batch in batches)
                {
                    recentTransactionsGrid.Rows.Add(batch.BatchID, batch.date, batch.TransactionType);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

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
                    bestSellerGrid.Rows.Add(index, product.ProductCode, product.ProductDescription, product.Category, product.Supplier, product.Unit);
                    index++;
                }



                //List<Item> products = BatchItemController.GetBestSeller();
                //bestSellerGrid.Rows.Clear();

                //int index = 1;
                //foreach (var product in products)
                //{
                //    bestSellerGrid.Rows.Add(index.ToString(), product.ProductCode, product.ProductDescription, product.Category, product.Supplier, product.Unit);
                //    index++;
                //}
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
                else if (product.ProductQuantity <= product.MinimumStockLevel)
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
            InitializeRecentTransactionData();
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
    }
}
