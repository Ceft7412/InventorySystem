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
                            SupplierId = reader["supplierId"] as string ?? "",
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

        public List<string> GetAllSupplierNames()
        {
            List<string> supplierNames = new List<string>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT supplierName FROM tbSupplier WHERE supplierStatus = @supplierStatus";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@supplierStatus", "active");
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    supplierNames.Add(reader["supplierName"] as string ?? "");
                }
                reader.Close();
            }
            return supplierNames;
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
                        SupplierId = reader["supplierId"] as string ?? "",
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
                            SupplierId = reader["supplierId"] as string ?? "",
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
            
        public void CreateSupplier(string supplierId, string supplierName, string supplierContact, string supplierAddress)
        {
            try
            {
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

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void UpdateSupplier(string supplierId, string supplierName, string supplierContact, string supplierAddress)
        {
            try
            {
                string query = "UPDATE tbSupplier SET supplierName = @supplierName, supplierContact = @supplierContact, supplierAddress = @supplierAddress WHERE supplierId = @supplierId";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@supplierId", supplierId);
                    command.Parameters.AddWithValue("@supplierName", supplierName);
                    command.Parameters.AddWithValue("@supplierContact", supplierContact);
                    command.Parameters.AddWithValue("@supplierAddress", supplierAddress);
                    connection.Open();
                    command.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                throw ex;
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

            }
            catch (Exception ex)
            {
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

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
