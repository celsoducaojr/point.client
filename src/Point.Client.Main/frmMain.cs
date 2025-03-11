using Point.Client.Main.Products;
using Point.Client.Main.Stocks;

namespace Point.Client.Main
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void tsbtnProducts_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmProducts());
        }

        private void tsbtnStocks_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmStocks());
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

    }
}
