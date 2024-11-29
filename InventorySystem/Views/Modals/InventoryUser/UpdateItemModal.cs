using InventorySystem.Controllers;
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
        private string itemCode;
        private ItemController itemController = new ItemController();
        private SupplierController supplierController = new SupplierController();
        public UpdateItemModal(string id)
        {
            InitializeComponent();
            itemCode = id;
            LoadSelectedItemData();
            LoadSupplierNamesIntoComboBox();

        }

        public void LoadSupplierNamesIntoComboBox()
        {
            try
            {
                List<string> supplierNames = supplierController.GetAllSupplierNames();
                if (supplierNames != null && supplierNames.Count > 0)
                {
                    foreach (var name in supplierNames)
                    {
                        updateItemSupplierInput.Items.Add(name);
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

        private void LoadSelectedItemData()
        {
            if (itemCode == null)
            {
                MessageBox.Show("Item code is null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                var item = itemController.GetItemData(itemCode);
                if (item != null)
                {
                    updateItemCodeInput.Text = item.ProductCode;
                    updateItemDescriptionInput.Text = item.ProductDescription;
                    updateItemCategoryInput.Text = item.Category;
                    updateItemSupplierInput.Text = item.Supplier;
                    updateItemUnitInput.Text = item.Unit;
                    updateMinimumStockLevelInput.Text = item.MinimumStock.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }


        private void cancelUpdateItemButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateItemButton_Click(object sender, EventArgs e)
        {
            if (itemCode == null)
            {
                MessageBox.Show("Item code is null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to update? Previous item transactions or related to the product itself will be updated.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                itemController.UpdateItem(itemCode, updateItemDescriptionInput.Text, updateItemCategoryInput.Text, updateItemSupplierInput.Text, updateItemUnitInput.Text, int.Parse(updateMinimumStockLevelInput.Text));
                itemController.GetAllItems("active  ");
                this.Close();
            }
        }
    }
}
