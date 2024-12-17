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
    public partial class UpdateSupplier : Form
    {
        private string supplierId;
        public UpdateSupplier(string id)
        {
            InitializeComponent();
            supplierId = id;
            LoadSupplierData();
        }
        private void LoadSupplierData()
        {
            if (supplierId != null)
            {
                SupplierController supplierController = new SupplierController();
                Supplier supplier = supplierController.GetItemData(supplierId);
                updateSupplierIdInput.Text = supplierId;
                updateSupplierNameInput.Text = supplier.SupplierName;
                updateSupplierContactInput.Text = supplier.SupplierContact;
                updateSupplierAddressInput.Text = supplier.SupplierAddress;
            }
        }
        private void updateSupplierButton_Click(object sender, EventArgs e)
        {
            if (supplierId != null)
            {
                string supplierName = updateSupplierNameInput.Text;
                string supplierContact = updateSupplierContactInput.Text;
                string supplierAddress = updateSupplierAddressInput.Text;

                if (supplierName == "")
                {
                    MessageBox.Show("Error message: Fill the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        SupplierController supplierController = new SupplierController();
                        supplierController.UpdateSupplier(Convert.ToInt32(supplierId), supplierName, supplierContact, supplierAddress);
                        MessageBox.Show("Supplier updated successfully");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }

        private void cancelUpdateSupplierButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
