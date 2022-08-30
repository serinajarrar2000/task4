using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication64.internalinterface;

namespace WebApplication64.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class employeesController : ControllerBase
    {
        private interfacess _employeeRepo;

        public employeesController(interfacess employeeRepo)
        {
            _employeeRepo = employeeRepo;

        }

        [HttpGet]
        [Route("getEmployees")]
        public async Task<ActionResult<employee>> GetEmployee()
        {
            var emp = _employeeRepo.Get();
            return Ok(emp);
        }

        [HttpGet]
        [Route("getStudentById")]
        public async Task<ActionResult<employee>> GetEmployee(int Id)
        {
            var emp = _employeeRepo.GetId(Id)
;

            if (emp == null)
                return BadRequest("There is no employees found");

            return Ok(emp);
        }

        [HttpPost]
        [Route("addEmployee")]
        public async Task<ActionResult<employee>> AddEmployee(employee request)
        {
            var emp = _employeeRepo.Addemployee(request);
            return Ok(emp);
        }

        [HttpPut]
        [Route("updateEmployee")]
        public async Task<ActionResult<employee>> UpdateEmployee(employee request)
        {
            var emp = _employeeRepo.updateEmployee(request);

            if (emp == null)
                return BadRequest("There is no employees found");


            return Ok(emp);
        }


        [HttpDelete]
        [Route("deleteEmployee")]
        public async Task<ActionResult<employee>> DeleteEmployee(int Id)
        {
            var emp = _employeeRepo.Delete(Id)
;

            return Ok(emp);
        }


    }
}
