namespace Point.Client.Main.Forms.Orders
{
    partial class frmOrderItemPrice
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
            label1 = new Label();
            cmbPrice = new ComboBox();
            lblItem = new Label();
            btnAddItem = new Button();
            btnCancel = new Button();
            txtPrice = new TextBox();
            lblQuantity = new Label();
            numQuantity = new NumericUpDown();
            label2 = new Label();
            lblTotal = new Label();
            label3 = new Label();
            label4 = new Label();
            txtUnit = new TextBox();
            txtCapitalCode = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F);
            label1.Location = new System.Drawing.Point(60, 256);
            label1.Margin = new Padding(8, 0, 8, 0);
            label1.Name = "label1";
            label1.Size = new Size(116, 31);
            label1.TabIndex = 38;
            label1.Text = "Item Price";
            // 
            // cmbPrice
            // 
            cmbPrice.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPrice.Font = new Font("Segoe UI", 16.2F);
            cmbPrice.FormattingEnabled = true;
            cmbPrice.Location = new System.Drawing.Point(187, 248);
            cmbPrice.Margin = new Padding(6);
            cmbPrice.Name = "cmbPrice";
            cmbPrice.Size = new Size(378, 45);
            cmbPrice.TabIndex = 8;
            cmbPrice.SelectedIndexChanged += cmbPrice_SelectedIndexChanged;
            cmbPrice.KeyDown += cmbPrice_KeyDown;
            // 
            // lblItem
            // 
            lblItem.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblItem.Location = new System.Drawing.Point(28, 20);
            lblItem.Margin = new Padding(8, 0, 8, 0);
            lblItem.Name = "lblItem";
            lblItem.Size = new Size(532, 124);
            lblItem.TabIndex = 41;
            lblItem.Text = "Item....";
            // 
            // btnAddItem
            // 
            btnAddItem.Font = new Font("Segoe UI", 13.8F);
            btnAddItem.Location = new System.Drawing.Point(23, 533);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(396, 50);
            btnAddItem.TabIndex = 4;
            btnAddItem.Text = "Add Item";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 13.8F);
            btnCancel.Location = new System.Drawing.Point(425, 533);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(140, 50);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtPrice
            // 
            txtPrice.AcceptsReturn = true;
            txtPrice.Font = new Font("Segoe UI", 16.2F);
            txtPrice.Location = new System.Drawing.Point(187, 302);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(378, 43);
            txtPrice.TabIndex = 2;
            txtPrice.TextAlign = HorizontalAlignment.Right;
            txtPrice.KeyDown += txtPrice_KeyDown;
            txtPrice.Validating += txtPrice_Validating;
            txtPrice.Validated += txtPrice_Validated;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 13.8F);
            lblQuantity.Location = new System.Drawing.Point(74, 358);
            lblQuantity.Margin = new Padding(8, 0, 8, 0);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(102, 31);
            lblQuantity.TabIndex = 47;
            lblQuantity.Text = "Quantity";
            // 
            // numQuantity
            // 
            numQuantity.Font = new Font("Segoe UI", 16.2F);
            numQuantity.Location = new System.Drawing.Point(187, 351);
            numQuantity.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(378, 43);
            numQuantity.TabIndex = 3;
            numQuantity.TextAlign = HorizontalAlignment.Right;
            numQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numQuantity.ValueChanged += numQuantity_ValueChanged;
            numQuantity.KeyDown += numQuantity_KeyDown;
            numQuantity.KeyPress += numQuantity_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(31, 421);
            label2.Margin = new Padding(8, 0, 8, 0);
            label2.Name = "label2";
            label2.Size = new Size(126, 62);
            label2.TabIndex = 48;
            label2.Text = "Total";
            // 
            // lblTotal
            // 
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new System.Drawing.Point(28, 409);
            lblTotal.Margin = new Padding(8, 0, 8, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(532, 86);
            lblTotal.TabIndex = 49;
            lblTotal.Text = "0,000,000.00";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F);
            label3.Location = new System.Drawing.Point(119, 155);
            label3.Margin = new Padding(8, 10, 8, 0);
            label3.Name = "label3";
            label3.Size = new Size(57, 31);
            label3.TabIndex = 50;
            label3.Text = "Unit";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F);
            label4.Location = new System.Drawing.Point(31, 204);
            label4.Margin = new Padding(8, 10, 8, 0);
            label4.Name = "label4";
            label4.Size = new Size(145, 31);
            label4.TabIndex = 51;
            label4.Text = "Capital Code";
            // 
            // txtUnit
            // 
            txtUnit.AcceptsReturn = true;
            txtUnit.Font = new Font("Segoe UI", 16.2F);
            txtUnit.Location = new System.Drawing.Point(187, 147);
            txtUnit.Name = "txtUnit";
            txtUnit.ReadOnly = true;
            txtUnit.Size = new Size(378, 43);
            txtUnit.TabIndex = 6;
            // 
            // txtCapitalCode
            // 
            txtCapitalCode.AcceptsReturn = true;
            txtCapitalCode.Font = new Font("Segoe UI", 16.2F);
            txtCapitalCode.Location = new System.Drawing.Point(187, 196);
            txtCapitalCode.Name = "txtCapitalCode";
            txtCapitalCode.ReadOnly = true;
            txtCapitalCode.Size = new Size(378, 43);
            txtCapitalCode.TabIndex = 7;
            // 
            // frmOrderItemPrice
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(588, 606);
            Controls.Add(txtCapitalCode);
            Controls.Add(txtUnit);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(numQuantity);
            Controls.Add(lblQuantity);
            Controls.Add(txtPrice);
            Controls.Add(btnCancel);
            Controls.Add(btnAddItem);
            Controls.Add(lblItem);
            Controls.Add(cmbPrice);
            Controls.Add(label1);
            Controls.Add(lblTotal);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmOrderItemPrice";
            Padding = new Padding(20);
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Select Item Price";
            Load += frmOrderItemPrice_Load;
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbPrice;
        private Label lblItem;
        private Button btnAddItem;
        private Button btnCancel;
        private TextBox txtPrice;
        private Label lblQuantity;
        private NumericUpDown numQuantity;
        private Label label2;
        private Label lblTotal;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtUnit;
        private TextBox txtCapitalCode;
    }
}