using System.ComponentModel.DataAnnotations;

namespace AdvanceWebAPI.ModelEntity
{
    public class EmployeDetails
    {
        [Key]
        public int Id { get; set; }
        [Required]

        public string Name { get; set; }=null!;
        [Required]
        public string Email { get; set; }=null!;
        [Required]
        [MaxLength(10)]
        public string Phone { get; set; }=null!;    
        [Required]
        public string Address { get; set; }=null!;
        [Required]
        public string Department { get; set; }=null!;
        [Required]
        public string Designation { get; set; }=null!;
        [Required]
        public double Salary { get; set; } 
       
    }
}
