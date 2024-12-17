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
            ChartArea chartArea1 = new ChartArea();
            Series series1 = new Series();
            Title title1 = new Title();
            ChartArea chartArea2 = new ChartArea();
            Legend legend1 = new Legend();
            Series series2 = new Series();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            sidebar = new Panel();
            panel3 = new Panel();
            settingsBtn = new Button();
            logsBtn = new Button();
            employeeBtn = new Button();
            logoutBtn = new Button();
            transactionsBtn = new Button();
            inventoryBtn = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            adminPanels = new Panel();
            panel11 = new Panel();
            panel8 = new Panel();
            panel24 = new Panel();
            panel10 = new Panel();
            panel18 = new Panel();
            panel19 = new Panel();
            chartInventory = new Chart();
            panel17 = new Panel();
            inventoryRestockingCmb = new ComboBox();
            panel4 = new Panel();
            panel36 = new Panel();
            panel39 = new Panel();
            panel40 = new Panel();
            panel25 = new Panel();
            panel26 = new Panel();
            label5 = new Label();
            panel27 = new Panel();
            damagedItems = new Label();
            panel41 = new Panel();
            panel42 = new Panel();
            label10 = new Label();
            panel43 = new Panel();
            totalItems = new Label();
            panel44 = new Panel();
            panel45 = new Panel();
            label12 = new Label();
            panel46 = new Panel();
            NUMBER_MIN_STOCK_LEVEL = new Label();
            panel47 = new Panel();
            pieChartInventory = new Chart();
            panel37 = new Panel();
            label8 = new Label();
            panel38 = new Panel();
            label9 = new Label();
            panel35 = new Panel();
            panel21 = new Panel();
            labelPullOuts = new Label();
            panel5 = new Panel();
            label1 = new Label();
            panel12 = new Panel();
            totalPullOutCmb = new ComboBox();
            label4 = new Label();
            panel7 = new Panel();
            panel1 = new Panel();
            panel6 = new Panel();
            panel14 = new Panel();
            panel16 = new Panel();
            bestSellerGrid = new DataGridView();
            Column6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            panel15 = new Panel();
            label3 = new Label();
            periodCmb = new ComboBox();
            panel13 = new Panel();
            panel20 = new Panel();
            transactionCountLabel = new Label();
            panel22 = new Panel();
            label2 = new Label();
            panel23 = new Panel();
            filterComboBox = new ComboBox();
            label6 = new Label();
            panel9 = new Panel();
            refreshButton = new Button();
            sidebar.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            adminPanels.SuspendLayout();
            panel11.SuspendLayout();
            panel8.SuspendLayout();
            panel24.SuspendLayout();
            panel10.SuspendLayout();
            panel18.SuspendLayout();
            panel19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartInventory).BeginInit();
            panel17.SuspendLayout();
            panel4.SuspendLayout();
            panel36.SuspendLayout();
            panel39.SuspendLayout();
            panel40.SuspendLayout();
            panel25.SuspendLayout();
            panel26.SuspendLayout();
            panel27.SuspendLayout();
            panel41.SuspendLayout();
            panel42.SuspendLayout();
            panel43.SuspendLayout();
            panel44.SuspendLayout();
            panel45.SuspendLayout();
            panel46.SuspendLayout();
            panel47.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pieChartInventory).BeginInit();
            panel37.SuspendLayout();
            panel38.SuspendLayout();
            panel21.SuspendLayout();
            panel5.SuspendLayout();
            panel12.SuspendLayout();
            panel7.SuspendLayout();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel14.SuspendLayout();
            panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bestSellerGrid).BeginInit();
            panel15.SuspendLayout();
            panel13.SuspendLayout();
            panel20.SuspendLayout();
            panel22.SuspendLayout();
            panel23.SuspendLayout();
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
            sidebar.Size = new Size(230, 791);
            sidebar.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(settingsBtn);
            panel3.Controls.Add(logsBtn);
            panel3.Controls.Add(employeeBtn);
            panel3.Controls.Add(logoutBtn);
            panel3.Controls.Add(transactionsBtn);
            panel3.Controls.Add(inventoryBtn);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 239);
            panel3.Name = "panel3";
            panel3.Size = new Size(230, 552);
            panel3.TabIndex = 2;
            // 
            // settingsBtn
            // 
            settingsBtn.Cursor = Cursors.Hand;
            settingsBtn.Dock = DockStyle.Top;
            settingsBtn.FlatAppearance.BorderSize = 0;
            settingsBtn.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            settingsBtn.FlatStyle = FlatStyle.Flat;
            settingsBtn.Font = new Font("Calibri", 18F);
            settingsBtn.ForeColor = SystemColors.ButtonHighlight;
            settingsBtn.Image = Properties.Resources.settings__3_;
            settingsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            settingsBtn.Location = new Point(0, 332);
            settingsBtn.Name = "settingsBtn";
            settingsBtn.Padding = new Padding(5, 5, 5, 5);
            settingsBtn.Size = new Size(230, 83);
            settingsBtn.TabIndex = 6;
            settingsBtn.Text = "Settings";
            settingsBtn.TextAlign = ContentAlignment.MiddleRight;
            settingsBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            settingsBtn.UseVisualStyleBackColor = true;
            settingsBtn.Click += settingsBtn_Click;
            // 
            // logsBtn
            // 
            logsBtn.Cursor = Cursors.Hand;
            logsBtn.Dock = DockStyle.Top;
            logsBtn.FlatAppearance.BorderSize = 0;
            logsBtn.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            logsBtn.FlatStyle = FlatStyle.Flat;
            logsBtn.Font = new Font("Calibri", 18F);
            logsBtn.ForeColor = SystemColors.ButtonHighlight;
            logsBtn.Image = Properties.Resources.log;
            logsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            logsBtn.Location = new Point(0, 249);
            logsBtn.Name = "logsBtn";
            logsBtn.Padding = new Padding(5, 5, 5, 5);
            logsBtn.Size = new Size(230, 83);
            logsBtn.TabIndex = 5;
            logsBtn.Text = "Logs";
            logsBtn.TextAlign = ContentAlignment.MiddleRight;
            logsBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            logsBtn.UseVisualStyleBackColor = true;
            logsBtn.Click += logsBtn_Click;
            // 
            // employeeBtn
            // 
            employeeBtn.Cursor = Cursors.Hand;
            employeeBtn.Dock = DockStyle.Top;
            employeeBtn.FlatAppearance.BorderSize = 0;
            employeeBtn.FlatAppearance.MouseOverBackColor = SystemColors.ActiveCaption;
            employeeBtn.FlatStyle = FlatStyle.Flat;
            employeeBtn.Font = new Font("Calibri", 18F);
            employeeBtn.ForeColor = SystemColors.ButtonHighlight;
            employeeBtn.Image = Properties.Resources.employee;
            employeeBtn.ImageAlign = ContentAlignment.MiddleLeft;
            employeeBtn.Location = new Point(0, 166);
            employeeBtn.Name = "employeeBtn";
            employeeBtn.Padding = new Padding(5, 5, 5, 5);
            employeeBtn.Size = new Size(230, 83);
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
            logoutBtn.Font = new Font("Calibri", 18F);
            logoutBtn.ForeColor = SystemColors.ButtonHighlight;
            logoutBtn.Image = Properties.Resources.logout;
            logoutBtn.ImageAlign = ContentAlignment.MiddleLeft;
            logoutBtn.Location = new Point(0, 469);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Padding = new Padding(5, 5, 5, 5);
            logoutBtn.Size = new Size(230, 83);
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
            transactionsBtn.Font = new Font("Calibri", 18F);
            transactionsBtn.ForeColor = SystemColors.ButtonHighlight;
            transactionsBtn.Image = Properties.Resources.transaction;
            transactionsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            transactionsBtn.Location = new Point(0, 83);
            transactionsBtn.Name = "transactionsBtn";
            transactionsBtn.Padding = new Padding(5, 5, 5, 5);
            transactionsBtn.Size = new Size(230, 83);
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
            inventoryBtn.Font = new Font("Calibri", 18F);
            inventoryBtn.ForeColor = SystemColors.ButtonHighlight;
            inventoryBtn.Image = Properties.Resources.asset;
            inventoryBtn.ImageAlign = ContentAlignment.MiddleLeft;
            inventoryBtn.Location = new Point(0, 0);
            inventoryBtn.Name = "inventoryBtn";
            inventoryBtn.Padding = new Padding(5, 5, 5, 5);
            inventoryBtn.Size = new Size(230, 83);
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
            panel2.Size = new Size(230, 239);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.company_logo;
            pictureBox1.Location = new Point(25, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(181, 147);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // adminPanels
            // 
            adminPanels.Controls.Add(panel11);
            adminPanels.Controls.Add(panel9);
            adminPanels.Dock = DockStyle.Fill;
            adminPanels.Location = new Point(230, 0);
            adminPanels.Name = "adminPanels";
            adminPanels.Padding = new Padding(15, 10, 15, 10);
            adminPanels.Size = new Size(1454, 791);
            adminPanels.TabIndex = 1;
            // 
            // panel11
            // 
            panel11.Controls.Add(panel8);
            panel11.Controls.Add(panel7);
            panel11.Dock = DockStyle.Fill;
            panel11.Location = new Point(15, 81);
            panel11.Name = "panel11";
            panel11.Size = new Size(1424, 700);
            panel11.TabIndex = 8;
            // 
            // panel8
            // 
            panel8.Controls.Add(panel24);
            panel8.Controls.Add(panel4);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(896, 700);
            panel8.TabIndex = 7;
            // 
            // panel24
            // 
            panel24.Controls.Add(panel10);
            panel24.Dock = DockStyle.Fill;
            panel24.Location = new Point(0, 0);
            panel24.Name = "panel24";
            panel24.Padding = new Padding(15, 5, 15, 5);
            panel24.Size = new Size(896, 347);
            panel24.TabIndex = 11;
            // 
            // panel10
            // 
            panel10.BackColor = SystemColors.ButtonHighlight;
            panel10.BorderStyle = BorderStyle.FixedSingle;
            panel10.Controls.Add(panel18);
            panel10.Controls.Add(panel17);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(15, 5);
            panel10.Name = "panel10";
            panel10.Size = new Size(866, 337);
            panel10.TabIndex = 8;
            // 
            // panel18
            // 
            panel18.Controls.Add(panel19);
            panel18.Dock = DockStyle.Fill;
            panel18.Location = new Point(0, 57);
            panel18.Name = "panel18";
            panel18.Padding = new Padding(15, 5, 15, 5);
            panel18.Size = new Size(864, 278);
            panel18.TabIndex = 4;
            // 
            // panel19
            // 
            panel19.Controls.Add(chartInventory);
            panel19.Dock = DockStyle.Fill;
            panel19.Location = new Point(15, 5);
            panel19.Name = "panel19";
            panel19.Size = new Size(834, 268);
            panel19.TabIndex = 2;
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
            chartInventory.Location = new Point(0, 0);
            chartInventory.Name = "chartInventory";
            series1.BackGradientStyle = GradientStyle.TopBottom;
            series1.BorderWidth = 4;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = SeriesChartType.Area;
            series1.Color = Color.Blue;
            series1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            series1.IsVisibleInLegend = false;
            series1.IsXValueIndexed = true;
            series1.MarkerSize = 10;
            series1.MarkerStyle = MarkerStyle.Circle;
            series1.Name = "Inventory Restocking";
            series1.ShadowColor = Color.FromArgb(64, 64, 64);
            chartInventory.Series.Add(series1);
            chartInventory.Size = new Size(834, 268);
            chartInventory.TabIndex = 1;
            chartInventory.Text = "chart1";
            title1.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title1.Name = "Title1";
            title1.Text = "INVENTORY RESTOCKING";
            chartInventory.Titles.Add(title1);
            // 
            // panel17
            // 
            panel17.Controls.Add(inventoryRestockingCmb);
            panel17.Dock = DockStyle.Top;
            panel17.Location = new Point(0, 0);
            panel17.Name = "panel17";
            panel17.Size = new Size(864, 57);
            panel17.TabIndex = 3;
            // 
            // inventoryRestockingCmb
            // 
            inventoryRestockingCmb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            inventoryRestockingCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            inventoryRestockingCmb.Font = new Font("Calibri", 15.75F);
            inventoryRestockingCmb.FormattingEnabled = true;
            inventoryRestockingCmb.Items.AddRange(new object[] { "Daily", "Weekly", "Monthly" });
            inventoryRestockingCmb.Location = new Point(581, 10);
            inventoryRestockingCmb.Name = "inventoryRestockingCmb";
            inventoryRestockingCmb.Size = new Size(268, 34);
            inventoryRestockingCmb.TabIndex = 2;
            inventoryRestockingCmb.SelectedIndexChanged += inventoryRestockingCmb_SelectedIndexChanged;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel36);
            panel4.Controls.Add(panel35);
            panel4.Controls.Add(panel21);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 347);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(15, 5, 15, 10);
            panel4.Size = new Size(896, 353);
            panel4.TabIndex = 10;
            // 
            // panel36
            // 
            panel36.BackColor = SystemColors.ButtonHighlight;
            panel36.BorderStyle = BorderStyle.FixedSingle;
            panel36.Controls.Add(panel39);
            panel36.Controls.Add(panel37);
            panel36.Dock = DockStyle.Fill;
            panel36.Location = new Point(15, 5);
            panel36.Name = "panel36";
            panel36.Padding = new Padding(10, 5, 10, 5);
            panel36.Size = new Size(505, 338);
            panel36.TabIndex = 14;
            // 
            // panel39
            // 
            panel39.Controls.Add(panel40);
            panel39.Controls.Add(panel47);
            panel39.Dock = DockStyle.Fill;
            panel39.Location = new Point(10, 63);
            panel39.Name = "panel39";
            panel39.Size = new Size(483, 268);
            panel39.TabIndex = 3;
            // 
            // panel40
            // 
            panel40.Controls.Add(panel25);
            panel40.Controls.Add(panel41);
            panel40.Controls.Add(panel44);
            panel40.Dock = DockStyle.Fill;
            panel40.Location = new Point(0, 0);
            panel40.Name = "panel40";
            panel40.Padding = new Padding(0, 60, 10, 30);
            panel40.Size = new Size(213, 268);
            panel40.TabIndex = 3;
            // 
            // panel25
            // 
            panel25.Controls.Add(panel26);
            panel25.Controls.Add(panel27);
            panel25.Dock = DockStyle.Top;
            panel25.Location = new Point(0, 198);
            panel25.Name = "panel25";
            panel25.Padding = new Padding(4, 4, 4, 4);
            panel25.Size = new Size(203, 69);
            panel25.TabIndex = 6;
            // 
            // panel26
            // 
            panel26.Controls.Add(label5);
            panel26.Dock = DockStyle.Fill;
            panel26.Location = new Point(4, 4);
            panel26.Name = "panel26";
            panel26.Size = new Size(98, 61);
            panel26.TabIndex = 2;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(98, 61);
            label5.TabIndex = 0;
            label5.Text = "Damaged Items";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel27
            // 
            panel27.Controls.Add(damagedItems);
            panel27.Dock = DockStyle.Right;
            panel27.Location = new Point(102, 4);
            panel27.Name = "panel27";
            panel27.Size = new Size(97, 61);
            panel27.TabIndex = 1;
            // 
            // damagedItems
            // 
            damagedItems.Dock = DockStyle.Fill;
            damagedItems.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            damagedItems.ForeColor = SystemColors.ActiveCaptionText;
            damagedItems.Location = new Point(0, 0);
            damagedItems.Name = "damagedItems";
            damagedItems.Size = new Size(97, 61);
            damagedItems.TabIndex = 1;
            damagedItems.Text = "0";
            damagedItems.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel41
            // 
            panel41.Controls.Add(panel42);
            panel41.Controls.Add(panel43);
            panel41.Dock = DockStyle.Top;
            panel41.Location = new Point(0, 129);
            panel41.Name = "panel41";
            panel41.Padding = new Padding(4, 4, 4, 4);
            panel41.Size = new Size(203, 69);
            panel41.TabIndex = 5;
            // 
            // panel42
            // 
            panel42.Controls.Add(label10);
            panel42.Dock = DockStyle.Fill;
            panel42.Location = new Point(4, 4);
            panel42.Name = "panel42";
            panel42.Size = new Size(98, 61);
            panel42.TabIndex = 2;
            // 
            // label10
            // 
            label10.Dock = DockStyle.Fill;
            label10.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(0, 0);
            label10.Name = "label10";
            label10.Size = new Size(98, 61);
            label10.TabIndex = 0;
            label10.Text = "All Items";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel43
            // 
            panel43.Controls.Add(totalItems);
            panel43.Dock = DockStyle.Right;
            panel43.Location = new Point(102, 4);
            panel43.Name = "panel43";
            panel43.Size = new Size(97, 61);
            panel43.TabIndex = 1;
            // 
            // totalItems
            // 
            totalItems.Dock = DockStyle.Fill;
            totalItems.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalItems.ForeColor = SystemColors.ActiveCaptionText;
            totalItems.Location = new Point(0, 0);
            totalItems.Name = "totalItems";
            totalItems.Size = new Size(97, 61);
            totalItems.TabIndex = 1;
            totalItems.Text = "0";
            totalItems.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel44
            // 
            panel44.Controls.Add(panel45);
            panel44.Controls.Add(panel46);
            panel44.Dock = DockStyle.Top;
            panel44.Location = new Point(0, 60);
            panel44.Name = "panel44";
            panel44.Padding = new Padding(4, 4, 4, 4);
            panel44.Size = new Size(203, 69);
            panel44.TabIndex = 4;
            // 
            // panel45
            // 
            panel45.Controls.Add(label12);
            panel45.Dock = DockStyle.Fill;
            panel45.Location = new Point(4, 4);
            panel45.Name = "panel45";
            panel45.Size = new Size(98, 61);
            panel45.TabIndex = 2;
            // 
            // label12
            // 
            label12.Dock = DockStyle.Fill;
            label12.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(0, 0);
            label12.Name = "label12";
            label12.Size = new Size(98, 61);
            label12.TabIndex = 0;
            label12.Text = "Low Stock Items";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel46
            // 
            panel46.Controls.Add(NUMBER_MIN_STOCK_LEVEL);
            panel46.Dock = DockStyle.Right;
            panel46.Location = new Point(102, 4);
            panel46.Name = "panel46";
            panel46.Size = new Size(97, 61);
            panel46.TabIndex = 1;
            // 
            // NUMBER_MIN_STOCK_LEVEL
            // 
            NUMBER_MIN_STOCK_LEVEL.Dock = DockStyle.Fill;
            NUMBER_MIN_STOCK_LEVEL.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NUMBER_MIN_STOCK_LEVEL.ForeColor = Color.Red;
            NUMBER_MIN_STOCK_LEVEL.Location = new Point(0, 0);
            NUMBER_MIN_STOCK_LEVEL.Name = "NUMBER_MIN_STOCK_LEVEL";
            NUMBER_MIN_STOCK_LEVEL.Size = new Size(97, 61);
            NUMBER_MIN_STOCK_LEVEL.TabIndex = 1;
            NUMBER_MIN_STOCK_LEVEL.Text = "0";
            NUMBER_MIN_STOCK_LEVEL.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel47
            // 
            panel47.Controls.Add(pieChartInventory);
            panel47.Dock = DockStyle.Right;
            panel47.Location = new Point(213, 0);
            panel47.Name = "panel47";
            panel47.Size = new Size(270, 268);
            panel47.TabIndex = 1;
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
            pieChartInventory.Location = new Point(0, 0);
            pieChartInventory.Name = "pieChartInventory";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = SeriesChartType.Pie;
            series2.IsValueShownAsLabel = true;
            series2.LabelFormat = "0.00%";
            series2.Legend = "Legend1";
            series2.Name = "pieChart";
            pieChartInventory.Series.Add(series2);
            pieChartInventory.Size = new Size(270, 268);
            pieChartInventory.TabIndex = 2;
            pieChartInventory.Text = "chart1";
            // 
            // panel37
            // 
            panel37.Controls.Add(label8);
            panel37.Controls.Add(panel38);
            panel37.Dock = DockStyle.Top;
            panel37.Location = new Point(10, 5);
            panel37.Name = "panel37";
            panel37.Size = new Size(483, 58);
            panel37.TabIndex = 2;
            // 
            // label8
            // 
            label8.BorderStyle = BorderStyle.Fixed3D;
            label8.Dock = DockStyle.Bottom;
            label8.Location = new Point(0, 57);
            label8.Name = "label8";
            label8.Size = new Size(483, 1);
            label8.TabIndex = 1;
            // 
            // panel38
            // 
            panel38.Controls.Add(label9);
            panel38.Dock = DockStyle.Fill;
            panel38.Location = new Point(0, 0);
            panel38.Name = "panel38";
            panel38.Size = new Size(483, 58);
            panel38.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(5, 11);
            label9.Name = "label9";
            label9.Size = new Size(163, 32);
            label9.TabIndex = 0;
            label9.Text = "ITEM DETAILS";
            // 
            // panel35
            // 
            panel35.Dock = DockStyle.Right;
            panel35.Location = new Point(520, 5);
            panel35.Name = "panel35";
            panel35.Size = new Size(15, 338);
            panel35.TabIndex = 13;
            // 
            // panel21
            // 
            panel21.BackColor = SystemColors.ButtonHighlight;
            panel21.BorderStyle = BorderStyle.FixedSingle;
            panel21.Controls.Add(labelPullOuts);
            panel21.Controls.Add(panel5);
            panel21.Dock = DockStyle.Right;
            panel21.Location = new Point(535, 5);
            panel21.Margin = new Padding(15, 3, 3, 3);
            panel21.Name = "panel21";
            panel21.Padding = new Padding(10, 5, 10, 5);
            panel21.Size = new Size(346, 338);
            panel21.TabIndex = 11;
            // 
            // labelPullOuts
            // 
            labelPullOuts.Dock = DockStyle.Fill;
            labelPullOuts.Font = new Font("Segoe UI", 65.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPullOuts.Location = new Point(10, 63);
            labelPullOuts.Name = "labelPullOuts";
            labelPullOuts.Size = new Size(324, 268);
            labelPullOuts.TabIndex = 4;
            labelPullOuts.Text = "0";
            labelPullOuts.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.Controls.Add(label1);
            panel5.Controls.Add(panel12);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(10, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(324, 58);
            panel5.TabIndex = 3;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Dock = DockStyle.Bottom;
            label1.Location = new Point(0, 57);
            label1.Name = "label1";
            label1.Size = new Size(324, 1);
            label1.TabIndex = 1;
            // 
            // panel12
            // 
            panel12.Controls.Add(totalPullOutCmb);
            panel12.Controls.Add(label4);
            panel12.Dock = DockStyle.Fill;
            panel12.Location = new Point(0, 0);
            panel12.Name = "panel12";
            panel12.Size = new Size(324, 58);
            panel12.TabIndex = 0;
            // 
            // totalPullOutCmb
            // 
            totalPullOutCmb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            totalPullOutCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            totalPullOutCmb.Font = new Font("Calibri", 15.75F);
            totalPullOutCmb.FormattingEnabled = true;
            totalPullOutCmb.Items.AddRange(new object[] { "Daily", "Weekly", "Monthly", "Yearly" });
            totalPullOutCmb.Location = new Point(143, 14);
            totalPullOutCmb.Name = "totalPullOutCmb";
            totalPullOutCmb.Size = new Size(175, 34);
            totalPullOutCmb.TabIndex = 3;
            totalPullOutCmb.SelectedIndexChanged += totalPullOutCmb_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(5, 11);
            label4.Name = "label4";
            label4.Size = new Size(124, 32);
            label4.TabIndex = 0;
            label4.Text = "PULL OUT";
            // 
            // panel7
            // 
            panel7.Controls.Add(panel1);
            panel7.Controls.Add(panel13);
            panel7.Dock = DockStyle.Right;
            panel7.Location = new Point(896, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(528, 700);
            panel7.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel6);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(528, 347);
            panel1.TabIndex = 8;
            // 
            // panel6
            // 
            panel6.Controls.Add(panel14);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(15, 5, 15, 5);
            panel6.Size = new Size(528, 347);
            panel6.TabIndex = 6;
            // 
            // panel14
            // 
            panel14.BackColor = SystemColors.ButtonHighlight;
            panel14.BorderStyle = BorderStyle.FixedSingle;
            panel14.Controls.Add(panel16);
            panel14.Controls.Add(panel15);
            panel14.Dock = DockStyle.Fill;
            panel14.Location = new Point(15, 5);
            panel14.Name = "panel14";
            panel14.Size = new Size(498, 337);
            panel14.TabIndex = 9;
            // 
            // panel16
            // 
            panel16.Controls.Add(bestSellerGrid);
            panel16.Dock = DockStyle.Fill;
            panel16.Location = new Point(0, 61);
            panel16.Name = "panel16";
            panel16.Padding = new Padding(15, 5, 15, 20);
            panel16.Size = new Size(496, 274);
            panel16.TabIndex = 9;
            // 
            // bestSellerGrid
            // 
            bestSellerGrid.AllowUserToAddRows = false;
            bestSellerGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            bestSellerGrid.BackgroundColor = SystemColors.ButtonHighlight;
            bestSellerGrid.BorderStyle = BorderStyle.None;
            bestSellerGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            bestSellerGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            bestSellerGrid.ColumnHeadersHeight = 45;
            bestSellerGrid.Columns.AddRange(new DataGridViewColumn[] { Column6, dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, Column1 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            bestSellerGrid.DefaultCellStyle = dataGridViewCellStyle2;
            bestSellerGrid.Dock = DockStyle.Fill;
            bestSellerGrid.EnableHeadersVisualStyles = false;
            bestSellerGrid.GridColor = SystemColors.ScrollBar;
            bestSellerGrid.Location = new Point(15, 5);
            bestSellerGrid.Name = "bestSellerGrid";
            bestSellerGrid.ReadOnly = true;
            bestSellerGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Calibri", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            bestSellerGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            bestSellerGrid.RowHeadersVisible = false;
            bestSellerGrid.RowHeadersWidth = 51;
            bestSellerGrid.RowTemplate.Height = 45;
            bestSellerGrid.RowTemplate.Resizable = DataGridViewTriState.True;
            bestSellerGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            bestSellerGrid.Size = new Size(466, 249);
            bestSellerGrid.TabIndex = 6;
            // 
            // Column6
            // 
            Column6.FillWeight = 71.26904F;
            Column6.HeaderText = "Rank";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.FillWeight = 71.26904F;
            dataGridViewTextBoxColumn1.HeaderText = "Item Code";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.FillWeight = 243.654785F;
            dataGridViewTextBoxColumn2.HeaderText = "Name";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "Total Sold";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // panel15
            // 
            panel15.Controls.Add(label3);
            panel15.Controls.Add(periodCmb);
            panel15.Dock = DockStyle.Top;
            panel15.Location = new Point(0, 0);
            panel15.Name = "panel15";
            panel15.Size = new Size(496, 61);
            panel15.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label3.Location = new Point(15, 12);
            label3.Name = "label3";
            label3.Size = new Size(230, 32);
            label3.TabIndex = 5;
            label3.Text = "TOP SELLING ITEMS";
            // 
            // periodCmb
            // 
            periodCmb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            periodCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            periodCmb.Font = new Font("Calibri", 15.75F);
            periodCmb.FormattingEnabled = true;
            periodCmb.Items.AddRange(new object[] { "Weekly", "Monthly", "Yearly" });
            periodCmb.Location = new Point(306, 12);
            periodCmb.Name = "periodCmb";
            periodCmb.Size = new Size(175, 34);
            periodCmb.TabIndex = 7;
            periodCmb.SelectedIndexChanged += periodCmb_SelectedIndexChanged;
            // 
            // panel13
            // 
            panel13.BackColor = SystemColors.Control;
            panel13.Controls.Add(panel20);
            panel13.Dock = DockStyle.Bottom;
            panel13.Location = new Point(0, 347);
            panel13.Name = "panel13";
            panel13.Padding = new Padding(15, 5, 15, 10);
            panel13.Size = new Size(528, 353);
            panel13.TabIndex = 7;
            // 
            // panel20
            // 
            panel20.BackColor = SystemColors.ButtonHighlight;
            panel20.BorderStyle = BorderStyle.FixedSingle;
            panel20.Controls.Add(transactionCountLabel);
            panel20.Controls.Add(panel22);
            panel20.Dock = DockStyle.Fill;
            panel20.Location = new Point(15, 5);
            panel20.Name = "panel20";
            panel20.Padding = new Padding(10, 5, 10, 5);
            panel20.Size = new Size(498, 338);
            panel20.TabIndex = 4;
            // 
            // transactionCountLabel
            // 
            transactionCountLabel.Dock = DockStyle.Fill;
            transactionCountLabel.Font = new Font("Segoe UI", 65.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            transactionCountLabel.Location = new Point(10, 63);
            transactionCountLabel.Name = "transactionCountLabel";
            transactionCountLabel.Size = new Size(476, 268);
            transactionCountLabel.TabIndex = 5;
            transactionCountLabel.Text = "0";
            transactionCountLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel22
            // 
            panel22.Controls.Add(label2);
            panel22.Controls.Add(panel23);
            panel22.Dock = DockStyle.Top;
            panel22.Location = new Point(10, 5);
            panel22.Name = "panel22";
            panel22.Size = new Size(476, 58);
            panel22.TabIndex = 4;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Dock = DockStyle.Bottom;
            label2.Location = new Point(0, 57);
            label2.Name = "label2";
            label2.Size = new Size(476, 1);
            label2.TabIndex = 1;
            // 
            // panel23
            // 
            panel23.Controls.Add(filterComboBox);
            panel23.Controls.Add(label6);
            panel23.Dock = DockStyle.Fill;
            panel23.Location = new Point(0, 0);
            panel23.Name = "panel23";
            panel23.Size = new Size(476, 58);
            panel23.TabIndex = 0;
            // 
            // filterComboBox
            // 
            filterComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            filterComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            filterComboBox.Font = new Font("Calibri", 15.75F);
            filterComboBox.FormattingEnabled = true;
            filterComboBox.Items.AddRange(new object[] { "Daily", "Weekly", "Monthly", "Yearly" });
            filterComboBox.Location = new Point(296, 11);
            filterComboBox.Name = "filterComboBox";
            filterComboBox.Size = new Size(175, 34);
            filterComboBox.TabIndex = 4;
            filterComboBox.SelectedIndexChanged += filterComboBox_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(5, 11);
            label6.Name = "label6";
            label6.Size = new Size(189, 32);
            label6.TabIndex = 0;
            label6.Text = "TRANSACTIONS";
            // 
            // panel9
            // 
            panel9.Controls.Add(refreshButton);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(15, 10);
            panel9.Name = "panel9";
            panel9.Size = new Size(1424, 71);
            panel9.TabIndex = 5;
            // 
            // refreshButton
            // 
            refreshButton.Font = new Font("Calibri", 14.25F);
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
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1684, 791);
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
            panel24.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel18.ResumeLayout(false);
            panel19.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartInventory).EndInit();
            panel17.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel36.ResumeLayout(false);
            panel39.ResumeLayout(false);
            panel40.ResumeLayout(false);
            panel25.ResumeLayout(false);
            panel26.ResumeLayout(false);
            panel27.ResumeLayout(false);
            panel41.ResumeLayout(false);
            panel42.ResumeLayout(false);
            panel43.ResumeLayout(false);
            panel44.ResumeLayout(false);
            panel45.ResumeLayout(false);
            panel46.ResumeLayout(false);
            panel47.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pieChartInventory).EndInit();
            panel37.ResumeLayout(false);
            panel38.ResumeLayout(false);
            panel38.PerformLayout();
            panel21.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel7.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel14.ResumeLayout(false);
            panel16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bestSellerGrid).EndInit();
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            panel13.ResumeLayout(false);
            panel20.ResumeLayout(false);
            panel22.ResumeLayout(false);
            panel23.ResumeLayout(false);
            panel23.PerformLayout();
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
        private Panel panel9;
        private Panel panel7;
        private Panel panel8;
        private Button refreshButton;
        private Panel panel11;
        private Label label3;
        private ComboBox inventoryRestockingCmb;
        private DataGridView bestSellerGrid;
        private ComboBox periodCmb;
        private Button employeeBtn;
        private Panel panel6;
        private Panel panel14;
        private Panel panel16;
        private Panel panel15;
        private Panel panel10;
        private Panel panel17;
        private Panel panel18;
        private Button logsBtn;
        private Panel panel19;
        private Button settingsBtn;
        private Panel panel13;
        private Panel panel20;
        private Panel panel23;
        private Panel panel22;
        private Label label2;
        private Panel panel4;
        private Panel panel24;
        private Panel panel1;
        private Panel panel21;
        private Panel panel35;
        private Panel panel36;
        private Panel panel39;
        private Panel panel40;
        private Panel panel41;
        private Panel panel42;
        private Label label10;
        private Panel panel43;
        private Label totalItems;
        private Panel panel44;
        private Panel panel45;
        private Label label12;
        private Panel panel46;
        private Label NUMBER_MIN_STOCK_LEVEL;
        private Panel panel47;
        private Chart pieChartInventory;
        private Panel panel37;
        private Label label8;
        private Panel panel38;
        private Label label9;
        private Panel panel5;
        private Label label1;
        private Panel panel12;
        private Label label4;
        private Panel panel25;
        private Panel panel26;
        private Label label5;
        private Panel panel27;
        private Label damagedItems;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Label label6;
        private ComboBox totalPullOutCmb;
        private Label labelPullOuts;
        private Label transactionCountLabel;
        private ComboBox filterComboBox;
        private DataGridViewTextBoxColumn Column1;
    }
}