using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
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
            _currentPageSize = FormConstants.Pagination.PageSizes.ElementAtOrDefault(0);

            _itemLastUpdate = null;
            _itemUnitLastUpdate = null;

            _itemService = ServiceFactory.GetService<ItemService>();
            _priceTypeService = ServiceFactory.GetService<PriceTypeService>();

            cmbPageSize.Items.AddRange(FormConstants.Pagination.PageSizes.Cast<object>().ToArray());
        }

        private async void frmItemUnits_Load(object sender, EventArgs e)
        {
            EnableControls(false);

            await Task.Run(() =>
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

                await Task.Run(LoadPriceTypes);

                cmbPageSize.SelectedIndex = 0;
                //lblSearchCriteria.Text = null;
            }

            EnableControls();
        }

        #region Search and Pagination

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (_currentTotalPages > 0 && _currentPage != 1)
            {
                _currentPage = 1;

                Task.Run(() => SearchItemsWithUnits());
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (_currentTotalPages > 0 && _currentPage > 1)
            {
                _currentPage = 1;

                if (int.TryParse(txtPage.Text, out var selectedPage)
                    && selectedPage > 1)
                {
                    _currentPage = selectedPage - 1;
                }

                Task.Run(() => SearchItemsWithUnits());
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_currentTotalPages > 0 && _currentPage < _currentTotalPages)
            {
                _currentPage = _currentTotalPages;
                if (int.TryParse(txtPage.Text, out var selectedPage)
                    && selectedPage < _currentTotalPages)
                {
                    _currentPage = selectedPage + 1;
                }

                Task.Run(() => SearchItemsWithUnits());
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (_currentTotalPages > 0 && _currentPage != _currentTotalPages)
            {
                _currentPage = _currentTotalPages;

                Task.Run(() => SearchItemsWithUnits());
            }

        }

        private void txtPage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && _currentTotalPages > 0)
            {
                if (int.TryParse(txtPage.Text, out var selectedPage)
                    && selectedPage > 0 && selectedPage != _currentPage && selectedPage <= _currentTotalPages)
                {
                    _currentPage = selectedPage;
                    Task.Run(() => SearchItemsWithUnits());
                }
                else
                {
                    txtPage.Text = _currentPage.ToString();
                }   
            }
        }

        private async void cmbPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            await Task.Run(async () =>
            {
                this.Invoke((MethodInvoker)(() =>
                {
                    _currentPage = 1;
                    _currentPageSize = FormConstants.Pagination.PageSizes[cmbPageSize.SelectedIndex];
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

        private void dgvItemUnits_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            var columnTag = dgvItemUnits.Columns[e.ColumnIndex].Tag;

            if (columnTag != null && columnTag.ToString() == FormConstants.DataGridViewColumn.PriceTag)
            {
                var value = e.FormattedValue?.ToString() ?? string.Empty;

                if (!string.IsNullOrWhiteSpace(value) && !decimal.TryParse(value, out _))
                {
                    MessageBox.Show("Invalid Amount value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
        }
        private void dgvItemUnits_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            var columnTag = dgvItemUnits.Columns[e.ColumnIndex].Tag;

            if (columnTag != null && columnTag.ToString() == FormConstants.DataGridViewColumn.PriceTag)
            {
                var cell = dgvItemUnits.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (decimal.TryParse(cell.Value?.ToString(), out decimal value))
                {
                    cell.Value = value.ToString(FormConstants.AmountFormat);
                }
            }
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
            unit.Prices?.ForEach(price =>
            {
                row.Cells[price.PriceType.Id.ToString()].Value = price.Amount;
            });
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
                lblTotalPage.Text = string.Format(FormConstants.Pagination.TotalPagesCountLabel, 0);

                if (response?.TotalCount > 0)
                {
                    txtPage.Text = _currentPage.ToString();
                    _currentTotalPages = (int)Math.Ceiling((decimal)response?.TotalCount / _currentPageSize);
                    lblTotalPage.Text = string.Format(FormConstants.Pagination.TotalPagesCountLabel, _currentTotalPages);

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
                response?.ForEach(priceType =>
                {
                    var column = new DataGridViewTextBoxColumn()
                    {
                        Name = priceType.Id.ToString(),
                        HeaderText = priceType.Name,
                    };
                    column.Tag = FormConstants.DataGridViewColumn.PriceTag;
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    column.DefaultCellStyle.Format = FormConstants.AmountFormat;
                    dgvItemUnits.Columns.Add(column);
                });

                this.Text = frmText;
                EnableControls();
            }));
        }

        #endregion
    }
}
