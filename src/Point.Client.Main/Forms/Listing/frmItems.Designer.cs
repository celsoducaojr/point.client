namespace Point.Client.Main.Listing
{
    partial class frmItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItems));
            tlpMain = new TableLayoutPanel();
            pnlList = new Panel();
            dgvItems = new DataGridView();
            clmItem = new DataGridViewTextBoxColumn();
            clmCategory = new DataGridViewTextBoxColumn();
            toolStrip1 = new ToolStrip();
            toolStripLabel2 = new ToolStripLabel();
            cmbPageSize = new ToolStripComboBox();
            toolStripSeparator1 = new ToolStripSeparator();
            btnLast = new ToolStripButton();
            btnNext = new ToolStripButton();
            lblTotalPage = new ToolStripLabel();
            txtPage = new ToolStripTextBox();
            toolStripLabel1 = new ToolStripLabel();
            btnPrev = new ToolStripButton();
            btnFirst = new ToolStripButton();
            btnReload = new ToolStripButton();
            pnlEdit = new Panel();
            label4 = new Label();
            label6 = new Label();
            txtTag = new TextBox();
            dgvTags = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            clmRemove = new DataGridViewButtonColumn();
            txtCategory = new TextBox();
            label1 = new Label();
            txtItem = new TextBox();
            label2 = new Label();
            cmbCategory = new ComboBox();
            txtDescription = new RichTextBox();
            label3 = new Label();
            lblTitle = new Label();
            label5 = new Label();
            tsMenu = new ToolStrip();
            btnAdd = new ToolStripButton();
            btnEdit = new ToolStripButton();
            btnCancel = new ToolStripButton();
            btnSave = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnAddItemUnit = new ToolStripButton();
            pnlSearch = new Panel();
            panel1 = new Panel();
            linkLabel1 = new LinkLabel();
            txtSearchItem = new TextBox();
            tlpMain.SuspendLayout();
            pnlList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            toolStrip1.SuspendLayout();
            pnlEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTags).BeginInit();
            tsMenu.SuspendLayout();
            pnlSearch.SuspendLayout();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlpMain.ColumnCount = 2;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.2344742F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.7655258F));
            tlpMain.Controls.Add(pnlList, 0, 0);
            tlpMain.Controls.Add(pnlEdit, 1, 0);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new System.Drawing.Point(0, 73);
            tlpMain.Margin = new Padding(4);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 1;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 608F));
            tlpMain.Size = new Size(1482, 495);
            tlpMain.TabIndex = 1;
            // 
            // pnlList
            // 
            pnlList.Controls.Add(dgvItems);
            pnlList.Controls.Add(toolStrip1);
            pnlList.Dock = DockStyle.Fill;
            pnlList.Location = new System.Drawing.Point(4, 4);
            pnlList.Margin = new Padding(4);
            pnlList.Name = "pnlList";
            pnlList.Size = new Size(766, 487);
            pnlList.TabIndex = 1;
            // 
            // dgvItems
            // 
            dgvItems.AllowUserToAddRows = false;
            dgvItems.AllowUserToDeleteRows = false;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Columns.AddRange(new DataGridViewColumn[] { clmItem, clmCategory });
            dgvItems.Dock = DockStyle.Fill;
            dgvItems.Location = new System.Drawing.Point(0, 0);
            dgvItems.Margin = new Padding(4);
            dgvItems.MultiSelect = false;
            dgvItems.Name = "dgvItems";
            dgvItems.ReadOnly = true;
            dgvItems.RowHeadersWidth = 51;
            dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItems.Size = new Size(766, 456);
            dgvItems.TabIndex = 1;
            dgvItems.SelectionChanged += dgvItems_SelectionChanged;
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
            clmCategory.Width = 130;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel2, cmbPageSize, toolStripSeparator1, btnLast, btnNext, lblTotalPage, txtPage, toolStripLabel1, btnPrev, btnFirst, btnReload });
            toolStrip1.Location = new System.Drawing.Point(0, 456);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(766, 31);
            toolStrip1.TabIndex = 3;
            toolStrip1.TabStop = true;
            toolStrip1.Text = "toolStrip1";
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
            // toolStripSeparator1
            // 
            toolStripSeparator1.Alignment = ToolStripItemAlignment.Right;
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 31);
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
            btnReload.RightToLeft = RightToLeft.No;
            btnReload.Size = new Size(123, 28);
            btnReload.Text = "Reload All";
            btnReload.Click += btnReload_Click;
            // 
            // pnlEdit
            // 
            pnlEdit.Controls.Add(label4);
            pnlEdit.Controls.Add(label6);
            pnlEdit.Controls.Add(txtTag);
            pnlEdit.Controls.Add(dgvTags);
            pnlEdit.Controls.Add(txtCategory);
            pnlEdit.Controls.Add(label1);
            pnlEdit.Controls.Add(txtItem);
            pnlEdit.Controls.Add(label2);
            pnlEdit.Controls.Add(cmbCategory);
            pnlEdit.Controls.Add(txtDescription);
            pnlEdit.Controls.Add(label3);
            pnlEdit.Dock = DockStyle.Fill;
            pnlEdit.Location = new System.Drawing.Point(778, 4);
            pnlEdit.Margin = new Padding(4);
            pnlEdit.Name = "pnlEdit";
            pnlEdit.Padding = new Padding(10);
            pnlEdit.Size = new Size(700, 487);
            pnlEdit.TabIndex = 2;
            pnlEdit.TabStop = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(14, 212);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(104, 25);
            label4.TabIndex = 26;
            label4.Text = "Search Tags";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new System.Drawing.Point(14, 10);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(136, 31);
            label6.TabIndex = 22;
            label6.Text = "Item Details";
            // 
            // txtTag
            // 
            txtTag.Location = new System.Drawing.Point(14, 388);
            txtTag.Margin = new Padding(4);
            txtTag.Name = "txtTag";
            txtTag.PlaceholderText = "Select tag...";
            txtTag.Size = new Size(412, 31);
            txtTag.TabIndex = 6;
            txtTag.Visible = false;
            txtTag.KeyDown += txtTag_KeyDown;
            // 
            // dgvTags
            // 
            dgvTags.AllowUserToAddRows = false;
            dgvTags.AllowUserToDeleteRows = false;
            dgvTags.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTags.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, clmRemove });
            dgvTags.Location = new System.Drawing.Point(14, 241);
            dgvTags.Margin = new Padding(4);
            dgvTags.MultiSelect = false;
            dgvTags.Name = "dgvTags";
            dgvTags.ReadOnly = true;
            dgvTags.RowHeadersWidth = 51;
            dgvTags.Size = new Size(554, 139);
            dgvTags.TabIndex = 5;
            dgvTags.CellClick += dgvTags_CellClick;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.HeaderText = "Tag";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // clmRemove
            // 
            clmRemove.HeaderText = "";
            clmRemove.MinimumWidth = 6;
            clmRemove.Name = "clmRemove";
            clmRemove.ReadOnly = true;
            clmRemove.Text = "Remove";
            clmRemove.Visible = false;
            clmRemove.Width = 125;
            // 
            // txtCategory
            // 
            txtCategory.Location = new System.Drawing.Point(124, 84);
            txtCategory.Margin = new Padding(4);
            txtCategory.Name = "txtCategory";
            txtCategory.ReadOnly = true;
            txtCategory.Size = new Size(317, 31);
            txtCategory.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(68, 48);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(48, 25);
            label1.TabIndex = 8;
            label1.Text = "Item";
            // 
            // txtItem
            // 
            txtItem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtItem.Location = new System.Drawing.Point(124, 45);
            txtItem.Margin = new Padding(4);
            txtItem.MaxLength = 100;
            txtItem.Name = "txtItem";
            txtItem.ReadOnly = true;
            txtItem.Size = new Size(562, 31);
            txtItem.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(32, 87);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 10;
            label2.Text = "Category";
            // 
            // cmbCategory
            // 
            cmbCategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCategory.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new System.Drawing.Point(124, 84);
            cmbCategory.Margin = new Padding(4);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(327, 33);
            cmbCategory.TabIndex = 2;
            cmbCategory.Visible = false;
            // 
            // txtDescription
            // 
            txtDescription.Location = new System.Drawing.Point(124, 125);
            txtDescription.Margin = new Padding(4);
            txtDescription.MaxLength = 250;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new Size(444, 83);
            txtDescription.TabIndex = 4;
            txtDescription.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(14, 128);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(102, 25);
            label3.TabIndex = 12;
            label3.Text = "Description";
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.DeepSkyBlue;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new System.Drawing.Point(0, 0);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1482, 42);
            lblTitle.TabIndex = 25;
            lblTitle.Text = "Manage Items";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.BackColor = Color.DeepSkyBlue;
            label5.Image = Properties.Resources.products_banner;
            label5.Location = new System.Drawing.Point(1430, 2);
            label5.Name = "label5";
            label5.Size = new Size(40, 40);
            label5.TabIndex = 26;
            // 
            // tsMenu
            // 
            tsMenu.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tsMenu.GripStyle = ToolStripGripStyle.Hidden;
            tsMenu.ImageScalingSize = new Size(20, 20);
            tsMenu.Items.AddRange(new ToolStripItem[] { btnAdd, btnEdit, btnCancel, btnSave, toolStripSeparator2, btnAddItemUnit });
            tsMenu.Location = new System.Drawing.Point(0, 42);
            tsMenu.Name = "tsMenu";
            tsMenu.Size = new Size(1482, 31);
            tsMenu.TabIndex = 5;
            tsMenu.TabStop = true;
            tsMenu.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            btnAdd.Image = Properties.Resources.add_folder_icon;
            btnAdd.ImageTransparentColor = Color.Magenta;
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(116, 28);
            btnAdd.Text = "Add Item";
            btnAdd.TextAlign = ContentAlignment.MiddleRight;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Image = Properties.Resources.edit_folder_icon;
            btnEdit.ImageTransparentColor = Color.Magenta;
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(116, 28);
            btnEdit.Text = "Edit Item";
            btnEdit.TextAlign = ContentAlignment.MiddleRight;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnCancel
            // 
            btnCancel.Alignment = ToolStripItemAlignment.Right;
            btnCancel.Image = Properties.Resources.cancel_icon;
            btnCancel.ImageTransparentColor = Color.Magenta;
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(93, 28);
            btnCancel.Text = "Cancel";
            btnCancel.Visible = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Alignment = ToolStripItemAlignment.Right;
            btnSave.Image = Properties.Resources.save_icon;
            btnSave.ImageTransparentColor = Color.Magenta;
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(159, 28);
            btnSave.Text = "Save Changes";
            btnSave.Visible = false;
            btnSave.Click += btnSave_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 31);
            // 
            // btnAddItemUnit
            // 
            btnAddItemUnit.Image = Properties.Resources.add_item_icon;
            btnAddItemUnit.ImageTransparentColor = Color.Magenta;
            btnAddItemUnit.Name = "btnAddItemUnit";
            btnAddItemUnit.Size = new Size(202, 28);
            btnAddItemUnit.Text = "Add New Item-unit";
            btnAddItemUnit.Click += btnAddItemUnit_Click;
            // 
            // pnlSearch
            // 
            pnlSearch.Controls.Add(panel1);
            pnlSearch.Controls.Add(linkLabel1);
            pnlSearch.Controls.Add(txtSearchItem);
            pnlSearch.Dock = DockStyle.Bottom;
            pnlSearch.Location = new System.Drawing.Point(0, 568);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(1482, 85);
            pnlSearch.TabIndex = 2;
            pnlSearch.TabStop = true;
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
            linkLabel1.Size = new Size(147, 25);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Advance search...";
            // 
            // txtSearchItem
            // 
            txtSearchItem.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSearchItem.Location = new System.Drawing.Point(47, 10);
            txtSearchItem.Margin = new Padding(4);
            txtSearchItem.MaxLength = 100;
            txtSearchItem.Name = "txtSearchItem";
            txtSearchItem.PlaceholderText = "Search item...";
            txtSearchItem.Size = new Size(1422, 31);
            txtSearchItem.TabIndex = 1;
            txtSearchItem.KeyDown += txtSearchItem_KeyDown;
            // 
            // frmItems
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 653);
            Controls.Add(label5);
            Controls.Add(tlpMain);
            Controls.Add(tsMenu);
            Controls.Add(lblTitle);
            Controls.Add(pnlSearch);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MinimumSize = new Size(1500, 700);
            Name = "frmItems";
            Text = "Items";
            WindowState = FormWindowState.Maximized;
            Activated += frmItems_Activated;
            Deactivate += frmItems_Deactivate;
            tlpMain.ResumeLayout(false);
            pnlList.ResumeLayout(false);
            pnlList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            pnlEdit.ResumeLayout(false);
            pnlEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTags).EndInit();
            tsMenu.ResumeLayout(false);
            tsMenu.PerformLayout();
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TableLayoutPanel tlpMain;
        private DataGridView dgvItems;
        private Panel pnlEdit;
        private TextBox txtItem;
        private Label label1;
        private ComboBox cmbCategory;
        private Label label2;
        private RichTextBox txtDescription;
        private Label label3;
        private TextBox txtCategory;
        private DataGridView dgvTags;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewButtonColumn clmRemove;
        private ComboBox cmbTag;
        private TextBox txtTag;
        private Panel pnlList;
        private ToolStrip toolStrip1;
        private ToolStripButton btnFirst;
        private ToolStripButton btnPrev;
        private ToolStripButton btnNext;
        private ToolStripButton btnLast;
        private ToolStripTextBox txtPage;
        private ToolStripLabel lblTotalPage;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripComboBox cmbPageSize;
        private ToolStripLabel toolStripLabel2;
        private ToolStripLabel toolStripLabel1;
        private TextBox txtItemSearch;
        private Label label5;
        private ComboBox cmbCategorySearch;
        private Label label6;
        private ToolStripButton btnReload;
        private Button btnAddItemUnits;
        private DataGridViewTextBoxColumn clmItem;
        private DataGridViewTextBoxColumn clmCategory;
        private Label lblTitle;
        private ToolStrip tsMenu;
        private ToolStripButton btnAdd;
        private ToolStripButton btnEdit;
        private Panel pnlSearch;
        private Panel panel1;
        private LinkLabel linkLabel1;
        private TextBox txtSearchItem;
        private ToolStripButton btnCancel;
        private ToolStripButton btnSave;
        private Label label4;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnAddItemUnit;
    }
}