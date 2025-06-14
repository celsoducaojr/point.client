namespace Point.Client.Main.Forms.Orders
{
    partial class frmOrder
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
            components = new System.ComponentModel.Container();
            lblTitle = new Label();
            panel1 = new Panel();
            lnkSelectCustomer = new LinkLabel();
            btnAddItem = new Button();
            label7 = new Label();
            label2 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label1 = new Label();
            dgvTags = new DataGridView();
            clmItem = new DataGridViewTextBoxColumn();
            clmUnit = new DataGridViewTextBoxColumn();
            clmQuantity = new DataGridViewTextBoxColumn();
            clmPrice = new DataGridViewTextBoxColumn();
            clmTotal = new DataGridViewTextBoxColumn();
            txtCustomer = new TextBox();
            lblTimestamp = new Label();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            timerTimestamp = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTags).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Teal;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new System.Drawing.Point(0, 0);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1482, 70);
            lblTitle.TabIndex = 11;
            lblTitle.Text = "Order Form";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(lnkSelectCustomer);
            panel1.Controls.Add(btnAddItem);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dgvTags);
            panel1.Controls.Add(txtCustomer);
            panel1.Controls.Add(lblTimestamp);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new System.Drawing.Point(0, 70);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20);
            panel1.Size = new Size(1482, 733);
            panel1.TabIndex = 13;
            // 
            // lnkSelectCustomer
            // 
            lnkSelectCustomer.AutoSize = true;
            lnkSelectCustomer.Location = new System.Drawing.Point(557, 100);
            lnkSelectCustomer.Name = "lnkSelectCustomer";
            lnkSelectCustomer.Size = new Size(165, 28);
            lnkSelectCustomer.TabIndex = 50;
            lnkSelectCustomer.TabStop = true;
            lnkSelectCustomer.Text = "Select Customer...";
            lnkSelectCustomer.LinkClicked += lnkSelectCustomer_LinkClicked;
            // 
            // btnAddItem
            // 
            btnAddItem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddItem.Font = new Font("Segoe UI", 13.8F);
            btnAddItem.Location = new System.Drawing.Point(1231, 60);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(227, 72);
            btnAddItem.TabIndex = 49;
            btnAddItem.Text = "ADD ITEM";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold);
            label7.Location = new System.Drawing.Point(1088, 648);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(95, 46);
            label7.TabIndex = 48;
            label7.Text = "Total";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold);
            label2.Location = new System.Drawing.Point(1191, 633);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(267, 75);
            label2.TabIndex = 47;
            label2.Text = "0.00";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button3.Font = new Font("Segoe UI", 13.8F);
            button3.Location = new System.Drawing.Point(23, 638);
            button3.Name = "button3";
            button3.Size = new Size(188, 72);
            button3.TabIndex = 46;
            button3.Text = "SAVE AS NEW";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.Font = new Font("Segoe UI", 13.8F);
            button2.Location = new System.Drawing.Point(23, 560);
            button2.Name = "button2";
            button2.Size = new Size(382, 72);
            button2.TabIndex = 45;
            button2.Text = "PAID";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.Font = new Font("Segoe UI", 13.8F);
            button1.Location = new System.Drawing.Point(217, 638);
            button1.Name = "button1";
            button1.Size = new Size(188, 72);
            button1.TabIndex = 44;
            button1.Text = "CANCEL";
            button1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new System.Drawing.Point(1057, 596);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(126, 38);
            label11.TabIndex = 41;
            label11.Text = "Discount";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label10.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new System.Drawing.Point(1191, 595);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(267, 38);
            label10.TabIndex = 40;
            label10.Text = "0.00";
            label10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label9.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new System.Drawing.Point(1191, 557);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(267, 38);
            label9.TabIndex = 39;
            label9.Text = "0.00";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new System.Drawing.Point(1053, 558);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(130, 38);
            label8.TabIndex = 38;
            label8.Text = "Sub Total";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(24, 100);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(96, 28);
            label1.TabIndex = 34;
            label1.Text = "Customer";
            // 
            // dgvTags
            // 
            dgvTags.AllowUserToAddRows = false;
            dgvTags.AllowUserToDeleteRows = false;
            dgvTags.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTags.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTags.Columns.AddRange(new DataGridViewColumn[] { clmItem, clmUnit, clmQuantity, clmPrice, clmTotal });
            dgvTags.Location = new System.Drawing.Point(24, 139);
            dgvTags.Margin = new Padding(4);
            dgvTags.MultiSelect = false;
            dgvTags.Name = "dgvTags";
            dgvTags.ReadOnly = true;
            dgvTags.RowHeadersWidth = 51;
            dgvTags.Size = new Size(1434, 414);
            dgvTags.TabIndex = 33;
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
            // clmQuantity
            // 
            clmQuantity.HeaderText = "Quantity";
            clmQuantity.MinimumWidth = 6;
            clmQuantity.Name = "clmQuantity";
            clmQuantity.ReadOnly = true;
            clmQuantity.Width = 125;
            // 
            // clmPrice
            // 
            clmPrice.HeaderText = "Price";
            clmPrice.MinimumWidth = 6;
            clmPrice.Name = "clmPrice";
            clmPrice.ReadOnly = true;
            clmPrice.Width = 125;
            // 
            // clmTotal
            // 
            clmTotal.HeaderText = "Total";
            clmTotal.MinimumWidth = 6;
            clmTotal.Name = "clmTotal";
            clmTotal.ReadOnly = true;
            clmTotal.Width = 150;
            // 
            // txtCustomer
            // 
            txtCustomer.Location = new System.Drawing.Point(128, 97);
            txtCustomer.Margin = new Padding(4);
            txtCustomer.MaxLength = 100;
            txtCustomer.Name = "txtCustomer";
            txtCustomer.ReadOnly = true;
            txtCustomer.Size = new Size(422, 34);
            txtCustomer.TabIndex = 32;
            // 
            // lblTimestamp
            // 
            lblTimestamp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTimestamp.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTimestamp.Location = new System.Drawing.Point(1237, 14);
            lblTimestamp.Margin = new Padding(4, 0, 4, 0);
            lblTimestamp.Name = "lblTimestamp";
            lblTimestamp.Size = new Size(221, 25);
            lblTimestamp.TabIndex = 31;
            lblTimestamp.Text = "Jan 1, 2025";
            lblTimestamp.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new System.Drawing.Point(97, 48);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(50, 25);
            label5.TabIndex = 30;
            label5.Text = "New";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(24, 45);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(65, 28);
            label4.TabIndex = 29;
            label4.Text = "Status";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new System.Drawing.Point(24, 14);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(207, 31);
            label6.TabIndex = 24;
            label6.Text = "ORDER NO. 12345";
            // 
            // timerTimestamp
            // 
            timerTimestamp.Enabled = true;
            timerTimestamp.Tick += timerTimestamp_Tick;
            // 
            // frmOrder
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 803);
            Controls.Add(panel1);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MinimumSize = new Size(1500, 850);
            Name = "frmOrder";
            Text = "Order Form";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTags).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lblTitle;
        private Panel panel1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label lblTimestamp;
        private DataGridView dgvTags;
        private TextBox txtCustomer;
        private Label label1;
        private DataGridViewTextBoxColumn clmItem;
        private DataGridViewTextBoxColumn clmUnit;
        private DataGridViewTextBoxColumn clmQuantity;
        private DataGridViewTextBoxColumn clmPrice;
        private DataGridViewTextBoxColumn clmTotal;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label2;
        private Label label7;
        private System.Windows.Forms.Timer timerTimestamp;
        private Button btnAddItem;
        private LinkLabel lnkSelectCustomer;
    }
}