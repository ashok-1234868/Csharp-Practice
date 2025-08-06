using Microsoft.EntityFrameworkCore;
using AuthendicationAPIDemo.Models;
namespace AuthendicationAPIDemo.DbContextCoonections
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<UserAuthendication>UserTable { get; set; }
       
    }
}
