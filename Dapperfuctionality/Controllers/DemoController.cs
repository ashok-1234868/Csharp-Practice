using Dapperfuctionality.Models;
using Dapperfuctionality.Repositary;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dapperfuctionality.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        private readonly IApiFunctions _apiFunctions;
        public DemoController(IApiFunctions apiFunctions )
        {
            _apiFunctions = apiFunctions;
        }
        [HttpGet("GetEmployeeById/{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            var employee = _apiFunctions.GetEmployeeById(id);
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }
        [HttpGet("GetAllEmployees")]
        public IActionResult GetAllEmployees()
        {
            var employees = _apiFunctions.GetAllEmployees();
            if (employees == null || !employees.Any())
            {
                return NotFound();
            }
            return Ok(employees);
        }
        [HttpPost("AddEmployee")]
        public IActionResult AddEmployee([FromBody] EmpolyeEntity employee)
        {
            if (employee == null)
            {
                return BadRequest("Employee data is null");
            }
            var addedEmployee = _apiFunctions.AddEmployee(employee);
            return Ok(addedEmployee);
        }
        [HttpPut("UpdateEmployee")]
        public IActionResult UpdateEmployee([FromBody] EmpolyeEntity employee)
        {
            if (employee == null || employee.id <= 0)
            {
                return BadRequest("Invalid employee data");
            }
            var updatedEmployee = _apiFunctions.UpdateEmployee(employee);
            if (updatedEmployee == null)
            {
                return NotFound();
            }
            return Ok("Updated Sucessfully");
        }
        [HttpDelete("DeleteEmployee/{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Invalid employee ID");
            }
            var employee = _apiFunctions.GetEmployeeById(id);
            if (employee == null)
            {
                return NotFound();
            }
            _apiFunctions.DeleteEmployee(id);
            return Ok("Delete sucessfully");
        }
    }
}
