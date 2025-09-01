using Point.Client.Main.Forms;
using Point.Client.Main.Forms.Listing;
using Point.Client.Main.Forms.Orders;
using Point.Client.Main.Forms.Products;
using Point.Client.Main.Forms.Sales;
using Point.Client.Main.Globals;
using Point.Client.Main.Listing;

namespace Point.Client.Main
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region Menu

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFactory.GetFormDialog<frmDataManager>().ShowDialog();
        }

        #endregion

        #region Listing

        private void btnItemUnits_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmItemUnits());
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            FormFactory.GetFormDialog<frmItems>().ShowDialog();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            FormFactory.GetFormDialog<frmCategories>().ShowDialog();
        }

        private void btnUnits_Click(object sender, EventArgs e)
        {
            FormFactory.GetFormDialog<frmUnits>().ShowDialog();
        }

        private void btnTags_Click(object sender, EventArgs e)
        {
            FormFactory.GetFormDialog<frmTags>().ShowDialog();
        }

        private void btnPriceTypes_Click(object sender, EventArgs e)
        {
            FormFactory.GetFormDialog<frmPriceTypes>().ShowDialog();
        }

        #endregion

        #region Stocks

        private void btnStocks_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Orders

        private void btnOrders_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmOrders());
        }

        private void btnOrderForm_Click(object sender, EventArgs e)
        {
            FormFactory.GetForm<frmOrder>().Show();
        }

        #endregion

        #region Sales

        private void btnSales_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmSales());
        }

        #endregion

        #region Helpers

        private void OpenChildForm(Form childForm)
        {
            foreach (var form in this.MdiChildren)
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

        #endregion
    }
}
