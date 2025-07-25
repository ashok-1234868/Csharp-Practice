using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// compile time 

namespace CSharp.Polymorphism
{
    public class A
    {
        public string name { get; set; }

        public string address { get; set; }
        public int age  { get; set; }
        public int a { get; set; }
        public int b { get; set; }
    }
        public class Overloading:A
        {
            public void Sample(int a, int b)
            {
                int c = a + b;
                Console.WriteLine(c);
            }
            public void Sample()
            {
                Console.WriteLine("Nothing in the Function");
            }
            public void Sample(string name, int age)
            {
                Console.WriteLine($"Name:{name},Age:{age}");
            }

            public void Sample(String name, string address)
            {
                Console.WriteLine($"Name:{name},Address:{address}");
            }
        }
    }

