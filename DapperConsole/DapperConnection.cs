using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperConsole
{
    public class DapperConnection
    {
        public static SqlConnection TestDB()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);
        }
    }
}
