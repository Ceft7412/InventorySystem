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

namespace InventorySystem.Views.Modals.InventoryUser
{
    public partial class UpdateItemModal : Form
    {
        private string item_id;
        private ItemController itemController = new ItemController();
        private SupplierController supplierController = new SupplierController();
        public UpdateItemModal(string id)
        {
            InitializeComponent();
            item_id = id;
            LoadSelectedItemData();

        }

        private void LoadSelectedItemData()
        {
            if (item_id == null)
            {
                MessageBox.Show("Item code is null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Load the item details
                var item = itemController.GetItemData(item_id);
                if (item != null)
                {
                    // Populate the text fields with the item data
                    updateItemIdInput.Text = item.ItemId.ToString();
                    updateItemCodeInput.Text = item.ProductCode;
                    updateItemDescriptionInput.Text = item.ProductDescription;
                    updateItemCategoryInput.Text = item.Category;
                    updateItemUnitInput.Text = item.Unit;
                    updateMinimumStockLevelInput.Text = item.MinimumStock.ToString();

                    // Clear existing controls in the panel
                    supplierPanel.Controls.Clear();

                    // Fetch all available suppliers
                    List<Supplier> allSuppliers = supplierController.GetAllSupplierNames();
                    if (allSuppliers != null && allSuppliers.Count > 0)
                    {
                        int yPosition = 10; // Initial Y position for the first checkbox

                        foreach (var supplier in allSuppliers)
                        {
                            // Create a new checkbox for each supplier
                            CheckBox supplierCheckBox = new CheckBox
                            {
                                Text = supplier.SupplierName, // Display the supplier name
                                Font = new Font("Calibri", 13F), // Font styling
                                Tag = supplier.SupplierId, // Store SupplierId as a hidden value
                                Location = new Point(10, yPosition), // Positioning
                                Size = new Size(200, 35) // Size of the checkbox

                            };
                            supplierCheckBox.CheckedChanged += SupplierCheckBox_CheckedChanged;

                            // Check the checkbox if the SupplierId matches one from the item's SupplierIds
                            if (item.SupplierIds.Contains(supplier.SupplierId.ToString()))
                            {
                                supplierCheckBox.Checked = true;
                            }

                            // Increment the Y position for the next checkbox
                            yPosition += 30;

                            // Add the checkbox to the panel
                            supplierPanel.Controls.Add(supplierCheckBox);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SupplierCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox != null)
            {
                int supplierId = (int)checkBox.Tag;  // Get the SupplierId from the Tag property
                bool isChecked = checkBox.Checked;   // Check if the checkbox is checked
            }
        }

        private void cancelUpdateItemButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateItemButton_Click(object sender, EventArgs e)
        {
            if (item_id == null)
            {
                MessageBox.Show("Item code is null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to update? Previous item transactions or related to the product itself will be updated.",
                                         "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                // Collect the selected supplier IDs from the checkboxes
                List<int> selectedSupplierIds = new List<int>();

                foreach (Control control in supplierPanel.Controls)
                {
                    if (control is CheckBox checkBox && checkBox.Checked)
                    {
                        int supplierId = (int)checkBox.Tag; // Get SupplierId from the Tag property
                        selectedSupplierIds.Add(supplierId); // Add the supplierId to the list
                    }
                }

                // Pass the list of selected supplier IDs to the UpdateItem method
                itemController.UpdateItem(item_id,
                                          updateItemDescriptionInput.Text,
                                          updateItemCategoryInput.Text,
                                          selectedSupplierIds, // Pass the list
                                          updateItemUnitInput.Text,
                                          int.Parse(updateMinimumStockLevelInput.Text));

                itemController.GetAllItems("active");
                this.Close();
            }
        }

    }
}
