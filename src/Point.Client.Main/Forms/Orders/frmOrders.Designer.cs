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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrders));
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            dgvOrders = new DataGridView();
            clmOrderNumber = new DataGridViewTextBoxColumn();
            clmDate = new DataGridViewTextBoxColumn();
            clmStatus = new DataGridViewTextBoxColumn();
            clmOrderTotal = new DataGridViewTextBoxColumn();
            clmCustomer = new DataGridViewTextBoxColumn();
            tsPages = new ToolStrip();
            toolStripLabel2 = new ToolStripLabel();
            cmbPageSize = new ToolStripComboBox();
            toolStripSeparator2 = new ToolStripSeparator();
            btnLast = new ToolStripButton();
            btnNext = new ToolStripButton();
            lblTotalPage = new ToolStripLabel();
            txtPage = new ToolStripTextBox();
            toolStripLabel1 = new ToolStripLabel();
            btnPrev = new ToolStripButton();
            btnFirst = new ToolStripButton();
            btnReload = new ToolStripButton();
            tsMain = new ToolStrip();
            btnAddNewOrder = new ToolStripButton();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            btnModify = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            btnRelease = new ToolStripMenuItem();
            btnCancel = new ToolStripMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            lblCustomer = new Label();
            label2 = new Label();
            dgvOrderItems = new DataGridView();
            clmItem = new DataGridViewTextBoxColumn();
            clmUnit = new DataGridViewTextBoxColumn();
            clmQuantity = new DataGridViewTextBoxColumn();
            clmPrice = new DataGridViewTextBoxColumn();
            clmTotal = new DataGridViewTextBoxColumn();
            lblTotal = new Label();
            lblStatus = new Label();
            label4 = new Label();
            lblDateTime = new Label();
            lblOrderNumber = new Label();
            label1 = new Label();
            lblTitle = new Label();
            lblIcon = new Label();
            pnlSearch = new Panel();
            label3 = new Label();
            txtSearchCustomer = new TextBox();
            cmbStatus = new ComboBox();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            tsPages.SuspendLayout();
            tsMain.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderItems).BeginInit();
            pnlSearch.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvOrders);
            panel1.Controls.Add(tsPages);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(4, 4);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(716, 477);
            panel1.TabIndex = 0;
            // 
            // dgvOrders
            // 
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.AllowUserToDeleteRows = false;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Columns.AddRange(new DataGridViewColumn[] { clmOrderNumber, clmDate, clmStatus, clmOrderTotal, clmCustomer });
            dgvOrders.Dock = DockStyle.Fill;
            dgvOrders.Location = new System.Drawing.Point(0, 0);
            dgvOrders.Margin = new Padding(5);
            dgvOrders.MultiSelect = false;
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.RowHeadersWidth = 51;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.Size = new Size(716, 446);
            dgvOrders.TabIndex = 6;
            dgvOrders.SelectionChanged += dgvOrders_SelectionChanged;
            // 
            // clmOrderNumber
            // 
            clmOrderNumber.HeaderText = "Order";
            clmOrderNumber.MinimumWidth = 6;
            clmOrderNumber.Name = "clmOrderNumber";
            clmOrderNumber.ReadOnly = true;
            clmOrderNumber.Width = 150;
            // 
            // clmDate
            // 
            clmDate.HeaderText = "Date Created";
            clmDate.MinimumWidth = 6;
            clmDate.Name = "clmDate";
            clmDate.ReadOnly = true;
            clmDate.Width = 175;
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
            // clmOrderTotal
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            clmOrderTotal.DefaultCellStyle = dataGridViewCellStyle4;
            clmOrderTotal.HeaderText = "Total";
            clmOrderTotal.MinimumWidth = 6;
            clmOrderTotal.Name = "clmOrderTotal";
            clmOrderTotal.ReadOnly = true;
            clmOrderTotal.Width = 150;
            // 
            // clmCustomer
            // 
            clmCustomer.HeaderText = "Customer";
            clmCustomer.MinimumWidth = 6;
            clmCustomer.Name = "clmCustomer";
            clmCustomer.ReadOnly = true;
            clmCustomer.Width = 250;
            // 
            // tsPages
            // 
            tsPages.Dock = DockStyle.Bottom;
            tsPages.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tsPages.GripStyle = ToolStripGripStyle.Hidden;
            tsPages.ImageScalingSize = new Size(20, 20);
            tsPages.Items.AddRange(new ToolStripItem[] { toolStripLabel2, cmbPageSize, toolStripSeparator2, btnLast, btnNext, lblTotalPage, txtPage, toolStripLabel1, btnPrev, btnFirst, btnReload });
            tsPages.Location = new System.Drawing.Point(0, 446);
            tsPages.Name = "tsPages";
            tsPages.Size = new Size(716, 31);
            tsPages.TabIndex = 11;
            tsPages.Text = "toolStrip2";
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Alignment = ToolStripItemAlignment.Right;
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(137, 28);
            toolStripLabel2.Text = "rows per page";
            // 
            // cmbPageSize
            // 
            cmbPageSize.Alignment = ToolStripItemAlignment.Right;
            cmbPageSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPageSize.DropDownWidth = 75;
            cmbPageSize.Name = "cmbPageSize";
            cmbPageSize.Size = new Size(75, 31);
            cmbPageSize.SelectedIndexChanged += cmbPageSize_SelectedIndexChanged;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Alignment = ToolStripItemAlignment.Right;
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 31);
            // 
            // btnLast
            // 
            btnLast.Alignment = ToolStripItemAlignment.Right;
            btnLast.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnLast.Image = (Image)resources.GetObject("btnLast.Image");
            btnLast.ImageTransparentColor = Color.Magenta;
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(44, 28);
            btnLast.Text = ">>";
            btnLast.ToolTipText = "last page";
            btnLast.Click += btnLast_Click;
            // 
            // btnNext
            // 
            btnNext.Alignment = ToolStripItemAlignment.Right;
            btnNext.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnNext.Image = (Image)resources.GetObject("btnNext.Image");
            btnNext.ImageTransparentColor = Color.Magenta;
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(29, 28);
            btnNext.Text = ">";
            btnNext.ToolTipText = "next page";
            btnNext.Click += btnNext_Click;
            // 
            // lblTotalPage
            // 
            lblTotalPage.Alignment = ToolStripItemAlignment.Right;
            lblTotalPage.Name = "lblTotalPage";
            lblTotalPage.Size = new Size(44, 28);
            lblTotalPage.Text = "of 0";
            // 
            // txtPage
            // 
            txtPage.Alignment = ToolStripItemAlignment.Right;
            txtPage.Name = "txtPage";
            txtPage.Size = new Size(55, 31);
            txtPage.TextBoxTextAlign = HorizontalAlignment.Center;
            txtPage.KeyDown += txtPage_KeyDown;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Alignment = ToolStripItemAlignment.Right;
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(54, 28);
            toolStripLabel1.Text = "page";
            // 
            // btnPrev
            // 
            btnPrev.Alignment = ToolStripItemAlignment.Right;
            btnPrev.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnPrev.Image = (Image)resources.GetObject("btnPrev.Image");
            btnPrev.ImageTransparentColor = Color.Magenta;
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(29, 28);
            btnPrev.Text = "<";
            btnPrev.ToolTipText = "previous page";
            btnPrev.Click += btnPrev_Click;
            // 
            // btnFirst
            // 
            btnFirst.Alignment = ToolStripItemAlignment.Right;
            btnFirst.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnFirst.Image = (Image)resources.GetObject("btnFirst.Image");
            btnFirst.ImageTransparentColor = Color.Magenta;
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(44, 28);
            btnFirst.Text = "<<";
            btnFirst.ToolTipText = "first page";
            btnFirst.Click += btnFirst_Click;
            // 
            // btnReload
            // 
            btnReload.Image = Properties.Resources.reload_icon;
            btnReload.ImageTransparentColor = Color.Magenta;
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(123, 28);
            btnReload.Text = "Reload All";
            btnReload.Click += btnReload_Click;
            // 
            // tsMain
            // 
            tsMain.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tsMain.GripStyle = ToolStripGripStyle.Hidden;
            tsMain.ImageScalingSize = new Size(20, 20);
            tsMain.Items.AddRange(new ToolStripItem[] { btnAddNewOrder, toolStripDropDownButton1 });
            tsMain.Location = new System.Drawing.Point(0, 42);
            tsMain.Name = "tsMain";
            tsMain.Size = new Size(1768, 31);
            tsMain.TabIndex = 5;
            tsMain.Text = "toolStrip1";
            // 
            // btnAddNewOrder
            // 
            btnAddNewOrder.Image = Properties.Resources.add_order_icon;
            btnAddNewOrder.ImageTransparentColor = Color.Magenta;
            btnAddNewOrder.Name = "btnAddNewOrder";
            btnAddNewOrder.Size = new Size(169, 28);
            btnAddNewOrder.Text = "Add New Order";
            btnAddNewOrder.Click += btnAddNewOrder_Click;
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { btnModify, toolStripSeparator3, btnRelease, btnCancel });
            toolStripDropDownButton1.Image = Properties.Resources.update_order_icon;
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(164, 28);
            toolStripDropDownButton1.Text = "Update Order";
            // 
            // btnModify
            // 
            btnModify.Enabled = false;
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(214, 28);
            btnModify.Text = "Modify or Pay";
            btnModify.Click += btnModify_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(211, 6);
            // 
            // btnRelease
            // 
            btnRelease.Enabled = false;
            btnRelease.Name = "btnRelease";
            btnRelease.Size = new Size(214, 28);
            btnRelease.Text = "Release";
            btnRelease.Click += btnRelease_Click;
            // 
            // btnCancel
            // 
            btnCancel.Enabled = false;
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(214, 28);
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
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
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 73);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1768, 485);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblCustomer);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(dgvOrderItems);
            panel2.Controls.Add(lblTotal);
            panel2.Controls.Add(lblStatus);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(lblDateTime);
            panel2.Controls.Add(lblOrderNumber);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(728, 4);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(1036, 477);
            panel2.TabIndex = 1;
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomer.Location = new System.Drawing.Point(111, 63);
            lblCustomer.Margin = new Padding(4, 0, 4, 0);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(50, 25);
            lblCustomer.TabIndex = 40;
            lblCustomer.Text = "New";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(693, 426);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(85, 41);
            label2.TabIndex = 39;
            label2.Text = "Total";
            // 
            // dgvOrderItems
            // 
            dgvOrderItems.AllowUserToAddRows = false;
            dgvOrderItems.AllowUserToDeleteRows = false;
            dgvOrderItems.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvOrderItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderItems.Columns.AddRange(new DataGridViewColumn[] { clmItem, clmUnit, clmQuantity, clmPrice, clmTotal });
            dgvOrderItems.Location = new System.Drawing.Point(14, 99);
            dgvOrderItems.Margin = new Padding(4);
            dgvOrderItems.MultiSelect = false;
            dgvOrderItems.Name = "dgvOrderItems";
            dgvOrderItems.ReadOnly = true;
            dgvOrderItems.RowHeadersWidth = 51;
            dgvOrderItems.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvOrderItems.Size = new Size(1008, 323);
            dgvOrderItems.TabIndex = 38;
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
            clmQuantity.ReadOnly = true;
            clmQuantity.Width = 125;
            // 
            // clmPrice
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            clmPrice.DefaultCellStyle = dataGridViewCellStyle5;
            clmPrice.HeaderText = "Price";
            clmPrice.MinimumWidth = 6;
            clmPrice.Name = "clmPrice";
            clmPrice.ReadOnly = true;
            clmPrice.Width = 150;
            // 
            // clmTotal
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleRight;
            clmTotal.DefaultCellStyle = dataGridViewCellStyle6;
            clmTotal.HeaderText = "Total";
            clmTotal.MinimumWidth = 6;
            clmTotal.Name = "clmTotal";
            clmTotal.ReadOnly = true;
            clmTotal.Width = 175;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotal.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new System.Drawing.Point(786, 426);
            lblTotal.Margin = new Padding(4, 0, 4, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(236, 41);
            lblTotal.TabIndex = 36;
            lblTotal.Text = "0.00";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.Location = new System.Drawing.Point(82, 31);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(50, 25);
            lblStatus.TabIndex = 28;
            lblStatus.Text = "New";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(14, 31);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 27;
            label4.Text = "Status";
            // 
            // lblDateTime
            // 
            lblDateTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDateTime.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDateTime.Location = new System.Drawing.Point(750, 6);
            lblDateTime.Margin = new Padding(4, 0, 4, 0);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(272, 25);
            lblDateTime.TabIndex = 26;
            lblDateTime.Text = "Jan 1, 2025";
            lblDateTime.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblOrderNumber
            // 
            lblOrderNumber.AutoSize = true;
            lblOrderNumber.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderNumber.Location = new System.Drawing.Point(0, 0);
            lblOrderNumber.Margin = new Padding(4, 0, 4, 0);
            lblOrderNumber.Name = "lblOrderNumber";
            lblOrderNumber.Size = new Size(207, 31);
            lblOrderNumber.TabIndex = 23;
            lblOrderNumber.Text = "ORDER NO. 12345";
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
            // lblTitle
            // 
            lblTitle.BackColor = Color.DeepSkyBlue;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new System.Drawing.Point(0, 0);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1768, 42);
            lblTitle.TabIndex = 9;
            lblTitle.Text = "Manage Orders";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblIcon
            // 
            lblIcon.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblIcon.BackColor = Color.DeepSkyBlue;
            lblIcon.Image = Properties.Resources.orders_banner;
            lblIcon.Location = new System.Drawing.Point(1716, 0);
            lblIcon.Name = "lblIcon";
            lblIcon.Size = new Size(40, 40);
            lblIcon.TabIndex = 10;
            // 
            // pnlSearch
            // 
            pnlSearch.Controls.Add(label3);
            pnlSearch.Controls.Add(txtSearchCustomer);
            pnlSearch.Controls.Add(cmbStatus);
            pnlSearch.Controls.Add(panel3);
            pnlSearch.Dock = DockStyle.Bottom;
            pnlSearch.Location = new System.Drawing.Point(0, 558);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(1768, 95);
            pnlSearch.TabIndex = 11;
            pnlSearch.TabStop = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(47, 55);
            label3.Name = "label3";
            label3.Size = new Size(111, 25);
            label3.TabIndex = 6;
            label3.Text = "Order Status";
            // 
            // txtSearchCustomer
            // 
            txtSearchCustomer.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSearchCustomer.Location = new System.Drawing.Point(47, 14);
            txtSearchCustomer.Margin = new Padding(4);
            txtSearchCustomer.MaxLength = 100;
            txtSearchCustomer.Name = "txtSearchCustomer";
            txtSearchCustomer.PlaceholderText = "Customer name...";
            txtSearchCustomer.Size = new Size(1708, 31);
            txtSearchCustomer.TabIndex = 5;
            txtSearchCustomer.KeyDown += txtSearchCustomer_KeyDown;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new System.Drawing.Point(164, 52);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(277, 33);
            cmbStatus.TabIndex = 4;
            cmbStatus.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.search;
            panel3.BackgroundImageLayout = ImageLayout.Center;
            panel3.Location = new System.Drawing.Point(13, 14);
            panel3.Name = "panel3";
            panel3.Size = new Size(27, 27);
            panel3.TabIndex = 3;
            // 
            // frmOrders
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1768, 653);
            Controls.Add(lblIcon);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tsMain);
            Controls.Add(lblTitle);
            Controls.Add(pnlSearch);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MinimumSize = new Size(1300, 700);
            Name = "frmOrders";
            Text = "Orders";
            WindowState = FormWindowState.Maximized;
            Load += frmOrders_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            tsPages.ResumeLayout(false);
            tsPages.PerformLayout();
            tsMain.ResumeLayout(false);
            tsMain.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderItems).EndInit();
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private DataGridView dgvOrders;
        private ToolStrip tsMain;
        private ToolStripButton btnAddNewOrder;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Label lblTitle;
        private Label label1;
        private Label lblOrderNumber;
        private Label lblStatus;
        private Label label4;
        private Label lblDateTime;
        private Label lblTotal;
        private DataGridView dgvOrderItems;
        private DataGridViewTextBoxColumn clmItem;
        private DataGridViewTextBoxColumn clmUnit;
        private DataGridViewTextBoxColumn clmQuantity;
        private DataGridViewTextBoxColumn clmPrice;
        private DataGridViewTextBoxColumn clmTotal;
        private Label label2;
        private ToolStrip tsPages;
        private ToolStripLabel toolStripLabel2;
        private ToolStripComboBox cmbPageSize;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnLast;
        private ToolStripButton btnNext;
        private ToolStripLabel lblTotalPage;
        private ToolStripTextBox txtPage;
        private ToolStripLabel toolStripLabel1;
        private ToolStripButton btnPrev;
        private ToolStripButton btnFirst;
        private Label lblCustomer;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem btnModify;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem btnRelease;
        private ToolStripMenuItem btnCancel;
        private ToolStripLabel toolStripLabel3;
        private Label lblIcon;
        private DataGridViewTextBoxColumn clmOrderNumber;
        private DataGridViewTextBoxColumn clmDate;
        private DataGridViewTextBoxColumn clmStatus;
        private DataGridViewTextBoxColumn clmOrderTotal;
        private DataGridViewTextBoxColumn clmCustomer;
        private Panel pnlSearch;
        private Panel panel3;
        private ComboBox cmbStatus;
        private TextBox txtSearchCustomer;
        private Label label3;
        private ToolStripButton btnReload;
    }
}