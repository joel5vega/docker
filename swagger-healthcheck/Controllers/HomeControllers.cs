using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace MyWebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet("config")]
        public IActionResult GetConfiguration()
        {
            var myCustomSetting = _configuration["MyCustomSetting"];
            return Ok($"My Custom Setting: {myCustomSetting}");
        }
    }
}