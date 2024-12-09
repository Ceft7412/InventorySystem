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

namespace InventorySystem.Views.Modals.Auth
{
    public partial class ChangePassword : Form
    {
        private string username;
        private AuthController AuthController = new AuthController();
        public ChangePassword(string usernameTxt)
        {
            InitializeComponent();
            username = usernameTxt;
        }

        private void ChangePassword_Load_1(object sender, EventArgs e)
        {
            usernameTxt.Text = username;
        }  

        private void showpasswordChk_CheckedChanged(object sender, EventArgs e)
        {
            if (showpasswordChk.Checked)
            {
                // \0 is the null character in C#.
                currentpasswordTxt.PasswordChar = '\0';
                newpasswordTxt.PasswordChar = '\0';
            }
            else
            {
                // * is the character that will be shown in the password field.
                currentpasswordTxt.PasswordChar = '*';
                newpasswordTxt.PasswordChar = '*';
            }
        }



        private void changeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(currentpasswordTxt.Text) || string.IsNullOrEmpty(newpasswordTxt.Text))
                {
                    MessageBox.Show("All fields are required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (newpasswordTxt.Text.Length < 5)
                {
                    MessageBox.Show("Password must be at least 5 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!AuthController.CheckMatchPassword(username, currentpasswordTxt.Text))
                {
                    MessageBox.Show("Current password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var result = MessageBox.Show("Are you sure you want to change your password?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool status = AuthController.UpdatePassword(username, newpasswordTxt.Text);

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
