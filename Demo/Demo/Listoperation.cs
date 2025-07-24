using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Listoperation
    {
        public void Helo()
        {
            List<string> list = new List<string>();
            list.Add("krishna");
            list.Add("Anbu");
            list.Add("Ashok");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
        
    }
}
