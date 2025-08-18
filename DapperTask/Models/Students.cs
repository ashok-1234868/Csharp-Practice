namespace DapperTask.Models
{
    public class Students
    {

        // Roll is a primary key of student table not auto incremented
        public int RollNo { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string MobileNo { get; set; } = null!;
        public string DOB { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public List<Addresses> Address { get; set; }
    }
}
