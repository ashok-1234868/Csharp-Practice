using System;
using System.Data;
using System.Data.SqlClient;
namespace DapperTask.DBConnection
{
    public class DbContext
    {
        public IConfiguration Configuration;
        public string ConnectionString;
        public DbContext(IConfiguration configuration)
        {
            Configuration = configuration;
            ConnectionString = Configuration.GetConnectionString("DefaultConnection");
        }
        public IDbConnection CreateConnection() => new SqlConnection(ConnectionString);


    }
}
