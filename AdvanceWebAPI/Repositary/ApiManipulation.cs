using AdvanceWebAPI.DbConnection;
using AdvanceWebAPI.ModelEntity;
using Microsoft.EntityFrameworkCore;

namespace AdvanceWebAPI.Repositary
{
    public class ApiManipulation : ApiFunctionalites
    {
        private readonly ApplicationDbConnection connection;
        public ApiManipulation(ApplicationDbConnection context)
        {
            connection = context;
        }

        public async Task<EmployeDetails> AddEmployeDetails(EmployeDetails employeDetails)
        {
            //BEFORE ADDING, YOU CAN PERFORM ANY VALIDATION OR BUSINESS LOGIC HERE
            if (employeDetails == null)
            {
                throw new ArgumentNullException(nameof(employeDetails), "EmployeDetails cannot be null");
            }
            else
            {
                await connection.EmployeDetails.AddAsync(employeDetails);
                await connection.SaveChangesAsync();
                return employeDetails;
            }
           

           
        }

        public Task<bool> DeleteEmployeDetails(int id)
        {
           var employeDetails = connection.EmployeDetails.Find(id);
            if (employeDetails == null)
            {
                throw new KeyNotFoundException($"Employe with ID {id} not found.");
            }
            connection.EmployeDetails.Remove(employeDetails);
            connection.SaveChangesAsync();
            return Task.FromResult(true);
        }

        public async Task<List<EmployeDetails>> GetAllEmployeDetails()
        {
            var details = await connection.EmployeDetails.ToListAsync();
            
            return details;
        }

        public Task<EmployeDetails> GetEmployeDetailsById(int id)
        {
            //show particular employe details by id
            var employeDetails = connection.EmployeDetails.FirstOrDefaultAsync(e => e.Id == id);
            if (employeDetails == null)
            {
                throw new KeyNotFoundException($"Employe with ID {id} not found.");
            }
            return employeDetails;
        }

        public Task<EmployeDetails> UpdateEmployeDetails(int id, EmployeDetails employeDetails)
        {
            throw new NotImplementedException();
        }
    }
}
