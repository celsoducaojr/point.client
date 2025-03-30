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
            dgvTags.Location = new System.Drawing.Point(23, 23);
            dgvTags.Margin = new Padding(3, 3, 20, 3);
            dgvTags.MultiSelect = false;
            dgvTags.Name = "dgvTags";
            dgvTags.ReadOnly = true;
            dgvTags.RowHeadersWidth = 51;
            dgvTags.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTags.Size = new Size(366, 492);
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
            btnEdit.Location = new System.Drawing.Point(512, 486);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new System.Drawing.Point(412, 486);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(94, 29);
            btnNew.TabIndex = 3;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // txtTag
            // 
            txtTag.Location = new System.Drawing.Point(450, 23);
            txtTag.MaxLength = 30;
            txtTag.Name = "txtTag";
            txtTag.ReadOnly = true;
            txtTag.Size = new Size(230, 27);
            txtTag.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(412, 26);
            label1.Name = "label1";
            label1.Size = new Size(32, 20);
            label1.TabIndex = 11;
            label1.Text = "Tag";
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(716, 486);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Visible = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(616, 486);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Visible = false;
            btnSave.Click += btnSave_Click;
            // 
            // frmTags
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 538);
            Controls.Add(dgvTags);
            Controls.Add(btnEdit);
            Controls.Add(btnNew);
            Controls.Add(txtTag);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmTags";
            Padding = new Padding(20);
            Text = "Tags";
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