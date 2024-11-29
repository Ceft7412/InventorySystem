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
    public partial class ArchiveModal : Form
    {
        private ItemController itemController = new ItemController();
        private SupplierController supplierController = new SupplierController();
        private string selectedArchiveItemCode;
        private string selectedArchiveSupplier;
        public ArchiveModal()
        {
            InitializeComponent();
            LoadInactiveProducts();
            LoadInactiveSuppliers();
        }

        private void archivePanelsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (archivePanelsComboBox.SelectedItem != null)
            {
                switch (archivePanelsComboBox.SelectedItem.ToString())
                {
                    case "Items/Materials":
                        supplierArchivePanel.Visible = false;
                        unarchiveSupplierButton.Visible = false;
                        archiveSearchSupplierId.Visible = false;
                        archiveSearchByItemCode.Visible = true;
                        unarchiveProductButton.Visible = true;
                        productmaterialArchivePanel.Visible = true;
                        break;
                    case "Suppliers":
                        unarchiveProductButton.Visible = false;
                        productmaterialArchivePanel.Visible = false;
                        archiveSearchByItemCode.Visible = false;
                        archiveSearchSupplierId.Visible = true;
                        unarchiveSupplierButton.Visible = true;
                        supplierArchivePanel.Visible = true;
                        break;
                }
            }
        }

        private void PerformArchiveSearch(string searchQuery)
        {
            if (searchQuery != null)
            {
                try
                {
                    dataGridViewProductArchive.Rows.Clear();
                    List<Item> items = itemController.SearchItem(searchQuery, "inactive");
                    if (items != null && items.Count > 0)
                    {
                        foreach (var item in items)
                        {
                            dataGridViewProductArchive.Rows.Add(
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
        private void PerformArchiveSearchSupplier(string supplierQuery)
        {
            if (supplierQuery != null)
            {
                try
                {
                    dataGridViewArchiveSupplier.Rows.Clear();
                    List<Supplier> suppliers = supplierController.SearchSupplier(supplierQuery, "inactive");
                    if (suppliers != null && suppliers.Count > 0)
                    {
                        foreach (var supplier in suppliers)
                        {
                            dataGridViewArchiveSupplier.Rows.Add(
                                supplier.SupplierId,
                                supplier.SupplierName,
                                supplier.SupplierContact,
                                supplier.SupplierAddress);
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

        public void LoadInactiveProducts()
        {
            try
            {
                dataGridViewProductArchive.Rows.Clear();
                List<Item> items = itemController.GetAllItems("inactive");
                if (items != null && items.Count > 0)
                {
                    foreach (var item in items)
                    {
                        dataGridViewProductArchive.Rows.Add(
                            item.ProductCode,
                            item.ProductDescription,
                            item.Quantity.ToString(),
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
        public void LoadInactiveSuppliers()
        {
            try
            {
                dataGridViewArchiveSupplier.Rows.Clear();
                List<Supplier> suppliers = supplierController.GetAllSuppliers("inactive");
                if (suppliers != null && suppliers.Count > 0)
                {
                    foreach (var supplier in suppliers)
                    {
                        dataGridViewArchiveSupplier.Rows.Add(
                            supplier.SupplierId,
                            supplier.SupplierName,
                            supplier.SupplierContact,
                            supplier.SupplierAddress);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void productmaterialArchivePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewProductArchive_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            PerformArchiveSearch(archiveSearchByItemCode.Text);
        }

        private void archiveSearchByItemCode_TextChanged(object sender, EventArgs e)
        {
            PerformArchiveSearchSupplier(archiveSearchSupplierId.Text);
        }

        private void archiveSearchSupplierId_TextChanged(object sender, EventArgs e)
        {
            PerformArchiveSearchSupplier(archiveSearchSupplierId.Text);
        }

        private void unarchiveProductButton_Click(object sender, EventArgs e)
        {
            // Get all selected rows
            var selectedRows = dataGridViewProductArchive.SelectedRows;

            if (selectedRows.Count > 0)
            {
                var results = MessageBox.Show($"Are you sure you want to unarchive {selectedRows.Count} item(s)?", "Unarchive Item", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (results == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in selectedRows)
                    {
                        var itemCode = row.Cells[0].Value.ToString();
                        try
                        {
                            itemController.UnarchiveItem(itemCode);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Failed to unarchive item {itemCode}. Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    LoadInactiveProducts();
                }
            }
            else
            {
                MessageBox.Show("Please select one or more products to unarchive.", "Unarchive Product", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void unarchiveSupplierButton_Click(object sender, EventArgs e)
        {
            // Get all selected rows
            var selectedRows = dataGridViewArchiveSupplier.SelectedRows;

            if (selectedRows.Count > 0)
            {
                var results = MessageBox.Show($"Are you sure you want to unarchive {selectedRows.Count} supplier(s)?", "Unarchive Supplier", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (results == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in selectedRows)
                    {
                        var supplierCode = row.Cells[0].Value.ToString();
                        try
                        {
                            supplierController.UnarchiveSupplier(supplierCode);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Failed to unarchive supplier {supplierCode}. Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    LoadInactiveSuppliers(); 
                }
            }
            else
            {
                MessageBox.Show("Please select one or more suppliers to unarchive.", "Unarchive Supplier", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void rowArchiveItemCodeClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewProductArchive.Rows[e.RowIndex];
                selectedArchiveItemCode = row.Cells[0].Value.ToString();
            }
        }

        private void rowArchiveSupplierClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewArchiveSupplier.Rows[e.RowIndex];
                selectedArchiveSupplier = row.Cells[0].Value.ToString();
            }
        }
    }
}
