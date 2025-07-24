using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    // Decleared delegate method outside the class"

    delegate  void Calculations(int a,int b);
    internal class DelegateOperation
    {
        public  static void Sum(int a,int b)
        {
            Console.WriteLine("The sum of two numbers : " + a + b);
        }
        public static void Sub(int a, int b)
        {
            Console.WriteLine("The Subtraction of two numbers : " + (a - b));
        }
        public static void Mul(int a, int b)
        {
            Console.WriteLine("The Multiplication  of two numbers : " + a * b);
        }
        public static void Div(int a, int b)
        {
            Console.WriteLine("The Division of two numbers : " + a / b);
        }
    }
}
