using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using Univercity.Services;

namespace UnivercityApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ConfigureServices(new ServiceCollection());
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            services.AddServices()
                .AddSingleton(typeof(Univercity))
                .AddSingleton(typeof(StudenDetails));

            var serviceProvider = services.BuildServiceProvider();
            var mainForm = (Univercity) serviceProvider.GetService(typeof(Univercity));
            Application.Run(mainForm);
        }
    }
}