using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DapperConTest
{
    class Program
    {
        private static List<BO.Employee> Main(string[] args)
        {
            List<BO.Employee> employee = null;
            using (var db = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString))
            {
                employee = db.Query<BO.Employee>("dbo.GetEmployees", commandType: CommandType.StoredProcedure).ToList();
            }
            Console.Write(employee);
            Console.ReadLine();
            return employee;
        }
    }
}
