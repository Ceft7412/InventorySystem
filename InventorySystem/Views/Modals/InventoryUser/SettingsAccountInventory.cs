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
    public partial class SettingsAccountInventory : Form
    {
        private AuthController AuthController = new AuthController();
        public SettingsAccountInventory()
        {
            InitializeComponent();
        }

        private void SettingsAccountInventory_Load(object sender, EventArgs e)
        {
            LoadEmployeeData();
        }
        public void LoadEmployeeData()
        {
            Employee employee = AuthController.GetEmployeeData(SessionData.UserId);
            if (employee != null)
            {
                idTxt.Text = SessionData.UserId.ToString();
                firstnameTxt.Text = employee.Firstname;
                lastnameTxt.Text = employee.Lastname;
                usernameTxt.Text = employee.Username;
                contactTxt.Text = employee.Contact;
                addressTxt.Text = employee.Address;
            }
        }
        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(firstnameTxt.Text))
            {
                MessageBox.Show("Firstname is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(lastnameTxt.Text))
            {
                MessageBox.Show("Lastname is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(usernameTxt.Text))
            {
                MessageBox.Show("Username is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var message = MessageBox.Show("Are you sure you want to update your information?", "Update information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (message == DialogResult.No)
            {
                return;
            }

            bool result = AuthController.UpdateEmployeeInfo(SessionData.UserId, firstnameTxt.Text, lastnameTxt.Text, usernameTxt.Text, contactTxt.Text, addressTxt.Text);
            if (result)
            {
                MessageBox.Show("Account updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadEmployeeData();
            }
            else
            {
                MessageBox.Show("Failed to update account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void closeSettingsWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void changepasswordBtn_Click(object sender, EventArgs e)
        {
            ChangePasswordInventoryUser changePasswordInventoryUser = new ChangePasswordInventoryUser();
            changePasswordInventoryUser.ShowDialog();
        }
    }
}
