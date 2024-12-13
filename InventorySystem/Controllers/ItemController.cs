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
        Item item;


        

        // Get all items from the database
        public List<Item> GetAllItems(string status)
        {
            try
            {
                List<Item> items = new List<Item>();
                string query = "SELECT item_id, productCode, productDescription, productQuantity, category, supplier, unit, minimumstocklevel FROM tbItem WHERE status = @status";

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
                            ProductCode = reader["productCode"] as string ?? "", // Safely cast to string, if null then use ""
                            ProductDescription = reader["productDescription"] as string ?? "",
                            Quantity = reader["productQuantity"] != DBNull.Value ? Convert.ToInt32(reader["productQuantity"]) : 0, // Check for DBNull
                            Category = reader["category"] as string ?? "",
                            Supplier = reader["supplier"] as string ?? "",
                            Unit = reader["unit"] as string ?? "",
                            MinimumStock = reader["minimumstocklevel"] != DBNull.Value ? Convert.ToInt32(reader["minimumstocklevel"]) : 0 // Check for DBNull
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
            try
            {
                MessageBox.Show(item_id);
                string query = "SELECT item_id, productCode, productDescription, category, supplier, unit, minimumstocklevel FROM tbItem WHERE item_id = @item_id";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    int id = Convert.ToInt32(item_id);
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@item_id", id);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {

                        // Check if the reader has any rows
                        if (!reader.HasRows)
                        {
                            return null;
                        }

                        item = new Item
                        {
                            ItemId = reader["item_id"] != DBNull.Value ? Convert.ToInt32(reader["item_id"]) : 0,
                            ProductCode = reader["productCode"] as string ?? "",
                            ProductDescription = reader["productDescription"] as string ?? "",
                            Category = reader["category"] as string ?? "",
                            Supplier = reader["supplier"] as string ?? "",
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
                StringBuilder query = new StringBuilder("SELECT * FROM tbItem WHERE status = 'active'");
                List<SqlParameter> parameters = new List<SqlParameter>();

                if (!string.IsNullOrEmpty(category))
                {
                    query.Append(" AND category = @category");
                    parameters.Add(new SqlParameter("@category", category));
                }
                if (!string.IsNullOrEmpty(supplier))
                {
                    query.Append(" AND supplier = @supplier");
                    parameters.Add(new SqlParameter("@supplier", supplier));
                }
                if (!string.IsNullOrEmpty(unit))
                {
                    query.Append(" AND unit = @unit");
                    parameters.Add(new SqlParameter("@unit", unit));
                }
                SqlCommand command = new SqlCommand(query.ToString(), connection);
                command.Parameters.AddRange(parameters.ToArray());

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    filteredItems.Add(new Item
                    {
                        ProductCode = reader["productCode"] as string ?? "",
                        ProductDescription = reader["productDescription"] as string ?? "",
                        Quantity = reader["productQuantity"] != DBNull.Value ? Convert.ToInt32(reader["productQuantity"]) : 0,
                        Category = reader["category"] as string ?? "",
                        Supplier = reader["supplier"] as string ?? "",
                        Unit = reader["unit"] as string ?? "",
                        MinimumStock = reader["minimumstocklevel"] != DBNull.Value ? Convert.ToInt32(reader["minimumstocklevel"]) : 0
                    });
                }
                reader.Close();
            }
            return filteredItems;
        }

        public List<Item> SearchItem(string searchQuery, string status, string category = null, string supplier = null, string unit = null)
        {
            List<Item> results = new List<Item>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                StringBuilder query = new StringBuilder("SELECT * FROM tbItem WHERE status = @status");

                // Add search query if provided
                if (!string.IsNullOrEmpty(searchQuery))
                {
                    query.Append(" AND (productCode LIKE @searchQuery OR productDescription LIKE @searchQuery)");
                }

                // Add category filter if provided
                if (!string.IsNullOrEmpty(category))
                {
                    query.Append(" AND category = @category");
                }

                // Add supplier filter if provided
                if (!string.IsNullOrEmpty(supplier))
                {
                    query.Append(" AND supplier = @supplier");
                }

                // Add unit filter if provided
                if (!string.IsNullOrEmpty(unit))
                {
                    query.Append(" AND unit = @unit");
                }

                SqlCommand command = new SqlCommand(query.ToString(), connection);

                // Add parameters to avoid SQL injection    
                command.Parameters.AddWithValue("@status", status);
                if (!string.IsNullOrEmpty(searchQuery))
                {
                    command.Parameters.AddWithValue("@searchQuery", "%" + searchQuery + "%");
                }
                if (!string.IsNullOrEmpty(category))
                {
                    command.Parameters.AddWithValue("@category", category);
                }
                if (!string.IsNullOrEmpty(supplier))
                {
                    command.Parameters.AddWithValue("@supplier", supplier);
                }
                if (!string.IsNullOrEmpty(unit))
                {
                    command.Parameters.AddWithValue("@unit", unit);
                }

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    results.Add(new Item
                    {
                        ProductCode = reader["productCode"] as string ?? "",
                        ProductDescription = reader["productDescription"] as string ?? "",
                        Quantity = reader["productQuantity"] != DBNull.Value ? Convert.ToInt32(reader["productQuantity"]) : 0,
                        Category = reader["category"] as string ?? "",
                        Supplier = reader["supplier"] as string ?? "",
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
            }
            catch (Exception ex)
            {

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

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Add item to the database
        public void AddItem(Item item)
        {
            string query = "INSERT INTO tbItem (item_id, productCode, productDescription, productQuantity, category, supplier, unit, minimumstocklevel, status, created_at) VALUES (@item_id, @productCode, @productDescription, @productQuantity, @category, @supplier, @unit, @minimumstocklevel, @status, @created_at)";
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
                addCommand.Parameters.AddWithValue("@supplier", item.Supplier);
                addCommand.Parameters.AddWithValue("@minimumstocklevel", item.MinimumStock);
                addCommand.Parameters.AddWithValue("@status", "active");
                addCommand.Parameters.AddWithValue("@created_at", dateTime);

                connection.Open();
                addCommand.ExecuteNonQuery();
            }
        }

       

            // Update an existing item in the database
        public void UpdateItem(string item_id, string productDescription, string category, string supplier, string unit, int minimumstocklevel)
        {
            try
            {
                if (item_id == null)
                {
                    MessageBox.Show("Error message: Item ID is null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                string query = "UPDATE tbItem SET productDescription = @productDescription, category = @category, supplier = @supplier, unit = @unit, minimumstocklevel = @minimumstocklevel, updated_at = @updated_at WHERE item_id = @item_id";
                DateTime dateTime = DateTime.Now;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand updateCommand = new SqlCommand(query, connection);
                    updateCommand.Parameters.AddWithValue("@item_id", item_id);
                    updateCommand.Parameters.AddWithValue("@productDescription", productDescription);
                    updateCommand.Parameters.AddWithValue("@unit", unit);
                    updateCommand.Parameters.AddWithValue("@category", category);
                    updateCommand.Parameters.AddWithValue("@supplier", supplier);
                    updateCommand.Parameters.AddWithValue("@minimumstocklevel", minimumstocklevel);
                    updateCommand.Parameters.AddWithValue("@updated_at", dateTime);
                    connection.Open();
                    updateCommand.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                INSERT INTO tbItem (item_id, productCode, productDescription, unit, productQuantity, supplier, category, minimumstocklevel, status, created_at)
                VALUES (@ItemId, @ItemCode, @ItemName, @Unit, @Quantity, @Supplier, @Category, @MinimumStockLevel, @Status, @Created_at)";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ItemId", uniqueItemId);
                        cmd.Parameters.AddWithValue("@ItemCode", item.ProductCode);
                        cmd.Parameters.AddWithValue("@ItemName", item.ProductDescription);
                        cmd.Parameters.AddWithValue("@Unit", item.Unit);
                        cmd.Parameters.AddWithValue("@Quantity", item.Quantity);
                        cmd.Parameters.AddWithValue("@Supplier", item.Supplier);
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
