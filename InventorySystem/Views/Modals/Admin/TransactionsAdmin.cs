using InventorySystem.Controllers;
using InventorySystem.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem.Views.Modals.Admin
{
    public partial class TransactionsAdmin : Form
    {
        private BatchItemController batchItemController = new BatchItemController();
        public TransactionsAdmin()
        {
            InitializeComponent();
        }
        private void TransactionsAdmin_Load(object sender, EventArgs e)
        {
            LOADBATCHITEMS();
        }

        private void refreshData_Click(object sender, EventArgs e)
        {
            try
            {
                
                serachBatchItem.Text = "";
                typeCmb.SelectedIndex = -1;
                LOADBATCHITEMS();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void LOADBATCHITEMS()
        {
            try
            {
                dataGridViewTransactions.Rows.Clear();
                List<BatchItem> batchItems = batchItemController.GETROWSBATCHITEMS();
                if (batchItems != null && batchItems.Count > 0)
                {
                    foreach (var batchItem in batchItems)
                    {
                        dataGridViewTransactions.Rows.Add(
                            batchItem.BatchItemId,
                            batchItem.BatchId,
                            batchItem.ProductCode,
                            batchItem.Quantity.ToString(),
                            batchItem.Type,
                            batchItem.Reason,
                            batchItem.Date);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void SEARCHBATCHITEM(string query)
        {
            try
            {
                dataGridViewTransactions.Rows.Clear();
                List<BatchItem> batchItems = batchItemController.SEARCHBATCHITEMS(query);
                if (batchItems != null && batchItems.Count > 0)
                {
                    foreach (var batchItem in batchItems)
                    {
                        dataGridViewTransactions.Rows.Add(
                            batchItem.BatchItemId,
                            batchItem.BatchId,
                            batchItem.ProductCode,
                            batchItem.Quantity.ToString(),
                               batchItem.Type,
                            batchItem.Reason,
                            batchItem.Date);

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void serachBatchItem_TextChanged(object sender, EventArgs e)
        {
            SEARCHBATCHITEM(serachBatchItem.Text);
        }

        private void typeCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridViewTransactions.Rows.Clear();
                List<BatchItem> batchItems = batchItemController.FILTERBATCHITEMS(typeCmb.Text);
                if (batchItems != null && batchItems.Count > 0)
                {
                    foreach (var batchItem in batchItems)
                    {
                        dataGridViewTransactions.Rows.Add(
                            batchItem.BatchItemId,
                            batchItem.BatchId,
                            batchItem.ProductCode,
                            batchItem.Quantity.ToString(),
                            batchItem.Type,
                            batchItem.Reason,
                            batchItem.Date);

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error message: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }

        
    }
}
