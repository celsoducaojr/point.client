namespace Point.Client.Main.Forms.Stocks
{
    partial class frmUpdateStock
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
            label1 = new Label();
            label2 = new Label();
            txtUnit = new TextBox();
            numQuantity = new NumericUpDown();
            lblQuantity = new Label();
            btnCancel = new Button();
            btnUpdateStock = new Button();
            label3 = new Label();
            txtRemarks = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            SuspendLayout();
            // 
            // txtItem
            // 
            txtItem.Location = new System.Drawing.Point(35, 60);
            txtItem.Margin = new Padding(4);
            txtItem.MaxLength = 100;
            txtItem.Name = "txtItem";
            txtItem.ReadOnly = true;
            txtItem.Size = new Size(688, 31);
            txtItem.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(35, 31);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(48, 25);
            label1.TabIndex = 10;
            label1.Text = "Item";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(35, 95);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(44, 25);
            label2.TabIndex = 12;
            label2.Text = "Unit";
            // 
            // txtUnit
            // 
            txtUnit.Location = new System.Drawing.Point(35, 124);
            txtUnit.Margin = new Padding(4);
            txtUnit.MaxLength = 250;
            txtUnit.Name = "txtUnit";
            txtUnit.ReadOnly = true;
            txtUnit.Size = new Size(334, 31);
            txtUnit.TabIndex = 5;
            // 
            // numQuantity
            // 
            numQuantity.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numQuantity.Location = new System.Drawing.Point(35, 187);
            numQuantity.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(254, 31);
            numQuantity.TabIndex = 1;
            numQuantity.TextAlign = HorizontalAlignment.Right;
            numQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new System.Drawing.Point(35, 159);
            lblQuantity.Margin = new Padding(4, 0, 4, 0);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(80, 25);
            lblQuantity.TabIndex = 49;
            lblQuantity.Text = "Quantity";
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(605, 329);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(118, 36);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdateStock
            // 
            btnUpdateStock.Location = new System.Drawing.Point(417, 329);
            btnUpdateStock.Margin = new Padding(4);
            btnUpdateStock.Name = "btnUpdateStock";
            btnUpdateStock.Size = new Size(180, 36);
            btnUpdateStock.TabIndex = 2;
            btnUpdateStock.Text = "Update Stock";
            btnUpdateStock.UseVisualStyleBackColor = true;
            btnUpdateStock.Click += btnUpdateStock_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(35, 221);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(79, 25);
            label3.TabIndex = 51;
            label3.Text = "Remarks";
            // 
            // txtRemarks
            // 
            txtRemarks.Location = new System.Drawing.Point(35, 250);
            txtRemarks.Margin = new Padding(4);
            txtRemarks.MaxLength = 150;
            txtRemarks.Name = "txtRemarks";
            txtRemarks.Size = new Size(500, 31);
            txtRemarks.TabIndex = 50;
            // 
            // frmUpdateStock
            // 
            AcceptButton = btnUpdateStock;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(758, 400);
            Controls.Add(label3);
            Controls.Add(txtRemarks);
            Controls.Add(btnUpdateStock);
            Controls.Add(btnCancel);
            Controls.Add(lblQuantity);
            Controls.Add(numQuantity);
            Controls.Add(label2);
            Controls.Add(txtUnit);
            Controls.Add(label1);
            Controls.Add(txtItem);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmUpdateStock";
            Padding = new Padding(31);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Update Stock";
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtItem;
        private Label label1;
        private Label label2;
        private TextBox txtUnit;
        private NumericUpDown numQuantity;
        private Label lblQuantity;
        private Button btnCancel;
        private Button btnUpdateStock;
        private Label label3;
        private TextBox txtRemarks;
    }
}