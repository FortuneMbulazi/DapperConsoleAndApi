using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace TutorialApi.Controllers
{
    [Route("api/Employees")]
    [ApiController]
    public class Employees : ControllerBase
    {
        [HttpGet]
        public List<BO.Employee> GetEmployees(long employeeId)
        {
            BLL.Employees emp = new BLL.Employees();
            var employees = emp.GetEmployees(employeeId);

            return employees;
        }
    }
}
