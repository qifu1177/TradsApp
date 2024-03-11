using App.DataAccess;
using App.DataAccess.Services;
using App.Infrastructure.Common;
using App.Infrastructure.Interfaces;
using App.Service.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Configuration;
using TradesApp.Dialogs;
using TradesApp.Models;
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
            services.AddScoped<EmployeeTradesView>();
            services.AddScoped<TradesView>();
            services.AddScoped<KursdatenView>();
            services.AddTransient<EmployeeTradeInputDialog>();
            services.AddTransient<AlarmDialog>();
            services.AddTransient<SettingView>();
        }
        private static void AddDatas(IServiceCollection services)
        {
            Config config = new Config();
            config.DataPageUrl = ConfigurationManager.AppSettings["DataPage"];
            services.AddSingleton<Config>(config);
            services.AddSingleton<Setting>();
        }
        private static void AddSerices(IServiceCollection services)
        {
            services.AddTransient<IDBUserService, DBUserService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IDBEmployeeTradeService, DBEmployeeTradeService>();
            services.AddTransient<IEmployeeTradeService, EmployeeTradeService>();
            services.AddTransient<IDBTradeDataService, DBTradeDataService>();
            services.AddTransient<ITradeDataService, TradeDataService>();
            services.AddSingleton<AppService>();
            services.AddSingleton<UiService>();
            services.AddTransient<HtmlService>();
        }
    }
}