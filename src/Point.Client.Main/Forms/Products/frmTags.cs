using Point.Client.Main.Api;
using Point.Client.Main.Api.Dtos;
using Point.Client.Main.Api.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point.Client.Main.Forms.Products
{
    public partial class frmTags : Form
    {
        private bool _isAddingNew;
        private readonly TagService _tagService;

        public frmTags()
        {
            InitializeComponent();

            _isAddingNew = false;
            _tagService = ServiceLocator.GetService<TagService>();
        }

        private void frmTags_Load(object sender, EventArgs e)
        {
            Task.Run(() => LoadTags());
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
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            _isAddingNew = false;
            EnableEditing(true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTag.Text))
            {
                MessageBox.Show("Tag is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txtTag.Focus();
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
                response?.ForEach(c =>
                {
                    dgvTags.Rows.Add(c.Name);
                    dgvTags.Rows[dgvTags.Rows.Count - 1].Tag = c.Id;
                });

                dgvTags.ClearSelection();
                if (dgvTags.Rows.Count > 0) dgvTags.Rows[0].Selected = true;
                this.Text = frmText;

                EnableButtons(true);
            }));
        }

        #endregion
    }
}
