using Application.Dto.CompanyDto;
using Application.Dto.Offer;
using Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace JobPortalAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService _companyService;
        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }
        [SwaggerOperation(Summary = "Pobierz wszystkie firmy.")]
        [HttpGet]
        public IActionResult Get()
        {
            var offers = _companyService.GetAllCompanies();
            return Ok(offers);
        }
        [SwaggerOperation(Summary = "Dodaj firmę.")]
        [HttpPost]
        public IActionResult Add(AddCompanyDto newCompany)
        {
            var company = _companyService.AddCompany(newCompany);
            return Created($"Company/{ company.CompanyId }", company);
        }
        [SwaggerOperation(Summary = "Usuń ofertę pracy.")]
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _companyService.DeleteCompany(id);
            return NoContent();
        }
    }
}
