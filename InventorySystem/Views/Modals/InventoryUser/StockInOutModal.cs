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
using System.Configuration;
namespace InventorySystem.Views.Modals.InventoryUser
{
    public partial class StockInOutModal : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["InventoryDb"].ConnectionString;

        private string batchSelectedItemCode;
        private BatchItemController batchItemController = new BatchItemController();
        private ItemController itemController = new ItemController();

        private List<BatchItem> batchItems = new List<BatchItem>();
        public StockInOutModal()
        {
            InitializeComponent();
        }

        private void StockInOutModal_Load(object sender, EventArgs e)
        {
            LOAD_UNITS_COMBOBOX();
        }

        public List<BatchItem> GetBatchItems()
        {
            return batchItems;
        }



        public void LOAD_UNITS_COMBOBOX()
        {
            try
            {
                stockOutUnitCmb.Items.Clear();
                stockInUnitCmb.Items.Clear();
                List<string> units = itemController.GetAllUnits();
                if (units != null && units.Count > 0)
                {
                    foreach (var unit in units)
                    {
                        stockInUnitCmb.Items.Add(unit);
                        stockOutUnitCmb.Items.Add(unit);
                    }
                }
                else
                {
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


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
            catch (Exception ex)
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
                            item.Unit,
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
                var message = MessageBox.Show("Are you sure you want to save all stock in items?", "Save Stock In Items", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (message == DialogResult.No)
                {
                    return;
                }
                string transaction_type = "IN";
                batchItemController.SaveTransaction(transaction_type);
                RefreshDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveAllStockOutItems_Click(object sender, EventArgs e)
        {
            try
            {
                var message = MessageBox.Show("Are you sure you want to save all stock out items?", "Save Stock Out Items", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (message == DialogResult.No)
                {
                    return;
                }
                string transaction_type = "OUT";
                batchItemController.SaveTransaction(transaction_type);
                RefreshDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearStockInItems_Click(object sender, EventArgs e)
        {
            try
            {

                var selectedRows = dataGridViewBatchItems.SelectedRows;
                if (selectedRows.Count < 0)
                {
                    MessageBox.Show("No items to clear.", "No items", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {

                    batchItemController.ClearBatchItems();
                    RefreshDataGridView();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
        private void btnClearStockOutItems_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRows = dataGridViewBatchItems.SelectedRows;
                if (selectedRows.Count < 0)
                {
                    MessageBox.Show("No items to clear.", "No items", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    var message = MessageBox.Show("Are you sure you want to clear all stock in items?", "Clear Stock In Items", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (message == DialogResult.No)
                    {
                        return;
                    }
                    batchItemController.ClearBatchItems();
                    RefreshDataGridView();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
        private void btnRemoveBatchItem_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRows = dataGridViewBatchItems.SelectedRows;
                if (selectedRows.Count > 0)
                {
                    var results = MessageBox.Show($"Are you sure you want to remove {selectedRows.Count} item(s)?", "Remove Item", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (results == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow row in selectedRows)
                        {
                            var itemCode = row.Cells[0].Value.ToString();
                            try
                            {
                                batchItemController.RemoveBatchItem(itemCode);

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        RefreshDataGridView();
                    }

                }
                else
                {
                    MessageBox.Show("Please select an item/s to remove.", "Select item", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }




        }





        private void stockInSaveButton_Click(object sender, EventArgs e)
        {
            int item_id = int.TryParse(stockInItemIdInput.Text.Trim(), out int result) ? result : -1;
            string productCode = stockInProductCodeInput.Text.Trim();
            int quantity;
            string unit = stockInUnitCmb.Text.Trim();
            bool isQuantityValid = int.TryParse(stockInProductQuantity.Text.Trim(), out quantity);
            string transaction_type = "IN";
            string reason = stockInReasonInput.Text.Trim();
            DateTime transactionDate = stockInDateInput.Value;

            if(item_id == -1)
            {
                MessageBox.Show("Please enter valid data.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(productCode) || !isQuantityValid)
            {
                MessageBox.Show("Please enter valid data.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                batchItemController.AddBatchItem(result, productCode, quantity, unit,  reason, transactionDate, transaction_type);
                stockInItemIdInput.Clear();
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
            stockInUnitCmb.SelectedIndex = -1;
            stockInReasonInput.SelectedIndex = -1;
            stockInDateInput.ResetText();
        }

        private void stockOutSaveButton_Click(object sender, EventArgs e)
        {
            int item_id = int.TryParse(stockOutItemIdInput.Text.Trim(), out int result_item_id) ? result_item_id : -1;
            string productCode = stockOutProductCodeInput.Text.Trim();
            int quantity;
            string unit = stockOutUnitCmb.Text.Trim();
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
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Step 1: Check if the productCode and unit combination exists in tbItem
                    string checkQuantityQuery = "SELECT productQuantity FROM tbItem WHERE productCode = @productCode AND unit = @unit";
                    int currentQuantity = 0;

                    using (SqlCommand checkCommand = new SqlCommand(checkQuantityQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@productCode", productCode);
                        checkCommand.Parameters.AddWithValue("@unit", unit);
                        object result = checkCommand.ExecuteScalar();

                        if (result != null)
                        {
                            currentQuantity = Convert.ToInt32(result);
                        }
                        else
                        {
                            MessageBox.Show("Error: Product code and unit combination not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            connection.Close();
                            return;
                        }
                    }

                    // Step 2: Ensure there is enough stock to perform the operation
                    if (currentQuantity < quantity)
                    {
                        MessageBox.Show("Error: Insufficient stock. Unable to process the stock out.", "Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        connection.Close();
                        return;
                    }

                    // Step 3: Call AddBatchItem to log the stock out operation
                    try
                    {
                        batchItemController.AddBatchItem(result_item_id, productCode, quantity, unit, reason, transactionDate, transaction_type);
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
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void stockOutClear_Click(object sender, EventArgs e)
        {
            stockOutProductCodeInput.Clear();
            stockOutProductQuantity.Clear();
            stockOutUnitCmb.SelectedIndex = -1;
            stockOutReasonInput.SelectedIndex = -1;
            stockOutDateInput.ResetText();
        }

        private void selectedItemCode(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridViewBatchItems.Rows[e.RowIndex];
                    batchSelectedItemCode = row.Cells[0].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        
    }
}
