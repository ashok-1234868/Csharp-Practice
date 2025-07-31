using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameWorkDemo.Models
{
    internal class College
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

       public string Department { get; set; }
        public string Phone { get; set; }
        [Required]
        public string Email { get; set; }
        // Navigation property for related students
       
    }
}
