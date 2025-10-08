namespace Point.Client.Main.Listing
{
    partial class frmItemUnit
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
            label2 = new Label();
            cmbUnit = new ComboBox();
            btnCancel = new Button();
            btnSave = new Button();
            txtItem = new RichTextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(29, 126);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(44, 25);
            label2.TabIndex = 14;
            label2.Text = "Unit";
            // 
            // cmbUnit
            // 
            cmbUnit.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbUnit.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbUnit.FormattingEnabled = true;
            cmbUnit.Location = new System.Drawing.Point(81, 123);
            cmbUnit.Margin = new Padding(4);
            cmbUnit.Name = "cmbUnit";
            cmbUnit.Size = new Size(248, 33);
            cmbUnit.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(384, 179);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(118, 36);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(196, 179);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(180, 36);
            btnSave.TabIndex = 2;
            btnSave.Text = "Add Item-unit";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtItem
            // 
            txtItem.Location = new System.Drawing.Point(28, 28);
            txtItem.Name = "txtItem";
            txtItem.ReadOnly = true;
            txtItem.Size = new Size(475, 88);
            txtItem.TabIndex = 4;
            txtItem.Text = "";
            // 
            // frmItemUnit
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(531, 244);
            Controls.Add(txtItem);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label2);
            Controls.Add(cmbUnit);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmItemUnit";
            Padding = new Padding(25);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Item-unit";
            Load += frmItemUnit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private ComboBox cmbUnit;
        private Button btnCancel;
        private Button btnSave;
        private RichTextBox txtItem;
    }
}