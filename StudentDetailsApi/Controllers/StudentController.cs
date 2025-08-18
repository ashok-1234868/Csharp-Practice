using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentDetailsApi.DTO;
using StudentDetailsApi.Services;

namespace StudentDetailsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _service;
        public StudentController(IStudentService service)
        {
            _service = service;
        }

        [HttpPost("add")]
        public async Task<IActionResult> Create([FromBody] StudentDto studentDto)
        {
            if (!ModelState.IsValid) return ValidationProblem(ModelState);

            var msg = await _service.AddStudentAsync(studentDto);
            if (msg.StartsWith("RollNo")) return Conflict(new { message = msg });
            return Created($"/api/add{studentDto.RollNo}", new { message = msg });
        }

        [HttpGet("getAll")]
        public async Task<IActionResult> GetAll()
        {
            var students = await _service.GetAllAsync();
            return Ok(students);
        }
    }
}
