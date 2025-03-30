using Point.Client.Main.Api;
using Point.Client.Main.Api.Dtos;
using Point.Client.Main.Api.Entities;
using Point.Client.Main.Api.Services;

namespace Point.Client.Main.Listing
{
    public partial class frmItems : Form
    {
        private bool _isAddingNew;
        private readonly ItemService _itemService;
        private readonly CategoryService _categoryService;

        public frmItems()
        {
            InitializeComponent();
            _itemService = ServiceLocator.GetService<ItemService>();
            _categoryService = ServiceLocator.GetService<CategoryService>();
        }

        private void frmItems_Load(object sender, EventArgs e)
        {
            Task.Run(() => SearchItems());
        }

        private void dgvItems_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvItems.SelectedRows.Count > 0)
            {
                ClearFields();

                var item = (Item)dgvItems.SelectedRows[0]?.Tag;

                txtItem.Tag = item.Id;
                txtItem.Text = item.Name;
                cmbCategory.Tag = item.Category?.Id;
                cmbCategory.Text = item.Category?.Name;
                txtCategory.Text = item.Category?.Name;
                txtDescription.Text = item.Description;
                item.Tags?.ToList().ForEach(t =>
                {
                    dgvTags.Rows.Add(t.Name, "Remove");
                    dgvTags.Rows[dgvTags.Rows.Count - 1].Tag = t.Id;
                });
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            _isAddingNew = true;
            ClearFields();
            EnableEditing(true);
            txtItem.Focus();

            if (cmbCategory.DataSource == null) Task.Run(() => LoadCategories());
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            _isAddingNew = false;
            EnableEditing(true);
            txtItem.Focus();

            if (cmbCategory.DataSource == null) Task.Run(() => LoadCategories());
        }

        private void lnkManageCategories_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lnkAddTag_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtItem.Text))
            {
                MessageBox.Show("Item is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtItem.Focus();
                return;
            }
            // Add category validation

            var itemDto = new ItemDto
            {
                Name = txtItem.Text.Trim(),
                CategoryId = cmbCategory.SelectedItem != null ? (int)cmbCategory.SelectedValue : null,
                Description = !string.IsNullOrWhiteSpace(txtDescription.Text.Trim()) 
                    ? txtDescription.Text.Trim() 
                    : null,
                Tags = dgvTags.Rows.Count > 0
                    ? dgvTags.Rows.Cast<DataGridViewRow>().Select(row => (int)row.Tag).ToList() 
                    : null
            };

            //EnableButtons(false);

            //if (_isAddingNew)
            //{
            //    Task.Run(() => CreateItem(itemDto));
            //}
            //else
            //{
            //    Task.Run(() => UpdateItem((int)txtCategory.Tag, itemDto));
            //}
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dgvItems_SelectionChanged(sender, e);

            EnableEditing(false);
        }

        #region Helpers

        private void ClearFields()
        {
            txtItem.Clear();
            txtCategory.Clear();
            cmbCategory.Text = string.Empty;
            cmbCategory.SelectedIndex = -1;
            txtDescription.Clear();
            dgvTags.Rows.Clear();
        }

        private void EnableEditing(bool enable)
        {
            dgvItems.Enabled = !enable;

            txtItem.ReadOnly = !enable;
            txtCategory.Visible = !enable;
            cmbCategory.Visible = enable;
            lnkManageCategories.Visible = enable;
            txtDescription.ReadOnly = !enable;
            lnkAddTag.Visible = enable;
            clmRemove.Visible = enable;

            btnNew.Visible = !enable;
            btnEdit.Visible = !enable;
            btnSave.Visible = enable;
            btnCancel.Visible = enable;

            EnableButtons();
        }

        private void EnableButtons(bool enable = true)
        {
            this.Controls.OfType<Button>().ToList().ForEach(c => c.Enabled = enable);
        }

        #endregion

        #region Services

        private async void CreateItem(ItemDto itemDto)
        {
            try
            {
                var response = await _itemService.CreateItem(itemDto);

                this.Invoke((MethodInvoker)(() =>
                {
                    MessageBox.Show("New Item has been added.", "Request Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dgvItems.Rows.Add(itemDto.Name, cmbCategory.Text, itemDto.Description);
                    var rowIndex = dgvItems.Rows.Count - 1;
                    dgvItems.Rows[rowIndex].Tag = response?.Id;

                    dgvItems.ClearSelection();
                    dgvItems.Rows[rowIndex].Selected = true;
                    dgvItems.FirstDisplayedScrollingRowIndex = rowIndex;

                    txtItem.Text = itemDto.Name;
                    txtCategory.Text = cmbCategory.Text;
                    txtDescription.Text = itemDto.Description;

                    EnableEditing(false);
                }));
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

        private async void UpdateItem(int id, ItemDto itemDto)
        {
            try
            {
                await _itemService.UpdateItem(id, itemDto);

                this.Invoke((MethodInvoker)(() =>
                {
                    MessageBox.Show("Item has been updated.", "Request Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dgvItems.Rows[dgvItems.SelectedRows[0].Index].Cells[0].Value = itemDto.Name;
                    dgvItems.Rows[dgvItems.SelectedRows[0].Index].Cells[1].Value = cmbCategory.Text;
                    dgvItems.Rows[dgvItems.SelectedRows[0].Index].Cells[2].Value = itemDto.Description;

                    txtItem.Text = itemDto.Name;
                    txtCategory.Text = cmbCategory.Text;
                    txtDescription.Text = itemDto.Description;

                    EnableEditing(false);
                }));
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
        private async void SearchItems()
        {
            var frmText = this.Text;
            this.Invoke((MethodInvoker)(() =>
            {
                EnableButtons(false);

                this.Text = "Loading Items...";
            }));

            var response = await _itemService.SearchItems();

            this.Invoke((MethodInvoker)(() =>
            {
                DataGridViewRow row;
                response?.ForEach(item =>
                {
                    row = new DataGridViewRow();
                    row.CreateCells(dgvItems);
                    row.Cells[0].Value = item.Name;
                    row.Cells[1].Value = item.Category?.Name;
                    row.Cells[2].Value = item.Description;
                    row.Tag = item;
                    dgvItems.Rows.Add(row);
                });

                this.Text = frmText;
                EnableButtons(true);
            }));
        }

        private async void LoadCategories()
        {
            var frmText = this.Text;
            this.Invoke((MethodInvoker)(() =>
            {
                EnableButtons(false);

                this.Text = "Loading Categories...";
            }));

            var response = await _categoryService.GetCategories();

            this.Invoke((MethodInvoker)(() =>
            {
                cmbCategory.DataSource = response;
                cmbCategory.DisplayMember = "Name";
                cmbCategory.ValueMember = "Id";

                this.Text = frmText;
                EnableButtons(true);
            }));
        }

        #endregion
    }
}
