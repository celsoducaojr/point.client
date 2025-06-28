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
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtStatus.Text.Trim().Equals(_newOrderStatusAction, StringComparison.OrdinalIgnoreCase))
            {
                this.Controls.OfType<Control>().ToList().ForEach(c => c.Enabled = false);
                UpdateOrderStatus(_order.Id, _newOrderStatus);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private async void UpdateOrderStatus(int id, OrderStatus newStatus)
        {
            try
            {
                await _orderService.UpdateOrderStatus(id, newStatus);

                this.Invoke((MethodInvoker)(() =>
                {
                    MessageBox.Show($"Order has been {newStatus}.", "Request Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _order.Status = newStatus;

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
