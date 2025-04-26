using Point.Client.Main.Api;
using Point.Client.Main.Api.Dtos;
using Point.Client.Main.Api.Services;
using Point.Client.Main.Globals;

namespace Point.Client.Main.Forms.Products
{
    public partial class frmTags : Form
    {
        private bool _isFirstLoad;
        private bool _isAddingNew;

        private readonly TagService _tagService;

        public frmTags()
        {
            InitializeComponent();

            _isFirstLoad = true;
            _isAddingNew = false;

            _tagService = ServiceLocator.GetService<TagService>();
        }

        private void frmTags_Load(object sender, EventArgs e)
        {
            if (_isFirstLoad)
            {
                Task.Run(() => LoadTags());
                _isFirstLoad = false;
            }
        }

        private void frmTags_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btnCancel.Visible)
            {
                btnCancel_Click(sender, e);
            }
        }

        private void dgvTags_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTags.SelectedRows.Count > 0)
            {
                var row = dgvTags.SelectedRows[0];
                txtTag.Tag = row.Tag;
                txtTag.Text = row.Cells[0].Value.ToString();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            _isAddingNew = true;
            ClearFields();
            EnableEditing(true);
            txtTag.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            _isAddingNew = false;
            EnableEditing(true);
            txtTag.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTag.Text))
            {
                MessageBox.Show("Tag is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTag.Focus();
                return;
            }

            var tag = new TagDto
            {
                Name = txtTag.Text.Trim()
            };

            EnableButtons(false);

            if (_isAddingNew)
            {
                Task.Run(() => CreateTag(tag));
            }
            else
            {
                Task.Run(() => UpdateTag((int)txtTag.Tag, tag));
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dgvTags_SelectionChanged(sender, e);

            EnableEditing(false);
        }

        #region Helpers

        private void ClearFields()
        {
            txtTag.Clear();
        }
        private void EnableEditing(bool enable)
        {
            btnNew.Visible = !enable;
            btnEdit.Visible = !enable;
            btnSave.Visible = enable;
            btnCancel.Visible = enable;

            dgvTags.Enabled = !enable;
            txtTag.ReadOnly = !enable;

            EnableButtons();
        }
        private void EnableButtons(bool enable = true)
        {
            this.Controls.OfType<Button>().ToList().ForEach(c => c.Enabled = enable);
        }

        #endregion

        #region Services

        private async void CreateTag(TagDto tagDto)
        {
            try
            {
                var response = await _tagService.CreateTag(tagDto);

                this.Invoke((MethodInvoker)(() =>
                {
                    MessageBox.Show("New Tag has been added.", "Request Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dgvTags.Rows.Add(tagDto.Name);
                    var rowIndex = dgvTags.Rows.Count - 1;
                    dgvTags.Rows[rowIndex].Tag = response?.Id;

                    dgvTags.ClearSelection();
                    dgvTags.Rows[rowIndex].Selected = true;
                    dgvTags.FirstDisplayedScrollingRowIndex = rowIndex;

                    txtTag.Text = tagDto.Name;

                    EnableEditing(false);
                }));

                RecordStatus.Tag.Updated();
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

        private async void UpdateTag(int id, TagDto tagDto)
        {
            try
            {
                await _tagService.UpdateTag(id, tagDto);

                this.Invoke((MethodInvoker)(() =>
                {
                    MessageBox.Show("Tag has been updated.", "Request Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dgvTags.Rows[dgvTags.SelectedRows[0].Index].Cells[0].Value = tagDto.Name;

                    dgvTags.Text = tagDto.Name;

                    EnableEditing(false);
                }));

                RecordStatus.Tag.Updated();
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
        private async void LoadTags()
        {
            var frmText = this.Text;
            this.Invoke((MethodInvoker)(() =>
            {
                EnableButtons(false);

                this.Text = "Loading Tags...";
            }));

            var response = await _tagService.GetTags();

            this.Invoke((MethodInvoker)(() =>
            {
                DataGridViewRow row;
                response?.ForEach(item =>
                {
                    row = new DataGridViewRow();
                    row.CreateCells(dgvTags);
                    row.Cells[0].Value = item.Name;
                    row.Tag = item.Id;
                    dgvTags.Rows.Add(row);
                });

                this.Text = frmText;
                EnableButtons(true);
            }));
        }

        #endregion

        
    }
}
