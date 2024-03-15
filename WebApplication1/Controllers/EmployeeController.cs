using Microsoft.AspNetCore.Mvc;
using WebApplication1.Repository.Interfaces;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public ActionResult GetEmployees()
        {
            var employees = _employeeRepository.GetEmployeeDetails();
            return View(employees);
        }
    }
}
