namespace Point.Client.Main.Forms
{
    partial class frmLoading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoading));
            pboxLoading = new PictureBox();
            lblLoading = new Label();
            ((System.ComponentModel.ISupportInitialize)pboxLoading).BeginInit();
            SuspendLayout();
            // 
            // pboxLoading
            // 
            pboxLoading.Image = (Image)resources.GetObject("pboxLoading.Image");
            pboxLoading.Location = new System.Drawing.Point(13, 13);
            pboxLoading.Margin = new Padding(4);
            pboxLoading.Name = "pboxLoading";
            pboxLoading.Size = new Size(582, 225);
            pboxLoading.SizeMode = PictureBoxSizeMode.CenterImage;
            pboxLoading.TabIndex = 0;
            pboxLoading.TabStop = false;
            pboxLoading.UseWaitCursor = true;
            // 
            // lblLoading
            // 
            lblLoading.Location = new System.Drawing.Point(13, 242);
            lblLoading.Margin = new Padding(4, 0, 4, 0);
            lblLoading.Name = "lblLoading";
            lblLoading.Size = new Size(582, 28);
            lblLoading.TabIndex = 1;
            lblLoading.Text = "Loading...";
            lblLoading.TextAlign = ContentAlignment.MiddleCenter;
            lblLoading.UseWaitCursor = true;
            // 
            // frmLoading
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(608, 280);
            Controls.Add(lblLoading);
            Controls.Add(pboxLoading);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "frmLoading";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLoading";
            UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)pboxLoading).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pboxLoading;
        private Label lblLoading;
    }
}