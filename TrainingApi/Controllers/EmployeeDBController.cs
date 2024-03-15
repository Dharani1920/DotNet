using Microsoft.AspNetCore.Mvc;
using TrainingApi.DAL.Interfaces;

namespace TrainingApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeDBController : ControllerBase
    {
        public static List<Employees> employees = new List<Employees>();

        private IEmployeeRepository _employeeRepository;

        public EmployeeDBController(IEmployeeRepository repository, AppDbContext _appDb) {
        
            _employeeRepository = repository;
        }


        [HttpGet(Name = "getEmployeesFromDb")]
        public List<Employees> GetEmployeesFromDB()
        {
            employees = _employeeRepository.GetEmployeeDetails();
            return employees;
        }

        [HttpPost(Name = "addEmployeesFromDB")]
        public IActionResult AddEmployeesFromDB(Employees newEmployee)
        {
           bool status = _employeeRepository.AddEmployeeDetails(newEmployee);
            if (status)
            {
                return Ok("Added");
            }
            return NotFound("Could not add");
        }

        [HttpPut(Name = "updateEmployeesFromDB")]
        public IActionResult UpdateEmployeesFromDB(int id, Employees updateEmp)
        {
           bool status = _employeeRepository.UpdateEmployeeDetails(id, updateEmp);
            if (status)
            {
                return Ok("Updated");
            }
            return NotFound("Could not update");
        }

        [HttpPut(Name = "deleteEmployeesFromDB")]
        public IActionResult DeleteEmployeesFromDB(int id)
        {
            bool status = _employeeRepository.DeleteEmployeeDetails(id);
            if (status)
            {
                return Ok("Deleted");
            }
            return NotFound("Could not delete");
        }

    }
}
