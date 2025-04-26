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
            label4 = new Label();
            lblTag = new Label();
            btnClear = new Button();
            cmbCategory = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvTags).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(249, 444);
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
            btnCancel.Location = new System.Drawing.Point(437, 444);
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
            txtTag.Location = new System.Drawing.Point(24, 312);
            txtTag.Margin = new Padding(4);
            txtTag.Name = "txtTag";
            txtTag.Size = new Size(250, 31);
            txtTag.TabIndex = 4;
            // 
            // dgvTags
            // 
            dgvTags.AllowUserToAddRows = false;
            dgvTags.AllowUserToDeleteRows = false;
            dgvTags.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTags.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, clmRemove });
            dgvTags.Location = new System.Drawing.Point(24, 127);
            dgvTags.Margin = new Padding(4);
            dgvTags.MultiSelect = false;
            dgvTags.Name = "dgvTags";
            dgvTags.ReadOnly = true;
            dgvTags.RowHeadersWidth = 51;
            dgvTags.Size = new Size(531, 177);
            dgvTags.TabIndex = 3;
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
            txtItem.Size = new Size(400, 31);
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(24, 98);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(50, 25);
            label4.TabIndex = 25;
            label4.Text = "Tags";
            // 
            // lblTag
            // 
            lblTag.AutoSize = true;
            lblTag.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTag.ForeColor = SystemColors.ControlDarkDark;
            lblTag.Location = new System.Drawing.Point(24, 347);
            lblTag.Margin = new Padding(4, 0, 4, 0);
            lblTag.Name = "lblTag";
            lblTag.Size = new Size(98, 23);
            lblTag.TabIndex = 26;
            lblTag.Text = "Select Tag...";
            lblTag.Visible = false;
            // 
            // btnClear
            // 
            btnClear.Location = new System.Drawing.Point(24, 444);
            btnClear.Margin = new Padding(4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(118, 36);
            btnClear.TabIndex = 5;
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
            cmbCategory.Size = new Size(269, 33);
            cmbCategory.TabIndex = 27;
            // 
            // frmItemSearch
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 504);
            Controls.Add(cmbCategory);
            Controls.Add(btnClear);
            Controls.Add(lblTag);
            Controls.Add(label4);
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
            StartPosition = FormStartPosition.CenterParent;
            Text = "Search Item";
            FormClosing += frmItemSearch_FormClosing;
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
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewButtonColumn clmRemove;
        private Label label1;
        private TextBox txtItem;
        private Label label2;
        private Label label4;
        private Label lblTag;
        private Button btnClear;
        private ComboBox cmbCategory;
    }
}