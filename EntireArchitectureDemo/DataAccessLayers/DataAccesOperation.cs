using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntireArchitectureDemo.Models;

namespace EntireArchitectureDemo.DataAccessLayers
{
    internal class DataAccesOperation
    {
        public void SaveUserDetails(UserDetails u)
        {
            // Here you would typically save the user details to a database
            // For demonstration purposes, we'll just print them to the console
            Console.WriteLine("User Details Saved:");
            Console.WriteLine($"Name: {u.Name}");
            Console.WriteLine($"Email: {u.Email}");
            Console.WriteLine($"Password: {u.Password}");
        }
    }
}
