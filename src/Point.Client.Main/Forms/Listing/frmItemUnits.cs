using Point.Client.Main.Api;
using Point.Client.Main.Api.Dtos;
using Point.Client.Main.Api.Entities;
using Point.Client.Main.Api.Enums;
using Point.Client.Main.Api.Extensions;
using Point.Client.Main.Api.Services;
using Point.Client.Main.Constants;
using Point.Client.Main.Forms.Stocks;
using Point.Client.Main.Globals;

namespace Point.Client.Main.Listing
{
    public partial class frmItemUnits : Form
    {
        private bool _isFirstLoad;
        private bool _isActive;
        private bool _hasChanges;

        private SearchItemCriteriaDto? _searchItemDto;
        private int _currentPage;
        private int _currentTotalPages;
        private int _currentPageSize;
        private List<PriceType>? _currentPriceTypes;

        private DateTime? _listingLastUpdate;

        private readonly ItemService _itemService;
        private readonly ItemUnitService _itemUnitService;
        private readonly PriceTypeService _priceTypeService;

        public frmItemUnits()
        {
            InitializeComponent();

            _isFirstLoad = true;
            _isActive = false;
            _hasChanges = false;

            _searchItemDto = null;
            _currentPage = 1;
            _currentTotalPages = 0;
            _currentPageSize = FormConstants.Pagination.PageSizes.ElementAtOrDefault(0);
            _currentPriceTypes = null;

            _listingLastUpdate = RecordStatus.Domain.Listing.LastUpdate;
            RecordStatus.Domain.Listing.OnDataUpdated += ReloadData;

            _itemService = ServiceFactory.GetService<ItemService>();
            _itemUnitService = ServiceFactory.GetService<ItemUnitService>();
            _priceTypeService = ServiceFactory.GetService<PriceTypeService>();

            cmbPageSize.Items.AddRange(FormConstants.Pagination.PageSizes.Cast<object>().ToArray());
        }

        private async void frmItemUnits_Activated(object sender, EventArgs e)
        {
            if (_isFirstLoad)
            {
                _isFirstLoad = false;

                await Task.Run(LoadPriceTypes);

                cmbPageSize.SelectedIndex = 0;
            }
            else if (_listingLastUpdate != RecordStatus.Domain.Listing.LastUpdate)
            {
                await Task.Run(LoadPriceTypes);

                cmbPageSize_SelectedIndexChanged(sender, e);
            }

            _isActive = true;
        }

        private void frmItemUnits_Deactivate(object sender, EventArgs e)
        {
            if (_hasChanges)
            {
                RecordStatus.ItemUnits.Updated();
                _hasChanges = false;
            }

            _isActive = false;
        }

        #region Editing

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EnableEditing();
        }

