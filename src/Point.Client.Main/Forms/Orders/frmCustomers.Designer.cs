namespace Point.Client.Main.Forms.Orders
{
    partial class frmCustomers
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
            dgvCustomers = new DataGridView();
            clmCustomer = new DataGridViewTextBoxColumn();
            btnEdit = new Button();
            btnNew = new Button();
            txtCustomer = new TextBox();
            label1 = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            txtSearch = new TextBox();
            lblSearch = new Label();
            btnSelect = new Button();
            btnLoadAll = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            // 
            // dgvCustomers
            // 
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AllowUserToDeleteRows = false;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Columns.AddRange(new DataGridViewColumn[] { clmCustomer });
            dgvCustomers.Location = new System.Drawing.Point(29, 73);
            dgvCustomers.Margin = new Padding(4, 4, 25, 4);
            dgvCustomers.MultiSelect = false;
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new Size(483, 426);
            dgvCustomers.TabIndex = 2;
            dgvCustomers.SelectionChanged += dgvCustomers_SelectionChanged;
            // 
            // clmCustomer
            // 
            clmCustomer.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clmCustomer.HeaderText = "Customer Name";
            clmCustomer.MinimumWidth = 6;
            clmCustomer.Name = "clmCustomer";
            clmCustomer.ReadOnly = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new System.Drawing.Point(155, 507);
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
            btnNew.Location = new System.Drawing.Point(29, 507);
            btnNew.Margin = new Padding(4);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(118, 36);
            btnNew.TabIndex = 3;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // txtCustomer
            // 
            txtCustomer.Location = new System.Drawing.Point(541, 142);
            txtCustomer.Margin = new Padding(4);
            txtCustomer.MaxLength = 30;
            txtCustomer.Name = "txtCustomer";
            txtCustomer.ReadOnly = true;
            txtCustomer.Size = new Size(407, 31);
            txtCustomer.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(541, 113);
            label1.Margin = new Padding(4, 15, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 11;
            label1.Text = "Name";
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(832, 507);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(118, 36);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Visible = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(644, 507);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(180, 36);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save Customer";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Visible = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new System.Drawing.Point(101, 32);
            txtSearch.Margin = new Padding(4);
            txtSearch.MaxLength = 30;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(411, 31);
            txtSearch.TabIndex = 1;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new System.Drawing.Point(29, 35);
            lblSearch.Margin = new Padding(4, 0, 4, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(64, 25);
            lblSearch.TabIndex = 15;
            lblSearch.Text = "Search";
            // 
            // btnSelect
            // 
            btnSelect.Enabled = false;
            btnSelect.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSelect.Location = new System.Drawing.Point(541, 497);
            btnSelect.Margin = new Padding(4);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(407, 46);
            btnSelect.TabIndex = 7;
            btnSelect.Text = "Select Customer";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnLoadAll
            // 
            btnLoadAll.Location = new System.Drawing.Point(281, 507);
            btnLoadAll.Margin = new Padding(4);
            btnLoadAll.Name = "btnLoadAll";
            btnLoadAll.Size = new Size(118, 36);
            btnLoadAll.TabIndex = 5;
            btnLoadAll.Text = "Load All";
            btnLoadAll.UseVisualStyleBackColor = true;
            btnLoadAll.Click += btnLoadAll_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(541, 73);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(178, 25);
            label3.TabIndex = 19;
            label3.Text = "CUSTOMER DETAILS";
            // 
            // frmCustomers
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(977, 572);
            Controls.Add(label3);
            Controls.Add(btnLoadAll);
            Controls.Add(btnSelect);
            Controls.Add(lblSearch);
            Controls.Add(txtSearch);
            Controls.Add(dgvCustomers);
            Controls.Add(btnEdit);
            Controls.Add(btnNew);
            Controls.Add(txtCustomer);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCustomers";
            Padding = new Padding(25);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Customers";
            FormClosing += frmCustomers_FormClosing;
            Load += frmCustomers_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCustomers;
        private DataGridViewTextBoxColumn clmCategory;
        private Button btnEdit;
        private Button btnNew;
        private TextBox txtCustomer;
        private Label label1;
        private Button btnCancel;
        private Button btnSave;
        private TextBox txtSearch;
        private Label lblSearch;
        private DataGridViewTextBoxColumn clmCustomer;
        private Button btnSelect;
        private Button btnLoadAll;
        private Label label3;
    }
}