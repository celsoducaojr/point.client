using System.Data;
using Point.Client.Main.Api;
using Point.Client.Main.Api.Dtos;
using Point.Client.Main.Api.Entities;
using Point.Client.Main.Api.Services;
using Point.Client.Main.Globals;

namespace Point.Client.Main.Forms.Listing
{
    public partial class frmItemSearch : Form
    {
        private DateTime? _categoryLastUpdate;
        private DateTime? _tagLastUpdate;

        private readonly CategoryService _categoryService;
        private readonly TagService _tagService;

        public SearchItemDto? SearchItemDto { get; set; }

        public frmItemSearch()
        {
            InitializeComponent();

            _categoryLastUpdate = null;
            _tagLastUpdate = null;

            _categoryService = ServiceLocator.GetService<CategoryService>();
            _tagService = ServiceLocator.GetService<TagService>();

            SearchItemDto = null;
        }

        private async void frmItemSearch_Load(object sender, EventArgs e)
        {
            EnableEditing(false);

            await Task.Run(async () =>
            {
                if (_categoryLastUpdate != RecordStatus.Categories.LastUpdate) await LoadCategories();
                if (_tagLastUpdate != RecordStatus.Tags.LastUpdate) await LoadTags();
            });

            EnableEditing(true);
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
            ClearFields();
            SearchItemDto = null;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

            SearchItemDto = new SearchItemDto
            {
                Name = !string.IsNullOrWhiteSpace(txtItem.Text) 
                    ? txtItem.Text 
                    : null,
                Category = cmbCategory.SelectedItem != null ?
                    (Category)cmbCategory.SelectedItem
                    : null,
                Tags = dgvTags.Rows.Count > 0
                    ? dgvTags.Rows.Cast<DataGridViewRow>()
                    .Select(row => row.Tag as Tag).ToList() as List<Tag>
                    : null
            };

            var properties = SearchItemDto.GetType().GetProperties();
            if (properties.All(prop => prop.GetValue(SearchItemDto) == null)) SearchItemDto = null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        #region Helpers

        private void ClearFields()
        {
            txtItem.Clear();
            cmbCategory.SelectedItem = null;
            dgvTags.Rows.Clear();
            txtTag.Clear();

            txtItem.Focus();
        }

        private void EnableEditing(bool enable)
        {
            this.Controls.OfType<Control>().ToList().ForEach(c => c.Enabled = enable);
        }

        #endregion

        #region Services

        private async Task LoadCategories()
        {
            if (_categoryLastUpdate == RecordStatus.Categories.LastUpdate) return;
            _categoryLastUpdate = RecordStatus.Categories.LastUpdate;

            var frmText = this.Text;
            this.Invoke((MethodInvoker)(() =>
            {
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
            }));
        }

        private async Task LoadTags()
        {
            if (_tagLastUpdate == RecordStatus.Tags.LastUpdate) return;
            _tagLastUpdate = RecordStatus.Tags.LastUpdate;

            var frmText = this.Text;
            this.Invoke((MethodInvoker)(() =>
            {
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
            }));
        }

        #endregion
    }
}
