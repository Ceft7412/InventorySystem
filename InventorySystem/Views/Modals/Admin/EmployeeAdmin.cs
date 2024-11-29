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
using InventorySystem.Models;

namespace InventorySystem.Views.Modals.Admin
{
    public partial class EmployeeAdmin : Form
    {
        private EmployeeController employeeController = new EmployeeController();
        public EmployeeAdmin()
        {
            InitializeComponent();
        }

        private void EmployeeAdmin_Load(object sender, EventArgs e)
        {
            FETCHEMPLOYEES();
        }

        private void addEmployeeBtnRedirect_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.ShowDialog();
            FETCHEMPLOYEES();
        }

        private void FETCHEMPLOYEES()
        {
            try
            {
                dataGridViewEmployees.Rows.Clear();
                List<Employee> employees = employeeController.FETCH_EMPLOYEES();
                if(employees != null && employees.Count > 0)
                {
                    foreach(var employee in employees)
                    {
                        dataGridViewEmployees.Rows.Add(
                            employee.EmployeeID,
                            employee.Firstname + " " + employee.Lastname,
                            employee.Contact,
                            employee.Address
                        );
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void dataGridViewEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        
    }
}
