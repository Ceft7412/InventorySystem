namespace InventorySystem.Views.Modals.Admin
{
    partial class TransactionsAdmin
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionsAdmin));
            topbarStockInOutPanel = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            dataGridViewTransactions = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            refreshData = new Button();
            label2 = new Label();
            typeCmb = new ComboBox();
            serachBatchItem = new TextBox();
            topbarStockInOutPanel.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransactions).BeginInit();
            panel3.SuspendLayout();
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
            topbarStockInOutPanel.Size = new Size(1352, 99);
            topbarStockInOutPanel.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 26F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(24, 31);
            label1.Name = "label1";
            label1.Size = new Size(401, 42);
            label1.TabIndex = 0;
            label1.Text = "Transactions - Stock In/Out";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 99);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(30, 20, 30, 20);
            panel1.Size = new Size(1352, 662);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(30, 20);
            panel2.Name = "panel2";
            panel2.Size = new Size(1292, 622);
            panel2.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(dataGridViewTransactions);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 92);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(10, 10, 10, 20);
            panel4.Size = new Size(1292, 530);
            panel4.TabIndex = 2;
            // 
            // dataGridViewTransactions
            // 
            dataGridViewTransactions.AllowUserToAddRows = false;
            dataGridViewTransactions.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewTransactions.BorderStyle = BorderStyle.None;
            dataGridViewTransactions.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Calibri", 16F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewTransactions.ColumnHeadersHeight = 40;
            dataGridViewTransactions.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 16F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewTransactions.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewTransactions.Dock = DockStyle.Fill;
            dataGridViewTransactions.EnableHeadersVisualStyles = false;
            dataGridViewTransactions.GridColor = SystemColors.ScrollBar;
            dataGridViewTransactions.Location = new Point(10, 10);
            dataGridViewTransactions.Name = "dataGridViewTransactions";
            dataGridViewTransactions.ReadOnly = true;
            dataGridViewTransactions.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Calibri", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewTransactions.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewTransactions.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = SystemColors.ButtonHighlight;
            dataGridViewTransactions.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewTransactions.RowTemplate.Height = 30;
            dataGridViewTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTransactions.Size = new Size(1272, 500);
            dataGridViewTransactions.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.HeaderText = "Batch Item ID";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 260;
            // 
            // Column2
            // 
            Column2.HeaderText = "Batch ID";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 280;
            // 
            // Column3
            // 
            Column3.HeaderText = "Item Code";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "Quantity";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 150;
            // 
            // Column5
            // 
            Column5.HeaderText = "Type";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 200;
            // 
            // Column6
            // 
            Column6.HeaderText = "Reason";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 250;
            // 
            // Column7
            // 
            Column7.HeaderText = "Date";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 250;
            // 
            // panel3
            // 
            panel3.Controls.Add(refreshData);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(typeCmb);
            panel3.Controls.Add(serachBatchItem);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(10);
            panel3.Size = new Size(1292, 92);
            panel3.TabIndex = 1;
            // 
            // refreshData
            // 
            refreshData.Font = new Font("Calibri", 16F);
            refreshData.Image = Properties.Resources.refresh__1_;
            refreshData.Location = new Point(1148, 24);
            refreshData.Name = "refreshData";
            refreshData.Size = new Size(131, 47);
            refreshData.TabIndex = 3;
            refreshData.Text = "Refresh";
            refreshData.TextImageRelation = TextImageRelation.ImageBeforeText;
            refreshData.UseVisualStyleBackColor = true;
            refreshData.Click += refreshData_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 16F);
            label2.Location = new Point(469, 34);
            label2.Name = "label2";
            label2.Size = new Size(61, 27);
            label2.TabIndex = 2;
            label2.Text = "Type:";
            // 
            // typeCmb
            // 
            typeCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            typeCmb.Font = new Font("Calibri", 16F);
            typeCmb.FormattingEnabled = true;
            typeCmb.Items.AddRange(new object[] { "IN", "OUT" });
            typeCmb.Location = new Point(540, 34);
            typeCmb.Name = "typeCmb";
            typeCmb.Size = new Size(274, 34);
            typeCmb.TabIndex = 1;
            typeCmb.SelectedIndexChanged += typeCmb_SelectedIndexChanged;
            // 
            // serachBatchItem
            // 
            serachBatchItem.Font = new Font("Calibri", 16F);
            serachBatchItem.Location = new Point(25, 31);
            serachBatchItem.Name = "serachBatchItem";
            serachBatchItem.PlaceholderText = "Search";
            serachBatchItem.Size = new Size(404, 34);
            serachBatchItem.TabIndex = 0;
            serachBatchItem.TextChanged += serachBatchItem_TextChanged;
            // 
            // TransactionsAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1352, 761);
            Controls.Add(panel1);
            Controls.Add(topbarStockInOutPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TransactionsAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin - Transactions";
            Load += TransactionsAdmin_Load;
            topbarStockInOutPanel.ResumeLayout(false);
            topbarStockInOutPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTransactions).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel topbarStockInOutPanel;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private TextBox serachBatchItem;
        private Panel panel3;
        private Panel panel4;
        private DataGridView dataGridViewItems;
        private DataGridView dataGridViewTransactions;
        private Label label2;
        private ComboBox typeCmb;
        private Button refreshData;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}