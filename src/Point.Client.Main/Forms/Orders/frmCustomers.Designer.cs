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
            label3 = new Label();
            txtMobile = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnSelect = new Button();
            txtAddress = new TextBox();
            txtRemarks = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            // 
            // dgvCustomers
            // 
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AllowUserToDeleteRows = false;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Columns.AddRange(new DataGridViewColumn[] { clmCustomer });
            dgvCustomers.Location = new System.Drawing.Point(29, 29);
            dgvCustomers.Margin = new Padding(4, 4, 25, 4);
            dgvCustomers.MultiSelect = false;
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new Size(483, 591);
            dgvCustomers.TabIndex = 1;
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
            btnEdit.Location = new System.Drawing.Point(1054, 623);
            btnEdit.Margin = new Padding(4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(118, 36);
            btnEdit.TabIndex = 10;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new System.Drawing.Point(928, 623);
            btnNew.Margin = new Padding(4);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(118, 36);
            btnNew.TabIndex = 9;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // txtCustomer
            // 
            txtCustomer.Location = new System.Drawing.Point(686, 69);
            txtCustomer.Margin = new Padding(4);
            txtCustomer.MaxLength = 100;
            txtCustomer.Name = "txtCustomer";
            txtCustomer.ReadOnly = true;
            txtCustomer.Size = new Size(486, 31);
            txtCustomer.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(619, 72);
            label1.Margin = new Padding(4, 15, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 11;
            label1.Text = "Name";
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(1054, 623);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(118, 36);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Visible = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(866, 623);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(180, 36);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save Customer";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Visible = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new System.Drawing.Point(29, 628);
            txtSearch.Margin = new Padding(4);
            txtSearch.MaxLength = 30;
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search customer...";
            txtSearch.Size = new Size(483, 31);
            txtSearch.TabIndex = 2;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(541, 29);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(178, 25);
            label3.TabIndex = 19;
            label3.Text = "CUSTOMER DETAILS";
            // 
            // txtMobile
            // 
            txtMobile.Location = new System.Drawing.Point(686, 105);
            txtMobile.Margin = new Padding(4);
            txtMobile.MaxLength = 15;
            txtMobile.Name = "txtMobile";
            txtMobile.ReadOnly = true;
            txtMobile.Size = new Size(289, 31);
            txtMobile.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(541, 108);
            label2.Margin = new Padding(4, 15, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(137, 25);
            label2.TabIndex = 21;
            label2.Text = "Mobile Number";
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(686, 144);
            txtEmail.Margin = new Padding(4);
            txtEmail.MaxLength = 50;
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(289, 31);
            txtEmail.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(624, 147);
            label4.Margin = new Padding(4, 15, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 23;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(601, 186);
            label5.Margin = new Padding(4, 15, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(77, 25);
            label5.TabIndex = 24;
            label5.Text = "Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(599, 276);
            label6.Margin = new Padding(4, 15, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(79, 25);
            label6.TabIndex = 25;
            label6.Text = "Remarks";
            // 
            // btnSelect
            // 
            btnSelect.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSelect.Location = new System.Drawing.Point(541, 363);
            btnSelect.Margin = new Padding(4);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(631, 50);
            btnSelect.TabIndex = 8;
            btnSelect.Text = "Select Customer";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // txtAddress
            // 
            txtAddress.Location = new System.Drawing.Point(686, 183);
            txtAddress.Margin = new Padding(4);
            txtAddress.MaxLength = 250;
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
            txtAddress.ScrollBars = ScrollBars.Vertical;
            txtAddress.Size = new Size(486, 82);
            txtAddress.TabIndex = 6;
            // 
            // txtRemarks
            // 
            txtRemarks.Location = new System.Drawing.Point(686, 273);
            txtRemarks.Margin = new Padding(4);
            txtRemarks.MaxLength = 250;
            txtRemarks.Multiline = true;
            txtRemarks.Name = "txtRemarks";
            txtRemarks.ReadOnly = true;
            txtRemarks.ScrollBars = ScrollBars.Vertical;
            txtRemarks.Size = new Size(486, 82);
            txtRemarks.TabIndex = 7;
            // 
            // frmCustomers
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1201, 688);
            Controls.Add(txtRemarks);
            Controls.Add(txtAddress);
            Controls.Add(btnSelect);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(txtMobile);
            Controls.Add(label2);
            Controls.Add(label3);
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
            ShowInTaskbar = false;
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
        private DataGridViewTextBoxColumn clmCustomer;
        private Label label3;
        private TextBox txtMobile;
        private Label label2;
        private TextBox txtEmail;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnSelect;
        private TextBox txtAddress;
        private TextBox txtRemarks;
    }
}