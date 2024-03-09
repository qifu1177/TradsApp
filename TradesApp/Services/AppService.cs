using App.Infrastructure.Common;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradesApp.Services
{
    public class AppService
    {
        public static IServiceProvider ServiceProvider { get; set; }
        public Config Config { get; private set; }
        public AppService(Config config)
        {
            Config = config;
        }
        public void UpdateConnectionString(string userName, string password)
        {
            Config.ConnectionString = string.Format(ConfigurationManager.ConnectionStrings["AppDb"].ConnectionString, userName, password);
        }
    }
}
