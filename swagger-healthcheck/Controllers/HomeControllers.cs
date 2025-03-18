using Microsoft.AspNetCore.Mvc;

namespace MyWebApp.Controllers
{
    [ApiController] // Important for API behaviors
    [Route("[controller]")] // This will make the base route '/Home'
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello from my Web API!");
        }
    }
}