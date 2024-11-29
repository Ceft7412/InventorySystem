using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InventorySystem.Models;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace InventorySystem.Controllers
{
    public class EmployeeController
    {

        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\cedri\Documents\inventoryDB.mdf;Integrated Security=True;Connect Timeout=30";

        
        public List<Employee> FETCH_EMPLOYEES()
        {
            try
            {
                List<Employee> employees = new List<Employee>();
                string query = @"SELECT user_id, firstname, lastname, contact_number, address FROM tbUser";
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        employees.Add(new Employee()
                        {
                            EmployeeID = reader["user_id"].ToString(),
                            Firstname = reader["firstname"].ToString(),
                            Lastname = reader["lastname"].ToString(),
                            Contact = (int)reader["contact_number"],
                            Address = reader["address"].ToString()
                        });
                    }
                    reader.Close();

                }
                return employees;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Employee>();
            }
        }


        public void ADDEMPLOYEE(string firstname, string lastname, long contact, string address)
        {
            try
            {

                var employeeDetails = GENERATE_EMPLOYEE_DETAILS(firstname);
                string employeeId;
                string username;
                string default_password = BCrypt.Net.BCrypt.HashPassword("123");
                string role = "employee";
                if (employeeDetails != null)
                {
                    employeeId = "E" + employeeDetails.Item1.ToString(); // Output: E539239
                    username = employeeDetails.Item2.ToLower(); // Get the username
                }
                else
                {
                    MessageBox.Show("Error message: Failed to generate employee details. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if employee ID already exists in the database.
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string checkQuery = "SELECT COUNT(*) FROM tbUser WHERE user_id = @user_id";
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, conn))
                    {
                        checkCommand.Parameters.AddWithValue("@user_id", employeeId);

                        int count = (int)checkCommand.ExecuteScalar();

                        if (count > 0) // If employeeId already exists, stop and notify the user
                        {
                            MessageBox.Show($"Error message: Employee ID {employeeId} already exists in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }


                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO tbUser(user_id, username, firstname, lastname, contact_number, password, address, role, is_first_login) VALUES (@user_id, @username, @firstname, @lastname, @contact_number, @password, @address, @role, @is_first_login)";

                    SqlCommand command = new SqlCommand(query,connection);
                    command.Parameters.AddWithValue("@user_id", employeeId);
                    command.Parameters.AddWithValue("@username", employeeDetails.Item2);
                    command.Parameters.AddWithValue("@firstname", firstname);
                    command.Parameters.AddWithValue("@lastname", lastname);
                    command.Parameters.AddWithValue("@password", default_password);
                    command.Parameters.AddWithValue("@contact_number", contact);
                    command.Parameters.AddWithValue("@address", address);
                    command.Parameters.AddWithValue("@role", role);
                    command.Parameters.AddWithValue("@is_first_login", 1);

                    command.ExecuteNonQuery();


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public int GENERATE_EMPLOYEE_ID()
        {
            try
            {
                Random random = new Random();

                // initial id is 0
                int employee_id = 0;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    bool isUnique = false;
                    while (!isUnique)
                    {
                        // Generate a 6-digit random number
                        employee_id = random.Next(100000, 1000000);

                        // Check if the generated ID exists in the database
                        string query = "SELECT COUNT(*) FROM tbUser WHERE user_id = @employee_id";
                        //
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@employee_id", employee_id);
                            int count = (int)command.ExecuteScalar();

                            if (count == 0) // If the ID is not found in the table, it's unique
                            {
                                isUnique = true;
                            }
                        }
                    }
                }

                return employee_id;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        public Tuple<long, string> GENERATE_EMPLOYEE_DETAILS(string firstname)
        {
            try
            {
                // Generate unique employee ID
                int employee_id = GENERATE_EMPLOYEE_ID();

                // Generate username based on firstname and employee ID
                string new_username = firstname + employee_id.ToString();

                // Return both employee ID and username as a Tuple
                return new Tuple<long, string>(employee_id, new_username);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

    }
}
