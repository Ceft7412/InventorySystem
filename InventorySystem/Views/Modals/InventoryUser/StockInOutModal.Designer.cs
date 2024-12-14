namespace InventorySystem.Views.Modals.InventoryUser
{
    partial class StockInOutModal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockInOutModal));
            topbarStockInOutPanel = new Panel();
            label1 = new Label();
            bodyStockInOutPanel = new Panel();
            panel3 = new Panel();
            panel14 = new Panel();
            panel13 = new Panel();
            panel17 = new Panel();
            btnRemoveBatchItem = new Button();
            btnRemoveItem = new Button();
            panel16 = new Panel();
            stockOutButtonsPanel = new Panel();
            btnClearStockOutItems = new Button();
            btnSaveAllStockOutItems = new Button();
            stockInButtonsPanel = new Panel();
            btnClearStockInItems = new Button();
            btnSaveAllStockInItems = new Button();
            dataGridViewBatchItems = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            panel4 = new Panel();
            stockInPanel = new Panel();
            stockInItemIdInput = new TextBox();
            label14 = new Label();
            stockInUnitCmb = new ComboBox();
            label12 = new Label();
            stockInSaveButton = new Button();
            stockInClear = new Button();
            stockInDateInput = new DateTimePicker();
            stockInReasonInput = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            stockInProductQuantity = new TextBox();
            label4 = new Label();
            stockInProductCodeInput = new TextBox();
            label3 = new Label();
            label2 = new Label();
            stockOutPanel = new Panel();
            stockOutItemIdInput = new TextBox();
            label15 = new Label();
            stockOutUnitCmb = new ComboBox();
            label13 = new Label();
            stockOutSaveButton = new Button();
            stockOutClear = new Button();
            stockOutDateInput = new DateTimePicker();
            stockOutReasonInput = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            stockOutProductQuantity = new TextBox();
            label9 = new Label();
            stockOutProductCodeInput = new TextBox();
            label10 = new Label();
            label11 = new Label();
            panel2 = new Panel();
            stockOutButton = new Button();
            stockInButton = new Button();
            topbarStockInOutPanel.SuspendLayout();
            bodyStockInOutPanel.SuspendLayout();
            panel3.SuspendLayout();
            panel14.SuspendLayout();
            panel13.SuspendLayout();
            panel17.SuspendLayout();
            panel16.SuspendLayout();
            stockOutButtonsPanel.SuspendLayout();
            stockInButtonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBatchItems).BeginInit();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            stockInPanel.SuspendLayout();
            stockOutPanel.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // topbarStockInOutPanel
            // 
            topbarStockInOutPanel.BackColor = Color.Transparent;
            topbarStockInOutPanel.BackgroundImage = Properties.Resources.panelBackground;
            topbarStockInOutPanel.Controls.Add(label1);
            topbarStockInOutPanel.Dock = DockStyle.Top;
            topbarStockInOutPanel.Location = new Point(0, 0);
            topbarStockInOutPanel.Name = "topbarStockInOutPanel";
            topbarStockInOutPanel.Size = new Size(1771, 99);
            topbarStockInOutPanel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 26F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(24, 31);
            label1.Name = "label1";
            label1.Size = new Size(197, 42);
            label1.TabIndex = 0;
            label1.Text = "Stock In/Out";
            // 
            // bodyStockInOutPanel
            // 
            bodyStockInOutPanel.Controls.Add(panel3);
            bodyStockInOutPanel.Controls.Add(panel1);
            bodyStockInOutPanel.Dock = DockStyle.Fill;
            bodyStockInOutPanel.Location = new Point(0, 99);
            bodyStockInOutPanel.Name = "bodyStockInOutPanel";
            bodyStockInOutPanel.Size = new Size(1771, 860);
            bodyStockInOutPanel.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(panel14);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(525, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1246, 860);
            panel3.TabIndex = 1;
            // 
            // panel14
            // 
            panel14.BorderStyle = BorderStyle.FixedSingle;
            panel14.Controls.Add(panel13);
            panel14.Controls.Add(dataGridViewBatchItems);
            panel14.Dock = DockStyle.Fill;
            panel14.Location = new Point(0, 0);
            panel14.Name = "panel14";
            panel14.Size = new Size(1244, 858);
            panel14.TabIndex = 21;
            // 
            // panel13
            // 
            panel13.BackColor = SystemColors.ControlLightLight;
            panel13.BorderStyle = BorderStyle.FixedSingle;
            panel13.Controls.Add(panel17);
            panel13.Controls.Add(panel16);
            panel13.Dock = DockStyle.Bottom;
            panel13.Location = new Point(0, 744);
            panel13.Name = "panel13";
            panel13.Size = new Size(1242, 112);
            panel13.TabIndex = 20;
            // 
            // panel17
            // 
            panel17.BackColor = SystemColors.Control;
            panel17.Controls.Add(btnRemoveBatchItem);
            panel17.Controls.Add(btnRemoveItem);
            panel17.Dock = DockStyle.Fill;
            panel17.Location = new Point(0, 0);
            panel17.Name = "panel17";
            panel17.Size = new Size(908, 110);
            panel17.TabIndex = 33;
            // 
            // btnRemoveBatchItem
            // 
            btnRemoveBatchItem.Anchor = AnchorStyles.Right;
            btnRemoveBatchItem.BackColor = Color.Firebrick;
            btnRemoveBatchItem.FlatStyle = FlatStyle.Flat;
            btnRemoveBatchItem.Font = new Font("Calibri", 15F);
            btnRemoveBatchItem.ForeColor = SystemColors.Control;
            btnRemoveBatchItem.Location = new Point(769, 33);
            btnRemoveBatchItem.Name = "btnRemoveBatchItem";
            btnRemoveBatchItem.Size = new Size(133, 49);
            btnRemoveBatchItem.TabIndex = 33;
            btnRemoveBatchItem.Text = "REMOVE";
            btnRemoveBatchItem.UseVisualStyleBackColor = false;
            btnRemoveBatchItem.Click += btnRemoveBatchItem_Click;
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.Anchor = AnchorStyles.Right;
            btnRemoveItem.BackColor = Color.Firebrick;
            btnRemoveItem.FlatStyle = FlatStyle.Flat;
            btnRemoveItem.Font = new Font("Segoe UI", 15F);
            btnRemoveItem.ForeColor = SystemColors.Control;
            btnRemoveItem.Location = new Point(1338, 33);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new Size(133, 54);
            btnRemoveItem.TabIndex = 32;
            btnRemoveItem.Text = "REMOVE";
            btnRemoveItem.UseVisualStyleBackColor = false;
            // 
            // panel16
            // 
            panel16.Controls.Add(stockOutButtonsPanel);
            panel16.Controls.Add(stockInButtonsPanel);
            panel16.Dock = DockStyle.Right;
            panel16.Location = new Point(908, 0);
            panel16.Name = "panel16";
            panel16.Size = new Size(332, 110);
            panel16.TabIndex = 31;
            // 
            // stockOutButtonsPanel
            // 
            stockOutButtonsPanel.BackColor = SystemColors.Control;
            stockOutButtonsPanel.Controls.Add(btnClearStockOutItems);
            stockOutButtonsPanel.Controls.Add(btnSaveAllStockOutItems);
            stockOutButtonsPanel.Dock = DockStyle.Fill;
            stockOutButtonsPanel.Location = new Point(0, 0);
            stockOutButtonsPanel.Name = "stockOutButtonsPanel";
            stockOutButtonsPanel.Size = new Size(332, 110);
            stockOutButtonsPanel.TabIndex = 30;
            stockOutButtonsPanel.Visible = false;
            // 
            // btnClearStockOutItems
            // 
            btnClearStockOutItems.Anchor = AnchorStyles.Right;
            btnClearStockOutItems.BackColor = Color.Firebrick;
            btnClearStockOutItems.FlatStyle = FlatStyle.Flat;
            btnClearStockOutItems.Font = new Font("Calibri", 15F);
            btnClearStockOutItems.ForeColor = SystemColors.Control;
            btnClearStockOutItems.Location = new Point(15, 33);
            btnClearStockOutItems.Name = "btnClearStockOutItems";
            btnClearStockOutItems.Size = new Size(133, 49);
            btnClearStockOutItems.TabIndex = 29;
            btnClearStockOutItems.Text = "CLEAR";
            btnClearStockOutItems.UseVisualStyleBackColor = false;
            btnClearStockOutItems.Click += btnClearStockOutItems_Click;
            // 
            // btnSaveAllStockOutItems
            // 
            btnSaveAllStockOutItems.Anchor = AnchorStyles.Right;
            btnSaveAllStockOutItems.BackColor = Color.MediumSeaGreen;
            btnSaveAllStockOutItems.FlatStyle = FlatStyle.Flat;
            btnSaveAllStockOutItems.Font = new Font("Calibri", 15F);
            btnSaveAllStockOutItems.ForeColor = SystemColors.ButtonHighlight;
            btnSaveAllStockOutItems.Location = new Point(173, 33);
            btnSaveAllStockOutItems.Name = "btnSaveAllStockOutItems";
            btnSaveAllStockOutItems.Size = new Size(133, 49);
            btnSaveAllStockOutItems.TabIndex = 30;
            btnSaveAllStockOutItems.Text = "SAVE ALL";
            btnSaveAllStockOutItems.UseVisualStyleBackColor = false;
            btnSaveAllStockOutItems.Click += btnSaveAllStockOutItems_Click;
            // 
            // stockInButtonsPanel
            // 
            stockInButtonsPanel.BackColor = SystemColors.Control;
            stockInButtonsPanel.Controls.Add(btnClearStockInItems);
            stockInButtonsPanel.Controls.Add(btnSaveAllStockInItems);
            stockInButtonsPanel.Dock = DockStyle.Fill;
            stockInButtonsPanel.Location = new Point(0, 0);
            stockInButtonsPanel.Name = "stockInButtonsPanel";
            stockInButtonsPanel.Size = new Size(332, 110);
            stockInButtonsPanel.TabIndex = 29;
            // 
            // btnClearStockInItems
            // 
            btnClearStockInItems.Anchor = AnchorStyles.Right;
            btnClearStockInItems.BackColor = Color.Firebrick;
            btnClearStockInItems.FlatStyle = FlatStyle.Flat;
            btnClearStockInItems.Font = new Font("Calibri", 15F);
            btnClearStockInItems.ForeColor = SystemColors.Control;
            btnClearStockInItems.Location = new Point(15, 33);
            btnClearStockInItems.Name = "btnClearStockInItems";
            btnClearStockInItems.Size = new Size(133, 49);
            btnClearStockInItems.TabIndex = 28;
            btnClearStockInItems.Text = "CLEAR";
            btnClearStockInItems.UseVisualStyleBackColor = false;
            btnClearStockInItems.Click += btnClearStockInItems_Click;
            // 
            // btnSaveAllStockInItems
            // 
            btnSaveAllStockInItems.Anchor = AnchorStyles.Right;
            btnSaveAllStockInItems.BackColor = Color.MediumSeaGreen;
            btnSaveAllStockInItems.FlatStyle = FlatStyle.Flat;
            btnSaveAllStockInItems.Font = new Font("Calibri", 15F);
            btnSaveAllStockInItems.ForeColor = SystemColors.ButtonHighlight;
            btnSaveAllStockInItems.Location = new Point(173, 33);
            btnSaveAllStockInItems.Name = "btnSaveAllStockInItems";
            btnSaveAllStockInItems.Size = new Size(133, 49);
            btnSaveAllStockInItems.TabIndex = 28;
            btnSaveAllStockInItems.Text = "SAVE ALL";
            btnSaveAllStockInItems.UseVisualStyleBackColor = false;
            btnSaveAllStockInItems.Click += btnSaveAllStockInItems_Click;
            // 
            // dataGridViewBatchItems
            // 
            dataGridViewBatchItems.AllowUserToAddRows = false;
            dataGridViewBatchItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewBatchItems.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewBatchItems.BorderStyle = BorderStyle.None;
            dataGridViewBatchItems.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Calibri", 15F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewBatchItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewBatchItems.ColumnHeadersHeight = 40;
            dataGridViewBatchItems.Columns.AddRange(new DataGridViewColumn[] { Column2, dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, Column1, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridViewBatchItems.Dock = DockStyle.Fill;
            dataGridViewBatchItems.EnableHeadersVisualStyles = false;
            dataGridViewBatchItems.GridColor = SystemColors.ScrollBar;
            dataGridViewBatchItems.Location = new Point(0, 0);
            dataGridViewBatchItems.Name = "dataGridViewBatchItems";
            dataGridViewBatchItems.ReadOnly = true;
            dataGridViewBatchItems.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Calibri", 30F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewBatchItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewBatchItems.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new Font("Calibri", 15F);
            dataGridViewBatchItems.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewBatchItems.RowTemplate.Height = 33;
            dataGridViewBatchItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBatchItems.Size = new Size(1242, 856);
            dataGridViewBatchItems.TabIndex = 4;
            dataGridViewBatchItems.CellClick += selectedItemCode;
            // 
            // Column2
            // 
            Column2.HeaderText = "Item ID";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Item Code";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Quantity";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "Unit";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Reason";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Date";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(525, 860);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(stockOutPanel);
            panel4.Controls.Add(stockInPanel);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 94);
            panel4.Name = "panel4";
            panel4.Size = new Size(523, 764);
            panel4.TabIndex = 1;
            // 
            // stockInPanel
            // 
            stockInPanel.BackColor = SystemColors.Control;
            stockInPanel.BorderStyle = BorderStyle.FixedSingle;
            stockInPanel.Controls.Add(stockInItemIdInput);
            stockInPanel.Controls.Add(label14);
            stockInPanel.Controls.Add(stockInUnitCmb);
            stockInPanel.Controls.Add(label12);
            stockInPanel.Controls.Add(stockInSaveButton);
            stockInPanel.Controls.Add(stockInClear);
            stockInPanel.Controls.Add(stockInDateInput);
            stockInPanel.Controls.Add(stockInReasonInput);
            stockInPanel.Controls.Add(label6);
            stockInPanel.Controls.Add(label5);
            stockInPanel.Controls.Add(stockInProductQuantity);
            stockInPanel.Controls.Add(label4);
            stockInPanel.Controls.Add(stockInProductCodeInput);
            stockInPanel.Controls.Add(label3);
            stockInPanel.Controls.Add(label2);
            stockInPanel.Dock = DockStyle.Fill;
            stockInPanel.Location = new Point(0, 0);
            stockInPanel.Name = "stockInPanel";
            stockInPanel.Size = new Size(523, 764);
            stockInPanel.TabIndex = 1;
            // 
            // stockInItemIdInput
            // 
            stockInItemIdInput.Font = new Font("Calibri", 18F);
            stockInItemIdInput.Location = new Point(32, 139);
            stockInItemIdInput.Name = "stockInItemIdInput";
            stockInItemIdInput.Size = new Size(446, 37);
            stockInItemIdInput.TabIndex = 16;
            stockInItemIdInput.TextChanged += stockInItemIdInput_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Calibri", 18F);
            label14.Location = new Point(29, 104);
            label14.Name = "label14";
            label14.Size = new Size(84, 29);
            label14.TabIndex = 15;
            label14.Text = "Item ID";
            // 
            // stockInUnitCmb
            // 
            stockInUnitCmb.Font = new Font("Calibri", 18F);
            stockInUnitCmb.FormattingEnabled = true;
            stockInUnitCmb.Items.AddRange(new object[] { "Purchase of Materials", "Stock Adjustments", "Return" });
            stockInUnitCmb.Location = new Point(32, 309);
            stockInUnitCmb.Name = "stockInUnitCmb";
            stockInUnitCmb.Size = new Size(446, 37);
            stockInUnitCmb.TabIndex = 14;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Calibri", 18F);
            label12.Location = new Point(29, 274);
            label12.Name = "label12";
            label12.Size = new Size(55, 29);
            label12.TabIndex = 13;
            label12.Text = "Unit";
            // 
            // stockInSaveButton
            // 
            stockInSaveButton.BackColor = Color.MediumSeaGreen;
            stockInSaveButton.FlatStyle = FlatStyle.Flat;
            stockInSaveButton.Font = new Font("Calibri", 16F);
            stockInSaveButton.ForeColor = SystemColors.ButtonHighlight;
            stockInSaveButton.Location = new Point(317, 677);
            stockInSaveButton.Name = "stockInSaveButton";
            stockInSaveButton.Size = new Size(161, 53);
            stockInSaveButton.TabIndex = 12;
            stockInSaveButton.Text = "STOCK IN";
            stockInSaveButton.UseVisualStyleBackColor = false;
            stockInSaveButton.Click += stockInSaveButton_Click;
            // 
            // stockInClear
            // 
            stockInClear.BackColor = Color.Firebrick;
            stockInClear.FlatStyle = FlatStyle.Flat;
            stockInClear.Font = new Font("Calibri", 16F);
            stockInClear.ForeColor = SystemColors.ButtonHighlight;
            stockInClear.Location = new Point(138, 677);
            stockInClear.Name = "stockInClear";
            stockInClear.Size = new Size(161, 53);
            stockInClear.TabIndex = 11;
            stockInClear.Text = "CLEAR";
            stockInClear.UseVisualStyleBackColor = false;
            stockInClear.Click += stockInClear_Click;
            // 
            // stockInDateInput
            // 
            stockInDateInput.Font = new Font("Calibri", 18F);
            stockInDateInput.Location = new Point(32, 603);
            stockInDateInput.Name = "stockInDateInput";
            stockInDateInput.Size = new Size(446, 37);
            stockInDateInput.TabIndex = 10;
            // 
            // stockInReasonInput
            // 
            stockInReasonInput.Font = new Font("Calibri", 18F);
            stockInReasonInput.FormattingEnabled = true;
            stockInReasonInput.Items.AddRange(new object[] { "Purchase of Materials", "Stock Adjustments", "Return" });
            stockInReasonInput.Location = new Point(32, 502);
            stockInReasonInput.Name = "stockInReasonInput";
            stockInReasonInput.Size = new Size(446, 37);
            stockInReasonInput.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 18F);
            label6.Location = new Point(29, 568);
            label6.Name = "label6";
            label6.Size = new Size(60, 29);
            label6.TabIndex = 7;
            label6.Text = "Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 18F);
            label5.Location = new Point(29, 467);
            label5.Name = "label5";
            label5.Size = new Size(85, 29);
            label5.TabIndex = 5;
            label5.Text = "Reason";
            // 
            // stockInProductQuantity
            // 
            stockInProductQuantity.Font = new Font("Calibri", 18F);
            stockInProductQuantity.Location = new Point(32, 407);
            stockInProductQuantity.Name = "stockInProductQuantity";
            stockInProductQuantity.Size = new Size(446, 37);
            stockInProductQuantity.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 18F);
            label4.Location = new Point(29, 372);
            label4.Name = "label4";
            label4.Size = new Size(99, 29);
            label4.TabIndex = 3;
            label4.Text = "Quantity";
            // 
            // stockInProductCodeInput
            // 
            stockInProductCodeInput.Font = new Font("Calibri", 18F);
            stockInProductCodeInput.Location = new Point(32, 223);
            stockInProductCodeInput.Name = "stockInProductCodeInput";
            stockInProductCodeInput.Size = new Size(446, 37);
            stockInProductCodeInput.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 18F);
            label3.Location = new Point(29, 188);
            label3.Name = "label3";
            label3.Size = new Size(114, 29);
            label3.TabIndex = 1;
            label3.Text = "Item Code";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 27.75F, FontStyle.Bold);
            label2.Location = new Point(22, 12);
            label2.Name = "label2";
            label2.Size = new Size(141, 45);
            label2.TabIndex = 0;
            label2.Text = "Stock In";
            // 
            // stockOutPanel
            // 
            stockOutPanel.AutoScroll = true;
            stockOutPanel.Controls.Add(stockOutItemIdInput);
            stockOutPanel.Controls.Add(label15);
            stockOutPanel.Controls.Add(stockOutUnitCmb);
            stockOutPanel.Controls.Add(label13);
            stockOutPanel.Controls.Add(stockOutSaveButton);
            stockOutPanel.Controls.Add(stockOutClear);
            stockOutPanel.Controls.Add(stockOutDateInput);
            stockOutPanel.Controls.Add(stockOutReasonInput);
            stockOutPanel.Controls.Add(label7);
            stockOutPanel.Controls.Add(label8);
            stockOutPanel.Controls.Add(stockOutProductQuantity);
            stockOutPanel.Controls.Add(label9);
            stockOutPanel.Controls.Add(stockOutProductCodeInput);
            stockOutPanel.Controls.Add(label10);
            stockOutPanel.Controls.Add(label11);
            stockOutPanel.Dock = DockStyle.Fill;
            stockOutPanel.Location = new Point(0, 0);
            stockOutPanel.Name = "stockOutPanel";
            stockOutPanel.Size = new Size(523, 764);
            stockOutPanel.TabIndex = 2;
            stockOutPanel.Visible = false;
            // 
            // stockOutItemIdInput
            // 
            stockOutItemIdInput.Font = new Font("Calibri", 18F);
            stockOutItemIdInput.Location = new Point(33, 127);
            stockOutItemIdInput.Name = "stockOutItemIdInput";
            stockOutItemIdInput.Size = new Size(446, 37);
            stockOutItemIdInput.TabIndex = 27;
            stockOutItemIdInput.TextChanged += stockOutItemIdInput_TextChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Calibri", 18F);
            label15.Location = new Point(30, 92);
            label15.Name = "label15";
            label15.Size = new Size(84, 29);
            label15.TabIndex = 26;
            label15.Text = "Item ID";
            // 
            // stockOutUnitCmb
            // 
            stockOutUnitCmb.Font = new Font("Calibri", 18F);
            stockOutUnitCmb.FormattingEnabled = true;
            stockOutUnitCmb.Items.AddRange(new object[] { "Purchase of Materials", "Stock Adjustments", "Return" });
            stockOutUnitCmb.Location = new Point(30, 307);
            stockOutUnitCmb.Name = "stockOutUnitCmb";
            stockOutUnitCmb.Size = new Size(446, 37);
            stockOutUnitCmb.TabIndex = 25;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Calibri", 18F);
            label13.Location = new Point(30, 272);
            label13.Name = "label13";
            label13.Size = new Size(55, 29);
            label13.TabIndex = 24;
            label13.Text = "Unit";
            // 
            // stockOutSaveButton
            // 
            stockOutSaveButton.BackColor = Color.MediumSeaGreen;
            stockOutSaveButton.FlatStyle = FlatStyle.Flat;
            stockOutSaveButton.Font = new Font("Calibri", 16F);
            stockOutSaveButton.ForeColor = SystemColors.ButtonHighlight;
            stockOutSaveButton.Location = new Point(318, 675);
            stockOutSaveButton.Name = "stockOutSaveButton";
            stockOutSaveButton.Size = new Size(161, 53);
            stockOutSaveButton.TabIndex = 23;
            stockOutSaveButton.Text = "STOCK OUT";
            stockOutSaveButton.UseVisualStyleBackColor = false;
            stockOutSaveButton.Click += stockOutSaveButton_Click;
            // 
            // stockOutClear
            // 
            stockOutClear.BackColor = Color.Firebrick;
            stockOutClear.FlatStyle = FlatStyle.Flat;
            stockOutClear.Font = new Font("Calibri", 16F);
            stockOutClear.ForeColor = SystemColors.ButtonHighlight;
            stockOutClear.Location = new Point(130, 675);
            stockOutClear.Name = "stockOutClear";
            stockOutClear.Size = new Size(161, 53);
            stockOutClear.TabIndex = 22;
            stockOutClear.Text = "CLEAR";
            stockOutClear.UseVisualStyleBackColor = false;
            stockOutClear.Click += stockOutClear_Click;
            // 
            // stockOutDateInput
            // 
            stockOutDateInput.Font = new Font("Calibri", 18F);
            stockOutDateInput.Location = new Point(33, 601);
            stockOutDateInput.Name = "stockOutDateInput";
            stockOutDateInput.Size = new Size(446, 37);
            stockOutDateInput.TabIndex = 21;
            // 
            // stockOutReasonInput
            // 
            stockOutReasonInput.Font = new Font("Calibri", 18F);
            stockOutReasonInput.FormattingEnabled = true;
            stockOutReasonInput.Items.AddRange(new object[] { "Sold", "Damaged" });
            stockOutReasonInput.Location = new Point(33, 500);
            stockOutReasonInput.Name = "stockOutReasonInput";
            stockOutReasonInput.Size = new Size(446, 37);
            stockOutReasonInput.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 18F);
            label7.Location = new Point(30, 566);
            label7.Name = "label7";
            label7.Size = new Size(60, 29);
            label7.TabIndex = 19;
            label7.Text = "Date";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 18F);
            label8.Location = new Point(30, 465);
            label8.Name = "label8";
            label8.Size = new Size(85, 29);
            label8.TabIndex = 18;
            label8.Text = "Reason";
            // 
            // stockOutProductQuantity
            // 
            stockOutProductQuantity.Font = new Font("Calibri", 18F);
            stockOutProductQuantity.Location = new Point(30, 405);
            stockOutProductQuantity.Name = "stockOutProductQuantity";
            stockOutProductQuantity.Size = new Size(446, 37);
            stockOutProductQuantity.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 18F);
            label9.Location = new Point(30, 370);
            label9.Name = "label9";
            label9.Size = new Size(99, 29);
            label9.TabIndex = 16;
            label9.Text = "Quantity";
            // 
            // stockOutProductCodeInput
            // 
            stockOutProductCodeInput.Font = new Font("Calibri", 18F);
            stockOutProductCodeInput.Location = new Point(30, 221);
            stockOutProductCodeInput.Name = "stockOutProductCodeInput";
            stockOutProductCodeInput.Size = new Size(446, 37);
            stockOutProductCodeInput.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Calibri", 18F);
            label10.Location = new Point(30, 186);
            label10.Name = "label10";
            label10.Size = new Size(114, 29);
            label10.TabIndex = 14;
            label10.Text = "Item Code";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Calibri", 27.75F, FontStyle.Bold);
            label11.Location = new Point(23, 13);
            label11.Name = "label11";
            label11.Size = new Size(169, 45);
            label11.TabIndex = 13;
            label11.Text = "Stock Out";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(stockOutButton);
            panel2.Controls.Add(stockInButton);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(523, 94);
            panel2.TabIndex = 0;
            // 
            // stockOutButton
            // 
            stockOutButton.Font = new Font("Calibri", 16F);
            stockOutButton.Location = new Point(181, 24);
            stockOutButton.Name = "stockOutButton";
            stockOutButton.Size = new Size(135, 50);
            stockOutButton.TabIndex = 1;
            stockOutButton.Text = "Stock Out";
            stockOutButton.UseVisualStyleBackColor = true;
            stockOutButton.Click += stockOutButton_Click;
            // 
            // stockInButton
            // 
            stockInButton.Font = new Font("Calibri", 16F);
            stockInButton.Location = new Point(22, 24);
            stockInButton.Name = "stockInButton";
            stockInButton.Size = new Size(135, 50);
            stockInButton.TabIndex = 0;
            stockInButton.Text = "Stock In";
            stockInButton.UseVisualStyleBackColor = true;
            stockInButton.Click += stockInButton_Click;
            // 
            // StockInOutModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1771, 959);
            Controls.Add(bodyStockInOutPanel);
            Controls.Add(topbarStockInOutPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "StockInOutModal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory - Stock In/Out";
            Load += StockInOutModal_Load;
            topbarStockInOutPanel.ResumeLayout(false);
            topbarStockInOutPanel.PerformLayout();
            bodyStockInOutPanel.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel14.ResumeLayout(false);
            panel13.ResumeLayout(false);
            panel17.ResumeLayout(false);
            panel16.ResumeLayout(false);
            stockOutButtonsPanel.ResumeLayout(false);
            stockInButtonsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewBatchItems).EndInit();
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            stockInPanel.ResumeLayout(false);
            stockInPanel.PerformLayout();
            stockOutPanel.ResumeLayout(false);
            stockOutPanel.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel topbarStockInOutPanel;
        private Label label1;
        private Panel bodyStockInOutPanel;
        private Panel panel1;
        private Panel panel2;
        private Button stockOutButton;
        private Button stockInButton;
        private Panel panel3;
        private Panel stockInPanel;
        private Panel stockOutPanel;
        private Label label2;
        private TextBox stockInProductCodeInput;
        private Label label3;
        private DateTimePicker stockInDateInput;
        private ComboBox stockInReasonInput;
        private Label label6;
        private Label label5;
        private TextBox stockInProductQuantity;
        private Label label4;
        private Button stockInSaveButton;
        private Button stockInClear;
        private Button stockOutSaveButton;
        private Button stockOutClear;
        private DateTimePicker stockOutDateInput;
        private ComboBox stockOutReasonInput;
        private Label label7;
        private Label label8;
        private TextBox stockOutProductQuantity;
        private Label label9;
        private TextBox stockOutProductCodeInput;
        private Label label10;
        private Label label11;
        private Panel panel14;
        private Panel panel13;
        private Panel panel16;
        private Panel stockInButtonsPanel;
        private Button btnClearStockInItems;
        private Button btnSaveAllStockInItems;
        private Panel stockOutButtonsPanel;
        private Button btnClearStockOutItems;
        private Button btnSaveAllStockOutItems;
        private DataGridView dataGridViewBatchItems;
        private Panel panel17;
        private Button btnRemoveBatchItem;
        private Button btnRemoveItem;
        private Panel panel4;
        private ComboBox stockInUnitCmb;
        private Label label12;
        private ComboBox stockOutUnitCmb;
        private Label label13;
        private TextBox stockInItemIdInput;
        private Label label14;
        private TextBox stockOutItemIdInput;
        private Label label15;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}