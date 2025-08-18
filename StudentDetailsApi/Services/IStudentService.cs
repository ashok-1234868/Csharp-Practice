using StudentDetailsApi.DTO;

namespace StudentDetailsApi.Services
{
    public interface IStudentService
    {
        Task<string> AddStudentAsync(StudentDto studentDto);
        Task<List<StudentDto>> GetAllAsync();
    }
}
