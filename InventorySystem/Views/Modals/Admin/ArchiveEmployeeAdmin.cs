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
using Microsoft.IdentityModel.Tokens;
using Excel = Microsoft.Office.Interop.Excel;
namespace InventorySystem.Views.Modals.Admin
{
    public partial class ArchiveEmployeeAdmin : Form
    {
        private EmployeeController employeeController = new EmployeeController();

        public ArchiveEmployeeAdmin()
        {
            InitializeComponent();
            FETCHEMPLOYEES();
        }

        private void unarchiveEmployeeBtn_Click(object sender, EventArgs e)
        {

            var selectedRows = dataGridViewEmployees.SelectedRows;
            if (selectedRows.Count > 0)
            {
                var results = MessageBox.Show($"Are you sure you want to unarchive {selectedRows.Count} item(s)?", "Unarchive Item", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (results == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in selectedRows)
                    {
                        string employeeID = row.Cells[0].Value.ToString();
                        try
                        {
                            employeeController.UNARCHIVE_EMPLOYEE(employeeID);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Failed to unarchive employee: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                    }
                    MessageBox.Show(Text = $"{selectedRows.Count} employee(s) unarchived successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FETCHEMPLOYEES();
                }
            }
            else
            {
                MessageBox.Show("Please select an employee to unarchive.", "Select employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void FETCHEMPLOYEES()
        {
            try
            {
                dataGridViewEmployees.Rows.Clear();
                List<Employee> employees = employeeController.FETCH_INACTIVE_EMPLOYEES();
                if (employees != null && employees.Count > 0)
                {
                    foreach (var employee in employees)
                    {
                        dataGridViewEmployees.Rows.Add(
                            employee.EmployeeID,
                            employee.Firstname + " " + employee.Lastname,
                            employee.Username,
                            employee.Contact.ToString(),
                            employee.Address
                        );
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void exportExcelBtn_Click(object sender, EventArgs e)
        {
            try
            {

                var message = MessageBox.Show("Do you want to export the employee data to Excel?", "Export to Excel", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (message == DialogResult.No)
                {
                    return;
                }
                Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = true;
                Excel.Workbook workbook = excelApp.Workbooks.Add();
                Excel._Worksheet worksheet = workbook.Sheets[1];
                worksheet.Cells[1, 1] = "Employee ID";
                worksheet.Cells[1, 2] = "Fullname";
                worksheet.Cells[1, 3] = "Username";
                worksheet.Cells[1, 4] = "Contact";
                worksheet.Cells[1, 5] = "Address";
                int row = 2;
                foreach (DataGridViewRow dataRow in dataGridViewEmployees.Rows)
                {
                    worksheet.Cells[row, 1] = dataRow.Cells[0].Value;
                    worksheet.Cells[row, 2] = dataRow.Cells[1].Value;
                    worksheet.Cells[row, 3] = dataRow.Cells[2].Value;
                    worksheet.Cells[row, 4] = dataRow.Cells[3].Value;
                    worksheet.Cells[row, 5] = dataRow.Cells[4].Value;
                    row++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void employeeTxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SEARCH_AND_DISPLAY_EMPLOYEES();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SEARCH_AND_DISPLAY_EMPLOYEES()
        {
            try
            {
                dataGridViewEmployees.Rows.Clear();

                // Get the search query from the employeeTxt textbox
                string searchText = employeeTxt.Text.Trim();

                // Call the search method to get matching employees
                List<Employee> employees = employeeController.SEARCH_INACTIVE_EMPLOYEE(searchText);

                // If employees are found, display them in the DataGridView
                if (employees != null && employees.Count > 0)
                {
                    foreach (var employee in employees)
                    {
                        dataGridViewEmployees.Rows.Add(
                            employee.EmployeeID,
                            employee.Firstname + " " + employee.Lastname,
                            employee.Username,
                            employee.Contact,
                            employee.Address
                        );
                    }
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error message: " + ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
