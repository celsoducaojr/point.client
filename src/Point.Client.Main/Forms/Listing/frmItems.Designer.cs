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
            pnlEdit = new Panel();
            txtTag = new TextBox();
            lblTag = new Label();
            lnkManageTags = new LinkLabel();
            dgvTags = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            clmRemove = new DataGridViewButtonColumn();
            txtCategory = new TextBox();
            btnEdit = new Button();
            btnNew = new Button();
            btnCancel = new Button();
            btnSave = new Button();
            txtItem = new TextBox();
            label1 = new Label();
            lnkManageCategories = new LinkLabel();
            cmbCategory = new ComboBox();
            label2 = new Label();
            txtDescription = new RichTextBox();
            label3 = new Label();
            panel1 = new Panel();
            dgvItems = new DataGridView();
            clmItem = new DataGridViewTextBoxColumn();
            clmCategory = new DataGridViewTextBoxColumn();
            clmDescription = new DataGridViewTextBoxColumn();
            toolStrip1 = new ToolStrip();
            btnFirst = new ToolStripButton();
            btnPrev = new ToolStripButton();
            toolStripLabel1 = new ToolStripLabel();
            txtPage = new ToolStripTextBox();
            lblTotalPage = new ToolStripLabel();
            toolStripSeparator1 = new ToolStripSeparator();
            btnNext = new ToolStripButton();
            btnLast = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            cmbPageSize = new ToolStripComboBox();
            toolStripLabel2 = new ToolStripLabel();
            panel2 = new Panel();
            txtItemSearch = new TextBox();
            label4 = new Label();
            label5 = new Label();
            btnSearch = new Button();
            cmbCategorySearch = new ComboBox();
            tlpMain.SuspendLayout();
            pnlEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTags).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 2;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58.74799F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.2520065F));
            tlpMain.Controls.Add(pnlEdit, 1, 0);
            tlpMain.Controls.Add(panel1, 0, 0);
            tlpMain.Dock = DockStyle.Bottom;
            tlpMain.Location = new System.Drawing.Point(20, 154);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 1;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpMain.Size = new Size(1246, 486);
            tlpMain.TabIndex = 4;
            // 
            // pnlEdit
            // 
            pnlEdit.Controls.Add(txtTag);
            pnlEdit.Controls.Add(lblTag);
            pnlEdit.Controls.Add(lnkManageTags);
            pnlEdit.Controls.Add(dgvTags);
            pnlEdit.Controls.Add(txtCategory);
            pnlEdit.Controls.Add(btnEdit);
            pnlEdit.Controls.Add(btnNew);
            pnlEdit.Controls.Add(btnCancel);
            pnlEdit.Controls.Add(btnSave);
            pnlEdit.Controls.Add(txtItem);
            pnlEdit.Controls.Add(label1);
            pnlEdit.Controls.Add(lnkManageCategories);
            pnlEdit.Controls.Add(cmbCategory);
            pnlEdit.Controls.Add(label2);
            pnlEdit.Controls.Add(txtDescription);
            pnlEdit.Controls.Add(label3);
            pnlEdit.Dock = DockStyle.Fill;
            pnlEdit.Location = new System.Drawing.Point(734, 3);
            pnlEdit.Name = "pnlEdit";
            pnlEdit.Padding = new Padding(20, 20, 20, 2);
            pnlEdit.Size = new Size(509, 480);
            pnlEdit.TabIndex = 2;
            // 
            // txtTag
            // 
            txtTag.Location = new System.Drawing.Point(23, 354);
            txtTag.Name = "txtTag";
            txtTag.Size = new Size(360, 27);
            txtTag.TabIndex = 6;
            txtTag.Visible = false;
            txtTag.KeyDown += txtTag_KeyDown;
            // 
            // lblTag
            // 
            lblTag.AutoSize = true;
            lblTag.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTag.ForeColor = SystemColors.ControlDarkDark;
            lblTag.Location = new System.Drawing.Point(23, 385);
            lblTag.Name = "lblTag";
            lblTag.Size = new Size(74, 17);
            lblTag.TabIndex = 23;
            lblTag.Text = "Select tag...";
            lblTag.Visible = false;
            // 
            // lnkManageTags
            // 
            lnkManageTags.AutoSize = true;
            lnkManageTags.Location = new System.Drawing.Point(389, 357);
            lnkManageTags.Name = "lnkManageTags";
            lnkManageTags.Size = new Size(96, 20);
            lnkManageTags.TabIndex = 7;
            lnkManageTags.TabStop = true;
            lnkManageTags.Text = "Manage Tags";
            lnkManageTags.Visible = false;
            lnkManageTags.LinkClicked += lnkManageTags_LinkClicked;
            // 
            // dgvTags
            // 
            dgvTags.AllowUserToAddRows = false;
            dgvTags.AllowUserToDeleteRows = false;
            dgvTags.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTags.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, clmRemove });
            dgvTags.Location = new System.Drawing.Point(23, 165);
            dgvTags.MultiSelect = false;
            dgvTags.Name = "dgvTags";
            dgvTags.ReadOnly = true;
            dgvTags.RowHeadersWidth = 51;
            dgvTags.Size = new Size(462, 183);
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
            txtCategory.Location = new System.Drawing.Point(114, 56);
            txtCategory.Name = "txtCategory";
            txtCategory.ReadOnly = true;
            txtCategory.Size = new Size(217, 27);
            txtCategory.TabIndex = 2;
            // 
            // btnEdit
            // 
            btnEdit.Location = new System.Drawing.Point(124, 446);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new System.Drawing.Point(24, 446);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(94, 29);
            btnNew.TabIndex = 8;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(392, 446);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Visible = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(292, 446);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Visible = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtItem
            // 
            txtItem.Location = new System.Drawing.Point(114, 23);
            txtItem.MaxLength = 100;
            txtItem.Name = "txtItem";
            txtItem.ReadOnly = true;
            txtItem.Size = new Size(304, 27);
            txtItem.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(69, 26);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 8;
            label1.Text = "Item";
            // 
            // lnkManageCategories
            // 
            lnkManageCategories.AutoSize = true;
            lnkManageCategories.Location = new System.Drawing.Point(347, 59);
            lnkManageCategories.Name = "lnkManageCategories";
            lnkManageCategories.Size = new Size(138, 20);
            lnkManageCategories.TabIndex = 3;
            lnkManageCategories.TabStop = true;
            lnkManageCategories.Text = "Manage Categories";
            lnkManageCategories.Visible = false;
            lnkManageCategories.LinkClicked += lnkManageCategories_LinkClicked;
            // 
            // cmbCategory
            // 
            cmbCategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCategory.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new System.Drawing.Point(114, 56);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(227, 28);
            cmbCategory.TabIndex = 2;
            cmbCategory.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(39, 59);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 10;
            label2.Text = "Category";
            // 
            // txtDescription
            // 
            txtDescription.Location = new System.Drawing.Point(114, 90);
            txtDescription.MaxLength = 250;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new Size(371, 69);
            txtDescription.TabIndex = 4;
            txtDescription.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(23, 96);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 12;
            label3.Text = "Description";
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvItems);
            panel1.Controls.Add(toolStrip1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(725, 480);
            panel1.TabIndex = 1;
            // 
            // dgvItems
            // 
            dgvItems.AllowUserToAddRows = false;
            dgvItems.AllowUserToDeleteRows = false;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Columns.AddRange(new DataGridViewColumn[] { clmItem, clmCategory, clmDescription });
            dgvItems.Dock = DockStyle.Fill;
            dgvItems.Location = new System.Drawing.Point(0, 0);
            dgvItems.MultiSelect = false;
            dgvItems.Name = "dgvItems";
            dgvItems.ReadOnly = true;
            dgvItems.RowHeadersWidth = 51;
            dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItems.Size = new Size(725, 451);
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
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnFirst, btnPrev, toolStripLabel1, txtPage, lblTotalPage, toolStripSeparator1, btnNext, btnLast, toolStripSeparator2, cmbPageSize, toolStripLabel2 });
            toolStrip1.Location = new System.Drawing.Point(0, 451);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(725, 29);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnFirst
            // 
            btnFirst.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnFirst.Image = (Image)resources.GetObject("btnFirst.Image");
            btnFirst.ImageTransparentColor = Color.Magenta;
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(40, 26);
            btnFirst.Text = "<<";
            btnFirst.ToolTipText = "first page";
            btnFirst.Click += btnFirst_Click;
            // 
            // btnPrev
            // 
            btnPrev.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnPrev.Image = (Image)resources.GetObject("btnPrev.Image");
            btnPrev.ImageTransparentColor = Color.Magenta;
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(29, 26);
            btnPrev.Text = "<";
            btnPrev.ToolTipText = "previous page";
            btnPrev.Click += btnPrev_Click;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(48, 26);
            toolStripLabel1.Text = "page";
            // 
            // txtPage
            // 
            txtPage.Name = "txtPage";
            txtPage.Size = new Size(50, 29);
            txtPage.TextBoxTextAlign = HorizontalAlignment.Center;
            txtPage.KeyDown += txtPage_KeyDown;
            // 
            // lblTotalPage
            // 
            lblTotalPage.Name = "lblTotalPage";
            lblTotalPage.Size = new Size(42, 26);
            lblTotalPage.Text = "of 0";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 29);
            // 
            // btnNext
            // 
            btnNext.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnNext.Image = (Image)resources.GetObject("btnNext.Image");
            btnNext.ImageTransparentColor = Color.Magenta;
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(29, 26);
            btnNext.Text = ">";
            btnNext.ToolTipText = "next page";
            btnNext.Click += btnNext_Click;
            // 
            // btnLast
            // 
            btnLast.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnLast.Image = (Image)resources.GetObject("btnLast.Image");
            btnLast.ImageTransparentColor = Color.Magenta;
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(40, 26);
            btnLast.Text = ">>";
            btnLast.ToolTipText = "last page";
            btnLast.Click += btnLast_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 29);
            // 
            // cmbPageSize
            // 
            cmbPageSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPageSize.Name = "cmbPageSize";
            cmbPageSize.Size = new Size(75, 29);
            cmbPageSize.SelectedIndexChanged += cmbPageSize_SelectedIndexChanged;
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(122, 26);
            toolStripLabel2.Text = "rows per page";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new System.Drawing.Point(23, 146);
            panel2.Name = "panel2";
            panel2.Size = new Size(1240, 2);
            panel2.TabIndex = 18;
            // 
            // txtItemSearch
            // 
            txtItemSearch.Location = new System.Drawing.Point(98, 23);
            txtItemSearch.MaxLength = 100;
            txtItemSearch.Name = "txtItemSearch";
            txtItemSearch.Size = new Size(304, 27);
            txtItemSearch.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(53, 26);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 20;
            label4.Text = "Item";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(23, 59);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 21;
            label5.Text = "Category";
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(23, 111);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(151, 29);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search Items";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // cmbCategorySearch
            // 
            cmbCategorySearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCategorySearch.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbCategorySearch.FormattingEnabled = true;
            cmbCategorySearch.Location = new System.Drawing.Point(98, 56);
            cmbCategorySearch.Name = "cmbCategorySearch";
            cmbCategorySearch.Size = new Size(227, 28);
            cmbCategorySearch.TabIndex = 2;
            // 
            // frmItems
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1286, 660);
            Controls.Add(cmbCategorySearch);
            Controls.Add(btnSearch);
            Controls.Add(txtItemSearch);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(panel2);
            Controls.Add(tlpMain);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmItems";
            Padding = new Padding(20);
            Text = "Manage Items";
            Load += frmItems_Load;
            tlpMain.ResumeLayout(false);
            pnlEdit.ResumeLayout(false);
            pnlEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTags).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
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
        private DataGridViewTextBoxColumn clmItem;
        private DataGridViewTextBoxColumn clmCategory;
        private DataGridViewTextBoxColumn clmDescription;
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
        private Panel panel1;
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
        private ToolStripSeparator toolStripSeparator2;
        private Panel panel2;
        private TextBox txtItemSearch;
        private Label label4;
        private Label label5;
        private Button btnSearch;
        private ComboBox cmbCategorySearch;
    }
}