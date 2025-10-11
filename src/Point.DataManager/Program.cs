using Microsoft.Extensions.Configuration;
using System.Configuration;

namespace Point.DataManager
{
    internal static class Program
    {
        public static IConfiguration Configuration { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                var builder = new ConfigurationBuilder()
                    .SetBasePath(AppContext.BaseDirectory)
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

                Configuration = builder.Build();

                ApplicationConfiguration.Initialize();
                Application.Run(new frmMain());
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred. Please restart the application.\n\n" + ex.Message,
                    "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Application.Exit();
            }

        }
    }
}