using App.DataAccess;
using App.Infrastructure.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Configuration;
using TradesApp.Services;
using TradesApp.Views;

namespace TradesApp
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
            var host = CreateHostBuilder().Build();
            AppService.ServiceProvider = host.Services;
            Application.Run(AppService.ServiceProvider.GetService<TradsApp>());
        }
        private static IHostBuilder CreateHostBuilder()
        {
            string connectionStr = ConfigurationManager.ConnectionStrings["AppDb"].ConnectionString;
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    //services.AddScoped<TInterface, TImplementation>();
                    //services.AddDbContext<AppDbContext>(options =>
                    //{
                    //    //options.UseSqlServer(connectionStr);
                    //});
                    AddDatas(services);
                    AddSerices(services);
                    AddViews(services);
                });
        }
        private static void AddViews(IServiceCollection services)
        {
            services.AddScoped<TradsApp>();
            services.AddTransient<LoginView>();
            services.AddTransient<MainView>();
        }
        private static void AddDatas(IServiceCollection services)
        {
            services.AddSingleton<Config>();
        }
        private static void AddSerices(IServiceCollection services)
        {
            services.AddSingleton<AppService>();
            services.AddSingleton<UiService>();
        }
    }
}