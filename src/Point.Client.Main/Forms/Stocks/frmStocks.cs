using Point.Client.Main.Api;
using Point.Client.Main.Api.Dtos;
using Point.Client.Main.Api.Dtos.Response;
using Point.Client.Main.Api.Entities;
using Point.Client.Main.Api.Entities.Stocks;
using Point.Client.Main.Api.Enums;
using Point.Client.Main.Api.Extensions;
using Point.Client.Main.Api.Services;
using Point.Client.Main.Constants;
using Point.Client.Main.Forms.Stocks;
using static Point.Client.Main.Globals.RecordStatus;

namespace Point.Client.Main.Stocks
{
    public partial class frmStocks : Form
    {
        private bool _isFirstLoad;

        private int _currentPage;
        private int _currentTotalPages;
        private int _currentPageSize;

        private DateTime? _stockLastUpdate;
        private DateTime? _itemLastUpdate;
        private DateTime? _unitLastUpdate;

        private readonly StockService _stockService;

        public frmStocks()
        {
            InitializeComponent();

            _isFirstLoad = true;

            _currentPage = 1;
            _currentTotalPages = 0;
            _currentPageSize = FormConstants.Pagination.PageSizes.ElementAtOrDefault(0);

            _stockLastUpdate = null;
            _itemLastUpdate = null;
            _unitLastUpdate = null;

            _stockService = ServiceFactory.GetService<StockService>();

            cmbPageSize.Items.AddRange(FormConstants.Pagination.PageSizes.Cast<object>().ToArray());
        }

        private void frmStocks_Load(object sender, EventArgs e)
        {
            EnableControls(false);

            if (_isFirstLoad)
            {
                _isFirstLoad = false;

                cmbPageSize.SelectedIndex = 0;
            }
            //else if (_categoryLastUpdate != Categories.LastUpdate
            //    || _tagLastUpdate != Tags.LastUpdate
            //    || _unitLastUpdate != Units.LastUpdate
            //    || _itemLastUpdate != Items.LastUpdate
            //    || _priceTypeLastUpdate != PriceTypes.LastUpdate)
            //{
            //    _categoryLastUpdate = Categories.LastUpdate;
            //    _tagLastUpdate = Tags.LastUpdate;
            //    _unitLastUpdate = Units.LastUpdate;
            //    _itemLastUpdate = Items.LastUpdate;
            //    _priceTypeLastUpdate = PriceTypes.LastUpdate;

            //    await Task.Run(LoadPriceTypes);

            //    cmbPageSize_SelectedIndexChanged(sender, e);
            //}

            EnableControls();
        }

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

        #region Search and Pagination

        private void btnReload_Click(object sender, EventArgs e)
        {
            txtSearchItem.Clear();

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

        #endregion

        #region Helpers

        private void ClearStockFields()
        {
            dgvHistories.Rows.Clear();
        }

        private void EnableControls(bool enable = true)
        {
            this.Controls.OfType<Control>().ToList().ForEach(c => c.Enabled = enable);

            if (dgvStocks.Rows.Count == 0)
            {
                tsMenu.Enabled = false;
                pnlSearch.Enabled = false;
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
            var frmText = this.Text;
            this.Invoke((MethodInvoker)(() =>
            {
                EnableControls(false);

                this.Text = "Loading Stocks...";
            }));

            var response = await _stockService.SearchStocks(_currentPage, _currentPageSize,
                !string.IsNullOrEmpty(txtSearchItem.Text) ? txtSearchItem.Text.Trim() : null);

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

                this.Text = frmText;
                EnableControls();
            }));
        }

        #endregion
        
    }
}
