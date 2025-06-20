﻿using System.Threading.Tasks;
using Point.Client.Main.Api;
using Point.Client.Main.Api.Dtos;
using Point.Client.Main.Api.Entities;
using Point.Client.Main.Api.Extensions;
using Point.Client.Main.Api.Services;
using Point.Client.Main.Constants;
using Point.Client.Main.Forms.Listing;
using Point.Client.Main.Forms.Products;
using Point.Client.Main.Globals;

namespace Point.Client.Main.Listing
{
    public partial class frmItems : Form
    {
        private bool _showForSelection;

        private bool _isFirstLoad;
        private bool _isAddingNew;

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

            _showForSelection = false;

            _isFirstLoad = true;
            _isAddingNew = false;

            _searchItemDto = null;
            _currentPage = 1;
            _currentTotalPages = 0;
            _currentPageSize = FormConstants.Pagination.PageSizes.ElementAtOrDefault(0);

            _categoryLastUpdate = null;
            _tagLastUpdate = null;

            _itemService = ServiceFactory.GetService<ItemService>();
            _categoryService = ServiceFactory.GetService<CategoryService>();
            _tagService = ServiceFactory.GetService<TagService>();

            cmbPageSize.Items.AddRange(FormConstants.Pagination.PageSizes.Cast<object>().ToArray());
            lblSearchCriteria.Text = null;
        }

        #region Main

        private async void frmItems_Load(object sender, EventArgs e)
        {
            await Task.Run(async () =>
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

                // Reload Items
                if (!_isFirstLoad && reloadRequired) cmbPageSize_SelectedIndexChanged(sender, e);
            });

            if (_isFirstLoad)
            {
                _isFirstLoad = false;

                cmbPageSize.SelectedIndex = 0;
            }

            // Show Add-button
            if (_showForSelection) dgvItems_SelectionChanged(sender, e);
        }

        private void frmItems_FormClosing(object sender, FormClosingEventArgs e)
        {
            _showForSelection = false;
            btnAddItemUnit.Visible = false;

            if (btnCancel.Visible)
            {
                btnCancel_Click(sender, e);
            }
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

                btnAddItemUnit.Visible = _showForSelection;
            }
        }

        private void btnAddItemUnit_Click(object sender, EventArgs e)
        {
            FormFactory.GetFormDialog<frmItemUnit>().ShowForSelection((Item)dgvItems.SelectedRows[0]?.Tag);
        }

        public void ShowForSelection()
        {
            _showForSelection = true;
            this.ShowDialog();
        }

        #endregion

        #region Search and Pagination

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var itemSearchForm = FormFactory.GetFormDialog<frmItemSearch>();
            if (itemSearchForm.ShowDialog() == DialogResult.OK)
            {
                _searchItemDto = itemSearchForm.SearchItemCriteria;
                lblSearchCriteria.Text = null;

                if (_searchItemDto != null)
                {
                    var criteria = new List<string>
                    {
                        _searchItemDto?.Name ?? string.Empty,
                        _searchItemDto?.Category?.Name ?? string.Empty,
                        string.Join(", ", _searchItemDto?.Tags?.Select(tag => tag.Name)?.ToList() ?? [])
                    };
                    lblSearchCriteria.Text = criteria.ToSearchResultLabel();
                }

                await SearchItems();
            }
        }

        private async void btnClearFilter_Click(object sender, EventArgs e)
        {
            _searchItemDto = null;
            lblSearchCriteria.Text = null;

            await SearchItems();
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

        private async void cmbPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            await Task.Run(async () =>
            {
                this.Invoke((MethodInvoker)(() =>
                {
                    _currentPage = 1;
                    _currentPageSize = FormConstants.Pagination.PageSizes[cmbPageSize.SelectedIndex];
                }));

                await SearchItems();
            });
        }

        #endregion

        #region Edit

        private async void lnkManageCategories_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormFactory.GetFormDialog<frmCategories>().ShowDialog();

            await LoadCategories(true);
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

        private async void lnkManageTags_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormFactory.GetFormDialog<frmTags>().ShowDialog();

            await LoadTags();
        }

        private void btnNew_Click(object sender, EventArgs e)
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

            btnAddItemUnit.Visible = false;
        }

        private void EnableEditing(bool enable = true)
        {
            pnlList.Enabled = !enable;

            txtItem.ReadOnly = !enable;
            txtCategory.Visible = !enable;
            cmbCategory.Visible = enable;
            lnkManageCategories.Visible = enable;
            txtDescription.ReadOnly = !enable;
            clmRemove.Visible = enable;
            txtTag.Visible = enable;
            lnkManageTags.Visible = enable;

            btnNew.Visible = !enable;
            btnEdit.Visible = !enable;
            btnSave.Visible = enable;
            btnCancel.Visible = enable;

            EnableButtons();
        }

        private void EnableButtons(bool enable = true)
        {
            pnlEdit.Controls.OfType<Button>().ToList().ForEach(c => c.Enabled = enable);
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

                RecordStatus.Items.Updated();
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

                RecordStatus.Items.Updated();
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
            var frmText = this.Text;
            this.Invoke((MethodInvoker)(() =>
            {
                tlpMain.Enabled = false;

                this.Text = "Loading Items...";
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

                this.Text = frmText;
                tlpMain.Enabled = true;
            }));
        }

        private async Task LoadCategories(bool clearSelection = false)
        {
            if (_categoryLastUpdate == RecordStatus.Categories.LastUpdate) return;
            _categoryLastUpdate = RecordStatus.Categories.LastUpdate;

            var frmText = this.Text;
            this.Invoke((MethodInvoker)(() =>
            {
                tlpMain.Enabled = false;

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
                tlpMain.Enabled = true;
            }));
        }

        private async Task LoadTags()
        {
            if (_tagLastUpdate == RecordStatus.Tags.LastUpdate) return;
            _tagLastUpdate = RecordStatus.Tags.LastUpdate;

            var frmText = this.Text;
            this.Invoke((MethodInvoker)(() =>
            {
                tlpMain.Enabled = false;

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
                tlpMain.Enabled = true;
            }));
        }

        #endregion
    }
}
