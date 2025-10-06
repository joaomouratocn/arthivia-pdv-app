using Microsoft.VisualBasic.Logging;

namespace Arthivia_pdv_app
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Login login = new();
            login.StartPosition = FormStartPosition.CenterScreen;
            login.FormBorderStyle = FormBorderStyle.FixedToolWindow;

            if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Main());
            }
        }
    }
}