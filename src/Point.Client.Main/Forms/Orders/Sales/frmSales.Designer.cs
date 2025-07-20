namespace Point.Client.Main.Forms.Sales
{
    partial class frmSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSales));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnPay = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            btnReload = new ToolStripButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            dgvSales = new DataGridView();
            clmOrderNumber = new DataGridViewTextBoxColumn();
            clmDateTime = new DataGridViewTextBoxColumn();
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
            toolStripLabel3 = new ToolStripLabel();
            cmbStatus = new ToolStripComboBox();
            tsMain = new ToolStrip();
            btnUpdate = new ToolStripDropDownButton();
            toolStripSeparator3 = new ToolStripSeparator();
            refundToolStripMenuItem = new ToolStripMenuItem();
            btnVoid = new ToolStripMenuItem();
            panel2 = new Panel();
            label2 = new Label();
            lblTotal = new Label();
            label11 = new Label();
            lblDiscount = new Label();
            lblSubTotal = new Label();
            label8 = new Label();
            lblDateTime = new Label();
            lblCustomer = new Label();
            lblStatus = new Label();
            label4 = new Label();
            lblOrderNumber = new Label();
            label1 = new Label();
            lblTitle = new Label();
            lblIcon = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            dgvOrderItems = new DataGridView();
            clmItem = new DataGridViewTextBoxColumn();
            clmUnit = new DataGridViewTextBoxColumn();
            clmQuantity = new DataGridViewTextBoxColumn();
            clmPrice = new DataGridViewTextBoxColumn();
            clmTotal = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSales).BeginInit();
            tsPages.SuspendLayout();
            tsMain.SuspendLayout();
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderItems).BeginInit();
            SuspendLayout();
            // 
            // btnPay
            // 
            btnPay.Enabled = false;
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(156, 28);
            btnPay.Text = "Pay";
            btnPay.Click += btnPay_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 31);
            // 
            // btnReload
            // 
            btnReload.Image = Properties.Resources.reload_icon;
            btnReload.ImageTransparentColor = Color.Magenta;
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(95, 28);
            btnReload.Text = "Reload";
            btnReload.Click += btnReload_Click;
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
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 60);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1770, 705);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvSales);
            panel1.Controls.Add(tsPages);
            panel1.Controls.Add(tsMain);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(4, 4);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(720, 697);
            panel1.TabIndex = 0;
            // 
            // dgvSales
            // 
            dgvSales.AllowUserToAddRows = false;
            dgvSales.AllowUserToDeleteRows = false;
            dgvSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSales.Columns.AddRange(new DataGridViewColumn[] { clmOrderNumber, clmDateTime, clmStatus, clmOrderTotal, clmCustomer });
            dgvSales.Dock = DockStyle.Fill;
            dgvSales.Location = new System.Drawing.Point(0, 31);
            dgvSales.Margin = new Padding(5);
            dgvSales.MultiSelect = false;
            dgvSales.Name = "dgvSales";
            dgvSales.ReadOnly = true;
            dgvSales.RowHeadersWidth = 51;
            dgvSales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSales.Size = new Size(720, 635);
            dgvSales.TabIndex = 6;
            dgvSales.SelectionChanged += dgvSales_SelectionChanged;
            // 
            // clmOrderNumber
            // 
            clmOrderNumber.HeaderText = "Order";
            clmOrderNumber.MinimumWidth = 6;
            clmOrderNumber.Name = "clmOrderNumber";
            clmOrderNumber.ReadOnly = true;
            clmOrderNumber.Width = 150;
            // 
            // clmDateTime
            // 
            clmDateTime.HeaderText = "Date & Time";
            clmDateTime.MinimumWidth = 6;
            clmDateTime.Name = "clmDateTime";
            clmDateTime.ReadOnly = true;
            clmDateTime.Width = 165;
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            clmOrderTotal.DefaultCellStyle = dataGridViewCellStyle1;
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
            tsPages.Items.AddRange(new ToolStripItem[] { toolStripLabel2, cmbPageSize, toolStripSeparator2, btnLast, btnNext, lblTotalPage, txtPage, toolStripLabel1, btnPrev, btnFirst, toolStripLabel3, cmbStatus });
            tsPages.Location = new System.Drawing.Point(0, 666);
            tsPages.Name = "tsPages";
            tsPages.Size = new Size(720, 31);
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
            // toolStripLabel3
            // 
            toolStripLabel3.Name = "toolStripLabel3";
            toolStripLabel3.Size = new Size(66, 28);
            toolStripLabel3.Text = "Status";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(121, 31);
            cmbStatus.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;
            // 
            // tsMain
            // 
            tsMain.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tsMain.GripStyle = ToolStripGripStyle.Hidden;
            tsMain.ImageScalingSize = new Size(20, 20);
            tsMain.Items.AddRange(new ToolStripItem[] { btnUpdate, toolStripSeparator1, btnReload });
            tsMain.Location = new System.Drawing.Point(0, 0);
            tsMain.Name = "tsMain";
            tsMain.Size = new Size(720, 31);
            tsMain.TabIndex = 5;
            tsMain.Text = "toolStrip1";
            // 
            // btnUpdate
            // 
            btnUpdate.DropDownItems.AddRange(new ToolStripItem[] { btnPay, toolStripSeparator3, refundToolStripMenuItem, btnVoid });
            btnUpdate.Image = Properties.Resources.update_sales_icon;
            btnUpdate.ImageTransparentColor = Color.Magenta;
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(161, 28);
            btnUpdate.Text = "Update Sales";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(153, 6);
            // 
            // refundToolStripMenuItem
            // 
            refundToolStripMenuItem.Enabled = false;
            refundToolStripMenuItem.Name = "refundToolStripMenuItem";
            refundToolStripMenuItem.Size = new Size(156, 28);
            refundToolStripMenuItem.Text = "Refund";
            refundToolStripMenuItem.Click += refundToolStripMenuItem_Click;
            // 
            // btnVoid
            // 
            btnVoid.Enabled = false;
            btnVoid.Name = "btnVoid";
            btnVoid.Size = new Size(156, 28);
            btnVoid.Text = "Void";
            btnVoid.Click += btnVoid_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(tabControl1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(lblTotal);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(lblDiscount);
            panel2.Controls.Add(lblSubTotal);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(lblDateTime);
            panel2.Controls.Add(lblCustomer);
            panel2.Controls.Add(lblStatus);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(lblOrderNumber);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(731, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1036, 699);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(697, 652);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(85, 41);
            label2.TabIndex = 53;
            label2.Text = "Total";
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotal.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new System.Drawing.Point(790, 652);
            lblTotal.Margin = new Padding(4, 0, 4, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(236, 41);
            lblTotal.TabIndex = 52;
            lblTotal.Text = "0.00";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new System.Drawing.Point(656, 615);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(126, 38);
            label11.TabIndex = 51;
            label11.Text = "Discount";
            // 
            // lblDiscount
            // 
            lblDiscount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblDiscount.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiscount.Location = new System.Drawing.Point(790, 614);
            lblDiscount.Margin = new Padding(4, 0, 4, 0);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(236, 38);
            lblDiscount.TabIndex = 50;
            lblDiscount.Text = "0.00";
            lblDiscount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSubTotal
            // 
            lblSubTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblSubTotal.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubTotal.Location = new System.Drawing.Point(790, 576);
            lblSubTotal.Margin = new Padding(4, 0, 4, 0);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(236, 38);
            lblSubTotal.TabIndex = 49;
            lblSubTotal.Text = "0.00";
            lblSubTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new System.Drawing.Point(652, 577);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(130, 38);
            label8.TabIndex = 48;
            label8.Text = "Sub Total";
            // 
            // lblDateTime
            // 
            lblDateTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDateTime.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDateTime.Location = new System.Drawing.Point(781, 7);
            lblDateTime.Margin = new Padding(4, 0, 4, 0);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(245, 25);
            lblDateTime.TabIndex = 47;
            lblDateTime.Text = "Jan 1, 2025";
            lblDateTime.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomer.Location = new System.Drawing.Point(115, 63);
            lblCustomer.Margin = new Padding(4, 0, 4, 0);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(50, 25);
            lblCustomer.TabIndex = 46;
            lblCustomer.Text = "New";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.Location = new System.Drawing.Point(86, 31);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(50, 25);
            lblStatus.TabIndex = 44;
            lblStatus.Text = "New";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(18, 31);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 43;
            label4.Text = "Status";
            // 
            // lblOrderNumber
            // 
            lblOrderNumber.AutoSize = true;
            lblOrderNumber.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderNumber.Location = new System.Drawing.Point(4, 0);
            lblOrderNumber.Margin = new Padding(4, 0, 4, 0);
            lblOrderNumber.Name = "lblOrderNumber";
            lblOrderNumber.Size = new Size(207, 31);
            lblOrderNumber.TabIndex = 42;
            lblOrderNumber.Text = "ORDER NO. 12345";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(18, 63);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 41;
            label1.Text = "Customer";
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.DeepSkyBlue;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new System.Drawing.Point(0, 0);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1770, 60);
            lblTitle.TabIndex = 11;
            lblTitle.Text = "Manage Sales";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblIcon
            // 
            lblIcon.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblIcon.BackColor = Color.DeepSkyBlue;
            lblIcon.Image = Properties.Resources.sales;
            lblIcon.Location = new System.Drawing.Point(1698, 0);
            lblIcon.Name = "lblIcon";
            lblIcon.Size = new Size(60, 60);
            lblIcon.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new System.Drawing.Point(18, 91);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1008, 482);
            tabControl1.TabIndex = 54;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvOrderItems);
            tabPage1.Location = new System.Drawing.Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1000, 444);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new System.Drawing.Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(242, 87);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvOrderItems
            // 
            dgvOrderItems.AllowUserToAddRows = false;
            dgvOrderItems.AllowUserToDeleteRows = false;
            dgvOrderItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderItems.Columns.AddRange(new DataGridViewColumn[] { clmItem, clmUnit, clmQuantity, clmPrice, clmTotal });
            dgvOrderItems.Dock = DockStyle.Fill;
            dgvOrderItems.Location = new System.Drawing.Point(3, 3);
            dgvOrderItems.Margin = new Padding(4);
            dgvOrderItems.MultiSelect = false;
            dgvOrderItems.Name = "dgvOrderItems";
            dgvOrderItems.ReadOnly = true;
            dgvOrderItems.RowHeadersWidth = 51;
            dgvOrderItems.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvOrderItems.Size = new Size(994, 438);
            dgvOrderItems.TabIndex = 46;
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
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            clmPrice.DefaultCellStyle = dataGridViewCellStyle2;
            clmPrice.HeaderText = "Price";
            clmPrice.MinimumWidth = 6;
            clmPrice.Name = "clmPrice";
            clmPrice.ReadOnly = true;
            clmPrice.Width = 150;
            // 
            // clmTotal
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            clmTotal.DefaultCellStyle = dataGridViewCellStyle3;
            clmTotal.HeaderText = "Total";
            clmTotal.MinimumWidth = 6;
            clmTotal.Name = "clmTotal";
            clmTotal.ReadOnly = true;
            clmTotal.Width = 175;
            // 
            // frmSales
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1770, 765);
            Controls.Add(lblIcon);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MinimumSize = new Size(1300, 700);
            Name = "frmSales";
            Text = "Sales";
            WindowState = FormWindowState.Maximized;
            Load += frmSales_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSales).EndInit();
            tsPages.ResumeLayout(false);
            tsPages.PerformLayout();
            tsMain.ResumeLayout(false);
            tsMain.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOrderItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripMenuItem btnPay;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnReload;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private DataGridView dgvSales;
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
        private ToolStripComboBox cmbStatus;
        private ToolStrip tsMain;
        private ToolStripButton btnAddNewOrder;
        private ToolStripDropDownButton btnUpdate;
        private ToolStripMenuItem btnModify;
        private ToolStripMenuItem btnCancel;
        private Label lblTitle;
        private Panel panel2;
        private ToolStripMenuItem btnVoid;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem refundToolStripMenuItem;
        private ToolStripLabel toolStripLabel3;
        private DataGridViewTextBoxColumn clmOrderNumber;
        private DataGridViewTextBoxColumn clmDateTime;
        private DataGridViewTextBoxColumn clmStatus;
        private DataGridViewTextBoxColumn clmOrderTotal;
        private DataGridViewTextBoxColumn clmCustomer;
        private Label lblIcon;
        private Label lblCustomer;
        private Label lblStatus;
        private Label label4;
        private Label lblOrderNumber;
        private Label label1;
        private Label lblDateTime;
        private Label label2;
        private Label lblTotal;
        private Label label11;
        private Label lblDiscount;
        private Label lblSubTotal;
        private Label label8;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dgvOrderItems;
        private DataGridViewTextBoxColumn clmItem;
        private DataGridViewTextBoxColumn clmUnit;
        private DataGridViewTextBoxColumn clmQuantity;
        private DataGridViewTextBoxColumn clmPrice;
        private DataGridViewTextBoxColumn clmTotal;
        private TabPage tabPage2;
    }
}