using Point.Client.Main.Forms.Products;
using Point.Client.Main.Listing;
using Point.Client.Main.Stocks;

namespace Point.Client.Main
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        private void OpenChildForm(Form childForm)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType() == childForm.GetType())
                {
                    form.Activate();
                    return;
                }
            }

            childForm.MdiParent = this;
            childForm.Show();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            new frmUnits().ShowDialog();
        }

        private void tsbtnStocks_Click(object sender, EventArgs e)
        {
            new frmCategories().ShowDialog();
        }

        private void tsbtnOrders_Click(object sender, EventArgs e)
        {
            new frmTags().ShowDialog();
        }

        private void tsbtnSales_Click(object sender, EventArgs e)
        {
            new frmItems().ShowDialog();
        }
    }
}
