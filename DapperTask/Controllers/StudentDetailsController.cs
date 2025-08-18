using DapperTask.DTO;
using DapperTask.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DapperTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentDetailsController : ControllerBase
    {
        private readonly AllService Service;

        public StudentDetailsController(AllService allService)
        {
            Service=allService; 
        }







        [HttpPost("AddStudentWithAddress")]
        public async Task<IActionResult> Create([FromBody] StudentDTO studentDto)
        {
            if (studentDto == null)
            {
                return BadRequest("Student data is null");
            }
            await Service.AddStudentWithddressAsync(studentDto);
            return Ok(new {Message="Student Added Sucessfully !"});
        }






        [HttpGet("GetAllStudentsDetails")]
        public async Task<IActionResult> GetAllStudentsDetails()
        {
            var students = await Service.GetAllStudentsWithAddressAsync();
            if (students == null || !students.Any())
            {
                return NotFound(new {message="student not found"});
            }
            return Ok(students);
        }






        [HttpGet("GetStudentByIdDetails/{id}")]
        public async Task<IActionResult> GetStudentByIdDetails(int id)
        {
            var student = await Service.GetStudentByRollNoWithAddressAsync(id);
            if (student == null)
            {
                return NotFound($"Student with ID {id} not found");
            }
            return Ok(student);
        }






        [HttpPut("UpdateStudentWithAddress")]
        public async Task<IActionResult> UpdateStudentWithAddress([FromBody] StudentDTO studentDto)
        {
            if (studentDto == null)
            {
                return BadRequest("Student data is null");
            }
            var result = await Service.UpdateStudentWithAddressAsync(studentDto);
            if (!result)
            {
                return NotFound($"Student with ID {studentDto.RollNo} not found ..Please Update valid Student");
            }
            return Ok("Student updated successfully");
        }








        [HttpDelete("DeleteStudentWithAddress/{id}")]
        public async Task<IActionResult> DeleteStudentWithAddress(int id)
        {
            var result = await Service.DeleteStudentWithAddressAsync(id);
            if (!result)
            {
                return NotFound($"Student with ID {id} not found....Please give correct ID");
            }
            return Ok("Student deleted successfully");
        }






    }
}
