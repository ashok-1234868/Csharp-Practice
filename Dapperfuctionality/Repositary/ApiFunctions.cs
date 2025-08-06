using Dapper;
using Dapperfuctionality.Models;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace Dapperfuctionality.Repositary
{
    public class ApiFunctions : IApiFunctions
    {
        private readonly IConfiguration _configuration;
        public ApiFunctions(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        private IDbConnection _dbConnection=>
            new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));


        public EmpolyeEntity AddEmployee(EmpolyeEntity employee)
        {
            var query = "INSERT INTO Details (Name, Email,Age, Salary) VALUES (@Name, @Email, @Age, @Salary);" +
                        "SELECT * FROM Details WHERE Email = @Email;";
            var emp = _dbConnection.Query<EmpolyeEntity>(query, new
            {
                @Name = employee.Name,
                @Email = employee.Email,
                @Age = employee.Age,
                @Salary = employee.Salary
            }).SingleOrDefault();
            return emp;


        }

        public EmpolyeEntity Authendication(EmpolyeEntity employee)
        {
            throw new NotImplementedException();
        }

        public void DeleteEmployee(int id)
        {
            var query = "DELETE FROM Details WHERE id = @Id";
            _dbConnection.Execute(query, new { Id = id });

        }

        public List<EmpolyeEntity> GetAllEmployees()
        {
            var query = "SELECT * FROM Details";
            var employees = _dbConnection.Query<EmpolyeEntity>(query).ToList();
            return employees;
        }

        public EmpolyeEntity GetEmployeeById(int id)
        {
            var query = "SELECT * FROM Details WHERE id = @Id";
            var employee = _dbConnection.Query<EmpolyeEntity>(query, new { Id = id }).SingleOrDefault();
            return employee;
        }

        public EmpolyeEntity UpdateEmployee(EmpolyeEntity employee)
        {
            var query = "UPDATE Details SET Name = @Name, Email = @Email, Age = @Age, Salary = @Salary WHERE id = @Id;" +
                        "SELECT * FROM Details WHERE id = @Id;";
            var updatedEmployee = _dbConnection.Query<EmpolyeEntity>(query, new
            {
                @Id = employee.id,
                @Name = employee.Name,
                @Email = employee.Email,
                @Age = employee.Age,
                @Salary = employee.Salary
            }).SingleOrDefault();
            return updatedEmployee;
        }
    }
}
