namespace Point.Client.Main.Forms.Orders
{
    partial class frmOrderItem
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
            txtItem = new TextBox();
            dgvItemUnits = new DataGridView();
            clmItem = new DataGridViewTextBoxColumn();
            clmCategory = new DataGridViewTextBoxColumn();
            clmUnit = new DataGridViewTextBoxColumn();
            clmCapitalCode = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvItemUnits).BeginInit();
            SuspendLayout();
            // 
            // txtItem
            // 
            txtItem.Font = new Font("Segoe UI", 16.2F);
            txtItem.Location = new System.Drawing.Point(13, 13);
            txtItem.Margin = new Padding(4);
            txtItem.MaxLength = 100;
            txtItem.Name = "txtItem";
            txtItem.PlaceholderText = "Search item...";
            txtItem.Size = new Size(1624, 43);
            txtItem.TabIndex = 1;
            txtItem.KeyDown += txtItem_KeyDown;
            // 
            // dgvItemUnits
            // 
            dgvItemUnits.AllowUserToAddRows = false;
            dgvItemUnits.AllowUserToDeleteRows = false;
            dgvItemUnits.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItemUnits.Columns.AddRange(new DataGridViewColumn[] { clmItem, clmCategory, clmUnit, clmCapitalCode });
            dgvItemUnits.Dock = DockStyle.Bottom;
            dgvItemUnits.Location = new System.Drawing.Point(0, 64);
            dgvItemUnits.Margin = new Padding(4);
            dgvItemUnits.MultiSelect = false;
            dgvItemUnits.Name = "dgvItemUnits";
            dgvItemUnits.ReadOnly = true;
            dgvItemUnits.RowHeadersWidth = 51;
            dgvItemUnits.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItemUnits.Size = new Size(1650, 779);
            dgvItemUnits.TabIndex = 2;
            dgvItemUnits.CellDoubleClick += dgvItemUnits_CellDoubleClick;
            dgvItemUnits.KeyDown += dgvItemUnits_KeyDown;
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
            clmCategory.Width = 125;
            // 
            // clmUnit
            // 
            clmUnit.HeaderText = "Unit";
            clmUnit.MinimumWidth = 6;
            clmUnit.Name = "clmUnit";
            clmUnit.ReadOnly = true;
            clmUnit.Width = 125;
            // 
            // clmCapitalCode
            // 
            clmCapitalCode.HeaderText = "Capital Code";
            clmCapitalCode.MaxInputLength = 50;
            clmCapitalCode.MinimumWidth = 6;
            clmCapitalCode.Name = "clmCapitalCode";
            clmCapitalCode.ReadOnly = true;
            clmCapitalCode.Width = 150;
            // 
            // frmOrderItem
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1650, 843);
            Controls.Add(dgvItemUnits);
            Controls.Add(txtItem);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmOrderItem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Search Item";
            Load += frmOrderItem_Load;
            ((System.ComponentModel.ISupportInitialize)dgvItemUnits).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cmbCategory;
        private Button btnClear;
        private Label lblTag;
        private TextBox txtTag;
        private Button btnSearch;
        private ComboBox comboBox1;
        private Label label3;
        private Button button1;
        private DataGridView dgvTags;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewButtonColumn clmRemove;
        private TextBox txtItem;
        private DataGridView dgvItemUnits;
        private DataGridViewTextBoxColumn clmItem;
        private DataGridViewTextBoxColumn clmCategory;
        private DataGridViewTextBoxColumn clmUnit;
        private DataGridViewTextBoxColumn clmCapitalCode;
    }
}