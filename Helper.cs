using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.IO;
namespace SilverTune
{
    

    public static class ConfigurationHelper
    {
        public static IConfigurationRoot LoadConfiguration()
        {
            return new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();
        }

        public static string GetConnectionString()
        {
            var config = LoadConfiguration();
            return config.GetConnectionString("BookingDatabase");
        }
    }

}
