
using System;
using System.Windows.Forms;

namespace SystemSmart
{
    internal static class Program
    {
        /// <summary>
        /// نقطة بداية البرنامج.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();

            Application.SetCompatibleTextRenderingDefault(false);

            Application.SetHighDpiMode(HighDpiMode.SystemAware);

            Application.Run(new LoginForm());
        }
    }
}
