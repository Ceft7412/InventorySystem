using InventorySystem.Views.Admin;
using InventorySystem.Views.Auth;
using InventorySystem.Views.Modals.InventoryUser;

namespace InventorySystem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // Define a unique name for the Mutex
            string mutexName = "SangreeInventory";

            // Create the Mutex
            using (Mutex mutex = new Mutex(true, mutexName, out bool isNewInstance))
            {
                // Check if this is the only instance
                if (isNewInstance)
                {
                    // Set the DataDirectory to be used in connection strings
                    string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                    AppDomain.CurrentDomain.SetData("DataDirectory", baseDirectory);
                    // To customize application configuration such as set high DPI settings or default font,
                    // see https://aka.ms/applicationconfiguration.
                    ApplicationConfiguration.Initialize();
                    Application.Run(new Login());
                }
                else
                {
                    // Another instance is already running
                    MessageBox.Show("The application is already running.", "Running Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

           

        }
    }
}