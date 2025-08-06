using EntireArchitectureDemo;
using EntireArchitectureDemo.DataAccessLayers;
using EntireArchitectureDemo.BusinesslayerOperations;
using EntireArchitectureDemo.Models;


namespace EntireArchitectureDemo
{
    internal class Program
    {

        static void Main(string[] args)
        {
            UserDetails u = new UserDetails();
            // This is a simple console application that collects user details and performs operations
            // Console.WriteLine("Hello, World!");
            Console.Write("Enter the your Name : ");
            u.Name = Console.ReadLine();
            Console.Write("Enter the your Email : ");
            u.Email = Console.ReadLine();
            Console.Write("Enter the your Password : ");
            u.Password = Console.ReadLine();
            Console.WriteLine("User Details Collected Successfully!");
            // Now we will perform operations using the collected user details
            DataAccesOperation dataAccess = new DataAccesOperation();
            Manipulations manipulations = new Manipulations();
            manipulations.Operations(u, dataAccess);


        }
    }
}