        private void addStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvItemUnits.SelectedCells.Count == 0)
            {
                MessageBox.Show("Please select an Item-unit to add stock.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedRow = dgvItemUnits.SelectedCells[0].OwningRow;
            new frmUpdateStock(
                StockUpdateType.Addition,
                selectedRow.Cells["clmItem"].Value.ToString(),
                selectedRow.Cells["clmUnit"].Value.ToString(),
                int.Parse(selectedRow.Tag.ToString()))
                .ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var itemUnits = new List<ItemUnitPatchDto>();

            foreach (DataGridViewRow row in dgvItemUnits.Rows)
            {
                var prices = new List<PriceDto>();

                _currentPriceTypes?.ForEach(type =>
                {
                    decimal.TryParse(row.Cells[type.Id.ToString()].Value?.ToString(), out decimal amount);
                    prices.Add(new PriceDto
                    {
                        PriceTypeId = type.Id,
                        Amount = amount
                    });
                });

                itemUnits.Add(new ItemUnitPatchDto
                {
                    Id = (int)row.Tag,
                    CostPriceCode = row.Cells["clmCapitalCode"].Value?.ToString(),
                    Prices = prices.Count > 0 ? prices : null
                });
            }

            Task.Run(() => PatchItemUnits(itemUnits));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            EnableEditing(false);
            Task.Run(() => SearchItems());
        }

        private void dgvItemUnits_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            var columnTag = dgvItemUnits.Columns[e.ColumnIndex].Tag;

            if (columnTag != null && columnTag.ToString() == FormConstants.DataGridView.Tags.Price)
            {
                var value = e.FormattedValue?.ToString() ?? string.Empty;

                if (!string.IsNullOrWhiteSpace(value) && (!decimal.TryParse(value, out decimal amount) || amount < 0))
                {
                    MessageBox.Show("Invalid Amount value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
        }

        private void dgvItemUnits_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            var columnTag = dgvItemUnits.Columns[e.ColumnIndex].Tag;

            if (columnTag != null && columnTag.ToString() == FormConstants.DataGridView.Tags.Price)
            {
                var cell = dgvItemUnits.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (decimal.TryParse(cell.Value?.ToString(), out decimal value))
                {
                    cell.Value = value.ToAmountString();
                }
            }
        }

        #endregion

        #region Search and Pagination

        private async void ReloadData()
        {
            if (_isActive)
            {
                await LoadPriceTypes();
                await SearchItems();
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
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

        private void EnableEditing(bool enable = true)
        {
            btnEdit.Visible = !enable;
            btnSave.Visible = enable;
            btnCancel.Visible = enable;

            dgvItemUnits.ReadOnly = !enable;
            dgvItemUnits.Columns["clmItem"].ReadOnly = enable;
            dgvItemUnits.Columns["clmCategory"].ReadOnly = enable;
            dgvItemUnits.Columns["clmUnit"].ReadOnly = enable;

            tsPages.Enabled = !enable;
        }

        private void EnableFormLoading(bool enable = true, string? message = null)
        {
            this.ControlBox = !enable;
            this.Controls.OfType<Control>().ToList().ForEach(c => c.Enabled = !enable);

            if (enable)
            {
                this.Invoke((MethodInvoker)(() =>
                {
                    this.UseWaitCursor = true;
                    FormFactory.ShowLoadingForm(this, message);
                }));
            }
            else
            {
                this.Invoke((MethodInvoker)(() =>
                {
                    if (dgvItemUnits.Rows.Count == 0)
                    {
                        tsMain.Enabled = false;
                    }

                    this.UseWaitCursor = false;
                    FormFactory.CloseLoadingForm(this);
                }));
            }
        }

        private void UpdateRowValues(Item item, ItemUnit unit, DataGridViewRow row)
        {
            row.Cells["clmItem"].Value = item.Name;
            row.Cells["clmCategory"].Value = item.Category?.Name;
            row.Cells["clmUnit"].Value = unit.Unit?.Name;
            row.Cells["clmCapitalCode"].Value = unit.CostPriceCode;

            _currentPriceTypes?.ForEach(type =>
            {
                var amount = unit.Prices?
                .Where(price => price.PriceType.Id == type.Id)
                .Select(price => price.Amount).FirstOrDefault() ?? 0;

                row.Cells[type.Id.ToString()].Value = amount;
            });

            row.Tag = unit.Id;
        }

        #endregion

        #region Services

        private async void PatchItemUnits(List<ItemUnitPatchDto> itemUnits)
        {
            this.Invoke((MethodInvoker)(() =>
            {
                EnableEditing(false);
                EnableFormLoading(true, "Updating Item-units Prices...");
            }));

            try
            {
                await _itemUnitService.PatchItemUnits(itemUnits);
                this.Invoke((MethodInvoker)(() =>
                {
                    EnableFormLoading(false);
                    MessageBox.Show("Item-units has been updated.", "Request Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }));

                _hasChanges = true;
            }
            catch (HttpRequestException ex)
            {
                this.Invoke((MethodInvoker)(() =>
                {
                    EnableEditing(true);
                    EnableFormLoading(false);
                    MessageBox.Show(ex.Message, "Request Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }));
            }
        }

        private async Task SearchItems()
        {
            _listingLastUpdate = RecordStatus.Domain.Listing.LastUpdate;

            this.Invoke((MethodInvoker)(() =>
            {
                EnableFormLoading(true, "Loading Item-units...");
            }));

            var response = await _itemService.SearchItemsWithUnits(_currentPage, _currentPageSize,
                _searchItemDto?.Name, _searchItemDto?.Category?.Id, _searchItemDto?.Tags?.Select(tag => tag.Id).ToList());

            this.Invoke((MethodInvoker)(() =>
            {
                _currentTotalPages = 0;

                dgvItemUnits.Rows.Clear();
                txtPage.Clear();
                lblTotalPage.Text = string.Format(FormConstants.Pagination.TotalPagesCountLabel, 0);

                if (response?.TotalCount > 0)
                {
                    txtPage.Text = _currentPage.ToString();
                    _currentTotalPages = (int)Math.Ceiling((decimal)response?.TotalCount / _currentPageSize);
                    lblTotalPage.Text = string.Format(FormConstants.Pagination.TotalPagesCountLabel, _currentTotalPages);

                    response?.Data?.ForEach(item =>
                    {
                        item.Units?.ForEach(unit =>
                        {
                            dgvItemUnits.Rows.Add(new DataGridViewRow());
                            UpdateRowValues(item, unit, dgvItemUnits.Rows[dgvItemUnits.Rows.Count - 1]);
                        });
                    });
                }

                EnableFormLoading(false);
            }));
        }

        private async Task LoadPriceTypes()
        {
            this.Invoke((MethodInvoker)(() =>
            {
                EnableFormLoading(true, "Loading Price Types...");
            }));

            _currentPriceTypes = await _priceTypeService.GetPricesTypes();

            this.Invoke((MethodInvoker)(() =>
            {
                dgvItemUnits.Columns.OfType<DataGridViewColumn>()
                .Where(c => c.Tag != null && c.Tag.ToString() == FormConstants.DataGridView.Tags.Price)
                .ToList().ForEach(c => dgvItemUnits.Columns.Remove(c));

                _currentPriceTypes?.ForEach(priceType =>
                {
                    var column = new DataGridViewTextBoxColumn()
                    {
                        Name = priceType.Id.ToString(),
                        HeaderText = priceType.Name,
                    };
                    column.Tag = FormConstants.DataGridView.Tags.Price;
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    column.DefaultCellStyle.Format = "N2";
                    column.Width = 175;
                    dgvItemUnits.Columns.Add(column);
                });

                EnableFormLoading(false);
            }));
        }

        #endregion
    }
}
