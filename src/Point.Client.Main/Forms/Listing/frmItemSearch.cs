using System.Data;
using Point.Client.Main.Api;
using Point.Client.Main.Api.Entities;
using Point.Client.Main.Api.Services;

namespace Point.Client.Main.Forms.Listing
{
    public partial class frmItemSearch : Form
    {
        public sealed record ItemSearchDto(
            string? Name,
            Category? Category,
            List<Tag>? TagIds);

        public ItemSearchDto? SearchDto;

        private bool _isFirstLoad;

        private readonly CategoryService _categoryService;
        private readonly TagService _tagService;

        public frmItemSearch()
        {
            InitializeComponent();

            SearchDto = null;

            _isFirstLoad = true;

            _categoryService = ServiceLocator.GetService<CategoryService>();
            _tagService = ServiceLocator.GetService<TagService>();
        }

        private void frmItemSearch_Load(object sender, EventArgs e)
        {
            if (_isFirstLoad)
            {
                Task.Run(async () => 
                {
                    await LoadCategories();
                    await LoadTags();
                });
                _isFirstLoad = false;
            }
        }

        private void frmItemSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void dgvTags_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0
                && dgvTags.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                dgvTags.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void txtTag_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(txtTag.Text))
            {
                var selectedTag = ((List<Tag>)txtTag.Tag).FirstOrDefault(tag => tag.Name == txtTag.Text);
                if (selectedTag != null)
                {
                    if (dgvTags.Rows.Cast<DataGridViewRow>().ToList()
                        .FirstOrDefault(row => ((Tag)row.Tag).Id == selectedTag.Id) == null)
                    {
                        dgvTags.Rows.Add(txtTag.Text, "Remove");
                        dgvTags.Rows[dgvTags.Rows.Count - 1].Tag = selectedTag;

                        txtTag.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Tag already added.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Tag not found.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
            SearchDto = new ItemSearchDto(
                txtItem.Text,
                cmbCategory.SelectedItem != null ?
                    (Category)cmbCategory.SelectedItem
                    : null,
                dgvTags.Rows.Count > 0
                    ? dgvTags.Rows.Cast<DataGridViewRow>()
                    .Select(row => row.Tag as Tag).ToList() as List<Tag>
                    : null);

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

        private async Task LoadCategories()
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
                cmbCategory.SelectedItem = null;

                this.Text = frmText;
                EnableEditing(true);
            }));
        }

        private async Task LoadTags()
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
