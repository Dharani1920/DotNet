using Microsoft.AspNetCore.Mvc;
using TrainingApi.DAL.Interfaces;

namespace TrainingApi.Controllers
{

    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmpEFController : ControllerBase
    {

        private AppDbContext appDb;

        public EmpEFController(AppDbContext _appDb)
        {
            appDb = _appDb;
        }

        [HttpGet(Name = "GetEmplFromEF")]
        public IActionResult GetEmployeeEF()
        {
            var res = appDb.E_Details.ToList();
            return Ok(res);
        }

        [HttpGet(Name = "GetPositionDetails")]
        public IActionResult GetEmployeePosition(int id) {
            var details = appDb.E_Details.ToList();
            var pos = appDb.E_Position.ToList();
            var name = from d in details where d.EmpId == id select d.EmpName;
            var position = from p in pos where p.EmpId == id select p.Position;
            var res = new { name, position };
            return Ok(res);
        }

        [HttpPost(Name = "AddEmplFromEF")]
        public IActionResult AddEmployeeEF(Employees Emp)
        {
            appDb.E_Details.Add(new EmployeeWF() { EmpId = Emp.EmpId, EmpName = Emp.EmpName, Experience = Emp.Experience });
            appDb.SaveChanges();
            return Ok("Success");
        }

        [HttpPost(Name = "RemoveEmplFromEF")]
        public IActionResult RemoveEmployeeEF(Employees Emp)
        {
            appDb.E_Details.Remove(new EmployeeWF() { EmpId = Emp.EmpId, EmpName = Emp.EmpName, Experience = Emp.Experience });
            appDb.SaveChanges();
            return Ok("Success");
        }
    }
}
