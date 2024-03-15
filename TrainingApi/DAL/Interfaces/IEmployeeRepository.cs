namespace TrainingApi.DAL.Interfaces
{
    public interface IEmployeeRepository
    {
        List<Employees> GetEmployeeDetails();
        bool AddEmployeeDetails(Employees details);
        bool UpdateEmployeeDetails(int id, Employees details);
        bool DeleteEmployeeDetails(int id);
    }
}
