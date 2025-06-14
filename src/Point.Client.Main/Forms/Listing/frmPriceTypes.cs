using System.Data;
using Point.Client.Main.Api;
using Point.Client.Main.Api.Dtos;
using Point.Client.Main.Api.Services;
using Point.Client.Main.Globals;

namespace Point.Client.Main.Forms.Listing
{
    public partial class frmPriceTypes : Form
    {
        private bool _isFirstLoad;
        private bool _isAddingNew;

        private readonly PriceTypeService _priceTypeService;

        public frmPriceTypes()
        {
            InitializeComponent();

            _isFirstLoad = true;
            _isAddingNew = false;

            _priceTypeService = ServiceFactory.GetService<PriceTypeService>();
        }

        private void frmPriceTypes_Load(object sender, EventArgs e)
        {
            if (_isFirstLoad)
            {
                _isFirstLoad = false;

                Task.Run(() => LoadPriceTypes());
            }
        }

        private void frmPriceTypes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btnCancel.Visible)
            {
                btnCancel_Click(sender, e);
            }
        }

        private void dgvTypes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTypes.SelectedRows.Count > 0)
            {
                var row = dgvTypes.SelectedRows[0];
                txtType.Tag = row.Tag;
                txtType.Text = row.Cells[0].Value.ToString();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            _isAddingNew = true;
            ClearFields();
            EnableEditing(true);
            txtType.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            _isAddingNew = false;
            EnableEditing(true);
            txtType.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtType.Text))
            {
                MessageBox.Show("Price Type is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtType.Focus();
                return;
            }

            var priceType = new PriceTypeDto
            {
                Name = txtType.Text.Trim(),
                DisplayIndex = _isAddingNew ? dgvTypes.Rows.Count + 1 : dgvTypes.SelectedRows[0].Index + 1
            };

            EnableButtons(false);

            if (_isAddingNew)
            {
                Task.Run(() => CreatePriceType(priceType));
            }
            else
            {
                Task.Run(() => UpdatePriceType((int)txtType.Tag, priceType));
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dgvTypes_SelectionChanged(sender, e);

            EnableEditing(false);
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (dgvTypes.SelectedRows.Count > 0 && dgvTypes.SelectedRows[0].Index > 0)
            {
                Task.Run(() => UpdatePriceTypeDisplayIndex());
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (dgvTypes.SelectedRows.Count > 0 && dgvTypes.SelectedRows[0].Index < dgvTypes.Rows.Count - 1)
            {
                Task.Run(() => UpdatePriceTypeDisplayIndex(false));
            }

        }

        #region Helpers

        private void ClearFields()
        {
            txtType.Clear();
        }

        private void EnableEditing(bool enable = true)
        {
            btnUp.Visible = !enable;
            btnDown.Visible = !enable;
            btnNew.Visible = !enable;
            btnEdit.Visible = !enable;
            btnSave.Visible = enable;
            btnCancel.Visible = enable;

            dgvTypes.Enabled = !enable;
            txtType.ReadOnly = !enable;

            EnableButtons();
        }

        private void EnableButtons(bool enable = true)
        {
            this.Controls.OfType<Button>().ToList().ForEach(c => c.Enabled = enable);
        }
        
        private void EnableControls(bool enable = true)
        {
            this.Controls.OfType<Control>().ToList().ForEach(c => c.Enabled = enable);
        }

        #endregion

        #region Services

        private async void CreatePriceType(PriceTypeDto priceTypeDto)
        {
            try
            {
                var response = await _priceTypeService.CreatePriceType(priceTypeDto);

                this.Invoke((MethodInvoker)(() =>
                {
                    MessageBox.Show("New Price Type has been added.", "Request Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dgvTypes.Rows.Add(priceTypeDto.Name);
                    var rowIndex = dgvTypes.Rows.Count - 1;
                    dgvTypes.Rows[rowIndex].Tag = response?.Id;

                    dgvTypes.ClearSelection();
                    dgvTypes.Rows[rowIndex].Selected = true;
                    dgvTypes.FirstDisplayedScrollingRowIndex = rowIndex;

                    EnableEditing(false);
                }));

                RecordStatus.PriceTypes.Updated();
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

        private async void UpdatePriceType(int id, PriceTypeDto priceTypeDto)
        {
            try
            {
                await _priceTypeService.UpdatePriceType(id, priceTypeDto);

                this.Invoke((MethodInvoker)(() =>
                {
                    MessageBox.Show("Price Type has been updated.", "Request Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dgvTypes.Rows[dgvTypes.SelectedRows[0].Index].Cells[0].Value = priceTypeDto.Name;

                    txtType.Text = priceTypeDto.Name;

                    EnableEditing(false);
                }));

                RecordStatus.PriceTypes.Updated();
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

        private async void UpdatePriceTypeDisplayIndex(bool moveUp = true)
        {
            var frmText = this.Text;
            this.Invoke((MethodInvoker)(() =>
            {
                this.Text = "Updating Price Type Column display indexes...";
                EnableControls(false);

                var sourceRow = dgvTypes.SelectedRows[0];
                var newRow = (DataGridViewRow)sourceRow.Clone();
                newRow.Cells[0].Value = sourceRow.Cells[0].Value;
                newRow.Tag = sourceRow.Tag;

                var newRowIndex = (moveUp) ? sourceRow.Index - 1 : sourceRow.Index + 2;
                dgvTypes.Rows.Insert(newRowIndex, newRow);

                dgvTypes.Rows.RemoveAt(sourceRow.Index);

                dgvTypes.ClearSelection();
                dgvTypes.Rows[newRow.Index].Selected = true;
                dgvTypes.FirstDisplayedScrollingRowIndex = newRow.Index;
            }));

            var priceTypeIndex = dgvTypes.Rows
                     .Cast<DataGridViewRow>()
                     .ToDictionary(row => (int)row.Tag, row => row.Index);

            await _priceTypeService.UpdatePriceTypeDisplayIndexes(priceTypeIndex);

            RecordStatus.PriceTypes.IndexUpdated();

            this.Invoke((MethodInvoker)(() =>
            {
                this.Text = frmText;
                EnableControls();
            }));
        }

        private async void LoadPriceTypes()
        {
            var frmText = this.Text;
            this.Invoke((MethodInvoker)(() =>
            {
                EnableControls(false);

                this.Text = "Loading Price Types...";
            }));

            var response = await _priceTypeService.GetPricesTypes();

            this.Invoke((MethodInvoker)(() =>
            {
                DataGridViewRow row;
                response?.ForEach(priceType =>
                {
                    row = new DataGridViewRow();
                    row.CreateCells(dgvTypes);
                    row.Cells[0].Value = priceType.Name;
                    row.Tag = priceType.Id;
                    dgvTypes.Rows.Add(row);
                });

                this.Text = frmText;
                EnableControls();
            }));
        }

        #endregion
       
    }
}
