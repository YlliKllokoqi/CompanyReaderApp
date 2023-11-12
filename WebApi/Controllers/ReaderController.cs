using CompanyReader.Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CompanyReader.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReaderController : ControllerBase
    {
        private readonly ICompanyService companyService;
        private readonly IProcessService processService;

        public ReaderController(ICompanyService companyService, IProcessService processService)
        {
            this.companyService = companyService;
            this.processService = processService;
        }

        [HttpPost("create")]
        [Consumes("multipart/form-data")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult CreateCompaniesFromCsv(IFormFile file)
        {
            try
            {
                var companyDtos = processService.ProcessCsv(file);

                foreach (var companyDto in companyDtos)
                {
                    companyService.CreateRecord(companyDto);
                }

                return Ok("Company Record created successfully!");
            }
            catch (Exception ex)
            {

                return StatusCode(500, "Something went wrong!");
            }
        }
    }
}
