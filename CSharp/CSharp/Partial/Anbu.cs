using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    partial class Parentclass
    {
        public void details()
        {
            System.Console.WriteLine($"Name :{Name}");
            System.Console.WriteLine($"Age :{Age}");
            System.Console.WriteLine($"Address :{Address}");
            System.Console.WriteLine($"Gender :{Gender}");
        }

        internal void parent1()
        {
            throw new NotImplementedException();
        }
    }
}
