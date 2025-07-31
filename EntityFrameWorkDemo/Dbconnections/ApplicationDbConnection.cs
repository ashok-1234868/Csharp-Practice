using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using EntityFrameWorkDemo.Models;

namespace EntityFrameWorkDemo.Dbconnections
{
    internal  class ApplicationDbConnection : DbContext
    {
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-B8HHSVO\\SQLEXPRESS;Initial Catalog=CollegeDB;Persist Security Info=True;User ID=sa;Password=1234;TrustServerCertificate=True;");
        }
        public DbSet<College>StudentDetails{ get; set; }
    }
}
// This code defines an ApplicationDbConnection class that inherits from DbContext.