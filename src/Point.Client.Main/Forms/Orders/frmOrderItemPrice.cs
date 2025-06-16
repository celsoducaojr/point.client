using Point.Client.Main.Api.Entities;
using Point.Client.Main.Constants;

namespace Point.Client.Main.Forms.Orders
{
    public partial class frmOrderItemPrice : Form
    {
        public decimal SelectedAmount { get; private set; }

        public frmOrderItemPrice()
        {
            InitializeComponent();
        }

        private void frmOrderItemPrice_Load(object sender, EventArgs e)
        {
            cmbPrice.Focus();
            numQuantity.Value = 1;
        }

        private void cmbPrice_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPrice.Text = ((decimal)cmbPrice.SelectedValue).ToString(FormConstants.Formats.Amount);
        }

        private void txtPrice_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var value = txtPrice.Text;
            if (!string.IsNullOrWhiteSpace(value) && (!decimal.TryParse(value, out decimal amount) || amount <= 0))
            {
                MessageBox.Show("Invalid Amount value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void txtPrice_Validated(object sender, EventArgs e)
        {
            var value = txtPrice.Text;
            txtPrice.Text = decimal.Parse(txtPrice.Text).ToString(FormConstants.Formats.Amount);
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            SelectedAmount = decimal.Parse(txtPrice.Text);
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public void SetItemDetails(Item item, ItemUnit itemUnit)
        {
            lblItem.Text = item.Name;
            lblUnit.Text = $"Unit '{itemUnit.Unit.Name}'";
            lblCapitalCode.Text = $"Capital Code '{itemUnit.CostPriceCode}'";

            var prices = itemUnit.Prices?
                .Where(price => price.Amount > 0)
                .Select(price => new { price.PriceType.Name, price.PriceType.DisplayIndex, price.Amount })
                .OrderBy(price => price.DisplayIndex)
                .ToList();

            cmbPrice.SelectedIndexChanged -= cmbPrice_SelectedIndexChanged;

            cmbPrice.DataSource = prices;
            cmbPrice.DisplayMember = "Name";
            cmbPrice.ValueMember = "Amount";

            cmbPrice.SelectedIndexChanged += cmbPrice_SelectedIndexChanged;
            cmbPrice_SelectedIndexChanged(null, null);
        }
    }
}
