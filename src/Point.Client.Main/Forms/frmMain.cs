using Point.Client.Main.Forms.Listing;
using Point.Client.Main.Forms.Products;
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

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmProducts());
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            FormFactory.GetForm<frmItems>().ShowDialog();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            FormFactory.GetForm<frmCategories>().ShowDialog();
        }

        private void btnUnits_Click(object sender, EventArgs e)
        {
            FormFactory.GetForm<frmUnits>().ShowDialog();
        }

        private void btnTags_Click(object sender, EventArgs e)
        {
            FormFactory.GetForm<frmTags>().ShowDialog();
        }

        private void btnPriceTypes_Click(object sender, EventArgs e)
        {
            FormFactory.GetForm<frmPriceTypes>().ShowDialog();
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
