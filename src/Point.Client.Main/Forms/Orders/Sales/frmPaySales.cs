using Point.Client.Main.Api.Dtos;
using Point.Client.Main.Api.Entities.Orders;
using Point.Client.Main.Api.Enums;
using Point.Client.Main.Api.Extensions;
using Point.Client.Main.Constants;
using Point.Client.Main.Globals.Common.Enums;

namespace Point.Client.Main.Forms.Orders.Sales
{
    public partial class frmPaySales : Form
    {
        public PaymentDto? PaymentDto { get; private set; }

        private Order _order;

        public frmPaySales(Order order)
        {
            InitializeComponent();

            _order = order;

            lblOrderNumber.Text = order.GenerateOrderNumberString();
            txtReceivables.Text = order.Total.ToAmountString();
            txtPayments.Text = order.GenerateTotalPayment().ToAmountString();
            txtBalance.Text = order.GenerateBalance().ToAmountString();
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            cmbPaymentType.DataSource = Enum.GetValues(typeof(PaymentType))
                .Cast<PaymentType>()
                .Select(s => new
                {
                    Value = s,
                    Text = s.GetDescription()
                })
                .ToList();
            cmbPaymentType.DisplayMember = "Text";
            cmbPaymentType.ValueMember = "Value";

            cmbMode.DataSource = Enum.GetValues(typeof(PaymentMode))
                .Cast<PaymentMode>()
                .Select(s => new
                {
                    Value = s,
                    Text = s.GetDescription()
                })
                .ToList();
            cmbMode.DisplayMember = "Text";
            cmbMode.ValueMember = "Value";

            txtAmount.Focus();
        }

        private void txtAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnPay.Focus();
        }

        private void txtAmount_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var value = txtAmount.Text;
            if (!string.IsNullOrWhiteSpace(value) && (!decimal.TryParse(value, out decimal amount) || amount < 0))
            {
                MessageBox.Show("Invalid Amount value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void txtAmount_Validated(object sender, EventArgs e)
        {
            var tendered = decimal.Parse(txtAmount.Text);
            txtAmount.Text = tendered.ToString(FormConstants.Formats.Amount);
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            var paymentType = (PaymentType)cmbPaymentType.SelectedValue;
            var payment = decimal.Parse(txtAmount.Text);
            var balance = _order.GenerateBalance();

            if (payment == 0
                || (paymentType == PaymentType.PartialPayment && payment >= balance)
                || (paymentType == PaymentType.FullPayment && payment != balance))
            {
                MessageBox.Show($"Invalid {paymentType.GetDescription()} Amount value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            PaymentDto = new PaymentDto
            {
                Amount = payment,
                Mode = (PaymentMode)cmbMode.SelectedValue,
                Reference = !string.IsNullOrWhiteSpace(txtReference.Text) ? txtReference.Text : null,
                Remarks = !string.IsNullOrWhiteSpace(txtRemarks.Text) ? txtRemarks.Text : null,
            };

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;    
        }
    }
}
