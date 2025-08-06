using Microsoft.EntityFrameworkCore;
using AdvanceWebAPI.ModelEntity;

namespace AdvanceWebAPI.DbConnection
{
    public class ApplicationDbConnection :DbContext
    {
        public ApplicationDbConnection(DbContextOptions<ApplicationDbConnection> options): base(options)
        {

        }


        public DbSet<EmployeDetails> EmployeDetails { get; set; } = null!;

    }
}
