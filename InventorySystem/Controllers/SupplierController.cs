using InventorySystem.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace InventorySystem.Controllers
{
    public class SupplierController
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["InventoryDb"].ConnectionString;
        private LogController LogController = new LogController();
        Supplier supplier;
        public List<Supplier> GetAllSuppliers(string status)
        {
            try
            {
                List<Supplier> suppliers = new List<Supplier>();
                string query = "SELECT supplierId, supplierName, supplierContact, supplierAddress FROM tbSupplier WHERE supplierStatus = @supplierStatus";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@supplierStatus", status);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        supplier = new Supplier
                        {
                            SupplierId = Convert.ToInt32(reader["supplierId"]),
                            SupplierName = reader["supplierName"] as string ?? "",
                            SupplierContact = reader["supplierContact"] as string ?? "",
                            SupplierAddress = reader["supplierAddress"] as string ?? ""
                        };
                        suppliers.Add(supplier);
                    }
                    reader.Close();
                }
                return suppliers;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load suppliers: " + ex.Message);
                return new List<Supplier>();
            }
        }

        public List<Supplier> GetAllSupplierNames()
        {
            List<Supplier> suppliers = new List<Supplier>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT supplierId, supplierName FROM tbSupplier WHERE supplierStatus = @supplierStatus";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@supplierStatus", "active");

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    suppliers.Add(new Supplier
                    {
                        SupplierId = Convert.ToInt32(reader["supplierId"]),
                        SupplierName = reader["supplierName"] as string ?? ""
                    });
                }

                reader.Close();
            }
          
            return suppliers;
        }
        public void InsertItemSupplier(int itemId, int supplierId)
        {
            try
            {
                // Insert into the tbItemSupplier table
                string query = "INSERT INTO tbItemSupplier (ItemId, SupplierId) VALUES (@itemId, @supplierId)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@itemId", itemId);
                    command.Parameters.AddWithValue("@supplierId", supplierId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<Supplier> SearchSupplier(string supplierQuery, string status)
        {
            List<Supplier> results = new List<Supplier>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM tbSupplier WHERE (supplierName LIKE @supplierQuery OR supplierId LIKE @supplierQuery) AND supplierStatus = @supplierStatus";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@supplierQuery", "%" + supplierQuery + "%");
                command.Parameters.AddWithValue("@supplierStatus", status);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    results.Add(new Supplier
                    {
                        SupplierId = Convert.ToInt32(reader["supplierId"]),
                        SupplierName = reader["supplierName"] as string ?? "",
                        SupplierContact = reader["supplierContact"] as string ?? "",
                        SupplierAddress = reader["supplierAddress"] as string ?? ""
                    });
                }
                reader.Close();
            }
            return results;
        }

        public Supplier GetItemData(string supplierId)
        {
            try
            {
                string query = "SELECT supplierId, supplierName, supplierContact, supplierAddress FROM tbSupplier WHERE supplierId = @supplierId";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@supplierId", supplierId);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        supplier = new Supplier
                        {
                            SupplierId = Convert.ToInt32(reader["supplierId"]),
                            SupplierName = reader["supplierName"] as string ?? "",
                            SupplierContact = reader["supplierContact"] as string ?? "",
                            SupplierAddress = reader["supplierAddress"] as string ?? ""
                        };
                    }
                    reader.Close();
                }
                return supplier;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private string GenerateUniqueSupplierId()
        {
            string supplierId;
            bool isUnique = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                while (!isUnique)
                {
                    // Generate a random 6-digit number
                    supplierId = new Random().Next(100000, 999999).ToString();

                    // Check if the generated ID already exists in the database
                    string query = "SELECT COUNT(1) FROM tbSupplier WHERE supplierId = @supplierId";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@supplierId", supplierId);
                        int count = Convert.ToInt32(command.ExecuteScalar());

                        if (count == 0) // If no existing supplier found with this ID
                        {
                            isUnique = true;
                            return supplierId;
                        }
                    }
                }
            }

            // This should never be reached, but returning a fallback value
            throw new Exception("Unable to generate a unique Supplier ID.");
        }


        public void CreateSupplier(string supplierName, string supplierContact, string supplierAddress)
        {
            try
            {
                // Generate a unique supplier ID
                string supplierId = GenerateUniqueSupplierId();

                string query = "INSERT INTO tbSupplier (supplierId, supplierName, supplierContact, supplierAddress, supplierStatus) VALUES (@supplierId, @supplierName, @supplierContact, @supplierAddress, @supplierStatus)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@supplierId", supplierId);
                    command.Parameters.AddWithValue("@supplierName", supplierName);
                    command.Parameters.AddWithValue("@supplierContact", supplierContact);
                    command.Parameters.AddWithValue("@supplierAddress", supplierAddress);
                    command.Parameters.AddWithValue("@supplierStatus", "active");
                    connection.Open();
                    command.ExecuteNonQuery();
                }

                // Log the successful creation of the supplier
                Log log = new Log
                {
                    TableAffected = "tbSupplier",
                    RecordID = 0, // Set to 0 if supplier ID is non-numeric
                    ModuleName = "Supplier Management",
                    Description = $"Created supplier with Name: {supplierName}, Contact: {supplierContact}, Address: {supplierAddress}, Supplier ID: {supplierId}",
                    Status = "Success",
                    ActionType = "Create"
                };
                LogController.LogUpdate(log.TableAffected, log.RecordID, log.ModuleName, log.Description, log.Status, log.ActionType);
            }
            catch (Exception ex)
            {
                // Log the failure
                Log log = new Log
                {
                    TableAffected = "tbSupplier",
                    RecordID = 0, // No specific record if the operation failed before creation
                    ModuleName = "Supplier Management",
                    Description = $"Failed to create supplier. Error: {ex.Message}",
                    Status = "Failure",
                    ActionType = "Create"
                };
                LogController.LogUpdate(log.TableAffected, log.RecordID, log.ModuleName, log.Description, log.Status, log.ActionType);

                MessageBox.Show("Error message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public void UpdateSupplier(int supplierId, string newSupplierName, string newSupplierContact, string newSupplierAddress)
        {
            try
            {
                // Fetch the current supplier details for comparison
                string selectQuery = "SELECT supplierName, supplierContact, supplierAddress FROM tbSupplier WHERE supplierId = @supplierId";
                string query = "UPDATE tbSupplier SET supplierName = @supplierName, supplierContact = @supplierContact, supplierAddress = @supplierAddress WHERE supplierId = @supplierId";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Get current supplier details
                    SqlCommand selectCommand = new SqlCommand(selectQuery, connection);
                    selectCommand.Parameters.AddWithValue("@supplierId", supplierId);
                    SqlDataReader reader = selectCommand.ExecuteReader();

                    string currentSupplierName = "";
                    string currentSupplierContact = "";
                    string currentSupplierAddress = "";

                    if (reader.Read())
                    {
                        currentSupplierName = reader["supplierName"] as string;
                        currentSupplierContact = reader["supplierContact"] as string;
                        currentSupplierAddress = reader["supplierAddress"] as string;
                    }
                    reader.Close();

                    // Detect changes and build the log description
                    List<string> changes = new List<string>();

                    if (currentSupplierName != newSupplierName)
                        changes.Add($"Name changed from '{currentSupplierName}' to '{newSupplierName}'");
                    if (currentSupplierContact != newSupplierContact)
                        changes.Add($"Contact changed from '{currentSupplierContact}' to '{newSupplierContact}'");
                    if (currentSupplierAddress != newSupplierAddress)
                        changes.Add($"Address changed from '{currentSupplierAddress}' to '{newSupplierAddress}'");

                    // Update the supplier
                    SqlCommand updateCommand = new SqlCommand(query, connection);
                    updateCommand.Parameters.AddWithValue("@supplierId", supplierId);
                    updateCommand.Parameters.AddWithValue("@supplierName", newSupplierName);
                    updateCommand.Parameters.AddWithValue("@supplierContact", newSupplierContact);
                    updateCommand.Parameters.AddWithValue("@supplierAddress", newSupplierAddress);
                    updateCommand.ExecuteNonQuery();

                    // Log the updates
                    if (changes.Count > 0)
                    {
                        string description = string.Join(", ", changes);

                        Log log = new Log
                        {
                            TableAffected = "tbSupplier",
                            RecordID = Convert.ToInt32(supplierId),
                            ModuleName = "Supplier Management",
                            Description = $"Updated Supplier: {description}",
                            Status = "Success",
                            ActionType = "Update"
                        };
                        LogController.LogUpdate(log.TableAffected, log.RecordID, log.ModuleName, log.Description, log.Status, log.ActionType);
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the failure
                Log log = new Log
                {
                    TableAffected = "tbSupplier",
                    RecordID = Convert.ToInt32(supplierId),
                    ModuleName = "Supplier Management",
                    Description = $"Failed to update supplier. Error: {ex.Message}",
                    Status = "Failure",
                    ActionType = "Update"
                };
                LogController.LogUpdate(log.TableAffected, log.RecordID, log.ModuleName, log.Description, log.Status, log.ActionType);

                throw ex; // Re-throw the exception for higher-level handling
            }
        }


        public void UnarchiveSupplier(string supplierId)
        {
            try
            {
                string query = "UPDATE tbSupplier SET supplierStatus = @supplierStatus WHERE supplierId = @supplierId";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@supplierId", supplierId);
                    command.Parameters.AddWithValue("@supplierStatus", "active");
                    connection.Open();
                    command.ExecuteNonQuery();
                }

                // Log the unarchiving action
                Log log = new Log
                {
                    TableAffected = "tbSupplier",
                    RecordID = Convert.ToInt32(supplierId),
                    ModuleName = "Supplier Management",
                    Description = $"Unarchived Supplier with ID {supplierId}. Status changed to 'active'.",
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
                    TableAffected = "tbSupplier",
                    RecordID = Convert.ToInt32(supplierId),
                    ModuleName = "Supplier Management",
                    Description = $"Failed to unarchive Supplier with ID {supplierId}. Error: {ex.Message}",
                    Status = "Failure",
                    ActionType = "Unarchive"
                };
                LogController.LogUpdate(log.TableAffected, log.RecordID, log.ModuleName, log.Description, log.Status, log.ActionType);

                // Display error message to the user
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void ArchiveSupplier(string supplierId)
        {
            try
            {
                string query = "UPDATE tbSupplier SET supplierStatus = @supplierStatus WHERE supplierId = @supplierId";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@supplierId", supplierId);
                    command.Parameters.AddWithValue("@supplierStatus", "inactive");
                    connection.Open();
                    command.ExecuteNonQuery();
                }

                // Log the archiving action
                Log log = new Log
                {
                    TableAffected = "tbSupplier",
                    RecordID = Convert.ToInt32(supplierId),
                    ModuleName = "Supplier Management",
                    Description = $"Archived Supplier with ID {supplierId}. Status changed to 'inactive'.",
                    Status = "Success",
                    ActionType = "Archive"
                };
                LogController.LogUpdate(log.TableAffected, log.RecordID, log.ModuleName, log.Description, log.Status, log.ActionType);
            }
            catch (Exception ex)
            {
                // Log the failure
                Log log = new Log
                {
                    TableAffected = "tbSupplier",
                    RecordID = Convert.ToInt32(supplierId),
                    ModuleName = "Supplier Management",
                    Description = $"Failed to archive Supplier with ID {supplierId}. Error: {ex.Message}",
                    Status = "Failure",
                    ActionType = "Archive"
                };
                LogController.LogUpdate(log.TableAffected, log.RecordID, log.ModuleName, log.Description, log.Status, log.ActionType);

                // Display error message to the user
                MessageBox.Show("Error message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
