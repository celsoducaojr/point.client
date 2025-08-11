namespace Point.Client.Main.Forms.Orders
{
    partial class frmPayOrder
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
            btnPay = new Button();
            btnCancel = new Button();
            cmbMode = new ComboBox();
            label2 = new Label();
            txtRemarks = new RichTextBox();
            txtReference = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblTotal = new Label();
            panel1 = new Panel();
            lblChange = new Label();
            txtTendered = new TextBox();
            label1 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnPay
            // 
            btnPay.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnPay.Font = new Font("Segoe UI", 13.8F);
            btnPay.Location = new System.Drawing.Point(32, 592);
            btnPay.Margin = new Padding(4);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(482, 72);
            btnPay.TabIndex = 5;
            btnPay.Text = "PAY";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancel.Font = new Font("Segoe UI", 13.8F);
            btnCancel.Location = new System.Drawing.Point(522, 592);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(188, 72);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // cmbMode
            // 
            cmbMode.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMode.Font = new Font("Segoe UI", 12F);
            cmbMode.FormattingEnabled = true;
            cmbMode.Location = new System.Drawing.Point(184, 376);
            cmbMode.Margin = new Padding(4);
            cmbMode.Name = "cmbMode";
            cmbMode.Size = new Size(210, 36);
            cmbMode.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new System.Drawing.Point(32, 379);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(144, 28);
            label2.TabIndex = 50;
            label2.Text = "Payment Mode";
            // 
            // txtRemarks
            // 
            txtRemarks.Location = new System.Drawing.Point(184, 459);
            txtRemarks.MaxLength = 250;
            txtRemarks.Name = "txtRemarks";
            txtRemarks.Size = new Size(507, 68);
            txtRemarks.TabIndex = 4;
            txtRemarks.Text = "";
            // 
            // txtReference
            // 
            txtReference.Location = new System.Drawing.Point(184, 419);
            txtReference.MaxLength = 50;
            txtReference.Name = "txtReference";
            txtReference.Size = new Size(507, 34);
            txtReference.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new System.Drawing.Point(92, 462);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(85, 28);
            label3.TabIndex = 53;
            label3.Text = "Remarks";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new System.Drawing.Point(81, 422);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(96, 28);
            label4.TabIndex = 54;
            label4.Text = "Reference";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 36F);
            label5.Location = new System.Drawing.Point(32, 35);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(161, 81);
            label5.TabIndex = 55;
            label5.Text = "Total";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Segoe UI", 36F);
            lblTotal.Location = new System.Drawing.Point(210, 28);
            lblTotal.Margin = new Padding(4, 0, 4, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(481, 95);
            lblTotal.TabIndex = 56;
            lblTotal.Text = "0.00";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 192, 0);
            panel1.Controls.Add(lblChange);
            panel1.Controls.Add(txtTendered);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label7);
            panel1.Location = new System.Drawing.Point(32, 126);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(15);
            panel1.Size = new Size(678, 236);
            panel1.TabIndex = 1;
            // 
            // lblChange
            // 
            lblChange.Font = new Font("Segoe UI", 36F);
            lblChange.Location = new System.Drawing.Point(284, 120);
            lblChange.Margin = new Padding(4, 0, 4, 0);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(375, 101);
            lblChange.TabIndex = 62;
            lblChange.Text = "0.00";
            lblChange.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtTendered
            // 
            txtTendered.CharacterCasing = CharacterCasing.Upper;
            txtTendered.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTendered.Location = new System.Drawing.Point(284, 55);
            txtTendered.Margin = new Padding(4);
            txtTendered.Name = "txtTendered";
            txtTendered.Size = new Size(375, 61);
            txtTendered.TabIndex = 1;
            txtTendered.Text = "0.00";
            txtTendered.TextAlign = HorizontalAlignment.Right;
            txtTendered.KeyDown += txtTendered_KeyDown;
            txtTendered.Validating += txtTendered_Validating;
            txtTendered.Validated += txtTendered_Validated;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(19, 68);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(257, 41);
            label1.TabIndex = 60;
            label1.Text = "Amount Tendered";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new System.Drawing.Point(156, 162);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(120, 41);
            label7.TabIndex = 61;
            label7.Text = "Change";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmPayOrder
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(742, 696);
            Controls.Add(panel1);
            Controls.Add(lblTotal);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtReference);
            Controls.Add(txtRemarks);
            Controls.Add(label2);
            Controls.Add(cmbMode);
            Controls.Add(btnCancel);
            Controls.Add(btnPay);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPayOrder";
            Padding = new Padding(28);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Pay Order";
            Load += frmPayOrder_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPay;
        private Button btnCancel;
        private ComboBox cmbMode;
        private Label label2;
        private RichTextBox txtRemarks;
        private TextBox txtReference;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblTotal;
        private Panel panel1;
        private Label lblChange;
        private Label label7;
        private TextBox txtTendered;
        private Label label1;
    }
}