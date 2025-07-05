namespace Point.Client.Main.Listing
{
    partial class frmCategories
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
            dgvCategories = new DataGridView();
            clmCategory = new DataGridViewTextBoxColumn();
            btnSave = new Button();
            btnCancel = new Button();
            label1 = new Label();
            txtCategory = new TextBox();
            btnNew = new Button();
            btnEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
            SuspendLayout();
            // 
            // dgvCategories
            // 
            dgvCategories.AllowUserToAddRows = false;
            dgvCategories.AllowUserToDeleteRows = false;
            dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategories.Columns.AddRange(new DataGridViewColumn[] { clmCategory });
            dgvCategories.Location = new System.Drawing.Point(29, 29);
            dgvCategories.Margin = new Padding(4, 4, 25, 4);
            dgvCategories.MultiSelect = false;
            dgvCategories.Name = "dgvCategories";
            dgvCategories.ReadOnly = true;
            dgvCategories.RowHeadersWidth = 51;
            dgvCategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategories.Size = new Size(458, 473);
            dgvCategories.TabIndex = 1;
            dgvCategories.SelectionChanged += dgvCategories_SelectionChanged;
            // 
            // clmCategory
            // 
            clmCategory.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clmCategory.HeaderText = "Category";
            clmCategory.MinimumWidth = 6;
            clmCategory.Name = "clmCategory";
            clmCategory.ReadOnly = true;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(583, 466);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(180, 36);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save Category";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Visible = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(771, 466);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(118, 36);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Visible = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(516, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 25);
            label1.TabIndex = 4;
            label1.Text = "Category";
            // 
            // txtCategory
            // 
            txtCategory.Location = new System.Drawing.Point(608, 29);
            txtCategory.Margin = new Padding(4);
            txtCategory.MaxLength = 30;
            txtCategory.Name = "txtCategory";
            txtCategory.ReadOnly = true;
            txtCategory.Size = new Size(281, 31);
            txtCategory.TabIndex = 2;
            // 
            // btnNew
            // 
            btnNew.Location = new System.Drawing.Point(646, 466);
            btnNew.Margin = new Padding(4);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(118, 36);
            btnNew.TabIndex = 3;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new System.Drawing.Point(771, 466);
            btnEdit.Margin = new Padding(4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(118, 36);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // frmCategories
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 531);
            Controls.Add(btnEdit);
            Controls.Add(btnNew);
            Controls.Add(txtCategory);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(dgvCategories);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCategories";
            Padding = new Padding(25);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Categories";
            FormClosing += frmCategories_FormClosing;
            Load += frmCategories_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCategories;
        private DataGridViewTextBoxColumn clmCategory;
        private Button btnSave;
        private Button btnCancel;
        private Label label1;
        private TextBox txtCategory;
        private Button btnNew;
        private Button btnEdit;
    }
}