using Point.Client.Main.Api;
using Point.Client.Main.Api.Services;

namespace Point.Client.Main.Listing
{
    public partial class frmProducts : Form
    {
        private bool _isFirstLoad;

        private readonly PriceTypeService _priceTypeService;

        public frmProducts()
        {
            InitializeComponent();

            _isFirstLoad = true;

            _priceTypeService = ServiceLocator.GetService<PriceTypeService>();
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            if (_isFirstLoad)
            {
                _isFirstLoad = false;

                Task.Run(() => LoadPriceTypes());
            }
        }

        #region Helpers

        private void EnableControls(bool enable = true)
        {
            this.Controls.OfType<Control>().ToList().ForEach(c => c.Enabled = enable);
        }

        #endregion

        #region Services

        private async void LoadPriceTypes()
        {
            var frmText = this.Text;
            this.Invoke((MethodInvoker)(() =>
            {
                EnableControls(false);

                this.Text = "Loading Price Types Columns...";
            }));

            var response = await _priceTypeService.GetPricesTypes();

            this.Invoke((MethodInvoker)(() =>
            {
                DataGridViewColumn column;
                response?.ForEach(priceType =>
                {
                    column = new DataGridViewColumn()
                    {
                        Name = priceType.Id.ToString(),
                        HeaderText = priceType.Name
                    };
                    dgvProducts.Columns.Add(column);
                });

                this.Text = frmText;
                EnableControls();
            }));
        }


        #endregion

       
    }
}
