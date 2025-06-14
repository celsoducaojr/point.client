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
            comboBox1 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F);
            label1.Location = new System.Drawing.Point(28, 284);
            label1.Margin = new Padding(8, 0, 8, 0);
            label1.Name = "label1";
            label1.Size = new Size(141, 38);
            label1.TabIndex = 38;
            label1.Text = "Item Price";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(176, 281);
            comboBox1.Margin = new Padding(6);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(464, 45);
            comboBox1.TabIndex = 39;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(176, 339);
            label2.Margin = new Padding(20);
            label2.Name = "label2";
            label2.Size = new Size(464, 72);
            label2.TabIndex = 40;
            label2.Text = "0.00";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 16.2F);
            label3.Location = new System.Drawing.Point(28, 20);
            label3.Margin = new Padding(8, 0, 8, 0);
            label3.Name = "label3";
            label3.Size = new Size(612, 159);
            label3.TabIndex = 41;
            label3.Text = "Item name...";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F);
            label4.Location = new System.Drawing.Point(28, 189);
            label4.Margin = new Padding(8, 10, 8, 0);
            label4.Name = "label4";
            label4.Size = new Size(133, 38);
            label4.TabIndex = 42;
            label4.Text = "Unit: ###";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F);
            label5.Location = new System.Drawing.Point(28, 237);
            label5.Margin = new Padding(8, 10, 8, 0);
            label5.Name = "label5";
            label5.Size = new Size(238, 38);
            label5.TabIndex = 43;
            label5.Text = "Capital Code: ###";
            // 
            // frmOrderItemPrice
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 451);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox1);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}