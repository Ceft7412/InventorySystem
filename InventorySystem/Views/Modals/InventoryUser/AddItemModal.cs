using InventorySystem.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using InventorySystem.Models;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Microsoft.Data.SqlClient;

namespace InventorySystem.Views.Modals.InventoryUser
{
    public partial class AddItemModal : Form
    {
        ItemController itemController = new ItemController();
        SupplierController SupplierController = new SupplierController();
        private string connectionString = ConfigurationManager.ConnectionStrings["InventoryDb"].ConnectionString;

        // List to keep track of dynamically created ComboBoxes
        private List<ComboBox> supplierComboBoxes = new List<ComboBox>();

        // Counter to keep track of the vertical position for each new ComboBox
        private int verticalPosition = 397; // Starting Y position for the first ComboBox
        public AddItemModal()
        {
            InitializeComponent();
            LOAD_SUPPLIER_INTO_COMBOBOX();
        }

        private void cancelCreateItemButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddItemModal_Load(object sender, EventArgs e)
        {
            LOAD_SUPPLIER_INTO_COMBOBOX();
        }

        private void LOAD_SUPPLIER_INTO_COMBOBOX()
        {
            try
            {
                supplierPanel.Controls.Clear(); 
                List<Supplier> suppliers = SupplierController.GetAllSupplierNames();

                if (suppliers != null && suppliers.Count > 0)
                {
                    int yPosition = 10;  // Y position for the first checkbox

                    foreach (var supplier in suppliers)
                    {
                        // Create a new CheckBox
                        CheckBox supplierCheckBox = new CheckBox();
                        supplierCheckBox.Text = supplier.SupplierName; // Display supplier name
                        supplierCheckBox.Font = new Font("Calibri", 13F); // Set font size
                        supplierCheckBox.Tag = supplier.SupplierId;    // Store SupplierId in the Tag property (hidden value)
                        supplierCheckBox.Location = new Point(10, yPosition); // Set location (x, y)
                        supplierCheckBox.Size = new Size(200, 35);    // Set size
                        yPosition += 30;  // Increment the yPosition for the next checkbox (spacing)

                        // Optionally, you can handle the event when a checkbox is checked
                        supplierCheckBox.CheckedChanged += SupplierCheckBox_CheckedChanged;

                        // Add the checkbox to the panel
                        supplierPanel.Controls.Add(supplierCheckBox);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SupplierCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox != null)
            {
                int supplierId = (int)checkBox.Tag;  // Get the SupplierId from the Tag property
                bool isChecked = checkBox.Checked;   // Check if the checkbox is checked
            }
        }

        private void createNewItemButton_Click(object sender, EventArgs e)
        {
            // Check if any of the fields are empty
            if (itemCodeInput.Text == "" || itemDescriptionInput.Text == "")
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var message = MessageBox.Show("Are you sure you want to add this item?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (message == DialogResult.No)
            {
                return;
            }

            int minimumStock;
            if (!int.TryParse(itemMSLInput.Text, out minimumStock))
            {
                // Default to 0 if input is blank or invalid
                minimumStock = 0;
            }

            int item_id = ItemController.GenerateItemId(); // Generate the new item ID

            try
            {
                // Create a new item object
                Item item = new Item
                {
                    ItemId = item_id,
                    ProductCode = itemCodeInput.Text,
                    ProductDescription = itemDescriptionInput.Text,
                    Category = itemCategoryInput.Text,
                    Quantity = 0,
                    Unit = itemUnitInput.Text,
                    MinimumStock = itemMSLInput.Text == "" ? 0 : minimumStock,
                };

                // Add the new item to the database
                itemController.AddItem(item);

                // Now, handle the item-supplier relationship
                foreach (Control control in supplierPanel.Controls)  // Loop through all checkboxes in the supplier panel
                {
                    if (control is CheckBox checkBox && checkBox.Checked)
                    {
                        int supplierId = (int)checkBox.Tag; // Get SupplierId from the Tag property of the checkbox
                        SupplierController.InsertItemSupplier(item_id, supplierId); // Insert the item-supplier relationship into tbItemSupplier
                    }
                }

                // Notify the user that the item was added successfully
                var result = MessageBox.Show("Item added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    this.Close(); // Close the form
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //private void btnAddSupplier_Click(object sender, EventArgs e)
        //{
        //    // Create a new ComboBox for selecting a supplier
        //    ComboBox newSupplierComboBox = new ComboBox
        //    {
        //        DropDownStyle = ComboBoxStyle.DropDownList,
        //        Font = new Font("Calibri", 16F),
        //        FormattingEnabled = true,
        //        Location = new Point(40, verticalPosition), // Position below the last ComboBox
        //        Size = new Size(514, 34),
        //    };

        //    // Populate the ComboBox with supplier data
        //    PopulateSuppliers(newSupplierComboBox);

        //    // Add the newly created ComboBox to the form
        //    this.Controls.Add(newSupplierComboBox);

        //    // Add the ComboBox to the list for later reference (if you need to access them later)
        //    supplierComboBoxes.Add(newSupplierComboBox);

        //    // Update the vertical position for the next ComboBox
        //    verticalPosition += 40; // Adjust the spacing between ComboBoxes
        //}

        //// Method to populate the ComboBox with suppliers
        //private void PopulateSuppliers(ComboBox comboBox)
        //{
        //    try
        //    {
        //        List<string> suppliers = GetSuppliersFromDatabase(); // Fetch supplier names from your database
        //        comboBox.Items.Clear(); // Clear previous items

        //        // Add suppliers to ComboBox
        //        foreach (string supplier in suppliers)
        //        {
        //            comboBox.Items.Add(supplier);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error loading suppliers: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //// Method to fetch supplier data from the database
        //private List<string> GetSuppliersFromDatabase()
        //{
        //    List<string> suppliers = new List<string>();

        //    // Query the database to get supplier names
        //    string query = "SELECT supplierName FROM tbSupplier"; // Modify the query based on your table structure

        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        SqlCommand command = new SqlCommand(query, connection);
        //        connection.Open();
        //        SqlDataReader reader = command.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            suppliers.Add(reader["supplierName"].ToString());
        //        }

        //        reader.Close();
        //    }

        //    return suppliers;
        //}

    }
}
