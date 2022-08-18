using DAL;
using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Employees
    {
        private readonly IDbConnection _DataBaseConnection;
        
        public Employees(IDbConnection DataBaseConnection)
        {
            _DataBaseConnection = DataBaseConnection;
        }

        public List<BO.Employee> GetEmpoyees()
        {
            List<BO.Employee> employee = null;
            using (var db = DataAccess.TestDB())
            {
                employee = db.Query<BO.Employee>("dbo.GetEmployees", commandType: CommandType.StoredProcedure).ToList();
            }

            return employee;
        }
    }
}
