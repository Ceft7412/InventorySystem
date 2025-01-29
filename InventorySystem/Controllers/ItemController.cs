using System;
using Microsoft.Data.SqlClient;
using InventorySystem.Models;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 using System.Configuration;

namespace InventorySystem.Controllers
{
    public class ItemController
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["InventoryDb"].ConnectionString; 
        private LogController LogController = new LogController();

        Item item;


        public List<Supplier> GetSuppliersByItemId(int itemId)
        {
            string query = "SELECT s.supplierId, s.supplierName FROM tbSupplier s " +
                           "INNER JOIN tbItemSupplier isup ON s.supplierId = isup.SupplierId " +
                           "WHERE isup.ItemId = @itemId";

            List<Supplier> suppliers = new List<Supplier>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@itemId", itemId);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    suppliers.Add(new Supplier
                    {
                        SupplierId = Convert.ToInt32(reader["supplierId"]),
                        SupplierName = reader["supplierName"].ToString()
                    });
                }
                reader.Close();
            }

            return suppliers;
        }

        public int GetDamagedItemCount()
        {
            try
            {
                int totalDamagedQuantity = 0;

                // Connect to the database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to sum the quantity of damaged items
                    string query = "SELECT SUM(quantity) AS TotalDamagedQuantity FROM tbBatchItems WHERE reason = 'damaged'";

                    // Execute the query and get the result
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Execute the scalar query to get the total quantity
                        object result = command.ExecuteScalar();
                        totalDamagedQuantity = result != DBNull.Value ? Convert.ToInt32(result) : 0;
                    }
                }

                return totalDamagedQuantity;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0; // Return 0 in case of an error
            }
        }


        public int CountBelowMinimumStock()
        {
            try
            {
                int belowMinimumCount = 0;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) AS BelowMinimumCount FROM tbItem WHERE productQuantity < minimumstocklevel";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        belowMinimumCount = (int)command.ExecuteScalar();
                    }
                }

                return belowMinimumCount;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        public int CountItems()
        {
            try
            {
                int itemCount = 0;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) AS ItemCount FROM tbItem";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        itemCount = (int)command.ExecuteScalar();
                    }
                }

                return itemCount;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        public int CountSlowMovingItems(DateTime startDate, DateTime endDate, int threshold = 5)
        {
            int slowMovingItemsCount = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                SELECT 
                    COUNT(DISTINCT tbItem.item_id) AS SlowMovingItemsCount
                FROM 
                    tbItem
                LEFT JOIN 
                    tbBatchItems 
                ON 
                    tbItem.item_id = tbBatchItems.item_id AND tbBatchItems.type = 'OUT' 
                AND 
                    tbBatchItems.date BETWEEN @startDate AND @endDate
                GROUP BY 
                    tbItem.item_id
                HAVING 
                    COUNT(tbBatchItems.batchItemId) <= @threshold";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@startDate", startDate);
                        command.Parameters.AddWithValue("@endDate", endDate);
                        command.Parameters.AddWithValue("@threshold", threshold);

                        // Execute the query and get the result
                        slowMovingItemsCount = (int)command.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return slowMovingItemsCount;
        }


        public Item QueryItemByItemId(int item_id)
        {
            try
            {
                string query = "SELECT * FROM tbItem WHERE CAST(item_id AS VARCHAR) LIKE @item_id";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);

                    // Add wildcards for partial matching
                    command.Parameters.AddWithValue("@item_id", $"%{item_id}%");

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        item = new Item
                        {
                            ItemId = reader["item_id"] != DBNull.Value ? Convert.ToInt32(reader["item_id"]) : 0,
                            ProductCode = reader["productCode"] as string ?? "",
                            ProductDescription = reader["productDescription"] as string ?? "",
                            Category = reader["category"] as string ?? "",
                            Unit = reader["unit"] as string ?? "",
                            MinimumStock = reader["minimumstocklevel"] != DBNull.Value ? Convert.ToInt32(reader["minimumstocklevel"]) : 0
                        };
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return item;
        }

        // Get all items from the database
        public List<Item> GetAllItems(string status)
        {
            try
            {
                List<Item> items = new List<Item>();
                string query = @"
            SELECT 
                i.item_id, 
                i.productCode, 
                i.productDescription, 
                i.productQuantity, 
                i.category, 
                i.unit, 
                i.minimumstocklevel,
                -- Concatenate supplier names into a single string
                STRING_AGG(s.supplierName, ', ') AS SupplierNames
            FROM tbItem i
            LEFT JOIN tbItemSupplier isup ON i.item_id = isup.ItemId
            LEFT JOIN tbSupplier s ON isup.SupplierId = s.supplierId
            WHERE i.status = @status
            GROUP BY i.item_id, i.productCode, i.productDescription, i.productQuantity, i.category, i.unit, i.minimumstocklevel
        ";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand getAllCommand = new SqlCommand(query, connection);
                    getAllCommand.Parameters.AddWithValue("@status", status);
                    connection.Open();
                    SqlDataReader reader = getAllCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        items.Add(new Item
                        {
                            ItemId = Convert.ToInt32(reader["item_id"]),
                            ProductCode = reader["productCode"] as string ?? "",
                            ProductDescription = reader["productDescription"] as string ?? "",
                            Quantity = reader["productQuantity"] != DBNull.Value ? Convert.ToInt32(reader["productQuantity"]) : 0,
                            Category = reader["category"] as string ?? "",
                            Supplier = reader["SupplierNames"] as string ?? "", // Now this will contain the comma-separated supplier names
                            Unit = reader["unit"] as string ?? "",
                            MinimumStock = reader["minimumstocklevel"] != DBNull.Value ? Convert.ToInt32(reader["minimumstocklevel"]) : 0
                        });
                    }
                    reader.Close();
                }
                return items;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load items: " + ex.Message);
                return new List<Item>();
            }
        }




        // Get specific item data from the database
        public Item GetItemData(string item_id)
        {
            Item item = null;
            try
            {
                string query = @"
            SELECT i.item_id, i.productCode, i.productDescription, i.category, i.unit, i.minimumstocklevel,
                   STRING_AGG(s.supplierName, ', ') AS SupplierNames, 
                   STRING_AGG(CAST(s.supplierId AS VARCHAR), ', ') AS SupplierIds
            FROM tbItem i
            LEFT JOIN tbItemSupplier isup ON i.item_id = isup.ItemId
            LEFT JOIN tbSupplier s ON isup.SupplierId = s.supplierId
            WHERE i.item_id = @item_id
            GROUP BY i.item_id, i.productCode, i.productDescription, i.category, i.unit, i.minimumstocklevel";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@item_id", item_id);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        item = new Item
                        {
                            ItemId = Convert.ToInt32(reader["item_id"]),
                            ProductCode = reader["productCode"] as string ?? "",
                            ProductDescription = reader["productDescription"] as string ?? "",
                            Category = reader["category"] as string ?? "",
                            Unit = reader["unit"] as string ?? "",
                            MinimumStock = reader["minimumstocklevel"] != DBNull.Value ? Convert.ToInt32(reader["minimumstocklevel"]) : 0
                        };

                        // Get the supplier names and IDs as comma-separated values
                        string supplierNamesString = reader["SupplierNames"] as string ?? "";
                        string supplierIdsString = reader["SupplierIds"] as string ?? "";

                        // Convert the comma-separated values to lists
                        item.SupplierNames = supplierNamesString.Split(',').Select(s => s.Trim()).ToList();
                        item.SupplierIds = supplierIdsString.Split(',').Select(s => s.Trim()).ToList();
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return item;
        }



        public List<string> GetAllUnits()
        {
            List<string> units = new List<string>();
            string query = "SELECT DISTINCT unit FROM tbItem";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    units.Add(reader["unit"] as string ?? "");
                }
                reader.Close();
            }
            return units;
        }

        public List<string> GetAllCategories()
        {
            List<string> categories = new List<string>();
            string query = "SELECT DISTINCT category FROM tbItem";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    categories.Add(reader["category"] as string ?? "");
                }
                reader.Close();
            }
            return categories;
        }

        public List<Item> FilterItems(string category, string supplier, string unit)
        {
            List<Item> filteredItems = new List<Item>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Build the base query to select items
                StringBuilder query = new StringBuilder(@"
            SELECT 
                i.item_id, 
                i.productCode, 
                i.productDescription, 
                i.productQuantity, 
                i.category, 
                i.unit, 
                i.minimumstocklevel,
                -- Concatenate supplier names into a single string
                STRING_AGG(s.supplierName, ', ') AS SupplierNames
            FROM tbItem i
            LEFT JOIN tbItemSupplier isup ON i.item_id = isup.ItemId
            LEFT JOIN tbSupplier s ON isup.SupplierId = s.supplierId
            WHERE i.status = 'active'");

                List<SqlParameter> parameters = new List<SqlParameter>();

                // Filter by category if provided
                if (!string.IsNullOrEmpty(category))
                {
                    query.Append(" AND i.category = @category");
                    parameters.Add(new SqlParameter("@category", category));
                }

                // Filter by supplier if provided (specific supplier)
                if (!string.IsNullOrEmpty(supplier))
                {
                    query.Append(" AND s.supplierName = @supplier");  // Ensure we filter by specific supplier
                    parameters.Add(new SqlParameter("@supplier", supplier));
                }

                // Filter by unit if provided
                if (!string.IsNullOrEmpty(unit))
                {
                    query.Append(" AND i.unit = @unit");
                    parameters.Add(new SqlParameter("@unit", unit));
                }

                // Group by item columns to aggregate suppliers into a single string
                query.Append(@"
            GROUP BY 
                i.item_id, 
                i.productCode, 
                i.productDescription, 
                i.productQuantity, 
                i.category, 
                i.unit, 
                i.minimumstocklevel");

                SqlCommand command = new SqlCommand(query.ToString(), connection);
                command.Parameters.AddRange(parameters.ToArray());

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    filteredItems.Add(new Item
                    {

                        ItemId = Convert.ToInt32(reader["item_id"]),
                        ProductCode = reader["productCode"] as string ?? "",
                        ProductDescription = reader["productDescription"] as string ?? "",
                        Quantity = reader["productQuantity"] != DBNull.Value ? Convert.ToInt32(reader["productQuantity"]) : 0,
                        Category = reader["category"] as string ?? "",
                        Supplier = reader["SupplierNames"] as string ?? "", // Comma-separated list of supplier names
                        Unit = reader["unit"] as string ?? "",
                        MinimumStock = reader["minimumstocklevel"] != DBNull.Value ? Convert.ToInt32(reader["minimumstocklevel"]) : 0
                    });
                }
                reader.Close();
            }
            return filteredItems;
        }




            public List<Item> SearchItem(string searchQuery, string status)
            {
                List<Item> results = new List<Item>();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Query to join tbItem, tbItemSupplier, and tbSupplier to fetch the supplier names as comma-separated values
                    StringBuilder query = new StringBuilder(@"
                SELECT i.item_id, 
                       i.productCode, 
                       i.productDescription, 
                       i.productQuantity, 
                       i.category, 
                       i.unit, 
                       i.minimumstocklevel, 
                       i.status,
                       STRING_AGG(s.supplierName, ', ') AS SupplierNames
                FROM tbItem i
                LEFT JOIN tbItemSupplier isup ON i.item_id = isup.ItemId
                LEFT JOIN tbSupplier s ON isup.SupplierId = s.supplierId
                WHERE i.status = @status");

                    // Add search query if provided
                    if (!string.IsNullOrEmpty(searchQuery))
                    {
                        query.Append(" AND (i.productCode LIKE @searchQuery OR i.productDescription LIKE @searchQuery OR i.item_id LIKE @searchQuery)");
                    }

                    query.Append(" GROUP BY i.item_id, i.productCode, i.productDescription, i.productQuantity, i.category, i.unit, i.minimumstocklevel, i.status");

                    SqlCommand command = new SqlCommand(query.ToString(), connection);

                    // Add parameters to avoid SQL injection    
                    command.Parameters.AddWithValue("@status", status);
                    if (!string.IsNullOrEmpty(searchQuery))
                    {
                        command.Parameters.AddWithValue("@searchQuery", "%" + searchQuery + "%");
                    }

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        // Create an Item object for each row in the result
                        results.Add(new Item
                        {
                            ItemId = Convert.ToInt32(reader["item_id"]),
                            ProductCode = reader["productCode"] as string ?? "",
                            ProductDescription = reader["productDescription"] as string ?? "",
                            Quantity = reader["productQuantity"] != DBNull.Value ? Convert.ToInt32(reader["productQuantity"]) : 0,
                            Category = reader["category"] as string ?? "",
                            Supplier = reader["SupplierNames"] as string ?? "",  // Fetch the comma-separated supplier names
                            Unit = reader["unit"] as string ?? "",
                            MinimumStock = reader["minimumstocklevel"] != DBNull.Value ? Convert.ToInt32(reader["minimumstocklevel"]) : 0
                        });
                    }

                    reader.Close();
                }
                return results;
            }




        // Set inactive status for an item
        public void ArchiveItem(string item_id)
        {
            try
            {
                string query = "UPDATE tbItem SET status = 'inactive' WHERE item_id = @item_id";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand archiveCommand = new SqlCommand(query, connection);
                    archiveCommand.Parameters.AddWithValue("@item_id", item_id);
                    connection.Open();
                    archiveCommand.ExecuteNonQuery();
                }

                // Log the archiving action
                Log log = new Log
                {
                    TableAffected = "tbItem",
                    RecordID = Convert.ToInt32(item_id),
                    ModuleName = "Inventory",
                    Description = $"Archived item with ID {item_id}",
                    Status = "Success",
                    ActionType = "Archive"
                };

                // Call the logging method
                LogController.LogUpdate(log.TableAffected, log.RecordID, log.ModuleName, log.Description, log.Status, log.ActionType);
            }
            catch (Exception ex)
            {
                // Log the failure
                Log log = new Log
                {
                    TableAffected = "tbItem",
                    RecordID = Convert.ToInt32(item_id),
                    ModuleName = "Inventory",
                    Description = $"Failed to archive item with ID {item_id}. Error: {ex.Message}",
                    Status = "Failure",
                    ActionType = "Archive"
                };
                LogController.LogUpdate(log.TableAffected, log.RecordID, log.ModuleName, log.Description, log.Status, log.ActionType);

                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UnarchiveItem(string productCode)
        {
            try
            {
                string query = "UPDATE tbItem SET status = 'active' WHERE productCode = @productCode";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand unarchiveCommand = new SqlCommand(query, connection);
                    unarchiveCommand.Parameters.AddWithValue("@productCode", productCode);
                    connection.Open();
                    unarchiveCommand.ExecuteNonQuery();
                }

                // Log the unarchiving action
                Log log = new Log
                {
                    TableAffected = "tbItem",
                    RecordID = 0, // Assuming you don't have a specific ID for the log
                    ModuleName = "Item Management",
                    Description = $"Unarchived item with Product Code: {productCode}",
                    Status = "Success",
                    ActionType = "Unarchive"
                };
                LogController.LogUpdate(log.TableAffected, log.RecordID, log.ModuleName, log.Description, log.Status, log.ActionType);
            }
            catch (Exception ex)
            {
                // Log the failure
                Log log = new Log
                {
                    TableAffected = "tbItem",
                    RecordID = 0, // Assuming you don't have a specific ID for the log
                    ModuleName = "Item Management",
                    Description = $"Failed to unarchive item with Product Code: {productCode}. Error: {ex.Message}",
                    Status = "Failure",
                    ActionType = "Unarchive"
                };
                LogController.LogUpdate(log.TableAffected, log.RecordID, log.ModuleName, log.Description, log.Status, log.ActionType);

                // Show error message
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Add item to the database
        public void AddItem(Item item)
        {
            string query = "INSERT INTO tbItem (item_id, productCode, productDescription, productQuantity, category, unit, minimumstocklevel, status, created_at) VALUES (@item_id, @productCode, @productDescription, @productQuantity, @category, @unit, @minimumstocklevel, @status, @created_at)";
            DateTime dateTime = DateTime.Now;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand addCommand = new SqlCommand(query, connection);
                addCommand.Parameters.AddWithValue("@item_id", item.ItemId);
                addCommand.Parameters.AddWithValue("@productCode", item.ProductCode);
                addCommand.Parameters.AddWithValue("@productDescription", item.ProductDescription);
                addCommand.Parameters.AddWithValue("@productQuantity", item.Quantity);
                addCommand.Parameters.AddWithValue("@unit", item.Unit);
                addCommand.Parameters.AddWithValue("@category", item.Category);
                addCommand.Parameters.AddWithValue("@minimumstocklevel", item.MinimumStock);
                addCommand.Parameters.AddWithValue("@status", "active");
                addCommand.Parameters.AddWithValue("@created_at", dateTime);

                connection.Open();
                addCommand.ExecuteNonQuery();
            }

            Log log = new Log
            {
                TableAffected = "tbItem",
                RecordID = item.ItemId,
                ModuleName = "Inventory",
                Description = $"Added new item: ID {item.ItemId}, Code {item.ProductCode}, Name {item.ProductDescription}",
                Status = "Success",
                ActionType = "Add"
            };

            // Call the logging method
            LogController.LogUpdate(log.TableAffected, log.RecordID, log.ModuleName, log.Description, log.Status, log.ActionType);

        }



        // Update an existing item in the database
        public void UpdateItem(string item_id, string productDescription, string category, List<int> supplierIds, string unit, int minimumstocklevel)
        {
            try
            {
                if (item_id == null)
                {
                    MessageBox.Show("Error message: Item ID is null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Retrieve the existing item data before update to compare with the new data
                Item existingItem = GetItemById(item_id);

                string query = "UPDATE tbItem SET productDescription = @productDescription, category = @category, unit = @unit, minimumstocklevel = @minimumstocklevel, updated_at = @updated_at WHERE item_id = @item_id";
                DateTime dateTime = DateTime.Now;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Update the tbItem table
                    SqlCommand updateCommand = new SqlCommand(query, connection);
                    updateCommand.Parameters.AddWithValue("@item_id", item_id);
                    updateCommand.Parameters.AddWithValue("@productDescription", productDescription);
                    updateCommand.Parameters.AddWithValue("@category", category);
                    updateCommand.Parameters.AddWithValue("@unit", unit);
                    updateCommand.Parameters.AddWithValue("@minimumstocklevel", minimumstocklevel);
                    updateCommand.Parameters.AddWithValue("@updated_at", dateTime);

                    connection.Open();
                    updateCommand.ExecuteNonQuery();

                    // Update the tbItemSupplier table
                    // Remove existing relationships for this item_id
                    string deleteQuery = "DELETE FROM tbItemSupplier WHERE ItemId = @itemId";
                    SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
                    deleteCommand.Parameters.AddWithValue("@itemId", item_id);
                    deleteCommand.ExecuteNonQuery();

                    // Insert new relationships for the selected suppliers
                    string insertQuery = "INSERT INTO tbItemSupplier (ItemId, SupplierId) VALUES (@itemId, @supplierId)";
                    foreach (int supplierId in supplierIds)
                    {
                        SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                        insertCommand.Parameters.AddWithValue("@itemId", item_id);
                        insertCommand.Parameters.AddWithValue("@supplierId", supplierId);
                        insertCommand.ExecuteNonQuery();
                    }
                }

                // Log the update in the log table
                Log log = new Log
                {
                    TableAffected = "tbItem",
                    RecordID = Convert.ToInt32(item_id),
                    ModuleName = "Inventory",
                    Status = "Success",
                    ActionType = "Update"
                };

                // Generate a detailed description of the changes
                var changes = new List<string>();

                if (existingItem.ProductDescription != productDescription)
                    changes.Add($"Product Description: {existingItem.ProductDescription} -> {productDescription}");

                if (existingItem.Category != category)
                    changes.Add($"Category: {existingItem.Category} -> {category}");

                if (existingItem.Unit != unit)
                    changes.Add($"Unit: {existingItem.Unit} -> {unit}");

                if (existingItem.MinimumStock != minimumstocklevel)
                    changes.Add($"Minimum Stock Level: {existingItem.MinimumStock} -> {minimumstocklevel}");

                // Add supplier changes
                changes.Add($"Suppliers updated: {string.Join(", ", supplierIds)}");

                // Join the changes and add to the log description
                log.Description = $"Updated Item ID {item_id}: {string.Join(", ", changes)}";

                // Call a method to save the log entry
                LogController.LogUpdate(log.TableAffected, log.RecordID, log.ModuleName, log.Description, log.Status, log.ActionType);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private Item GetItemById(string item_id)
        {
            string itemQuery = "SELECT * FROM tbItem WHERE item_id = @item_id";
            string supplierQuery = "SELECT supplierId FROM tbItemSupplier WHERE itemId = @itemId";

            Item item = null;
            List<string> supplierIds = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Fetch the item details
                using (SqlCommand itemCommand = new SqlCommand(itemQuery, connection))
                {
                    itemCommand.Parameters.AddWithValue("@item_id", item_id);

                    SqlDataReader reader = itemCommand.ExecuteReader();
                    if (reader.Read())
                    {
                        item = new Item
                        {
                            ItemId = Convert.ToInt32(reader["item_id"]),
                            ProductCode = reader["productCode"].ToString(),
                            ProductDescription = reader["productDescription"].ToString(),
                            Category = reader["category"].ToString(),
                            // Supplier is now a list, will fetch below
                            Unit = reader["unit"].ToString(),
                            MinimumStock = Convert.ToInt32(reader["minimumstocklevel"])
                        };
                    }
                    reader.Close();
                }

                if (item == null)
                {
                    // If the item is not found, return null
                    return null;
                }

                // Fetch associated suppliers
                using (SqlCommand supplierCommand = new SqlCommand(supplierQuery, connection))
                {
                    supplierCommand.Parameters.AddWithValue("@itemId", item_id);

                    SqlDataReader supplierReader = supplierCommand.ExecuteReader();
                    while (supplierReader.Read())
                    {
                        supplierIds.Add(supplierReader["supplierId"].ToString());
                    }
                    supplierReader.Close();
                }
            }

            // Add the supplier IDs as a list of strings to the item object
            item.SupplierIds = supplierIds;

            return item;
        }


        public static int GenerateItemId()
        {
            try
            {
                int item_id;
                bool isUnique;
                do
                {
                    Random random = new Random();
                    item_id = random.Next(100000, 999999);
                    string query = "SELECT COUNT(*) FROM tbItem WHERE item_id = @item_id";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand checkCommand = new SqlCommand(query, connection);
                        checkCommand.Parameters.AddWithValue("@item_id", item_id);
                        connection.Open();
                        int count = (int)checkCommand.ExecuteScalar();
                        isUnique = count == 0;
                    }
                } while (!isUnique);
                return item_id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to generate an item id: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        // Method to save a list of items to the database
        public void SaveItemsToDatabase(List<Item> items)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                DateTime dateTime = DateTime.Now;

                bool skipAllDuplicates = false; // Flag to track whether the user wants to skip all duplicates

                foreach (var item in items)
                {
                    int uniqueItemId = GenerateItemId(); // Generate unique item ID
                    // Check if the item already exists in the database with the same productCode and unit
                    string checkQuery = "SELECT COUNT(*) FROM tbItem WHERE item_id = @item_id AND productCode = @ItemCode AND unit = @Unit";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@item_id", uniqueItemId);
                        checkCmd.Parameters.AddWithValue("@ItemCode", item.ProductCode);
                        checkCmd.Parameters.AddWithValue("@Unit", item.Unit);
                        int count = (int)checkCmd.ExecuteScalar();

                        // If the item already exists (count > 0) with the same productCode and unit
                        if (count > 0)
                        {
                            if (!skipAllDuplicates) // Check if we are not skipping all
                            {
                                // Show a MessageBox with Yes, No, and Skip All options
                                var result = MessageBox.Show($"Item code {item.ProductCode} with unit {item.Unit} already exists in the database. Do you want to skip this item, skip all duplicates, or continue?",
                                                             "Duplicate Detected",
                                                             MessageBoxButtons.YesNoCancel,
                                                             MessageBoxIcon.Warning);

                                if (result == DialogResult.No)
                                {
                                    return; // Exit the process if the user clicks "No"
                                }

                                if (result == DialogResult.Cancel)
                                {
                                    skipAllDuplicates = true; // Set the flag to skip all duplicates
                                    continue; // Skip the current duplicate and proceed to the next
                                }
                            }
                            else
                            {
                                continue; // Skip all duplicates if the flag is set
                            }
                        }
                    }

                    // If item doesn't exist with the same productCode and unit, insert the new item
                    string query = @"
                INSERT INTO tbItem (item_id, productCode, productDescription, unit, productQuantity, category, minimumstocklevel, status, created_at)
                VALUES (@ItemId, @ItemCode, @ItemName, @Unit, @Quantity, @Category, @MinimumStockLevel, @Status, @Created_at)";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ItemId", uniqueItemId);
                        cmd.Parameters.AddWithValue("@ItemCode", item.ProductCode);
                        cmd.Parameters.AddWithValue("@ItemName", item.ProductDescription);
                        cmd.Parameters.AddWithValue("@Unit", item.Unit);
                        cmd.Parameters.AddWithValue("@Quantity", item.Quantity);
                        cmd.Parameters.AddWithValue("@Category", item.Category);
                        cmd.Parameters.AddWithValue("@MinimumStockLevel", item.MinimumStock);
                        cmd.Parameters.AddWithValue("@Status", "active");
                        cmd.Parameters.AddWithValue("@Created_at", dateTime);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }




    }
}
