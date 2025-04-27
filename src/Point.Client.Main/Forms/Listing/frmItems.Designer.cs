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
            clmDescription = new DataGridViewTextBoxColumn();
            clmTags = new DataGridViewTextBoxColumn();
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
            btnSearch = new ToolStripButton();
            btnClearFilter = new ToolStripButton();
            pnlEdit = new Panel();
            label4 = new Label();
            label6 = new Label();
            txtTag = new TextBox();
            lblTag = new Label();
            lnkManageTags = new LinkLabel();
            dgvTags = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            clmRemove = new DataGridViewButtonColumn();
            txtCategory = new TextBox();
            btnEdit = new Button();
            label1 = new Label();
            txtItem = new TextBox();
            btnCancel = new Button();
            btnNew = new Button();
            label2 = new Label();
            btnSave = new Button();
            lnkManageCategories = new LinkLabel();
            cmbCategory = new ComboBox();
            txtDescription = new RichTextBox();
            label3 = new Label();
            lblSearchCriteria = new Label();
            tlpMain.SuspendLayout();
            pnlList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            toolStrip1.SuspendLayout();
            pnlEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTags).BeginInit();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlpMain.ColumnCount = 2;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.22194F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.77806F));
            tlpMain.Controls.Add(pnlList, 0, 0);
            tlpMain.Controls.Add(pnlEdit, 1, 0);
            tlpMain.Dock = DockStyle.Bottom;
            tlpMain.Location = new System.Drawing.Point(25, 29);
            tlpMain.Margin = new Padding(4);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 1;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 608F));
            tlpMain.Size = new Size(1322, 643);
            tlpMain.TabIndex = 4;
            // 
            // pnlList
            // 
            pnlList.Controls.Add(dgvItems);
            pnlList.Controls.Add(toolStrip1);
            pnlList.Dock = DockStyle.Fill;
            pnlList.Location = new System.Drawing.Point(4, 4);
            pnlList.Margin = new Padding(4);
            pnlList.Name = "pnlList";
            pnlList.Size = new Size(841, 635);
            pnlList.TabIndex = 1;
            // 
            // dgvItems
            // 
            dgvItems.AllowUserToAddRows = false;
            dgvItems.AllowUserToDeleteRows = false;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Columns.AddRange(new DataGridViewColumn[] { clmItem, clmCategory, clmDescription, clmTags });
            dgvItems.Dock = DockStyle.Fill;
            dgvItems.Location = new System.Drawing.Point(0, 0);
            dgvItems.Margin = new Padding(4);
            dgvItems.MultiSelect = false;
            dgvItems.Name = "dgvItems";
            dgvItems.ReadOnly = true;
            dgvItems.RowHeadersWidth = 51;
            dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItems.Size = new Size(841, 604);
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
            // clmDescription
            // 
            clmDescription.HeaderText = "Description";
            clmDescription.MinimumWidth = 6;
            clmDescription.Name = "clmDescription";
            clmDescription.ReadOnly = true;
            clmDescription.Width = 200;
            // 
            // clmTags
            // 
            clmTags.HeaderText = "Tags";
            clmTags.MinimumWidth = 6;
            clmTags.Name = "clmTags";
            clmTags.ReadOnly = true;
            clmTags.Width = 150;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel2, cmbPageSize, toolStripSeparator1, btnLast, btnNext, lblTotalPage, txtPage, toolStripLabel1, btnPrev, btnFirst, btnSearch, btnClearFilter });
            toolStrip1.Location = new System.Drawing.Point(0, 604);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(841, 31);
            toolStrip1.TabIndex = 2;
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
            // btnSearch
            // 
            btnSearch.Image = Properties.Resources.search;
            btnSearch.ImageTransparentColor = Color.Magenta;
            btnSearch.Name = "btnSearch";
            btnSearch.RightToLeft = RightToLeft.No;
            btnSearch.Size = new Size(94, 28);
            btnSearch.Text = "Search";
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClearFilter
            // 
            btnClearFilter.Image = Properties.Resources.clear_search;
            btnClearFilter.ImageTransparentColor = Color.Magenta;
            btnClearFilter.Name = "btnClearFilter";
            btnClearFilter.Size = new Size(131, 28);
            btnClearFilter.Text = "Clear Filter";
            btnClearFilter.ToolTipText = "Clear Filter";
            btnClearFilter.Click += btnClearFilter_Click;
            // 
            // pnlEdit
            // 
            pnlEdit.Controls.Add(label4);
            pnlEdit.Controls.Add(label6);
            pnlEdit.Controls.Add(txtTag);
            pnlEdit.Controls.Add(lblTag);
            pnlEdit.Controls.Add(lnkManageTags);
            pnlEdit.Controls.Add(dgvTags);
            pnlEdit.Controls.Add(txtCategory);
            pnlEdit.Controls.Add(btnEdit);
            pnlEdit.Controls.Add(label1);
            pnlEdit.Controls.Add(txtItem);
            pnlEdit.Controls.Add(btnCancel);
            pnlEdit.Controls.Add(btnNew);
            pnlEdit.Controls.Add(label2);
            pnlEdit.Controls.Add(btnSave);
            pnlEdit.Controls.Add(lnkManageCategories);
            pnlEdit.Controls.Add(cmbCategory);
            pnlEdit.Controls.Add(txtDescription);
            pnlEdit.Controls.Add(label3);
            pnlEdit.Dock = DockStyle.Fill;
            pnlEdit.Location = new System.Drawing.Point(853, 4);
            pnlEdit.Margin = new Padding(4);
            pnlEdit.Name = "pnlEdit";
            pnlEdit.Padding = new Padding(25, 25, 25, 2);
            pnlEdit.Size = new Size(465, 635);
            pnlEdit.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(28, 199);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(50, 25);
            label4.TabIndex = 24;
            label4.Text = "Tags";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new System.Drawing.Point(0, 0);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(132, 25);
            label6.TabIndex = 22;
            label6.Text = "ITEM DETAILS";
            // 
            // txtTag
            // 
            txtTag.Location = new System.Drawing.Point(29, 413);
            txtTag.Margin = new Padding(4);
            txtTag.Name = "txtTag";
            txtTag.Size = new Size(250, 31);
            txtTag.TabIndex = 6;
            txtTag.Visible = false;
            txtTag.KeyDown += txtTag_KeyDown;
            // 
            // lblTag
            // 
            lblTag.AutoSize = true;
            lblTag.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTag.ForeColor = SystemColors.ControlDarkDark;
            lblTag.Location = new System.Drawing.Point(29, 448);
            lblTag.Margin = new Padding(4, 0, 4, 0);
            lblTag.Name = "lblTag";
            lblTag.Size = new Size(98, 23);
            lblTag.TabIndex = 23;
            lblTag.Text = "Select Tag...";
            lblTag.Visible = false;
            // 
            // lnkManageTags
            // 
            lnkManageTags.AutoSize = true;
            lnkManageTags.Location = new System.Drawing.Point(287, 416);
            lnkManageTags.Margin = new Padding(4, 0, 4, 0);
            lnkManageTags.Name = "lnkManageTags";
            lnkManageTags.Size = new Size(59, 25);
            lnkManageTags.TabIndex = 7;
            lnkManageTags.TabStop = true;
            lnkManageTags.Text = "Tags...";
            lnkManageTags.Visible = false;
            lnkManageTags.LinkClicked += lnkManageTags_LinkClicked;
            // 
            // dgvTags
            // 
            dgvTags.AllowUserToAddRows = false;
            dgvTags.AllowUserToDeleteRows = false;
            dgvTags.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTags.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, clmRemove });
            dgvTags.Location = new System.Drawing.Point(28, 228);
            dgvTags.Margin = new Padding(4);
            dgvTags.MultiSelect = false;
            dgvTags.Name = "dgvTags";
            dgvTags.ReadOnly = true;
            dgvTags.RowHeadersWidth = 51;
            dgvTags.Size = new Size(437, 177);
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
            txtCategory.Location = new System.Drawing.Point(139, 70);
            txtCategory.Margin = new Padding(4);
            txtCategory.Name = "txtCategory";
            txtCategory.ReadOnly = true;
            txtCategory.Size = new Size(200, 31);
            txtCategory.TabIndex = 2;
            // 
            // btnEdit
            // 
            btnEdit.Location = new System.Drawing.Point(347, 599);
            btnEdit.Margin = new Padding(4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(118, 36);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(83, 34);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(48, 25);
            label1.TabIndex = 8;
            label1.Text = "Item";
            // 
            // txtItem
            // 
            txtItem.Location = new System.Drawing.Point(139, 31);
            txtItem.Margin = new Padding(4);
            txtItem.MaxLength = 100;
            txtItem.Name = "txtItem";
            txtItem.ReadOnly = true;
            txtItem.Size = new Size(326, 31);
            txtItem.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(347, 599);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(118, 36);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Visible = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new System.Drawing.Point(222, 599);
            btnNew.Margin = new Padding(4);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(118, 36);
            btnNew.TabIndex = 8;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(47, 73);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 10;
            label2.Text = "Category";
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(159, 599);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(180, 36);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save Item";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Visible = false;
            btnSave.Click += btnSave_Click;
            // 
            // lnkManageCategories
            // 
            lnkManageCategories.AutoSize = true;
            lnkManageCategories.Location = new System.Drawing.Point(357, 73);
            lnkManageCategories.Margin = new Padding(4, 0, 4, 0);
            lnkManageCategories.Name = "lnkManageCategories";
            lnkManageCategories.Size = new Size(108, 25);
            lnkManageCategories.TabIndex = 3;
            lnkManageCategories.TabStop = true;
            lnkManageCategories.Text = "Categories...";
            lnkManageCategories.Visible = false;
            lnkManageCategories.LinkClicked += lnkManageCategories_LinkClicked;
            // 
            // cmbCategory
            // 
            cmbCategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCategory.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new System.Drawing.Point(139, 70);
            cmbCategory.Margin = new Padding(4);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(210, 33);
            cmbCategory.TabIndex = 2;
            cmbCategory.Visible = false;
            // 
            // txtDescription
            // 
            txtDescription.Location = new System.Drawing.Point(139, 109);
            txtDescription.Margin = new Padding(4);
            txtDescription.MaxLength = 250;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new Size(326, 86);
            txtDescription.TabIndex = 4;
            txtDescription.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(29, 112);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(102, 25);
            label3.TabIndex = 12;
            label3.Text = "Description";
            // 
            // lblSearchCriteria
            // 
            lblSearchCriteria.AutoSize = true;
            lblSearchCriteria.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSearchCriteria.ForeColor = SystemColors.ControlDarkDark;
            lblSearchCriteria.Location = new System.Drawing.Point(25, 668);
            lblSearchCriteria.Margin = new Padding(4, 0, 4, 0);
            lblSearchCriteria.Name = "lblSearchCriteria";
            lblSearchCriteria.Size = new Size(163, 20);
            lblSearchCriteria.TabIndex = 24;
            lblSearchCriteria.Text = "Loading search criteria...";
            // 
            // frmItems
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1372, 697);
            Controls.Add(tlpMain);
            Controls.Add(lblSearchCriteria);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmItems";
            Padding = new Padding(25);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Manage Items";
            FormClosing += frmItems_FormClosing;
            Load += frmItems_Load;
            tlpMain.ResumeLayout(false);
            pnlList.ResumeLayout(false);
            pnlList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            pnlEdit.ResumeLayout(false);
            pnlEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTags).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TableLayoutPanel tlpMain;
        private DataGridView dgvItems;
        private Panel pnlEdit;
        private TextBox txtItem;
        private Label label1;
        private LinkLabel lnkManageCategories;
        private ComboBox cmbCategory;
        private Label label2;
        private RichTextBox txtDescription;
        private Label label3;
        private Button btnEdit;
        private Button btnNew;
        private Button btnCancel;
        private Button btnSave;
        private TextBox txtCategory;
        private LinkLabel lnkManageTags;
        private DataGridView dgvTags;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewButtonColumn clmRemove;
        private Label lblTag;
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
        private Label label4;
        private Label label5;
        private ComboBox cmbCategorySearch;
        private Label label6;
        private ToolStripButton btnSearch;
        private ToolStripButton btnClearFilter;
        private DataGridViewTextBoxColumn clmItem;
        private DataGridViewTextBoxColumn clmCategory;
        private DataGridViewTextBoxColumn clmDescription;
        private DataGridViewTextBoxColumn clmTags;
        private Label lblSearchCriteria;
    }
}