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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrderItem));
            tsPages = new ToolStrip();
            toolStripLabel2 = new ToolStripLabel();
            cmbPageSize = new ToolStripComboBox();
            toolStripSeparator2 = new ToolStripSeparator();
            btnLast = new ToolStripButton();
            btnNext = new ToolStripButton();
            lblTotalPage = new ToolStripLabel();
            txtPage = new ToolStripTextBox();
            toolStripLabel1 = new ToolStripLabel();
            btnPrev = new ToolStripButton();
            btnFirst = new ToolStripButton();
            label1 = new Label();
            txtItem = new TextBox();
            dgvItemUnits = new DataGridView();
            clmItem = new DataGridViewTextBoxColumn();
            clmUnit = new DataGridViewTextBoxColumn();
            clmItemCode = new DataGridViewTextBoxColumn();
            clmPriceCode = new DataGridViewTextBoxColumn();
            tsPages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItemUnits).BeginInit();
            SuspendLayout();
            // 
            // tsPages
            // 
            tsPages.Dock = DockStyle.Bottom;
            tsPages.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tsPages.GripStyle = ToolStripGripStyle.Hidden;
            tsPages.ImageScalingSize = new Size(20, 20);
            tsPages.Items.AddRange(new ToolStripItem[] { toolStripLabel2, cmbPageSize, toolStripSeparator2, btnLast, btnNext, lblTotalPage, txtPage, toolStripLabel1, btnPrev, btnFirst });
            tsPages.Location = new System.Drawing.Point(0, 812);
            tsPages.Name = "tsPages";
            tsPages.Size = new Size(1457, 31);
            tsPages.TabIndex = 3;
            tsPages.Text = "toolStrip2";
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Alignment = ToolStripItemAlignment.Right;
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(144, 28);
            toolStripLabel2.Text = "items per page";
            // 
            // cmbPageSize
            // 
            cmbPageSize.Alignment = ToolStripItemAlignment.Right;
            cmbPageSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPageSize.DropDownWidth = 75;
            cmbPageSize.Name = "cmbPageSize";
            cmbPageSize.Size = new Size(93, 31);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Alignment = ToolStripItemAlignment.Right;
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 31);
            // 
            // btnLast
            // 
            btnLast.Alignment = ToolStripItemAlignment.Right;
            btnLast.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnLast.Image = (Image)resources.GetObject("btnLast.Image");
            btnLast.ImageTransparentColor = Color.Magenta;
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(44, 28);
            btnLast.Text = ">>";
            btnLast.ToolTipText = "last page";
            // 
            // btnNext
            // 
            btnNext.Alignment = ToolStripItemAlignment.Right;
            btnNext.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnNext.Image = (Image)resources.GetObject("btnNext.Image");
            btnNext.ImageTransparentColor = Color.Magenta;
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(29, 28);
            btnNext.Text = ">";
            btnNext.ToolTipText = "next page";
            // 
            // lblTotalPage
            // 
            lblTotalPage.Alignment = ToolStripItemAlignment.Right;
            lblTotalPage.Name = "lblTotalPage";
            lblTotalPage.Size = new Size(44, 28);
            lblTotalPage.Text = "of 0";
            // 
            // txtPage
            // 
            txtPage.Alignment = ToolStripItemAlignment.Right;
            txtPage.Name = "txtPage";
            txtPage.Size = new Size(68, 31);
            txtPage.TextBoxTextAlign = HorizontalAlignment.Center;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Alignment = ToolStripItemAlignment.Right;
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(54, 28);
            toolStripLabel1.Text = "page";
            // 
            // btnPrev
            // 
            btnPrev.Alignment = ToolStripItemAlignment.Right;
            btnPrev.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnPrev.Image = (Image)resources.GetObject("btnPrev.Image");
            btnPrev.ImageTransparentColor = Color.Magenta;
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(29, 28);
            btnPrev.Text = "<";
            btnPrev.ToolTipText = "previous page";
            // 
            // btnFirst
            // 
            btnFirst.Alignment = ToolStripItemAlignment.Right;
            btnFirst.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnFirst.Image = (Image)resources.GetObject("btnFirst.Image");
            btnFirst.ImageTransparentColor = Color.Magenta;
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(44, 28);
            btnFirst.Text = "<<";
            btnFirst.ToolTipText = "first page";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F);
            label1.Location = new System.Drawing.Point(13, 16);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(72, 38);
            label1.TabIndex = 36;
            label1.Text = "Item";
            // 
            // txtItem
            // 
            txtItem.Font = new Font("Segoe UI", 16.2F);
            txtItem.Location = new System.Drawing.Point(93, 13);
            txtItem.Margin = new Padding(4);
            txtItem.MaxLength = 100;
            txtItem.Name = "txtItem";
            txtItem.Size = new Size(1351, 43);
            txtItem.TabIndex = 1;
            // 
            // dgvItemUnits
            // 
            dgvItemUnits.AllowUserToAddRows = false;
            dgvItemUnits.AllowUserToDeleteRows = false;
            dgvItemUnits.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItemUnits.Columns.AddRange(new DataGridViewColumn[] { clmItem, clmUnit, clmItemCode, clmPriceCode });
            dgvItemUnits.Dock = DockStyle.Bottom;
            dgvItemUnits.Location = new System.Drawing.Point(0, 64);
            dgvItemUnits.Margin = new Padding(4);
            dgvItemUnits.Name = "dgvItemUnits";
            dgvItemUnits.ReadOnly = true;
            dgvItemUnits.RowHeadersWidth = 51;
            dgvItemUnits.Size = new Size(1457, 748);
            dgvItemUnits.TabIndex = 2;
            // 
            // clmItem
            // 
            clmItem.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clmItem.HeaderText = "Item";
            clmItem.MinimumWidth = 6;
            clmItem.Name = "clmItem";
            clmItem.ReadOnly = true;
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
            clmItemCode.MaxInputLength = 50;
            clmItemCode.MinimumWidth = 6;
            clmItemCode.Name = "clmItemCode";
            clmItemCode.ReadOnly = true;
            clmItemCode.Width = 175;
            // 
            // clmPriceCode
            // 
            clmPriceCode.HeaderText = "Price Code";
            clmPriceCode.MaxInputLength = 50;
            clmPriceCode.MinimumWidth = 6;
            clmPriceCode.Name = "clmPriceCode";
            clmPriceCode.ReadOnly = true;
            clmPriceCode.Width = 125;
            // 
            // frmOrderItem
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1457, 843);
            Controls.Add(dgvItemUnits);
            Controls.Add(label1);
            Controls.Add(txtItem);
            Controls.Add(tsPages);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmOrderItem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Order Item";
            Load += frmOrderItem_Load;
            tsPages.ResumeLayout(false);
            tsPages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItemUnits).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStrip tsPages;
        private ToolStripLabel toolStripLabel2;
        private ToolStripComboBox cmbPageSize;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnLast;
        private ToolStripButton btnNext;
        private ToolStripLabel lblTotalPage;
        private ToolStripTextBox txtPage;
        private ToolStripLabel toolStripLabel1;
        private ToolStripButton btnPrev;
        private ToolStripButton btnFirst;
        private ComboBox cmbCategory;
        private Button btnClear;
        private Label lblTag;
        private TextBox txtTag;
        private Label label2;
        private Button btnSearch;
        private ComboBox comboBox1;
        private Label label3;
        private Button button1;
        private DataGridView dgvTags;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewButtonColumn clmRemove;
        private Label label1;
        private TextBox txtItem;
        private DataGridView dgvItemUnits;
        private DataGridViewTextBoxColumn clmItem;
        private DataGridViewTextBoxColumn clmUnit;
        private DataGridViewTextBoxColumn clmItemCode;
        private DataGridViewTextBoxColumn clmPriceCode;
    }
}