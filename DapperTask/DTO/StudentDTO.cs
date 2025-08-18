namespace DapperTask.DTO
{
    public class StudentDTO
    {
        public int RollNo { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string MobileNo { get; set; } = null!;
        public string DOB { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public List<AddressModelDTO> Address { get; set; }
    }
}
