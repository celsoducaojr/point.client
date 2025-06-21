using System.Data;
using Point.Client.Main.Api.Dtos;
using Point.Client.Main.Api.Enums;
using Point.Client.Main.Api.Extensions;

namespace Point.Client.Main.Forms.Orders
{
    public partial class frmPayOrder : Form
    {
        public PaymentDto? PaymentDto { get; private set; }
        

        public frmPayOrder()
        {
            InitializeComponent();

            PaymentDto = null;
        }

        private void frmPayOrder_Load(object sender, EventArgs e)
        {
            cmbMode.DataSource = Enum.GetValues(typeof(PaymentMode))
                .Cast<PaymentMode>()
                .Select(s => new { Value = s, Text = s.ToString() })
                .ToList();
            cmbMode.DisplayMember = "Text";
            cmbMode.ValueMember = "Value";

            txtTendered.Focus();
        }

        private void btnPaid_Click(object sender, EventArgs e)
        {
            if (txtTendered.Text.Trim().Equals("PAY", StringComparison.OrdinalIgnoreCase))
            {
                PaymentDto = new PaymentDto
                {

                };

                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public void SetTotal(decimal total)
        {
            lblTotal.Text = total.ToAmountString();
        }
    }
}
