using StudentDetailsApi.DTO;
using StudentDetailsApi.Model;

namespace StudentDetailsApi.Repository
{
    public interface IStudentRepository
    {
        Task AddAsync(StudentTb student);
        Task<bool> ExistAsync(int RollNo);
        Task SaveChanges();
        Task<List<StudentTb>> GetAsync();
    }
}
