using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal interface Company
    {
        public string Name { get; set; }
        public string Role { get; set; }
        public int age  { get; set; }
        public string gender { get; set; }
        public int salary { get; set; }
        void PersonDetails();

    }
}
