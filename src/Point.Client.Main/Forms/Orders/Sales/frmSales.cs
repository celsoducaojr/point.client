using Point.Client.Main.Api;
using Point.Client.Main.Api.Dtos;
using Point.Client.Main.Api.Entities.Orders;
using Point.Client.Main.Api.Enums;
using Point.Client.Main.Api.Extensions;
using Point.Client.Main.Api.Services;
using Point.Client.Main.Constants;
using Point.Client.Main.Forms.Orders.Sales;
using Point.Client.Main.Globals;
using Point.Client.Main.Globals.Common.Objects;

namespace Point.Client.Main.Forms.Sales
{
    public partial class frmSales : Form
    {
        private bool _isFirstLoad;
        private Order? _currentOrder;

        private int _currentPage;
        private int _currentTotalPages;
        private int _currentPageSize;
        private ComboBoxItem<OrderStatus> _currentOrderStatus;

        private readonly OrderService _orderService;

        public frmSales()
        {
            InitializeComponent();

            _isFirstLoad = true;
            _currentOrder = null;

            _currentPage = 1;
            _currentTotalPages = 0;
            _currentPageSize = FormConstants.Pagination.PageSizes.ElementAtOrDefault(0);
            _currentOrderStatus = new ComboBoxItem<OrderStatus>
            {
                Value = OrderStatus.New,
                Text = OrderStatus.New.GetDescription()
            };

            _orderService = ServiceFactory.GetService<OrderService>();

            cmbPageSize.Items.AddRange(FormConstants.Pagination.PageSizes.Cast<object>().ToArray());
        }

        private void frmSales_Load(object sender, EventArgs e)
        {
            if (_isFirstLoad)
            {
                ClearSalesFields();

                _isFirstLoad = false;

                var orderStatuses = new List<OrderStatus>
                {
                    OrderStatus.Released,
                    OrderStatus.PartiallyPaid,
                    OrderStatus.Paid,
                    OrderStatus.Refunded,
                };
                cmbStatus.ComboBox.DataSource = orderStatuses
                    .Select(e => new ComboBoxItem<OrderStatus>
                    {
                        Value = e,
                        Text = e.GetDescription()
                    }).ToList();
                cmbStatus.ComboBox.DisplayMember = "Text";
                cmbStatus.ComboBox.ValueMember = "Value";
                cmbStatus.SelectedIndex = 0;
            }

            RecordStatus.Orders.OnDataUpdated += ReloadData;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            var form = new frmPaySales(_currentOrder);
            if (form.ShowDialog() == DialogResult.OK)
            {
                Task.Run(() => AddPayment(form.PaymentDto));
            }
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
                ClearSalesFields();

                _currentOrder = (Order)dgvSales.SelectedRows[0]?.Tag;

                if (_currentOrder.Status == OrderStatus.Released || _currentOrder.Status == OrderStatus.PartiallyPaid)
                {
                    lblTerm.Visible = true;
                    lblOrderTerm.Visible = true;
                    lblLastPayment.Visible = true;
                    lblOrderLastPayment.Visible = true;

                    btnPay.Enabled = true;
                    btnVoid.Enabled = true;
                    btnAddPayment.Visible = true;
                }
                else if (_currentOrder.Status == OrderStatus.Paid)
                {
                    btnRefund.Enabled = true;
                    btnVoid.Enabled = true;
                }

                lblOrderNumber.Text = _currentOrder.GenerateOrderNumberString();
                lblStatus.Text = _currentOrder.Status.GetDescription();
                lblCustomer.Text = _currentOrder.Customer?.Name ?? "-";
                lblDateTime.Text = _currentOrder.Created.ConvertToLongDateString();

                // Summary
                txtReceivables.Text = _currentOrder.Total.ToAmountString();
                txtPayments.Text = _currentOrder.GenerateTotalPayment().ToAmountString();
                txtRefunds.Text = _currentOrder.GenerateTotalRefund().ToAmountString();
                txtBalance.Text = _currentOrder.GenerateBalance().ToAmountString();
                lblOrderTerm.Text = _currentOrder.PaymentTerm?.GetDescription() ?? "-";
                lblOrderLastPayment.Text = _currentOrder.GetLastPayment()?.ToString() ?? "-";

                // Items
                _currentOrder.Items.Where(item => item.Status == OrderItemStatus.Active)
                    .ToList().ForEach(item =>
                {
                    dgvOrderItems.Rows.Add(
                        item.ItemName,
                        item.UnitName,
                        item.Quantity,
                        item.Price.ToAmountString(),
                        item.Total.ToAmountString());
                });

                lblSubTotal.Text = _currentOrder.SubTotal.ToAmountString();
                lblDiscount.Text = _currentOrder.Discount.ToAmountString();
                lblTotalItems.Text = _currentOrder.Total.ToAmountString();

                // Payments
                _currentOrder.Payments?.ForEach(payment =>
                {
                    dgvPayments.Rows.Add(
                        payment.Created,
                        payment.Amount.ToAmountString(),
                        payment.Mode.GetDescription(),
                        payment.Reference,
                        payment.Remarks);
                });

                lblTotalPayments.Text = _currentOrder?.GenerateTotalPayment().ToAmountString() ?? "0.00";


                // Refunds
                _currentOrder.Refunds?.ForEach(refund =>
                {
                    var item = _currentOrder.Items.Where(i => i.Id == refund.OrderItemId).FirstOrDefault();
                    dgvRefunds.Rows.Add(
                        item.ItemName,
                        item.UnitName,
                        item.Quantity,
                        item.Price.ToAmountString(),
                        refund.Amount.ToAmountString(),
                        refund.Created,
                        refund.Mode.GetDescription(),
                        refund.Reference,
                        refund.Remarks);
                });

                lblTotalRefunds.Text = _currentOrder?.GenerateTotalRefund().ToAmountString() ?? "0.00";
            }
        }

