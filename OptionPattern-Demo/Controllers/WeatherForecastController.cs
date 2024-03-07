using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using OptionPattern_Demo.Models;

namespace OptionPattern_Demo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly SmtpConfiguration _smtpConfiguration;

        public WeatherForecastController(IOptions<SmtpConfiguration> smtpConfiguration)
        {
            _smtpConfiguration = smtpConfiguration.Value;
        }

        [HttpGet]
        public IActionResult GetEmailDetail()
        {
            return Ok(_smtpConfiguration.Domain);
        }
    }
}
