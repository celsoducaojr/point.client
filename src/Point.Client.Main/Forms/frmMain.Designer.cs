namespace Point.Client.Main
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            menuStrip1 = new MenuStrip();
            productsToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            btnProducts = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            btnItems = new ToolStripMenuItem();
            btnCategories = new ToolStripMenuItem();
            btnUnits = new ToolStripMenuItem();
            btnTags = new ToolStripMenuItem();
            tsbtnStocks = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbtnOrders = new ToolStripButton();
            tsbtnSales = new ToolStripButton();
            toolStripDropDownButton2 = new ToolStripDropDownButton();
            contextMenuStrip1 = new ContextMenuStrip(components);
            dgvOrders = new DataGridView();
            clmOrderNumber = new DataGridViewTextBoxColumn();
            toolStrip2 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripLabel2 = new ToolStripLabel();
            pnOrders = new Panel();
            lblOrders = new Label();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            toolStrip2.SuspendLayout();
            pnOrders.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { productsToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1226, 28);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // productsToolStripMenuItem
            // 
            productsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            productsToolStripMenuItem.Size = new Size(70, 24);
            productsToolStripMenuItem.Text = "System";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(116, 26);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // toolStrip1
            // 
            toolStrip1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1, tsbtnStocks, toolStripSeparator1, tsbtnOrders, tsbtnSales, toolStripDropDownButton2 });
            toolStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            toolStrip1.Location = new System.Drawing.Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1226, 103);
            toolStrip1.TabIndex = 6;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.AutoSize = false;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { btnProducts, toolStripSeparator4, btnItems, btnCategories, btnUnits, btnTags });
            toolStripDropDownButton1.ImageScaling = ToolStripItemImageScaling.None;
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(96, 100);
            toolStripDropDownButton1.Text = "Products";
            toolStripDropDownButton1.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // btnProducts
            // 
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(237, 30);
            btnProducts.Text = "Manage Products";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(234, 6);
            // 
            // btnItems
            // 
            btnItems.Name = "btnItems";
            btnItems.Size = new Size(237, 30);
            btnItems.Text = "Items";
            // 
            // btnCategories
            // 
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(237, 30);
            btnCategories.Text = "Categories";
            // 
            // btnUnits
            // 
            btnUnits.Name = "btnUnits";
            btnUnits.Size = new Size(237, 30);
            btnUnits.Text = "Units";
            // 
            // btnTags
            // 
            btnTags.Name = "btnTags";
            btnTags.Size = new Size(237, 30);
            btnTags.Text = "Tags";
            // 
            // tsbtnStocks
            // 
            tsbtnStocks.Image = (Image)resources.GetObject("tsbtnStocks.Image");
            tsbtnStocks.ImageTransparentColor = Color.Magenta;
            tsbtnStocks.Name = "tsbtnStocks";
            tsbtnStocks.Size = new Size(87, 100);
            tsbtnStocks.Text = "Stocks";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 103);
            // 
            // tsbtnOrders
            // 
            tsbtnOrders.Image = (Image)resources.GetObject("tsbtnOrders.Image");
            tsbtnOrders.ImageTransparentColor = Color.Magenta;
            tsbtnOrders.Name = "tsbtnOrders";
            tsbtnOrders.Size = new Size(90, 100);
            tsbtnOrders.Text = "Orders";
            // 
            // tsbtnSales
            // 
            tsbtnSales.Image = (Image)resources.GetObject("tsbtnSales.Image");
            tsbtnSales.ImageTransparentColor = Color.Magenta;
            tsbtnSales.Name = "tsbtnSales";
            tsbtnSales.Size = new Size(76, 100);
            tsbtnSales.Text = "Sales";
            // 
            // toolStripDropDownButton2
            // 
            toolStripDropDownButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripDropDownButton2.Image = (Image)resources.GetObject("toolStripDropDownButton2.Image");
            toolStripDropDownButton2.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            toolStripDropDownButton2.Size = new Size(34, 100);
            toolStripDropDownButton2.Text = "toolStripDropDownButton2";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // dgvOrders
            // 
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.AllowUserToDeleteRows = false;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Columns.AddRange(new DataGridViewColumn[] { clmOrderNumber });
            dgvOrders.Dock = DockStyle.Fill;
            dgvOrders.Location = new System.Drawing.Point(0, 23);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.RowHeadersWidth = 51;
            dgvOrders.Size = new Size(250, 439);
            dgvOrders.TabIndex = 1;
            // 
            // clmOrderNumber
            // 
            clmOrderNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clmOrderNumber.HeaderText = "Order Number";
            clmOrderNumber.MinimumWidth = 6;
            clmOrderNumber.Name = "clmOrderNumber";
            clmOrderNumber.ReadOnly = true;
            // 
            // toolStrip2
            // 
            toolStrip2.Dock = DockStyle.Bottom;
            toolStrip2.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip2.ImageScalingSize = new Size(20, 20);
            toolStrip2.Items.AddRange(new ToolStripItem[] { toolStripLabel1, toolStripSeparator2, toolStripLabel2 });
            toolStrip2.Location = new System.Drawing.Point(0, 593);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(1226, 25);
            toolStrip2.TabIndex = 10;
            toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Alignment = ToolStripItemAlignment.Right;
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(46, 22);
            toolStripLabel1.Text = "v1.0.0";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Alignment = ToolStripItemAlignment.Right;
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Alignment = ToolStripItemAlignment.Right;
            toolStripLabel2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripLabel2.ForeColor = Color.FromArgb(0, 192, 0);
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(83, 22);
            toolStripLabel2.Text = "Connected";
            // 
            // pnOrders
            // 
            pnOrders.Controls.Add(dgvOrders);
            pnOrders.Controls.Add(lblOrders);
            pnOrders.Dock = DockStyle.Right;
            pnOrders.Location = new System.Drawing.Point(976, 131);
            pnOrders.Name = "pnOrders";
            pnOrders.Size = new Size(250, 462);
            pnOrders.TabIndex = 11;
            // 
            // lblOrders
            // 
            lblOrders.Dock = DockStyle.Top;
            lblOrders.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOrders.Location = new System.Drawing.Point(0, 0);
            lblOrders.Name = "lblOrders";
            lblOrders.Size = new Size(250, 23);
            lblOrders.TabIndex = 2;
            lblOrders.Text = "New Orders";
            lblOrders.TextAlign = ContentAlignment.TopCenter;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1226, 618);
            Controls.Add(pnOrders);
            Controls.Add(toolStrip2);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            Name = "frmMain";
            Text = "Point Client";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            pnOrders.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem productsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbtnStocks;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbtnOrders;
        private ToolStripButton tsbtnSales;
        private ContextMenuStrip contextMenuStrip1;
        private Panel panel1;
        private Label lblNewOrders;
        private DataGridView dgvOrders;
        private DataGridViewTextBoxColumn clmOrderNumber;
        private ToolStrip toolStrip2;
        private Panel pnOrders;
        private Label lblOrders;
        private ToolStripLabel toolStripLabel1;
        private ToolStripLabel toolStripLabel2;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem btnCategories;
        private ToolStripMenuItem btnUnits;
        private ToolStripMenuItem btnTags;
        private ToolStripDropDownButton toolStripDropDownButton2;
        private ToolStripMenuItem btnProducts;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem btnItems;
    }
}
