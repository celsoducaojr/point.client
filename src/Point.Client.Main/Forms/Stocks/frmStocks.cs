using Point.Client.Main.Api;
using Point.Client.Main.Api.Dtos;
using Point.Client.Main.Api.Dtos.Response;
using Point.Client.Main.Api.Entities.Stocks;
using Point.Client.Main.Api.Enums;
using Point.Client.Main.Api.Services;
using Point.Client.Main.Constants;
using Point.Client.Main.Forms.Stocks;
using Point.Client.Main.Globals;

namespace Point.Client.Main.Stocks
{
    public partial class frmStocks : Form
    {
        private bool _isFirstLoad;
        private bool _isActive;
        private SearchItemCriteriaDto? _searchItemDto;

        private int _currentPage;
        private int _currentTotalPages;
        private int _currentPageSize;

        private DateTime? _listingLastUpdate;

        private readonly StockService _stockService;

        public frmStocks()
        {
            InitializeComponent();

            _isFirstLoad = true;
            _isActive = false;
            _searchItemDto = null;

            _currentPage = 1;
            _currentTotalPages = 0;
            _currentPageSize = FormConstants.Pagination.PageSizes.ElementAtOrDefault(0);

            _listingLastUpdate = RecordStatus.Domain.Listing.LastUpdate;
            RecordStatus.Domain.Listing.OnDataUpdated += ReloadData;

            _stockService = ServiceFactory.GetService<StockService>();

            cmbPageSize.Items.AddRange(FormConstants.Pagination.PageSizes.Cast<object>().ToArray());
        }

        private void frmStocks_Activated(object sender, EventArgs e)
        {
            if (_isFirstLoad)
            {
                _isFirstLoad = false;

                cmbPageSize.SelectedIndex = 0;
            }
            else if (_listingLastUpdate != RecordStatus.Domain.Listing.LastUpdate)
            {

                cmbPageSize_SelectedIndexChanged(sender, e);
            }

            _isActive = true;
        }

        private void frmStocks_Deactivate(object sender, EventArgs e)
        {
            _isActive = false;
        }

        #region Editing

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var stock = (StockResponseDto)dgvStocks.SelectedRows[0].Tag;
            var form = new frmUpdateStock(
                StockUpdateType.Addition,
                stock.ItemName,
                stock.ItemUnitName,
                stock.ItemUnitId);
            if (form.ShowDialog() == DialogResult.OK)
            {
                stock.Quantity += form.QuantityChanged;
                stock.Histories.Insert(0, new StockHistory
                {
                    Created = DateTime.Now,
                    QuantityChanged = form.QuantityChanged,
                    QuantityAfterChange = stock.Quantity,
                    Type = StockUpdateType.Addition,
                    Remarks = form.Remarks
                });
                dgvStocks.SelectedRows[0].Cells["clmQuantity"].Value = stock.Quantity;
                dgvStocks_SelectionChanged(null, null);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var stock = (StockResponseDto)dgvStocks.SelectedRows[0].Tag;
            var form = new frmUpdateStock(
                StockUpdateType.Removal,
                stock.ItemName,
                stock.ItemUnitName,
                stock.ItemUnitId);
            if (form.ShowDialog() == DialogResult.OK)
            {
                stock.Quantity -= form.QuantityChanged;
                stock.Histories.Insert(0, new StockHistory
                {
                    Created = DateTime.Now,
                    QuantityChanged = form.QuantityChanged,
                    QuantityAfterChange = stock.Quantity,
                    Type = StockUpdateType.Removal,
                    Remarks = form.Remarks
                });
                dgvStocks.SelectedRows[0].Cells["clmQuantity"].Value = stock.Quantity;
                dgvStocks_SelectionChanged(null, null);
            }
        }

        private void dgvStocks_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvStocks.SelectedRows.Count > 0)
            {
                ClearStockFields();

                var stock = (StockResponseDto?)dgvStocks.SelectedRows[0].Tag;

                stock.Histories.ForEach(history =>
                {
                    dgvHistories.Rows.Add(
                        history.Created,
                        history.QuantityChanged,
                        history.QuantityAfterChange,
                        history.Remarks);
                });
            }
        }

        #endregion

        #region Search and Pagination

        private async void ReloadData()
        {
            if (_isActive)
            {
                await SearchStocks();
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            _searchItemDto = null;

            Task.Run(() => SearchStocks());
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (_currentTotalPages > 0 && _currentPage != 1)
            {
                _currentPage = 1;

                Task.Run(() => SearchStocks());
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

                Task.Run(() => SearchStocks());
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

                Task.Run(() => SearchStocks());
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (_currentTotalPages > 0 && _currentPage != _currentTotalPages)
            {
                _currentPage = _currentTotalPages;

                Task.Run(() => SearchStocks());
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
                    Task.Run(() => SearchStocks());
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

                await SearchStocks();
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

                Task.Run(() => SearchStocks());
            }
        }

        #endregion

        #region Helpers

        private void ClearStockFields()
        {
            dgvHistories.Rows.Clear();
        }

        private void EnableFormLoading(bool enable = true, string? message = null)
        {
            this.ControlBox = !enable;
            this.Controls.OfType<Control>().ToList().ForEach(c => c.Enabled = !enable);

            if (dgvStocks.Rows.Count == 0)
            {
                tsMenu.Enabled = false;
            }

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
                    this.UseWaitCursor = false;
                    FormFactory.CloseLoadingForm(this);
                }));
            }
        }

        private void UpdateRowValues(StockResponseDto stock, DataGridViewRow row)
        {
            row.Cells[0].Value = stock.ItemName;
            row.Cells[1].Value = stock.CategoryName;
            row.Cells[2].Value = stock.ItemUnitName;
            row.Cells[3].Value = stock.Quantity;
            row.Tag = stock;
        }

        #endregion

        #region Services

        private async Task SearchStocks()
        {
            _listingLastUpdate = RecordStatus.Domain.Listing.LastUpdate;

            this.Invoke((MethodInvoker)(() =>
            {
                EnableFormLoading(true, "Loading Stocks...");
            }));

            Thread.Sleep(2000);
            var response = await _stockService.SearchStocks(_currentPage, _currentPageSize,
                _searchItemDto != null ? _searchItemDto.Name : null);

            this.Invoke((MethodInvoker)(() =>
            {
                _currentTotalPages = 0;

                dgvStocks.Rows.Clear();
                ClearStockFields();
                txtPage.Clear();
                lblTotalPage.Text = string.Format(FormConstants.Pagination.TotalPagesCountLabel, 0);

                if (response?.TotalCount > 0)
                {
                    txtPage.Text = _currentPage.ToString();
                    _currentTotalPages = (int)Math.Ceiling((decimal)response?.TotalCount / _currentPageSize);
                    lblTotalPage.Text = string.Format(FormConstants.Pagination.TotalPagesCountLabel, _currentTotalPages);

                    DataGridViewRow row;
                    response?.Data?.ForEach(stock =>
                    {
                        row = new DataGridViewRow();
                        row.CreateCells(dgvStocks);
                        UpdateRowValues(stock, row);
                        dgvStocks.Rows.Add(row);
                    });
                }

                EnableFormLoading(false);
            }));
        }

        #endregion
    }
}
