using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventorySystem.Controllers;

namespace InventorySystem.Views.Modals.Admin
{
    public partial class AddEmployee : Form
    {
        private EmployeeController employeeController = new EmployeeController();
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(firstnameTxt.Text) || string.IsNullOrEmpty(lastnameTxt.Text))
                {
                    MessageBox.Show("Please fill in the necessary fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var result = MessageBox.Show("You are adding an employee. Do you wish to continue adding?", "Adding Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    string firstname = firstnameTxt.Text.Trim();
                    string lastname = lastnameTxt.Text.Trim();
                    string contactInput = contactTxt.Text.Trim();
                    string address = addressTxt.Text.Trim();

                    // Initialize contact number variable, set default as 0 or null as per your design
                    long? contact = null;

                    // Validate contact number only if it's provided
                    if (!string.IsNullOrEmpty(contactInput))
                    {
                        if (!long.TryParse(contactInput, out long parsedContact))
                        {
                            MessageBox.Show("Invalid contact number. Please enter a valid numeric value.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        contact = parsedContact; // Only set contact if parsing is successful
                    }

                    // Proceed with adding the employee
                    employeeController.ADDEMPLOYEE(firstname, lastname, (long)contact, address);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }
    }
}
