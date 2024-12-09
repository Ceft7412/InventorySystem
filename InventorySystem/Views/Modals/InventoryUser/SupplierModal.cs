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
using Excel = Microsoft.Office.Interop.Excel;   

namespace InventorySystem.Views.Modals.InventoryUser
{
    public partial class SupplierModal : Form
    {
        private SupplierController supplierController = new SupplierController();
        private string selectedSupplier;
        public SupplierModal()
        {
            InitializeComponent();
            LoadSuppliers();
        }

        private void LoadSuppliers()
        {
            try
            {
                dataGridViewSuppliers.Rows.Clear();
                List<Supplier> suppliers = supplierController.GetAllSuppliers("active");
                if (suppliers != null && suppliers.Count > 0)
                {
                    foreach (var supplier in suppliers)
                    {
                        dataGridViewSuppliers.Rows.Add(
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
                return;
            }
        }

        private void newSupplierButton_Click(object sender, EventArgs e)
        {
            try
            {
                NewSupplier newSupplier = new NewSupplier();
                newSupplier.ShowDialog();
                LoadSuppliers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void updateSupplierButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(selectedSupplier))
                {
                    UpdateSupplier updateSupplier = new UpdateSupplier(selectedSupplier);
                    updateSupplier.ShowDialog();
                    LoadSuppliers();
                }
                else
                {
                    MessageBox.Show("Error message: Please select a supplier to update.", "Update Supplier", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void archiveSupplierButton_Click(object sender, EventArgs e)
        {
            var selectedRows = dataGridViewSuppliers.SelectedRows;

            if (selectedRows.Count > 0)
            {
                var result = MessageBox.Show($"Are you sure you want to archive {selectedRows.Count} supplier(s)?", "Archive Supplier", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    SupplierController supplierController = new SupplierController();

                    foreach (DataGridViewRow row in selectedRows)
                    {
                        var supplierCode = row.Cells["SupplierCodeColumn"].Value.ToString();
                        try
                        {
                            supplierController.ArchiveSupplier(supplierCode);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Failed to archive supplier {supplierCode}. Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    LoadSuppliers(); 
                }
            }
            else
            {
                MessageBox.Show("Please select one or more suppliers to archive.", "Archive Supplier", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void exportSupplierButton_Click(object sender, EventArgs e)
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
                worksheet.Name = "Supplier Data";

                // Export column headers
                for (int i = 0; i < dataGridViewSuppliers.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = dataGridViewSuppliers.Columns[i].HeaderText;
                }

                // Export row data
                for (int i = 0; i < dataGridViewSuppliers.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridViewSuppliers.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridViewSuppliers.Rows[i].Cells[j].Value?.ToString();
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

        private void supplierRowClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewSuppliers.Rows[e.RowIndex];
                selectedSupplier = row.Cells[0].Value.ToString();
            }
        }

        private void searchSupplierBox_TextChanged(object sender, EventArgs e)
        {
            PerformSearchSupplier(searchSupplierBox.Text);
        }

        // Function to search for supplier
        private void PerformSearchSupplier(string supplierQuery)
        {
            if (supplierQuery != null)
            {
                try
                {
                    dataGridViewSuppliers.Rows.Clear();
                    List<Supplier> suppliers = supplierController.SearchSupplier(supplierQuery, "active");
                    if (suppliers != null && suppliers.Count > 0)
                    {
                        foreach (var supplier in suppliers)
                        {
                            dataGridViewSuppliers.Rows.Add(
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
                    return;
                }
            }

        }
    }
}
