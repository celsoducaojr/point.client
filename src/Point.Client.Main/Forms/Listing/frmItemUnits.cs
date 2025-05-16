using Point.Client.Main.Api;
using Point.Client.Main.Api.Services;
using Point.Client.Main.Globals;

namespace Point.Client.Main.Listing
{
    public partial class frmItemUnits : Form
    {
        private bool _isFirstLoad;

        private readonly PriceTypeService _priceTypeService;

        public frmItemUnits()
        {
            InitializeComponent();

            _isFirstLoad = true;

            _priceTypeService = ServiceFactory.GetService<PriceTypeService>();
        }

        private void frmItemUnits_Load(object sender, EventArgs e)
        {
            EnableControls(false);

            if (_isFirstLoad)
            {
                _isFirstLoad = false;

                Task.Run(() => LoadPriceTypes());
            }

            EnableControls();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormFactory.GetForm<frmItems>().ShowForSelection();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

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
                    dgvItemUnits.Columns.Add(column);
                });

                this.Text = frmText;
                EnableControls();
            }));
        }


        #endregion

       
    }
}
