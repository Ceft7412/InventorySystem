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
    public partial class UpdateEmployee : Form
    {
        private string employeeID;
        private EmployeeController employeeController = new EmployeeController();
        public UpdateEmployee(string id)
        {
            InitializeComponent();
            employeeID = id;

        }
        private void UpdateEmployee_Load(object sender, EventArgs e)
        {
            LOAD_EMPLOYEE();
        }
        public void LOAD_EMPLOYEE()
        {
            try
            {
                Employee employee = employeeController.GET_EMPLOYEE_DATA(employeeID);
                if (employee != null)
                {
                    updateEmployeeIDInput.Text = employee.EmployeeID;
                    updateEmployeeFirstnameInput.Text = employee.Firstname;
                    updateEmployeeLastnameInput.Text = employee.Lastname;
                    updateEmployeeContactInput.Text = employee.Contact;
                    updateEmployeeAddressInput.Text = employee.Address;
                }
                else
                {
                    MessageBox.Show("Employee not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //string contactInput = updateEmployeeContactInput.Text.Trim();
                //long? contact = null;
                //// Validate contact number only if it's provided
                //if (!string.IsNullOrEmpty(contactInput))
                //{
                //    if (!long.TryParse(contactInput, out long parsedContact))
                //    {
                //        MessageBox.Show("Invalid contact number. Please enter a valid numeric value.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //        return;
                //    }
                //    contact = parsedContact; // Only set contact if parsing is successful

                //}


                var confirmation_message = MessageBox.Show("You are about to update an employee. Do you wish to continue?", "Update Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (confirmation_message == DialogResult.No)
                {
                    return;
                }
                Employee employee = new Employee()
                {
                    EmployeeID = updateEmployeeIDInput.Text,
                    Firstname = updateEmployeeFirstnameInput.Text,
                    Lastname = updateEmployeeLastnameInput.Text,
                    Contact = updateEmployeeContactInput.Text,
                    Address = updateEmployeeAddressInput.Text
                };
                bool result = employeeController.UPDATE_EMPLOYEE(employee);
                if (result)
                {
                    MessageBox.Show("Employee updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Employee not updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
