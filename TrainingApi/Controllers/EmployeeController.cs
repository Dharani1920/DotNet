//using Microsoft.AspNetCore.Mvc;

//namespace TrainingApi.Controllers
//{
//    [Route("api/[controller]/[action]")]
//    [ApiController]
//    public class EmployeeController : ControllerBase
//    {
//        public static List<Employees> employees = new List<Employees>();
//        public EmployeeController() 
//        {
//        }
//        private List<Employees> GetEmployees()
//        {
//            employees.Add(new Employees() { EmpId = 1, EmpName = "Dharani", Experience = 2.5 });
//            employees.Add(new Employees() { EmpId = 2, EmpName = "Sourabh", Experience = 4.5 });
//            employees.Add(new Employees() { EmpId = 3, EmpName = "Mani", Experience = 5.5 });
//            employees.Add(new Employees() { EmpId = 4, EmpName = "Jalaj", Experience = 2 });

//            return employees;
//        }

//        [HttpGet(Name = "getEmployees")]
//        public IActionResult GetAllEmployees()
//        {
//            if (employees.Count == 0)
//            {
//                return Ok(GetEmployees());
//            }
//            else
//            {
//                return Ok(employees);
//            }
//        }

//        [HttpPost(Name = "addEmployees")]
//        public IActionResult AddEmployees(Employees newEmployee)
//        {
//            employees.Add(newEmployee);

//            return Ok(employees);
//        }
        
//        [HttpDelete(Name = "removeEmployees")]
//        public IActionResult RemoveEmployees(int id)
//        {
//            var empToRemove = employees.FirstOrDefault(e => e.EmpId == id);
//            if (empToRemove == null)
//            {
//                return NotFound("Id not found");
//            }
//                employees.Remove(empToRemove);
//                return Ok(employees);
//        }

//        [HttpPut(Name = "updateEmployees")]
//        public IActionResult UpdateEmployees(int id, Employees updateEmployee)
//        {
//            var empToUpdate = employees.FirstOrDefault(e => e.EmpId == id);
//            if (empToUpdate == null)
//            {
//                return NotFound("Id not found");
//            }
//            foreach (var item in employees)
//            {
//                if(item.EmpId == id)
//                {
//                    item.EmpName = updateEmployee.EmpName;
//                    item.Experience = updateEmployee.Experience;
//                }
//            }
//            return Ok(employees);
//        }


//        //public IEnumerable<Employees> Get()
//        //{
//        //    var employees = GetEmployees();
//        //    return employees;
//        //}
//    }
//}
