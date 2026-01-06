using Point.Client.Main.Api;
using Point.Client.Main.Api.Dtos;
using Point.Client.Main.Api.Entities.Orders;
using Point.Client.Main.Api.Enums;
using Point.Client.Main.Api.Extensions;
using Point.Client.Main.Api.Services;
using Point.Client.Main.Constants;
using Point.Client.Main.Globals;

namespace Point.Client.Main.Forms.Orders
{
    public partial class frmOrders : Form
    {
        private bool _isFirstLoad;
        private bool _isActive;
        private bool _hasChanges;

        private SearchOrderCriteriaDto? _searchOrderDto;

        private int _currentPage;
        private int _currentTotalPages;
        private int _currentPageSize;
        private OrderStatus _currentOrderStatus;

        private DateTime? _orderLastUpdate;

        private readonly OrderService _orderService;

        public frmOrders()
        {
            InitializeComponent();

            _isFirstLoad = true;
            _isActive = false;
            _hasChanges = false;

            _searchOrderDto = null;

            _currentPage = 1;
            _currentTotalPages = 0;
            _currentPageSize = FormConstants.Pagination.PageSizes.ElementAtOrDefault(0);
            _currentOrderStatus = OrderStatus.New;

            _orderLastUpdate = RecordStatus.Orders.LastUpdate;
            RecordStatus.Orders.OnDataUpdated += ReloadData;

            _orderService = ServiceFactory.GetService<OrderService>();

            cmbPageSize.Items.AddRange(FormConstants.Pagination.PageSizes.Cast<object>().ToArray());
        }
        private void frmOrders_Activated(object sender, EventArgs e)
        {
            if (_isFirstLoad)
            {
                _isFirstLoad = false;

                // Set available Order statuses
                var orderStatuses = new List<OrderStatus>
                {
                    OrderStatus.New,
                    OrderStatus.Cancelled
                };
                cmbStatus.DataSource = orderStatuses.ToList();
                cmbStatus.SelectedIndex = 0;
            }
            else if (_orderLastUpdate != RecordStatus.Orders.LastUpdate)
            {
                cmbPageSize_SelectedIndexChanged(sender, e);
            }

            _isActive = true;
        }

        private void frmOrders_Deactivate(object sender, EventArgs e)
        {
            _isActive = false;
        }

        #region Editing
        private void btnAddNewOrder_Click(object sender, EventArgs e)
        {
            FormFactory.GetForm<frmOrder>().Show();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            FormFactory.GetForm<frmOrder>().ShowForEdit((Order)dgvOrders.SelectedRows[0]?.Tag);
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count > 0)
            {
                var order = (Order)dgvOrders.SelectedRows[0]?.Tag;
                var form = new frmOrderStatusUpdate(order, OrderStatus.Released).ShowDialog();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count > 0)
            {
                var order = (Order)dgvOrders.SelectedRows[0]?.Tag;
                var form = new frmOrderStatusUpdate(order, OrderStatus.Cancelled).ShowDialog();
            }
        }

        private void dgvOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count > 0)
            {
                ClearOrderFields();

                var order = (Order)dgvOrders.SelectedRows[0]?.Tag;

                lblOrderNumber.Text = order.GenerateOrderNumberString();
                lblStatus.Text = order.Status.ToString();
                lblCustomer.Text = order.Customer?.Name ?? "-";
                lblDateTime.Text = order.Created.ConvertToLongDateString();

                order.Items.ForEach(item =>
                {
                    dgvOrderItems.Rows.Add(
                        item.ItemName,
                        item.UnitName,
                        item.Quantity,
                        item.Price.ToAmountString(),
                        item.Total.ToAmountString());
                });

                lblTotal.Text = order?.Total.ToAmountString();

                if (order.Status != OrderStatus.Cancelled)
                {
                    btnModify.Enabled = true;
                    btnRelease.Enabled = true;
                    btnCancel.Enabled = true;
                }
            }
        }

        #endregion

        #region Search and Pagination

        private async void ReloadData()
        {
            if (_isActive)
            {
                await SearchOrders();
            }
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            _searchOrderDto = null;

            Task.Run(() => SearchOrders());
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (_currentTotalPages > 0 && _currentPage != 1)
            {
                _currentPage = 1;

                Task.Run(() => SearchOrders());
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

                Task.Run(() => SearchOrders());
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

                Task.Run(() => SearchOrders());
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (_currentTotalPages > 0 && _currentPage != _currentTotalPages)
            {
                _currentPage = _currentTotalPages;

                Task.Run(() => SearchOrders());
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

                    Task.Run(() => SearchOrders());
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

                await SearchOrders();
            });
        }

        private void txtSearchCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(txtSearchCustomer.Text))
            {
                _searchOrderDto = new SearchOrderCriteriaDto
                {
                    CustomerName = txtSearchCustomer.Text.Trim()
                };

                Task.Run(() => SearchOrders());
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentOrderStatus = (OrderStatus)cmbStatus.SelectedValue;
            
            Task.Run(() => SearchOrders());
        }

        #endregion

        #region Helpers

        private void ClearOrderFields()
        {
            lblOrderNumber.Text = string.Empty;
            lblStatus.Text = "-";
            lblDateTime.Text = string.Empty;
            lblCustomer.Text = "-";
            dgvOrderItems.Rows.Clear();
            lblTotal.Text = "0.00";

            btnModify.Enabled = false;
            btnRelease.Enabled = false;
            btnCancel.Enabled = false;
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
                    this.UseWaitCursor = false;
                    FormFactory.CloseLoadingForm(this);
                }));
            }
        }
        private void UpdateRowValues(Order order, DataGridViewRow row)
        {
            row.Cells[0].Value = order.Number;
            row.Cells[1].Value = order.Created.ConvertToLongDateString();
            row.Cells[2].Value = order.Status;
            row.Cells[3].Value = order.Total.ToAmountString();
            row.Cells[4].Value = order.Customer?.Name;
            row.Tag = order;
        }

        #endregion

        #region Services

        private async Task SearchOrders()
        {
            _orderLastUpdate = RecordStatus.Orders.LastUpdate;

            this.Invoke((MethodInvoker)(() =>
            {
                EnableFormLoading(true, "Loading Orders...");
            }));

            var response = await _orderService.SearchOrders(_currentPage, _currentPageSize,
                customerId: null, customerName: _searchOrderDto?.CustomerName ?? null, [_currentOrderStatus]);

            this.Invoke((MethodInvoker)(() =>
            {
                _currentTotalPages = 0;

                dgvOrders.Rows.Clear();
                ClearOrderFields();
                txtPage.Clear();
                lblTotalPage.Text = string.Format(FormConstants.Pagination.TotalPagesCountLabel, 0);

                if (response?.TotalCount > 0)
                {
                    txtPage.Text = _currentPage.ToString();
                    _currentTotalPages = (int)Math.Ceiling((decimal)response?.TotalCount / _currentPageSize);
                    lblTotalPage.Text = string.Format(FormConstants.Pagination.TotalPagesCountLabel, _currentTotalPages);

                    DataGridViewRow row;
                    response?.Data?.ForEach(order =>
                    {
                        row = new DataGridViewRow();
                        row.CreateCells(dgvOrders);
                        UpdateRowValues(order, row);
                        dgvOrders.Rows.Add(row);
                    });
                }

                EnableFormLoading(false);
            }));
        }

        #endregion
    }
}
