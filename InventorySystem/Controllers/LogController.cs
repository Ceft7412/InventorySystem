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
    public class LogController
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["InventoryDb"].ConnectionString;
        Log log;


        public static List<Log> GetLogsFromDatabase(string statusFilter = null)
        {
            List<Log> logs = new List<Log>();

            string query = "SELECT * FROM tbLogs";

            // Add filtering if statusFilter is provided
            if (!string.IsNullOrEmpty(statusFilter))
            {
                query += " WHERE status = @status";
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);

                    // Add the status filter parameter if necessary
                    if (!string.IsNullOrEmpty(statusFilter))
                    {
                        command.Parameters.AddWithValue("@status", statusFilter);
                    }

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Log log = new Log
                        {
                            LogID = Convert.ToInt32(reader["log_id"]),
                            TimeStamp = Convert.ToDateTime(reader["timestamp"]),
                            UserID = Convert.ToInt32(reader["user_id"]),
                            ActionType = reader["action_type"].ToString(),
                            RecordID = Convert.ToInt32(reader["record_id"]),
                            ModuleName = reader["module_name"].ToString(),
                            Description = reader["description"].ToString(),
                            Status = reader["status"].ToString()
                        };
                        logs.Add(log);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return logs;
        }

        public static List<Log> SearchLogsByLogIdOrUserId(string searchTerm)
        {
            List<Log> logs = new List<Log>();

            // Build the query to search by LogID or UserID
            string query = "SELECT * FROM tbLogs WHERE log_id LIKE @searchTerm OR user_id LIKE @searchTerm";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);

                    // Add the search term parameter (wrap it with '%' for LIKE)
                    command.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Log log = new Log
                        {
                            LogID = Convert.ToInt32(reader["log_id"]),
                            TimeStamp = Convert.ToDateTime(reader["timestamp"]),
                            UserID = Convert.ToInt32(reader["user_id"]),
                            ActionType = reader["action_type"].ToString(),
                            RecordID = Convert.ToInt32(reader["record_id"]),
                            ModuleName = reader["module_name"].ToString(),
                            Description = reader["description"].ToString(),
                            Status = reader["status"].ToString()
                        };
                        logs.Add(log);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return logs;
        }


        //public List<Log> GetLogsFromDatabase()
        //{
        //    try
        //    {
        //        List<Log> logs = new List<Log>();
        //        string query = "SELECT * FROM tbLogs";

        //        using (SqlConnection connection = new SqlConnection(connectionString))
        //        {
        //            SqlCommand cmd = new SqlCommand(query, connection);
        //            connection.Open();
        //            SqlDataReader reader = cmd.ExecuteReader();

        //            while (reader.Read())
        //            {
        //                log = new Log
        //                {
        //                    LogID = Convert.ToInt32(reader["log_id"]),
        //                    TimeStamp = Convert.ToDateTime(reader["timestamp"]),
        //                    UserID = Convert.ToInt32(reader["user_id"]),
        //                    ActionType = reader["action_type"].ToString(),
        //                    RecordID = Convert.ToInt32(reader["record_id"]),
        //                    ModuleName = reader["module_name"].ToString(),
        //                    Description = reader["description"].ToString(),
        //                    Status = reader["status"].ToString()
        //                };

        //                logs.Add(log);
        //            }
        //        }

        //        return logs;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return null;

        //    }
        //}


        public void LogUpdate(string tableName, int recordId, string moduleName, string description, string status, string actionType)
        {
            try
            {
                // Create a new log entry
                Log logEntry = new Log
                {

                    TimeStamp = DateTime.Now,
                    UserID = SessionData.UserId,
                    ActionType = actionType,
                    TableAffected = tableName,
                    RecordID = recordId,
                    Description = description,
                    ModuleName = moduleName,
                    Status = status
                };

                // Save the log entry to the database
                SaveLogToDatabase(logEntry);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
               
        }

        public void LogUserLogin(int userId, bool success, string role, bool isFirstLogin)
        {
            // Create log entry for user login attempt
            Log logEntry = new Log
            {
                TimeStamp = DateTime.Now,
                UserID = userId,
                ActionType = success ? "Login" : "Login",
                TableAffected = "tbUser",
                RecordID = userId,
                Description = success
                    ? $"User {userId} logged in successfully. Role: {role}, First Login: {isFirstLogin}"
                    : $"Failed login attempt for user {userId}",
                ModuleName = "Authentication",
                Status = success ? "Success" : "Failure"
            };
            SaveLogToDatabase(logEntry);
        }

        private void SaveLogToDatabase(Log log)
        {
            string query = @"
                    INSERT INTO tbLogs (timestamp, user_id, action_type, table_affected, record_id, description, module_name, status)
                    VALUES (@TimeStamp, @UserID, @ActionType, @TableAffected, @RecordID, @Description, @ModuleName, @Status)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@TimeStamp", log.TimeStamp);
                cmd.Parameters.AddWithValue("@UserID", log.UserID);
                cmd.Parameters.AddWithValue("@ActionType", log.ActionType);
                cmd.Parameters.AddWithValue("@TableAffected", log.TableAffected);
                cmd.Parameters.AddWithValue("@RecordID", log.RecordID);
                cmd.Parameters.AddWithValue("@Description", log.Description);
                cmd.Parameters.AddWithValue("@ModuleName", log.ModuleName);
                cmd.Parameters.AddWithValue("@Status", log.Status);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }


    }
}
