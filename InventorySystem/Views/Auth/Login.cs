using InventorySystem.Controllers;
using InventorySystem.Views.Admin;
using InventorySystem.Views.Modals.Auth;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace InventorySystem.Views.Auth
{
    public partial class Login : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["InventoryDb"].ConnectionString;
        private AuthController AuthController = new AuthController();
        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var username = usernameTxt.Text;
                var password = passwordTxt.Text;

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Username and password are required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Attempt to log in and get role and first login status
                var (Success, Role, UserID, IsFirstLogin) = AuthController.LOGINUSER(username, password);
                if (Success)
                {
                    if (IsFirstLogin)
                    {
                        // Show change password window
                        ChangePassword changePasswordWindow = new ChangePassword(username); // Assuming you pass username
                        var dialogResult = changePasswordWindow.ShowDialog();

                        if (dialogResult != DialogResult.OK)
                        {
                            // If they cancel the change password process, return to the login window
                            return;
                        }

                        // Optional: Update is_first_login in database
                        AuthController.UpdateFirstLoginStatus(username);
                        SessionData.UserId = Convert.ToInt32(UserID);
                    }

                    // Proceed based on role
                    if (Role == "admin")
                    {
                        SessionData.UserId = Convert.ToInt32(UserID);
                        InventorySystem.Views.Admin.Admin adminWindow = new InventorySystem.Views.Admin.Admin();
                        adminWindow.Show();
                        this.Hide();
                    }
                    else if (Role == "employee")
                    {
                        SessionData.UserId = Convert.ToInt32(UserID);
                        Inventory inventoryWindow = new Inventory();
                        inventoryWindow.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void UpdateFirstLoginStatus(string username)
        //{
        //    try
        //    {
        //        string query = @"UPDATE tbUser SET is_first_login = 0 WHERE username = @username";
        //        using (SqlConnection connection = new SqlConnection(connectionString))
        //        {
        //            SqlCommand cmd = new SqlCommand(query, connection);
        //            cmd.Parameters.AddWithValue("@username", username);
        //            connection.Open();
        //            cmd.ExecuteNonQuery();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error updating first login status: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}




        private void showpasswordChk_CheckedChanged(object sender, EventArgs e)
        {
            if (showpasswordChk.Checked)
            {
                // \0 is the null character in C#.
                passwordTxt.PasswordChar = '\0';
            }
            else
            {
                // * is the character that will be shown in the password field.
                passwordTxt.PasswordChar = '*';
            }
        }

        private void username(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginBtn_Click(sender, e);
            }
        }

        private void passwordKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginBtn_Click(sender, e);
            }
        }
    }
}
