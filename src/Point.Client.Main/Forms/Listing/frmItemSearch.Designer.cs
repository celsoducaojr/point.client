namespace Point.Client.Main.Forms.Listing
{
    partial class frmItemSearch
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
            btnSearch = new Button();
            btnCancel = new Button();
            txtTag = new TextBox();
            dgvTags = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            clmRemove = new DataGridViewButtonColumn();
            label1 = new Label();
            txtItem = new TextBox();
            label2 = new Label();
            btnClear = new Button();
            cmbCategory = new ComboBox();
            cmbUnit = new ComboBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTags).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(624, 392);
            btnSearch.Margin = new Padding(4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(180, 36);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search Item";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(812, 392);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(118, 36);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtTag
            // 
            txtTag.Location = new System.Drawing.Point(427, 248);
            txtTag.Margin = new Padding(4);
            txtTag.Name = "txtTag";
            txtTag.PlaceholderText = "Select tag...";
            txtTag.Size = new Size(250, 31);
            txtTag.TabIndex = 4;
            txtTag.KeyDown += txtTag_KeyDown;
            // 
            // dgvTags
            // 
            dgvTags.AllowUserToAddRows = false;
            dgvTags.AllowUserToDeleteRows = false;
            dgvTags.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTags.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, clmRemove });
            dgvTags.Location = new System.Drawing.Point(427, 63);
            dgvTags.Margin = new Padding(15, 4, 4, 4);
            dgvTags.MultiSelect = false;
            dgvTags.Name = "dgvTags";
            dgvTags.ReadOnly = true;
            dgvTags.RowHeadersWidth = 51;
            dgvTags.Size = new Size(503, 177);
            dgvTags.TabIndex = 3;
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
            clmRemove.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(60, 27);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(48, 25);
            label1.TabIndex = 15;
            label1.Text = "Item";
            // 
            // txtItem
            // 
            txtItem.Location = new System.Drawing.Point(116, 24);
            txtItem.Margin = new Padding(4);
            txtItem.MaxLength = 100;
            txtItem.Name = "txtItem";
            txtItem.Size = new Size(814, 31);
            txtItem.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(24, 66);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 16;
            label2.Text = "Category";
            // 
            // btnClear
            // 
            btnClear.Location = new System.Drawing.Point(24, 392);
            btnClear.Margin = new Padding(4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(118, 36);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // cmbCategory
            // 
            cmbCategory.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCategory.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new System.Drawing.Point(116, 63);
            cmbCategory.Margin = new Padding(4);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(292, 33);
            cmbCategory.TabIndex = 2;
            // 
            // cmbUnit
            // 
            cmbUnit.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbUnit.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbUnit.FormattingEnabled = true;
            cmbUnit.Location = new System.Drawing.Point(116, 104);
            cmbUnit.Margin = new Padding(4);
            cmbUnit.Name = "cmbUnit";
            cmbUnit.Size = new Size(292, 33);
            cmbUnit.TabIndex = 27;
            cmbUnit.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(64, 107);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(44, 25);
            label3.TabIndex = 28;
            label3.Text = "Unit";
            label3.Visible = false;
            // 
            // frmItemSearch
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(954, 452);
            Controls.Add(cmbUnit);
            Controls.Add(label3);
            Controls.Add(cmbCategory);
            Controls.Add(btnClear);
            Controls.Add(txtTag);
            Controls.Add(dgvTags);
            Controls.Add(label1);
            Controls.Add(txtItem);
            Controls.Add(label2);
            Controls.Add(btnCancel);
            Controls.Add(btnSearch);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "frmItemSearch";
            Padding = new Padding(20);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Search Item";
            Load += frmItemSearch_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTags).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private Button btnCancel;
        private TextBox txtTag;
        private DataGridView dgvTags;
        private Label label1;
        private TextBox txtItem;
        private Label label2;
        private Button btnClear;
        private ComboBox cmbCategory;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewButtonColumn clmRemove;
        private ComboBox cmbUnit;
        private Label label3;
    }
}