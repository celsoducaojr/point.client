using Point.Client.Main.Constants;

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
    }
}
