
using InventorySystem.Controllers;
using InventorySystem.Models;
using InventorySystem.Views.Modals.InventoryUser;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace InventorySystem
{
    public partial class Inventory : Form
    {
        private ItemController itemController = new ItemController();
        private SupplierController supplierController = new SupplierController();
        private string selectedItemCodeRow;
        private string selectedRows;
        public Inventory()
        {
            InitializeComponent();

            LoadItems();
            LoadSupplierNamesIntoComboBox();
            LoadUnitsIntoComboBox();
            LoadCategoriesIntoComboBox();
        }

        private void LoadItems()
        {
            try
            {
                dataGridViewItems.Rows.Clear();
                List<Item> items = itemController.GetAllItems("active");
                // Check if items list is not empty
                if (items != null && items.Count > 0)
                {

                    foreach (var item in items) // Iterate over each Item object
                    {
                        // Add rows to DataGridView by accessing Item properties
                        dataGridViewItems.Rows.Add(
                            item.ProductCode,
                            item.ProductDescription,
                            item.Quantity.ToString(), // Assuming ProductQuantity is a numeric type
                            item.Unit,
                            item.Supplier,
                            item.Category,
                              item.MinimumStock.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }



        public void LoadSupplierNamesIntoComboBox()
        {
            try
            {
                supplierComboBox.Items.Clear();
                List<string> supplierNames = supplierController.GetAllSupplierNames();
                if (supplierNames != null && supplierNames.Count > 0)
                {
                    foreach (var name in supplierNames)
                    {
                        supplierComboBox.Items.Add(name);
                    }
                }
                else
                {
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadUnitsIntoComboBox()
        {
            try
            {
                unitComboBox.Items.Clear();
                List<string> units = itemController.GetAllUnits();
                if (units != null && units.Count > 0)
                {
                    foreach (var unit in units)
                    {
                        unitComboBox.Items.Add(unit);
                    }
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadCategoriesIntoComboBox()
        {

            try
            {
                categoryComboBox.Items.Clear();
                List<string> categories = itemController.GetAllCategories();
                if (categories != null && categories.Count > 0)
                {
                    foreach (var category in categories)
                    {
                        categoryComboBox.Items.Add(category);
                    }
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PerformSearch(string searchQuery)
        {
            if (searchQuery != null)
            {
                try
                {
                    dataGridViewItems.Rows.Clear();
                    List<Item> items = itemController.SearchItem(searchQuery, "active");
                    if (items != null && items.Count > 0)
                    {
                        foreach (var item in items)
                        {
                            dataGridViewItems.Rows.Add(
                                item.ProductCode,
                                item.ProductDescription,
                                item.Quantity.ToString(),
                                item.Unit,
                                item.Supplier,
                                item.Category,
                                item.LastUpdated,
                                item.MinimumStock.ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
        private void searchItemTxt_TextChanged(object sender, EventArgs e)
        {
            PerformSearch(searchItemTxt.Text);
        }


        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // ++++++++++++++++++++++++++++++++++++++ NAVIGATION BUTTONS ++++++++++++++++++++++++++++++++++++++
        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void stockInOutNavigationButton_Click(object sender, EventArgs e)
        {
            StockInOutModal stockInOutModal = new StockInOutModal();
            stockInOutModal.ShowDialog();
            LoadItems();
        }

        private void supplierNavigationButton_Click(object sender, EventArgs e)
        {
            SupplierModal supplierModal = new SupplierModal();
            supplierModal.ShowDialog();
            LoadSupplierNamesIntoComboBox();
        }

        private void archiveNavigationButton_Click(object sender, EventArgs e)
        {
            ArchiveModal archiveModal = new ArchiveModal();
            archiveModal.ShowDialog();
            LoadItems();
        }

        private void settingsNavigationButton_Click(object sender, EventArgs e)
        {
            SettingsModal settingsModal = new SettingsModal();
            settingsModal.ShowDialog();
        }

        private void logoutNavigationButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                //Login login = new Login();
                //login.Show();
            }

        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            AddItemModal addItemModal = new AddItemModal();
            addItemModal.ShowDialog();
            LoadItems();
        }

        private void updateItemButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(selectedItemCodeRow))
                {
                    UpdateItemModal updateItemModal = new UpdateItemModal(selectedItemCodeRow);
                    updateItemModal.ShowDialog();
                    LoadItems();
                }
                else
                {
                    MessageBox.Show("Error message: Please select an item to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }

        private void SelectedItemCodeRowClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            selectedItemCodeRow = dataGridViewItems.Rows[e.RowIndex].Cells[0].Value.ToString();
            
        }

        private void archiveItemButton_Click(object sender, EventArgs e)
        {
            var selectedRows = dataGridViewItems.SelectedRows;
            if (selectedRows.Count > 0)
            {
                var results = MessageBox.Show($"Are you sure you want to archive {selectedRows.Count} item(s)?", "Archive Item", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (results == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in selectedRows)
                    {
                        var itemCode = row.Cells[0].Value.ToString(); // Ensure you use the correct column name for the product code
                        try
                        {
                            itemController.ArchiveItem(itemCode);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Failed to archive item {itemCode}. Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            // Optionally break the loop if one fails or continue based on your requirements
                        }
                    }

                    LoadItems(); // Reload items to reflect the changes
                                 // LoadInactiveProducts(); // Optional, if you need to load inactive products somewhere
                }
            }
            else
            {
                MessageBox.Show("Please select one or more products to archive.", "Archive Product", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void exportItemsButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Create Excel application instance
                Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = true;
                Excel.Workbook workbook = excelApp.Workbooks.Add();
                Excel.Worksheet worksheet = workbook.Sheets[1];
                worksheet.Name = "Inventory Data";

                // Export column headers
                for (int i = 0; i < dataGridViewItems.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = dataGridViewItems.Columns[i].HeaderText;
                }

                // Export row data
                for (int i = 0; i < dataGridViewItems.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridViewItems.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridViewItems.Rows[i].Cells[j].Value?.ToString();
                    }
                }

                // Auto-fit columns
                worksheet.Columns.AutoFit();

                // Release resources
                System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);

                MessageBox.Show("Data exported successfully!", "Export to Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error message: {ex.Message}", "Export to Excel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = categoryComboBox.SelectedItem as string;
            string supplier = supplierComboBox.SelectedItem as string;
            string unit = unitComboBox.SelectedItem as string;
            var filterItems = itemController.FilterItems(category, supplier, unit);
            UpdateDisplay(filterItems);
        }

        private void supplierComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = categoryComboBox.SelectedItem as string;
            string supplier = supplierComboBox.SelectedItem as string;
            string unit = unitComboBox.SelectedItem as string;
            var filterItems = itemController.FilterItems(category, supplier, unit);
            UpdateDisplay(filterItems);
        }

        private void unitComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = categoryComboBox.SelectedItem as string;
            string supplier = supplierComboBox.SelectedItem as string;
            string unit = unitComboBox.SelectedItem as string;
            var filterItems = itemController.FilterItems(category, supplier, unit);
            UpdateDisplay(filterItems);
        }

        private void UpdateDisplay(List<Item> items)
        {
            // Clear existing rows
            dataGridViewItems.Rows.Clear();

            // Check if there are any items to display
            if (items == null || items.Count == 0)
            {
                return;
            }

            // Adding rows to the DataGridView for each item
            foreach (Item item in items)
            {
                dataGridViewItems.Rows.Add(new object[] {
            item.ProductCode,
            item.ProductDescription,
            item.Quantity.ToString(),
            item.Unit,
            item.Supplier,
            item.Category,
            item.MinimumStock.ToString()
             });
            }
        }

        private void refreshData_Click(object sender, EventArgs e)
        {
            try
            {
                
                searchItemTxt.Text = "";
                categoryComboBox.SelectedIndex = -1;
                supplierComboBox.SelectedIndex = -1;
                unitComboBox.SelectedIndex = -1;
                LoadItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
