using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace MIR_ERM
{
    public class GlobalConfig
    {
        public static string ConnectionString { get; private set; }
        public static string Username { get; private set; }

        public static void Initialize()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
        }
    }

}
