using System;
using System.Collections.Generic;
using InventorySystem.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.Data.SqlClient;
using System.Data;

namespace InventorySystem.Controllers
{
    public class SettingsController
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["InventoryDb"].ConnectionString;
        private LogController LogController = new LogController();
        public bool     BackupDatabase(string backUpFolderPath)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string databaseName = con.Database;
                    MessageBox.Show(databaseName);

                    // Correctly format the backup file path in single quotes
                    string backupQuery = $@"
                                BACKUP DATABASE inventory_db
                                TO DISK = '{backUpFolderPath}'
                                WITH FORMAT;";


                    using (SqlCommand cmd = new SqlCommand(backupQuery, con))
                    {
                        // Safely add the backup path parameter
                        cmd.Parameters.Add("@BackupPath", SqlDbType.NVarChar).Value = backUpFolderPath;
                        cmd.ExecuteNonQuery();
                    }
                }

                // Log the successful backup
                Log log = new Log
                {
                    TableAffected = "Database",  // Referring to the whole database since we're performing a backup
                    RecordID = 0, // No specific record ID
                    ModuleName = "Database Management",
                    Description = $"Database backup was successful. Backup stored at: {backUpFolderPath}",
                    Status = "Success",
                    ActionType = "Backup"
                };
                LogController.LogUpdate(log.TableAffected, log.RecordID, log.ModuleName, log.Description, log.Status, log.ActionType);

                return true; // Return true if backup is successful
            }
            catch (Exception ex)
            {
                // Log the failure
                Log log = new Log
                {
                    TableAffected = "Database",  // Referring to the whole database since it's a database backup
                    RecordID = 0, // No specific record ID for database
                    ModuleName = "Database Management",
                    Description = $"Database backup failed. Error: {ex.Message}",
                    Status = "Failure",
                    ActionType = "Backup"
                };
                LogController.LogUpdate(log.TableAffected, log.RecordID, log.ModuleName, log.Description, log.Status, log.ActionType);

                MessageBox.Show("Failed to backup database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // Return false if an error occurred
            }
        }



    }
}
