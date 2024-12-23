﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace InventorySystem.Controllers
{
    public class StockRecord
    {
        public DateTime Date { get; set; }
        public int Quantity { get; set; }
    }

    public class ProductRecord
    {
        public string ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public int ProductQuantity { get; set; }
        public int MinimumStockLevel { get; set; }
    }

    public class DashboardController
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["InventoryDb"].ConnectionString;


        public int GetTransactionTotalsByFilter(string filter)
        {
            try
            {
                int totalTransactions = 0;
                string query = "";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Adjust SQL query based on filter
                    switch (filter)
                    {
                        case "Daily":
                            query = @"SELECT COUNT(*) AS TotalTransactions 
                              FROM tbTransaction 
                              WHERE CAST(timestamp AS DATE) = CAST(GETDATE() AS DATE)";
                            break;

                        case "Weekly":
                            query = @"SELECT COUNT(*) AS TotalTransactions 
                              FROM tbTransaction 
                              WHERE DATEPART(WEEK, timestamp) = DATEPART(WEEK, GETDATE()) AND 
                                    DATEPART(YEAR, timestamp) = DATEPART(YEAR, GETDATE())";
                            break;

                        case "Monthly":
                            query = @"SELECT COUNT(*) AS TotalTransactions 
                              FROM tbTransaction 
                              WHERE DATEPART(MONTH, timestamp) = DATEPART(MONTH, GETDATE()) AND 
                                    DATEPART(YEAR, timestamp) = DATEPART(YEAR, GETDATE())";
                            break;

                        case "Yearly":
                            query = @"SELECT COUNT(*) AS TotalTransactions 
                              FROM tbTransaction 
                              WHERE DATEPART(YEAR, timestamp) = DATEPART(YEAR, GETDATE())";
                            break;

                        default:
                            throw new ArgumentException("Invalid filter selected.");
                    }

                    // Execute the query
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        totalTransactions = Convert.ToInt32(command.ExecuteScalar() ?? 0);
                    }
                }

                return totalTransactions;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        public List<ProductRecord> FetchInventoryData()
        {
            var products = new List<ProductRecord>();

            string query = @"
            SELECT 
                productCode, 
                productDescription, 
                productQuantity, 
                minimumstocklevel 
            FROM 
                tbItem
            ORDER BY 
                productCode;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var product = new ProductRecord
                        {
                            ProductCode = reader["productCode"].ToString(),
                            ProductDescription = reader["productDescription"].ToString(),
                            ProductQuantity = Convert.ToInt32(reader["productQuantity"]),
                            MinimumStockLevel = Convert.ToInt32(reader["minimumstocklevel"])
                        };
                        products.Add(product);
                    }
                }
            }

            return products;
        }

        public int GetPullOutTotalsByFilter(string filter)
        {
            try
            {
                int pullOuts = 0;
                string query = "";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Adjust SQL query based on filter
                    switch (filter)
                    {
                        case "Daily":
                            query = @"SELECT SUM(quantity) AS TotalPullOuts 
                              FROM tbBatchItems 
                              WHERE type = 'OUT' AND CAST(date AS DATE) = CAST(GETDATE() AS DATE)";
                            break;

                        case "Weekly":
                            query = @"SELECT SUM(quantity) AS TotalPullOuts 
                              FROM tbBatchItems 
                              WHERE type = 'OUT' AND 
                                    DATEPART(WEEK, date) = DATEPART(WEEK, GETDATE()) AND 
                                    DATEPART(YEAR, date) = DATEPART(YEAR, GETDATE())";
                            break;

                        case "Monthly":
                            query = @"SELECT SUM(quantity) AS TotalPullOuts 
                              FROM tbBatchItems 
                              WHERE type = 'OUT' AND 
                                    DATEPART(MONTH, date) = DATEPART(MONTH, GETDATE()) AND 
                                    DATEPART(YEAR, date) = DATEPART(YEAR, GETDATE())";
                            break;

                        case "Yearly":
                            query = @"SELECT SUM(quantity) AS TotalPullOuts 
                              FROM tbBatchItems 
                              WHERE type = 'OUT' AND 
                                    DATEPART(YEAR, date) = DATEPART(YEAR, GETDATE())";
                            break;

                        default:
                            throw new ArgumentException("Invalid filter selected.");
                    }

                    // Execute Query
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        object result = command.ExecuteScalar();
                        pullOuts = result == DBNull.Value || result == null ? 0 : Convert.ToInt32(result);
                    }
                }

                return pullOuts;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

    public Dictionary<string, int> GroupByDaily(List<StockRecord> records)
        {
            // Get the current date (truncate to date only)
            DateTime today = DateTime.Today;

            // Filter records to include only those from the current day
            var currentDayRecords = records
                .Where(r => r.Date.Date == today);

            // Group records by time (e.g., hours) within the current day
            return currentDayRecords
                .GroupBy(r => r.Date.ToString("HH:mm")) // Group by time within the day (e.g., "14:30")
                .ToDictionary(g => g.Key, g => g.Sum(r => r.Quantity));
        }

        public Dictionary<string, int> GroupByWeekly(List<StockRecord> records)
        {
            // Determine the start and end dates of the current week
            DateTime today = DateTime.Today;

            // Adjust to ensure Monday is the start of the week
            int diff = (int)today.DayOfWeek == 0 ? -6 : 1 - (int)today.DayOfWeek; // Handle Sunday as the last day
            DateTime startOfWeek = today.AddDays(diff); // Monday of the current week
            DateTime endOfWeek = startOfWeek.AddDays(7); // Start of next week (exclusive)

            // Filter records to include only those in the current week
            var currentWeekRecords = records
                .Where(r => r.Date.Date >= startOfWeek && r.Date.Date < endOfWeek);

            // Group records by each day of the current week
            return currentWeekRecords
                .GroupBy(r => r.Date.ToString("yyyy-MM-dd")) // Group by specific date (e.g., "2024-11-20")
                .ToDictionary(g => g.Key, g => g.Sum(r => r.Quantity));
        }

        public  Dictionary<string, int> GroupByMonthly(List<StockRecord> records)
        {
            return records
                .GroupBy(r => r.Date.ToString("yyyy-MM")) // Group by month
                .ToDictionary(g => g.Key, g => g.Sum(r => r.Quantity));
        }

        public List<StockRecord> FetchStockRecordsFromDatabase()
        {
            var stockRecords = new List<StockRecord>();

            string query = @"
            SELECT 
                [date], 
                [quantity]
            FROM 
                [tbBatchItems]
            WHERE 
                [type] = 'IN'
                AND [date] >= DATEADD(YEAR, -1, GETDATE()) -- Fetch data from the past year
            ORDER BY 
                [date];";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Parse each row into a StockRecord
                        var record = new StockRecord
                        {
                            Date = reader.GetDateTime(reader.GetOrdinal("date")),
                            Quantity = reader.GetInt32(reader.GetOrdinal("quantity"))
                        };
                        stockRecords.Add(record);
                    }
                }
            }

            return stockRecords;
        }
    }
}
