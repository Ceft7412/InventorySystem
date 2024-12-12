
using InventorySystem.Controllers;
using InventorySystem.Models;
using InventorySystem.Services;
using InventorySystem.Views.Auth;
using InventorySystem.Views.Modals.InventoryUser;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace InventorySystem
{
    public partial class Inventory : Form
    {
        private ItemController itemController = new ItemController();
        private SupplierController supplierController = new SupplierController();
        private AuthenticationService AuthenticationService = new AuthenticationService();
        private string selectedItemCodeRow;
        private string selectedRows;
        private bool alreadyAsked = false;
        private bool isLoggingOut = false;
        public Inventory()
        {

            // TO CHECK IF USER IS AUTHENTICATED
            if (!AuthenticationService.IsAuthenticated)
            {
                CHECKAUTHENTICATION();
            }
            // IF AUTHENTICATED, LOAD ALL THE COMPONENTS
            else
            {
                InitializeComponent();
                LoadItems();
                LoadSupplierNamesIntoComboBox();
                LoadUnitsIntoComboBox();
                LoadCategoriesIntoComboBox();
            }

        }


        // METHOD TO CHECK IF USER IS AUTHENTICATED
        private void CHECKAUTHENTICATION()
        {
            try
            {
                MessageBox.Show("You are not authenticated. Please login.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Load += (s, e) => this.Close(); // Close the form if not authenticated
                Login login = new Login();
                login.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        // TO PREVENT THE FORM FROM CLOSING WHEN USER CLICKS THE CLOSE BUTTON   
        private void Inventory_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            //
            if (!isLoggingOut)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    if (!alreadyAsked)
                    {
                        var response = MessageBox.Show(this, "Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (response == DialogResult.No)
                        {
                            e.Cancel = true;
                        }
                        else
                        {
                            alreadyAsked = true;
                            Application.Exit();

                        }
                    }
                }
            }
            isLoggingOut = false;

        }

        // To reset the flag when the form is closed.
        private void Inventory_FormClosed(object sender, FormClosedEventArgs e)
        {
            alreadyAsked = false;
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
            string category = categoryComboBox.SelectedItem as string;
            string supplier = supplierComboBox.SelectedItem as string;
            string unit = unitComboBox.SelectedItem as string;
            if (searchQuery != null)
            {
                try
                {
                    dataGridViewItems.Rows.Clear();
                    List<Item> items = itemController.SearchItem(searchQuery, "active", category, supplier, unit);
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
                // Set the logout flag
                isLoggingOut = true;
                AuthenticationService.Destroy();
                this.Close();
                Login login = new Login();
                login.Show();
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
                        var itemCode = row.Cells[0].Value.ToString();
                        try
                        {
                            itemController.ArchiveItem(itemCode);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Failed to archive item {itemCode}. Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    LoadItems();

                }
            }
            else
            {
                MessageBox.Show("Please select one or more items to archive.", "Archive Product", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void exportItemsButton_Click(object sender, EventArgs e)
        {
            try
            {

                var message = MessageBox.Show("Are you sure you want to export the data?", "Export to Excel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (message == DialogResult.No)
                {
                    return;
                }

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

        private void importExcelBtn_Click(object sender, EventArgs e)
        {
            // Open File Dialog to Select Excel File
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel Files|*.xls;*.xlsx;*.xlsm",
                Title = "Select an Excel File"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                // Load Excel Data
                LoadExcelIntoDataGridView(filePath);
            }
        }

        private void LoadExcelIntoDataGridView(string filePath)
        {
            Excel.Application excelApp = null;
            Excel.Workbook workbook = null;
            Excel.Worksheet worksheet = null;

            try
            {
                // Start Excel Application
                excelApp = new Excel.Application();
                workbook = excelApp.Workbooks.Open(filePath);
                worksheet = workbook.Sheets[1]; // Assume data is in the first sheet

                // Get the headers (first row)
                string headerItemCode = worksheet.Cells[1, 1]?.Value?.ToString().Trim();
                string headerItemName = worksheet.Cells[1, 2]?.Value?.ToString().Trim();
                string headerUnit = worksheet.Cells[1, 3]?.Value?.ToString().Trim();

                // Validate headers
                if (headerItemCode != "Item Code" || headerItemName != "Item Description" || headerUnit != "Unit")
                {
                    MessageBox.Show("Invalid Excel format. The file must have headers: 'Item Code', 'Item Description', and 'Unit'.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Find the last used row in the Excel sheet
                Excel.Range usedRange = worksheet.UsedRange;
                int rows = usedRange.Rows.Count;

                // Clear existing data in DataGridView
                dataGridViewItems.Rows.Clear();

                // Loop through rows in Excel starting from row 2 (assuming headers in row 1)
                for (int i = 2; i <= rows; i++)
                {
                    // Read specific columns from Excel
                    string itemCode = worksheet.Cells[i, 1]?.Value?.ToString(); // Column A
                    string itemName = worksheet.Cells[i, 2]?.Value?.ToString(); // Column B
                    string unit = worksheet.Cells[i, 3]?.Value?.ToString();     // Column C

                    // Add data to DataGridView
                    int rowIndex = dataGridViewItems.Rows.Add();
                    dataGridViewItems.Rows[rowIndex].Cells[0].Value = itemCode;
                    dataGridViewItems.Rows[rowIndex].Cells[1].Value = itemName;
                    dataGridViewItems.Rows[rowIndex].Cells[3].Value = unit;
                }
                btnSaveToDatabase.Visible = true;

                MessageBox.Show("Excel data successfully imported!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Clean up resources
                workbook?.Close(false);
                excelApp?.Quit();

                // Release COM objects
                ReleaseObject(worksheet);
                ReleaseObject(workbook);
                ReleaseObject(excelApp);
            }
        }


        private void ReleaseObject(object obj)
        {
            try
            {
                if (obj != null)
                {
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                    obj = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error releasing object: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                GC.Collect();
            }
        }

        private void btnSaveToDatabase_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Are you sure you want to save the data to the database? You cannot undo these changes.", "Save to Database", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }

                List<Item> items = new List<Item>();
                HashSet<string> existingItemCodesAndUnits = new HashSet<string>(); // Track unique combinations of itemCode and unit
                HashSet<string> exportedItemCodesAndUnits = new HashSet<string>(); // Track itemCode and unit combinations for exported items

                // First, populate the HashSet with the existing itemCode and unit combinations in the DataGridView
                foreach (DataGridViewRow row in dataGridViewItems.Rows)
                {
                    if (row.IsNewRow || row.Cells[0].Value == null || row.Cells[3].Value == null) continue;
                    string itemCode = row.Cells[0].Value.ToString();
                    string unit = row.Cells[3].Value.ToString();
                    string itemCodeUnitCombo = $"{itemCode}|{unit}"; // Combine itemCode and unit

                    existingItemCodesAndUnits.Add(itemCodeUnitCombo); // Add to HashSet for checking duplicates
                }

                foreach (DataGridViewRow row in dataGridViewItems.Rows)
                {
                    if (row.IsNewRow || row.Cells[0].Value == null || row.Cells[3].Value == null) continue;
                    string itemCode = row.Cells[0].Value.ToString();
                    string unit = row.Cells[3].Value.ToString();
                    string itemCodeUnitCombo = $"{itemCode}|{unit}"; // Combine itemCode and unit

                    // Check for duplicate Item Code and Unit combination
                    if (exportedItemCodesAndUnits.Contains(itemCodeUnitCombo))
                    {
                        MessageBox.Show($"Duplicate Item Code and Unit found: {itemCode} - {unit}. Skipping this item.", "Duplicate Detected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        continue;
                    }

                    exportedItemCodesAndUnits.Add(itemCodeUnitCombo); // Add to the set for tracking

                    items.Add(new Item
                    {
                        ProductCode = itemCode,
                        ProductDescription = row.Cells[1].Value?.ToString() ?? "",
                        Unit = unit,
                        Quantity = int.TryParse(row.Cells[2].Value?.ToString(), out int quantity) ? quantity : 0,
                        Supplier = row.Cells[4].Value?.ToString() ?? "",
                        Category = row.Cells[5].Value?.ToString() ?? "",
                        MinimumStock = int.TryParse(row.Cells[6].Value?.ToString(), out int minStock) ? minStock : 0
                    });
                }

                if (items.Count == 0)
                {
                    MessageBox.Show("No items to save. Please check for duplicates or empty data.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Pass the list to the controller for saving
                itemController.SaveItemsToDatabase(items);
                LoadItems();
                LoadCategoriesIntoComboBox();
                LoadUnitsIntoComboBox();
                LoadSupplierNamesIntoComboBox();

                MessageBox.Show("Data successfully saved to the database!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSaveToDatabase.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
