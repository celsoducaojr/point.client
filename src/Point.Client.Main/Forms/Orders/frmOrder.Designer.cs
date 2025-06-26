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
            btnSaveAsNew = new Button();
            btnPaid = new Button();
            btnClear = new Button();
            label11 = new Label();
            lblDiscount = new Label();
            lblSubTotal = new Label();
            label8 = new Label();
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
            pnlMain.Controls.Add(btnSaveAsNew);
            pnlMain.Controls.Add(btnPaid);
            pnlMain.Controls.Add(btnClear);
            pnlMain.Controls.Add(label11);
            pnlMain.Controls.Add(lblDiscount);
            pnlMain.Controls.Add(lblSubTotal);
            pnlMain.Controls.Add(label8);
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
            lnkSelectCustomer.Location = new System.Drawing.Point(557, 100);
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
            btnAddItem.Location = new System.Drawing.Point(1231, 60);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(227, 72);
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
            label7.Location = new System.Drawing.Point(1057, 651);
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
            lblTotal.Location = new System.Drawing.Point(1057, 638);
            lblTotal.Margin = new Padding(4, 0, 4, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(401, 70);
            lblTotal.TabIndex = 47;
            lblTotal.Text = "0.00";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnSaveAsNew
            // 
            btnSaveAsNew.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSaveAsNew.Enabled = false;
            btnSaveAsNew.Font = new Font("Segoe UI", 13.8F);
            btnSaveAsNew.Location = new System.Drawing.Point(23, 638);
            btnSaveAsNew.Name = "btnSaveAsNew";
            btnSaveAsNew.Size = new Size(188, 72);
            btnSaveAsNew.TabIndex = 4;
            btnSaveAsNew.Text = "SAVE AS NEW";
            btnSaveAsNew.UseVisualStyleBackColor = true;
            btnSaveAsNew.Click += btnSaveAsNew_Click;
            // 
            // btnPaid
            // 
            btnPaid.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnPaid.Enabled = false;
            btnPaid.Font = new Font("Segoe UI", 13.8F);
            btnPaid.Location = new System.Drawing.Point(23, 560);
            btnPaid.Name = "btnPaid";
            btnPaid.Size = new Size(382, 72);
            btnPaid.TabIndex = 3;
            btnPaid.Text = "PAY";
            btnPaid.UseVisualStyleBackColor = true;
            btnPaid.Click += btnPaid_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnClear.Font = new Font("Segoe UI", 13.8F);
            btnClear.Location = new System.Drawing.Point(217, 638);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(188, 72);
            btnClear.TabIndex = 5;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new System.Drawing.Point(1057, 596);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(126, 38);
            label11.TabIndex = 41;
            label11.Text = "Discount";
            // 
            // lblDiscount
            // 
            lblDiscount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblDiscount.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiscount.Location = new System.Drawing.Point(1191, 595);
            lblDiscount.Margin = new Padding(4, 0, 4, 0);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(267, 38);
            lblDiscount.TabIndex = 40;
            lblDiscount.Text = "0.00";
            lblDiscount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSubTotal
            // 
            lblSubTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblSubTotal.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubTotal.Location = new System.Drawing.Point(1191, 557);
            lblSubTotal.Margin = new Padding(4, 0, 4, 0);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(267, 38);
            lblSubTotal.TabIndex = 39;
            lblSubTotal.Text = "0.00";
            lblSubTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new System.Drawing.Point(1053, 558);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(130, 38);
            label8.TabIndex = 38;
            label8.Text = "Sub Total";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(24, 100);
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
            dgvOrderItems.Location = new System.Drawing.Point(24, 139);
            dgvOrderItems.Margin = new Padding(4);
            dgvOrderItems.MultiSelect = false;
            dgvOrderItems.Name = "dgvOrderItems";
            dgvOrderItems.RowHeadersWidth = 51;
            dgvOrderItems.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvOrderItems.Size = new Size(1434, 414);
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
            txtCustomer.Location = new System.Drawing.Point(128, 97);
            txtCustomer.Margin = new Padding(4);
            txtCustomer.MaxLength = 100;
            txtCustomer.Name = "txtCustomer";
            txtCustomer.ReadOnly = true;
            txtCustomer.Size = new Size(422, 34);
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
            lblStatus.Location = new System.Drawing.Point(97, 48);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(54, 25);
            lblStatus.TabIndex = 30;
            lblStatus.Text = "NEW";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(24, 45);
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
        private Label label11;
        private Label lblDiscount;
        private Label lblSubTotal;
        private Label label8;
        private Button btnSaveAsNew;
        private Button btnPaid;
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