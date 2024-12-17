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
                supplierComboBox.Items.Clear();
                List<Supplier> supplierNames = supplierController.GetAllSupplierNames();
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
            item.Quantity,
            item.Unit,
             item.Supplier,
            item.Category,
             item.LastUpdated,
            item.MinimumStock
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
