using Point.Client.Main.Api;
using Point.Client.Main.Api.Dtos;
using Point.Client.Main.Api.Services;
using Point.Client.Main.Constants;
using Point.Client.Main.Globals;

namespace Point.Client.Main.Forms.Orders
{
    public partial class frmOrder : Form
    {
        private readonly OrderService _orderService;

        public frmOrder()
        {
            InitializeComponent();

            _orderService = ServiceFactory.GetService<OrderService>();
        }

        private void timerTimestamp_Tick(object sender, EventArgs e)
        {
            lblTimestamp.Text = DateTime.Now.ToString(FormConstants.Formats.Timestamp).ToUpper();
        }

        #region Editing

        private void lnkSelectCustomer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = FormFactory.GetFormDialog<frmCustomers>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                txtCustomer.Tag = form.SelectedCustomer;
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
            }
        }

        private void btnPaid_Click(object sender, EventArgs e)
        {
            if (dgvOrderItems.Rows.Count > 0)
            {

            }
        }

        private void btnSaveAsNew_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Helpers

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
        }

        private void UpdateTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvOrderItems.Rows) total += decimal.Parse(row.Cells["clmTotal"].Value.ToString());

            lblSubTotal.Text = total.ToString(FormConstants.Formats.Amount);
            lblTotal.Text = total.ToString(FormConstants.Formats.Amount);
        }

        #endregion

        private void dgvOrderItems_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dgvOrderItems.Columns[e.ColumnIndex].Name == FormConstants.DataGridView.Columns.Quantiy)
            {
                var value = e.FormattedValue?.ToString() ?? string.Empty;

                if (!int.TryParse(value, out int amount) || amount < 1)
                {
                    MessageBox.Show("Invalid Quantity value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
        }

        private void dgvOrderItems_CellValidated(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvOrderItems.Columns[e.ColumnIndex].Name == FormConstants.DataGridView.Columns.Quantiy)
            {
                var cell = dgvOrderItems.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (int.TryParse(cell.Value?.ToString(), out int value))
                {
                    cell.Value = value;
                }
            }
        }
    }
}
