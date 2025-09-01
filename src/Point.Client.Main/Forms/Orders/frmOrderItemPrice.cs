using Point.Client.Main.Api.Entities;
using Point.Client.Main.Api.Extensions;
using Point.Client.Main.Constants;

namespace Point.Client.Main.Forms.Orders
{
    public partial class frmOrderItemPrice : Form
    {
        public int SelectedQuantity { get; private set; }
        public decimal SelectedPrice { get; private set; }
        public decimal SelectedTotal { get; private set; }

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
            txtPrice.Text = ((decimal)cmbPrice.SelectedValue).ToAmountString();
            lblTotal.Text = GenerateTotalPrice();
        }

        private void cmbPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnAddItem.Focus();

        }
     
        private void txtPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnAddItem.Focus();
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
            txtPrice.Text = decimal.Parse(txtPrice.Text).ToAmountString();
            lblTotal.Text = GenerateTotalPrice();
        }

        private void numQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnAddItem.Focus();

        }

        private void numQuantity_ValueChanged(object sender, EventArgs e)
        {
            lblTotal.Text = GenerateTotalPrice();
        }

        private void numQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                e.Handled = true; // block decimal point
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            SelectedQuantity = (int)numQuantity.Value;
            SelectedPrice = decimal.Parse(txtPrice.Text);
            SelectedTotal = decimal.Parse(GenerateTotalPrice());
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        public void SetItemDetails(Item item, ItemUnit itemUnit)
        {
            lblItem.Text = item.Name;
            lblUnit.Text = itemUnit.Unit.Name;
            lblCapitalCode.Text = itemUnit.CostPriceCode;

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

        private string GenerateTotalPrice()
        {
            return (decimal.Parse(txtPrice.Text) * numQuantity.Value).ToAmountString();
        }
    }
}
