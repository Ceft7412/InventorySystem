using System;
using System.Collections.Generic;
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
        public bool BackupDatabase(string backUpFolderPath)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string backupQuery = @"
                BACKUP DATABASE inventory_db
                TO DISK = @BackupPath
                WITH FORMAT;";

                    using (SqlCommand cmd = new SqlCommand(backupQuery, con))
                    {
                        // Safely add the backup path parameter
                        cmd.Parameters.Add("@BackupPath", SqlDbType.NVarChar).Value = backUpFolderPath;
                        cmd.ExecuteNonQuery();
                    }
                }
                return true; // Return true if backup is successful
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to backup database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // Return false if an error occurred
            }
        }


    }
}
