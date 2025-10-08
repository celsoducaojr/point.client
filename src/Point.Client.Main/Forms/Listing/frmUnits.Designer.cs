namespace Point.Client.Main.Forms.Products
{
    partial class frmUnits
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
            btnEdit = new Button();
            btnNew = new Button();
            txtUnit = new TextBox();
            label1 = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            dgvUnits = new DataGridView();
            clmUnit = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvUnits).BeginInit();
            SuspendLayout();
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
            // txtUnit
            // 
            txtUnit.Location = new System.Drawing.Point(568, 29);
            txtUnit.Margin = new Padding(4);
            txtUnit.MaxLength = 30;
            txtUnit.Name = "txtUnit";
            txtUnit.ReadOnly = true;
            txtUnit.Size = new Size(321, 31);
            txtUnit.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(516, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(44, 25);
            label1.TabIndex = 11;
            label1.Text = "Unit";
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
            btnSave.Text = "Save Unit";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Visible = false;
            btnSave.Click += btnSave_Click;
            // 
            // dgvUnits
            // 
            dgvUnits.AllowUserToAddRows = false;
            dgvUnits.AllowUserToDeleteRows = false;
            dgvUnits.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUnits.Columns.AddRange(new DataGridViewColumn[] { clmUnit });
            dgvUnits.Location = new System.Drawing.Point(29, 29);
            dgvUnits.Margin = new Padding(4, 4, 25, 4);
            dgvUnits.MultiSelect = false;
            dgvUnits.Name = "dgvUnits";
            dgvUnits.ReadOnly = true;
            dgvUnits.RowHeadersWidth = 51;
            dgvUnits.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUnits.Size = new Size(458, 473);
            dgvUnits.TabIndex = 12;
            dgvUnits.SelectionChanged += dgvUnits_SelectionChanged;
            // 
            // clmUnit
            // 
            clmUnit.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clmUnit.HeaderText = "Unit";
            clmUnit.MinimumWidth = 6;
            clmUnit.Name = "clmUnit";
            clmUnit.ReadOnly = true;
            // 
            // frmUnits
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 531);
            Controls.Add(dgvUnits);
            Controls.Add(btnEdit);
            Controls.Add(btnNew);
            Controls.Add(txtUnit);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmUnits";
            Padding = new Padding(25);
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Units";
            FormClosed += frmUnits_FormClosed;
            Load += frmUnits_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUnits).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnEdit;
        private Button btnNew;
        private TextBox txtUnit;
        private Label label1;
        private Button btnCancel;
        private Button btnSave;
        private DataGridView dgvUnits;
        private DataGridViewTextBoxColumn clmUnit;
    }
}