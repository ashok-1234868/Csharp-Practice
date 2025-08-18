using AutoMapper;
using DapperTask.DTO;
using DapperTask.Models;
using DapperTask.Repositary;

namespace DapperTask.Services
{
    public class AllService
    {
        private readonly IMapper _mapper;
        private readonly IStudentRepo _studentRepo;
        public AllService(IMapper mapper,IStudentRepo studentRepo)
        {
            _mapper = mapper;
            _studentRepo = studentRepo;
        }

        // Get All Students with Address
        public async Task<IEnumerable<StudentDTO>> GetAllStudentsWithAddressAsync()
        {
            var students = await _studentRepo.GetAllStudentsAsync();
            return _mapper.Map<IEnumerable<StudentDTO>>(students);
        }

        // Get Student by RollNo with Address

        public async Task<StudentDTO> GetStudentByRollNoWithAddressAsync(int rollNo)
        {
            var student = await _studentRepo.GetStudentByRollNoAsync(rollNo);
            return _mapper.Map<StudentDTO>(student);
        }


        //ADD Student with Address

        public async Task AddStudentWithddressAsync(StudentDTO studentDto)
        {
            var student = _mapper.Map<Students>(studentDto);
            await _studentRepo.AddStudentAsync(student);
        }


        // Update Student with Address

        public async Task<bool> UpdateStudentWithAddressAsync(StudentDTO studentDto)
        {
            var student = _mapper.Map<Students>(studentDto);
           var suma= await _studentRepo.UpdateStudentAsync(student);
            return suma;

        }


        // Delete Student with Address

        public async Task<bool> DeleteStudentWithAddressAsync(int rollNo)
        {
            return await _studentRepo.DeleteStudentAsync(rollNo);
        }

    }
}
