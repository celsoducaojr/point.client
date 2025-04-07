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
            panel3 = new Panel();
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
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripTextBox1 = new ToolStripTextBox();
            toolStripLabel1 = new ToolStripLabel();
            toolStripButton4 = new ToolStripButton();
            toolStripButton1 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripComboBox1 = new ToolStripComboBox();
            toolStripLabel2 = new ToolStripLabel();
            tlpMain.SuspendLayout();
            panel3.SuspendLayout();
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
            tlpMain.Controls.Add(panel3, 1, 0);
            tlpMain.Controls.Add(panel1, 0, 0);
            tlpMain.Dock = DockStyle.Bottom;
            tlpMain.Location = new System.Drawing.Point(20, 154);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 1;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpMain.Size = new Size(1246, 486);
            tlpMain.TabIndex = 17;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtTag);
            panel3.Controls.Add(lblTag);
            panel3.Controls.Add(lnkManageTags);
            panel3.Controls.Add(dgvTags);
            panel3.Controls.Add(txtCategory);
            panel3.Controls.Add(btnEdit);
            panel3.Controls.Add(btnNew);
            panel3.Controls.Add(btnCancel);
            panel3.Controls.Add(btnSave);
            panel3.Controls.Add(txtItem);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(lnkManageCategories);
            panel3.Controls.Add(cmbCategory);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtDescription);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new System.Drawing.Point(734, 3);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(20);
            panel3.Size = new Size(509, 480);
            panel3.TabIndex = 2;
            // 
            // txtTag
            // 
            txtTag.Location = new System.Drawing.Point(23, 354);
            txtTag.Name = "txtTag";
            txtTag.Size = new Size(360, 27);
            txtTag.TabIndex = 25;
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
            lnkManageTags.TabIndex = 21;
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
            dgvTags.TabIndex = 20;
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
            txtCategory.TabIndex = 19;
            // 
            // btnEdit
            // 
            btnEdit.Location = new System.Drawing.Point(124, 430);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 16;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new System.Drawing.Point(24, 430);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(94, 29);
            btnNew.TabIndex = 15;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(392, 430);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Visible = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(292, 430);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 17;
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
            txtItem.TabIndex = 11;
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
            lnkManageCategories.TabIndex = 9;
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
            cmbCategory.TabIndex = 14;
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
            txtDescription.TabIndex = 13;
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
            panel1.TabIndex = 3;
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
            dgvItems.TabIndex = 0;
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
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton2, toolStripButton3, toolStripTextBox1, toolStripLabel1, toolStripSeparator1, toolStripComboBox1, toolStripLabel2, toolStripButton4, toolStripButton1 });
            toolStrip1.Location = new System.Drawing.Point(0, 451);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(725, 29);
            toolStrip1.TabIndex = 19;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(40, 26);
            toolStripButton2.Text = "<<";
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(29, 26);
            toolStripButton3.Text = "<";
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(50, 29);
            toolStripTextBox1.Text = "0";
            toolStripTextBox1.TextBoxTextAlign = HorizontalAlignment.Center;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(86, 26);
            toolStripLabel1.Text = "of page 0";
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(29, 26);
            toolStripButton4.Text = ">";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(40, 26);
            toolStripButton1.Text = ">>";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 29);
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            toolStripComboBox1.Items.AddRange(new object[] { "25", "50", "100" });
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(75, 29);
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(122, 26);
            toolStripLabel2.Text = "rows per page";
            // 
            // frmItems
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1286, 660);
            Controls.Add(tlpMain);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmItems";
            Padding = new Padding(20);
            Text = "Manage Items";
            Load += frmItems_Load;
            tlpMain.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTags).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tlpMain;
        private DataGridView dgvItems;
        private Panel panel3;
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
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton1;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripComboBox toolStripComboBox1;
        private ToolStripLabel toolStripLabel2;
    }
}