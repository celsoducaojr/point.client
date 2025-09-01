namespace Point.Client.Main.Forms
{
    partial class frmDataManager
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnExport = new Button();
            btnBrowseDirectory = new Button();
            txtDirectory = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new System.Drawing.Point(28, 28);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(607, 341);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnExport);
            tabPage1.Controls.Add(btnBrowseDirectory);
            tabPage1.Controls.Add(txtDirectory);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new System.Drawing.Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(15);
            tabPage1.Size = new Size(599, 303);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Export";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            btnExport.Location = new System.Drawing.Point(400, 248);
            btnExport.Margin = new Padding(4);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(180, 36);
            btnExport.TabIndex = 9;
            btnExport.Text = "Export Data";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // btnBrowseDirectory
            // 
            btnBrowseDirectory.Location = new System.Drawing.Point(462, 83);
            btnBrowseDirectory.Margin = new Padding(4);
            btnBrowseDirectory.Name = "btnBrowseDirectory";
            btnBrowseDirectory.Size = new Size(118, 36);
            btnBrowseDirectory.TabIndex = 7;
            btnBrowseDirectory.Text = "Browse";
            btnBrowseDirectory.UseVisualStyleBackColor = true;
            btnBrowseDirectory.Click += btnBrowseDirectory_Click;
            // 
            // txtDirectory
            // 
            txtDirectory.Location = new System.Drawing.Point(19, 44);
            txtDirectory.Margin = new Padding(4);
            txtDirectory.MaxLength = 30;
            txtDirectory.Name = "txtDirectory";
            txtDirectory.ReadOnly = true;
            txtDirectory.Size = new Size(561, 31);
            txtDirectory.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(19, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(146, 25);
            label1.TabIndex = 6;
            label1.Text = "Output Directory";
            // 
            // tabPage2
            // 
            tabPage2.Location = new System.Drawing.Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(599, 308);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Import";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // frmDataManager
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(663, 397);
            Controls.Add(tabControl1);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "frmDataManager";
            Padding = new Padding(25);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Data Manager";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox txtDirectory;
        private Label label1;
        private Button button1;
        private Button btnBrowseDirectory;
        private Button btnExport;
    }
}