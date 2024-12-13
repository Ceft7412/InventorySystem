using InventorySystem.Views.Admin;
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
using InventorySystem.Models;

namespace InventorySystem.Views.Modals.Admin
{
    public partial class SettingsAccount : Form
    {
        AuthController AuthController = new AuthController();


        public SettingsAccount()
        {
            InitializeComponent();
        }
        private void SettingsAccount_Load(object sender, EventArgs e)
        {
            idTxt.Text = SessionData.UserId.ToString();
            LoadEmployeeData();
        }

        public void LoadEmployeeData()
        {
            Employee employee = AuthController.GetEmployeeData(SessionData.UserId);
            if (employee != null)
            {
                firstnameTxt.Text = employee.Firstname;
                lastnameTxt.Text = employee.Lastname;
                usernameTxt.Text = employee.Username;
            }
        }

        private void closeSettingsWindow_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(firstnameTxt.Text) || string.IsNullOrEmpty(lastnameTxt.Text) || string.IsNullOrEmpty(usernameTxt.Text))
            {
                MessageBox.Show("All fields are required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var message = MessageBox.Show("Are you sure you want to update your information?", "Update information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(message == DialogResult.No)
            {
                return;
            }


            bool result = AuthController.UpdateAdminInfo(SessionData.UserId, firstnameTxt.Text, lastnameTxt.Text, usernameTxt.Text);
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

        private void changepasswordBtn_Click(object sender, EventArgs e)
        {
            ChangePasswordAdmin changePasswordAdmin = new ChangePasswordAdmin();
            changePasswordAdmin.ShowDialog();
        }
    }
}
