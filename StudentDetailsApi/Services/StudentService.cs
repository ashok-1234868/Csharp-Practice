using AutoMapper;
using StudentDetailsApi.DTO;
using StudentDetailsApi.Model;
using StudentDetailsApi.Repository;

namespace StudentDetailsApi.Services
{
    public class StudentService:IStudentService
    {
        private readonly IStudentRepository _repo;
        private readonly IMapper _mapper;
        public StudentService(IMapper mapper,IStudentRepository repo) 
        {
            _mapper = mapper;
            _repo=repo; 
        }
        public async Task<string> AddStudentAsync(StudentDto studentDto)
        {
            if (await _repo.ExistAsync(studentDto.RollNo))
                return $"RollNo {studentDto.RollNo} Already exists";
            var student = _mapper.Map<StudentTb>(studentDto);

            //Foriegn Key
            if (student.Address != null)
                foreach (var addr in student.Address)
                    addr.RollNo = student.RollNo;

            await _repo.AddAsync(student);
            await _repo.SaveChanges();

            return "Student created successfully with address";
        }
        public async Task<List<StudentDto>> GetAllAsync()
        {
            var students = await _repo.GetAsync();
            return _mapper.Map<List<StudentDto>>(students);
        }

    }
}
