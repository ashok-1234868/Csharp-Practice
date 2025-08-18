using StudentDetailsApi.Model;
using System.ComponentModel.DataAnnotations;

namespace StudentDetailsApi.DTO
{
    public class AddressDto
    {
        [Required, MaxLength(100)]
        public string AddressType { get; set; }
        [Required, MaxLength(250)]
        public string Street { get; set; }
        [Required, MaxLength(100)]
        public string City { get; set; }
        [Required]
        public string pincode { get; set; }
        [Required, MaxLength(100)]
        public string State { get; set; }

    }
}
