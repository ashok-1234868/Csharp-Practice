using AdvanceWebAPI.DTO;
using AdvanceWebAPI.ModelEntity;
using AdvanceWebAPI.Repositary;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AdvanceWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoFunctionalityController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ApiFunctionalites acess;
        public DemoFunctionalityController(IMapper mapper, ApiFunctionalites manipulation )
        {

            _mapper = mapper;
            acess = manipulation;

        }
        // GET: api/DemoFunctionality
        [HttpGet("show")]
        public async Task<IActionResult> Get()
        {
            var response = await acess.GetAllEmployeDetails();
                return Ok(response);
        }
        // POST: api/DemoFunctionality
        [HttpPost("values")]
        public async Task<IActionResult> Post([FromBody] DummyDTO dTO)
        {
           var employee = _mapper.Map<EmployeDetails>(dTO);
           var createdEmployee = await acess.AddEmployeDetails(employee);

            return Ok(createdEmployee);
        }
        // PUT: api/DemoFunctionality/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] object value)
        {
            var data=acess.GetEmployeDetailsById(id);
            return Ok(data);
        }
        // DELETE: api/DemoFunctionality/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var isDeleted = acess.DeleteEmployeDetails(id);
            return Ok(new { message = "data deleted successfully!" });
        }
        // Additional methods can be added here as needed

    }
}
