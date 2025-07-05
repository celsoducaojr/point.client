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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSales));
            lblTitle = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            dgvOrders = new DataGridView();
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
            btnAddNewOrder = new ToolStripButton();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            btnModify = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            btnRelease = new ToolStripMenuItem();
            btnCancel = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            btnReload = new ToolStripButton();
            panel2 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            tsPages.SuspendLayout();
            tsMain.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.DeepSkyBlue;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new System.Drawing.Point(0, 0);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1586, 60);
            lblTitle.TabIndex = 11;
            lblTitle.Text = "Manage Sales";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 60);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1586, 797);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(dgvOrders);
            panel1.Controls.Add(tsPages);
            panel1.Controls.Add(tsMain);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(4, 4);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1578, 789);
            panel1.TabIndex = 0;
            // 
            // dgvOrders
            // 
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.AllowUserToDeleteRows = false;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Columns.AddRange(new DataGridViewColumn[] { clmOrderNumber, clmDateTime, clmStatus, clmOrderTotal, clmCustomer });
            dgvOrders.Location = new System.Drawing.Point(0, 31);
            dgvOrders.Margin = new Padding(5);
            dgvOrders.MultiSelect = false;
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.RowHeadersWidth = 51;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.Size = new Size(534, 726);
            dgvOrders.TabIndex = 6;
            // 
            // clmOrderNumber
            // 
            clmOrderNumber.HeaderText = "Order No.";
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            clmOrderTotal.DefaultCellStyle = dataGridViewCellStyle3;
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
            tsPages.Location = new System.Drawing.Point(0, 758);
            tsPages.Name = "tsPages";
            tsPages.Size = new Size(1578, 31);
            tsPages.TabIndex = 11;
            tsPages.Text = "toolStrip2";
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Alignment = ToolStripItemAlignment.Right;
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(137, 29);
            toolStripLabel2.Text = "rows per page";
            // 
            // cmbPageSize
            // 
            cmbPageSize.Alignment = ToolStripItemAlignment.Right;
            cmbPageSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPageSize.DropDownWidth = 75;
            cmbPageSize.Name = "cmbPageSize";
            cmbPageSize.Size = new Size(75, 32);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Alignment = ToolStripItemAlignment.Right;
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 32);
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
            // 
            // btnNext
            // 
            btnNext.Alignment = ToolStripItemAlignment.Right;
            btnNext.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnNext.Image = (Image)resources.GetObject("btnNext.Image");
            btnNext.ImageTransparentColor = Color.Magenta;
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(29, 29);
            btnNext.Text = ">";
            btnNext.ToolTipText = "next page";
            // 
            // lblTotalPage
            // 
            lblTotalPage.Alignment = ToolStripItemAlignment.Right;
            lblTotalPage.Name = "lblTotalPage";
            lblTotalPage.Size = new Size(44, 29);
            lblTotalPage.Text = "of 0";
            // 
            // txtPage
            // 
            txtPage.Alignment = ToolStripItemAlignment.Right;
            txtPage.Name = "txtPage";
            txtPage.Size = new Size(55, 32);
            txtPage.TextBoxTextAlign = HorizontalAlignment.Center;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Alignment = ToolStripItemAlignment.Right;
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(54, 24);
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
            // 
            // toolStripLabel3
            // 
            toolStripLabel3.Name = "toolStripLabel3";
            toolStripLabel3.Size = new Size(66, 24);
            toolStripLabel3.Text = "Status";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(121, 28);
            // 
            // tsMain
            // 
            tsMain.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tsMain.GripStyle = ToolStripGripStyle.Hidden;
            tsMain.ImageScalingSize = new Size(20, 20);
            tsMain.Items.AddRange(new ToolStripItem[] { btnAddNewOrder, toolStripDropDownButton1, toolStripSeparator1, btnReload });
            tsMain.Location = new System.Drawing.Point(0, 0);
            tsMain.Name = "tsMain";
            tsMain.Size = new Size(1578, 31);
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
            btnModify.Size = new Size(164, 28);
            btnModify.Text = "Modify";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(161, 6);
            // 
            // btnRelease
            // 
            btnRelease.Enabled = false;
            btnRelease.Name = "btnRelease";
            btnRelease.Size = new Size(164, 28);
            btnRelease.Text = "Release";
            // 
            // btnCancel
            // 
            btnCancel.Enabled = false;
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(164, 28);
            btnCancel.Text = "Cancel";
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
            // 
            // panel2
            // 
            panel2.Location = new System.Drawing.Point(841, 163);
            panel2.Name = "panel2";
            panel2.Size = new Size(243, 185);
            panel2.TabIndex = 12;
            // 
            // frmSales
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1586, 857);
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
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            tsPages.ResumeLayout(false);
            tsPages.PerformLayout();
            tsMain.ResumeLayout(false);
            tsMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitle;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private DataGridView dgvOrders;
        private DataGridViewTextBoxColumn clmOrderNumber;
        private DataGridViewTextBoxColumn clmDateTime;
        private DataGridViewTextBoxColumn clmStatus;
        private DataGridViewTextBoxColumn clmOrderTotal;
        private DataGridViewTextBoxColumn clmCustomer;
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
        private ToolStripLabel toolStripLabel3;
        private ToolStripComboBox cmbStatus;
        private ToolStrip tsMain;
        private ToolStripButton btnAddNewOrder;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem btnModify;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem btnRelease;
        private ToolStripMenuItem btnCancel;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnReload;
        private Panel panel2;
    }
}