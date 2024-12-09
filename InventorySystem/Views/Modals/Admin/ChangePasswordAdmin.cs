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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace InventorySystem.Views.Modals.Admin
{
    public partial class ChangePasswordAdmin : Form
    {
        AuthController AuthController = new AuthController();
        public ChangePasswordAdmin()
        {
            InitializeComponent();
        }


        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentPasswordTxt.Text) || string.IsNullOrEmpty(newPasswordTxt.Text))
            {
                MessageBox.Show("All fields are required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!AuthController.CheckMatchPasswordAdmin(SessionData.UserId, currentPasswordTxt.Text))
            {
                MessageBox.Show("Current password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (newPasswordTxt.Text != confirmPasswordTxt.Text)
            {
                MessageBox.Show("Passwords do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to change your password?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                bool status = AuthController.UpdatePasswordAdmin(SessionData.UserId, newPasswordTxt.Text);

                if (status)
                {
                    MessageBox.Show("Password changed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Error changing password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showpasswordChk_CheckedChanged(object sender, EventArgs e)
        {
            if (showpasswordChk.Checked)
            {
                // \0 is the null character in C#.
                currentPasswordTxt.PasswordChar = '\0';
                newPasswordTxt.PasswordChar = '\0';
                confirmPasswordTxt.PasswordChar = '\0';
            }
            else
            {
                // * is the character that will be shown in the password field.
                currentPasswordTxt.PasswordChar = '*';
                newPasswordTxt.PasswordChar = '*';
                confirmPasswordTxt.PasswordChar = '*';
            }
        }
    }
}
