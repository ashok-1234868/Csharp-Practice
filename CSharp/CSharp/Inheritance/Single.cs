using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Inheritance
{
    public class Parentclass
    {
        public void parent()
        {
            Console.WriteLine("This is Parent Class");
        }
    }

    public class Childclass :Parentclass
    {
        public void child()
        {
            Console.WriteLine("This is Children Class");
        }
    }
}
