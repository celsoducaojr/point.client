namespace Point.Client.Main.Stocks
{
    partial class frmStocks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStocks));
            lblTitle = new Label();
            label1 = new Label();
            dgvStocks = new DataGridView();
            clmItem = new DataGridViewTextBoxColumn();
            clmCategory = new DataGridViewTextBoxColumn();
            clmUnit = new DataGridViewTextBoxColumn();
            clmQuantity = new DataGridViewTextBoxColumn();
            pnlSearch = new Panel();
            panel1 = new Panel();
            linkLabel1 = new LinkLabel();
            txtItem = new TextBox();
            panel2 = new Panel();
            dgvHistories = new DataGridView();
            clmDateTime = new DataGridViewTextBoxColumn();
            clmChanged = new DataGridViewTextBoxColumn();
            clmAfterChange = new DataGridViewTextBoxColumn();
            clmRemarks = new DataGridViewTextBoxColumn();
            label4 = new Label();
            panel3 = new Panel();
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
            tsMenu = new ToolStrip();
            btnAdd = new ToolStripButton();
            btnRemove = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)dgvStocks).BeginInit();
            pnlSearch.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistories).BeginInit();
            panel3.SuspendLayout();
            tsPages.SuspendLayout();
            tsMenu.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.DeepSkyBlue;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new System.Drawing.Point(0, 0);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1598, 42);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Manage Stocks";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.BackColor = Color.DeepSkyBlue;
            label1.Image = Properties.Resources.stocks_banner;
            label1.Location = new System.Drawing.Point(1546, 2);
            label1.Name = "label1";
            label1.Size = new Size(40, 40);
            label1.TabIndex = 11;
            // 
            // dgvStocks
            // 
            dgvStocks.AllowUserToAddRows = false;
            dgvStocks.AllowUserToDeleteRows = false;
            dgvStocks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStocks.Columns.AddRange(new DataGridViewColumn[] { clmItem, clmCategory, clmUnit, clmQuantity });
            dgvStocks.Dock = DockStyle.Fill;
            dgvStocks.Location = new System.Drawing.Point(0, 0);
            dgvStocks.Margin = new Padding(4);
            dgvStocks.MultiSelect = false;
            dgvStocks.Name = "dgvStocks";
            dgvStocks.ReadOnly = true;
            dgvStocks.RowHeadersWidth = 51;
            dgvStocks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStocks.Size = new Size(791, 516);
            dgvStocks.TabIndex = 1;
            dgvStocks.SelectionChanged += dgvStocks_SelectionChanged;
            // 
            // clmItem
            // 
            clmItem.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clmItem.HeaderText = "Item";
            clmItem.MinimumWidth = 6;
            clmItem.Name = "clmItem";
            clmItem.ReadOnly = true;
            // 
            // clmCategory
            // 
            clmCategory.HeaderText = "Category";
            clmCategory.MinimumWidth = 6;
            clmCategory.Name = "clmCategory";
            clmCategory.ReadOnly = true;
            clmCategory.Width = 125;
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
            clmQuantity.MaxInputLength = 50;
            clmQuantity.MinimumWidth = 6;
            clmQuantity.Name = "clmQuantity";
            clmQuantity.ReadOnly = true;
            clmQuantity.Width = 125;
            // 
            // pnlSearch
            // 
            pnlSearch.Controls.Add(panel1);
            pnlSearch.Controls.Add(linkLabel1);
            pnlSearch.Controls.Add(txtItem);
            pnlSearch.Dock = DockStyle.Bottom;
            pnlSearch.Location = new System.Drawing.Point(0, 620);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(1598, 85);
            pnlSearch.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.search;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Location = new System.Drawing.Point(13, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(27, 27);
            panel1.TabIndex = 3;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new System.Drawing.Point(13, 45);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(121, 20);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Advance search...";
            // 
            // txtItem
            // 
            txtItem.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtItem.Location = new System.Drawing.Point(47, 14);
            txtItem.Margin = new Padding(4);
            txtItem.MaxLength = 100;
            txtItem.Name = "txtItem";
            txtItem.PlaceholderText = "Search item...";
            txtItem.Size = new Size(1537, 27);
            txtItem.TabIndex = 1;
            txtItem.KeyDown += txtItem_KeyDown;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvHistories);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new System.Drawing.Point(791, 73);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(807, 547);
            panel2.TabIndex = 4;
            // 
            // dgvHistories
            // 
            dgvHistories.AllowUserToAddRows = false;
            dgvHistories.AllowUserToDeleteRows = false;
            dgvHistories.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvHistories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistories.Columns.AddRange(new DataGridViewColumn[] { clmDateTime, clmChanged, clmAfterChange, clmRemarks });
            dgvHistories.Location = new System.Drawing.Point(14, 42);
            dgvHistories.Margin = new Padding(4);
            dgvHistories.Name = "dgvHistories";
            dgvHistories.ReadOnly = true;
            dgvHistories.RowHeadersWidth = 51;
            dgvHistories.Size = new Size(779, 491);
            dgvHistories.TabIndex = 1;
            // 
            // clmDateTime
            // 
            clmDateTime.HeaderText = "Date & Time";
            clmDateTime.MinimumWidth = 6;
            clmDateTime.Name = "clmDateTime";
            clmDateTime.ReadOnly = true;
            clmDateTime.Width = 220;
            // 
            // clmChanged
            // 
            clmChanged.HeaderText = "Quantity Changed";
            clmChanged.MinimumWidth = 6;
            clmChanged.Name = "clmChanged";
            clmChanged.ReadOnly = true;
            clmChanged.Width = 150;
            // 
            // clmAfterChange
            // 
            clmAfterChange.HeaderText = "Quantity After Change";
            clmAfterChange.MinimumWidth = 6;
            clmAfterChange.Name = "clmAfterChange";
            clmAfterChange.ReadOnly = true;
            clmAfterChange.Width = 150;
            // 
            // clmRemarks
            // 
            clmRemarks.HeaderText = "Remarks";
            clmRemarks.MinimumWidth = 6;
            clmRemarks.Name = "clmRemarks";
            clmRemarks.ReadOnly = true;
            clmRemarks.Width = 400;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(13, 10);
            label4.Name = "label4";
            label4.Size = new Size(128, 28);
            label4.TabIndex = 0;
            label4.Text = "Stock History";
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvStocks);
            panel3.Controls.Add(tsPages);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new System.Drawing.Point(0, 73);
            panel3.Name = "panel3";
            panel3.Size = new Size(791, 547);
            panel3.TabIndex = 3;
            // 
            // tsPages
            // 
            tsPages.Dock = DockStyle.Bottom;
            tsPages.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tsPages.GripStyle = ToolStripGripStyle.Hidden;
            tsPages.ImageScalingSize = new Size(20, 20);
            tsPages.Items.AddRange(new ToolStripItem[] { toolStripLabel2, cmbPageSize, toolStripSeparator2, btnLast, btnNext, lblTotalPage, txtPage, toolStripLabel1, btnPrev, btnFirst, btnReload });
            tsPages.Location = new System.Drawing.Point(0, 516);
            tsPages.Name = "tsPages";
            tsPages.Size = new Size(791, 31);
            tsPages.TabIndex = 2;
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
            // tsMenu
            // 
            tsMenu.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tsMenu.GripStyle = ToolStripGripStyle.Hidden;
            tsMenu.ImageScalingSize = new Size(20, 20);
            tsMenu.Items.AddRange(new ToolStripItem[] { btnAdd, btnRemove });
            tsMenu.Location = new System.Drawing.Point(0, 42);
            tsMenu.Name = "tsMenu";
            tsMenu.Size = new Size(1598, 31);
            tsMenu.TabIndex = 2;
            tsMenu.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            btnAdd.Image = Properties.Resources.add_items_icon;
            btnAdd.ImageTransparentColor = Color.Magenta;
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(131, 28);
            btnAdd.Text = "Add Stocks";
            btnAdd.TextAlign = ContentAlignment.MiddleRight;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Image = Properties.Resources.remove_items_icon;
            btnRemove.ImageTransparentColor = Color.Magenta;
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(106, 28);
            btnRemove.Text = "Remove";
            btnRemove.TextAlign = ContentAlignment.MiddleRight;
            btnRemove.Click += btnRemove_Click;
            // 
            // frmStocks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1598, 705);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(pnlSearch);
            Controls.Add(label1);
            Controls.Add(tsMenu);
            Controls.Add(lblTitle);
            MinimumSize = new Size(1300, 600);
            Name = "frmStocks";
            Text = "Stocks";
            WindowState = FormWindowState.Maximized;
            Activated += frmStocks_Activated;
            Deactivate += frmStocks_Deactivate;
            ((System.ComponentModel.ISupportInitialize)dgvStocks).EndInit();
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistories).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tsPages.ResumeLayout(false);
            tsPages.PerformLayout();
            tsMenu.ResumeLayout(false);
            tsMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label label1;
        private DataGridView dgvStocks;
        private Panel pnlSearch;
        private TextBox txtItem;
        private Panel panel2;
        private DataGridView dgvHistories;
        private Label label4;
        private Panel panel3;
        private ToolStrip tsMenu;
        private ToolStripButton btnAdd;
        private ToolStripButton btnRemove;
        private LinkLabel linkLabel1;
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
        private ToolStripButton btnReload;
        private DataGridViewTextBoxColumn clmItem;
        private DataGridViewTextBoxColumn clmCategory;
        private DataGridViewTextBoxColumn clmUnit;
        private DataGridViewTextBoxColumn clmQuantity;
        private DataGridViewTextBoxColumn clmDateTime;
        private DataGridViewTextBoxColumn clmChanged;
        private DataGridViewTextBoxColumn clmAfterChange;
        private DataGridViewTextBoxColumn clmRemarks;
        private Panel panel1;
    }
}