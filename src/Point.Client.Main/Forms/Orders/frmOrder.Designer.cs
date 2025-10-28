namespace Point.Client.Main.Forms.Orders
{
    partial class frmOrder
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
            lblTitle = new Label();
            pnlMain = new Panel();
            lnkSelectCustomer = new LinkLabel();
            btnAddItem = new Button();
            label7 = new Label();
            lblTotal = new Label();
            btnSave = new Button();
            btnPay = new Button();
            btnClear = new Button();
            label1 = new Label();
            dgvOrderItems = new DataGridView();
            clmRemove = new DataGridViewButtonColumn();
            clmItem = new DataGridViewTextBoxColumn();
            clmUnit = new DataGridViewTextBoxColumn();
            clmQuantity = new DataGridViewTextBoxColumn();
            clmPrice = new DataGridViewTextBoxColumn();
            clmTotal = new DataGridViewTextBoxColumn();
            txtCustomer = new TextBox();
            lblDateTime = new Label();
            lblStatus = new Label();
            label4 = new Label();
            lblOrderNumber = new Label();
            pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderItems).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Teal;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new System.Drawing.Point(0, 0);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1482, 70);
            lblTitle.TabIndex = 11;
            lblTitle.Text = "Order Form";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(lnkSelectCustomer);
            pnlMain.Controls.Add(btnAddItem);
            pnlMain.Controls.Add(label7);
            pnlMain.Controls.Add(lblTotal);
            pnlMain.Controls.Add(btnSave);
            pnlMain.Controls.Add(btnPay);
            pnlMain.Controls.Add(btnClear);
            pnlMain.Controls.Add(label1);
            pnlMain.Controls.Add(dgvOrderItems);
            pnlMain.Controls.Add(txtCustomer);
            pnlMain.Controls.Add(lblDateTime);
            pnlMain.Controls.Add(lblStatus);
            pnlMain.Controls.Add(label4);
            pnlMain.Controls.Add(lblOrderNumber);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlMain.Location = new System.Drawing.Point(0, 70);
            pnlMain.Name = "pnlMain";
            pnlMain.Padding = new Padding(20);
            pnlMain.Size = new Size(1482, 733);
            pnlMain.TabIndex = 13;
            // 
            // lnkSelectCustomer
            // 
            lnkSelectCustomer.AutoSize = true;
            lnkSelectCustomer.Location = new System.Drawing.Point(782, 80);
            lnkSelectCustomer.Name = "lnkSelectCustomer";
            lnkSelectCustomer.Size = new Size(165, 28);
            lnkSelectCustomer.TabIndex = 6;
            lnkSelectCustomer.TabStop = true;
            lnkSelectCustomer.Text = "Select Customer...";
            lnkSelectCustomer.LinkClicked += lnkSelectCustomer_LinkClicked;
            // 
            // btnAddItem
            // 
            btnAddItem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddItem.Font = new Font("Segoe UI", 13.8F);
            btnAddItem.Location = new System.Drawing.Point(1181, 71);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(277, 51);
            btnAddItem.TabIndex = 1;
            btnAddItem.Text = "ADD ITEM";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(192, 192, 0);
            label7.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold);
            label7.Location = new System.Drawing.Point(1054, 634);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(95, 46);
            label7.TabIndex = 48;
            label7.Text = "Total";
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotal.BackColor = Color.FromArgb(192, 192, 0);
            lblTotal.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold);
            lblTotal.Location = new System.Drawing.Point(1054, 621);
            lblTotal.Margin = new Padding(4, 0, 4, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(404, 70);
            lblTotal.TabIndex = 47;
            lblTotal.Text = "0.00";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSave.Enabled = false;
            btnSave.Font = new Font("Segoe UI", 13.8F);
            btnSave.Location = new System.Drawing.Point(169, 610);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(140, 100);
            btnSave.TabIndex = 5;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnPay
            // 
            btnPay.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnPay.BackColor = Color.LimeGreen;
            btnPay.Enabled = false;
            btnPay.Font = new Font("Segoe UI", 13.8F);
            btnPay.Location = new System.Drawing.Point(23, 610);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(140, 100);
            btnPay.TabIndex = 3;
            btnPay.Text = "PAY";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnClear.Font = new Font("Segoe UI", 13.8F);
            btnClear.Location = new System.Drawing.Point(315, 610);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(140, 100);
            btnClear.TabIndex = 6;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(24, 83);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(96, 28);
            label1.TabIndex = 34;
            label1.Text = "Customer";
            // 
            // dgvOrderItems
            // 
            dgvOrderItems.AllowUserToAddRows = false;
            dgvOrderItems.AllowUserToDeleteRows = false;
            dgvOrderItems.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvOrderItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderItems.Columns.AddRange(new DataGridViewColumn[] { clmRemove, clmItem, clmUnit, clmQuantity, clmPrice, clmTotal });
            dgvOrderItems.Location = new System.Drawing.Point(24, 129);
            dgvOrderItems.Margin = new Padding(4);
            dgvOrderItems.MultiSelect = false;
            dgvOrderItems.Name = "dgvOrderItems";
            dgvOrderItems.RowHeadersWidth = 51;
            dgvOrderItems.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvOrderItems.Size = new Size(1434, 474);
            dgvOrderItems.TabIndex = 2;
            dgvOrderItems.CellClick += dgvOrderItems_CellClick;
            dgvOrderItems.CellValidated += dgvOrderItems_CellValidated;
            dgvOrderItems.CellValidating += dgvOrderItems_CellValidating;
            // 
            // clmRemove
            // 
            clmRemove.HeaderText = "";
            clmRemove.MinimumWidth = 6;
            clmRemove.Name = "clmRemove";
            clmRemove.Width = 125;
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
            clmUnit.HeaderText = "Unit";
            clmUnit.MinimumWidth = 6;
            clmUnit.Name = "clmUnit";
            clmUnit.ReadOnly = true;
            clmUnit.Width = 125;
            // 
            // clmQuantity
            // 
            clmQuantity.HeaderText = "Quantity";
            clmQuantity.MinimumWidth = 6;
            clmQuantity.Name = "clmQuantity";
            clmQuantity.Width = 125;
            // 
            // clmPrice
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            clmPrice.DefaultCellStyle = dataGridViewCellStyle1;
            clmPrice.HeaderText = "Price";
            clmPrice.MinimumWidth = 6;
            clmPrice.Name = "clmPrice";
            clmPrice.Width = 150;
            // 
            // clmTotal
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            clmTotal.DefaultCellStyle = dataGridViewCellStyle2;
            clmTotal.HeaderText = "Total";
            clmTotal.MinimumWidth = 6;
            clmTotal.Name = "clmTotal";
            clmTotal.ReadOnly = true;
            clmTotal.Width = 175;
            // 
            // txtCustomer
            // 
            txtCustomer.Location = new System.Drawing.Point(128, 77);
            txtCustomer.Margin = new Padding(4);
            txtCustomer.MaxLength = 100;
            txtCustomer.Name = "txtCustomer";
            txtCustomer.ReadOnly = true;
            txtCustomer.Size = new Size(647, 34);
            txtCustomer.TabIndex = 32;
            txtCustomer.TabStop = false;
            // 
            // lblDateTime
            // 
            lblDateTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDateTime.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDateTime.Location = new System.Drawing.Point(1237, 14);
            lblDateTime.Margin = new Padding(4, 0, 4, 0);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(221, 25);
            lblDateTime.TabIndex = 31;
            lblDateTime.Text = "Jan 1, 2025";
            lblDateTime.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.Location = new System.Drawing.Point(128, 48);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(54, 25);
            lblStatus.TabIndex = 30;
            lblStatus.Text = "NEW";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(55, 45);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(65, 28);
            label4.TabIndex = 29;
            label4.Text = "Status";
            // 
            // lblOrderNumber
            // 
            lblOrderNumber.AutoSize = true;
            lblOrderNumber.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderNumber.Location = new System.Drawing.Point(24, 14);
            lblOrderNumber.Margin = new Padding(4, 0, 4, 0);
            lblOrderNumber.Name = "lblOrderNumber";
            lblOrderNumber.Size = new Size(207, 31);
            lblOrderNumber.TabIndex = 24;
            lblOrderNumber.Text = "ORDER NO. 12345";
            // 
            // frmOrder
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 803);
            Controls.Add(pnlMain);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MinimumSize = new Size(1500, 850);
            Name = "frmOrder";
            Text = "Order Form";
            WindowState = FormWindowState.Maximized;
            FormClosing += frmOrder_FormClosing;
            Load += frmOrder_Load;
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderItems).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lblTitle;
        private Panel pnlMain;
        private Label lblOrderNumber;
        private Label lblStatus;
        private Label label4;
        private Label lblDateTime;
        private DataGridView dgvOrderItems;
        private TextBox txtCustomer;
        private Label label1;
        private Button btnSave;
        private Button btnPay;
        private Button btnClear;
        private Label lblTotal;
        private Label label7;
        private Button btnAddItem;
        private LinkLabel lnkSelectCustomer;
        private DataGridViewButtonColumn clmRemove;
        private DataGridViewTextBoxColumn clmItem;
        private DataGridViewTextBoxColumn clmUnit;
        private DataGridViewTextBoxColumn clmQuantity;
        private DataGridViewTextBoxColumn clmPrice;
        private DataGridViewTextBoxColumn clmTotal;
    }
}