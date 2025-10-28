using Point.Client.Main.Api;
using Point.Client.Main.Api.Dtos;
using Point.Client.Main.Api.Entities.Orders;
using Point.Client.Main.Api.Extensions;
using Point.Client.Main.Api.Services;
using Point.Client.Main.Globals;
using System.Text.RegularExpressions;

namespace Point.Client.Main.Forms.Orders
{
    public partial class frmCustomers : Form
    {
        private const string _emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

        public Customer SelectedCustomer { get; set; }

        private bool _isFirstLoad;
        private bool _isAddingNew;

        private readonly CustomerService _customerService;

        public frmCustomers()
        {
            InitializeComponent();

            SelectedCustomer = null;

            _isFirstLoad = true;
            _isAddingNew = false;

            _customerService = ServiceFactory.GetService<CustomerService>();
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            if (_isFirstLoad)
            {
                _isFirstLoad = false;

                Task.Run(() => SearchCustomers());
            }
        }

        #region Search and Selection

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                ClearFields();
                Task.Run(() => SearchCustomers(txtSearch.Text));
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count > 0)
            {
                SelectedCustomer = (Customer)txtCustomer.Tag;
                this.DialogResult = DialogResult.OK;
            }
        }

        #endregion

        #region Editing

        private void frmCustomers_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btnCancel.Visible)
            {
                btnCancel_Click(sender, e);
            }
        }

        private void dgvCustomers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count > 0)
            {
                var customer = (Customer)dgvCustomers.SelectedRows[0].Tag;
                txtCustomer.Tag = customer;
                txtCustomer.Text = customer.Name;
                txtMobile.Text = customer.MobileNumber;
                txtEmail.Text = customer.Email;
                txtAddress.Text = customer.Address;
                txtRemarks.Text = customer.Remarks;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            _isAddingNew = true;
            ClearFields();
            EnableEditing(true);
            txtCustomer.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            _isAddingNew = false;
            EnableEditing(true);
            txtCustomer.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomer.Text))
            {
                MessageBox.Show("Customer Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCustomer.Focus();
                return;
            }

            Regex regex = new(_emailPattern);

            if (!string.IsNullOrWhiteSpace(txtEmail.Text) && !regex.IsMatch(txtEmail.Text.Trim()))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            var customer = new CustomerDto
            {
                Name = txtCustomer.Text.Trim(),
                MobileNumber = string.IsNullOrWhiteSpace(txtMobile.Text) ? null : txtMobile.Text.Trim(),
                Email = string.IsNullOrWhiteSpace(txtEmail.Text) ? null : txtEmail.Text.Trim(),
                Address = string.IsNullOrWhiteSpace(txtAddress.Text) ? null : txtAddress.Text.Trim(),
                Remarks = string.IsNullOrWhiteSpace(txtRemarks.Text) ? null : txtRemarks.Text.Trim()
            };

            EnableButtons(false);

            if (_isAddingNew)
            {
                Task.Run(() => CreateCustomer(customer));
            }
            else
            {
                Task.Run(() => UpdateCustomer(((Customer)txtCustomer.Tag).Id, customer));
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dgvCustomers_SelectionChanged(sender, e);

            EnableEditing(false);
        }

        #endregion

        #region Helpers

        private void ClearFields()
        {
            txtCustomer.Clear();
            txtMobile.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtRemarks.Clear();
        }

        private void EnableEditing(bool enable)
        {
            txtSearch.Enabled = !enable;
            btnSelect.Visible = !enable;

            btnNew.Visible = !enable;
            btnEdit.Visible = !enable;
            btnSave.Visible = enable;
            btnCancel.Visible = enable;

            dgvCustomers.Enabled = !enable;
            txtCustomer.ReadOnly = !enable;
            txtMobile.ReadOnly = !enable;
            txtEmail.ReadOnly = !enable;
            txtAddress.ReadOnly = !enable;
            txtRemarks.ReadOnly = !enable;

            EnableButtons();
        }

        private void EnableButtons(bool enable = true)
        {
            btnNew.Enabled = enable;
            btnEdit.Enabled = enable;
            btnSave.Enabled = enable;
            btnCancel.Enabled = enable;
        }

        private void EnableFormLoading(bool enable = true, string? message = null)
        {
            this.ControlBox = !enable;
            this.Controls.OfType<Control>().ToList().ForEach(c => c.Enabled = !enable);

            if (enable)
            {
                this.Invoke((MethodInvoker)(() =>
                {
                    btnEdit.Enabled = false;
                    btnSelect.Enabled = false;

                    this.UseWaitCursor = true;
                    FormFactory.ShowLoadingForm(this, message);
                }));
            }
            else
            {
                this.Invoke((MethodInvoker)(() =>
                {
                    if (dgvCustomers.Rows.Count > 0)
                    {
                        btnSelect.Enabled = true;
                        btnEdit.Enabled = true;
                    }

                    this.UseWaitCursor = false;
                    FormFactory.CloseLoadingForm(this);
                }));
            }
        }

        #endregion

        #region Services

        private async void CreateCustomer(CustomerDto customerDto)
        {
            try
            {
                var response = await _customerService.CreateCustomer(customerDto);

                this.Invoke((MethodInvoker)(() =>
                {
                    MessageBox.Show("New Customer has been added.", "Request Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    var customer = customerDto.ToCustomer(response.Id);

                    dgvCustomers.Rows.Add(customerDto.Name);
                    var rowIndex = dgvCustomers.Rows.Count - 1;
                    dgvCustomers.Rows[rowIndex].Tag = customer;

                    dgvCustomers.ClearSelection();
                    dgvCustomers.Rows[rowIndex].Selected = true;
                    dgvCustomers.FirstDisplayedScrollingRowIndex = rowIndex;

                    txtCustomer.Text = customerDto.Name;
                    txtCustomer.Tag = customer;

                    EnableEditing(false);
                }));

                RecordStatus.Customers.Updated();
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

        private async void UpdateCustomer(int id, CustomerDto customerDto)
        {
            try
            {
                await _customerService.UpdateCustomer(id, customerDto);

                this.Invoke((MethodInvoker)(() =>
                {
                    MessageBox.Show("Customer has been updated.", "Request Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    var customer = customerDto.ToCustomer(id);

                    dgvCustomers.Rows[dgvCustomers.SelectedRows[0].Index].Cells[0].Value = customer.Name;
                    dgvCustomers.Rows[dgvCustomers.SelectedRows[0].Index].Tag = customer;

                    txtCustomer.Text = customer.Name;
                    txtMobile.Text = customer.MobileNumber;
                    txtEmail.Text = customer.Email;
                    txtAddress.Text = customer.Address;
                    txtRemarks.Text = customer.Remarks;

                    EnableEditing(false);
                }));

                RecordStatus.Customers.Updated();
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

        private async void SearchCustomers(string? name = null)
        {
            this.Invoke((MethodInvoker)(() =>
            {
                EnableFormLoading(true, "Loading Customers...");
            }));

            var response = await _customerService.SearchCustomers(name);

            this.Invoke((MethodInvoker)(() =>
            {
                dgvCustomers.Rows.Clear();

                DataGridViewRow row;
                response?.ForEach(customer =>
                {
                    row = new DataGridViewRow();
                    row.CreateCells(dgvCustomers);
                    row.Cells[0].Value = customer.Name;
                    row.Tag = customer;
                    dgvCustomers.Rows.Add(row);
                });

                EnableFormLoading(false);

                if (name != null) txtSearch.Focus();
            }));
        }

        #endregion
    }
}
