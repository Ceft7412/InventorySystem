using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using InventorySystem.Controllers;
using InventorySystem.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventorySystem.Models;
using Microsoft.Data.SqlClient;

namespace InventorySystem.Views.Modals.InventoryUser
{
    public partial class StockInOutModal : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\cedri\Documents\inventoryDB.mdf;Integrated Security=True;Connect Timeout=30");
        private string batchSelectedItemCode;
        private BatchItemController batchItemController = new BatchItemController();
        private ItemController itemController = new ItemController();

        private List<BatchItem> batchItems = new List<BatchItem>();
        public StockInOutModal()
        {
            InitializeComponent();
        }
        public List<BatchItem> GetBatchItems()
        {
            return batchItems;
        }
        private void stockInButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (batchItemController.GetBatchItems().Count >= 1 && stockOutPanel.Visible)
                {
                    var result = MessageBox.Show("You have unsaved stock out items. Do you wish to discard them and go to another panel?", "Save Stock Out Items", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        stockOutPanel.Visible = false;
                        stockOutButtonsPanel.Visible = false;
                        stockInPanel.Visible = true;
                        stockInButtonsPanel.Visible = true;
                        RefreshDataGridView();
                    }
                }
                else
                {
                    stockOutPanel.Visible = false;
                    stockOutButtonsPanel.Visible = false;
                    stockInButtonsPanel.Visible = true;
                    stockInPanel.Visible = true;
                }
            }
            catch(Exception ex)
            {   
                MessageBox.Show("Error message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            
        }

        private void stockOutButton_Click(object sender, EventArgs e)
        {
            if (batchItemController.GetBatchItems().Count >= 1 && stockInPanel.Visible)
            {
                var result = MessageBox.Show("You have unsaved stock out items. Do you wish to discard them and go to another panel?", "Save Stock Out Items", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    stockInButtonsPanel.Visible = false;
                    stockInPanel.Visible = false;
                    stockOutPanel.Visible = true;
                    stockOutButtonsPanel.Visible = true;
                    RefreshDataGridView();
                }
            }
            else
            {
                stockInPanel.Visible = false;
                stockInButtonsPanel.Visible = false;
                stockOutButtonsPanel.Visible = true;
                stockOutPanel.Visible = true;
            }
        }

        private void RefreshDataGridView()
        {

            try
            {
                dataGridViewBatchItems.Rows.Clear();
                List<BatchItem> batchItems = batchItemController.GetBatchItems();
                if (batchItems != null && batchItems.Count > 0)
                {
                    foreach (var item in batchItems)
                    {
                        dataGridViewBatchItems.Rows.Add(
                            item.ProductCode,
                            item.Quantity.ToString(),
                            item.Reason,
                            item.Date.ToString());
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnSaveAllStockInItems_Click(object sender, EventArgs e)
        {
            try
            {
                string transaction_type = "IN";
                batchItemController.SaveBatchItemsToDatabase(transaction_type);
                RefreshDataGridView();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearStockInItems_Click(object sender, EventArgs e)
        {
            if (batchSelectedItemCode == null)
            {
                MessageBox.Show("No items to clear.", "No items", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            batchItemController.ClearBatchItems();
            RefreshDataGridView();
        }

        private void btnRemoveBatchItem_Click(object sender, EventArgs e)
        {
            if (batchSelectedItemCode == null)
            {
                MessageBox.Show("Please select an item to remove.", "Select item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            batchItemController.RemoveBatchItem(batchSelectedItemCode);
            RefreshDataGridView();
        }

        private void btnClearStockOutItems_Click(object sender, EventArgs e)
        {
            if (batchSelectedItemCode == null)
            {
                MessageBox.Show("No items to clear.", "No items", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            batchItemController.ClearBatchItems();
            RefreshDataGridView();
        }

        private void btnSaveAllStockOutItems_Click(object sender, EventArgs e)
        {
            try
            {
                string transaction_type = "OUT";
                batchItemController.SaveBatchItemsToDatabase(transaction_type);
                RefreshDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void stockInSaveButton_Click(object sender, EventArgs e)
        {
            string productCode = stockInProductCodeInput.Text.Trim();
            int quantity;
            bool isQuantityValid = int.TryParse(stockInProductQuantity.Text.Trim(), out quantity);
            string transaction_type = "IN";
            string reason = stockInReasonInput.Text.Trim();
            DateTime transactionDate = stockInDateInput.Value;
            if (string.IsNullOrEmpty(productCode) || !isQuantityValid)
            {
                MessageBox.Show("Please enter valid data.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                batchItemController.AddBatchItem(productCode, quantity, reason, transactionDate, transaction_type);
                stockInProductCodeInput.Clear();
                stockInProductQuantity.Clear();
                stockInReasonInput.Text = "";
                stockInDateInput.ResetText();


                RefreshDataGridView();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void stockInClear_Click(object sender, EventArgs e)
        {
            stockInProductCodeInput.Clear();
            stockInProductQuantity.Clear();
            stockInReasonInput.SelectedIndex = -1;
            stockInDateInput.ResetText();
        }

        private void stockOutSaveButton_Click(object sender, EventArgs e)
        {
            string productCode = stockOutProductCodeInput.Text.Trim();
            int quantity;
            bool isQuantityValid = int.TryParse(stockOutProductQuantity.Text.Trim(), out quantity);
            string transaction_type = "OUT";
            string reason = stockOutReasonInput.Text.Trim();
            DateTime transactionDate = stockOutDateInput.Value;

            if (string.IsNullOrEmpty(productCode) || !isQuantityValid)
            {
                MessageBox.Show("Please enter valid data.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                connection.Open();

                // Step 1: Check the current quantity in tbProduct
                string checkQuantityQuery = "SELECT productQuantity FROM tbItem WHERE productCode = @productCode";
                int currentQuantity = 0;

                using (SqlCommand checkCommand = new SqlCommand(checkQuantityQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@productCode", productCode);
                    object result = checkCommand.ExecuteScalar();

                    if (result != null)
                    {
                        currentQuantity = Convert.ToInt32(result);
                    }
                    else
                    {
                        MessageBox.Show("Error message: Product not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        connection.Close();
                        return;
                    }
                }

                // Step 2: Ensure there is enough stock to perform the operation
                if (currentQuantity < quantity)
                {
                    MessageBox.Show("Error message: Insufficient stock. Unable to process the stock out.", "Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    connection.Close();
                    return;
                }

                try
                {
                    batchItemController.AddBatchItem(productCode, quantity, reason, transactionDate, transaction_type);
                    stockOutProductCodeInput.Clear();
                    stockOutProductQuantity.Clear();
                    stockOutReasonInput.Text = "";
                    stockOutDateInput.ResetText();
                    RefreshDataGridView();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void stockOutClear_Click(object sender, EventArgs e)
        {
            stockOutProductCodeInput.Clear();
            stockOutProductQuantity.Clear();
            stockOutReasonInput.SelectedIndex = -1;
            stockOutDateInput.ResetText();
        }
    }
}
