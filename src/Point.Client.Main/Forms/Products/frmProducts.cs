namespace Point.Client.Main.Products
{
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
        }
        private void tsbtnNewItemUnit_Click(object sender, EventArgs e)
        {
            new frmCategories().ShowDialog();
        }

        private void lnkManageItems_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmItems().ShowDialog();
        }
    }
}
