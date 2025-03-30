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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            textBox2 = new TextBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            dgvItems = new DataGridView();
            clmItem = new DataGridViewTextBoxColumn();
            clmCategory = new DataGridViewTextBoxColumn();
            clmDescription = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            lnkAddTag = new LinkLabel();
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
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTags).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58.7479935F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.2520065F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 1);
            tableLayoutPanel1.Controls.Add(dgvItems, 0, 0);
            tableLayoutPanel1.Controls.Add(panel3, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new System.Drawing.Point(20, 23);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 60.2349F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 39.7651F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1246, 617);
            tableLayoutPanel1.TabIndex = 17;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(3, 374);
            panel1.Name = "panel1";
            panel1.Size = new Size(726, 240);
            panel1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(148, 69);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(446, 27);
            textBox2.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(103, 72);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 15;
            label4.Text = "Item";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(148, 102);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(282, 28);
            comboBox1.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(73, 105);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 16;
            label5.Text = "Category";
            // 
            // dgvItems
            // 
            dgvItems.AllowUserToAddRows = false;
            dgvItems.AllowUserToDeleteRows = false;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Columns.AddRange(new DataGridViewColumn[] { clmItem, clmCategory, clmDescription });
            dgvItems.Dock = DockStyle.Fill;
            dgvItems.Location = new System.Drawing.Point(3, 3);
            dgvItems.MultiSelect = false;
            dgvItems.Name = "dgvItems";
            dgvItems.ReadOnly = true;
            dgvItems.RowHeadersWidth = 51;
            dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItems.Size = new Size(726, 365);
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
            // panel3
            // 
            panel3.Controls.Add(lnkAddTag);
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
            panel3.Location = new System.Drawing.Point(735, 3);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(20);
            tableLayoutPanel1.SetRowSpan(panel3, 2);
            panel3.Size = new Size(508, 611);
            panel3.TabIndex = 2;
            // 
            // lnkAddTag
            // 
            lnkAddTag.AutoSize = true;
            lnkAddTag.Location = new System.Drawing.Point(421, 176);
            lnkAddTag.Name = "lnkAddTag";
            lnkAddTag.Size = new Size(64, 20);
            lnkAddTag.TabIndex = 21;
            lnkAddTag.TabStop = true;
            lnkAddTag.Text = "Add Tag";
            lnkAddTag.Visible = false;
            lnkAddTag.LinkClicked += lnkAddTag_LinkClicked;
            // 
            // dgvTags
            // 
            dgvTags.AllowUserToAddRows = false;
            dgvTags.AllowUserToDeleteRows = false;
            dgvTags.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTags.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, clmRemove });
            dgvTags.Location = new System.Drawing.Point(23, 199);
            dgvTags.MultiSelect = false;
            dgvTags.Name = "dgvTags";
            dgvTags.ReadOnly = true;
            dgvTags.RowHeadersWidth = 51;
            dgvTags.Size = new Size(462, 203);
            dgvTags.TabIndex = 20;
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
            btnEdit.Location = new System.Drawing.Point(123, 559);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 16;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new System.Drawing.Point(23, 559);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(94, 29);
            btnNew.TabIndex = 15;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(391, 559);
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
            btnSave.Location = new System.Drawing.Point(291, 559);
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
            // frmItems
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1286, 660);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmItems";
            Padding = new Padding(20);
            Text = "Manage Items";
            Load += frmItems_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTags).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private DataGridView dgvItems;
        private TextBox textBox2;
        private Label label4;
        private ComboBox comboBox1;
        private Label label5;
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
        private LinkLabel lnkAddTag;
        private DataGridView dgvTags;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewButtonColumn clmRemove;
    }
}