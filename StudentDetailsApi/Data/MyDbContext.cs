using Microsoft.EntityFrameworkCore;
using StudentDetailsApi.Model;

namespace StudentDetailsApi.Data
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options):base(options)
        {
            
        }
        public DbSet<StudentTb> StudentTb { get; set; } 
        public DbSet<AddressTb> AddressTb { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AddressTb>()
                .HasOne(a => a.Studentobj)
                .WithMany(s => s.Address)
                .HasForeignKey(a => a.RollNo);

            base.OnModelCreating(modelBuilder);
        }

    }
}

