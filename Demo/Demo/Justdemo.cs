using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{

    public class Justdemo 
    {
        public int age { get; set; }
        public string name { get; set; }

        public void Display()
        {
            Console.WriteLine(name +" "+age);
        }
        public Justdemo(int age,string name)
        {
            this.name = name;
            this.age = age;
        }
    }
}
