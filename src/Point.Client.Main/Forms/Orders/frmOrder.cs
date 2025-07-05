using System;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
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
    public partial class frmOrder : Form
    {
        private bool _isFirstLoad;
        private Order? _currentOrder;

        private readonly OrderService _orderService;

        public frmOrder()
        {
            InitializeComponent();

            _isFirstLoad = true;
            _currentOrder = null;

            _orderService = ServiceFactory.GetService<OrderService>();
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            if (_isFirstLoad && _currentOrder == null)
            {
                _isFirstLoad = false;

                ClearFields();
            }
        }

        private void frmOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dgvOrderItems.Rows.Count == 0) return;

            if (MessageBox.Show("You are about to close the Order Form." +
                "\n\nAre you sure you wan to discard changes?", "Discard Changes",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ClearFields();
            }
            else
            {
                e.Cancel = true;
            }
        }

        #region Editing

        private void lnkSelectCustomer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = FormFactory.GetFormDialog<frmCustomers>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                txtCustomer.Tag = form.SelectedCustomer.Id;
                txtCustomer.Text = form.SelectedCustomer.Name;
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            var form = FormFactory.GetFormDialog<frmOrderItem>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                dgvOrderItems.Rows.Add(new DataGridViewRow());
                UpdateRowValues(form.SelectedOrderItem, dgvOrderItems.Rows[dgvOrderItems.Rows.Count - 1]);
                UpdateTotal();

                EnableButtons(true);
            }
        }

        private void dgvOrderItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0
                && dgvOrderItems.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                var orderItem = dgvOrderItems.Rows[e.RowIndex].Tag as OrderItemDto;
                if (MessageBox.Show($"Remove {orderItem.ItemName} from the list?", "Remove Item",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    dgvOrderItems.Rows.RemoveAt(e.RowIndex);
                    if (dgvOrderItems.Rows.Count == 0) EnableButtons(false);
                }
            }
        }

        private void dgvOrderItems_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            var value = e.FormattedValue?.ToString() ?? string.Empty;

            if (dgvOrderItems.Columns[e.ColumnIndex].Name == FormConstants.DataGridView.Columns.Quantiy)
            {
                if (!int.TryParse(value, out int quantity) || quantity < 1)
                {
                    MessageBox.Show("Invalid Quantity value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
            else if (dgvOrderItems.Columns[e.ColumnIndex].Name == FormConstants.DataGridView.Columns.Price)
            {
                if (!decimal.TryParse(value, out decimal price) || price < 1)
                {
                    MessageBox.Show("Invalid Priice value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
        }

        private void dgvOrderItems_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            var cell = dgvOrderItems.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (dgvOrderItems.Rows[e.RowIndex].Tag is OrderItemDto orderItem)
            {
                var itemUpdated = false;

                if (dgvOrderItems.Columns[e.ColumnIndex].Name == FormConstants.DataGridView.Columns.Quantiy)
                {
                    var quantity = int.Parse(cell.Value.ToString());
                    cell.Value = quantity;
                    orderItem.Quantity = quantity;
                    itemUpdated = true;
                }
                else if (dgvOrderItems.Columns[e.ColumnIndex].Name == FormConstants.DataGridView.Columns.Price)
                {
                    var price = decimal.Parse(cell.Value.ToString());
                    cell.Value = price.ToAmountString();
                    orderItem.Price = price;
                    itemUpdated = true;
                }

                if (itemUpdated)
                {
                    orderItem.Total = orderItem.Quantity * orderItem.Price;
                    dgvOrderItems.Rows[e.RowIndex].Cells["clmTotal"].Value = orderItem.Total.ToAmountString();
                    dgvOrderItems.Rows[e.RowIndex].Tag = orderItem;

                    UpdateTotal();
                }
            }
        }

        private void btnPaid_Click(object sender, EventArgs e)
        {
            if (dgvOrderItems.Rows.Count == 0) return;

            var form = new frmPayOrder();
            form.SetTotal(decimal.Parse(lblTotal.Text));
            if (form.ShowDialog() == DialogResult.OK)
            {
                EnableControls(false);
                Task.Run(() => CreateOrder(form.PaymentDto));
            }
        }

        private void btnSaveAsNew_Click(object sender, EventArgs e)
        {
            if (dgvOrderItems.Rows.Count == 0) return;

            if (MessageBox.Show("Post this Order?", "Post Order",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                EnableControls(false);

                if (_currentOrder == null)
                {
                    Task.Run(() => CreateOrder());
                }
                else
                {
                    Task.Run(() => UpdateOrder());
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You are about to clear all fields." +
                "\n\nAre you sure you wan to discard changes?", "Discard Changes",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ClearFields();
            }
        }

        #endregion

        #region Helpers

        private void ClearFields()
        {
            _currentOrder = null;

            lblOrderNumber.Text = string.Empty;
            lblStatus.Text = OrderStatus.New.ToString();
            lblDateTime.Text = DateTime.Now.ConvertToLongDateString();
            txtCustomer.Clear();
            txtCustomer.Tag = null;
            dgvOrderItems.Rows.Clear();
            lblSubTotal.Text = "0.00";
            lblDiscount.Text = "0.00";
            lblTotal.Text = "0.00";

            EnableButtons(false);
        }

        private void EnableButtons(bool enable = true)
        {
            btnPay.Enabled = enable;
            btnSaveAsNew.Enabled = enable;
        }

        private void EnableControls(bool enable = true)
        {
            this.Controls.OfType<Control>().ToList().ForEach(c => c.Enabled = enable);
        }

        private void UpdateRowValues(OrderItemDto orderItem, DataGridViewRow row)
        {
            row.Cells["clmRemove"].Value = "Remove";
            row.Cells["clmItem"].Value = orderItem.ItemName;
            row.Cells["clmUnit"].Value = orderItem.UnitName;
            row.Cells[FormConstants.DataGridView.Columns.Quantiy].Value = orderItem.Quantity;
            row.Cells["clmPrice"].Value = orderItem.Price.ToString(FormConstants.Formats.Amount);
            row.Cells["clmTotal"].Value = orderItem.Total.ToString(FormConstants.Formats.Amount);
            row.Tag = orderItem;
        }

        private void UpdateTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvOrderItems.Rows) total += ((OrderItemDto)row.Tag).Total;

            lblSubTotal.Text = total.ToString(FormConstants.Formats.Amount);
            lblTotal.Text = total.ToString(FormConstants.Formats.Amount);
        }

        public void ShowForEdit(Order order)
        {
            ClearFields();

            _currentOrder = order;

            lblOrderNumber.Text = order.Number.ToOrderNumberString();
            lblDateTime.Text = order.Created.ConvertToLongDateString();

            txtCustomer.Tag = order.Customer?.Id;
            txtCustomer.Text = order.Customer?.Name;

            foreach (var orderItem in order.Items)
            {
                dgvOrderItems.Rows.Add(new DataGridViewRow());
                UpdateRowValues(orderItem.ToOrderItemDto(), dgvOrderItems.Rows[dgvOrderItems.Rows.Count - 1]);
                UpdateTotal();
            }

            btnPay.Enabled = true;

            this.Show();
        }

        #endregion

        #region Services

        private async void CreateOrder(PaymentDto? paymentDto = null)
        {
            try
            {
                var items = new List<OrderItemDto>();
                foreach (DataGridViewRow row in dgvOrderItems.Rows) items.Add(row.Tag.Parse<OrderItemDto>());

                var orderDto = new OrderDto
                {
                    CustomerId = !txtCustomer.Tag.IsNull() ? int.Parse(txtCustomer.Tag.ToString()) : null,
                    SubTotal = decimal.Parse(lblSubTotal.Text),
                    Discount = decimal.Parse(lblDiscount.Text),
                    Total = decimal.Parse(lblTotal.Text),
                    Items = items,
                    PaymentTerm = null,
                    Payment = paymentDto
                };

                var response = await _orderService.CreateOrder(orderDto);

                this.Invoke((MethodInvoker)(() =>
                {
                    var status = OrderStatus.Paid;
                    if (paymentDto == null) status = OrderStatus.New;

                    MessageBox.Show($"'{status.ToString()}' Order has been posted.", "Request Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearFields();

                    EnableControls();
                }));

                RecordStatus.Orders.Updated();
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

        private async void UpdateOrder()
        {
            try
            {
                var items = new List<OrderItemDto>();
                foreach (DataGridViewRow row in dgvOrderItems.Rows) items.Add(row.Tag.Parse<OrderItemDto>());

                var orderDto = new OrderDto
                {
                    CustomerId = !txtCustomer.Tag.IsNull() ? int.Parse(txtCustomer.Tag.ToString()) : null,
                    SubTotal = decimal.Parse(lblSubTotal.Text),
                    Discount = decimal.Parse(lblDiscount.Text),
                    Total = decimal.Parse(lblTotal.Text),
                    Items = items
                };
                
                await _orderService.UpdateOrder(_currentOrder.Id, orderDto);

                this.Invoke((MethodInvoker)(() =>
                {
                    MessageBox.Show($"{_currentOrder.Number.ToOrderNumberString()} updates has been posted.", "Request Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearFields();

                    EnableControls();
                }));

                RecordStatus.Orders.Updated();
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
