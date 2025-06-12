﻿namespace Point.Client.Main
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
            menuStrip1 = new MenuStrip();
            productsToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            btnItemUnits = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            btnItems = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            btnPriceTypes = new ToolStripMenuItem();
            btnCategories = new ToolStripMenuItem();
            btnUnits = new ToolStripMenuItem();
            btnTags = new ToolStripMenuItem();
            tsbtnStocks = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripDropDownButton2 = new ToolStripDropDownButton();
            btnOrders = new ToolStripMenuItem();
            btnOrderForm = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStrip2 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripLabel2 = new ToolStripLabel();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            toolStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { productsToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(1426, 28);
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
            toolStrip1.BackColor = SystemColors.Control;
            toolStrip1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1, tsbtnStocks, toolStripSeparator1, toolStripDropDownButton2, toolStripSeparator3, toolStripButton1, toolStripButton2 });
            toolStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            toolStrip1.Location = new System.Drawing.Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1426, 102);
            toolStrip1.TabIndex = 6;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { btnItemUnits, toolStripSeparator4, btnItems, toolStripSeparator5, btnPriceTypes, btnCategories, btnUnits, btnTags });
            toolStripDropDownButton1.Image = Properties.Resources.products;
            toolStripDropDownButton1.ImageScaling = ToolStripItemImageScaling.None;
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Margin = new Padding(0);
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Padding = new Padding(10);
            toolStripDropDownButton1.Size = new Size(105, 102);
            toolStripDropDownButton1.Text = "Listings";
            toolStripDropDownButton1.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // btnItemUnits
            // 
            btnItemUnits.Name = "btnItemUnits";
            btnItemUnits.Size = new Size(248, 30);
            btnItemUnits.Text = "Manage Item-units";
            btnItemUnits.Click += btnItemUnits_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(245, 6);
            // 
            // btnItems
            // 
            btnItems.Name = "btnItems";
            btnItems.Size = new Size(248, 30);
            btnItems.Text = "Items";
            btnItems.Click += btnItems_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(245, 6);
            // 
            // btnPriceTypes
            // 
            btnPriceTypes.Name = "btnPriceTypes";
            btnPriceTypes.Size = new Size(248, 30);
            btnPriceTypes.Text = "Price Types";
            btnPriceTypes.Click += btnPriceTypes_Click;
            // 
            // btnCategories
            // 
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(248, 30);
            btnCategories.Text = "Categories";
            btnCategories.Click += btnCategories_Click;
            // 
            // btnUnits
            // 
            btnUnits.Name = "btnUnits";
            btnUnits.Size = new Size(248, 30);
            btnUnits.Text = "Units";
            btnUnits.Click += btnUnits_Click;
            // 
            // btnTags
            // 
            btnTags.Name = "btnTags";
            btnTags.Size = new Size(248, 30);
            btnTags.Text = "Tags";
            btnTags.Click += btnTags_Click;
            // 
            // tsbtnStocks
            // 
            tsbtnStocks.Image = Properties.Resources.stocks;
            tsbtnStocks.ImageScaling = ToolStripItemImageScaling.None;
            tsbtnStocks.ImageTransparentColor = Color.Magenta;
            tsbtnStocks.Name = "tsbtnStocks";
            tsbtnStocks.Padding = new Padding(10);
            tsbtnStocks.Size = new Size(87, 99);
            tsbtnStocks.Text = "Stocks";
            tsbtnStocks.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 102);
            // 
            // toolStripDropDownButton2
            // 
            toolStripDropDownButton2.DropDownItems.AddRange(new ToolStripItem[] { btnOrders, btnOrderForm });
            toolStripDropDownButton2.Image = Properties.Resources.orders;
            toolStripDropDownButton2.ImageScaling = ToolStripItemImageScaling.None;
            toolStripDropDownButton2.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            toolStripDropDownButton2.Size = new Size(80, 99);
            toolStripDropDownButton2.Text = "Orders";
            toolStripDropDownButton2.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // btnOrders
            // 
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(227, 30);
            btnOrders.Text = "Manager Orders";
            btnOrders.Click += btnOrders_Click;
            // 
            // btnOrderForm
            // 
            btnOrderForm.Name = "btnOrderForm";
            btnOrderForm.Size = new Size(227, 30);
            btnOrderForm.Text = "Order Form";
            btnOrderForm.Click += btnOrderForm_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 102);
            // 
            // toolStripButton1
            // 
            toolStripButton1.Image = Properties.Resources.sales;
            toolStripButton1.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Padding = new Padding(10);
            toolStripButton1.Size = new Size(76, 99);
            toolStripButton1.Text = "Sales";
            toolStripButton1.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripButton2
            // 
            toolStripButton2.Image = Properties.Resources.reports;
            toolStripButton2.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Padding = new Padding(10);
            toolStripButton2.Size = new Size(97, 99);
            toolStripButton2.Text = "Reports";
            toolStripButton2.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStrip2
            // 
            toolStrip2.Dock = DockStyle.Bottom;
            toolStrip2.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip2.ImageScalingSize = new Size(20, 20);
            toolStrip2.Items.AddRange(new ToolStripItem[] { toolStripLabel1, toolStripSeparator2, toolStripLabel2 });
            toolStrip2.Location = new System.Drawing.Point(0, 826);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(1426, 25);
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
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1426, 851);
            Controls.Add(toolStrip2);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IsMdiContainer = true;
            Name = "frmMain";
            Text = "Point Client";
            WindowState = FormWindowState.Maximized;
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
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
        private Panel panel1;
        private Label lblNewOrders;
        private ToolStrip toolStrip2;
        private ToolStripLabel toolStripLabel1;
        private ToolStripLabel toolStripLabel2;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem btnCategories;
        private ToolStripMenuItem btnUnits;
        private ToolStripMenuItem btnTags;
        private ToolStripMenuItem btnItemUnits;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem btnItems;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripDropDownButton toolStripDropDownButton2;
        private ToolStripMenuItem btnOrders;
        private ToolStripMenuItem btnOrderForm;
        private ToolStripMenuItem btnPriceTypes;
    }
}
