using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace InventorySystem.Controllers
{
    public class AuthController
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\cedri\Documents\inventoryDB.mdf;Integrated Security=True;Connect Timeout=30";


        public (bool Success, string Role, bool IsFirstLogin) LOGINUSER(string username, string password)
        {
            try
            {
                string query = @"SELECT password, role, is_first_login FROM tbUser WHERE username = @username";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@username", username);
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string storedHash = reader["password"] as string;
                        if (BCrypt.Net.BCrypt.Verify(password, storedHash))
                        {
                            string role = reader["role"] as string;
                            bool isFirstLogin = (bool)reader["is_first_login"];
                            return (true, role, isFirstLogin); // Return success, role, and first login status
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return (false, null, false); // Login failed or role/first login not found
        }



    }
}
