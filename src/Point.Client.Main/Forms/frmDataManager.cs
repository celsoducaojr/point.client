using System.Diagnostics;

namespace Point.Client.Main.Forms
{
    public partial class frmDataManager : Form
    {
        public frmDataManager()
        {
            InitializeComponent();
        }

        private void btnBrowseDirectory_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                dialog.SelectedPath = txtDirectory.Text;
                dialog.Description = "Select a folder to save exported data";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtDirectory.Text = dialog.SelectedPath;
                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string backupFile = $"{txtDirectory.Text}/point_data.sql";
            string dbName = "point";
            string user = "point";
            string password = "point";

            var psi = new ProcessStartInfo
            {
                FileName = "mysqldump",
                Arguments = $"-u {user} -p{password} {dbName}",
                RedirectStandardOutput = true,
                UseShellExecute = false
            };

            using var process = Process.Start(psi);
            using var reader = process.StandardOutput;
            File.WriteAllText(backupFile, reader.ReadToEnd());
        }
    }
}
