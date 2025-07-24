using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.List
{
    public class Listclass
    {
        public static void checking()
        {
            List<string> listname = new List<string>();
            listname.Add("Anbu");
            listname.Add("Rangan");
            listname.Add("Mani");
            listname.Add("Imaiya");
            
        // Or Using below method....
        //{
        //    "Anbu",
        //    "Rangan",
        //    "Mani",
        //    "Imaiyan"  
        //};

            foreach (var names in listname)
            {
                Console.WriteLine(names);
            };

        }
    }
}
