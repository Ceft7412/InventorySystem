﻿using System;
using Microsoft.Data.SqlClient;
using InventorySystem.Models;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.Controllers
{
    public class ItemController
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\cedri\Documents\inventoryDB.mdf;Integrated Security=True;Connect Timeout=30";
        Item item;


        

        // Get all items from the database
        public List<Item> GetAllItems(string status)
        {
            try
            {
                List<Item> items = new List<Item>();
                string query = "SELECT productCode, productDescription, productQuantity, category, supplier, unit, minimumstocklevel FROM tbItem WHERE status = @status";

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
        public Item GetItemData(string itemCode)
        {
            try
            {
                string query = "SELECT productCode, productDescription, category, supplier, unit, minimumstocklevel FROM tbItem WHERE productCode = @productCode";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@productCode", itemCode);
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

        public List<Item> SearchItem(string searchQuery, string status)
        {
            List<Item> results = new List<Item>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM tbItem WHERE (productCode LIKE @searchQuery OR productDescription LIKE @searchQuery) AND status = @status";
                SqlCommand searchCommand = new SqlCommand(query, connection);
                searchCommand.Parameters.AddWithValue("@searchQuery", "%" + searchQuery + "%");
                searchCommand.Parameters.AddWithValue("@status", status);
                connection.Open();
                SqlDataReader reader = searchCommand.ExecuteReader();
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
        public void ArchiveItem(string productCode)
        {
            try
            {
                string query = "UPDATE tbItem SET status = 'inactive' WHERE productCode = @productCode";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand archiveCommand = new SqlCommand(query, connection);
                    archiveCommand.Parameters.AddWithValue("@productCode", productCode);
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
            string query = "INSERT INTO tbItem (productCode, productDescription, productQuantity, category, supplier, unit, minimumstocklevel, status, created_at) VALUES (@productCode, @productDescription, @productQuantity, @category, @supplier, @unit, @minimumstocklevel, @status, @created_at)";
            DateTime dateTime = DateTime.Now;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand addCommand = new SqlCommand(query, connection);
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
        public void UpdateItem(string productCode, string productDescription, string category, string supplier, string unit, int minimumstocklevel)
        {
            try
            {
                if (productCode == null)
                {
                    MessageBox.Show("Error message: Product code is null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                string query = "UPDATE tbItem SET productDescription = @productDescription, category = @category, supplier = @supplier, unit = @unit, minimumstocklevel = @minimumstocklevel, updated_at = @updated_at WHERE productCode = @productCode";
                DateTime dateTime = DateTime.Now;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand updateCommand = new SqlCommand(query, connection);
                    updateCommand.Parameters.AddWithValue("@productCode", productCode);
                    updateCommand.Parameters.AddWithValue("@productDescription", productDescription);
                    updateCommand.Parameters.AddWithValue("@unit", unit);
                    updateCommand.Parameters.AddWithValue("@category", category);
                    updateCommand.Parameters.AddWithValue("@supplier", supplier);
                    updateCommand.Parameters.AddWithValue("@minimumstocklevel", minimumstocklevel);
                    connection.Open();
                    updateCommand.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}