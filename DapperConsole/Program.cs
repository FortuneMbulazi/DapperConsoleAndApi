using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DapperConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employee = new List<Employee>();
            Console.WriteLine("Please enter the EmployeeId...");
            long employeeId = Convert.ToInt64(Console.ReadLine());

            using (var db = DapperConnection.TestDB())
            {
                employee = db.Query<Employee>("dbo.GetEmployees", param: new { employeeId }, commandType: CommandType.StoredProcedure).ToList();
            }

            foreach (var emp in employee)
            {
                Console.WriteLine($"Employee Name = {emp.Name} & Employye Surname = {emp.Surname}");
            }
        }

        public class Employee
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public string ID_Number { get; set; }
            public string PhoneNumber { get; set; }
            public string Email { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public int DepartmentID { get; set; }
            public int ManagerID { get; set; }
        }
    }
}
