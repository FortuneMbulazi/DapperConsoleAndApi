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
        public List<BO.Employee> GetEmployees(long employeeId)
        {
            List<BO.Employee> results = new List<BO.Employee>();

            using (var db = DataAccess.TestDB())
            {
                results = db.Query<BO.Employee>("dbo.GetEmployees", param: new { employeeId }, commandType: CommandType.StoredProcedure).ToList();
            }

            return results;
        }
    }
}
