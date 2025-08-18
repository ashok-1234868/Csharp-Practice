using System.ComponentModel.DataAnnotations;

namespace StudentDetailsApi.Model
{
    public class AddressTb
    {
        [Key]
        public int Id { get; set; }
        [Required,MaxLength(100)]
        public string AddressType { get; set; }
        [Required,MaxLength(250)]  
        public string Street { get; set; }
        [Required,MaxLength(100)]
        public string City { get; set; }
        [Required]
        public string pincode { get; set; }
        [Required,MaxLength(100)]
        public string State { get; set; } 
        
        public int RollNo { get; set; }
        public StudentTb Studentobj { get; set; }


    }
}
