using EntityFrameWorkDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkDemo.DataMnipulation
{
   internal class Manipulation
    {
       // var con= new Dbconnections.ApplicationDbConnection();
        public void DisplayAllColleges()
        // display all college records
        {
            using (var context = new Dbconnections.ApplicationDbConnection())
            {
                var colleges = context.StudentDetails.ToList();
                Console.WriteLine("College Records:");
                foreach (var c in colleges)
                {
                    Console.WriteLine($"Id: {c.Id}, Name: {c.Name}, Location: {c.Location}, Department: {c.Department}, Phone: {c.Phone}, Email: {c.Email}");
                }
                Console.WriteLine("-------All college records retrieved successfully!-------");
            }
        }
        public void DisplayCollegeByName(string name)
        // display a particular college record by name
        {
            using (var context = new Dbconnections.ApplicationDbConnection())
            {
                var collegeRecord = context.StudentDetails.FirstOrDefault(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
                if (collegeRecord != null)
                {
                    Console.WriteLine($"Found College Record: Id: {collegeRecord.Id}, Name: {collegeRecord.Name}, Location: {collegeRecord.Location}, Department: {collegeRecord.Department}, Phone: {collegeRecord.Phone}, Email: {collegeRecord.Email}");
                }
                else
                {
                    Console.WriteLine("College record not found.");
                }
                Console.WriteLine("-------College record retrieved successfully!-------");
            }
        }
        public Boolean UpdateCollege(College college)
        {
            // validation
            if (college.Id < 0)
                throw new ArgumentException("Invalid college ID", nameof(college.Id));
            if (string.IsNullOrWhiteSpace(college.Name))
                throw new ArgumentException("Name cannot be null or empty", nameof(college.Name));
            if (string.IsNullOrWhiteSpace(college.Location))
                throw new ArgumentException("Location cannot be null or empty", nameof(college.Location));
            if (string.IsNullOrWhiteSpace(college.Department))
                throw new ArgumentException("Department cannot be null or empty", nameof(college.Department));
            if (string.IsNullOrWhiteSpace(college.Phone))
                throw new ArgumentException("Phone cannot be null or empty", nameof(college.Phone));
            if (string.IsNullOrWhiteSpace(college.Email))
                throw new ArgumentException("Email cannot be null or empty", nameof(college.Email));
            using (var context = new Dbconnections.ApplicationDbConnection())
            {
                context.StudentDetails.Update(college);
                context.SaveChanges();
                
            }
            Console.WriteLine("-------College record validated successfully!-------");
            return true;
        }
        public void DeleteCollege(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Invalid college ID", nameof(id));
            using (var context = new Dbconnections.ApplicationDbConnection())
            {
                var college = context.StudentDetails.Find(id);
                if (college != null)
                {
                    context.StudentDetails.Remove(college);
                    context.SaveChanges();
                }
                else
                {
                    Console.WriteLine("College record not found.");
                }
                Console.WriteLine("-------College record deleted successfully!-------");
            }
        }
        public void AddingNewData(College college)
        {
            // Add a new college record
            using (var context = new Dbconnections.ApplicationDbConnection())
            {
                context.StudentDetails.Add(college);
                context.SaveChanges();
            }
            Console.WriteLine("College record added successfully with validation!");
        }
       
    }
}
