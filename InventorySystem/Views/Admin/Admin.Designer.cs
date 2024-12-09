using System.Windows.Forms.DataVisualization.Charting;

namespace InventorySystem.Views.Admin
{
    partial class Admin
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
            ChartArea chartArea1 = new ChartArea();
            Series series1 = new Series();
            Title title1 = new Title();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            ChartArea chartArea2 = new ChartArea();
            Legend legend1 = new Legend();
            Series series2 = new Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            sidebar = new Panel();
            panel3 = new Panel();
            employeeBtn = new Button();
            logoutBtn = new Button();
            transactionsBtn = new Button();
            inventoryBtn = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            adminPanels = new Panel();
            panel11 = new Panel();
            panel8 = new Panel();
            panel14 = new Panel();
            panel16 = new Panel();
            bestSellerGrid = new DataGridView();
            Column6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            panel15 = new Panel();
            label3 = new Label();
            periodCmb = new ComboBox();
            panel10 = new Panel();
            panel18 = new Panel();
            chartInventory = new Chart();
            panel17 = new Panel();
            inventoryRestockingCmb = new ComboBox();
            panel7 = new Panel();
            panel4 = new Panel();
            panel13 = new Panel();
            recentTransactionsGrid = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            panel12 = new Panel();
            label1 = new Label();
            linkTransaction = new LinkLabel();
            panel1 = new Panel();
            panel6 = new Panel();
            pieChartInventory = new Chart();
            panel5 = new Panel();
            label2 = new Label();
            panel9 = new Panel();
            refreshButton = new Button();
            settingsBtn = new Button();
            sidebar.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            adminPanels.SuspendLayout();
            panel11.SuspendLayout();
            panel8.SuspendLayout();
            panel14.SuspendLayout();
            panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bestSellerGrid).BeginInit();
            panel15.SuspendLayout();
            panel10.SuspendLayout();
            panel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartInventory).BeginInit();
            panel17.SuspendLayout();
            panel7.SuspendLayout();
            panel4.SuspendLayout();
            panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)recentTransactionsGrid).BeginInit();
            panel12.SuspendLayout();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pieChartInventory).BeginInit();
            panel5.SuspendLayout();
            panel9.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.LightSlateGray;
            sidebar.BackgroundImage = Properties.Resources.navigationBackground;
            sidebar.BackgroundImageLayout = ImageLayout.Stretch;
            sidebar.Controls.Add(panel3);
            sidebar.Controls.Add(panel2);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(304, 881);
            sidebar.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(settingsBtn);
            panel3.Controls.Add(employeeBtn);
            panel3.Controls.Add(logoutBtn);
            panel3.Controls.Add(transactionsBtn);
            panel3.Controls.Add(inventoryBtn);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 239);
            panel3.Name = "panel3";
            panel3.Size = new Size(304, 642);
            panel3.TabIndex = 2;
            // 
            // employeeBtn
            // 
            employeeBtn.Cursor = Cursors.Hand;
            employeeBtn.Dock = DockStyle.Top;
            employeeBtn.FlatAppearance.BorderSize = 0;
            employeeBtn.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            employeeBtn.FlatStyle = FlatStyle.Flat;
            employeeBtn.Font = new Font("MS UI Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            employeeBtn.ForeColor = SystemColors.ButtonHighlight;
            employeeBtn.Image = Properties.Resources.employeeIcon__2_;
            employeeBtn.ImageAlign = ContentAlignment.MiddleLeft;
            employeeBtn.Location = new Point(0, 166);
            employeeBtn.Name = "employeeBtn";
            employeeBtn.Padding = new Padding(5);
            employeeBtn.Size = new Size(304, 83);
            employeeBtn.TabIndex = 4;
            employeeBtn.Text = "Employee";
            employeeBtn.TextAlign = ContentAlignment.MiddleRight;
            employeeBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            employeeBtn.UseVisualStyleBackColor = true;
            employeeBtn.Click += employeeBtn_Click;
            // 
            // logoutBtn
            // 
            logoutBtn.Cursor = Cursors.Hand;
            logoutBtn.Dock = DockStyle.Bottom;
            logoutBtn.FlatAppearance.BorderSize = 0;
            logoutBtn.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            logoutBtn.FlatStyle = FlatStyle.Flat;
            logoutBtn.Font = new Font("MS UI Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logoutBtn.ForeColor = SystemColors.ButtonHighlight;
            logoutBtn.Image = Properties.Resources.logoutIcon__2_;
            logoutBtn.ImageAlign = ContentAlignment.MiddleLeft;
            logoutBtn.Location = new Point(0, 559);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Padding = new Padding(5);
            logoutBtn.Size = new Size(304, 83);
            logoutBtn.TabIndex = 3;
            logoutBtn.Text = "Logout";
            logoutBtn.TextAlign = ContentAlignment.MiddleRight;
            logoutBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            logoutBtn.UseVisualStyleBackColor = true;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // transactionsBtn
            // 
            transactionsBtn.Cursor = Cursors.Hand;
            transactionsBtn.Dock = DockStyle.Top;
            transactionsBtn.FlatAppearance.BorderSize = 0;
            transactionsBtn.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            transactionsBtn.FlatStyle = FlatStyle.Flat;
            transactionsBtn.Font = new Font("MS UI Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            transactionsBtn.ForeColor = SystemColors.ButtonHighlight;
            transactionsBtn.Image = Properties.Resources.stockInOutTransaction;
            transactionsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            transactionsBtn.Location = new Point(0, 83);
            transactionsBtn.Name = "transactionsBtn";
            transactionsBtn.Padding = new Padding(5);
            transactionsBtn.Size = new Size(304, 83);
            transactionsBtn.TabIndex = 2;
            transactionsBtn.Text = "Transactions";
            transactionsBtn.TextAlign = ContentAlignment.MiddleRight;
            transactionsBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            transactionsBtn.UseVisualStyleBackColor = true;
            transactionsBtn.Click += transactionsBtn_Click;
            // 
            // inventoryBtn
            // 
            inventoryBtn.Cursor = Cursors.Hand;
            inventoryBtn.Dock = DockStyle.Top;
            inventoryBtn.FlatAppearance.BorderSize = 0;
            inventoryBtn.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            inventoryBtn.FlatStyle = FlatStyle.Flat;
            inventoryBtn.Font = new Font("MS UI Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inventoryBtn.ForeColor = SystemColors.ButtonHighlight;
            inventoryBtn.Image = Properties.Resources.inventoryMonitoringIcon;
            inventoryBtn.ImageAlign = ContentAlignment.MiddleLeft;
            inventoryBtn.Location = new Point(0, 0);
            inventoryBtn.Name = "inventoryBtn";
            inventoryBtn.Padding = new Padding(5);
            inventoryBtn.Size = new Size(304, 83);
            inventoryBtn.TabIndex = 1;
            inventoryBtn.Text = "Inventory";
            inventoryBtn.TextAlign = ContentAlignment.MiddleRight;
            inventoryBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            inventoryBtn.UseVisualStyleBackColor = true;
            inventoryBtn.Click += inventoryBtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(304, 239);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.company_logo;
            pictureBox1.Location = new Point(33, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(237, 189);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // adminPanels
            // 
            adminPanels.Controls.Add(panel11);
            adminPanels.Controls.Add(panel9);
            adminPanels.Dock = DockStyle.Fill;
            adminPanels.Location = new Point(304, 0);
            adminPanels.Name = "adminPanels";
            adminPanels.Size = new Size(1300, 881);
            adminPanels.TabIndex = 1;
            // 
            // panel11
            // 
            panel11.BorderStyle = BorderStyle.FixedSingle;
            panel11.Controls.Add(panel8);
            panel11.Controls.Add(panel7);
            panel11.Dock = DockStyle.Fill;
            panel11.Location = new Point(0, 71);
            panel11.Name = "panel11";
            panel11.Size = new Size(1300, 810);
            panel11.TabIndex = 8;
            // 
            // panel8
            // 
            panel8.Controls.Add(panel14);
            panel8.Controls.Add(panel10);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(676, 808);
            panel8.TabIndex = 7;
            // 
            // panel14
            // 
            panel14.Controls.Add(panel16);
            panel14.Controls.Add(panel15);
            panel14.Dock = DockStyle.Fill;
            panel14.Location = new Point(0, 413);
            panel14.Name = "panel14";
            panel14.Size = new Size(676, 395);
            panel14.TabIndex = 9;
            // 
            // panel16
            // 
            panel16.Controls.Add(bestSellerGrid);
            panel16.Dock = DockStyle.Fill;
            panel16.Location = new Point(0, 61);
            panel16.Name = "panel16";
            panel16.Padding = new Padding(15, 5, 15, 5);
            panel16.Size = new Size(676, 334);
            panel16.TabIndex = 9;
            // 
            // bestSellerGrid
            // 
            bestSellerGrid.AllowUserToAddRows = false;
            bestSellerGrid.BackgroundColor = SystemColors.ButtonHighlight;
            bestSellerGrid.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 16F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            bestSellerGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            bestSellerGrid.ColumnHeadersHeight = 45;
            bestSellerGrid.Columns.AddRange(new DataGridViewColumn[] { Column6, dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, Column4, Column5 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 16F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            bestSellerGrid.DefaultCellStyle = dataGridViewCellStyle2;
            bestSellerGrid.Dock = DockStyle.Fill;
            bestSellerGrid.EnableHeadersVisualStyles = false;
            bestSellerGrid.Location = new Point(15, 5);
            bestSellerGrid.Name = "bestSellerGrid";
            bestSellerGrid.ReadOnly = true;
            bestSellerGrid.RowHeadersVisible = false;
            bestSellerGrid.RowTemplate.Height = 60;
            bestSellerGrid.RowTemplate.Resizable = DataGridViewTriState.True;
            bestSellerGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            bestSellerGrid.Size = new Size(646, 324);
            bestSellerGrid.TabIndex = 6;
            // 
            // Column6
            // 
            Column6.HeaderText = "Rank";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Item Code";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Name";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 250;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Category";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 200;
            // 
            // Column4
            // 
            Column4.HeaderText = "Supplier";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 200;
            // 
            // Column5
            // 
            Column5.HeaderText = "Unit";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 150;
            // 
            // panel15
            // 
            panel15.Controls.Add(label3);
            panel15.Controls.Add(periodCmb);
            panel15.Dock = DockStyle.Top;
            panel15.Location = new Point(0, 0);
            panel15.Name = "panel15";
            panel15.Size = new Size(676, 61);
            panel15.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 12);
            label3.Name = "label3";
            label3.Size = new Size(143, 37);
            label3.TabIndex = 5;
            label3.Text = "Best Seller";
            // 
            // periodCmb
            // 
            periodCmb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            periodCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            periodCmb.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            periodCmb.FormattingEnabled = true;
            periodCmb.Items.AddRange(new object[] { "Weekly", "Monthly", "Yearly" });
            periodCmb.Location = new Point(393, 12);
            periodCmb.Name = "periodCmb";
            periodCmb.Size = new Size(268, 38);
            periodCmb.TabIndex = 7;
            periodCmb.SelectedIndexChanged += periodCmb_SelectedIndexChanged;
            // 
            // panel10
            // 
            panel10.Controls.Add(panel18);
            panel10.Controls.Add(panel17);
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(0, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(676, 413);
            panel10.TabIndex = 8;
            // 
            // panel18
            // 
            panel18.Controls.Add(chartInventory);
            panel18.Dock = DockStyle.Fill;
            panel18.Location = new Point(0, 57);
            panel18.Name = "panel18";
            panel18.Padding = new Padding(15, 5, 15, 5);
            panel18.Size = new Size(676, 356);
            panel18.TabIndex = 4;
            // 
            // chartInventory
            // 
            chartInventory.BackColor = Color.Transparent;
            chartArea1.AxisX.MajorGrid.LineColor = Color.LightGray;
            chartArea1.AxisY.MajorGrid.LineColor = Color.LightGray;
            chartArea1.AxisY.Title = "Re-stock Values";
            chartArea1.Name = "ChartArea1";
            chartInventory.ChartAreas.Add(chartArea1);
            chartInventory.Dock = DockStyle.Fill;
            chartInventory.Location = new Point(15, 5);
            chartInventory.Name = "chartInventory";
            series1.BackGradientStyle = GradientStyle.TopBottom;
            series1.BorderWidth = 4;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = SeriesChartType.Area;
            series1.Color = Color.Blue;
            series1.IsVisibleInLegend = false;
            series1.IsXValueIndexed = true;
            series1.MarkerSize = 10;
            series1.MarkerStyle = MarkerStyle.Circle;
            series1.Name = "Inventory Restocking";
            series1.ShadowColor = Color.FromArgb(64, 64, 64);
            chartInventory.Series.Add(series1);
            chartInventory.Size = new Size(646, 346);
            chartInventory.TabIndex = 1;
            chartInventory.Text = "chart1";
            title1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title1.Name = "Title1";
            title1.Text = "Inventory Re-stocking";
            chartInventory.Titles.Add(title1);
            // 
            // panel17
            // 
            panel17.Controls.Add(inventoryRestockingCmb);
            panel17.Dock = DockStyle.Top;
            panel17.Location = new Point(0, 0);
            panel17.Name = "panel17";
            panel17.Size = new Size(676, 57);
            panel17.TabIndex = 3;
            // 
            // inventoryRestockingCmb
            // 
            inventoryRestockingCmb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            inventoryRestockingCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            inventoryRestockingCmb.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inventoryRestockingCmb.FormattingEnabled = true;
            inventoryRestockingCmb.Items.AddRange(new object[] { "Daily", "Weekly", "Monthly" });
            inventoryRestockingCmb.Location = new Point(392, 12);
            inventoryRestockingCmb.Name = "inventoryRestockingCmb";
            inventoryRestockingCmb.Size = new Size(268, 38);
            inventoryRestockingCmb.TabIndex = 2;
            inventoryRestockingCmb.SelectedIndexChanged += inventoryRestockingCmb_SelectedIndexChanged;
            // 
            // panel7
            // 
            panel7.Controls.Add(panel4);
            panel7.Controls.Add(panel1);
            panel7.Dock = DockStyle.Right;
            panel7.Location = new Point(676, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(622, 808);
            panel7.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel13);
            panel4.Controls.Add(panel12);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 383);
            panel4.Name = "panel4";
            panel4.Size = new Size(622, 425);
            panel4.TabIndex = 7;
            // 
            // panel13
            // 
            panel13.Controls.Add(recentTransactionsGrid);
            panel13.Dock = DockStyle.Fill;
            panel13.Location = new Point(0, 64);
            panel13.Name = "panel13";
            panel13.Padding = new Padding(15, 5, 15, 5);
            panel13.Size = new Size(622, 361);
            panel13.TabIndex = 7;
            // 
            // recentTransactionsGrid
            // 
            recentTransactionsGrid.AllowUserToAddRows = false;
            recentTransactionsGrid.BackgroundColor = SystemColors.Control;
            recentTransactionsGrid.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ControlLight;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 16F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ControlLight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            recentTransactionsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            recentTransactionsGrid.ColumnHeadersHeight = 45;
            recentTransactionsGrid.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 16F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            recentTransactionsGrid.DefaultCellStyle = dataGridViewCellStyle4;
            recentTransactionsGrid.Dock = DockStyle.Fill;
            recentTransactionsGrid.EnableHeadersVisualStyles = false;
            recentTransactionsGrid.Location = new Point(15, 5);
            recentTransactionsGrid.Name = "recentTransactionsGrid";
            recentTransactionsGrid.RowHeadersVisible = false;
            recentTransactionsGrid.RowTemplate.Height = 60;
            recentTransactionsGrid.RowTemplate.Resizable = DataGridViewTriState.True;
            recentTransactionsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            recentTransactionsGrid.Size = new Size(592, 351);
            recentTransactionsGrid.TabIndex = 4;
            // 
            // Column1
            // 
            Column1.HeaderText = "Batch ID";
            Column1.Name = "Column1";
            Column1.Width = 300;
            // 
            // Column2
            // 
            Column2.HeaderText = "Date";
            Column2.Name = "Column2";
            Column2.Width = 250;
            // 
            // Column3
            // 
            Column3.HeaderText = "Type";
            Column3.Name = "Column3";
            Column3.Width = 120;
            // 
            // panel12
            // 
            panel12.Controls.Add(label1);
            panel12.Controls.Add(linkTransaction);
            panel12.Dock = DockStyle.Top;
            panel12.Location = new Point(0, 0);
            panel12.Name = "panel12";
            panel12.Size = new Size(622, 64);
            panel12.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 18);
            label1.Name = "label1";
            label1.Size = new Size(248, 37);
            label1.TabIndex = 3;
            label1.Text = "Recent Transaction";
            // 
            // linkTransaction
            // 
            linkTransaction.AutoSize = true;
            linkTransaction.Font = new Font("Segoe UI", 18F);
            linkTransaction.Location = new Point(479, 23);
            linkTransaction.Name = "linkTransaction";
            linkTransaction.Size = new Size(128, 32);
            linkTransaction.TabIndex = 5;
            linkTransaction.TabStop = true;
            linkTransaction.Text = "View more";
            linkTransaction.LinkClicked += linkTransaction_LinkClicked;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(622, 383);
            panel1.TabIndex = 6;
            // 
            // panel6
            // 
            panel6.Controls.Add(pieChartInventory);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 57);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(15, 5, 15, 5);
            panel6.Size = new Size(622, 326);
            panel6.TabIndex = 6;
            // 
            // pieChartInventory
            // 
            pieChartInventory.BackColor = SystemColors.ButtonHighlight;
            pieChartInventory.BorderlineColor = SystemColors.WindowFrame;
            chartArea2.Name = "ChartArea1";
            pieChartInventory.ChartAreas.Add(chartArea2);
            pieChartInventory.Dock = DockStyle.Fill;
            legend1.Alignment = StringAlignment.Center;
            legend1.Docking = Docking.Bottom;
            legend1.LegendStyle = LegendStyle.Row;
            legend1.Name = "Legend1";
            pieChartInventory.Legends.Add(legend1);
            pieChartInventory.Location = new Point(15, 5);
            pieChartInventory.Name = "pieChartInventory";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = SeriesChartType.Pie;
            series2.IsValueShownAsLabel = true;
            series2.LabelFormat = "0.00%";
            series2.Legend = "Legend1";
            series2.Name = "pieChart";
            pieChartInventory.Series.Add(series2);
            pieChartInventory.Size = new Size(592, 316);
            pieChartInventory.TabIndex = 2;
            pieChartInventory.Text = "chart1";
            // 
            // panel5
            // 
            panel5.Controls.Add(label2);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(622, 57);
            panel5.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 13);
            label2.Name = "label2";
            label2.Size = new Size(153, 37);
            label2.TabIndex = 4;
            label2.Text = "Stock Level";
            // 
            // panel9
            // 
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Controls.Add(refreshButton);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(1300, 71);
            panel9.TabIndex = 5;
            // 
            // refreshButton
            // 
            refreshButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            refreshButton.Image = Properties.Resources.refresh;
            refreshButton.Location = new Point(16, 10);
            refreshButton.Name = "refreshButton";
            refreshButton.Padding = new Padding(10, 4, 4, 10);
            refreshButton.Size = new Size(136, 52);
            refreshButton.TabIndex = 0;
            refreshButton.Text = "Refresh";
            refreshButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += refreshButton_Click;
            // 
            // settingsBtn
            // 
            settingsBtn.Cursor = Cursors.Hand;
            settingsBtn.Dock = DockStyle.Top;
            settingsBtn.FlatAppearance.BorderSize = 0;
            settingsBtn.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            settingsBtn.FlatStyle = FlatStyle.Flat;
            settingsBtn.Font = new Font("MS UI Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            settingsBtn.ForeColor = SystemColors.ButtonHighlight;
            settingsBtn.Image = Properties.Resources.settings__1_;
            settingsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            settingsBtn.Location = new Point(0, 249);
            settingsBtn.Name = "settingsBtn";
            settingsBtn.Padding = new Padding(5);
            settingsBtn.Size = new Size(304, 83);
            settingsBtn.TabIndex = 5;
            settingsBtn.Text = "Settings";
            settingsBtn.TextAlign = ContentAlignment.MiddleRight;
            settingsBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            settingsBtn.UseVisualStyleBackColor = true;
            settingsBtn.Click += settingsBtn_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1604, 881);
            Controls.Add(adminPanels);
            Controls.Add(sidebar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            WindowState = FormWindowState.Maximized;
            FormClosing += Admin_FormClosing;
            FormClosed += Admin_FormClosed;
            sidebar.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            adminPanels.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel14.ResumeLayout(false);
            panel16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bestSellerGrid).EndInit();
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            panel10.ResumeLayout(false);
            panel18.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartInventory).EndInit();
            panel17.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)recentTransactionsGrid).EndInit();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pieChartInventory).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel9.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel sidebar;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel3;
        private Panel adminPanels;
        private Button inventoryBtn;
        private Button transactionsBtn;
        private Button logoutBtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartInventory;
        private System.Windows.Forms.DataVisualization.Charting.Chart pieChartInventory;
        private Panel panel9;
        private Panel panel7;
        private Panel panel8;
        private Button refreshButton;
        private Panel panel11;
        private Label label1;
        private DataGridView recentTransactionsGrid;
        private Label label2;
        private Label label3;
        private ComboBox inventoryRestockingCmb;
        private LinkLabel linkTransaction;
        private DataGridView bestSellerGrid;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private ComboBox periodCmb;
        private Button employeeBtn;
        private Panel panel4;
        private Panel panel1;
        private Panel panel5;
        private Panel panel6;
        private Panel panel13;
        private Panel panel12;
        private Panel panel14;
        private Panel panel16;
        private Panel panel15;
        private Panel panel10;
        private Panel panel17;
        private Panel panel18;
        private Button settingsBtn;
    }
}