using System.Data.SqlTypes;
using Point.Client.Main.Api;
using Point.Client.Main.Api.Entities.Orders;
using Point.Client.Main.Api.Enums;
using Point.Client.Main.Api.Extensions;
using Point.Client.Main.Api.Services;
using Point.Client.Main.Constants;
using Point.Client.Main.Globals;

namespace Point.Client.Main.Forms.Sales
{
    public partial class frmSales : Form
    {
        private bool _isFirstLoad;

        private int _currentPage;
        private int _currentTotalPages;
        private int _currentPageSize;
        private OrderStatus _currentOrderStatus;

        private readonly OrderService _orderService;

        public frmSales()
        {
            InitializeComponent();

            _isFirstLoad = true;

            _currentPage = 1;
            _currentTotalPages = 0;
            _currentPageSize = FormConstants.Pagination.PageSizes.ElementAtOrDefault(0);
            _currentOrderStatus = OrderStatus.New;

            _orderService = ServiceFactory.GetService<OrderService>();

            cmbPageSize.Items.AddRange(FormConstants.Pagination.PageSizes.Cast<object>().ToArray());
        }

        private void frmSales_Load(object sender, EventArgs e)
        {
            if (_isFirstLoad)
            {
                ClearFields();

                _isFirstLoad = false;

                var orderStatuses = new List<OrderStatus>
                {
                    OrderStatus.Released,
                    OrderStatus.Partially_Paid,
                    OrderStatus.Paid,
                    OrderStatus.Refunded,
                };
                cmbStatus.ComboBox.DataSource = orderStatuses.ToList();
                cmbStatus.SelectedIndex = 0;
            }

            RecordStatus.Orders.OnDataUpdated += ReloadData;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {

        }

        private void refundToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnVoid_Click(object sender, EventArgs e)
        {

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void dgvSales_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSales.SelectedRows.Count > 0)
            {
                ClearFields();

                var order = (Order)dgvSales.SelectedRows[0]?.Tag;

                if (order.Status == OrderStatus.Released || order.Status == OrderStatus.Partially_Paid)
                {
                    lblTerm.Visible = true;
                    lblOrderTerm.Visible = true;
                    lblLastPayment.Visible = true;
                    lblOrderLastPayment.Visible = true;

                    btnPay.Enabled = true;
                    btnVoid.Enabled = true;
                    btnAddPayment.Visible = true;
                }
                else if (order.Status == OrderStatus.Paid)
                {
                    btnRefund.Enabled = true;
                    btnVoid.Enabled = true;
                }

                lblOrderNumber.Text = order.Number.ToOrderNumberString();
                lblStatus.Text = order.Status.ToString();
                lblCustomer.Text = order.Customer?.Name ?? "-";
                lblDateTime.Text = order.Created.ConvertToLongDateString();

                txtReceivable.Text = order.Total.ToAmountString();
                txtPayment.Text = order.Payments.GenerateTotal().ToAmountString();
                txtBalance.Text = order.GenerateBalance().ToAmountString();

                lblOrderTerm.Text = order.PaymentTerm?.GetDescription() ?? "-";
                lblOrderLastPayment.Text = order.GetLastPayment()?.ToString() ?? "-";

                order.Items.ForEach(item =>
                {
                    dgvOrderItems.Rows.Add(
                        item.ItemName,
                        item.UnitName,
                        item.Quantity,
                        item.Price.ToAmountString(),
                        item.Total.ToAmountString());
                });

                lblSubTotal.Text = order.SubTotal.ToAmountString();
                lblDiscount.Text = order.Discount.ToAmountString();
                lblTotalItems.Text = order.Total.ToAmountString();

                order.Payments?.ForEach(payment =>
                {
                    dgvPayments.Rows.Add(
                        payment.Created,
                        payment.Amount.ToAmountString(),
                        payment.Mode,
                        payment.Reference,
                        payment.Remarks);
                });

                lblTotalPayments.Text = order.Payments?.GenerateTotal().ToAmountString() ?? "0.00";
            }
        }

        #region Search and Pagination

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentOrderStatus = (OrderStatus)cmbStatus.ComboBox.SelectedValue;
            if (cmbPageSize.SelectedItem == null)
                cmbPageSize.SelectedIndex = 0;
            else
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

        #endregion

        #region Helpers

        private void ReloadData()
        {
            cmbPageSize_SelectedIndexChanged(null, null);
        }

        private void ClearFields()
        {
            lblOrderNumber.Text = string.Empty;
            lblStatus.Text = "-";
            lblDateTime.Text = string.Empty;
            lblCustomer.Text = "-";

            txtReceivable.Text = "0.00";
            txtPayment.Text = "0.00";
            txtBalance.Text = "0.00";
            lblOrderTerm.Text = "-";
            lblOrderLastPayment.Text = "-";

            dgvOrderItems.Rows.Clear();
            lblSubTotal.Text = "0.00";
            lblDiscount.Text = "0.00";
            lblTotalItems.Text = "0.00";

            dgvPayments.Rows.Clear();
            lblTotalPage.Text = "0.00";

            lblTerm.Visible = false;
            lblOrderTerm.Visible = false;
            lblLastPayment.Visible = false;
            lblOrderLastPayment.Visible = false;

            btnPay.Enabled = false;
            btnRefund.Enabled = false;
            btnVoid.Enabled = false;

            btnAddPayment.Visible = false;
        }

        private void EnableControls(bool enable = true)
        {
            this.Controls.OfType<Control>().ToList().ForEach(c => c.Enabled = enable);
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
            var frmText = this.Text;
            this.Invoke((MethodInvoker)(() =>
            {
                EnableControls(false);

                this.Text = "Loading Orders...";
            }));

            var response = await _orderService.SearchOrders(_currentPage, _currentPageSize, customerId: null,
                [_currentOrderStatus]);

            this.Invoke((MethodInvoker)(() =>
            {
                _currentTotalPages = 0;

                dgvSales.Rows.Clear();
                txtPage.Clear();
                lblTotalPage.Text = string.Format(FormConstants.Pagination.TotalPagesCountLabel, 0);
                ClearFields();

                if (response?.TotalCount > 0)
                {
                    txtPage.Text = _currentPage.ToString();
                    _currentTotalPages = (int)Math.Ceiling((decimal)response?.TotalCount / _currentPageSize);
                    lblTotalPage.Text = string.Format(FormConstants.Pagination.TotalPagesCountLabel, _currentTotalPages);

                    DataGridViewRow row;
                    response?.Data?.ForEach(order =>
                    {
                        row = new DataGridViewRow();
                        row.CreateCells(dgvSales);
                        UpdateRowValues(order, row);
                        dgvSales.Rows.Add(row);
                    });
                }

                this.Text = frmText;
                EnableControls();
            }));
        }

        #endregion

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
