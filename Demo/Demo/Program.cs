namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Listoperation a = new Listoperation();
            // a.Helo();
            DictionaryOperation d=new DictionaryOperation();
            //d.Dict();
            //int a= d.Sum(2, 4);
            //Console.WriteLine(a);

            // delegate method object creation 

            /*  Calculations c=new Calculations(DelegateOperation.Sum);
              c = c + DelegateOperation.Sub;
              c = c + DelegateOperation.Mul;
              c = c + DelegateOperation.Div;
              c(20, 10);*/

            /*  Justdemo j=new Justdemo(10,"krishna");
              //j.Krishna(10,"krishna");
              j.Display();
            */
        string Name;
        string Role;
        int age=0;
        string gender;
        int salary;
            Console.WriteLine("Enter the Name: ");
            Name = Console.ReadLine();

            Console.WriteLine("Enter the Role on that company : ");
            Role = Console.ReadLine();

          try
            {
                Console.WriteLine("Enter you age : ");
                //age =int.Parse(Console.ReadLine());
                age = Convert.ToInt32(Console.ReadLine());

            }
            catch (FormatException e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("Enter the Gender : ");
            gender = Console.ReadLine();

            Console.WriteLine("Enter the Salary:  ");
            salary= Convert.ToInt32(Console.ReadLine());


            CompanyInterface c = new CompanyInterface(Name,Role,age,gender,salary);
            c.PersonDetails();
        }
    }
} 
