using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InventorySystem.Models;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace InventorySystem.Controllers
{
    public class EmployeeController
    {

        private string connectionString = ConfigurationManager.ConnectionStrings["InventoryDb"].ConnectionString;
        private LogController LogController = new LogController();

        public Employee GET_EMPLOYEE_DATA(string employeeID)
        {
            try
            {
                string query = @"SELECT user_id, firstname, lastname, username, contact_number, address FROM tbUser WHERE user_id = @user_id";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@user_id", employeeID);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        return new Employee()
                        {
                            EmployeeID = reader["user_id"].ToString(),
                            Firstname = reader["firstname"].ToString(),
                            Lastname = reader["lastname"].ToString(),
                            Username = reader["username"].ToString(),
                            Contact = reader["contact_number"].ToString(),
                            Address = reader["address"].ToString()
                        };
                    }
                    else
                    {
                        return null;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }

        public List<Employee> FETCH_EMPLOYEES()
        {
            try
            {
                List<Employee> employees = new List<Employee>();
                string query = @"SELECT user_id, firstname, lastname, username, contact_number, address FROM tbUser WHERE role = 'employee' AND status = 'active'";
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
                            Username = reader["username"].ToString(),
                            Contact = reader["contact_number"].ToString(),
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

        public List<Employee> FETCH_INACTIVE_EMPLOYEES()
        {
            try
            {
                List<Employee> employees = new List<Employee>();
                string query = @"SELECT user_id, firstname, lastname, username, contact_number, address FROM tbUser WHERE role = 'employee' AND status = 'inactive'";
                using (SqlConnection connection = new SqlConnection(connectionString))
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
                            Username = reader["username"].ToString(),
                            Contact = reader["contact_number"].ToString(),
                            Address = reader["address"].ToString()
                        });
                    }
                    reader.Close();

                }
                return employees;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Employee>();
            }
        }

        public List<Employee> SEARCH_EMPLOYEE(string searchText)
        {
            try
            {
                // Define the base query to search for active employees
                string query = @"SELECT user_id, username, firstname, lastname, contact_number, address, status
                         FROM tbUser
                         WHERE status = 'active' AND (firstname LIKE @searchText OR lastname LIKE @searchText OR user_id LIKE @searchText)";

                List<Employee> employees = new List<Employee>();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Create the command with parameters
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

                    SqlDataReader reader = command.ExecuteReader();

                    // Add each found employee to the list
                    while (reader.Read())
                    {
                        Employee employee = new Employee
                        {
                            EmployeeID = reader["user_id"].ToString(),
                            Firstname = reader["firstname"].ToString(),
                            Lastname = reader["lastname"].ToString(),
                            Username = reader["username"].ToString(),
                            Contact = reader["contact_number"].ToString(),
                            Address = reader["address"].ToString()
                        };

                        employees.Add(employee);
                    }
                }

                return employees;
            }
            catch (Exception ex)
            {
                // Log the error if an exception occurs
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public List<Employee> SEARCH_INACTIVE_EMPLOYEE(string searchText)
        {
            try
            {
                // Define the base query to search for active employees
                string query = @"SELECT user_id, username, firstname, lastname, contact_number, address, status
                         FROM tbUser
                         WHERE status = 'inactive' AND (firstname LIKE @searchText OR lastname LIKE @searchText OR user_id LIKE @searchText)";

                List<Employee> employees = new List<Employee>();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Create the command with parameters
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

                    SqlDataReader reader = command.ExecuteReader();

                    // Add each found employee to the list
                    while (reader.Read())
                    {
                        Employee employee = new Employee
                        {
                            EmployeeID = reader["user_id"].ToString(),
                            Firstname = reader["firstname"].ToString(),
                            Lastname = reader["lastname"].ToString(),
                            Username = reader["username"].ToString(),
                            Contact = reader["contact_number"].ToString(),
                            Address = reader["address"].ToString()
                        };

                        employees.Add(employee);
                    }
                }

                return employees;
            }
            catch (Exception ex)
            {
                // Log the error if an exception occurs
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }





        public void ADDEMPLOYEE(string firstname, string lastname, long? contact, string address)
        {
            try
            {
                var employeeDetails = GENERATE_EMPLOYEE_DETAILS(firstname.ToLower());
                int employeeId;
                string username;
                string default_password = BCrypt.Net.BCrypt.HashPassword("123");
                string role = "employee";
                if (employeeDetails != null)
                {
                    employeeId = employeeDetails.Item1; // Output: E539239
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

                            // Log the failed attempt of adding employee
                            Log log = new Log
                            {
                                TableAffected = "tbUser",
                                RecordID = employeeId,
                                ModuleName = "Employee Management",
                                Description = $"Failed to add employee with ID {employeeId}. Employee ID already exists.",
                                Status = "Failure",
                                ActionType = "Employee Added"
                            };
                            LogController.LogUpdate(log.TableAffected, log.RecordID, log.ModuleName, log.Description, log.Status, log.ActionType);
                            return;
                        }
                    }
                }

                // Proceed with employee insertion
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO tbUser(user_id, username, firstname, lastname, contact_number, password, address, role, is_first_login, status) 
                             VALUES (@user_id, @username, @firstname, @lastname, @contact_number, @password, @address, @role, @is_first_login, @status)";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@user_id", employeeId);
                    command.Parameters.AddWithValue("@username", employeeDetails.Item2);
                    command.Parameters.AddWithValue("@firstname", firstname);
                    command.Parameters.AddWithValue("@lastname", lastname);
                    command.Parameters.AddWithValue("@password", default_password);
                    command.Parameters.AddWithValue("@contact_number", contact.HasValue ? (object)contact.Value : DBNull.Value);
                    command.Parameters.AddWithValue("@address", string.IsNullOrEmpty(address) ? DBNull.Value : (object)address);
                    command.Parameters.AddWithValue("@role", role);
                    command.Parameters.AddWithValue("@is_first_login", 1);
                    command.Parameters.AddWithValue("@status", "active");

                    command.ExecuteNonQuery();
                    connection.Close();
                    // Log the successful addition of the employee
                    Log log = new Log
                    {
                        TableAffected = "tbUser",
                        RecordID = employeeId,
                        ModuleName = "Employee Management",
                        Description = $"Employee with ID {employeeId} and username {username} added successfully.",
                        Status = "Success",
                        ActionType = "Add Employee"
                    };
                    LogController.LogUpdate(log.TableAffected, log.RecordID, log.ModuleName, log.Description, log.Status, log.ActionType);
                }

                // Notify the user of the successful addition
                MessageBox.Show("Employee added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Log the failure if any exception occurs
                Log log = new Log
                {
                    TableAffected = "tbUser",
                    RecordID = 0, // No specific record ID for failure
                    ModuleName = "Employee Management",
                    Description = $"Failed to add employee. Error: {ex.Message}",
                    Status = "Failure",
                    ActionType = "Add Employee"
                };
                LogController.LogUpdate(log.TableAffected, log.RecordID, log.ModuleName, log.Description, log.Status, log.ActionType);
            }
        }


        public bool UPDATE_EMPLOYEE(Employee employee)
        {
            try
            {
                // Initialize the query to update employee details
                string query = @"UPDATE tbUser SET firstname = @firstname, lastname = @lastname, contact_number = @contact_number, address = @address WHERE user_id = @user_id";

                // Track changes
                string changeDescription = string.Empty;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Get current employee data to compare with new values
                    string selectQuery = "SELECT firstname, lastname, contact_number, address FROM tbUser WHERE user_id = @user_id";
                    using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@user_id", employee.EmployeeID);

                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Compare the current values with the updated ones and track changes
                                if (employee.Firstname != reader["firstname"].ToString())
                                {
                                    changeDescription += $"Firstname changed from {reader["firstname"]} to {employee.Firstname}. ";
                                }

                                if (employee.Lastname != reader["lastname"].ToString())
                                {
                                    changeDescription += $"Lastname changed from {reader["lastname"]} to {employee.Lastname}. ";
                                }

                                if (employee.Contact != reader["contact_number"].ToString())
                                {
                                    changeDescription += $"Contact Number changed from {reader["contact_number"]} to {employee.Contact}. ";
                                }

                                if (employee.Address != reader["address"].ToString())
                                {
                                    changeDescription += $"Address changed from {reader["address"]} to {employee.Address}. ";
                                }
                            }
                        }
                    }

                    // If there are any changes, update the employee details in the database
                    if (!string.IsNullOrEmpty(changeDescription))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@user_id", employee.EmployeeID);
                            command.Parameters.AddWithValue("@firstname", employee.Firstname);
                            command.Parameters.AddWithValue("@lastname", employee.Lastname);
                            command.Parameters.AddWithValue("@contact_number", string.IsNullOrEmpty(employee.Contact) ? DBNull.Value : (object)employee.Contact);
                            command.Parameters.AddWithValue("@address", string.IsNullOrEmpty(employee.Address) ? DBNull.Value : (object)employee.Address);

                            command.ExecuteNonQuery();
                        }

                        // Log the specific field changes
                        Log log = new Log
                        {
                            TableAffected = "tbUser",
                            RecordID = Convert.ToInt32(employee.EmployeeID),
                            ModuleName = "Employee Management",
                            Description = $"Employee details updated: {changeDescription}",
                            Status = "Success",
                            ActionType = "Employee Updated"
                        };
                        LogController.LogUpdate(log.TableAffected, log.RecordID, log.ModuleName, log.Description, log.Status, log.ActionType);
                    }

                    connection.Close();
                }

                // Return true indicating the update was successful
                return true;
            }
            catch (Exception ex)
            {
                // Log the failure if an exception occurs
                Log log = new Log
                {
                    TableAffected = "tbUser",
                    RecordID = Convert.ToInt32(employee.EmployeeID),
                    ModuleName = "Employee Management",
                    Description = $"Failed to update employee details for ID = {employee.EmployeeID}. Error: {ex.Message}",
                    Status = "Failure",
                    ActionType = "Employee Updated"
                };
                LogController.LogUpdate(log.TableAffected, log.RecordID, log.ModuleName, log.Description, log.Status, log.ActionType);

                // Show error message to the user
                MessageBox.Show("Error message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Return false indicating the update failed
                return false;
            }
        }

        public bool UNARCHIVE_EMPLOYEE(string employeeID)
        {
            try
            {
                string query = @"UPDATE tbUser SET status = 'active' WHERE user_id = @user_id";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@user_id", employeeID);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Log the archiving action if successful
                        Log log = new Log
                        {
                            TableAffected = "tbUser",
                            RecordID = Convert.ToInt32(employeeID), // Assuming employeeID is an integer
                            ModuleName = "Employee Management",
                            Description = $"Employee with ID {employeeID} unarchived (status changed to 'active').",
                            Status = "Success",
                            ActionType = "Unarchive Employee"
                        };

                        LogController.LogUpdate(log.TableAffected, log.RecordID, log.ModuleName, log.Description, log.Status, log.ActionType);
                        return true;
                    }
                    else
                    {
                        // If no rows were affected, it might indicate an issue with the employee ID
                        Log log = new Log
                        {
                            TableAffected = "tbUser",
                            RecordID = Convert.ToInt32(employeeID),
                            ModuleName = "Employee Management",
                            Description = $"Failed to unarchive employee with ID {employeeID} - employee not found or already unarchived.",
                            Status = "Failure",
                            ActionType = "Unarchive Employee"
                        };

                        LogController.LogUpdate(log.TableAffected, log.RecordID, log.ModuleName, log.Description, log.Status, log.ActionType);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the failure due to exception
                Log log = new Log
                {
                    TableAffected = "tbUser",
                    RecordID = Convert.ToInt32(employeeID),
                    ModuleName = "Employee Management",
                    Description = $"Failed to unarchive employee with ID {employeeID}. Error: {ex.Message}",
                    Status = "Failure",
                    ActionType = "Unarchive Employee"
                };

                LogController.LogUpdate(log.TableAffected, log.RecordID, log.ModuleName, log.Description, log.Status, log.ActionType);

                // Show error message to the user
                MessageBox.Show("Error message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
       


        public bool ARCHIVE_EMPLOYEE(string employeeID)
        {
            try
            {
                string query = @"UPDATE tbUser SET status = 'inactive' WHERE user_id = @user_id";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@user_id", employeeID);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Log the archiving action if successful
                        Log log = new Log
                        {
                            TableAffected = "tbUser",
                            RecordID = Convert.ToInt32(employeeID), // Assuming employeeID is an integer
                            ModuleName = "Employee Management",
                            Description = $"Employee with ID {employeeID} archived (status changed to 'inactive').",
                            Status = "Success",
                            ActionType = "Archive Employee"
                        };

                        LogController.LogUpdate(log.TableAffected, log.RecordID, log.ModuleName, log.Description, log.Status, log.ActionType);
                        return true;
                    }
                    else
                    {
                        // If no rows were affected, it might indicate an issue with the employee ID
                        Log log = new Log
                        {
                            TableAffected = "tbUser",
                            RecordID = Convert.ToInt32(employeeID),
                            ModuleName = "Employee Management",
                            Description = $"Failed to archive employee with ID {employeeID} - employee not found or already archived.",
                            Status = "Failure",
                            ActionType = "Archive Employee"
                        };

                        LogController.LogUpdate(log.TableAffected, log.RecordID, log.ModuleName, log.Description, log.Status, log.ActionType);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the failure due to exception
                Log log = new Log
                {
                    TableAffected = "tbUser",
                    RecordID = Convert.ToInt32(employeeID),
                    ModuleName = "Employee Management",
                    Description = $"Failed to archive employee with ID {employeeID}. Error: {ex.Message}",
                    Status = "Failure",
                    ActionType = "Archive Employee"
                };

                LogController.LogUpdate(log.TableAffected, log.RecordID, log.ModuleName, log.Description, log.Status, log.ActionType);

                // Show error message to the user
                MessageBox.Show("Error message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
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
                        int search_id = employee_id;

                        // Check if the generated ID exists in the database
                        string query = "SELECT COUNT(*) FROM tbUser WHERE user_id = @employee_id";
                        //
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@employee_id", search_id);
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

        public Tuple<int, string> GENERATE_EMPLOYEE_DETAILS(string firstname)
        {
            try
            {
                // Generate unique employee ID
                int employee_id = GENERATE_EMPLOYEE_ID();

                // Generate username based on firstname and employee ID
                string new_username = firstname + employee_id.ToString();

                // Return both employee ID and username as a Tuple
                return new Tuple<int, string>(employee_id, new_username);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

    }
}
