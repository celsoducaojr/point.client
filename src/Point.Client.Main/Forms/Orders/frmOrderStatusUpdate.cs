using Point.Client.Main.Api;
using Point.Client.Main.Api.Entities.Orders;
using Point.Client.Main.Api.Enums;
using Point.Client.Main.Api.Extensions;
using Point.Client.Main.Api.Services;
using Point.Client.Main.Constants;
using Point.Client.Main.Globals;

namespace Point.Client.Main.Forms.Orders
{
    public partial class frmOrderStatusUpdate : Form
    {
        private Order _order;
        private OrderStatus _newOrderStatus;
        private string _newOrderStatusAction;

        private readonly OrderService _orderService;

        public frmOrderStatusUpdate(Order order, OrderStatus newOrderStatus)
        {
            InitializeComponent();

            _order = order;
            _newOrderStatus = newOrderStatus;
            _newOrderStatusAction = FormConstants.Order.StatusActionDictionary[newOrderStatus];

            _orderService = ServiceFactory.GetService<OrderService>();
        }

        private void frmOrderStatusUpdate_Load(object sender, EventArgs e)
        {
            lblOrderNumber.Text = _order.Number.ToOrderNumberString();
            lblTotal.Text = _order.Total.ToAmountString();
            lblStatus.Text = string.Format(FormConstants.Order.ChangeStatusLabel, _newOrderStatusAction.ToUpper());
            btnUpdate.Text = string.Format(FormConstants.Order.ChangeStatuslButtonLabel, _newOrderStatusAction.ToUpper());

            if (_newOrderStatus == OrderStatus.Released)
            {
                lblPaymentTerm.Visible = true;
                cmbPaymentTerm.Visible = true;

                cmbPaymentTerm.DataSource = Enum.GetValues(typeof(PaymentTerm))
                    .Cast<PaymentTerm>()
                    .Select(e => new
                    {
                        Value = e,
                        Text = e.GetDescription()
                    }).ToList();
                cmbPaymentTerm.DisplayMember = "Text";
                cmbPaymentTerm.ValueMember = "Value";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtStatus.Text.Trim().Equals(_newOrderStatusAction, StringComparison.OrdinalIgnoreCase))
            {
                this.Controls.OfType<Control>().ToList().ForEach(c => c.Enabled = false);
                UpdateOrderStatus(_order.Id);
            }
            else 
            {
                MessageBox.Show(lblStatus.Text, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private async void UpdateOrderStatus(int id)
        {
            try
            {
                if (_newOrderStatus == OrderStatus.Released)
                {
                    await _orderService.ReleaseOrder(id, (PaymentTerm)cmbPaymentTerm.SelectedValue);
                }
                else if (_newOrderStatus == OrderStatus.Cancelled)
                {
                    await _orderService.CancelOrder(id);
                }

                this.Invoke((MethodInvoker)(() =>
                {
                    MessageBox.Show($"Order has been {_newOrderStatus}.", "Request Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _order.Status = _newOrderStatus;

                    this.DialogResult = DialogResult.OK;
                }));

                RecordStatus.Orders.Updated();
            }
            catch (HttpRequestException ex)
            {
                this.Invoke((MethodInvoker)(() =>
                {
                    MessageBox.Show(ex.Message, "Request Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    this.Controls.OfType<Control>().ToList().ForEach(c => c.Enabled = true);
                }));
            }
        }
    }
}
