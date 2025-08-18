using Microsoft.EntityFrameworkCore;
using StudentDetailsApi.Data;
using StudentDetailsApi.DTO;
using StudentDetailsApi.Model;

namespace StudentDetailsApi.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly MyDbContext _context;
        public StudentRepository(MyDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(StudentTb student) =>
            await _context.StudentTb.AddAsync(student);

        public async Task<bool> ExistAsync(int RollNo) =>
            await _context.StudentTb.AnyAsync(s => s.RollNo == RollNo);

        public async Task SaveChanges() => 
            await _context.SaveChangesAsync();
        public async Task<List<StudentTb>> GetAsync()=>
            await _context.StudentTb.Include(s => s.Address).ToListAsync();

    }
}
