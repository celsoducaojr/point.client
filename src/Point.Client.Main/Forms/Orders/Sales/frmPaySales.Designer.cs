namespace Point.Client.Main.Forms.Orders.Sales
{
    partial class frmPaySales
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
            lblOrderNumber = new Label();
            panel1 = new Panel();
            cmbPaymentType = new ComboBox();
            txtAmount = new TextBox();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtReference = new TextBox();
            txtRemarks = new RichTextBox();
            label2 = new Label();
            cmbMode = new ComboBox();
            btnCancel = new Button();
            btnPay = new Button();
            txtBalance = new TextBox();
            txtPayments = new TextBox();
            txtReceivables = new TextBox();
            label17 = new Label();
            label15 = new Label();
            label19 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblOrderNumber
            // 
            lblOrderNumber.AutoSize = true;
            lblOrderNumber.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderNumber.Location = new System.Drawing.Point(29, 25);
            lblOrderNumber.Margin = new Padding(4, 0, 4, 0);
            lblOrderNumber.Name = "lblOrderNumber";
            lblOrderNumber.Size = new Size(207, 31);
            lblOrderNumber.TabIndex = 77;
            lblOrderNumber.Text = "ORDER NO. 12345";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 192, 0);
            panel1.Controls.Add(cmbPaymentType);
            panel1.Controls.Add(txtAmount);
            panel1.Controls.Add(label1);
            panel1.Location = new System.Drawing.Point(29, 224);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(15);
            panel1.Size = new Size(571, 162);
            panel1.TabIndex = 1;
            // 
            // cmbPaymentType
            // 
            cmbPaymentType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaymentType.Font = new Font("Segoe UI", 12F);
            cmbPaymentType.FormattingEnabled = true;
            cmbPaymentType.Location = new System.Drawing.Point(143, 91);
            cmbPaymentType.Margin = new Padding(4);
            cmbPaymentType.Name = "cmbPaymentType";
            cmbPaymentType.Size = new Size(264, 36);
            cmbPaymentType.TabIndex = 2;
            // 
            // txtAmount
            // 
            txtAmount.CharacterCasing = CharacterCasing.Upper;
            txtAmount.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAmount.Location = new System.Drawing.Point(143, 36);
            txtAmount.Margin = new Padding(4);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(409, 47);
            txtAmount.TabIndex = 1;
            txtAmount.Text = "0.00";
            txtAmount.TextAlign = HorizontalAlignment.Right;
            txtAmount.KeyDown += txtAmount_KeyDown;
            txtAmount.Validating += txtAmount_Validating;
            txtAmount.Validated += txtAmount_Validated;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(19, 41);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(116, 38);
            label1.TabIndex = 60;
            label1.Text = "Amount";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new System.Drawing.Point(78, 440);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(96, 28);
            label4.TabIndex = 86;
            label4.Text = "Reference";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new System.Drawing.Point(89, 480);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(85, 28);
            label3.TabIndex = 85;
            label3.Text = "Remarks";
            // 
            // txtReference
            // 
            txtReference.Location = new System.Drawing.Point(181, 437);
            txtReference.MaxLength = 50;
            txtReference.Name = "txtReference";
            txtReference.Size = new Size(419, 31);
            txtReference.TabIndex = 3;
            // 
            // txtRemarks
            // 
            txtRemarks.Location = new System.Drawing.Point(181, 477);
            txtRemarks.MaxLength = 250;
            txtRemarks.Name = "txtRemarks";
            txtRemarks.Size = new Size(419, 68);
            txtRemarks.TabIndex = 4;
            txtRemarks.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new System.Drawing.Point(29, 397);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(144, 28);
            label2.TabIndex = 84;
            label2.Text = "Payment Mode";
            // 
            // cmbMode
            // 
            cmbMode.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMode.Font = new Font("Segoe UI", 12F);
            cmbMode.FormattingEnabled = true;
            cmbMode.Location = new System.Drawing.Point(181, 394);
            cmbMode.Margin = new Padding(4);
            cmbMode.Name = "cmbMode";
            cmbMode.Size = new Size(210, 36);
            cmbMode.TabIndex = 2;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancel.Font = new Font("Segoe UI", 13.8F);
            btnCancel.Location = new System.Drawing.Point(412, 611);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(188, 72);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnPay
            // 
            btnPay.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnPay.Font = new Font("Segoe UI", 13.8F);
            btnPay.Location = new System.Drawing.Point(29, 611);
            btnPay.Margin = new Padding(4);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(375, 72);
            btnPay.TabIndex = 5;
            btnPay.Text = "PAY";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click;
            // 
            // txtBalance
            // 
            txtBalance.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBalance.Location = new System.Drawing.Point(172, 162);
            txtBalance.Name = "txtBalance";
            txtBalance.ReadOnly = true;
            txtBalance.Size = new Size(264, 34);
            txtBalance.TabIndex = 9;
            txtBalance.Text = "0.00";
            txtBalance.TextAlign = HorizontalAlignment.Right;
            // 
            // txtPayments
            // 
            txtPayments.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPayments.Location = new System.Drawing.Point(172, 122);
            txtPayments.Name = "txtPayments";
            txtPayments.ReadOnly = true;
            txtPayments.Size = new Size(264, 34);
            txtPayments.TabIndex = 8;
            txtPayments.Text = "0.00";
            txtPayments.TextAlign = HorizontalAlignment.Right;
            // 
            // txtReceivables
            // 
            txtReceivables.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtReceivables.Location = new System.Drawing.Point(172, 82);
            txtReceivables.Name = "txtReceivables";
            txtReceivables.ReadOnly = true;
            txtReceivables.Size = new Size(264, 34);
            txtReceivables.TabIndex = 7;
            txtReceivables.Text = "0.00";
            txtReceivables.TextAlign = HorizontalAlignment.Right;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 10.8F);
            label17.Location = new System.Drawing.Point(43, 128);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(122, 25);
            label17.TabIndex = 91;
            label17.Text = "Total Payment";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10.8F);
            label15.Location = new System.Drawing.Point(94, 168);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(71, 25);
            label15.TabIndex = 92;
            label15.Text = "Balance";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 10.8F);
            label19.Location = new System.Drawing.Point(29, 88);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(136, 25);
            label19.TabIndex = 90;
            label19.Text = "Total Receivable";
            // 
            // frmPaySales
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(629, 712);
            Controls.Add(txtBalance);
            Controls.Add(txtPayments);
            Controls.Add(txtReceivables);
            Controls.Add(label17);
            Controls.Add(label15);
            Controls.Add(label19);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtReference);
            Controls.Add(txtRemarks);
            Controls.Add(label2);
            Controls.Add(cmbMode);
            Controls.Add(btnCancel);
            Controls.Add(btnPay);
            Controls.Add(panel1);
            Controls.Add(lblOrderNumber);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPaySales";
            Padding = new Padding(25);
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Payment";
            Load += frmPayment_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblOrderNumber;
        private Panel panel1;
        private TextBox txtAmount;
        private Label label1;
        private Label label4;
        private Label label3;
        private TextBox txtReference;
        private RichTextBox txtRemarks;
        private Label label2;
        private ComboBox cmbMode;
        private Button btnCancel;
        private Button btnPay;
        private TextBox txtBalance;
        private TextBox txtPayments;
        private TextBox txtReceivables;
        private Label label17;
        private Label label15;
        private Label label19;
        private ComboBox cmbPaymentType;
    }
}