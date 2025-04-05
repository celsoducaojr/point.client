using Point.Client.Main.Api;
using Point.Client.Main.Api.Dtos;
using Point.Client.Main.Api.Entities;
using Point.Client.Main.Api.Extensions;
using Point.Client.Main.Api.Services;
using Point.Client.Main.Forms.Products;

namespace Point.Client.Main.Listing
{
    public partial class frmItems : Form
    {
        private static bool _isAddingNew;
        private readonly ItemService _itemService;
        private readonly CategoryService _categoryService;
        private readonly TagService _tagService;

        public frmItems()
        {
            InitializeComponent();
            _itemService = ServiceLocator.GetService<ItemService>();
            _categoryService = ServiceLocator.GetService<CategoryService>();
            _tagService = ServiceLocator.GetService<TagService>();
        }

        private async void frmItems_Load(object sender, EventArgs e)
        {
            await Task.Run(async () =>
            {
                await SearchItems();
                await LoadCategories();
                await LoadTags();
            });
        }

        private void dgvItems_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvItems.SelectedRows.Count > 0)
            {
                ClearFields();

                var item = (Item)dgvItems.SelectedRows[0]?.Tag;

                txtItem.Tag = item.Id;
                txtItem.Text = item.Name;
                cmbCategory.Tag = item.Category?.Id;
                cmbCategory.Text = item.Category?.Name;
                txtCategory.Text = item.Category?.Name;
                txtDescription.Text = item.Description;
                item.Tags?.ToList().ForEach(t =>
                {
                    dgvTags.Rows.Add(t.Name, "Remove");
                    dgvTags.Rows[dgvTags.Rows.Count - 1].Tag = t.Id;
                });
            }
        }

        private void lnkManageCategories_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmCategories().ShowDialog();
            LoadCategories(frmCategories.HasUpdates);
        }

        private void dgvTags_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0
                && dgvTags.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                dgvTags.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void cmbTag_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTag.SelectedItem != null)
            {
                dgvTags.Rows.Add(cmbTag.Text, "Remove");
                dgvTags.Rows[dgvTags.Rows.Count - 1].Tag = cmbTag.SelectedValue;
            }
        }

        private void txtTag_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(txtTag.Text))
            {
                var tags = (List<Tag>)txtTag.Tag;
                var tagId = tags.FirstOrDefault(tag => tag.Name == txtTag.Text)?.Id;
                if (tagId != null)
                {
                    if (dgvTags.Rows.Cast<DataGridViewRow>().ToList()
                        .FirstOrDefault(row => (int)row.Tag == tagId) == null)
                    {
                        dgvTags.Rows.Add(txtTag.Text, "Remove");
                        dgvTags.Rows[dgvTags.Rows.Count - 1].Tag = tagId;

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

        private void lnkManageTags_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmTags().ShowDialog();
            if (frmTags.HasUpdates)
            {
                LoadTags(true);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            _isAddingNew = true;
            ClearFields();
            EnableEditing(true);
            txtItem.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            _isAddingNew = false;
            EnableEditing(true);
            txtItem.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtItem.Text))
            {
                MessageBox.Show("Item is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtItem.Focus();
                return;
            }

            if (!string.IsNullOrWhiteSpace(cmbCategory.Text) && cmbCategory.SelectedItem == null)
            {
                MessageBox.Show("Selected Category is invalid.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbCategory.Focus();
                return;
            }

            var item = new Item
            {
                Id = _isAddingNew ? 0 : (int)txtItem.Tag,
                Name = txtItem.Text.Trim(),
                Category = cmbCategory.SelectedItem != null 
                    ? new Category
                    {
                        Id = (int)cmbCategory.SelectedValue,
                        Name = cmbCategory.SelectedText
                    }
                    : null,
                Description = !string.IsNullOrWhiteSpace(txtDescription.Text.Trim())
                    ? txtDescription.Text.Trim()
                    : null,
                Tags = dgvTags.Rows.Count > 0
                    ? dgvTags.Rows.Cast<DataGridViewRow>().Select(row => new Tag
                    {
                        Id = (int)row.Tag,
                        Name = row.Cells[0].Value.ToString()
                    } ).ToList()
                    : null
            };

            EnableControls(false);

            if (_isAddingNew)
            {
                Task.Run(() => CreateItem(item));
            }
            else
            {
                Task.Run(() => UpdateItem(item));
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dgvItems_SelectionChanged(sender, e);

            EnableEditing(false);
        }

        #region Helpers

        private void ClearFields()
        {
            txtItem.Clear();
            txtCategory.Clear();
            cmbCategory.SelectedItem = null;
            txtDescription.Clear();
            dgvTags.Rows.Clear();
            txtTag.Clear();
        }

        private void EnableEditing(bool enable)
        {
            dgvItems.Enabled = !enable;

            txtItem.ReadOnly = !enable;
            txtCategory.Visible = !enable;
            cmbCategory.Visible = enable;
            lnkManageCategories.Visible = enable;
            txtDescription.ReadOnly = !enable;
            clmRemove.Visible = enable;
            txtTag.Visible = enable;
            lblTag.Visible = enable;
            lnkManageTags.Visible = enable;

            btnNew.Visible = !enable;
            btnEdit.Visible = !enable;
            btnSave.Visible = enable;
            btnCancel.Visible = enable;

            EnableControls();
        }

        private void EnableControls(bool enable = true)
        {
            this.Controls.OfType<Control>().ToList().ForEach(c => c.Enabled = enable);
        }

        #endregion

        #region Services

        private async void CreateItem(Item item)
        {
            try
            {
                var response = await _itemService.CreateItem(item.ToItemDto());

                this.Invoke((MethodInvoker)(() =>
                {
                    MessageBox.Show("New Item has been added.", "Request Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    var row = new DataGridViewRow();
                    row.CreateCells(dgvItems);
                    row.Cells[0].Value = item.Name;
                    row.Cells[1].Value = item.Category?.Name;
                    row.Cells[2].Value = item.Description;
                    row.Tag = item;
                    dgvItems.Rows.Add(row);

                    var rowIndex = dgvItems.Rows.Count - 1;
                    dgvItems.ClearSelection();
                    dgvItems.Rows[rowIndex].Selected = true;
                    dgvItems.FirstDisplayedScrollingRowIndex = rowIndex;

                    EnableEditing(false);
                }));
            }
            catch (HttpRequestException ex)
            {
                this.Invoke((MethodInvoker)(() =>
                {
                    MessageBox.Show(ex.Message, "Request Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    EnableEditing(true);
                }));
            }
        }

        private async void UpdateItem(Item item)
        {
            try
            {
                await _itemService.UpdateItem(item.Id, item.ToItemDto());

                this.Invoke((MethodInvoker)(() =>
                {
                    MessageBox.Show("Item has been updated.", "Request Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    var row = dgvItems.SelectedRows[0];
                    row.Cells[0].Value = item.Name;
                    row.Cells[1].Value = item.Category?.Name;
                    row.Cells[2].Value = item.Description;
                    row.Tag = item;

                    txtItem.Text = item.Name;
                    txtCategory.Text = item.Category?.Name;
                    txtDescription.Text = item.Description;

                    EnableEditing(false);
                }));
            }
            catch (HttpRequestException ex)
            {
                this.Invoke((MethodInvoker)(() =>
                {
                    MessageBox.Show(ex.Message, "Request Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    EnableEditing(true);
                }));
            }
        }

        private async Task SearchItems()
        {
            var frmText = this.Text;
            this.Invoke((MethodInvoker)(() =>
            {
                EnableControls(false);

                this.Text = "Loading Items...";
            }));

            var response = await _itemService.SearchItems();

            this.Invoke((MethodInvoker)(() =>
            {
                DataGridViewRow row;
                response?.ForEach(item =>
                {
                    row = new DataGridViewRow();
                    row.CreateCells(dgvItems);
                    row.Cells[0].Value = item.Name;
                    row.Cells[1].Value = item.Category?.Name;
                    row.Cells[2].Value = item.Description;
                    row.Tag = item;
                    dgvItems.Rows.Add(row);
                });

                this.Text = frmText;
                EnableControls(true);
            }));
        }

        private async Task LoadCategories(bool clearSelection = false)
        {
            var frmText = this.Text;
            this.Invoke((MethodInvoker)(() =>
            {
                EnableControls(false);

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
                EnableControls(true);
            }));
        }

        private async Task LoadTags(bool clearSelection = false)
        {
            var frmText = this.Text;
            this.Invoke((MethodInvoker)(() =>
            {
                EnableControls(false);

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
                EnableControls(true);
            }));
        }

        #endregion
    }
}
