using Microsoft.AspNetCore.Mvc;

namespace CustomMiddlewares.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        public String Get()
        {
            throw new Exception("Test Hatas�");
            return "OK";
        }
    }
}
