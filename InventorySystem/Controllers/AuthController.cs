using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using InventorySystem.Models;
using InventorySystem.Services;
using System.Configuration;
using InventorySystem.Services;

namespace InventorySystem.Controllers
{
    public static class SessionData
    {
        public static int UserId { get; set; }
    }
    public class AuthController
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["InventoryDb"].ConnectionString;
        private AuthenticationService AuthService = new AuthenticationService();
        private LogController LogController = new LogController();

        public (bool Success, string Role, string UserID, bool IsFirstLogin, string ErrorMessage) LOGINUSER(string username, string password)
        {
            try
            {
                // Query to retrieve user data including the status field
                string query = @"SELECT password, username, firstname, lastname, contact_number, address, role, user_id, is_first_login, status 
                         FROM tbUser WHERE username = @username";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@username", username);
                    connection.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Check if user is inactive
                        string status = reader["status"] as string;
                        if (status == "inactive")
                        {
                            // If inactive, return a failure result and message
                            return (false, null, null, false, "Your account is inactive. Please contact support.");
                        }

                        // Password verification
                        string storedHash = reader["password"] as string;
                        if (BCrypt.Net.BCrypt.Verify(password, storedHash))
                        {
                            // Retrieve user information after successful password verification
                            string role = reader["role"] as string;
                            int userId = reader["user_id"] != DBNull.Value ? Convert.ToInt32(reader["user_id"]) : 0;
                            string toStringId = userId.ToString();
                            bool isFirstLogin = (bool)reader["is_first_login"];

                            // Log the successful login
                            LogController.LogUserLogin(userId, true, role, isFirstLogin);

                            // Proceed with authentication
                            AuthService.Authenticated();

                            // Return success result
                            return (true, role, toStringId, isFirstLogin, null);
                        }
                        else
                        {
                            // Invalid password
                            return (false, null, null, false, "Invalid username or password.");
                        }
                    }
                    else
                    {
                        // Username not found
                        return (false, null, null, false, "Invalid username or password.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (false, null, null, false, "An error occurred during the login process.");
            }
        }



        public void UpdateFirstLoginStatus(string username)
        {
            try
            {
                string query = @"UPDATE tbUser SET is_first_login = 0 WHERE username = @username";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public bool CheckMatchPassword(string username, string password)
        {
            try
            {
                string query = @"SELECT password FROM tbUser WHERE username = @username";
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
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public bool CheckMatchPasswordAdmin(int user_id, string password)
        {
            try
            {
                string query = @"SELECT password FROM tbUser WHERE user_id = @user_id";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@user_id", user_id);
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string storedHash = reader["password"] as string;
                        if (BCrypt.Net.BCrypt.Verify(password, storedHash))
                        {
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        } 
            public bool UpdatePassword(string username, string newPassword)
        {
            try
            {
                string query = @"UPDATE tbUser SET password = @password WHERE username = @username";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@password", BCrypt.Net.BCrypt.HashPassword(newPassword));
                    cmd.Parameters.AddWithValue("@username", username);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool UpdatePasswordAdmin(int user_id, string newPassword)
        {
            try
            {
                string query = @"UPDATE tbUser SET password = @password WHERE user_id = @user_id";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@password", BCrypt.Net.BCrypt.HashPassword(newPassword));
                    cmd.Parameters.AddWithValue("@user_id", user_id);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool UpdateAdminInfo(int user_id, string firstname, string lastname, string username)
        {
            try
            {
                string query = @"UPDATE tbUser SET firstname = @firstname, lastname = @lastname, username = @username WHERE user_id = @user_id";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@firstname", firstname);
                    cmd.Parameters.AddWithValue("@lastname", lastname);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@user_id", user_id);   
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool UpdateEmployeeInfo(int user_id, string firstname, string lastname, string username, string contact, string address)
        {
            try
            {
                string query = @"UPDATE tbUser SET firstname = @firstname, lastname = @lastname, username = @username, contact_number = @contact, address = @address WHERE user_id = @user_id";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@firstname", firstname);
                    cmd.Parameters.AddWithValue("@lastname", lastname);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@contact", contact);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@user_id", user_id);
                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public Employee GetEmployeeData(int id)
        {
            try
            {
                string query = @"SELECT * FROM tbUser WHERE user_id = @id";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@id", id);
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        Employee employee = new Employee
                        {
                            EmployeeID = reader["user_id"] as string,
                            Firstname = reader["firstname"] as string,
                            Lastname = reader["lastname"] as string,
                            Username = reader["username"] as string,
                            Contact = reader["contact_number"] as string,
                            Address = reader["address"] as string
                        };
                        return employee;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;

        }

    }
    
}
