using Microsoft.AspNetCore.Mvc;
using PhoneNumberAssessment.Services;

namespace PhoneNumberAssessment.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountryController : ControllerBase
    {
        private readonly CountryService _countryService;

        public CountryController(CountryService countryService)
        {
            _countryService = countryService;
        }

        [HttpGet("{phoneNumber}")]
        public IActionResult GetCountryByPhoneNumber(string phoneNumber)
        {
            var result = _countryService.GetCountryByPhoneNumber(phoneNumber);
            if (result == null)
                return NotFound("Country not found");

            return Ok(result);
        }
    }
}
