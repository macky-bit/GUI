using GUI;
using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        private static readonly string CrashLogFile = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "DMMMSU_Maintenance", "error-log.txt");

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Report faults instead of vanishing, and keep a log the student can send in
            Application.ThreadException += (s, e) => ReportFault(e.Exception);
            AppDomain.CurrentDomain.UnhandledException += (s, e) => ReportFault(e.ExceptionObject as Exception);
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            if (!PrepareDatabase()) return;

            Application.Run(new Dashboard());
        }

        /// <summary>
        /// Creates the MySQL schema on first launch. Returns false when the server
        /// cannot be reached, so the app exits with an explanation instead of
        /// failing on the first query.
        /// </summary>
        private static bool PrepareDatabase()
        {
            try
            {
                Database.EnsureCreated();
                return true;
            }
            catch (DatabaseUnavailableException error)
            {
                MessageBox.Show(error.Message, "Database Unavailable",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private static void ReportFault(Exception error)
        {
            if (error == null) return;

            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(CrashLogFile));
                File.AppendAllText(CrashLogFile,
                    DateTime.Now.ToString("u") + Environment.NewLine + error + Environment.NewLine + Environment.NewLine);
            }
            catch (IOException)
            {
                // Logging must never mask the original fault
            }

            MessageBox.Show(
                "Something went wrong:" + Environment.NewLine + Environment.NewLine + error.Message +
                Environment.NewLine + Environment.NewLine + "Details were saved to:" + Environment.NewLine + CrashLogFile,
                "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
