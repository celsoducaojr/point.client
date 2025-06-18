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
            lblUnit = new Label();
            lblCapitalCode = new Label();
            btnAddItem = new Button();
            btnCancel = new Button();
            txtPrice = new TextBox();
            lblQuantity = new Label();
            numQuantity = new NumericUpDown();
            label2 = new Label();
            lblTotal = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F);
            label1.Location = new System.Drawing.Point(50, 284);
            label1.Margin = new Padding(8, 0, 8, 0);
            label1.Name = "label1";
            label1.Size = new Size(141, 38);
            label1.TabIndex = 38;
            label1.Text = "Item Price";
            // 
            // cmbPrice
            // 
            cmbPrice.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPrice.FormattingEnabled = true;
            cmbPrice.Location = new System.Drawing.Point(205, 281);
            cmbPrice.Margin = new Padding(6);
            cmbPrice.Name = "cmbPrice";
            cmbPrice.Size = new Size(435, 45);
            cmbPrice.TabIndex = 1;
            cmbPrice.SelectedIndexChanged += cmbPrice_SelectedIndexChanged;
            // 
            // lblItem
            // 
            lblItem.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblItem.Location = new System.Drawing.Point(28, 20);
            lblItem.Margin = new Padding(8, 0, 8, 0);
            lblItem.Name = "lblItem";
            lblItem.Size = new Size(612, 159);
            lblItem.TabIndex = 41;
            lblItem.Text = "Item name...";
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.Font = new Font("Segoe UI", 16.2F);
            lblUnit.Location = new System.Drawing.Point(205, 189);
            lblUnit.Margin = new Padding(8, 10, 8, 0);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(139, 38);
            lblUnit.TabIndex = 42;
            lblUnit.Text = "Unit '###'";
            // 
            // lblCapitalCode
            // 
            lblCapitalCode.AutoSize = true;
            lblCapitalCode.Font = new Font("Segoe UI", 16.2F);
            lblCapitalCode.Location = new System.Drawing.Point(205, 237);
            lblCapitalCode.Margin = new Padding(8, 10, 8, 0);
            lblCapitalCode.Name = "lblCapitalCode";
            lblCapitalCode.Size = new Size(244, 38);
            lblCapitalCode.TabIndex = 43;
            lblCapitalCode.Text = "Capital Code '###'";
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new System.Drawing.Point(28, 635);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(423, 70);
            btnAddItem.TabIndex = 4;
            btnAddItem.Text = "Add Item";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(465, 635);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(175, 70);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrice.Location = new System.Drawing.Point(205, 335);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(435, 87);
            txtPrice.TabIndex = 2;
            txtPrice.TextAlign = HorizontalAlignment.Right;
            txtPrice.Validating += txtPrice_Validating;
            txtPrice.Validated += txtPrice_Validated;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 16.2F);
            lblQuantity.Location = new System.Drawing.Point(68, 428);
            lblQuantity.Margin = new Padding(8, 0, 8, 0);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(123, 38);
            lblQuantity.TabIndex = 47;
            lblQuantity.Text = "Quantity";
            // 
            // numQuantity
            // 
            numQuantity.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numQuantity.Location = new System.Drawing.Point(205, 428);
            numQuantity.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(435, 87);
            numQuantity.TabIndex = 3;
            numQuantity.TextAlign = HorizontalAlignment.Right;
            numQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numQuantity.ValueChanged += numQuantity_ValueChanged;
            numQuantity.KeyPress += numQuantity_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(28, 521);
            label2.Margin = new Padding(8, 0, 8, 0);
            label2.Name = "label2";
            label2.Size = new Size(161, 81);
            label2.TabIndex = 48;
            label2.Text = "Total";
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new System.Drawing.Point(205, 518);
            lblTotal.Margin = new Padding(8, 0, 8, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(435, 86);
            lblTotal.TabIndex = 49;
            lblTotal.Text = "0,000,000.00";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F);
            label3.Location = new System.Drawing.Point(123, 189);
            label3.Margin = new Padding(8, 10, 8, 0);
            label3.Name = "label3";
            label3.Size = new Size(68, 38);
            label3.TabIndex = 50;
            label3.Text = "Unit";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F);
            label4.Location = new System.Drawing.Point(18, 237);
            label4.Margin = new Padding(8, 10, 8, 0);
            label4.Name = "label4";
            label4.Size = new Size(173, 38);
            label4.TabIndex = 51;
            label4.Text = "Capital Code";
            // 
            // frmOrderItemPrice
            // 
            AcceptButton = btnAddItem;
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(666, 728);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblTotal);
            Controls.Add(label2);
            Controls.Add(numQuantity);
            Controls.Add(lblQuantity);
            Controls.Add(txtPrice);
            Controls.Add(btnCancel);
            Controls.Add(btnAddItem);
            Controls.Add(lblCapitalCode);
            Controls.Add(lblUnit);
            Controls.Add(lblItem);
            Controls.Add(cmbPrice);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmOrderItemPrice";
            Padding = new Padding(20);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Select Item Price...";
            Load += frmOrderItemPrice_Load;
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbPrice;
        private Label lblItem;
        private Label lblUnit;
        private Label lblCapitalCode;
        private Button btnAddItem;
        private Button btnCancel;
        private TextBox txtPrice;
        private Label lblQuantity;
        private NumericUpDown numQuantity;
        private Label label2;
        private Label lblTotal;
        private Label label3;
        private Label label4;
    }
}