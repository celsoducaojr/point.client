namespace Point.Client.Main.Listing
{
    partial class frmProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducts));
            toolStrip1 = new ToolStrip();
            tsbtnNewItemUnit = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            dgvProducts = new DataGridView();
            clmName = new DataGridViewTextBoxColumn();
            clmCategory = new DataGridViewTextBoxColumn();
            clmUnit = new DataGridViewTextBoxColumn();
            clmItemCode = new DataGridViewTextBoxColumn();
            clmWholesalePrice = new DataGridViewTextBoxColumn();
            clmRetailPrice = new DataGridViewTextBoxColumn();
            clmPriceCode = new DataGridViewTextBoxColumn();
            clmRemarks = new DataGridViewTextBoxColumn();
            lblTitle = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbtnNewItemUnit, toolStripButton3, toolStripSeparator1 });
            toolStrip1.Location = new System.Drawing.Point(0, 63);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1178, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnNewItemUnit
            // 
            tsbtnNewItemUnit.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbtnNewItemUnit.Image = (Image)resources.GetObject("tsbtnNewItemUnit.Image");
            tsbtnNewItemUnit.ImageTransparentColor = Color.Magenta;
            tsbtnNewItemUnit.Name = "tsbtnNewItemUnit";
            tsbtnNewItemUnit.Size = new Size(98, 24);
            tsbtnNewItemUnit.Text = "New Product";
            tsbtnNewItemUnit.TextAlign = ContentAlignment.MiddleRight;
            tsbtnNewItemUnit.Click += tsbtnNewItemUnit_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(94, 24);
            toolStripButton3.Text = "Edit Product";
            toolStripButton3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { clmName, clmCategory, clmUnit, clmItemCode, clmWholesalePrice, clmRetailPrice, clmPriceCode, clmRemarks });
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.Location = new System.Drawing.Point(0, 90);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(552, 471);
            dgvProducts.TabIndex = 1;
            // 
            // clmName
            // 
            clmName.HeaderText = "Name";
            clmName.MinimumWidth = 6;
            clmName.Name = "clmName";
            clmName.ReadOnly = true;
            clmName.Width = 125;
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
            // clmItemCode
            // 
            clmItemCode.HeaderText = "Item Code";
            clmItemCode.MinimumWidth = 6;
            clmItemCode.Name = "clmItemCode";
            clmItemCode.ReadOnly = true;
            clmItemCode.Width = 125;
            // 
            // clmWholesalePrice
            // 
            clmWholesalePrice.HeaderText = "Wholesale";
            clmWholesalePrice.MinimumWidth = 6;
            clmWholesalePrice.Name = "clmWholesalePrice";
            clmWholesalePrice.ReadOnly = true;
            clmWholesalePrice.Width = 125;
            // 
            // clmRetailPrice
            // 
            clmRetailPrice.HeaderText = "Retail";
            clmRetailPrice.MinimumWidth = 6;
            clmRetailPrice.Name = "clmRetailPrice";
            clmRetailPrice.ReadOnly = true;
            clmRetailPrice.Width = 125;
            // 
            // clmPriceCode
            // 
            clmPriceCode.HeaderText = "Price Code";
            clmPriceCode.MinimumWidth = 6;
            clmPriceCode.Name = "clmPriceCode";
            clmPriceCode.ReadOnly = true;
            clmPriceCode.Width = 125;
            // 
            // clmRemarks
            // 
            clmRemarks.HeaderText = "Remarks";
            clmRemarks.MinimumWidth = 6;
            clmRemarks.Name = "clmRemarks";
            clmRemarks.ReadOnly = true;
            clmRemarks.Width = 125;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.DeepSkyBlue;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new System.Drawing.Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1178, 63);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Manage Products";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Right;
            panel1.Location = new System.Drawing.Point(552, 90);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20);
            panel1.Size = new Size(626, 592);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new System.Drawing.Point(0, 561);
            panel2.Name = "panel2";
            panel2.Size = new Size(552, 121);
            panel2.TabIndex = 4;
            // 
            // frmProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 682);
            Controls.Add(dgvProducts);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            Controls.Add(lblTitle);
            Name = "frmProducts";
            Text = "Products";
            WindowState = FormWindowState.Maximized;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton tsbtnNewItemUnit;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton3;
        private DataGridView dgvProducts;
        private Label lblTitle;
        private DataGridViewTextBoxColumn clmName;
        private DataGridViewTextBoxColumn clmCategory;
        private DataGridViewTextBoxColumn clmUnit;
        private DataGridViewTextBoxColumn clmItemCode;
        private DataGridViewTextBoxColumn clmWholesalePrice;
        private DataGridViewTextBoxColumn clmRetailPrice;
        private DataGridViewTextBoxColumn clmPriceCode;
        private DataGridViewTextBoxColumn clmRemarks;
        private Panel panel1;
        private Panel panel2;
    }
}