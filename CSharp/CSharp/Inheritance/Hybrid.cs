using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Inheritance
{
    public class Parents
    {
        public void parent()
        {
            Console.WriteLine("Parent Class");
        }
    }

    public class Children1:Parent
    {
        public void child1()
        {
            Console.WriteLine("I am the Child One");
        }
    }
    
    public class Children2:Parent
    {
        public void child2()
        {
            Console.WriteLine("I am the Child Second ");
        }

    }

    public  class Subchildren:Children1
    {
        public void subchild()
        {
            Console.WriteLine("I am the SubChildren from the Children1 ");
        }
    }

}
