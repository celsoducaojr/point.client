using Point.Client.Main.Constants;
using Point.Client.Main.Globals;

namespace Point.Client.Main.Forms.Orders
{
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
        }

        private void timerTimestamp_Tick(object sender, EventArgs e)
        {
            lblTimestamp.Text = DateTime.Now.ToString(FormConstants.Formats.Timestamp).ToUpper();
        }

        private void lnkSelectCustomer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = FormFactory.GetFormDialog<frmCustomers>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                txtCustomer.Tag = form.SelectedCustomer;
                txtCustomer.Text = form.SelectedCustomer.Name;
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            var form = FormFactory.GetFormDialog<frmOrderItem>();
            if (form.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
