using DapperTask.Models;

namespace DapperTask.Repositary
{
    public interface IStudentRepo
    {
        Task<IEnumerable<Students>> GetAllStudentsAsync();
        Task<Students> GetStudentByRollNoAsync(int rollNo);
        Task AddStudentAsync(Students student);
        Task<bool> UpdateStudentAsync(Students student);
        Task<bool> DeleteStudentAsync(int rollNo);
      
    }
}
