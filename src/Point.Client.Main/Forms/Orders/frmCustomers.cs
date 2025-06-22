using Point.Client.Main.Api;
using Point.Client.Main.Api.Dtos;
using Point.Client.Main.Api.Entities;
using Point.Client.Main.Api.Services;
using Point.Client.Main.Globals;

namespace Point.Client.Main.Forms.Orders
{
    public partial class frmCustomers : Form
    {
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

                Task.Run(() => LoadCustomers());
            }
        }

        #region Search and Selection

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                btnSelect.Enabled = false;
                Task.Run(() => LoadCustomers(txtSearch.Text));
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

        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            Task.Run(() => LoadCustomers());
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
                var row = dgvCustomers.SelectedRows[0];
                txtCustomer.Tag = row.Tag;
                txtCustomer.Text = row.Cells[0].Value.ToString();

                btnSelect.Enabled = true;
            }
            else
            {
                btnSelect.Enabled = false;
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

            var customer = new CustomerDto
            {
                Name = txtCustomer.Text.Trim()
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
        }
        private void EnableEditing(bool enable)
        {
            txtSearch.Enabled = !enable;
            btnLoadAll.Visible = !enable;
            btnSelect.Visible = !enable;

            btnNew.Visible = !enable;
            btnEdit.Visible = !enable;
            btnSave.Visible = enable;
            btnCancel.Visible = enable;

            dgvCustomers.Enabled = !enable;
            txtCustomer.ReadOnly = !enable;

            EnableButtons();
        }
        private void EnableButtons(bool enable = true)
        {
            btnLoadAll.Enabled = enable;

            btnNew.Enabled = enable;
            btnEdit.Enabled = enable;
            btnSave.Enabled = enable;
            btnCancel.Enabled = enable;
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

                    dgvCustomers.Rows.Add(customerDto.Name);
                    var rowIndex = dgvCustomers.Rows.Count - 1;
                    dgvCustomers.Rows[rowIndex].Tag = response?.Id;

                    dgvCustomers.ClearSelection();
                    dgvCustomers.Rows[rowIndex].Selected = true;
                    dgvCustomers.FirstDisplayedScrollingRowIndex = rowIndex;

                    txtCustomer.Text = customerDto.Name;
                    txtCustomer.Tag = new Customer { Id = response.Id, Name = customerDto.Name};

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

                    dgvCustomers.Rows[dgvCustomers.SelectedRows[0].Index].Cells[0].Value = customerDto.Name;

                    txtCustomer.Text = customerDto.Name;

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

        private async void LoadCustomers(string? name = null)
        {
            var frmText = this.Text;
            this.Invoke((MethodInvoker)(() =>
            {
                EnableButtons(false);

                this.Text = "Loading Categories...";
            }));

            var response = string.IsNullOrWhiteSpace(name)
                ? await _customerService.GetCustomers()
                : await _customerService.SearchCustomers(name);

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

                this.Text = frmText;
                EnableButtons(true);
            }));
        }

        #endregion
    }
}
