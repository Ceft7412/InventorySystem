namespace InventoryManagementSystem
{
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        public void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheckBox.Checked)
            {
                passwordInput.PasswordChar = '\0';
            }
            else
            {
                passwordInput.PasswordChar = '*';
            }
        }
    }
}
    