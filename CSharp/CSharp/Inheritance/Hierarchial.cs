using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Inheritance
{
        public class Parent
        {
            public void parents()
            {
                Console.WriteLine("There are two Parents per each Child");
            }
        }

        public class Child1 :Parent
        {
            public void child_one()
            {
                Console.WriteLine("I am the First Child");
            }
        }

        public class Child2 :Parent
        {
            public void child_two()
            {
                Console.WriteLine("I am the Second Child");
            }
        }
    }

