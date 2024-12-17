using InventorySystem.Controllers;
using InventorySystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem.Views.Modals.Admin
{
    public partial class InventoryAdmin : Form
    {
        private ItemController itemController = new ItemController();
        private SupplierController supplierController = new SupplierController();
        public InventoryAdmin()
        {
            InitializeComponent();

        }

        private void InventoryAdmin_Load(object sender, EventArgs e)
        {
            LoadInventory();
            LoadSupplierNamesIntoComboBox();
            LoadUnitsIntoComboBox();
            LoadCategoriesIntoComboBox();
        }

        private void LoadInventory()
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
                supplierComboBox.DataSource = null;
                List<Supplier> suppliers = supplierController.GetAllSupplierNames();

                if (suppliers != null && suppliers.Count > 0)
                {

                    // Bind the data directly to the ComboBox
                    supplierComboBox.DataSource = suppliers;
                    supplierComboBox.DisplayMember = "SupplierName"; // What is displayed
                    supplierComboBox.ValueMember = "SupplierId";     // The hidden value
                                                                     // Ensure no item is selected when the ComboBox is loaded
                    supplierComboBox.SelectedIndex = -1;
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
                unitComboBox.Items.Clear(); // Clear any existing items
                List<string> units = itemController.GetAllUnits(); // Get the list of units

                if (units != null && units.Count > 0)
                {
                    // Ensure no empty or null units are added
                    foreach (var unit in units)
                    {
                        if (!string.IsNullOrWhiteSpace(unit)) // Add only non-empty strings
                        {
                            unitComboBox.Items.Add(unit);
                        }
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
                categoryComboBox.Items.Clear(); // Clear any existing items
                List<string> categories = itemController.GetAllCategories(); // Get the list of categories

                if (categories != null && categories.Count > 0)
                {
                    // Ensure no empty or null categories are added
                    foreach (var category in categories)
                    {
                        if (!string.IsNullOrWhiteSpace(category)) // Add only non-empty strings
                        {
                            categoryComboBox.Items.Add(category);
                        }
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
                                 item.ItemId,
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

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected category from the ComboBox
            string category = categoryComboBox.SelectedItem as string;

            // Get the selected supplier and unit
            Supplier selectedSupplier = supplierComboBox.SelectedItem as Supplier;
            string supplier = selectedSupplier?.SupplierName ?? string.Empty;  // Default to empty if no selection

            string unit = unitComboBox.SelectedItem as string;

            // Perform the filtering when category is selected
            FilterItemsAndUpdateDisplay(category, supplier, unit);
        }

        private void supplierComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected supplier as a Supplier object
            Supplier selectedSupplier = supplierComboBox.SelectedItem as Supplier;

            // If a supplier is selected, retrieve its properties
            string supplierName = selectedSupplier?.SupplierName ?? string.Empty;  // Default to empty if no selection

            // Get the selected category and unit
            string category = categoryComboBox.SelectedItem as string;
            string unit = unitComboBox.SelectedItem as string;

            // Perform the filtering when supplier is selected
            FilterItemsAndUpdateDisplay(category, supplierName, unit);
            
        }

        private void unitComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected category and supplier
            string category = categoryComboBox.SelectedItem as string;
            string supplier = supplierComboBox.SelectedItem as string;

            // Get the selected unit
            string unit = unitComboBox.SelectedItem as string;

            // Perform the filtering when unit is selected
            FilterItemsAndUpdateDisplay(category, supplier, unit);
        }

        private void FilterItemsAndUpdateDisplay(string category, string supplier, string unit)
        {
            // Only proceed if we have selections to filter by
            // This will silently filter without popping up any messages
            var filterItems = itemController.FilterItems(category, supplier, unit);
            UpdateDisplay(filterItems);  // Update the UI with the filtered items
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

            foreach (Item item in items)
            {
                dataGridViewItems.Rows.Add(new object[] {
                    item.ItemId.ToString(),
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
                LoadInventory();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
    }
}
