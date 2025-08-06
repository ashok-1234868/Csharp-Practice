using EntireArchitectureDemo.DataAccessLayers;
using EntireArchitectureDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntireArchitectureDemo.BusinesslayerOperations
{
    internal class Manipulations
    {
        public void Operations(UserDetails u, DataAccesOperation dataAccess)
        {
            // Here you would typically perform business logic operations
            // For demonstration purposes, we'll just print a message to the console
            Console.WriteLine("Performing business logic operations...");
            // Example of a business logic operation
            if (!string.IsNullOrEmpty(u.Name) && !string.IsNullOrEmpty(u.Email))
            {

                dataAccess.SaveUserDetails(u);
            }
            else
            {
                Console.WriteLine("Invalid user details. Please provide valid Name and Email.");
            }

        }
    }
}
