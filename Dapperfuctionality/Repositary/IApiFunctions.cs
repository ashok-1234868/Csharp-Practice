using Dapperfuctionality.Models;

namespace Dapperfuctionality.Repositary
{
    public interface IApiFunctions
    {
        EmpolyeEntity GetEmployeeById(int id);

        List<EmpolyeEntity> GetAllEmployees();
        EmpolyeEntity AddEmployee(EmpolyeEntity employee);
        EmpolyeEntity Authendication(EmpolyeEntity employee);

        EmpolyeEntity UpdateEmployee(EmpolyeEntity employee);
        void DeleteEmployee(int id);

    }
}
