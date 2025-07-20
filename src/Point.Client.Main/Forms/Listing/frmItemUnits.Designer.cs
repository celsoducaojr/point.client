namespace Point.Client.Main.Listing
{
    partial class frmItemUnits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItemUnits));
            tsMain = new ToolStrip();
            btnNew = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnEdit = new ToolStripButton();
            btnCancel = new ToolStripButton();
            btnSave = new ToolStripButton();
            dgvItemUnits = new DataGridView();
            clmItem = new DataGridViewTextBoxColumn();
            clmCategory = new DataGridViewTextBoxColumn();
            clmUnit = new DataGridViewTextBoxColumn();
            clmCapitalCode = new DataGridViewTextBoxColumn();
            lblTitle = new Label();
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
            btnSearch = new ToolStripButton();
            btnClearFilter = new ToolStripButton();
            lblSearchCriteria = new ToolStripLabel();
            label1 = new Label();
            tsMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItemUnits).BeginInit();
            tsPages.SuspendLayout();
            SuspendLayout();
            // 
            // tsMain
            // 
            tsMain.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tsMain.GripStyle = ToolStripGripStyle.Hidden;
            tsMain.ImageScalingSize = new Size(20, 20);
            tsMain.Items.AddRange(new ToolStripItem[] { btnNew, toolStripSeparator1, btnEdit, btnCancel, btnSave });
            tsMain.Location = new System.Drawing.Point(0, 60);
            tsMain.Name = "tsMain";
            tsMain.Size = new Size(1282, 31);
            tsMain.TabIndex = 0;
            tsMain.Text = "toolStrip1";
            // 
            // btnNew
            // 
            btnNew.Image = Properties.Resources.add_items_icon;
            btnNew.ImageTransparentColor = Color.Magenta;
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(211, 28);
            btnNew.Text = "Add New Item-units";
            btnNew.TextAlign = ContentAlignment.MiddleRight;
            btnNew.Click += btnNew_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 31);
            // 
            // btnEdit
            // 
            btnEdit.Image = Properties.Resources.edit_icon;
            btnEdit.ImageTransparentColor = Color.Magenta;
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(166, 28);
            btnEdit.Text = "Edit Item-units";
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
            btnCancel.TextAlign = ContentAlignment.MiddleRight;
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
            btnSave.TextAlign = ContentAlignment.MiddleRight;
            btnSave.Visible = false;
            btnSave.Click += btnSave_Click;
            // 
            // dgvItemUnits
            // 
            dgvItemUnits.AllowUserToAddRows = false;
            dgvItemUnits.AllowUserToDeleteRows = false;
            dgvItemUnits.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItemUnits.Columns.AddRange(new DataGridViewColumn[] { clmItem, clmCategory, clmUnit, clmCapitalCode });
            dgvItemUnits.Dock = DockStyle.Fill;
            dgvItemUnits.Location = new System.Drawing.Point(0, 91);
            dgvItemUnits.Margin = new Padding(4);
            dgvItemUnits.Name = "dgvItemUnits";
            dgvItemUnits.ReadOnly = true;
            dgvItemUnits.RowHeadersWidth = 51;
            dgvItemUnits.Size = new Size(1282, 531);
            dgvItemUnits.TabIndex = 1;
            dgvItemUnits.CellValidated += dgvItemUnits_CellValidated;
            dgvItemUnits.CellValidating += dgvItemUnits_CellValidating;
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
            // clmCapitalCode
            // 
            clmCapitalCode.HeaderText = "Capital Code";
            clmCapitalCode.MaxInputLength = 50;
            clmCapitalCode.MinimumWidth = 6;
            clmCapitalCode.Name = "clmCapitalCode";
            clmCapitalCode.ReadOnly = true;
            clmCapitalCode.Width = 150;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.DeepSkyBlue;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new System.Drawing.Point(0, 0);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1282, 60);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Manage Item-units";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tsPages
            // 
            tsPages.Dock = DockStyle.Bottom;
            tsPages.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tsPages.GripStyle = ToolStripGripStyle.Hidden;
            tsPages.ImageScalingSize = new Size(20, 20);
            tsPages.Items.AddRange(new ToolStripItem[] { toolStripLabel2, cmbPageSize, toolStripSeparator2, btnLast, btnNext, lblTotalPage, txtPage, toolStripLabel1, btnPrev, btnFirst, btnSearch, btnClearFilter, lblSearchCriteria });
            tsPages.Location = new System.Drawing.Point(0, 622);
            tsPages.Name = "tsPages";
            tsPages.Size = new Size(1282, 31);
            tsPages.TabIndex = 3;
            tsPages.Text = "toolStrip2";
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Alignment = ToolStripItemAlignment.Right;
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(144, 28);
            toolStripLabel2.Text = "items per page";
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
            // lblSearchCriteria
            // 
            lblSearchCriteria.Font = new Font("Tahoma", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSearchCriteria.ForeColor = SystemColors.ControlDarkDark;
            lblSearchCriteria.Name = "lblSearchCriteria";
            lblSearchCriteria.Size = new Size(201, 28);
            lblSearchCriteria.Text = "Loading search criteria...";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.BackColor = Color.DeepSkyBlue;
            label1.Image = Properties.Resources.products;
            label1.Location = new System.Drawing.Point(1210, 0);
            label1.Name = "label1";
            label1.Size = new Size(60, 60);
            label1.TabIndex = 4;
            // 
            // frmItemUnits
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 653);
            Controls.Add(label1);
            Controls.Add(dgvItemUnits);
            Controls.Add(tsPages);
            Controls.Add(tsMain);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MinimumSize = new Size(1300, 700);
            Name = "frmItemUnits";
            Text = "Item-Units";
            WindowState = FormWindowState.Maximized;
            Load += frmItemUnits_Load;
            tsMain.ResumeLayout(false);
            tsMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItemUnits).EndInit();
            tsPages.ResumeLayout(false);
            tsPages.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip tsMain;
        private ToolStripButton btnNew;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnEdit;
        private DataGridView dgvItemUnits;
        private Label lblTitle;
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
        private ToolStripButton btnSearch;
        private ToolStripButton btnClearFilter;
        private ToolStripButton btnSave;
        private ToolStripButton btnCancel;
        private ToolStripLabel lblSearchCriteria;
        private DataGridViewTextBoxColumn clmItem;
        private DataGridViewTextBoxColumn clmCategory;
        private DataGridViewTextBoxColumn clmUnit;
        private DataGridViewTextBoxColumn clmCapitalCode;
        private Label label1;
    }
}