        #region Search and Pagination

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentOrderStatus = (ComboBoxItem<OrderStatus>)cmbStatus.ComboBox.SelectedItem;

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

        private void ClearSalesFields()
        {
            lblOrderNumber.Text = string.Empty;
            lblStatus.Text = "-";
            lblDateTime.Text = string.Empty;
            lblCustomer.Text = "-";

            txtReceivables.Text = "0.00";
            txtPayments.Text = "0.00";
            txtBalance.Text = "0.00";
            lblOrderTerm.Text = "-";
            lblOrderLastPayment.Text = "-";

            dgvOrderItems.Rows.Clear();
            lblSubTotal.Text = "0.00";
            lblDiscount.Text = "0.00";
            lblTotalItems.Text = "0.00";

            dgvPayments.Rows.Clear();
            lblTotalPayments.Text = "0.00";

            dgvRefunds.Rows.Clear();
            lblTotalRefunds.Text = "0.00";

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
            row.Cells[1].Value = order.Released?.ConvertToLongDateString();
            row.Cells[2].Value = order.Status.GetDescription();
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

            var response = await _orderService.SearchOrders(_currentPage, _currentPageSize, 
                customerId: null, customerName: null, [_currentOrderStatus.Value]);

            this.Invoke((MethodInvoker)(() =>
            {
                _currentTotalPages = 0;

                dgvSales.Rows.Clear();
                ClearSalesFields();
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
                        row.CreateCells(dgvSales);
                        UpdateRowValues(order, row);
                        dgvSales.Rows.Add(row);
                    });
                }

                this.Text = frmText;
                EnableControls();
            }));
        }

        private async Task AddPayment(PaymentDto? paymentDto = null)
        {
            try
            {
                this.Invoke((MethodInvoker)(() =>
                {
                    EnableControls(false);
                }));

                var response = await _orderService.AddPayment(_currentOrder.Id, paymentDto);

                this.Invoke((MethodInvoker)(() =>
                {
                    if (response?.Status == OrderStatus.Paid)
                    {
                        MessageBox.Show($"{_currentOrder.GenerateOrderNumberString()} payment completed.", "Request Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        cmbStatus_SelectedIndexChanged(null, null);
                    }
                    else // Partially Paid
                    {
                        MessageBox.Show($"{_currentOrder.GenerateOrderNumberString()} new payment has been posted.", "Request Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (_currentOrder.Status == response.Status)
                        {
                            if (_currentOrder.Payments == null) _currentOrder.Payments = [];
                            _currentOrder.Payments.Add(new Payment
                            {
                                Amount = paymentDto.Amount,
                                Mode = paymentDto.Mode,
                                Reference = paymentDto.Reference,
                                Remarks = paymentDto.Remarks,
                                Created = DateTime.Now
                            });

                            dgvSales_SelectionChanged(null, null);
                        }
                        else // Reload
                        {
                            cmbStatus_SelectedIndexChanged(null, null);
                        }
                    }

                    EnableControls();
                }));
            }
            catch (HttpRequestException ex)
            {
                this.Invoke((MethodInvoker)(() =>
                {
                    MessageBox.Show(ex.Message, "Request Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    EnableControls();
                }));
            }
        }

        #endregion
    }
}
