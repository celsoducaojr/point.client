using System.Data;
using Point.Client.Main.Api;
using Point.Client.Main.Api.Services;

namespace Point.Client.Main.Forms.Listing
{
    public partial class frmItemSearch : Form
    {
        public sealed record ItemSearchDto(
            string? Name,
            int? CategoryId,
            List<int>? TagIds);

        public readonly ItemSearchDto Item;

        private bool _isFirstLoad;

        private readonly CategoryService _categoryService;
        private readonly TagService _tagService;

        public frmItemSearch()
        {
            InitializeComponent();

            Item = new ItemSearchDto(null, null, null);

            _isFirstLoad = true;

            _categoryService = ServiceLocator.GetService<CategoryService>();
            //_tagService = new TagService();
        }

        private void frmItemSearch_Load(object sender, EventArgs e)
        {
            if (_isFirstLoad)
            {
                Task.Run(() => LoadCategories());
                _isFirstLoad = false;
            }
        }

        private void frmItemSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtItem.Clear();
            cmbCategory.SelectedItem = null;
            dgvTags.Rows.Clear();
            txtTag.Clear();

            txtItem.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        #region Helpers

        private void EnableEditing(bool enable)
        {
            this.Controls.OfType<Control>().ToList().ForEach(c => c.Enabled = enable);
        }

        #endregion
        #region Services

        internal async Task LoadCategories(bool clearSelection = false)
        {
            var frmText = this.Text;
            this.Invoke((MethodInvoker)(() =>
            {
                EnableEditing(false);

                this.Text = "Loading Categories...";
            }));

            var response = await _categoryService.GetCategories();

            this.Invoke((MethodInvoker)(() =>
            {
                cmbCategory.DataSource = response;
                cmbCategory.DisplayMember = "Name";
                cmbCategory.ValueMember = "Id";

                if (clearSelection)
                {
                    cmbCategory.SelectedItem = null;
                }

                this.Text = frmText;
                EnableEditing(true);
            }));
        }

        internal async Task LoadTags(bool clearSelection = false)
        {
            var frmText = this.Text;
            this.Invoke((MethodInvoker)(() =>
            {
                EnableEditing(false);

                this.Text = "Loading Tags...";
            }));

            var response = await _tagService.GetTags();

            this.Invoke((MethodInvoker)(() =>
            {
                var collection = new AutoCompleteStringCollection { };
                collection.AddRange(response.Select(x => x.Name).ToArray());

                txtTag.Clear();
                txtTag.AutoCompleteCustomSource = collection;
                txtTag.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtTag.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtTag.Tag = response;

                this.Text = frmText;
                EnableEditing(true);
            }));
        }

        #endregion
    }
}
