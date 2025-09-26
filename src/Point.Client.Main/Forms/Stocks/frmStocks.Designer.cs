namespace Point.Client.Main.Stocks
{
    partial class frmStocks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStocks));
            lblTitle = new Label();
            label1 = new Label();
            dgvItemUnits = new DataGridView();
            clmItem = new DataGridViewTextBoxColumn();
            clmCategory = new DataGridViewTextBoxColumn();
            clmUnit = new DataGridViewTextBoxColumn();
            clmCapitalCode = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            button1 = new Button();
            btnSearch = new Button();
            cmbUnit = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            txtItem = new TextBox();
            tsPages = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            clmDate = new DataGridViewTextBoxColumn();
            clmChanged = new DataGridViewTextBoxColumn();
            clmAfterChange = new DataGridViewTextBoxColumn();
            clmRemarks = new DataGridViewTextBoxColumn();
            label4 = new Label();
            panel3 = new Panel();
            toolStrip1 = new ToolStrip();
            toolStripLabel3 = new ToolStripLabel();
            toolStripComboBox1 = new ToolStripComboBox();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButton3 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            toolStripLabel4 = new ToolStripLabel();
            toolStripTextBox1 = new ToolStripTextBox();
            toolStripLabel5 = new ToolStripLabel();
            toolStripButton5 = new ToolStripButton();
            toolStripButton6 = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)dgvItemUnits).BeginInit();
            panel1.SuspendLayout();
            tsPages.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.DeepSkyBlue;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new System.Drawing.Point(0, 0);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1282, 42);
            lblTitle.TabIndex = 10;
            lblTitle.Text = "Manage Stocks";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.BackColor = Color.DeepSkyBlue;
            label1.Image = Properties.Resources.stocks_banner;
            label1.Location = new System.Drawing.Point(1230, 2);
            label1.Name = "label1";
            label1.Size = new Size(40, 40);
            label1.TabIndex = 11;
            // 
            // dgvItemUnits
            // 
            dgvItemUnits.AllowUserToAddRows = false;
            dgvItemUnits.AllowUserToDeleteRows = false;
            dgvItemUnits.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItemUnits.Columns.AddRange(new DataGridViewColumn[] { clmItem, clmCategory, clmUnit, clmCapitalCode });
            dgvItemUnits.Dock = DockStyle.Fill;
            dgvItemUnits.Location = new System.Drawing.Point(0, 0);
            dgvItemUnits.Margin = new Padding(4);
            dgvItemUnits.Name = "dgvItemUnits";
            dgvItemUnits.ReadOnly = true;
            dgvItemUnits.RowHeadersWidth = 51;
            dgvItemUnits.Size = new Size(475, 343);
            dgvItemUnits.TabIndex = 13;
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
            clmCapitalCode.HeaderText = "Quantity";
            clmCapitalCode.MaxInputLength = 50;
            clmCapitalCode.MinimumWidth = 6;
            clmCapitalCode.Name = "clmCapitalCode";
            clmCapitalCode.ReadOnly = true;
            clmCapitalCode.Width = 125;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(cmbUnit);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtItem);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 447);
            panel1.Name = "panel1";
            panel1.Size = new Size(1282, 106);
            panel1.TabIndex = 14;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(201, 57);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(118, 36);
            button1.TabIndex = 36;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(13, 57);
            btnSearch.Margin = new Padding(4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(180, 36);
            btnSearch.TabIndex = 35;
            btnSearch.Text = "Search Item";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // cmbUnit
            // 
            cmbUnit.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbUnit.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbUnit.FormattingEnabled = true;
            cmbUnit.Location = new System.Drawing.Point(564, 8);
            cmbUnit.Margin = new Padding(4);
            cmbUnit.Name = "cmbUnit";
            cmbUnit.Size = new Size(292, 28);
            cmbUnit.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(520, 11);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 34;
            label3.Text = "Unit";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(13, 11);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 31;
            label2.Text = "Item";
            // 
            // txtItem
            // 
            txtItem.Location = new System.Drawing.Point(60, 8);
            txtItem.Margin = new Padding(4);
            txtItem.MaxLength = 100;
            txtItem.Name = "txtItem";
            txtItem.Size = new Size(452, 27);
            txtItem.TabIndex = 29;
            // 
            // tsPages
            // 
            tsPages.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tsPages.GripStyle = ToolStripGripStyle.Hidden;
            tsPages.ImageScalingSize = new Size(20, 20);
            tsPages.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2 });
            tsPages.Location = new System.Drawing.Point(0, 42);
            tsPages.Name = "tsPages";
            tsPages.Size = new Size(1282, 31);
            tsPages.TabIndex = 15;
            tsPages.Text = "toolStrip2";
            // 
            // toolStripButton1
            // 
            toolStripButton1.Image = Properties.Resources.add_items_icon;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(176, 28);
            toolStripButton1.Text = "Add New Stocks";
            toolStripButton1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // toolStripButton2
            // 
            toolStripButton2.Image = Properties.Resources.edit_icon;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(98, 28);
            toolStripButton2.Text = "Update";
            toolStripButton2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new System.Drawing.Point(475, 73);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(807, 374);
            panel2.TabIndex = 16;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clmDate, clmChanged, clmAfterChange, clmRemarks });
            dataGridView1.Location = new System.Drawing.Point(14, 42);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(779, 318);
            dataGridView1.TabIndex = 14;
            // 
            // clmDate
            // 
            clmDate.HeaderText = "Date";
            clmDate.MinimumWidth = 6;
            clmDate.Name = "clmDate";
            clmDate.ReadOnly = true;
            clmDate.Width = 125;
            // 
            // clmChanged
            // 
            clmChanged.HeaderText = "Quantity Changed";
            clmChanged.MinimumWidth = 6;
            clmChanged.Name = "clmChanged";
            clmChanged.ReadOnly = true;
            clmChanged.Width = 150;
            // 
            // clmAfterChange
            // 
            clmAfterChange.HeaderText = "Quantity After Change";
            clmAfterChange.MinimumWidth = 6;
            clmAfterChange.Name = "clmAfterChange";
            clmAfterChange.ReadOnly = true;
            clmAfterChange.Width = 150;
            // 
            // clmRemarks
            // 
            clmRemarks.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clmRemarks.HeaderText = "Remarks";
            clmRemarks.MinimumWidth = 6;
            clmRemarks.Name = "clmRemarks";
            clmRemarks.ReadOnly = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(13, 10);
            label4.Name = "label4";
            label4.Size = new Size(128, 28);
            label4.TabIndex = 0;
            label4.Text = "Stock History";
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvItemUnits);
            panel3.Controls.Add(toolStrip1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new System.Drawing.Point(0, 73);
            panel3.Name = "panel3";
            panel3.Size = new Size(475, 374);
            panel3.TabIndex = 17;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel3, toolStripComboBox1, toolStripSeparator1, toolStripButton3, toolStripButton4, toolStripLabel4, toolStripTextBox1, toolStripLabel5, toolStripButton5, toolStripButton6 });
            toolStrip1.Location = new System.Drawing.Point(0, 343);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(475, 31);
            toolStrip1.TabIndex = 14;
            toolStrip1.Text = "toolStrip2";
            // 
            // toolStripLabel3
            // 
            toolStripLabel3.Alignment = ToolStripItemAlignment.Right;
            toolStripLabel3.Name = "toolStripLabel3";
            toolStripLabel3.Size = new Size(144, 28);
            toolStripLabel3.Text = "items per page";
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.Alignment = ToolStripItemAlignment.Right;
            toolStripComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            toolStripComboBox1.DropDownWidth = 75;
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(75, 31);
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Alignment = ToolStripItemAlignment.Right;
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 31);
            // 
            // toolStripButton3
            // 
            toolStripButton3.Alignment = ToolStripItemAlignment.Right;
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(44, 28);
            toolStripButton3.Text = ">>";
            toolStripButton3.ToolTipText = "last page";
            // 
            // toolStripButton4
            // 
            toolStripButton4.Alignment = ToolStripItemAlignment.Right;
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(29, 28);
            toolStripButton4.Text = ">";
            toolStripButton4.ToolTipText = "next page";
            // 
            // toolStripLabel4
            // 
            toolStripLabel4.Alignment = ToolStripItemAlignment.Right;
            toolStripLabel4.Name = "toolStripLabel4";
            toolStripLabel4.Size = new Size(44, 28);
            toolStripLabel4.Text = "of 0";
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Alignment = ToolStripItemAlignment.Right;
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(55, 31);
            toolStripTextBox1.TextBoxTextAlign = HorizontalAlignment.Center;
            // 
            // toolStripLabel5
            // 
            toolStripLabel5.Alignment = ToolStripItemAlignment.Right;
            toolStripLabel5.Name = "toolStripLabel5";
            toolStripLabel5.Size = new Size(54, 28);
            toolStripLabel5.Text = "page";
            // 
            // toolStripButton5
            // 
            toolStripButton5.Alignment = ToolStripItemAlignment.Right;
            toolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton5.Image = (Image)resources.GetObject("toolStripButton5.Image");
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(29, 28);
            toolStripButton5.Text = "<";
            toolStripButton5.ToolTipText = "previous page";
            // 
            // toolStripButton6
            // 
            toolStripButton6.Alignment = ToolStripItemAlignment.Right;
            toolStripButton6.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton6.Image = (Image)resources.GetObject("toolStripButton6.Image");
            toolStripButton6.ImageTransparentColor = Color.Magenta;
            toolStripButton6.Name = "toolStripButton6";
            toolStripButton6.Size = new Size(44, 28);
            toolStripButton6.Text = "<<";
            toolStripButton6.ToolTipText = "first page";
            // 
            // frmStocks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 553);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(tsPages);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            MinimumSize = new Size(1300, 600);
            Name = "frmStocks";
            Text = "Stocks";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgvItemUnits).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tsPages.ResumeLayout(false);
            tsPages.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label label1;
        private DataGridView dgvItemUnits;
        private Panel panel1;
        private ComboBox cmbUnit;
        private Label label3;
        private Label label2;
        private TextBox txtItem;
        private Button button1;
        private Button btnSearch;
        private ToolStrip tsPages;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private DataGridViewTextBoxColumn clmItem;
        private DataGridViewTextBoxColumn clmCategory;
        private DataGridViewTextBoxColumn clmUnit;
        private DataGridViewTextBoxColumn clmCapitalCode;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label4;
        private Panel panel3;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel3;
        private ToolStripComboBox toolStripComboBox1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripLabel toolStripLabel4;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripLabel toolStripLabel5;
        private ToolStripButton toolStripButton5;
        private ToolStripButton toolStripButton6;
        private DataGridViewTextBoxColumn clmDate;
        private DataGridViewTextBoxColumn clmChanged;
        private DataGridViewTextBoxColumn clmAfterChange;
        private DataGridViewTextBoxColumn clmRemarks;
    }
}