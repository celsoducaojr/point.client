namespace Point.Client.Main.Forms.Orders
{
    partial class frmOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrders));
            panel1 = new Panel();
            dgvItemUnits = new DataGridView();
            clmOrderNumber = new DataGridViewTextBoxColumn();
            clmCustomer = new DataGridViewTextBoxColumn();
            clmStatus = new DataGridViewTextBoxColumn();
            tsMain = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            button3 = new Button();
            button2 = new Button();
            label2 = new Label();
            label7 = new Label();
            button1 = new Button();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label6 = new Label();
            dgvTags = new DataGridView();
            clmItem = new DataGridViewTextBoxColumn();
            clmUnit = new DataGridViewTextBoxColumn();
            clmQuantity = new DataGridViewTextBoxColumn();
            clmPrice = new DataGridViewTextBoxColumn();
            clmTotal = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txtItem = new TextBox();
            lblTitle = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItemUnits).BeginInit();
            tsMain.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTags).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvItemUnits);
            panel1.Controls.Add(tsMain);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(4, 4);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(430, 755);
            panel1.TabIndex = 0;
            // 
            // dgvItemUnits
            // 
            dgvItemUnits.AllowUserToAddRows = false;
            dgvItemUnits.AllowUserToDeleteRows = false;
            dgvItemUnits.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItemUnits.Columns.AddRange(new DataGridViewColumn[] { clmOrderNumber, clmCustomer, clmStatus });
            dgvItemUnits.Dock = DockStyle.Fill;
            dgvItemUnits.Location = new System.Drawing.Point(0, 31);
            dgvItemUnits.Margin = new Padding(5);
            dgvItemUnits.Name = "dgvItemUnits";
            dgvItemUnits.ReadOnly = true;
            dgvItemUnits.RowHeadersWidth = 51;
            dgvItemUnits.Size = new Size(430, 724);
            dgvItemUnits.TabIndex = 6;
            // 
            // clmOrderNumber
            // 
            clmOrderNumber.HeaderText = "Order No.";
            clmOrderNumber.MinimumWidth = 6;
            clmOrderNumber.Name = "clmOrderNumber";
            clmOrderNumber.ReadOnly = true;
            clmOrderNumber.Width = 125;
            // 
            // clmCustomer
            // 
            clmCustomer.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clmCustomer.HeaderText = "Customer";
            clmCustomer.MinimumWidth = 6;
            clmCustomer.Name = "clmCustomer";
            clmCustomer.ReadOnly = true;
            // 
            // clmStatus
            // 
            clmStatus.HeaderText = "Status";
            clmStatus.MaxInputLength = 50;
            clmStatus.MinimumWidth = 6;
            clmStatus.Name = "clmStatus";
            clmStatus.ReadOnly = true;
            clmStatus.Width = 125;
            // 
            // tsMain
            // 
            tsMain.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tsMain.GripStyle = ToolStripGripStyle.Hidden;
            tsMain.ImageScalingSize = new Size(20, 20);
            tsMain.Items.AddRange(new ToolStripItem[] { toolStripButton1 });
            tsMain.Location = new System.Drawing.Point(0, 0);
            tsMain.Name = "tsMain";
            tsMain.Size = new Size(430, 31);
            tsMain.TabIndex = 5;
            tsMain.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(149, 28);
            toolStripButton1.Text = "Add New Order";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1482, 763);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(dgvTags);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtItem);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(442, 4);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(1036, 755);
            panel2.TabIndex = 1;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button3.Font = new Font("Segoe UI", 13.8F);
            button3.Location = new System.Drawing.Point(145, 592);
            button3.Name = "button3";
            button3.Size = new Size(188, 72);
            button3.TabIndex = 39;
            button3.Text = "SAVE AS NEW";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.Font = new Font("Segoe UI", 13.8F);
            button2.Location = new System.Drawing.Point(14, 592);
            button2.Name = "button2";
            button2.Size = new Size(125, 72);
            button2.TabIndex = 38;
            button2.Text = "PAID";
            button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label2.Location = new System.Drawing.Point(685, 668);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(88, 41);
            label2.TabIndex = 37;
            label2.Text = "Total";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label7.Location = new System.Drawing.Point(781, 669);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(241, 38);
            label7.TabIndex = 36;
            label7.Text = "0.00";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.Font = new Font("Segoe UI", 13.8F);
            button1.Location = new System.Drawing.Point(14, 670);
            button1.Name = "button1";
            button1.Size = new Size(319, 72);
            button1.TabIndex = 35;
            button1.Text = "CANCEL";
            button1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new System.Drawing.Point(647, 631);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(126, 38);
            label11.TabIndex = 34;
            label11.Text = "Discount";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label10.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new System.Drawing.Point(781, 630);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(241, 38);
            label10.TabIndex = 33;
            label10.Text = "0.00";
            label10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label9.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new System.Drawing.Point(781, 592);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(241, 38);
            label9.TabIndex = 32;
            label9.Text = "0.00";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new System.Drawing.Point(643, 593);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(130, 38);
            label8.TabIndex = 31;
            label8.Text = "Sub Total";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new System.Drawing.Point(68, 31);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(50, 25);
            label5.TabIndex = 28;
            label5.Text = "New";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(0, 31);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 27;
            label4.Text = "Status";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(898, 0);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 25);
            label3.TabIndex = 26;
            label3.Text = "Jan 1, 2025";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new System.Drawing.Point(0, 0);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(207, 31);
            label6.TabIndex = 23;
            label6.Text = "ORDER NO. 12345";
            // 
            // dgvTags
            // 
            dgvTags.AllowUserToAddRows = false;
            dgvTags.AllowUserToDeleteRows = false;
            dgvTags.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTags.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTags.Columns.AddRange(new DataGridViewColumn[] { clmItem, clmUnit, clmQuantity, clmPrice, clmTotal });
            dgvTags.Location = new System.Drawing.Point(14, 99);
            dgvTags.Margin = new Padding(4);
            dgvTags.MultiSelect = false;
            dgvTags.Name = "dgvTags";
            dgvTags.ReadOnly = true;
            dgvTags.RowHeadersWidth = 51;
            dgvTags.Size = new Size(1008, 486);
            dgvTags.TabIndex = 11;
            // 
            // clmItem
            // 
            clmItem.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clmItem.HeaderText = "Item";
            clmItem.MinimumWidth = 6;
            clmItem.Name = "clmItem";
            clmItem.ReadOnly = true;
            // 
            // clmUnit
            // 
            clmUnit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            clmUnit.HeaderText = "Unit";
            clmUnit.MinimumWidth = 6;
            clmUnit.Name = "clmUnit";
            clmUnit.ReadOnly = true;
            clmUnit.Width = 73;
            // 
            // clmQuantity
            // 
            clmQuantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            clmQuantity.HeaderText = "Qty.";
            clmQuantity.MinimumWidth = 6;
            clmQuantity.Name = "clmQuantity";
            clmQuantity.ReadOnly = true;
            clmQuantity.Width = 74;
            // 
            // clmPrice
            // 
            clmPrice.HeaderText = "Price";
            clmPrice.MinimumWidth = 6;
            clmPrice.Name = "clmPrice";
            clmPrice.ReadOnly = true;
            clmPrice.Width = 125;
            // 
            // clmTotal
            // 
            clmTotal.HeaderText = "Total";
            clmTotal.MinimumWidth = 6;
            clmTotal.Name = "clmTotal";
            clmTotal.ReadOnly = true;
            clmTotal.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(14, 63);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 10;
            label1.Text = "Customer";
            // 
            // txtItem
            // 
            txtItem.Location = new System.Drawing.Point(111, 60);
            txtItem.Margin = new Padding(4);
            txtItem.MaxLength = 100;
            txtItem.Name = "txtItem";
            txtItem.ReadOnly = true;
            txtItem.Size = new Size(459, 31);
            txtItem.TabIndex = 9;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.DeepSkyBlue;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new System.Drawing.Point(0, 0);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1482, 40);
            lblTitle.TabIndex = 9;
            lblTitle.Text = "Manage Orders";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmOrders
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 803);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MinimumSize = new Size(1500, 850);
            Name = "frmOrders";
            Text = "Orders";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItemUnits).EndInit();
            tsMain.ResumeLayout(false);
            tsMain.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTags).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private DataGridView dgvItemUnits;
        private ToolStrip tsMain;
        private ToolStripButton toolStripButton1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Label lblTitle;
        private Label label1;
        private TextBox txtItem;
        private DataGridView dgvTags;
        private Label label6;
        private DataGridViewTextBoxColumn clmItem;
        private DataGridViewTextBoxColumn clmUnit;
        private DataGridViewTextBoxColumn clmQuantity;
        private DataGridViewTextBoxColumn clmPrice;
        private DataGridViewTextBoxColumn clmTotal;
        private Label label5;
        private Label label4;
        private Label label3;
        private DataGridViewTextBoxColumn clmOrderNumber;
        private DataGridViewTextBoxColumn clmCustomer;
        private DataGridViewTextBoxColumn clmStatus;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Button button1;
        private Label label2;
        private Label label7;
        private Button button2;
        private Button button3;
    }
}