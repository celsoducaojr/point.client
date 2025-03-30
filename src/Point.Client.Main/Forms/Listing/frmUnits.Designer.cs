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
            // txtUnit
            // 
            txtUnit.Location = new System.Drawing.Point(454, 23);
            txtUnit.MaxLength = 30;
            txtUnit.Name = "txtUnit";
            txtUnit.ReadOnly = true;
            txtUnit.Size = new Size(230, 27);
            txtUnit.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(412, 26);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 11;
            label1.Text = "Unit";
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
            // dgvUnits
            // 
            dgvUnits.AllowUserToAddRows = false;
            dgvUnits.AllowUserToDeleteRows = false;
            dgvUnits.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUnits.Columns.AddRange(new DataGridViewColumn[] { clmUnit });
            dgvUnits.Location = new System.Drawing.Point(23, 23);
            dgvUnits.Margin = new Padding(3, 3, 20, 3);
            dgvUnits.MultiSelect = false;
            dgvUnits.Name = "dgvUnits";
            dgvUnits.ReadOnly = true;
            dgvUnits.RowHeadersWidth = 51;
            dgvUnits.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUnits.Size = new Size(366, 492);
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
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 538);
            Controls.Add(dgvUnits);
            Controls.Add(btnEdit);
            Controls.Add(btnNew);
            Controls.Add(txtUnit);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmUnits";
            Padding = new Padding(20);
            Text = "Units";
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