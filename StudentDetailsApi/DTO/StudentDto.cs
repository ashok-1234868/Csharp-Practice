using System.ComponentModel.DataAnnotations;

namespace StudentDetailsApi.DTO
{
    public class StudentDto
    {
        [Required]
        public int RollNo { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public DateOnly DOB { get; set; }
        [Required, MaxLength(100)]
        public string Email { get; set; }
        [Required, MaxLength(100)]
        public string MobileNo { get; set; }

        [Required]
        public List<AddressDto> Address { get; set; }

    }
}
