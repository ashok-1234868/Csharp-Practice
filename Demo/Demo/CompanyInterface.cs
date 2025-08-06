using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class CompanyInterface : Company
    {

        string Name;
        public string Role { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        public int salary { get; set; }
        public CompanyInterface(string Name, string Role, int age, string gender, int salary)
        {
            this.Name = Name;
            this.Role = Role;
            this.age=age;
            this.gender=gender;
            this.salary=salary;
        }
       public void PersonDetails()
        {
            Console.WriteLine($"Name : {Name} \t  Role : {Role} \t Age : {age} \t  Gender : {gender } \t  Salary : {salary}");
        }
    }
}
