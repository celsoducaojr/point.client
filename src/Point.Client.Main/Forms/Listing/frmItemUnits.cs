using Point.Client.Main.Api;
using Point.Client.Main.Api.Dtos;
using Point.Client.Main.Api.Entities;
using Point.Client.Main.Api.Services;
using Point.Client.Main.Constants;
using Point.Client.Main.Globals;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using static Point.Client.Main.Globals.RecordStatus;

namespace Point.Client.Main.Listing
{
    public partial class frmItemUnits : Form
    {
        private bool _isFirstLoad;

        private SearchItemDto? _searchItemDto;
        private int _currentPage;
        private int _currentTotalPages;
        private int _currentPageSize;

        private DateTime? _itemLastUpdate;
        private DateTime? _itemUnitLastUpdate;

        private readonly ItemService _itemService;
        private readonly PriceTypeService _priceTypeService;

        public frmItemUnits()
        {
            InitializeComponent();

            _isFirstLoad = true;

            _searchItemDto = null;
            _currentPage = 1;
            _currentTotalPages = 0;
            _currentPageSize = FormConstants.PageSizes.ElementAtOrDefault(0);

            _itemLastUpdate = null;
            _itemUnitLastUpdate = null;

            _itemService = ServiceFactory.GetService<ItemService>();
            _priceTypeService = ServiceFactory.GetService<PriceTypeService>();

            cmbPageSize.Items.AddRange(FormConstants.PageSizes.Cast<object>().ToArray());
        }

        private void frmItemUnits_Load(object sender, EventArgs e)
        {
            EnableControls(false);

            Task.Run(() =>
            {
                var reloadRequired = false;
                if (_itemLastUpdate != RecordStatus.Categories.LastUpdate)
                {
                    reloadRequired = true;
                    //await LoadCategories();
                }
                if (_itemLastUpdate != RecordStatus.Tags.LastUpdate)
                {
                    reloadRequired = true;
                    //await LoadTags();
                }

                // Reload
                //if (!_isFirstLoad && reloadRequired) cmbPageSize_SelectedIndexChanged(sender, e);
            });

            if (_isFirstLoad)
            {
                _isFirstLoad = false;

                Task.Run(LoadPriceTypes);

                cmbPageSize.SelectedIndex = 0;
                //lblSearchCriteria.Text = null;
            }

            EnableControls();
        }

        #region Search and Pagination

        private async void cmbPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            await Task.Run(async () =>
            {
                this.Invoke((MethodInvoker)(() =>
                {
                    _currentPage = 1;
                    _currentPageSize = FormConstants.PageSizes[cmbPageSize.SelectedIndex];
                }));

                await SearchItemsWithUnits();
            });
        }

        #endregion

        #region Edit

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormFactory.GetForm<frmItems>().ShowForSelection();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EnableEditing(false);
        }

        #endregion

        #region Helpers

        private void EnableEditing(bool enable = true)
        {
            tsMain.Enabled = enable;
            tsPages.Enabled = enable;

            dgvItemUnits.ReadOnly = enable;
            dgvItemUnits.Columns["clmName"].ReadOnly = !enable;
            dgvItemUnits.Columns["clmUnit"].ReadOnly = !enable;
        }

        private void EnableControls(bool enable = true)
        {
            this.Controls.OfType<Control>().ToList().ForEach(c => c.Enabled = enable);
        }

        private void UpdateRowValues(Item item, ItemUnit unit, DataGridViewRow row)
        {
            row.Cells["clmName"].Value = $"{item.Name} ({item.Category?.Name})";
            row.Cells["clmUnit"].Value = unit.Unit?.Name;
            row.Cells["clmItemCode"].Value = unit.ItemCode;
            row.Cells["clmPriceCode"].Value = unit.PriceCode;
            unit.Prices?.ForEach(price => row.Cells[price.PriceType.Id.ToString()].Value = price.Amount);
            row.Tag = unit;
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

            var response = await _itemService.SearchItemsWithUnits(_currentPage, _currentPageSize,
                _searchItemDto?.Name, _searchItemDto?.Category?.Id, _searchItemDto?.Tags?.Select(tag => tag.Id).ToList());

            this.Invoke((MethodInvoker)(() =>
            {
                _currentTotalPages = 0;

                dgvItemUnits.Rows.Clear();
                txtPage.Clear();
                lblTotalPage.Text = string.Format(FormConstants.TotalPagesCountLabel, 0);

                if (response?.TotalCount > 0)
                {
                    txtPage.Text = _currentPage.ToString();
                    _currentTotalPages = (int)Math.Ceiling((decimal)response?.TotalCount / _currentPageSize);
                    lblTotalPage.Text = string.Format(FormConstants.TotalPagesCountLabel, _currentTotalPages);

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

            var response = await _priceTypeService.GetPricesTypes();

            this.Invoke((MethodInvoker)(() =>
            {
                DataGridViewColumn column;
                response?.ForEach(priceType =>
                {
                    column = new DataGridViewTextBoxColumn()
                    {
                        Name = priceType.Id.ToString(),
                        HeaderText = priceType.Name, 
                    };
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    column.DefaultCellStyle.Format = "C2";
                    dgvItemUnits.Columns.Add(column);
                });

                this.Text = frmText;
                EnableControls();
            }));
        }

        #endregion
    }
}
