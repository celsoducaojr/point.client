using Point.Client.Main.Api;
using Point.Client.Main.Api.Dtos;
using Point.Client.Main.Api.Entities;
using Point.Client.Main.Api.Extensions;
using Point.Client.Main.Api.Services;
using Point.Client.Main.Constants;
using Point.Client.Main.Globals;

namespace Point.Client.Main.Listing
{
    public partial class frmItems : Form
    {
        private bool _isFirstLoad;
        private bool _isAddingNew;
        private bool _isActive;
        private bool _hasChanges;

        private SearchItemCriteriaDto? _searchItemDto;
        private int _currentPage;
        private int _currentTotalPages;
        private int _currentPageSize;

        private DateTime? _categoryLastUpdate;
        private DateTime? _tagLastUpdate;

        private readonly ItemService _itemService;
        private readonly CategoryService _categoryService;
        private readonly TagService _tagService;

        public frmItems()
        {
            InitializeComponent();

            _isFirstLoad = true;
            _isAddingNew = false;
            _isActive = false;
            _hasChanges = false;

            _searchItemDto = null;
            _currentPage = 1;
            _currentTotalPages = 0;
            _currentPageSize = FormConstants.Pagination.PageSizes.ElementAtOrDefault(0);

            _categoryLastUpdate = null;
            RecordStatus.Categories.OnDataUpdated += ReloadCategories;
            _tagLastUpdate = null;
            RecordStatus.Tags.OnDataUpdated += ReloadTags;

            _itemService = ServiceFactory.GetService<ItemService>();
            _categoryService = ServiceFactory.GetService<CategoryService>();
            _tagService = ServiceFactory.GetService<TagService>();

            cmbPageSize.Items.AddRange(FormConstants.Pagination.PageSizes.Cast<object>().ToArray());
        }

        private async void frmItems_Activated(object sender, EventArgs e)
        {
            var reloadRequired = false;

            if (_categoryLastUpdate != RecordStatus.Categories.LastUpdate)
            {
                reloadRequired = true;
                await LoadCategories();
            }

            if (_tagLastUpdate != RecordStatus.Tags.LastUpdate)
            {
                reloadRequired = true;
                await LoadTags();
            }

            if (_isFirstLoad)
            {
                _isFirstLoad = false;

                cmbPageSize.SelectedIndex = 0;
            }
            else if (reloadRequired)
            {
                cmbPageSize_SelectedIndexChanged(sender, e);
            }

            _isActive = true;
        }

        private void frmItems_Deactivate(object sender, EventArgs e)
        {
            if (_hasChanges)
            {
                RecordStatus.Items.Updated();
                _hasChanges = false;
            }

            _isActive = false;
        }

        #region Editing

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _isAddingNew = true;
            ClearEditingFields();
            EnableEditing();
            txtItem.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            _isAddingNew = false;
            EnableEditing();
            txtItem.Focus();
        }

