using Point.Client.Main.Api;
using Point.Client.Main.Api.Dtos;
using Point.Client.Main.Api.Enums;
using Point.Client.Main.Api.Services;
using Point.Client.Main.Globals;

namespace Point.Client.Main.Forms.Stocks
{
    public partial class frmUpdateStock : Form
    {
        public int QuantityChanged { get; private set; }
        public string? Remarks { get; private set; }

        private readonly StockUpdateType _stockUpdateType;
        private readonly int _itemUnitId;

        private readonly StockService _stockService;

        public frmUpdateStock(StockUpdateType stockUpdateType, string itemName, string unitName, int itemUnitId)
        {
            InitializeComponent();

            _stockUpdateType = stockUpdateType;
            _itemUnitId = itemUnitId;

            _stockService = ServiceFactory.GetService<StockService>();

            txtItem.Text = itemName;
            txtUnit.Text = unitName;

            if (stockUpdateType == StockUpdateType.Addition)
            {
                this.Text = "Add Stock";
                lblQuantity.Text = "Quantity to Add:";
                btnUpdateStock.Text = "Add Stock";
            }
            else
            {
                this.Text = "Remove Stock";
                lblQuantity.Text = "Quantity to Remove:";
                btnUpdateStock.Text = "Remove Stock";
            }
        }

        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            EnableEditing(false);

            Task.Run(() => UpdateStock(new StockDto(_stockUpdateType, (int)numQuantity.Value, 
                !string.IsNullOrEmpty(txtRemarks.Text.Trim()) ? txtRemarks.Text : null)));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        #region Helpers

        private void EnableEditing(bool enable = true)
        {
            numQuantity.Enabled = enable;
            txtRemarks.Enabled = enable;

            EnableButtons(enable);
        }
        private void EnableButtons(bool enable = true)
        {
            this.Controls.OfType<Button>().ToList().ForEach(c => c.Enabled = enable);
        }

        #endregion

        #region Services

        private async void UpdateStock(StockDto stockDto)
        {
            try
            {
                await _stockService.UpdateStocks(_itemUnitId, stockDto);

                this.Invoke((MethodInvoker)(() =>
                {
                    MessageBox.Show("Stock has been updated.", "Request Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    QuantityChanged = stockDto.Quantity;
                    Remarks = stockDto.Remarks;
                    this.DialogResult = DialogResult.OK;
                }));

                RecordStatus.Stocks.Updated();
            }
            catch (HttpRequestException ex)
            {
                this.Invoke((MethodInvoker)(() =>
                {
                    MessageBox.Show(ex.Message, "Request Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    EnableEditing();
                }));
            }
        }

        #endregion 
    }
}
