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

            try
            {
                throw new Exception("Test Hatasý");
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
            return "Ok";
        }
    }
}
