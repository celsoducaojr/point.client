﻿using Point.Client.Main.Api;
using Point.Client.Main.Api.Dtos;
using Point.Client.Main.Api.Services;
using Point.Client.Main.Globals;

namespace Point.Client.Main.Forms.Products
{
    public partial class frmUnits : Form
    {
        private bool _isFirstLoad;
        private bool _isAddingNew;

        private readonly UnitService _unitService;

        public frmUnits()
        {
            InitializeComponent();

            _isFirstLoad  = true;
            _isAddingNew = false;

            _unitService = ServiceFactory.GetService<UnitService>();
        }

        private void frmUnits_Load(object sender, EventArgs e)
        {
            if (_isFirstLoad)
            {
                _isFirstLoad = false;

                Task.Run(() => LoadUnits());
            }
        }

        private void dgvUnits_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUnits.SelectedRows.Count > 0)
            {
                var row = dgvUnits.SelectedRows[0];
                txtUnit.Tag = row.Tag;
                txtUnit.Text = row.Cells[0].Value.ToString();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            _isAddingNew = true;
            ClearFields();
            EnableEditing();
            txtUnit.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            _isAddingNew = false;
            EnableEditing();
            txtUnit.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUnit.Text))
            {
                MessageBox.Show("Unit is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUnit.Focus();
                return;
            }

            var unitDto = new UnitDto
            {
                Name = txtUnit.Text.Trim()
            };

            EnableButtons(false);

            if (_isAddingNew)
            {
                Task.Run(() => CreateUnit(unitDto));
            }
            else
            {
                Task.Run(() => UpdateUnit((int)txtUnit.Tag, unitDto));
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dgvUnits_SelectionChanged(sender, e);

            EnableEditing(false);
        }

        #region Helpers

        private void ClearFields()
        {
            txtUnit.Clear();
        }

        private void EnableEditing(bool enable = true)
        {
            btnNew.Visible = !enable;
            btnEdit.Visible = !enable;
            btnSave.Visible = enable;
            btnCancel.Visible = enable;

            dgvUnits.Enabled = !enable;
            txtUnit.ReadOnly = !enable;

            EnableButtons();
        }

        private void EnableButtons(bool enable = true)
        {
            this.Controls.OfType<Button>().ToList().ForEach(c => c.Enabled = enable);
        }

        #endregion

        #region Services

        private async void CreateUnit(UnitDto unitDto)
        {
            try
            {
                var response = await _unitService.CreateUnit(unitDto);

                this.Invoke((MethodInvoker)(() =>
                {
                    MessageBox.Show("New Unit has been added.", "Request Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dgvUnits.Rows.Add(unitDto.Name);
                    var rowIndex = dgvUnits.Rows.Count - 1;
                    dgvUnits.Rows[rowIndex].Tag = response?.Id;

                    dgvUnits.ClearSelection();
                    dgvUnits.Rows[rowIndex].Selected = true;
                    dgvUnits.FirstDisplayedScrollingRowIndex = rowIndex;

                    EnableEditing(false);
                }));

                RecordStatus.Units.Updated();
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

        private async void UpdateUnit(int id, UnitDto unitDto)
        {
            try
            {
                await _unitService.UpdateUnit(id, unitDto);

                this.Invoke((MethodInvoker)(() =>
                {
                    MessageBox.Show("Unit has been updated.", "Request Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dgvUnits.Rows[dgvUnits.SelectedRows[0].Index].Cells[0].Value = unitDto.Name;

                    txtUnit.Text = unitDto.Name;

                    EnableEditing(false);
                }));

                RecordStatus.Units.Updated();
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
                EnableButtons(false);

                this.Text = "Loading Units...";
            }));

            var response = await _unitService.GetUnits();

            this.Invoke((MethodInvoker)(() =>
            {
                DataGridViewRow row;
                response?.ForEach(unit =>
                {
                    row = new DataGridViewRow();
                    row.CreateCells(dgvUnits);
                    row.Cells[0].Value = unit.Name;
                    row.Tag = unit.Id;
                    dgvUnits.Rows.Add(row);
                });

                this.Text = frmText;
                EnableButtons(true);
            }));
        }

        #endregion
    }
}
