using Point.Client.Main.Api;
using Point.Client.Main.Api.Dtos;
using Point.Client.Main.Api.Entities;
using Point.Client.Main.Api.Services;

namespace Point.Client.Main.Listing
{
    public partial class frmItemUnit : Form
    {
        private Item _item;

        private bool _isFirstLoad;

        private readonly UnitService _unitService;
        private readonly ItemUnitService _itemUnitService;

        public frmItemUnit()
        {
            InitializeComponent();

            _isFirstLoad = true;

            _unitService = ServiceFactory.GetService<UnitService>();
            _itemUnitService = ServiceFactory.GetService<ItemUnitService>();
        }

        #region Main

        private void frmItemUnit_Load(object sender, EventArgs e)
        {
            if (_isFirstLoad)
            {
                _isFirstLoad = false;

                Task.Run(() => LoadUnits());
            }
        }

        public void ShowForSelection(Item item)
        {
            _item = item;

            lblItem.Text = _item.Name;

            this.ShowDialog();
        }

        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbUnit.SelectedItem == null)
            {
                MessageBox.Show("Please select a valid Unit.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbUnit.Focus();
                return;
            }

            var itemUnit = new ItemUnitDto 
            {
                ItemId =_item.Id,
                UnitId = (int)cmbUnit.SelectedValue
            };

            EnableEditing(false);

            Task.Run(() => CreateItemUnit(itemUnit));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cmbUnit.Text = null;

            this.Close();
        }

        #region Helpers

        private void EnableEditing(bool enable = true)
        {
            cmbUnit.Enabled = enable;
            btnSave.Enabled = enable;
            btnCancel.Enabled = enable;

            cmbUnit.Focus();
        }

        #endregion


        #region Services

        private async void CreateItemUnit(ItemUnitDto itemUnit)
        {
            try
            {
                var response = await _itemUnitService.CreateItemUnit(itemUnit);

                this.Invoke((MethodInvoker)(() =>
                {
                    MessageBox.Show("New Item-Unit has been added.", "Request Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    EnableEditing();

                    cmbUnit.Text = null;

                    this.Close();
                }));
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

        private async void LoadUnits()
        {
            var frmText = this.Text;
            this.Invoke((MethodInvoker)(() =>
            {
                cmbUnit.SelectedItem = null;
                EnableEditing(false);

                this.Text = "Loading Units...";
            }));

            var response = await _unitService.GetUnits();

            this.Invoke((MethodInvoker)(() =>
            {
                response?.ForEach(unit =>
                {
                    cmbUnit.DataSource = response;
                    cmbUnit.DisplayMember = "Name";
                    cmbUnit.ValueMember = "Id";
                });
                cmbUnit.Text = null;

                this.Text = frmText;
                EnableEditing();
            }));
        }

        #endregion

    }
}
