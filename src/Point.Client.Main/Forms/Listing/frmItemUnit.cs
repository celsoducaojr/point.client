namespace Point.Client.Main.Listing
{
    public partial class frmItemUnit : Form
    {
        public frmItemUnit()
        {
            InitializeComponent();
        }

        private void lnkManageItems_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmItems().ShowDialog();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
