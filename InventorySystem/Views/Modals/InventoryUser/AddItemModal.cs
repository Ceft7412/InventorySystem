using InventorySystem.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using InventorySystem.Models;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem.Views.Modals.InventoryUser
{
    public partial class AddItemModal : Form
    {
        ItemController itemController = new ItemController();
        SupplierController SupplierController = new SupplierController();
        public AddItemModal()
        {
            InitializeComponent();
            LOAD_SUPPLIER_INTO_COMBOBOX();
        }

        private void cancelCreateItemButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddItemModal_Load(object sender, EventArgs e)
        {
            LOAD_SUPPLIER_INTO_COMBOBOX();
        }

        private void LOAD_SUPPLIER_INTO_COMBOBOX()
        {
            try
            {
                itemSupplierInput.Items.Clear();
                List<string> supplierNames = SupplierController.GetAllSupplierNames();
                if (supplierNames != null && supplierNames.Count > 0)
                {
                    foreach (var name in supplierNames)
                    {
                        itemSupplierInput.Items.Add(name);
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
        private void createNewItemButton_Click(object sender, EventArgs e)
        {
            /// Ckecks if any of the fields are empty
            if (itemCodeInput.Text == "" || itemDescriptionInput.Text == "")
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var message = MessageBox.Show("Are you sure you want to add this item?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (message == DialogResult.No)
            {
                return;
            }

            int minimumStock;
            if (!int.TryParse(itemMSLInput.Text, out minimumStock))
            {
                // Default to 0 if input is blank or invalid
                minimumStock = 0;
            }
            try
            {
                Item item = new Item
                {
                    ProductCode = itemCodeInput.Text,
                    ProductDescription = itemDescriptionInput.Text,
                    Category = itemCategoryInput.Text,
                    Quantity = 0,
                    Supplier = itemSupplierInput.Text,
                    Unit = itemUnitInput.Text,
                    MinimumStock = itemMSLInput.Text == "" ? 0 : minimumStock,

                };
                itemController.AddItem(item);
                var result = MessageBox.Show("Item added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    this.Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        
    }
}
