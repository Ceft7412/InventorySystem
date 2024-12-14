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


        public List<Log> GetLogsFromDatabase()
        {
            try
            {
                List<Log> logs = new List<Log>();
                string query = "SELECT * FROM tbLogs";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        log = new Log
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

                return logs;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;

            }
        }


        public void LogUpdate(string tableName, int recordId, string moduleName, string description, string status)
        {
            try
            {
                // Create a new log entry
                Log logEntry = new Log
                {

                    TimeStamp = DateTime.Now,
                    UserID = SessionData.UserId,
                    ActionType = "Update",
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

        private void LogUserLogin(int userId, bool success, string role, bool isFirstLogin)
        {
            // Create log entry for user login attempt
            Log logEntry = new Log
            {
                TimeStamp = DateTime.Now,
                UserID = userId,
                ActionType = success ? "Login Success" : "Login Failed",
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
