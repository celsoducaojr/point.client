using Point.Client.Main.Api;
using Point.Client.Main.Api.Services;

namespace Point.Client.Main.Products
{
    public partial class frmCategories : Form
    {
        public frmCategories()
        {
            InitializeComponent();
        }

        private void frmCategories_Load(object sender, EventArgs e)
        {
            Task.Run(() => LoadCategories());
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            EnableEditing(true);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EnableEditing(true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            EnableEditing(false);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            EnableEditing(false);
        }

        private void EnableEditing(bool enable)
        {
            btnNew.Visible = !enable;
            btnEdit.Visible = !enable;
            btnSave.Visible = enable;
            btnCancel.Visible = enable;

            dgvCategories.Enabled = !enable;
            txtCategory.ReadOnly = !enable;
        }

        #region Helpers

        private async void LoadCategories()
        {
            var frmText = this.Text;
            this.Invoke((MethodInvoker)(() =>
            {
                this.Text = "Loading categories...";
                this.Controls.Cast<Control>().ToList().ForEach(c => c.Enabled = false);
            }));
            
            var categoryService = ServiceLocator.GetService<CategoryService>();
            var response = await categoryService.GetCategories();

            this.Invoke((MethodInvoker)(() =>
            {
                response?.ForEach(c => 
                {
                    dgvCategories.Rows.Add(c.Name);
                    dgvCategories.Rows[dgvCategories.Rows.Count - 1].Tag = c.Id;
                });

                if (dgvCategories.Rows.Count > 0) dgvCategories.Rows[0].Selected = true;
                this.Text = frmText;
                this.Controls.Cast<Control>().ToList().ForEach(c => c.Enabled = true);
            }));
        }

        #endregion
    }
}
