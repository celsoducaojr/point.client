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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            btnPay = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            btnReload = new ToolStripButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            dgvSales = new DataGridView();
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
            toolStripLabel3 = new ToolStripLabel();
            cmbStatus = new ToolStripComboBox();
            tsMain = new ToolStrip();
            btnUpdate = new ToolStripDropDownButton();
            toolStripSeparator3 = new ToolStripSeparator();
            btnRefund = new ToolStripMenuItem();
            btnVoid = new ToolStripMenuItem();
            panel2 = new Panel();
            tabControl1 = new TabControl();
            tabSummary = new TabPage();
            panel3 = new Panel();
            txtRefunds = new TextBox();
            label7 = new Label();
            btnAddPayment = new Button();
            txtBalance = new TextBox();
            txtPayments = new TextBox();
            txtReceivables = new TextBox();
            lblOrderTerm = new Label();
            lblOrderLastPayment = new Label();
            lblLastPayment = new Label();
            lblTerm = new Label();
            label17 = new Label();
            label15 = new Label();
            label19 = new Label();
            tabItems = new TabPage();
            lblTotalItems = new Label();
            label6 = new Label();
            lblDiscount = new Label();
            label5 = new Label();
            lblSubTotal = new Label();
            label8 = new Label();
            dgvOrderItems = new DataGridView();
            clmItem = new DataGridViewTextBoxColumn();
            clmUnit = new DataGridViewTextBoxColumn();
            clmQuantity = new DataGridViewTextBoxColumn();
            clmPrice = new DataGridViewTextBoxColumn();
            clmTotal = new DataGridViewTextBoxColumn();
            tabPayments = new TabPage();
            lblTotalPayments = new Label();
            label13 = new Label();
            dgvPayments = new DataGridView();
            clmDateTime = new DataGridViewTextBoxColumn();
            clmAmount = new DataGridViewTextBoxColumn();
            clmMode = new DataGridViewTextBoxColumn();
            clmReference = new DataGridViewTextBoxColumn();
            clmRemarks = new DataGridViewTextBoxColumn();
            tabRefunds = new TabPage();
            dgvRefunds = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            clmRefundDateTime = new DataGridViewTextBoxColumn();
            clmRefundMode = new DataGridViewTextBoxColumn();
            clmRefundReference = new DataGridViewTextBoxColumn();
            clmRefundRemarks = new DataGridViewTextBoxColumn();
            lblTotalRefunds = new Label();
            label3 = new Label();
            lblDateTime = new Label();
            lblCustomer = new Label();
            lblStatus = new Label();
            label4 = new Label();
            lblOrderNumber = new Label();
            label1 = new Label();
            lblTitle = new Label();
            lblIcon = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSales).BeginInit();
            tsPages.SuspendLayout();
            tsMain.SuspendLayout();
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabSummary.SuspendLayout();
            panel3.SuspendLayout();
            tabItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderItems).BeginInit();
            tabPayments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPayments).BeginInit();
            tabRefunds.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRefunds).BeginInit();
            SuspendLayout();
            // 
            // btnPay
            // 
            btnPay.Enabled = false;
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(212, 28);
            btnPay.Text = "Add Payment";
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
            dgvSales.Columns.AddRange(new DataGridViewColumn[] { clmOrderNumber, clmDate, clmStatus, clmOrderTotal, clmCustomer });
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
            // clmDate
            // 
            clmDate.HeaderText = "Date Released";
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
            btnUpdate.DropDownItems.AddRange(new ToolStripItem[] { btnPay, toolStripSeparator3, btnRefund, btnVoid });
            btnUpdate.Image = Properties.Resources.update_sales_icon;
            btnUpdate.ImageTransparentColor = Color.Magenta;
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(108, 28);
            btnUpdate.Text = "Update";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(209, 6);
            // 
            // btnRefund
            // 
            btnRefund.Enabled = false;
            btnRefund.Name = "btnRefund";
            btnRefund.Size = new Size(212, 28);
            btnRefund.Text = "Refund";
            btnRefund.Click += refundToolStripMenuItem_Click;
            // 
            // btnVoid
            // 
            btnVoid.Enabled = false;
            btnVoid.Name = "btnVoid";
            btnVoid.Size = new Size(212, 28);
            btnVoid.Text = "Void";
            btnVoid.Click += btnVoid_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(tabControl1);
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
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabSummary);
            tabControl1.Controls.Add(tabItems);
            tabControl1.Controls.Add(tabPayments);
            tabControl1.Controls.Add(tabRefunds);
            tabControl1.Location = new System.Drawing.Point(18, 91);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1008, 599);
            tabControl1.TabIndex = 1;
            // 
            // tabSummary
            // 
            tabSummary.Controls.Add(panel3);
            tabSummary.Location = new System.Drawing.Point(4, 34);
            tabSummary.Name = "tabSummary";
            tabSummary.Padding = new Padding(3);
            tabSummary.Size = new Size(1000, 561);
            tabSummary.TabIndex = 2;
            tabSummary.Text = "Summary";
            tabSummary.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel3.BackColor = Color.WhiteSmoke;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(txtRefunds);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(btnAddPayment);
            panel3.Controls.Add(txtBalance);
            panel3.Controls.Add(txtPayments);
            panel3.Controls.Add(txtReceivables);
            panel3.Controls.Add(lblOrderTerm);
            panel3.Controls.Add(lblOrderLastPayment);
            panel3.Controls.Add(lblLastPayment);
            panel3.Controls.Add(lblTerm);
            panel3.Controls.Add(label17);
            panel3.Controls.Add(label15);
            panel3.Controls.Add(label19);
            panel3.Location = new System.Drawing.Point(28, 25);
            panel3.Margin = new Padding(25);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(10);
            panel3.Size = new Size(420, 508);
            panel3.TabIndex = 56;
            // 
            // txtRefunds
            // 
            txtRefunds.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRefunds.Location = new System.Drawing.Point(157, 93);
            txtRefunds.Name = "txtRefunds";
            txtRefunds.ReadOnly = true;
            txtRefunds.Size = new Size(248, 34);
            txtRefunds.TabIndex = 73;
            txtRefunds.Text = "0.00";
            txtRefunds.TextAlign = HorizontalAlignment.Right;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F);
            label7.Location = new System.Drawing.Point(40, 99);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(110, 25);
            label7.TabIndex = 74;
            label7.Text = "Total Refund";
            // 
            // btnAddPayment
            // 
            btnAddPayment.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddPayment.BackColor = Color.LimeGreen;
            btnAddPayment.Font = new Font("Segoe UI", 13.8F);
            btnAddPayment.Location = new System.Drawing.Point(13, 424);
            btnAddPayment.Name = "btnAddPayment";
            btnAddPayment.Size = new Size(392, 69);
            btnAddPayment.TabIndex = 4;
            btnAddPayment.Text = "Add Payment";
            btnAddPayment.UseVisualStyleBackColor = false;
            btnAddPayment.Visible = false;
            btnAddPayment.Click += btnPay_Click;
            // 
            // txtBalance
            // 
            txtBalance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBalance.Location = new System.Drawing.Point(157, 133);
            txtBalance.Name = "txtBalance";
            txtBalance.ReadOnly = true;
            txtBalance.Size = new Size(248, 34);
            txtBalance.TabIndex = 3;
            txtBalance.Text = "0.00";
            txtBalance.TextAlign = HorizontalAlignment.Right;
            // 
            // txtPayments
            // 
            txtPayments.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPayments.Location = new System.Drawing.Point(157, 53);
            txtPayments.Name = "txtPayments";
            txtPayments.ReadOnly = true;
            txtPayments.Size = new Size(248, 34);
            txtPayments.TabIndex = 2;
            txtPayments.Text = "0.00";
            txtPayments.TextAlign = HorizontalAlignment.Right;
            // 
            // txtReceivables
            // 
            txtReceivables.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtReceivables.Location = new System.Drawing.Point(157, 13);
            txtReceivables.Name = "txtReceivables";
            txtReceivables.ReadOnly = true;
            txtReceivables.Size = new Size(248, 34);
            txtReceivables.TabIndex = 1;
            txtReceivables.Text = "0.00";
            txtReceivables.TextAlign = HorizontalAlignment.Right;
            // 
            // lblOrderTerm
            // 
            lblOrderTerm.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblOrderTerm.Location = new System.Drawing.Point(157, 183);
            lblOrderTerm.Margin = new Padding(4, 0, 4, 0);
            lblOrderTerm.Name = "lblOrderTerm";
            lblOrderTerm.Size = new Size(248, 38);
            lblOrderTerm.TabIndex = 69;
            lblOrderTerm.Text = "Term";
            lblOrderTerm.TextAlign = ContentAlignment.MiddleLeft;
            lblOrderTerm.Visible = false;
            // 
            // lblOrderLastPayment
            // 
            lblOrderLastPayment.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblOrderLastPayment.Location = new System.Drawing.Point(157, 221);
            lblOrderLastPayment.Margin = new Padding(4, 0, 4, 0);
            lblOrderLastPayment.Name = "lblOrderLastPayment";
            lblOrderLastPayment.Size = new Size(248, 38);
            lblOrderLastPayment.TabIndex = 70;
            lblOrderLastPayment.Text = "Last Payment";
            lblOrderLastPayment.TextAlign = ContentAlignment.MiddleLeft;
            lblOrderLastPayment.Visible = false;
            // 
            // lblLastPayment
            // 
            lblLastPayment.AutoSize = true;
            lblLastPayment.Font = new Font("Segoe UI", 10.8F);
            lblLastPayment.Location = new System.Drawing.Point(33, 228);
            lblLastPayment.Margin = new Padding(4, 0, 4, 0);
            lblLastPayment.Name = "lblLastPayment";
            lblLastPayment.Size = new Size(116, 25);
            lblLastPayment.TabIndex = 68;
            lblLastPayment.Text = "Last Payment";
            lblLastPayment.Visible = false;
            // 
            // lblTerm
            // 
            lblTerm.AutoSize = true;
            lblTerm.Font = new Font("Segoe UI", 10.8F);
            lblTerm.Location = new System.Drawing.Point(99, 190);
            lblTerm.Margin = new Padding(4, 0, 4, 0);
            lblTerm.Name = "lblTerm";
            lblTerm.Size = new Size(50, 25);
            lblTerm.TabIndex = 67;
            lblTerm.Text = "Term";
            lblTerm.Visible = false;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 10.8F);
            label17.Location = new System.Drawing.Point(28, 59);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(122, 25);
            label17.TabIndex = 63;
            label17.Text = "Total Payment";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10.8F);
            label15.Location = new System.Drawing.Point(79, 139);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(71, 25);
            label15.TabIndex = 65;
            label15.Text = "Balance";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 10.8F);
            label19.Location = new System.Drawing.Point(14, 19);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(136, 25);
            label19.TabIndex = 61;
            label19.Text = "Total Receivable";
            // 
            // tabItems
            // 
            tabItems.Controls.Add(lblTotalItems);
            tabItems.Controls.Add(label6);
            tabItems.Controls.Add(lblDiscount);
            tabItems.Controls.Add(label5);
            tabItems.Controls.Add(lblSubTotal);
            tabItems.Controls.Add(label8);
            tabItems.Controls.Add(dgvOrderItems);
            tabItems.Location = new System.Drawing.Point(4, 29);
            tabItems.Name = "tabItems";
            tabItems.Padding = new Padding(3);
            tabItems.Size = new Size(1000, 566);
            tabItems.TabIndex = 0;
            tabItems.Text = "Items";
            tabItems.UseVisualStyleBackColor = true;
            // 
            // lblTotalItems
            // 
            lblTotalItems.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotalItems.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblTotalItems.Location = new System.Drawing.Point(822, 520);
            lblTotalItems.Margin = new Padding(4, 0, 4, 0);
            lblTotalItems.Name = "lblTotalItems";
            lblTotalItems.Size = new Size(171, 38);
            lblTotalItems.TabIndex = 54;
            lblTotalItems.Text = "0.00";
            lblTotalItems.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label6.Location = new System.Drawing.Point(765, 527);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(54, 25);
            label6.TabIndex = 53;
            label6.Text = "Total";
            // 
            // lblDiscount
            // 
            lblDiscount.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblDiscount.Font = new Font("Segoe UI", 10.8F);
            lblDiscount.Location = new System.Drawing.Point(822, 482);
            lblDiscount.Margin = new Padding(4, 0, 4, 0);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(171, 38);
            lblDiscount.TabIndex = 52;
            lblDiscount.Text = "0.00";
            lblDiscount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F);
            label5.Location = new System.Drawing.Point(732, 489);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(82, 25);
            label5.TabIndex = 51;
            label5.Text = "Discount";
            // 
            // lblSubTotal
            // 
            lblSubTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblSubTotal.Font = new Font("Segoe UI", 10.8F);
            lblSubTotal.Location = new System.Drawing.Point(822, 444);
            lblSubTotal.Margin = new Padding(4, 0, 4, 0);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(171, 38);
            lblSubTotal.TabIndex = 48;
            lblSubTotal.Text = "0.00";
            lblSubTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F);
            label8.Location = new System.Drawing.Point(728, 451);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(85, 25);
            label8.TabIndex = 47;
            label8.Text = "Sub Total";
            // 
            // dgvOrderItems
            // 
            dgvOrderItems.AllowUserToAddRows = false;
            dgvOrderItems.AllowUserToDeleteRows = false;
            dgvOrderItems.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvOrderItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderItems.Columns.AddRange(new DataGridViewColumn[] { clmItem, clmUnit, clmQuantity, clmPrice, clmTotal });
            dgvOrderItems.Location = new System.Drawing.Point(7, 7);
            dgvOrderItems.Margin = new Padding(4);
            dgvOrderItems.MultiSelect = false;
            dgvOrderItems.Name = "dgvOrderItems";
            dgvOrderItems.ReadOnly = true;
            dgvOrderItems.RowHeadersWidth = 51;
            dgvOrderItems.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvOrderItems.Size = new Size(986, 433);
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
            // tabPayments
            // 
            tabPayments.Controls.Add(lblTotalPayments);
            tabPayments.Controls.Add(label13);
            tabPayments.Controls.Add(dgvPayments);
            tabPayments.Location = new System.Drawing.Point(4, 29);
            tabPayments.Name = "tabPayments";
            tabPayments.Padding = new Padding(3);
            tabPayments.Size = new Size(1000, 566);
            tabPayments.TabIndex = 1;
            tabPayments.Text = "Payments";
            tabPayments.UseVisualStyleBackColor = true;
            // 
            // lblTotalPayments
            // 
            lblTotalPayments.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotalPayments.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblTotalPayments.Location = new System.Drawing.Point(822, 520);
            lblTotalPayments.Margin = new Padding(4, 0, 4, 0);
            lblTotalPayments.Name = "lblTotalPayments";
            lblTotalPayments.Size = new Size(171, 38);
            lblTotalPayments.TabIndex = 56;
            lblTotalPayments.Text = "0.00";
            lblTotalPayments.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label13.Location = new System.Drawing.Point(765, 527);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(54, 25);
            label13.TabIndex = 55;
            label13.Text = "Total";
            // 
            // dgvPayments
            // 
            dgvPayments.AllowUserToAddRows = false;
            dgvPayments.AllowUserToDeleteRows = false;
            dgvPayments.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPayments.Columns.AddRange(new DataGridViewColumn[] { clmDateTime, clmAmount, clmMode, clmReference, clmRemarks });
            dgvPayments.Location = new System.Drawing.Point(7, 7);
            dgvPayments.Margin = new Padding(4);
            dgvPayments.MultiSelect = false;
            dgvPayments.Name = "dgvPayments";
            dgvPayments.ReadOnly = true;
            dgvPayments.RowHeadersWidth = 51;
            dgvPayments.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvPayments.Size = new Size(986, 509);
            dgvPayments.TabIndex = 47;
            // 
            // clmDateTime
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            clmDateTime.DefaultCellStyle = dataGridViewCellStyle4;
            clmDateTime.HeaderText = "Date & Time";
            clmDateTime.MinimumWidth = 6;
            clmDateTime.Name = "clmDateTime";
            clmDateTime.ReadOnly = true;
            clmDateTime.Width = 220;
            // 
            // clmAmount
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight;
            clmAmount.DefaultCellStyle = dataGridViewCellStyle5;
            clmAmount.HeaderText = "Amount";
            clmAmount.MinimumWidth = 6;
            clmAmount.Name = "clmAmount";
            clmAmount.ReadOnly = true;
            clmAmount.Width = 175;
            // 
            // clmMode
            // 
            clmMode.HeaderText = "Mode";
            clmMode.MinimumWidth = 6;
            clmMode.Name = "clmMode";
            clmMode.ReadOnly = true;
            clmMode.Width = 200;
            // 
            // clmReference
            // 
            clmReference.HeaderText = "Reference";
            clmReference.MinimumWidth = 6;
            clmReference.Name = "clmReference";
            clmReference.ReadOnly = true;
            clmReference.Width = 125;
            // 
            // clmRemarks
            // 
            clmRemarks.HeaderText = "Remarks";
            clmRemarks.MinimumWidth = 6;
            clmRemarks.Name = "clmRemarks";
            clmRemarks.ReadOnly = true;
            clmRemarks.Width = 250;
            // 
            // tabRefunds
            // 
            tabRefunds.Controls.Add(dgvRefunds);
            tabRefunds.Controls.Add(lblTotalRefunds);
            tabRefunds.Controls.Add(label3);
            tabRefunds.Location = new System.Drawing.Point(4, 29);
            tabRefunds.Name = "tabRefunds";
            tabRefunds.Padding = new Padding(3);
            tabRefunds.Size = new Size(1000, 566);
            tabRefunds.TabIndex = 3;
            tabRefunds.Text = "Refunds";
            tabRefunds.UseVisualStyleBackColor = true;
            // 
            // dgvRefunds
            // 
            dgvRefunds.AllowUserToAddRows = false;
            dgvRefunds.AllowUserToDeleteRows = false;
            dgvRefunds.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRefunds.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRefunds.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, clmRefundDateTime, clmRefundMode, clmRefundReference, clmRefundRemarks });
            dgvRefunds.Location = new System.Drawing.Point(7, 7);
            dgvRefunds.Margin = new Padding(4);
            dgvRefunds.MultiSelect = false;
            dgvRefunds.Name = "dgvRefunds";
            dgvRefunds.ReadOnly = true;
            dgvRefunds.RowHeadersWidth = 51;
            dgvRefunds.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvRefunds.Size = new Size(986, 509);
            dgvRefunds.TabIndex = 59;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Item";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 300;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Unit";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Quantity";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewTextBoxColumn4.HeaderText = "Price";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewTextBoxColumn5.HeaderText = "Total";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 175;
            // 
            // clmRefundDateTime
            // 
            clmRefundDateTime.HeaderText = "Date & Time";
            clmRefundDateTime.MinimumWidth = 6;
            clmRefundDateTime.Name = "clmRefundDateTime";
            clmRefundDateTime.ReadOnly = true;
            clmRefundDateTime.Width = 220;
            // 
            // clmRefundMode
            // 
            clmRefundMode.HeaderText = "Mode";
            clmRefundMode.MinimumWidth = 6;
            clmRefundMode.Name = "clmRefundMode";
            clmRefundMode.ReadOnly = true;
            clmRefundMode.Width = 200;
            // 
            // clmRefundReference
            // 
            clmRefundReference.HeaderText = "Reference";
            clmRefundReference.MinimumWidth = 6;
            clmRefundReference.Name = "clmRefundReference";
            clmRefundReference.ReadOnly = true;
            clmRefundReference.Width = 125;
            // 
            // clmRefundRemarks
            // 
            clmRefundRemarks.HeaderText = "Remarks";
            clmRefundRemarks.MinimumWidth = 6;
            clmRefundRemarks.Name = "clmRefundRemarks";
            clmRefundRemarks.ReadOnly = true;
            clmRefundRemarks.Width = 250;
            // 
            // lblTotalRefunds
            // 
            lblTotalRefunds.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotalRefunds.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            lblTotalRefunds.Location = new System.Drawing.Point(822, 520);
            lblTotalRefunds.Margin = new Padding(4, 0, 4, 0);
            lblTotalRefunds.Name = "lblTotalRefunds";
            lblTotalRefunds.Size = new Size(171, 38);
            lblTotalRefunds.TabIndex = 58;
            lblTotalRefunds.Text = "0.00";
            lblTotalRefunds.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label3.Location = new System.Drawing.Point(765, 527);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 57;
            label3.Text = "Total";
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
            tabSummary.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tabItems.ResumeLayout(false);
            tabItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderItems).EndInit();
            tabPayments.ResumeLayout(false);
            tabPayments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPayments).EndInit();
            tabRefunds.ResumeLayout(false);
            tabRefunds.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRefunds).EndInit();
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
        private ToolStripMenuItem btnRefund;
        private ToolStripLabel toolStripLabel3;
        private Label lblIcon;
        private Label lblCustomer;
        private Label lblStatus;
        private Label label4;
        private Label lblOrderNumber;
        private Label label1;
        private Label lblDateTime;
        private TabControl tabControl1;
        private TabPage tabItems;
        private DataGridView dgvOrderItems;
        private DataGridViewTextBoxColumn clmItem;
        private DataGridViewTextBoxColumn clmUnit;
        private DataGridViewTextBoxColumn clmQuantity;
        private DataGridViewTextBoxColumn clmPrice;
        private DataGridViewTextBoxColumn clmTotal;
        private TabPage tabPayments;
        private Label lblTotalItems;
        private Label label6;
        private Label lblDiscount;
        private Label label5;
        private Label lblSubTotal;
        private Label label8;
        private DataGridView dgvPayments;
        private TabPage tabSummary;
        private Label lblTerm;
        private Panel panel3;
        private Label label17;
        private Label label15;
        private Label label19;
        private Label lblOrderTerm;
        private Label lblOrderLastPayment;
        private Label lblLastPayment;
        private TextBox txtBalance;
        private TextBox txtPayments;
        private TextBox txtReceivables;
        private Label lblTotalPayments;
        private Label label13;
        private Button btnAddPayment;
        private DataGridViewTextBoxColumn clmOrderNumber;
        private DataGridViewTextBoxColumn clmDate;
        private DataGridViewTextBoxColumn clmStatus;
        private DataGridViewTextBoxColumn clmOrderTotal;
        private DataGridViewTextBoxColumn clmCustomer;
        private TabPage tabRefunds;
        private Label lblTotalRefunds;
        private Label label3;
        private DataGridView dgvRefunds;
        private DataGridViewTextBoxColumn clmDateTime;
        private DataGridViewTextBoxColumn clmAmount;
        private DataGridViewTextBoxColumn clmMode;
        private DataGridViewTextBoxColumn clmReference;
        private DataGridViewTextBoxColumn clmRemarks;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn clmRefundDateTime;
        private DataGridViewTextBoxColumn clmRefundMode;
        private DataGridViewTextBoxColumn clmRefundReference;
        private DataGridViewTextBoxColumn clmRefundRemarks;
        private TextBox txtRefunds;
        private Label label7;
    }
}