namespace InventorySystem.Views.Modals.InventoryUser
{
    partial class NotificationModal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotificationModal));
            panel1 = new Panel();
            panel3 = new Panel();
            dataGridViewAlerts = new DataGridView();
            panel2 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlerts).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1723, 791);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridViewAlerts);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 91);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(30, 5, 30, 20);
            panel3.Size = new Size(1723, 700);
            panel3.TabIndex = 1;
            // 
            // dataGridViewAlerts
            // 
            dataGridViewAlerts.AllowUserToAddRows = false;
            dataGridViewAlerts.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewAlerts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAlerts.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewAlerts.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewAlerts.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewAlerts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new Font("Calibri", 18F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewAlerts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewAlerts.ColumnHeadersHeight = 70;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Calibri", 16F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewAlerts.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewAlerts.EnableHeadersVisualStyles = false;
            dataGridViewAlerts.GridColor = SystemColors.ScrollBar;
            dataGridViewAlerts.Location = new Point(30, 5);
            dataGridViewAlerts.Name = "dataGridViewAlerts";
            dataGridViewAlerts.ReadOnly = true;
            dataGridViewAlerts.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Font = new Font("Calibri", 8.25F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewAlerts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewAlerts.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewAlerts.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewAlerts.RowTemplate.Height = 100;
            dataGridViewAlerts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAlerts.Size = new Size(1663, 675);
            dataGridViewAlerts.TabIndex = 1;
            dataGridViewAlerts.CellFormatting += dataGridViewAlerts_CellFormatting;
            dataGridViewAlerts.DataBindingComplete += Alerts_OnDataBindingComplete;
            // 
            // panel2
            // 
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1723, 91);
            panel2.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(37, 58);
            label3.Name = "label3";
            label3.Size = new Size(230, 20);
            label3.TabIndex = 2;
            label3.Text = "Items below minimum stock level";
            // 
            // label2
            // 
            label2.Dock = DockStyle.Bottom;
            label2.Location = new Point(0, 90);
            label2.Name = "label2";
            label2.Size = new Size(1723, 1);
            label2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 9);
            label1.Name = "label1";
            label1.Size = new Size(234, 49);
            label1.TabIndex = 0;
            label1.Text = "Notifications";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Red;
            panel4.Location = new Point(1633, 57);
            panel4.Name = "panel4";
            panel4.Size = new Size(22, 21);
            panel4.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Orange;
            panel5.Location = new Point(1491, 57);
            panel5.Name = "panel5";
            panel5.Size = new Size(22, 21);
            panel5.TabIndex = 4;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Yellow;
            panel6.Location = new Point(1240, 57);
            panel6.Name = "panel6";
            panel6.Size = new Size(22, 21);
            panel6.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(1018, 57);
            label4.Name = "label4";
            label4.Size = new Size(216, 21);
            label4.TabIndex = 6;
            label4.Text = "Greater than or equal to 75%";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(1288, 57);
            label5.Name = "label5";
            label5.Size = new Size(197, 21);
            label5.TabIndex = 7;
            label5.Text = "Greater than or equal 50%";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(1538, 57);
            label6.Name = "label6";
            label6.Size = new Size(89, 21);
            label6.TabIndex = 8;
            label6.Text = "Below 50%";
            // 
            // NotificationModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1723, 791);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "NotificationModal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Notification";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlerts).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private DataGridView dataGridViewAlerts;
        private DataGridViewTextBoxColumn Column9;
        private Label label2;
        private Label label3;
        private Panel panel5;
        private Panel panel4;
        private Panel panel6;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}