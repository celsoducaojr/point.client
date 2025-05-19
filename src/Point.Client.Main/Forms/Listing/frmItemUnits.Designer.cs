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
            toolStrip1 = new ToolStrip();
            btnNew = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnEdit = new ToolStripButton();
            dgvItemUnits = new DataGridView();
            lblTitle = new Label();
            toolStrip2 = new ToolStrip();
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
            clmName = new DataGridViewTextBoxColumn();
            clmUnit = new DataGridViewTextBoxColumn();
            clmItemCode = new DataGridViewTextBoxColumn();
            clmPriceCode = new DataGridViewTextBoxColumn();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItemUnits).BeginInit();
            toolStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnNew, toolStripSeparator1, btnEdit });
            toolStrip1.Location = new System.Drawing.Point(0, 70);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1130, 31);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnNew
            // 
            btnNew.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnNew.Image = (Image)resources.GetObject("btnNew.Image");
            btnNew.ImageTransparentColor = Color.Magenta;
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(143, 28);
            btnNew.Text = "New Item Unit";
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
            btnEdit.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnEdit.Image = (Image)resources.GetObject("btnEdit.Image");
            btnEdit.ImageTransparentColor = Color.Magenta;
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(48, 28);
            btnEdit.Text = "Edit";
            btnEdit.TextAlign = ContentAlignment.MiddleRight;
            btnEdit.Click += btnEdit_Click;
            // 
            // dgvItemUnits
            // 
            dgvItemUnits.AllowUserToAddRows = false;
            dgvItemUnits.AllowUserToDeleteRows = false;
            dgvItemUnits.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItemUnits.Columns.AddRange(new DataGridViewColumn[] { clmName, clmUnit, clmItemCode, clmPriceCode });
            dgvItemUnits.Dock = DockStyle.Fill;
            dgvItemUnits.Location = new System.Drawing.Point(0, 101);
            dgvItemUnits.Margin = new Padding(4);
            dgvItemUnits.Name = "dgvItemUnits";
            dgvItemUnits.ReadOnly = true;
            dgvItemUnits.RowHeadersWidth = 51;
            dgvItemUnits.Size = new Size(1130, 484);
            dgvItemUnits.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.DeepSkyBlue;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new System.Drawing.Point(0, 0);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1130, 70);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Manage Item-Units";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // toolStrip2
            // 
            toolStrip2.Dock = DockStyle.Bottom;
            toolStrip2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStrip2.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip2.ImageScalingSize = new Size(20, 20);
            toolStrip2.Items.AddRange(new ToolStripItem[] { toolStripLabel2, cmbPageSize, toolStripSeparator2, btnLast, btnNext, lblTotalPage, txtPage, toolStripLabel1, btnPrev, btnFirst, btnSearch, btnClearFilter });
            toolStrip2.Location = new System.Drawing.Point(0, 585);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(1130, 31);
            toolStrip2.TabIndex = 3;
            toolStrip2.Text = "toolStrip2";
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
            // btnSearch
            // 
            btnSearch.Image = Properties.Resources.search;
            btnSearch.ImageTransparentColor = Color.Magenta;
            btnSearch.Name = "btnSearch";
            btnSearch.RightToLeft = RightToLeft.No;
            btnSearch.Size = new Size(94, 28);
            btnSearch.Text = "Search";
            // 
            // btnClearFilter
            // 
            btnClearFilter.Image = Properties.Resources.clear_search;
            btnClearFilter.ImageTransparentColor = Color.Magenta;
            btnClearFilter.Name = "btnClearFilter";
            btnClearFilter.Size = new Size(131, 28);
            btnClearFilter.Text = "Clear Filter";
            btnClearFilter.ToolTipText = "Clear Filter";
            // 
            // clmName
            // 
            clmName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clmName.HeaderText = "Name";
            clmName.MinimumWidth = 6;
            clmName.Name = "clmName";
            clmName.ReadOnly = true;
            // 
            // clmUnit
            // 
            clmUnit.HeaderText = "Unit";
            clmUnit.MinimumWidth = 6;
            clmUnit.Name = "clmUnit";
            clmUnit.ReadOnly = true;
            clmUnit.Width = 125;
            // 
            // clmItemCode
            // 
            clmItemCode.HeaderText = "Item Code";
            clmItemCode.MinimumWidth = 6;
            clmItemCode.Name = "clmItemCode";
            clmItemCode.ReadOnly = true;
            clmItemCode.Width = 175;
            // 
            // clmPriceCode
            // 
            clmPriceCode.HeaderText = "Price Code";
            clmPriceCode.MinimumWidth = 6;
            clmPriceCode.Name = "clmPriceCode";
            clmPriceCode.ReadOnly = true;
            clmPriceCode.Width = 125;
            // 
            // frmItemUnits
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 616);
            Controls.Add(dgvItemUnits);
            Controls.Add(toolStrip2);
            Controls.Add(toolStrip1);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmItemUnits";
            Text = "Manage Item-Units";
            WindowState = FormWindowState.Maximized;
            Load += frmItemUnits_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItemUnits).EndInit();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnNew;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnEdit;
        private DataGridView dgvItemUnits;
        private Label lblTitle;
        private ToolStrip toolStrip2;
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
        private DataGridViewTextBoxColumn clmName;
        private DataGridViewTextBoxColumn clmUnit;
        private DataGridViewTextBoxColumn clmItemCode;
        private DataGridViewTextBoxColumn clmPriceCode;
    }
}