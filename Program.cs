using CounterSalary.Core.Services;
using System;
using System.Windows.Forms;

namespace CounterSalary
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ServiceBase[] services = new ServiceBase[]
            {
                new StorageService(),
                new SalaryService()
            };
            ServiceProvider serviceProvider = new ServiceProvider(services);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(serviceProvider));
        }
    }
}
