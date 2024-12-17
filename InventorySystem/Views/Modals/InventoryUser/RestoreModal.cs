using InventorySystem.Controllers;
using InventorySystem.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem.Views.Modals.InventoryUser
{
    public partial class RestoreModal : Form
    {
        private LogController LogController = new LogController();
        public RestoreModal()
        {
            InitializeComponent();
        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void selectbackupfileBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Backup Files (*.bak)|*.bak";
                openFileDialog.Title = "Select a Backup File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    backupfilePath.Text = openFileDialog.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void restoreBtn_Click(object sender, EventArgs e)
        {
            string backupFilePath = backupfilePath.Text;
            if (string.IsNullOrEmpty(backupFilePath))
            {
                MessageBox.Show("Please select a backup file first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var fileDetails = GetBackupFileDetails(backupFilePath);
            if (fileDetails.Item1 == null || fileDetails.Item2 == null || fileDetails.Item3 == null)
            {
                MessageBox.Show("Could not determine the database details from the backup file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                var message = MessageBox.Show("Are you sure you want to restore the database?", "Confirm Restore", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (message == DialogResult.Yes)
                {
                    
                    RestoreDatabaseAsync(backupFilePath, fileDetails.Item1, fileDetails.Item2, fileDetails.Item3);
                }

            } catch (Exception ex)
            {
                MessageBox.Show("Error message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void RestoreDatabaseAsync(string backupFilePath, string dataLogicalName, string logLogicalName, string targetDatabaseName)
        {
            Task.Run(() =>
            {   
                this.Invoke(new Action(() => {
                    statusLabel.Text = "Restoring the database...";
                }));

                try
                {
                    RestoreDatabaseFiles(backupFilePath, dataLogicalName, logLogicalName, targetDatabaseName);
                    UpdateConnectionString(targetDatabaseName); 

                    this.Invoke(new Action(() => {
                        statusLabel.Text = "Database restored successfully. Restarting application...";
                    }));

                    // Optionally, restart the application
                    Application.Restart();
                }
                catch (Exception ex)
                {
                    this.Invoke(new Action(() => {
                        statusLabel.Text = $"Failed to restore database: {ex.Message}";
                    }));
                }
            });
        }

        private Tuple<string, string, string> GetBackupFileDetails(string backupFilePath)
        {
            using (SqlConnection con = new SqlConnection(@"Server=(LocalDB)\MSSQLLocalDB;Integrated Security=True;Connect Timeout=30;"))
            {
                con.Open();

                // Fetching logical names and paths
                SqlCommand cmdFileList = new SqlCommand("RESTORE FILELISTONLY FROM DISK = @BackupPath", con);
                cmdFileList.Parameters.AddWithValue("@BackupPath", backupFilePath);
                string dataLogicalName = null, logLogicalName = null;

                using (SqlDataReader fileListReader = cmdFileList.ExecuteReader())
                {
                    if (fileListReader.Read()) // Assume first row is data file
                    {
                        dataLogicalName = fileListReader["LogicalName"].ToString();
                    }
                    if (fileListReader.Read()) // Assume second row is log file
                    {
                        logLogicalName = fileListReader["LogicalName"].ToString();
                    }
                }

                // Fetching the database name
                string databaseName = null;
                SqlCommand cmdHeader = new SqlCommand("RESTORE HEADERONLY FROM DISK = @BackupPath", con);
                cmdHeader.Parameters.AddWithValue("@BackupPath", backupFilePath);

                using (SqlDataReader headerReader = cmdHeader.ExecuteReader())
                {
                    if (headerReader.Read())
                    {
                        databaseName = headerReader["DatabaseName"].ToString();
                    }
                }

                return new Tuple<string, string, string>(dataLogicalName, logLogicalName, databaseName);
            }
        }

        private void RestoreDatabaseFiles(string backupFilePath, string dataLogicalName, string logLogicalName, string targetDatabaseName)
        {
            string dataFilePath = Path.Combine(AppDomain.CurrentDomain.GetData("DataDirectory").ToString(), $"{targetDatabaseName}.mdf");
            string logFilePath = Path.Combine(AppDomain.CurrentDomain.GetData("DataDirectory").ToString(), $"{targetDatabaseName}_log.ldf");

            try
            {
                using (SqlConnection con = new SqlConnection(@"Server=(LocalDB)\MSSQLLocalDB;Integrated Security=True;Connect Timeout=30;"))
                {
                    con.Open();
                    // Set the database to single user mode
                    SetDatabaseToSingleUserMode(targetDatabaseName, con);
                    SqlCommand cmd = new SqlCommand($@"
                RESTORE DATABASE [{targetDatabaseName}] FROM DISK = @BackupPath WITH 
                MOVE @DataLogicalName TO @DataFilePath, 
                MOVE @LogLogicalName TO @LogFilePath, 
                REPLACE", con);

                    cmd.Parameters.AddWithValue("@BackupPath", backupFilePath);
                    cmd.Parameters.AddWithValue("@DataLogicalName", dataLogicalName);
                    cmd.Parameters.AddWithValue("@DataFilePath", dataFilePath);
                    cmd.Parameters.AddWithValue("@LogLogicalName", logLogicalName);
                    cmd.Parameters.AddWithValue("@LogFilePath", logFilePath);
                    cmd.ExecuteNonQuery();

                    // Log the restore action
                    Log log = new Log
                    {
                        TableAffected = "tbDatabase", // You can change this if you want a specific table to track the restore
                        RecordID = 0, // No specific record ID for the restore action
                        ModuleName = "Database Management",
                        Description = $"Restored database '{targetDatabaseName}' from backup file '{backupFilePath}'.",
                        Status = "Success",
                        ActionType = "Restore Database" // ActionType set to "Restore Database"
                    };
                    LogController.LogUpdate(log.TableAffected, log.RecordID, log.ModuleName, log.Description, log.Status, log.ActionType);
                }
            }
            catch (Exception ex)
            {
                // Log the failure if there's an issue during the restore process
                Log log = new Log
                {
                    TableAffected = "tbDatabase", // You can change this if you want a specific table to track the restore failure
                    RecordID = 0, // No specific record ID for the restore failure
                    ModuleName = "Database Management",
                    Description = $"Failed to restore database '{targetDatabaseName}' from backup. Error: {ex.Message}",
                    Status = "Failure",
                    ActionType = "Restore Database" // ActionType set to "Restore Database"
                };
                LogController.LogUpdate(log.TableAffected, log.RecordID, log.ModuleName, log.Description, log.Status, log.ActionType);

                // Show error message
                MessageBox.Show("Error: " + ex.Message, "Database Restore Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void SetDatabaseToSingleUserMode(string databaseName, SqlConnection connection)
        {
            SqlCommand cmd = new SqlCommand($@"
                ALTER DATABASE [{databaseName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
            ", connection);

            cmd.ExecuteNonQuery();
        }

        public static void UpdateConnectionString(string databaseName)
        {
            string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\{databaseName}.mdf;Integrated Security=True;Connect Timeout=30";

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.ConnectionStrings.ConnectionStrings["InventoryDb"].ConnectionString = connectionString;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("connectionStrings");
        }
    }
}
