using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using proyectotecnicotecano.Interfaces;

namespace proyectotecnicotecano.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public IEmployeeServices _employeeServices;
        public EmployeeController(IEmployeeServices employeeServices) 
        {
            _employeeServices = employeeServices;
        }

        [Route("GetEmployees")]
        [HttpGet]
        public IActionResult GetEmployees()
        {
            return Ok(_employeeServices.GetEmployees());
        }

        [Route("GetEmployee")]
        [HttpGet]
        public IActionResult GetEmployee(string dni)
        {
            return Ok(_employeeServices.GetEmployee(dni));
        }
    }
}