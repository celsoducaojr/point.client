using Point.Client.Main.Api;
using Point.Client.Main.Api.Dtos;
using Point.Client.Main.Api.Services;
using Point.Client.Main.Globals;

namespace Point.Client.Main.Listing
{
    public partial class frmCategories : Form
    {
        private bool _isFirstLoad;
        private bool _isAddingNew;
        private bool _hasChanges;

        private readonly CategoryService _categoryService;

        public frmCategories()
        {
            InitializeComponent();

            _isFirstLoad = true;
            _isAddingNew = false;
            _hasChanges = false;

            _categoryService = ServiceFactory.GetService<CategoryService>();
        }

        private void frmCategories_Load(object sender, EventArgs e)
        {
            if (_isFirstLoad)
            {
                _isFirstLoad = false;

                Task.Run(() => LoadCategories());
            }
        }

        private void frmCategories_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_hasChanges)
            {
                RecordStatus.Categories.Updated();
                _hasChanges = false;
            }
        }
        private void dgvCategories_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCategories.SelectedRows.Count > 0)
            {
                var row = dgvCategories.SelectedRows[0];
                txtCategory.Tag = row.Tag;
                txtCategory.Text = row.Cells[0].Value.ToString();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            _isAddingNew = true;
            ClearFields();
            EnableEditing(true);
            txtCategory.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            _isAddingNew = false;
            EnableEditing(true);
            txtCategory.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCategory.Text))
            {
                MessageBox.Show("Category is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCategory.Focus();
                return;
            }

            var category = new CategoryDto
            {
                Name = txtCategory.Text.Trim()
            };

            EnableButtons(false);

            if (_isAddingNew)
            {
                Task.Run(() => CreateCategory(category));
            }
            else
            {
                Task.Run(() => UpdateCategory((int)txtCategory.Tag, category));
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dgvCategories_SelectionChanged(sender, e);

            EnableEditing(false);
        }

        #region Helpers

        private void ClearFields()
        {
            txtCategory.Clear();
        }
        private void EnableEditing(bool enable)
        {
            btnNew.Visible = !enable;
            btnEdit.Visible = !enable;
            btnSave.Visible = enable;
            btnCancel.Visible = enable;

            dgvCategories.Enabled = !enable;
            txtCategory.ReadOnly = !enable;

            EnableButtons();
        }
        private void EnableButtons(bool enable = true)
        {
            this.Controls.OfType<Button>().ToList().ForEach(c => c.Enabled = enable);
        }

        private void EnableFormLoading(bool enable = true, string? message = null)
        {
            this.ControlBox = !enable;
            this.Controls.OfType<Control>().ToList().ForEach(c => c.Enabled = !enable);

            btnEdit.Enabled = true;
            if (dgvCategories.Rows.Count == 0)
            {
                btnEdit.Enabled = false;
            }

            if (enable)
            {
                this.Invoke((MethodInvoker)(() =>
                {
                    FormFactory.ShowLoadingForm(this, message);
                }));
            }
            else
            {
                this.Invoke((MethodInvoker)(() =>
                {
                    FormFactory.CloseLoadingForm(this);
                }));
            }
        }
        #endregion

        #region Services

        private async void CreateCategory(CategoryDto categoryDto)
        {
            try
            {
                var response = await _categoryService.CreateCategory(categoryDto);

                this.Invoke((MethodInvoker)(() =>
                {
                    MessageBox.Show("New Category has been added.", "Request Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dgvCategories.Rows.Add(categoryDto.Name);
                    var rowIndex = dgvCategories.Rows.Count - 1;
                    dgvCategories.Rows[rowIndex].Tag = response?.Id;

                    dgvCategories.ClearSelection();
                    dgvCategories.Rows[rowIndex].Selected = true;
                    dgvCategories.FirstDisplayedScrollingRowIndex = rowIndex;

                    EnableEditing(false);
                }));

                _hasChanges = true;
            }
            catch (HttpRequestException ex)
            {
                this.Invoke((MethodInvoker)(() =>
                {
                    MessageBox.Show(ex.Message, "Request Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    EnableEditing(true);
                }));
            }
        }

        private async void UpdateCategory(int id, CategoryDto categoryDto)
        {
            try
            {
                await _categoryService.UpdateCategory(id, categoryDto);

                this.Invoke((MethodInvoker)(() =>
                {
                    MessageBox.Show("Category has been updated.", "Request Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dgvCategories.Rows[dgvCategories.SelectedRows[0].Index].Cells[0].Value = categoryDto.Name;

                    txtCategory.Text = categoryDto.Name;

                    EnableEditing(false);
                }));

                _hasChanges = true;
            }
            catch (HttpRequestException ex)
            {
                this.Invoke((MethodInvoker)(() =>
                {
                    MessageBox.Show(ex.Message, "Request Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    EnableEditing(true);
                }));
            }
        }
        private async void LoadCategories()
        {
            this.Invoke((MethodInvoker)(() =>
            {
                EnableFormLoading(true, "Loading Categories...");
            }));

            var response = await _categoryService.GetCategories();

            this.Invoke((MethodInvoker)(() =>
            {
                DataGridViewRow row;
                response?.ForEach(category =>
                {
                    row = new DataGridViewRow();
                    row.CreateCells(dgvCategories);
                    row.Cells[0].Value = category.Name;
                    row.Tag = category.Id;
                    dgvCategories.Rows.Add(row);
                });

                EnableFormLoading(false);
            }));
        }

        #endregion
    }
}
