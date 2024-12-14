using System;
using System.Collections.Generic;
using InventorySystem.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Configuration;
using InventorySystem.Controllers;

namespace InventorySystem.Controllers
{
    public class BatchItemController
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["InventoryDb"].ConnectionString;
        private NotificationController NotificationController = new NotificationController();
        private List<BatchItem> batchItems = new List<BatchItem>();
        public List<BatchItem> GetBatchItems()
        {
            return batchItems;
        }


        public List<BatchItem> FetchBatchItems()
        {
            List<BatchItem> batchItems = new List<BatchItem>();

            string query = @"
            SELECT 
                bi.productCode, 
                bi.quantity, 
                bi.date
            FROM 
                tbBatchItems AS bi
            WHERE 
                bi.reason = 'SOLD' 
                AND bi.type = 'OUT'
            ORDER BY 
                bi.date DESC;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    batchItems.Add(new BatchItem
                    {
                        ProductCode = reader["productCode"].ToString(),
                        Quantity = Convert.ToInt32(reader["quantity"]),
                        Date = Convert.ToDateTime(reader["date"])
                    });
                }

                reader.Close();
            }

            return batchItems;
        }

        public List<BatchItem> FILTERBATCHITEMS(string type)
        {
            try
            {
                List<BatchItem> rowsBatchItems = new List<BatchItem>();
                string queryString = @"SELECT * FROM tbBatchItems WHERE type = @type";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.AddWithValue("@type", type);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        rowsBatchItems.Add(new BatchItem
                        {
                            BatchItemId = reader["batchItemId"].ToString(),
                            BatchId = reader["batchId"].ToString(),
                            ProductCode = reader["productCode"].ToString(),
                            Quantity = Convert.ToInt32(reader["quantity"]),
                            Type = reader["type"].ToString(),
                            Reason = reader["reason"].ToString(),
                            Date = Convert.ToDateTime(reader["date"])
                        });
                    }
                    reader.Close();
                }
                return rowsBatchItems;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An error occurred while filtering the batch items.", ex);
            }
        }

                public List<BatchItem> SEARCHBATCHITEMS(string query)
        {
            try
            {
                List<BatchItem> rowsBatchItems = new List<BatchItem>();
                string queryString = @"SELECT * FROM tbBatchItems WHERE batchItemId LIKE @query OR batchId LIKE @query OR productCode LIKE @query";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.AddWithValue("@query", "%" + query + "%");
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        rowsBatchItems.Add(new BatchItem
                        {
                            BatchItemId = reader["batchItemId"].ToString(),
                            BatchId = reader["batchId"].ToString(),
                            ProductCode = reader["productCode"].ToString(),
                            Quantity = Convert.ToInt32(reader["quantity"]),
                            Type = reader["type"].ToString(),
                            Reason = reader["reason"].ToString(),
                            Date = Convert.ToDateTime(reader["date"])
                        });
                    }
                    reader.Close();
                }
                return rowsBatchItems;


            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An error occurred while searching for the item.", ex);
            }
        }
            public List<BatchItem> GETROWSBATCHITEMS()
        {
            try
            {
                List<BatchItem> rowbatchitems = new List<BatchItem>();
                string query = @"SELECT * FROM tbBatchItems";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        rowbatchitems.Add(new BatchItem
                        {
                            BatchItemId = reader["batchItemId"].ToString(),
                            BatchId = reader["batchId"].ToString(),
                            ProductCode = reader["productCode"].ToString(),
                            Quantity = Convert.ToInt32(reader["quantity"]),
                            Type = reader["type"].ToString(),
                            Reason = reader["reason"].ToString(),
                            Date = Convert.ToDateTime(reader["date"])
                        });
                    }
                    reader.Close();
                }
                return rowbatchitems;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<BatchItem>();
            }
        }

            public List<Item> FetchItems()
        {
            List<Item> items = new List<Item>();

            string query = @"
            SELECT 
                productCode, 
                productDescription, 
                category, 
                supplier, 
                unit
            FROM 
                tbItem";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    items.Add(new Item
                    {
                        ProductCode = reader["productCode"].ToString(),
                        ProductDescription = reader["productDescription"].ToString(),
                        Category = reader["category"].ToString(),
                        Supplier = reader["supplier"].ToString(),
                        Unit = reader["unit"].ToString()
                    });
                }

                reader.Close();
            }

            return items;
        }

        public List<Item> GroupByWeekly(List<BatchItem> batchItems, List<Item> items)
        {
            // Filter for current week
            DateTime today = DateTime.Today;
            DateTime startOfWeek = today.AddDays(-(int)today.DayOfWeek + 1); // Monday
            DateTime endOfWeek = startOfWeek.AddDays(7);

            // Filter and group data
            var grouped = batchItems
                .Where(bi => bi.Date >= startOfWeek && bi.Date < endOfWeek)
                .GroupBy(bi => bi.ProductCode)
                .Select(g => new
                {
                    ProductCode = g.Key,
                    TotalSold = g.Sum(bi => bi.Quantity)
                })
                .OrderByDescending(g => g.TotalSold)
                .Take(5);

            // Join with product data
            return grouped.Select(g => items.FirstOrDefault(i => i.ProductCode == g.ProductCode)).ToList();
        }

        public List<Item> GroupByMonthly(List<BatchItem> batchItems, List<Item> items)
        {
            DateTime today = DateTime.Today;
            DateTime startOfMonth = new DateTime(today.Year, today.Month, 1);
            DateTime endOfMonth = startOfMonth.AddMonths(1);

            var grouped = batchItems
                .Where(bi => bi.Date >= startOfMonth && bi.Date < endOfMonth)
                .GroupBy(bi => bi.ProductCode)
                .Select(g => new
                {
                    ProductCode = g.Key,
                    TotalSold = g.Sum(bi => bi.Quantity)
                })
                .OrderByDescending(g => g.TotalSold)
                .Take(5);

            return grouped.Select(g => items.FirstOrDefault(i => i.ProductCode == g.ProductCode)).ToList();
        }

        public List<Item> GroupByYearly(List<BatchItem> batchItems, List<Item> items)
        {
            DateTime today = DateTime.Today;
            DateTime startOfYear = new DateTime(today.Year, 1, 1);
            DateTime endOfYear = startOfYear.AddYears(1);

            var grouped = batchItems
                .Where(bi => bi.Date >= startOfYear && bi.Date < endOfYear)
                .GroupBy(bi => bi.ProductCode)
                .Select(g => new
                {
                    ProductCode = g.Key,
                    TotalSold = g.Sum(bi => bi.Quantity)
                })
                .OrderByDescending(g => g.TotalSold)
                .Take(5);

            return grouped.Select(g => items.FirstOrDefault(i => i.ProductCode == g.ProductCode)).ToList();
        }

        public void RemoveBatchItem(string productCode)
        {
            var itemToRemove = batchItems.FirstOrDefault(i => i.ProductCode == productCode);
            if (itemToRemove != null)
            {
                batchItems.Remove(itemToRemove);
            }
        }

        public bool ProductCodeExists(string productCode, string unit)
        {
            string query = "SELECT COUNT(*) FROM tbItem WHERE productCode = @productCode AND unit = @unit";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@productCode", productCode);
                command.Parameters.AddWithValue("@unit", unit);
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }

        public bool ItemIdExists(int item_id)
        {
            string query = "SELECT COUNT(*) FROM tbItem WHERE item_id = @item_id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@item_id", item_id);
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }

        public void AddBatchItem(int item_id, string productCode, int quantity, string unit, string reason, DateTime date, string transaction_type)
        {   
            if (!ProductCodeExists(productCode, unit))
            {
                throw new ArgumentException("Product code and unit combination does not exist.");
            }

            if(!ItemIdExists(item_id))
            {
                throw new ArgumentException("Item ID does not exist.");
            }

            var existingItem = batchItems.FirstOrDefault(i => i.ItemId == item_id && i.ProductCode == productCode && i.Reason == reason);
            if (existingItem != null)
            {
                // If an item exists with the same reason, update the quantity and possibly the date
                existingItem.Quantity += quantity;
                existingItem.Date = date;  // Consider whether updating the date is appropriate in all cases
            }
            else
            {
                BatchItem batchItem = new BatchItem
                {
                    ItemId = item_id,
                    ProductCode = productCode,
                    Quantity = quantity,
                    Unit = unit,
                    Reason = reason,
                    Date = date,
                    TransactionType = transaction_type

                };
                batchItems.Add(batchItem);
            }
        }

        public void ClearBatchItems()
        {
            batchItems.Clear();
        }
        private string GenerateUniqueBatchId(SqlConnection connection)
        {
            string newId = "";
            bool isUnique = false;
            while (!isUnique)
            {
                newId = "B" + DateTime.Now.Ticks.ToString();  // Example: B637688130850202830
                string checkIdQuery = "SELECT COUNT(*) FROM tbBatches WHERE batchId = @batchId";
                using (SqlCommand checkCmd = new SqlCommand(checkIdQuery, connection))
                {
                    checkCmd.Parameters.AddWithValue("@batchId", newId);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());  // Ensure the conversion to int is handled in C#
                    isUnique = (count == 0);  // Unique if no existing record with this ID
                }
            }
            return newId;
        }

        private string GenerateUniqueBatchItemId(SqlConnection connection)
        {
            try
            {
                string newId = "";
                bool isUnique = false;
                while (!isUnique)
                {
                    newId = "BI" + DateTime.Now.Ticks.ToString();  // Example: BI637688130850202830
                    string checkIdQuery = "SELECT COUNT(*) FROM tbBatchItems WHERE batchItemId = @batchItemId";
                    using (SqlCommand checkCmd = new SqlCommand(checkIdQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@batchItemId", newId);
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                        isUnique = (count == 0); 
                    }
                }
                return newId;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An error occurred while generating a unique batch item ID.", ex);
            }
        }
        public int GenerateUniqueTransactionID()
        {
            try
            {
                int transaction_id;
                bool isUnique;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    do
                    {
                        // Generate a random 8-digit number
                        transaction_id = new Random().Next(10000000, 99999999);
                        string query = "SELECT COUNT(*) FROM [tbTransaction] WHERE transaction_id = @transactionID";
                        // Check if the generated ID already exists in the database
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@transactionID", transaction_id);
                            int countTransactionId = (int)command.ExecuteScalar();

                            // Unique if no records are found
                            isUnique = countTransactionId == 0;
                        }

                    } while (!isUnique); // Keep generating until we find a unique ID
                }

                return transaction_id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to generate unique transaction ID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        public void SaveTransaction(string transaction_type)
        {
            try
            {
                if (batchItems.Count == 0)
                {
                    MessageBox.Show("No items to save. You need to add data to the table to save it into the database.", "No batch items found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // First, create the batch and get the batch ID
                    string batchId = GenerateUniqueBatchId(connection);
                    string batchItemId = GenerateUniqueBatchItemId(connection);
                    int transaction_id = GenerateUniqueTransactionID();

                    int employee_id = SessionData.UserId;

                    DateTime dateTime = DateTime.Now;


                    string transactionQuery = "INSERT INTO tbTransaction(transaction_id, employee_id, type, timestamp) VALUES(@transaction_id, @employee_id, @type, @timestamp)";
                    using (SqlCommand addTransactionCommand = new SqlCommand(transactionQuery, connection))
                    {
                        addTransactionCommand.Parameters.AddWithValue("@transaction_id", transaction_id);
                        addTransactionCommand.Parameters.AddWithValue("@employee_id", employee_id);
                        addTransactionCommand.Parameters.AddWithValue("@type", transaction_type);
                        addTransactionCommand.Parameters.AddWithValue("@timestamp", dateTime);
                        addTransactionCommand.ExecuteNonQuery();
                    }


                    string batchQuery = "INSERT INTO tbBatches(batchId, date, transaction_id) VALUES(@batchId, @date, @transaction_id)";
                    using (SqlCommand addCommand = new SqlCommand(batchQuery, connection))
                    {
                        addCommand.Parameters.AddWithValue("@batchId", batchId);
                        addCommand.Parameters.AddWithValue("@date", dateTime);
                        addCommand.Parameters.AddWithValue("@transaction_id", transaction_id);
                        addCommand.ExecuteNonQuery();
                    }

                    foreach (BatchItem item in batchItems)
                    {
                        // Check current stock if the transaction is "OUT"
                        if (transaction_type == "OUT")
                        {
                            // Modified query to check stock for both productCode and unit combination
                            string checkStockQuery = "SELECT productQuantity FROM tbItem WHERE item_id = @item_id AND productCode = @productCode AND unit = @unit";
                            using (SqlCommand checkStockCommand = new SqlCommand(checkStockQuery, connection))
                            {
                                checkStockCommand.Parameters.AddWithValue("@item_id", item.ItemId);
                                checkStockCommand.Parameters.AddWithValue("@productCode", item.ProductCode);
                                checkStockCommand.Parameters.AddWithValue("@unit", item.Unit);
                                int currentQuantity = (int)checkStockCommand.ExecuteScalar();

                                if (currentQuantity < item.Quantity)
                                {
                                    throw new InvalidOperationException("Insufficient stock available to complete the transaction.");
                                }
                            }
                        }

                        // Insert batch item
                        string batchItemsQuery = "INSERT INTO tbBatchItems(batchItemId, batchId, transaction_id, productCode, quantity, type, reason, date, unit) " +
                                                  "VALUES(@batchItemId, @batchId, @transaction_id, @productCode, @quantity, @type, @reason, @date, @unit)";
                        using (SqlCommand addCommand = new SqlCommand(batchItemsQuery, connection))
                        {
                            addCommand.Parameters.AddWithValue("@batchItemId", batchItemId);
                            addCommand.Parameters.AddWithValue("@batchId", batchId);
                            addCommand.Parameters.AddWithValue("@transaction_id", transaction_id);
                            addCommand.Parameters.AddWithValue("@productCode", item.ProductCode);
                            addCommand.Parameters.AddWithValue("@quantity", item.Quantity);
                            addCommand.Parameters.AddWithValue("@unit", item.Unit);
                            addCommand.Parameters.AddWithValue("@type", transaction_type);
                            addCommand.Parameters.AddWithValue("@reason", item.Reason);
                            addCommand.Parameters.AddWithValue("@date", item.Date);
                            
                            addCommand.ExecuteNonQuery();
                        }

                        // Update product stock considering unit
                        string updateProductQuery = "UPDATE tbItem SET productQuantity = productQuantity + @quantity WHERE item_id = @item_id AND productCode = @productCode AND unit = @unit";
                        if (transaction_type == "OUT")
                        {
                            updateProductQuery = "UPDATE tbItem SET productQuantity = productQuantity - @quantity WHERE item_id = @item_id AND productCode = @productCode AND unit = @unit";
                        }

                        using (SqlCommand updateCommand = new SqlCommand(updateProductQuery, connection))
                        {
                            updateCommand.Parameters.AddWithValue("@item_id", item.ItemId);
                            updateCommand.Parameters.AddWithValue("@productCode", item.ProductCode);
                            updateCommand.Parameters.AddWithValue("@unit", item.Unit);  // Add unit to stock update
                            updateCommand.Parameters.AddWithValue("@quantity", item.Quantity);
                            updateCommand.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Save items successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Check and generate stock alerts
                    NotificationController.UpdateCompletedStockAlerts();
                    NotificationController.GenerateStockAlerts();
                    ClearBatchItems();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
