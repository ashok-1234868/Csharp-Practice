using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class DictionaryOperation
    {
        public void Dict()
        {
            Dictionary<int, string> a = new Dictionary<int, string>();
           /* a.Add(1,"krishna");
            a.Add(2, "mani");
            a.Add(3, "anbu");*/

            foreach(var items in  a.Keys)
            {
                Console.WriteLine(items);
            }
        }
        public int Sum(int a,int b)
        {
            int c = a + b;
            return c;
        }
       
    }
}
