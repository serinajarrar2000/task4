using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication64.internalinterface;
namespace WebApplication64.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CompanyController : ControllerBase
    {
        private Interface2 _companyRepo;

        public CompanyController(Interface2 companyRepo)
        {
            _companyRepo = companyRepo;

        }
        [HttpGet]
        [Route("getComapny")]
        public async Task<ActionResult<company>> GetCompany()
        {
            var comp = _companyRepo.Get();
            return Ok(comp);
        }

        [HttpGet]
        [Route("getCompanyById")]
        public async Task<ActionResult<company>> GetEmployee(int Id)
        {
            var emp = _companyRepo.GetId(Id)
;

            if (emp == null)
                return BadRequest("There is no employees found");

            return Ok(emp);
        }

        [HttpPost]
        [Route("addCompany")]
        public async Task<ActionResult<company>> AddEmployee(company request)
        {
            var emp = _companyRepo.Addemployee(request);
            return Ok(emp);
        }

        [HttpPut]
        [Route("updateCompany")]
        public async Task<ActionResult<company>> UpdateCompany(company request)
        {
            var emp = _companyRepo.updateEmployee(request);

            if (emp == null)
                return BadRequest("There is no employees found");


            return Ok(emp);
        }


        [HttpDelete]
        [Route("deleteCompany")]
        public async Task<ActionResult<company>> DeleteCompany(int Id)
        {
            var emp = _companyRepo.Delete(Id)
;

            return Ok(emp);
        }


    }
}

