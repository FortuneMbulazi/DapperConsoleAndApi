using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccess
    {
        public static SqlConnection TestDB()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);
        }
        //public static IDbConnection DataBaseConnection { get { return new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString); } }

        //private static IDbConnection DataBaseConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);
        //private readonly IDbConnection _DataBaseConnection;

        //public DataAccess(IDbConnection DataBaseConnection)
        //{
        //    _DataBaseConnection = DataBaseConnection;
        //}

        //public string test()
        //{
        //   var test = ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString;
        //    return test;
        //}
    }
}
