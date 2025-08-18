using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentDetailsApi.Model
{
    public class StudentTb
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RollNo { get; set; }
        [Required,MaxLength(100)]
        public string Name { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public DateOnly DOB { get; set; }
        [Required, MaxLength(100)]
        public string Email { get; set; }
        [Required, MaxLength(100)]
        public string MobileNo { get; set; }

        public ICollection<AddressTb> Address { get; set; } = new List<AddressTb>();

    }
}
