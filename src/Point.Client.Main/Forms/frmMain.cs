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

        private void btnProducts_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmProducts());
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            new frmItems().ShowDialog();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            new frmCategories().ShowDialog();
        }

        private void btnUnits_Click(object sender, EventArgs e)
        {
            new frmUnits().ShowDialog();
        }

        private void btnTags_Click(object sender, EventArgs e)
        {
            new frmTags().ShowDialog();
        }

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
