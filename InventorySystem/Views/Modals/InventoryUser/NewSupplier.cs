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
    public partial class NewSupplier : Form
    {
        public NewSupplier()
        {
            InitializeComponent();
        }

        private void createNewSupplierButton_Click(object sender, EventArgs e)
        {
            string supplierName = supplierNameInput.Text;
            string supplierContact = supplierContactInput.Text;
            string supplierAddress = supplierAddressInput.Text;

            if (supplierName == "")
            {
                MessageBox.Show("Please fill the supplier name.");
            }
            else
            {
                try
                {
                    SupplierController supplierController = new SupplierController();
                    supplierController.CreateSupplier(supplierName, supplierContact, supplierAddress);
                    MessageBox.Show("Supplier created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    throw new("An error occured: " + ex.Message);
                }
            }
        }

        private void cancelCreateSupplierButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
