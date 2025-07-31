using EntityFrameWorkDemo.Models;
using EntityFrameWorkDemo.Dbconnections;
using EntityFrameWorkDemo.DataMnipulation;

namespace EntityFrameWorkDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean q=true;
            // Console.WriteLine("Hello, World!");
            College college = new College();
            Manipulation manipulation = new Manipulation();
            while(q)
            {
                Console.WriteLine("1: Adding New Data's ;");
                Console.WriteLine("2: Show Data's ;");
                Console.WriteLine("3: Particular Data's ;");
                Console.WriteLine("4: validate the Data's ;");
                Console.WriteLine("5: Delete particular with id Data's ;");
                Console.WriteLine("6: Exit ;");
                Console.Write("Enter your choice (1-6): ");
                int choice =Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                       
                        //manipulation.UpdateCollege(college);
                        while (choice == 1)
                        {
                            // user input for college details
                            Console.Write("Enter College Name:");
                            college.Name = Console.ReadLine();
                            Console.Write("Enter College Location:");
                            college.Location = Console.ReadLine();
                            Console.Write("Enter College Department:");
                            college.Department = Console.ReadLine();
                            Console.Write("Enter College Phone:");
                            college.Phone = Console.ReadLine();
                            Console.Write("Enter College Email:");
                            college.Email = Console.ReadLine();

                            if (string.IsNullOrWhiteSpace(college.Name) ||
                           string.IsNullOrWhiteSpace(college.Location) ||
                           string.IsNullOrWhiteSpace(college.Department) ||
                           string.IsNullOrWhiteSpace(college.Phone) ||
                           string.IsNullOrWhiteSpace(college.Email))
                            {
                                Console.WriteLine("Please fill all the fields.");
                                continue;
                            }
                            else
                            {
                                // Create a new instance of Manipulation class to add the college record
                                manipulation.AddingNewData(college);
                                manipulation.UpdateCollege(college);
                                break;

                                //Console.WriteLine("College record added successfully!");
                            }
                        }
                        
                        break;
                    case 2:
                        //Manipulation manipulation = new Manipulation();
                        manipulation.DisplayAllColleges();
                        break;
                    case 3:
                        Console.Write("Enter the name to search: ");
                        string name = Console.ReadLine();
                        manipulation.DisplayCollegeByName(name);
                        break;
                    case 4:
                        // Update logic can be implemented here
                        manipulation.UpdateCollege(college);
                        break;
                    case 5:
                        // Delete logic can be implemented here
                        Console.Write("Enter the ID of the college to delete: ");
                        int idToDelete = Convert.ToInt32(Console.ReadLine());

                        manipulation.DeleteCollege(idToDelete);
                        break;
                    case 6:
                        Console.WriteLine("Exiting the application.");
                        q = false;
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            
            // Create a new instance of Manipulation class to add the college record
     

            // Create a new instance of ApplicationDbConnection and add the college record
            //using (var context = new Dbconnections.ApplicationDbConnection())
            //  {
            //    context.StudentDetails.Add(college);
            //    context.SaveChanges();
            //  }
            ////display a message indicating that the record has been added
            //Console.WriteLine("College record added successfully!");


            ////DPLAY THE COLLEGE RECORDS
            //using (var context = new Dbconnections.ApplicationDbConnection())
            //{
            //    var colleges = context.StudentDetails.ToList();
            //    Console.WriteLine("College Records:");
            //    foreach (var c in colleges)
            //    {
            //        Console.WriteLine($"Id: {c.Id}, Name: {c.Name}, Location: {c.Location}, Department: {c.Department}, Phone: {c.Phone}, Email: {c.Email}");
            //    }
            //}
            //// Display a message indicating that the records have been retrieved
            //Console.WriteLine("College records retrieved successfully!");

            ////particular the college records
            //using (var context = new Dbconnections.ApplicationDbConnection())
            //{
            //    var collegeRecord = context.StudentDetails.FirstOrDefault(c => c.Name == "krishna");
            //    if (collegeRecord != null)
            //    {
            //        Console.WriteLine($"Found College Record: Id: {collegeRecord.Id}, Name: {collegeRecord.Name}, Location: {collegeRecord.Location}, Department: {collegeRecord.Department}, Phone: {collegeRecord.Phone}, Email: {collegeRecord.Email}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("College record not found.");
            //    }
            //}


        }
    }
}
// This code defines a simple console application that adds a new college record to the database using Entity Framework Core.