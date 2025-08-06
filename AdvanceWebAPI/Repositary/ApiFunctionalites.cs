using AdvanceWebAPI.ModelEntity;

namespace AdvanceWebAPI.Repositary
{
    public interface ApiFunctionalites
    {
        Task<List<EmployeDetails>> GetAllEmployeDetails();
        Task<EmployeDetails> GetEmployeDetailsById(int id);
        Task<EmployeDetails> AddEmployeDetails(EmployeDetails employeDetails);
        Task<EmployeDetails> UpdateEmployeDetails(int id, EmployeDetails employeDetails);
        Task<bool> DeleteEmployeDetails(int id);
    }
}
