namespace Point.Client.Main.Forms.Products
{
    partial class frmTags
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
            dgvTags = new DataGridView();
            clmTag = new DataGridViewTextBoxColumn();
            btnEdit = new Button();
            btnNew = new Button();
            txtTag = new TextBox();
            label1 = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTags).BeginInit();
            SuspendLayout();
            // 
            // dgvTags
            // 
            dgvTags.AllowUserToAddRows = false;
            dgvTags.AllowUserToDeleteRows = false;
            dgvTags.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTags.Columns.AddRange(new DataGridViewColumn[] { clmTag });
            dgvTags.Location = new System.Drawing.Point(29, 29);
            dgvTags.Margin = new Padding(4, 4, 25, 4);
            dgvTags.MultiSelect = false;
            dgvTags.Name = "dgvTags";
            dgvTags.ReadOnly = true;
            dgvTags.RowHeadersWidth = 51;
            dgvTags.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTags.Size = new Size(458, 473);
            dgvTags.TabIndex = 1;
            dgvTags.SelectionChanged += dgvTags_SelectionChanged;
            // 
            // clmTag
            // 
            clmTag.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clmTag.HeaderText = "Tag";
            clmTag.MinimumWidth = 6;
            clmTag.Name = "clmTag";
            clmTag.ReadOnly = true;
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
            // txtTag
            // 
            txtTag.Location = new System.Drawing.Point(563, 29);
            txtTag.Margin = new Padding(4);
            txtTag.MaxLength = 30;
            txtTag.Name = "txtTag";
            txtTag.ReadOnly = true;
            txtTag.Size = new Size(326, 31);
            txtTag.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(516, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(39, 25);
            label1.TabIndex = 11;
            label1.Text = "Tag";
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
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(583, 466);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(180, 36);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save Tag";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Visible = false;
            btnSave.Click += btnSave_Click;
            // 
            // frmTags
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 531);
            Controls.Add(dgvTags);
            Controls.Add(btnEdit);
            Controls.Add(btnNew);
            Controls.Add(txtTag);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmTags";
            Padding = new Padding(25);
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Tags";
            FormClosed += frmTags_FormClosed;
            Load += frmTags_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTags).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTags;
        private DataGridViewTextBoxColumn clmTag;
        private Button btnEdit;
        private Button btnNew;
        private TextBox txtTag;
        private Label label1;
        private Button btnCancel;
        private Button btnSave;
    }
}