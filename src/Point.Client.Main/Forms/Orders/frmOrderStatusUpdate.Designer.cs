namespace Point.Client.Main.Forms.Orders
{
    partial class frmOrderStatusUpdate
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
            lblTotal = new Label();
            label5 = new Label();
            lblOrderNumber = new Label();
            btnCancel = new Button();
            btnUpdate = new Button();
            txtStatus = new TextBox();
            lblStatus = new Label();
            lblPaymentTerm = new Label();
            cmbPaymentTerm = new ComboBox();
            SuspendLayout();
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Segoe UI", 36F);
            lblTotal.Location = new System.Drawing.Point(201, 88);
            lblTotal.Margin = new Padding(4, 0, 4, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(509, 95);
            lblTotal.TabIndex = 58;
            lblTotal.Text = "0.00";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 36F);
            label5.Location = new System.Drawing.Point(32, 95);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(161, 81);
            label5.TabIndex = 57;
            label5.Text = "Total";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOrderNumber
            // 
            lblOrderNumber.AutoSize = true;
            lblOrderNumber.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrderNumber.Location = new System.Drawing.Point(32, 28);
            lblOrderNumber.Margin = new Padding(4, 0, 4, 0);
            lblOrderNumber.Name = "lblOrderNumber";
            lblOrderNumber.Size = new Size(207, 31);
            lblOrderNumber.TabIndex = 59;
            lblOrderNumber.Text = "ORDER NO. 12345";
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancel.Font = new Font("Segoe UI", 13.8F);
            btnCancel.Location = new System.Drawing.Point(522, 441);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(188, 72);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnUpdate.Font = new Font("Segoe UI", 13.8F);
            btnUpdate.Location = new System.Drawing.Point(32, 441);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(482, 72);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtStatus
            // 
            txtStatus.CharacterCasing = CharacterCasing.Upper;
            txtStatus.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStatus.Location = new System.Drawing.Point(32, 341);
            txtStatus.Margin = new Padding(4);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(678, 61);
            txtStatus.TabIndex = 2;
            txtStatus.TextAlign = HorizontalAlignment.Center;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new System.Drawing.Point(32, 306);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(356, 31);
            lblStatus.TabIndex = 60;
            lblStatus.Text = "Type 'CHANGE' to update status...";
            // 
            // lblPaymentTerm
            // 
            lblPaymentTerm.AutoSize = true;
            lblPaymentTerm.Font = new Font("Segoe UI", 12F);
            lblPaymentTerm.Location = new System.Drawing.Point(32, 203);
            lblPaymentTerm.Name = "lblPaymentTerm";
            lblPaymentTerm.Size = new Size(134, 28);
            lblPaymentTerm.TabIndex = 61;
            lblPaymentTerm.Text = "Payment Term";
            lblPaymentTerm.Visible = false;
            // 
            // cmbPaymentTerm
            // 
            cmbPaymentTerm.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaymentTerm.Font = new Font("Segoe UI", 12F);
            cmbPaymentTerm.FormattingEnabled = true;
            cmbPaymentTerm.Location = new System.Drawing.Point(172, 200);
            cmbPaymentTerm.Name = "cmbPaymentTerm";
            cmbPaymentTerm.Size = new Size(236, 36);
            cmbPaymentTerm.TabIndex = 1;
            cmbPaymentTerm.Visible = false;
            // 
            // frmOrderStatusUpdate
            // 
            AcceptButton = btnUpdate;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(742, 545);
            Controls.Add(cmbPaymentTerm);
            Controls.Add(lblPaymentTerm);
            Controls.Add(lblStatus);
            Controls.Add(txtStatus);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(lblOrderNumber);
            Controls.Add(lblTotal);
            Controls.Add(label5);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmOrderStatusUpdate";
            Padding = new Padding(28);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Order Status Update";
            Load += frmOrderStatusUpdate_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTotal;
        private Label label5;
        private Label lblOrderNumber;
        private Button btnCancel;
        private Button btnUpdate;
        private TextBox txtStatus;
        private Label lblStatus;
        private Label lblPaymentTerm;
        private ComboBox cmbPaymentTerm;
    }
}