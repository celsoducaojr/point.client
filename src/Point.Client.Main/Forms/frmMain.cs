using ClosedXML.Excel;
using Point.Client.Main.Forms;
using Point.Client.Main.Forms.Listing;
using Point.Client.Main.Forms.Orders;
using Point.Client.Main.Forms.Products;
using Point.Client.Main.Forms.Sales;
using Point.Client.Main.Globals;
using Point.Client.Main.Listing;
using Point.Client.Main.Stocks;

namespace Point.Client.Main
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region Menu

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmLoading().ShowDialog();
        }

        #endregion

        #region Listing

        private void btnItemUnits_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmItemUnits());
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmItems());
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            FormFactory.GetFormDialog<frmCategories>().ShowDialog();
        }

        private void btnUnits_Click(object sender, EventArgs e)
        {
            FormFactory.GetFormDialog<frmUnits>().ShowDialog();
        }

        private void btnTags_Click(object sender, EventArgs e)
        {
            FormFactory.GetFormDialog<frmTags>().ShowDialog();
        }

        private void btnPriceTypes_Click(object sender, EventArgs e)
        {
            FormFactory.GetFormDialog<frmPriceTypes>().ShowDialog();
        }

        #endregion

        #region Stocks

        private void btnStocks_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmStocks());
        }

        #endregion

        #region Orders

        private void btnOrders_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmOrders());
        }

        private void btnOrderForm_Click(object sender, EventArgs e)
        {
            FormFactory.GetForm<frmOrder>().Show();
        }

        #endregion

        #region Sales

        private void btnSales_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmSales());
        }

        #endregion

        #region Helpers

        private void OpenChildForm(Form childForm)
        {
            foreach (var form in this.MdiChildren)
            {
                if (form.GetType() == childForm.GetType())
                {
                    form.Activate();
                    return;
                }
            }

            childForm.MdiParent = this;
            childForm.Show();
        }

        #endregion

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            string orderFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"static\printing\order.xlsx");
            string outputFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "temp");
            if (!Directory.Exists(outputFolder)) Directory.CreateDirectory(outputFolder);
            string outputFile = Path.Combine(outputFolder, "order_printing.xlsx");
            File.Copy(orderFile, outputFile, true);


            string filePath = outputFile;

            using (var book = new XLWorkbook(filePath))
            {
                var worksheet = book.Worksheet(1); // or .Worksheet("Sheet1")

                // Write values
                worksheet.Cell("A1").Value = "Name";
                worksheet.Cell("B1").Value = "Score";

                worksheet.Cell("A2").Value = "John";
                worksheet.Cell("B2").Value = 95;

                worksheet.Cell("A3").Value = "Maria";
                worksheet.Cell("B3").Value = 88;

                // Save changes to same file
                book.Save();
            }
        }
    }
}
