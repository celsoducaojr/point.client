using Point.Client.Main.Api;
using Point.Client.Main.Api.Dtos;
using Point.Client.Main.Api.Entities;
using Point.Client.Main.Api.Enums;
using Point.Client.Main.Api.Extensions;
using Point.Client.Main.Api.Services;
using Point.Client.Main.Constants;
using Point.Client.Main.Forms.Listing;
using Point.Client.Main.Forms.Stocks;
using Point.Client.Main.Globals;
using static Point.Client.Main.Globals.RecordStatus;

namespace Point.Client.Main.Listing
{
    public partial class frmItemUnits : Form
    {
        private bool _isFirstLoad;

        private SearchItemCriteriaDto? _searchItemDto;
        private int _currentPage;
        private int _currentTotalPages;
        private int _currentPageSize;
        private List<PriceType>? _currentPriceTypes;

        private DateTime? _categoryLastUpdate;
        private DateTime? _tagLastUpdate;
        private DateTime? _unitLastUpdate;
        private DateTime? _itemLastUpdate;
        private DateTime? _priceTypeLastUpdate;

        private readonly ItemService _itemService;
        private readonly ItemUnitService _itemUnitService;
        private readonly PriceTypeService _priceTypeService;

        public frmItemUnits()
        {
            InitializeComponent();

            _isFirstLoad = true;

            _searchItemDto = null;
            _currentPage = 1;
            _currentTotalPages = 0;
            _currentPageSize = FormConstants.Pagination.PageSizes.ElementAtOrDefault(0);
            _currentPriceTypes = null;

            _categoryLastUpdate = null;
            _tagLastUpdate = null;
            _unitLastUpdate = null;
            _itemLastUpdate = null;
            _priceTypeLastUpdate = null;

            _itemService = ServiceFactory.GetService<ItemService>();
            _itemUnitService = ServiceFactory.GetService<ItemUnitService>();
            _priceTypeService = ServiceFactory.GetService<PriceTypeService>();

            cmbPageSize.Items.AddRange(FormConstants.Pagination.PageSizes.Cast<object>().ToArray());
            lblSearchCriteria.Text = null;
        }

        private async void frmItemUnits_Load(object sender, EventArgs e)
        {
            EnableControls(false);

            if (_isFirstLoad)
            {
                _isFirstLoad = false;

                await Task.Run(LoadPriceTypes);

                cmbPageSize.SelectedIndex = 0;
            }
            else if (_categoryLastUpdate != Categories.LastUpdate
                || _tagLastUpdate != Tags.LastUpdate
                || _unitLastUpdate != Units.LastUpdate
                || _itemLastUpdate != Items.LastUpdate
                || _priceTypeLastUpdate != PriceTypes.LastUpdate)
            {
                _categoryLastUpdate = Categories.LastUpdate;
                _tagLastUpdate = Tags.LastUpdate;
                _unitLastUpdate = Units.LastUpdate;
                _itemLastUpdate = Items.LastUpdate;
                _priceTypeLastUpdate = PriceTypes.LastUpdate;

                await Task.Run(LoadPriceTypes);

                cmbPageSize_SelectedIndexChanged(sender, e);
            }

            EnableControls();
        }

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

                await SearchItemsWithUnits();
            }
        }

        private async void btnClearFilter_Click(object sender, EventArgs e)
        {
            _searchItemDto = null;
            lblSearchCriteria.Text = null;

            await SearchItemsWithUnits();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (_currentTotalPages > 0 && _currentPage != 1)
            {
                _currentPage = 1;

                Task.Run(() => SearchItemsWithUnits());
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

                Task.Run(() => SearchItemsWithUnits());
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

                Task.Run(() => SearchItemsWithUnits());
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (_currentTotalPages > 0 && _currentPage != _currentTotalPages)
            {
                _currentPage = _currentTotalPages;

                Task.Run(() => SearchItemsWithUnits());
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
                    Task.Run(() => SearchItemsWithUnits());
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

                await SearchItemsWithUnits();
            });
        }

        #endregion

        #region Edit

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
            EnableControls(false);

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
            Task.Run(() => SearchItemsWithUnits());
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

            EnableControls();
        }

        private void EnableControls(bool enable = true)
        {
            dgvItemUnits.EndEdit();

            this.Controls.OfType<Control>().ToList().ForEach(c => c.Enabled = enable);
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
            try
            {
                await _itemUnitService.PatchItemUnits(itemUnits);

                this.Invoke((MethodInvoker)(() =>
                {
                    MessageBox.Show("Item-units has been updated.", "Request Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    EnableEditing(false);
                }));

                ItemUnits.Updated();
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

        private async Task SearchItemsWithUnits()
        {
            var frmText = this.Text;
            this.Invoke((MethodInvoker)(() =>
            {
                EnableControls(false);

                this.Text = "Loading Items Units...";
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

                this.Text = frmText;
                EnableControls();
            }));
        }

        private async Task LoadPriceTypes()
        {
            var frmText = this.Text;
            this.Invoke((MethodInvoker)(() =>
            {
                EnableControls(false);

                this.Text = "Loading Price Types Columns...";
            }));

            _currentPriceTypes = await _priceTypeService.GetPricesTypes();

            this.Invoke((MethodInvoker)(() =>
            {
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

                this.Text = frmText;
                EnableControls();
            }));
        }

        #endregion
    }
}
