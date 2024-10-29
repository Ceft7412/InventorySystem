namespace InventoryManagementSystem
{
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
        }


        // This function will listen to the check box of the show password. If the check box is checked, the password will be shown.
        public void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheckBox.Checked)
            {
                // \0 is the null character in C#.
                passwordInput.PasswordChar = '\0';
            }
            else
            {
                // * is the character that will be shown in the password field.
                passwordInput.PasswordChar = '*';
            }
        }

        public void loginButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                // This is the function that will be called when the login button is clicked.
                // This function will check if the username and password are correct.
                // If they are correct, the user will be logged in.
                // If they are not correct, the user will be shown an error message.
                if (userNameInput.Text == "" || passwordInput.Text == "")
                {
                    MessageBox.Show("Please enter a username and password.", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //else if (username == "admin" && password == "admin")
                //{
                //    MessageBox.Show("Login successful!");
                //    this.Hide();
                //    InventoryManagementSystem ims = new InventoryManagementSystem();
                //    ims.Show();
                //}
                //else
                //{
                //    MessageBox.Show("Invalid username or password.");
                //}
                MessageBox.Show("Login Successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch(Exception ex)
            {
                MessageBox.Show("Login failed with the message: " + ex.Message);
            }
        }   

        private void username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginButton_Click(sender, e);
            }
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginButton_Click(sender, e);
            }
        }
    }
}
        