namespace Point.Client.Main.Forms.Listing
{
    partial class frmPriceTypes
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
            dgvTypes = new DataGridView();
            clmType = new DataGridViewTextBoxColumn();
            btnEdit = new Button();
            btnNew = new Button();
            txtType = new TextBox();
            label1 = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            btnUp = new Button();
            btnDown = new Button();
            toolTipType = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dgvTypes).BeginInit();
            SuspendLayout();
            // 
            // dgvTypes
            // 
            dgvTypes.AllowUserToAddRows = false;
            dgvTypes.AllowUserToDeleteRows = false;
            dgvTypes.AllowUserToOrderColumns = true;
            dgvTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTypes.Columns.AddRange(new DataGridViewColumn[] { clmType });
            dgvTypes.Location = new System.Drawing.Point(24, 24);
            dgvTypes.Margin = new Padding(4, 4, 25, 4);
            dgvTypes.MultiSelect = false;
            dgvTypes.Name = "dgvTypes";
            dgvTypes.ReadOnly = true;
            dgvTypes.RowHeadersWidth = 51;
            dgvTypes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTypes.Size = new Size(369, 483);
            dgvTypes.TabIndex = 1;
            dgvTypes.SelectionChanged += dgvTypes_SelectionChanged;
            // 
            // clmType
            // 
            clmType.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clmType.HeaderText = "Type";
            clmType.MinimumWidth = 6;
            clmType.Name = "clmType";
            clmType.ReadOnly = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new System.Drawing.Point(776, 471);
            btnEdit.Margin = new Padding(4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(118, 36);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new System.Drawing.Point(650, 471);
            btnNew.Margin = new Padding(4);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(118, 36);
            btnNew.TabIndex = 5;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // txtType
            // 
            txtType.Location = new System.Drawing.Point(568, 24);
            txtType.Margin = new Padding(4);
            txtType.MaxLength = 30;
            txtType.Name = "txtType";
            txtType.ReadOnly = true;
            txtType.Size = new Size(326, 31);
            txtType.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(511, 27);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 25);
            label1.TabIndex = 11;
            label1.Text = "Type";
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(776, 471);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(118, 36);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Visible = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(588, 471);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(180, 36);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save Type";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Visible = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnUp
            // 
            btnUp.Image = Properties.Resources.up_icon;
            btnUp.Location = new System.Drawing.Point(418, 94);
            btnUp.Margin = new Padding(0);
            btnUp.Name = "btnUp";
            btnUp.Size = new Size(52, 59);
            btnUp.TabIndex = 2;
            toolTipType.SetToolTip(btnUp, "Move up");
            btnUp.UseVisualStyleBackColor = true;
            btnUp.Click += btnUp_Click;
            // 
            // btnDown
            // 
            btnDown.Image = Properties.Resources.down_icon;
            btnDown.Location = new System.Drawing.Point(418, 168);
            btnDown.Margin = new Padding(0);
            btnDown.Name = "btnDown";
            btnDown.Size = new Size(52, 59);
            btnDown.TabIndex = 3;
            toolTipType.SetToolTip(btnDown, "Move down");
            btnDown.UseVisualStyleBackColor = true;
            btnDown.Click += btnDown_Click;
            // 
            // toolTipType
            // 
            toolTipType.ToolTipIcon = ToolTipIcon.Info;
            toolTipType.ToolTipTitle = "Product Column Arrangement";
            // 
            // frmPriceTypes
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 531);
            Controls.Add(btnDown);
            Controls.Add(btnUp);
            Controls.Add(dgvTypes);
            Controls.Add(btnEdit);
            Controls.Add(btnNew);
            Controls.Add(txtType);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPriceTypes";
            Padding = new Padding(20);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Price Types";
            FormClosing += frmPriceTypes_FormClosing;
            Load += frmPriceTypes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTypes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTypes;
        private Button btnEdit;
        private Button btnNew;
        private TextBox txtType;
        private Label label1;
        private Button btnCancel;
        private Button btnSave;
        private DataGridViewTextBoxColumn clmType;
        private Button btnUp;
        private Button btnDown;
        private ToolTip toolTipType;
    }
}