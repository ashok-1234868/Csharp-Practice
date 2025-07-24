using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Inheritance
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace CSharp.Inheritance
    {
        public class Parent1
        {
            public void dad()
            {
                string Dadname = "Raja";
                Console.WriteLine($"Dad Name is {Dadname}");
            }
        }

        public class Parent2:Parent1
        {
            public void mom()
            {
                String Momname = "Vennila";
                Console.WriteLine($"Mom Name is {Momname}");
            }
        }

        public class Child : Parent2 
        {
            public void children()
            {
                String Name = "Anbu";
                Console.WriteLine($"My Name is {Name}");
            }
        }
    }
}
