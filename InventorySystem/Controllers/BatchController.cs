using System;
using InventorySystem.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace InventorySystem.Controllers
{
    public class BatchController
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\cedri\Documents\inventoryDB.mdf;Integrated Security=True;Connect Timeout=30";
        

       

        public List<Batch> GetBatches()
        {
            try
            {
                List<Batch> batches = new List<Batch>();
                string query = @"
                SELECT TOP 5 * 
                FROM tbBatches
                ORDER BY date DESC;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand getAllCommand = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = getAllCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        batches.Add(new Batch
                        {
                            BatchID = reader["batchID"].ToString(),
                            date = Convert.ToDateTime(reader["date"]),
                            TransactionType = reader["transaction_type"].ToString()
                        });
                    }
                    reader.Close();
                }
                return batches;

            }catch(Exception ex)
            {
                throw new Exception("Error message: " + ex.Message);
            }
         
        }
    }
}
