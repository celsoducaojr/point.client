using Point.Client.Main.Api;
using Point.Client.Main.Api.Dtos;
using Point.Client.Main.Api.Entities;
using Point.Client.Main.Api.Services;
using Point.Client.Main.Constants;
using Point.Client.Main.Globals;

namespace Point.Client.Main.Forms.Orders
{
    public partial class frmOrderItem : Form
    {
        public OrderItemDto SelectedOrderItem { get; private set; }

        private bool _isFirstLoad;
        private bool _isActive;

        private SearchItemCriteriaDto? _searchItemDto;
        private List<PriceType>? _currentPriceTypes;

        private DateTime? _listingLastUpdate;

        private readonly ItemService _itemService;
        private readonly PriceTypeService _priceTypeService;

        public frmOrderItem()
        {
            InitializeComponent();

            _isFirstLoad = true;
            _isActive = false;

            _searchItemDto = null;
            _currentPriceTypes = null;

            _listingLastUpdate = RecordStatus.Domain.Listing.LastUpdate;
            RecordStatus.Domain.Listing.OnDataUpdated += ReloadData;

            _itemService = ServiceFactory.GetService<ItemService>();
            _priceTypeService = ServiceFactory.GetService<PriceTypeService>();
        }

        private async void frmOrderItem_Activated(object sender, EventArgs e)
        {
            if (_isFirstLoad)
            {
                _isFirstLoad = false;

                await LoadPriceTypes();

                await SearchItemsWithUnits();
            }
            else if (_listingLastUpdate != RecordStatus.Domain.Listing.LastUpdate)
            {
                await SearchItemsWithUnits();
            }

            txtItem.Focus();

            _isActive = true;
        }

        private void frmOrderItem_Deactivate(object sender, EventArgs e)
        {
            _isActive = false;
        }

        #region Search

        private async void ReloadData()
        {
            if (_isActive)
            {
                await SearchItemsWithUnits();
            }
        }

        private async void txtItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(txtItem.Text))
            {
                _searchItemDto = new SearchItemCriteriaDto
                {
                    Name = txtItem.Text
                };
                await SearchItemsWithUnits();
            }
        }

        private void dgvItemUnits_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvItemUnits.CurrentRow != null)
            {
                OpenPriceSelectionDialog();
            }
        }

        private void dgvItemUnits_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && dgvItemUnits.CurrentRow != null)
            {
                e.Handled = true;

                OpenPriceSelectionDialog();
            }
        }

#endregion

        #region Helpers

        private void OpenPriceSelectionDialog()
        {
            var selectedRow = dgvItemUnits.CurrentRow;

            var item = (Item)selectedRow.Cells["clmItem"].Tag;
            var itemUnit = (ItemUnit)selectedRow.Cells["clmUnit"].Tag;

            if (itemUnit.Prices?.Where(price => price.Amount > 0).Any() == true)
            {
                var form = new frmOrderItemPrice();
                form.SetItemDetails(item, itemUnit);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    SelectedOrderItem = new OrderItemDto
                    {
                        ItemUnitId = itemUnit.Id,
                        ItemName = item.Name,
                        UnitId = itemUnit.Unit.Id,
                        UnitName = itemUnit.Unit.Name,
                        Quantity = form.SelectedQuantity,
                        Price = form.SelectedPrice,
                        Discount = 0,
                        Total = form.SelectedTotal
                    };

                    txtItem.Focus();
                    txtItem.SelectAll();

                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                MessageBox.Show("The Item-unit selected has no valid Prices.", "Invalid Item selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void EnableFormLoading(bool enable = true, string? message = null)
        {
            this.ControlBox = !enable;
            this.Controls.OfType<Control>().ToList().ForEach(c => c.Enabled = !enable);

            if (enable)
            {
                this.Invoke((MethodInvoker)(() =>
                {
                    this.UseWaitCursor = true;
                    FormFactory.ShowLoadingForm(this, message);
                }));
            }
            else
            {
                this.Invoke((MethodInvoker)(() =>
                {
                    this.UseWaitCursor = false;
                    FormFactory.CloseLoadingForm(this);
                }));
            }
        }

        private void UpdateRowValues(Item item, ItemUnit itemUnit, DataGridViewRow row)
        {
            row.Cells["clmItem"].Value = item.Name;
            row.Cells["clmItem"].Tag = item;
            row.Cells["clmCategory"].Value = item.Category?.Name;
            row.Cells["clmUnit"].Value = itemUnit.Unit?.Name;
            row.Cells["clmUnit"].Tag = itemUnit;
            row.Cells["clmCapitalCode"].Value = itemUnit.CostPriceCode;

            _currentPriceTypes?.ForEach(type =>
            {
                var amount = itemUnit.Prices?
                .Where(price => price.PriceType.Id == type.Id)
                .Select(price => price.Amount).FirstOrDefault() ?? 0;

                row.Cells[type.Id.ToString()].Value = amount;
            });
        }

        #endregion

        #region Services

        private async Task SearchItemsWithUnits()
        {
            _listingLastUpdate = RecordStatus.Domain.Listing.LastUpdate;

            this.Invoke((MethodInvoker)(() =>
            {
                EnableFormLoading(true, "Loading Items-units...");
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
                        item.Units?.ForEach(itemUnit =>
                        {
                            dgvItemUnits.Rows.Add(new DataGridViewRow());
                            UpdateRowValues(item, itemUnit, dgvItemUnits.Rows[dgvItemUnits.Rows.Count - 1]);
                        });
                    });
                }

                EnableFormLoading(false);
            }));
        }

        private async Task LoadPriceTypes()
        {
            this.Invoke((MethodInvoker)(() =>
            {
                EnableFormLoading(true, "Loading Price Types Columns...");
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
                    column.Tag = FormConstants.DataGridView.Tags.Price;
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    column.DefaultCellStyle.Format = "N2";
                    column.Width = 175;
                    dgvItemUnits.Columns.Add(column);
                });

                EnableFormLoading(false);
            }));
        }

        #endregion
    }
}
