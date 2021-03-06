using EmployeeManagement_Business;
using EmployeeManagement_Repository;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace EmployeeManagement_Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : Controller
    {
        private readonly EmployeeBuisness employeeBusiness;

        public EmployeeController()
        {
            employeeBusiness = new EmployeeBuisness();
        }

        [HttpGet("GetAllEmployee")]
        public async Task<List<Employee>> GetAllEmployee()
        {
             return await employeeBusiness.GetAllEmployeesAsync();
        }
    }
}
