
namespace ADOconectivity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Connection c=new Connection();
             Boolean q = true;
           while (q)
            {
                Console.WriteLine("1: DISPLAY");
                Console.WriteLine("2: INSERT");
                Console.Write("Select your choice :");
                int a = Convert.ToInt32(Console.ReadLine());
                if (a == 1)
                {
                    c.Display();
                }
                else if (a == 2)
                {
                    Console.Write("Enter the name : ");
                    string userName = Console.ReadLine();
                    Console.Write("Enter the age : ");
                    int age = Convert.ToInt32(Console.ReadLine());
                    c.Insert(userName, age);
                    c.Display();
                }
                else
                {
                    q=false;
                }

            }

        }
    }
}
