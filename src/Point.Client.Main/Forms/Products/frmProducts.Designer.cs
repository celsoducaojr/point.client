namespace Point.Client.Main.Products
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
            toolStripButton1 = new ToolStripButton();
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
            btnCancel = new Button();
            btnSave = new Button();
            panel3 = new Panel();
            richTextBox2 = new RichTextBox();
            textBox5 = new TextBox();
            label11 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label6 = new Label();
            linkLabel2 = new LinkLabel();
            comboBox2 = new ComboBox();
            textBox2 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            richTextBox1 = new RichTextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            lnkManageItems = new LinkLabel();
            label1 = new Label();
            comboBox1 = new ComboBox();
            panel2 = new Panel();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbtnNewItemUnit, toolStripButton3, toolStripSeparator1, toolStripButton1 });
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
            tsbtnNewItemUnit.Size = new Size(108, 24);
            tsbtnNewItemUnit.Text = "New Item Unit";
            tsbtnNewItemUnit.TextAlign = ContentAlignment.MiddleRight;
            tsbtnNewItemUnit.Click += tsbtnNewItemUnit_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(104, 24);
            toolStripButton3.Text = "Edit Item Unit";
            toolStripButton3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(132, 24);
            toolStripButton1.Text = "Remove Item Unit";
            toolStripButton1.TextAlign = ContentAlignment.MiddleRight;
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
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(richTextBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lnkManageItems);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(comboBox1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new System.Drawing.Point(552, 90);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20);
            panel1.Size = new Size(626, 592);
            panel1.TabIndex = 3;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom;
            btnCancel.Location = new System.Drawing.Point(509, 540);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 21;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom;
            btnSave.Location = new System.Drawing.Point(409, 540);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 20;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(richTextBox2);
            panel3.Controls.Add(textBox5);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(textBox4);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(linkLabel2);
            panel3.Controls.Add(comboBox2);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(label5);
            panel3.Location = new System.Drawing.Point(23, 187);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(20);
            panel3.Size = new Size(580, 347);
            panel3.TabIndex = 19;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new System.Drawing.Point(143, 193);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(412, 69);
            richTextBox2.TabIndex = 19;
            richTextBox2.Text = "";
            // 
            // textBox5
            // 
            textBox5.Location = new System.Drawing.Point(143, 123);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(170, 27);
            textBox5.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(72, 196);
            label11.Name = "label11";
            label11.Size = new Size(65, 20);
            label11.TabIndex = 18;
            label11.Text = "Remarks";
            // 
            // textBox4
            // 
            textBox4.Location = new System.Drawing.Point(143, 90);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(210, 27);
            textBox4.TabIndex = 20;
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(143, 57);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(210, 27);
            textBox3.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(57, 126);
            label10.Name = "label10";
            label10.Size = new Size(80, 20);
            label10.TabIndex = 17;
            label10.Text = "Price Code";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(54, 63);
            label9.Name = "label9";
            label9.Size = new Size(83, 20);
            label9.TabIndex = 16;
            label9.Text = "Retail Price";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(23, 93);
            label8.Name = "label8";
            label8.Size = new Size(114, 20);
            label8.TabIndex = 15;
            label8.Text = "Wholesale Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(59, 160);
            label6.Name = "label6";
            label6.Size = new Size(78, 20);
            label6.TabIndex = 12;
            label6.Text = "Item Code";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new System.Drawing.Point(253, 24);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(100, 20);
            linkLabel2.TabIndex = 11;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Manage Units";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new System.Drawing.Point(143, 23);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(104, 28);
            comboBox2.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(143, 156);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(215, 27);
            textBox2.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(101, 27);
            label5.Name = "label5";
            label5.Size = new Size(36, 20);
            label5.TabIndex = 2;
            label5.Text = "Unit";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(23, 164);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 18;
            label4.Text = "Item Unit";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new System.Drawing.Point(114, 90);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(371, 71);
            richTextBox1.TabIndex = 17;
            richTextBox1.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(23, 93);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 16;
            label3.Text = "Description";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(114, 57);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(211, 27);
            textBox1.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(39, 60);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 14;
            label2.Text = "Category";
            // 
            // lnkManageItems
            // 
            lnkManageItems.AutoSize = true;
            lnkManageItems.Location = new System.Drawing.Point(500, 26);
            lnkManageItems.Name = "lnkManageItems";
            lnkManageItems.Size = new Size(103, 20);
            lnkManageItems.TabIndex = 13;
            lnkManageItems.TabStop = true;
            lnkManageItems.Text = "Manage Items";
            lnkManageItems.LinkClicked += lnkManageItems_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(69, 26);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 12;
            label1.Text = "Item";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(114, 23);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(380, 28);
            comboBox1.TabIndex = 11;
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton tsbtnNewItemUnit;
        private ToolStripButton toolStripButton1;
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
        private Button btnCancel;
        private Button btnSave;
        private Panel panel3;
        private RichTextBox richTextBox2;
        private TextBox textBox5;
        private Label label11;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label6;
        private LinkLabel linkLabel2;
        private ComboBox comboBox2;
        private TextBox textBox2;
        private Label label5;
        private Label label4;
        private RichTextBox richTextBox1;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private LinkLabel lnkManageItems;
        private Label label1;
        private ComboBox comboBox1;
    }
}