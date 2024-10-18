using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using System.Xml;
using System.Xml.Linq;


namespace Util
{
    public class DBPropertyUtil
    {
        private static IConfigurationRoot _configuration;
        static string s = null;
        static DBPropertyUtil()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("C:\\Users\\Amulya\\Desktop\\Hexaware\\Assignment\\Techshop_Sol\\Util\\appsettings.json",
               optional: true, reloadOnChange: true);
            _configuration = builder.Build();
        }
        public static string ReturnCn(string key)
        {

            s = _configuration.GetConnectionString("CnStr");

            return s;
        }
    }
}