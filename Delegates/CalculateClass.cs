using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class CalculateClass
    {
        public static void Sum(int a, int b)
        {
            Console.WriteLine (a + b);
        }
        public static void Multiply(int a, int b)
        {
            Console.WriteLine( a * b);
        }
        public static void Sub(int a, int b)
        {
            Console.WriteLine( a-b);
        }
        public static void Divide(int a, int b)
        {
            Console.WriteLine( a/b);
        }
    }
}
