using Point.Client.Main.Api.Dtos;
using Point.Client.Main.Api.Enums;
using Point.Client.Main.Api.Extensions;
using System.Data;

namespace Point.Client.Main.Forms.Orders
{
    public partial class frmPayOrder : Form
    {
        public PaymentDto? PaymentDto { get; private set; }

        public frmPayOrder(decimal total)
        {
            InitializeComponent();

            PaymentDto = null;

            lblTotal.Text = total.ToAmountString();
        }

        private void frmPayOrder_Load(object sender, EventArgs e)
        {
            cmbMode.DataSource = Enum.GetValues(typeof(PaymentMode))
                .Cast<PaymentMode>()
                .Select(s => new 
                { 
                    Value = s, 
                    Text = s.GetDescription() })
                .ToList();
            cmbMode.DisplayMember = "Text";
            cmbMode.ValueMember = "Value";

            txtTendered.Focus();
        }

        private void txtTendered_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnPay.Focus();
        }

        private void txtTendered_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var value = txtTendered.Text;
            if (!string.IsNullOrWhiteSpace(value) && (!decimal.TryParse(value, out decimal amount) || amount < 0))
            {
                MessageBox.Show("Invalid Payment Amount value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void txtTendered_Validated(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtTendered.Text, out decimal tendered))
            {
                txtTendered.Text = tendered.ToAmountString();
            }
            else
            {
                txtTendered.Text = "0.00";
            }

                var change = (tendered - decimal.Parse(lblTotal.Text));
            if (change >= 0)
                lblChange.Text = change.ToAmountString();
            else
                lblChange.Text = "0.00";
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            var total = decimal.Parse(lblTotal.Text);
            var tendered = decimal.Parse(txtTendered.Text);
            if (total <= tendered)
            {
                PaymentDto = new PaymentDto
                {
                    Amount = total,
                    Mode = (PaymentMode)cmbMode.SelectedValue,
                    Reference = !string.IsNullOrWhiteSpace(txtReference.Text) ? txtReference.Text : null,
                    Remarks = !string.IsNullOrWhiteSpace(txtRemarks.Text) ? txtRemarks.Text : null,
                };

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Invalid Payment Amount value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
