using System.Windows.Forms;
using Point.Client.Main.Api;
using Point.Client.Main.Api.Dtos;
using Point.Client.Main.Api.Entities;
using Point.Client.Main.Api.Services;
using Point.Client.Main.Constants;
using static Point.Client.Main.Globals.RecordStatus;

namespace Point.Client.Main.Forms.Orders
{
    public partial class frmOrderItem : Form
    {
        private bool _isFirstLoad;

        private SearchItemCriteriaDto? _searchItemDto;
        private List<PriceType>? _currentPriceTypes;

        private DateTime? _categoryLastUpdate;
        private DateTime? _tagLastUpdate;
        private DateTime? _unitLastUpdate;
        private DateTime? _itemLastUpdate;

        private readonly ItemService _itemService;
        private readonly ItemUnitService _itemUnitService;
        private readonly PriceTypeService _priceTypeService;

        public frmOrderItem()
        {
            InitializeComponent();

            _isFirstLoad = true;

            _searchItemDto = null;
            _currentPriceTypes = null;

            _categoryLastUpdate = null;
            _tagLastUpdate = null;
            _unitLastUpdate = null;
            _itemLastUpdate = null;

            _itemService = ServiceFactory.GetService<ItemService>();
            _itemUnitService = ServiceFactory.GetService<ItemUnitService>();
            _priceTypeService = ServiceFactory.GetService<PriceTypeService>();
        }

        private async void frmOrderItem_Load(object sender, EventArgs e)
        {
            EnableControls(false);

            if (_isFirstLoad)
            {
                _isFirstLoad = false;

                await Task.Run(LoadPriceTypes);

                await SearchItemsWithUnits();
            }
            else if (_categoryLastUpdate != Categories.LastUpdate
                || _tagLastUpdate != Tags.LastUpdate
                || _unitLastUpdate != Units.LastUpdate
                || _itemLastUpdate != Items.LastUpdate)
            {
                _categoryLastUpdate = Categories.LastUpdate;
                _tagLastUpdate = Tags.LastUpdate;
                _unitLastUpdate = Units.LastUpdate;
                _itemLastUpdate = Items.LastUpdate;

                await SearchItemsWithUnits();
            }

            EnableControls();
        }

        #region Helpers

        private void EnableControls(bool enable = true)
        {
            this.Controls.OfType<Control>().ToList().ForEach(c => c.Enabled = enable);
        }

        private void UpdateRowValues(Item item, ItemUnit unit, DataGridViewRow row)
        {
            row.Cells["clmItem"].Value = item.Name;
            row.Cells["clmCategory"].Value = item.Category?.Name;
            row.Cells["clmUnit"].Value = unit.Unit?.Name;
            row.Cells["clmCapitalCode"].Value = unit.CostPriceCode;

            _currentPriceTypes?.ForEach(type =>
            {
                var amount = unit.Prices?
                .Where(price => price.PriceType.Id == type.Id)
                .Select(price => price.Amount).FirstOrDefault() ?? 0;

                row.Cells[type.Id.ToString()].Value = amount;
            });

            row.Tag = unit.Id;
        }

        #endregion

        #region Services

        private async Task SearchItemsWithUnits()
        {
            var frmText = this.Text;
            this.Invoke((MethodInvoker)(() =>
            {
                EnableControls(false);

                this.Text = "Loading Items Units...";
            }));

            var response = await _itemService.SearchItemsWithUnits(1, 100,
                _searchItemDto?.Name);

            this.Invoke((MethodInvoker)(() =>
            {
                dgvItemUnits.Rows.Clear();

                if (response?.TotalCount > 0)
                {
                    response?.Data?.ForEach(item =>
                    {
                        item.Units?.ForEach(unit =>
                        {
                            dgvItemUnits.Rows.Add(new DataGridViewRow());
                            UpdateRowValues(item, unit, dgvItemUnits.Rows[dgvItemUnits.Rows.Count - 1]);
                        });
                    });
                }

                this.Text = frmText;
                EnableControls();
            }));
        }

        private async Task LoadPriceTypes()
        {
            var frmText = this.Text;
            this.Invoke((MethodInvoker)(() =>
            {
                EnableControls(false);

                this.Text = "Loading Price Types Columns...";
            }));

            _currentPriceTypes = await _priceTypeService.GetPricesTypes();

            this.Invoke((MethodInvoker)(() =>
            {
                _currentPriceTypes?.ForEach(priceType =>
                {
                    var column = new DataGridViewTextBoxColumn()
                    {
                        Name = priceType.Id.ToString(),
                        HeaderText = priceType.Name,
                    };
                    column.Tag = FormConstants.DataGridViewColumn.PriceTag;
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    column.DefaultCellStyle.Format = FormConstants.Formats.Amount;
                    dgvItemUnits.Columns.Add(column);
                });

                this.Text = frmText;
                EnableControls();
            }));
        }

        #endregion

        private void dgvItemUnits_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;

                if (dgvItemUnits.CurrentRow != null)
                {
                    var selectedRow = dgvItemUnits.CurrentRow;

                    new frmOrderItemPrice().ShowDialog();
                }
            }
        }
    }
}
