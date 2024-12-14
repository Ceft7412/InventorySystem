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
    public class StockAlert
    {
        public int ItemId { get; set; }
        public string ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public int Quantity { get; set; }
        public int MinimumStockLevel { get; set; }
        public DateTime DateTime { get; set; }
        public string Status { get; set; }
        public string Severity { get; set; }
    }
    public class NotificationController
    {

            
        private static string connectionString = ConfigurationManager.ConnectionStrings["InventoryDb"].ConnectionString;

        // Method to Get Items Below Minimum Stock with Severity
        public void GenerateStockAlerts()
        {
            string query = @"
        INSERT INTO tbStockAlert (alert_id, item_id, datetime, status, severity)
        SELECT NEWID(), item_id, GETDATE(), 'Active',
            CASE
                WHEN productQuantity >= 0.75 * minimumstocklevel THEN 'Low'
                WHEN productQuantity >= 0.5 * minimumstocklevel THEN 'Medium'
                ELSE 'High'
            END AS severity
        FROM tbItem
        WHERE productQuantity < minimumstocklevel
          AND NOT EXISTS (
              SELECT 1
              FROM tbStockAlert
              WHERE tbStockAlert.item_id = tbItem.item_id
                AND tbStockAlert.status = 'Active'
          )";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<StockAlert> GetActiveStockAlerts()
        {
            List<StockAlert> alerts = new List<StockAlert>();

            string query = @"
        SELECT 
            sa.item_id, 
            i.productCode, 
            i.productDescription, 
            i.productQuantity, 
            i.minimumstocklevel, 
            sa.datetime, 
            sa.status,
            sa.severity
        FROM tbStockAlert sa    
        INNER JOIN tbItem i ON sa.item_id = i.item_id
        WHERE sa.status = 'Active'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    alerts.Add(new StockAlert
                    {
                        ItemId = Convert.ToInt32(reader["item_id"]),
                        ProductCode = reader["productCode"].ToString(),
                        ProductDescription = reader["productDescription"].ToString(),
                        Quantity = Convert.ToInt32(reader["productQuantity"]),
                        MinimumStockLevel = Convert.ToInt32(reader["minimumstocklevel"]),
                        DateTime = Convert.ToDateTime(reader["datetime"]),
                        Status = reader["status"].ToString(),
                        Severity = reader["severity"].ToString()
                    });
                }
            }

            return alerts;
        }

        public void UpdateCompletedStockAlerts()
        {
            // This query will check if any active stock alert can be marked as "Completed" when the quantity exceeds the minimum stock level.
            string query = @"
                UPDATE sa
                SET sa.status = 'Completed'
                FROM tbStockAlert sa
                INNER JOIN tbItem i ON sa.item_id = i.item_id
                WHERE sa.status = 'Active'
                  AND i.productQuantity >= i.minimumstocklevel";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

    }
}
    