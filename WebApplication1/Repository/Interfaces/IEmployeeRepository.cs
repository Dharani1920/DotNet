using WebApplication1.Models;

namespace WebApplication1.Repository.Interfaces
{
    public interface IEmployeeRepository
    {
        List<Employees> GetEmployeeDetails();
        bool AddEmployeeDetails(Employees details);
        bool UpdateEmployeeDetails(int id, Employees details);
        bool DeleteEmployeeDetails(int id);
    }
}