        private void btnAddItemUnit_Click(object sender, EventArgs e)
        {
            FormFactory.GetFormDialog<frmItemUnit>().ShowForSelection((Item)dgvItems.SelectedRows[0]?.Tag);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtItem.Text))
            {
                MessageBox.Show("Item is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtItem.Focus();
                return;
            }

            if (cmbCategory.SelectedItem == null)
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
                        Name = cmbCategory.Text
                    }
                    : null,
                Description = !string.IsNullOrWhiteSpace(txtDescription.Text.Trim())
                    ? txtDescription.Text.Trim()
                    : null,
                Tags = dgvTags.Rows.Count > 0
                    ? dgvTags.Rows.Cast<DataGridViewRow>()
                    .Select(row => row.Tag as Tag).ToList() as List<Tag>
                    : null
            };

            EnableButtons(false);

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

        private void dgvItems_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvItems.SelectedRows.Count > 0)
            {
                ClearEditingFields();

                var item = (Item)dgvItems.SelectedRows[0]?.Tag;

                txtItem.Tag = item.Id;
                txtItem.Text = item.Name;
                cmbCategory.Tag = item.Category?.Id;
                cmbCategory.Text = item.Category?.Name;
                txtCategory.Text = item.Category?.Name;
                txtDescription.Text = item.Description;
                item.Tags?.ToList().ForEach(tag =>
                {
                    dgvTags.Rows.Add(tag.Name, "Remove");
                    dgvTags.Rows[dgvTags.Rows.Count - 1].Tag = tag;
                });
            }
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

        #endregion

        #region Search and Pagination

        private async void ReloadCategories()
        {
            if (_isActive)
            {
                if (btnCancel.Visible) btnCancel_Click(this, EventArgs.Empty);

                await LoadCategories();
                await SearchItems(); // Items has categories
            }
        }

        private async void ReloadTags()
        {
            if (_isActive)
            {
                if (btnCancel.Visible) btnCancel_Click(this, EventArgs.Empty);

                await LoadTags();
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            txtSearchItem.Clear();
            _searchItemDto = null;

            Task.Run(() => SearchItems());
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (_currentTotalPages > 0 && _currentPage != 1)
            {
                _currentPage = 1;

                Task.Run(() => SearchItems());
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (_currentTotalPages > 0 && _currentPage > 1)
            {
                _currentPage = 1;
                if (int.TryParse(txtPage.Text, out var selectedPage)
                    && selectedPage > 1)
                {
                    _currentPage = selectedPage - 1;
                }

                Task.Run(() => SearchItems());
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_currentTotalPages > 0 && _currentPage < _currentTotalPages)
            {
                _currentPage = _currentTotalPages;
                if (int.TryParse(txtPage.Text, out var selectedPage)
                    && selectedPage < _currentTotalPages)
                {
                    _currentPage = selectedPage + 1;
                }

                Task.Run(() => SearchItems());
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (_currentTotalPages > 0 && _currentPage != _currentTotalPages)
            {
                _currentPage = _currentTotalPages;

                Task.Run(() => SearchItems());
            }

        }

        private void txtPage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && _currentTotalPages > 0)
            {
                if (int.TryParse(txtPage.Text, out var selectedPage)
                    && selectedPage > 0 && selectedPage != _currentPage && selectedPage <= _currentTotalPages)
                {
                    _currentPage = selectedPage;
                    Task.Run(() => SearchItems());
                }
                else
                {
                    txtPage.Text = _currentPage.ToString();
                }
            }
        }

        private void cmbPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            Task.Run(async () =>
            {
                this.Invoke((MethodInvoker)(() =>
                {
                    _currentPage = 1;
                    _currentPageSize = FormConstants.Pagination.PageSizes[cmbPageSize.SelectedIndex];
                }));

                await SearchItems();
            });
        }

        private void txtSearchItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(txtSearchItem.Text))
            {
                _searchItemDto = new SearchItemCriteriaDto
                {
                    Name = txtSearchItem.Text.Trim()
                };

                Task.Run(() => SearchItems());
            }
        }

        #endregion

        #region Helpers

        private void ClearEditingFields()
        {
            txtItem.Clear();
            txtCategory.Clear();
            cmbCategory.SelectedItem = null;
            txtDescription.Clear();
            dgvTags.Rows.Clear();
            txtTag.Clear();
        }

        private void EnableEditing(bool enable = true)
        {
            pnlList.Enabled = !enable;

            txtItem.ReadOnly = !enable;
            txtCategory.Visible = !enable;
            cmbCategory.Visible = enable;
            txtDescription.ReadOnly = !enable;
            clmRemove.Visible = enable;
            txtTag.Visible = enable;

            btnAdd.Visible = !enable;
            btnEdit.Visible = !enable;
            btnAddItemUnit.Visible = !enable;
            btnSave.Visible = enable;
            btnCancel.Visible = enable;

            EnableButtons();
        }

        private void EnableButtons(bool enable = true)
        {
            pnlEdit.Controls.OfType<Button>().ToList().ForEach(c => c.Enabled = enable);
        }

        private void EnableFormLoading(bool enable = true, string? message = null)
        {
            this.ControlBox = !enable;
            this.Controls.OfType<Control>().ToList().ForEach(c => c.Enabled = !enable);

           

            if (enable)
            {
                this.Invoke((MethodInvoker)(() =>
                {
                    btnEdit.Enabled = false;
                    btnAddItemUnit.Enabled = false;

                    this.UseWaitCursor = true;
                    FormFactory.ShowLoadingForm(this, message);
                }));
            }
            else
            {
                this.Invoke((MethodInvoker)(() =>
                {
                    if (dgvItems.Rows.Count > 0)
                    {
                        btnEdit.Enabled = true;
                        btnAddItemUnit.Enabled = true;
                    }

                    this.UseWaitCursor = false;
                    FormFactory.CloseLoadingForm(this);
                }));
            }
        }

        private void UpdateRowValues(Item item, DataGridViewRow row)
        {
            row.Cells[0].Value = item.Name;
            row.Cells[1].Value = item.Category?.Name;
            row.Tag = item;
        }

        #endregion

        #region Services

        private async void CreateItem(Item item)
        {
            try
            {
                var response = await _itemService.CreateItem(item.ToItemDto());
                item.Id = response.Id;

                this.Invoke((MethodInvoker)(() =>
                {
                    MessageBox.Show("New Item has been added.", "Request Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    var row = new DataGridViewRow();
                    row.CreateCells(dgvItems);
                    UpdateRowValues(item, row);
                    dgvItems.Rows.Add(row);

                    var rowIndex = dgvItems.Rows.Count - 1;
                    dgvItems.ClearSelection();
                    dgvItems.Rows[rowIndex].Selected = true;
                    dgvItems.FirstDisplayedScrollingRowIndex = rowIndex;

                    EnableEditing(false);
                }));

                _hasChanges = true;
            }
            catch (HttpRequestException ex)
            {
                this.Invoke((MethodInvoker)(() =>
                {
                    MessageBox.Show(ex.Message, "Request Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    EnableEditing();
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

                    UpdateRowValues(item, dgvItems.SelectedRows[0]);

                    txtItem.Text = item.Name;
                    txtCategory.Text = item.Category?.Name;
                    txtDescription.Text = item.Description;

                    EnableEditing(false);
                }));

                _hasChanges = true;
            }
            catch (HttpRequestException ex)
            {
                this.Invoke((MethodInvoker)(() =>
                {
                    MessageBox.Show(ex.Message, "Request Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    EnableEditing();
                }));
            }
        }

        private async Task SearchItems()
        {
            this.Invoke((MethodInvoker)(() =>
            {
                EnableFormLoading(true, "Loading Items...");
            }));

            var response = await _itemService.SearchItems(_currentPage, _currentPageSize,
                _searchItemDto?.Name, _searchItemDto?.Category?.Id, _searchItemDto?.Tags?.Select(tag => tag.Id).ToList());

            this.Invoke((MethodInvoker)(() =>
            {
                _currentTotalPages = 0;

                dgvItems.Rows.Clear();
                txtPage.Clear();
                lblTotalPage.Text = string.Format(FormConstants.Pagination.TotalPagesCountLabel, 0);
                ClearEditingFields();

                if (response?.TotalCount > 0)
                {
                    txtPage.Text = _currentPage.ToString();
                    _currentTotalPages = (int)Math.Ceiling((decimal)response?.TotalCount / _currentPageSize);
                    lblTotalPage.Text = string.Format(FormConstants.Pagination.TotalPagesCountLabel, _currentTotalPages);

                    DataGridViewRow row;
                    response?.Data?.ForEach(item =>
                    {
                        row = new DataGridViewRow();
                        row.CreateCells(dgvItems);
                        UpdateRowValues(item, row);
                        dgvItems.Rows.Add(row);
                    });
                }

                EnableFormLoading(false);
            }));
        }

        private async Task LoadCategories(bool clearSelection = false)
        {
            _categoryLastUpdate = RecordStatus.Categories.LastUpdate;

            this.Invoke((MethodInvoker)(() =>
            {
                EnableFormLoading(true, "Loading Categories...");
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

                EnableFormLoading(false);
            }));
        }

        private async Task LoadTags()
        {
            _tagLastUpdate = RecordStatus.Tags.LastUpdate;

            this.Invoke((MethodInvoker)(() =>
            {
                EnableFormLoading(true, "Loading Tags...");
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

                EnableFormLoading(false);
            }));
        }

        #endregion
    }
}
