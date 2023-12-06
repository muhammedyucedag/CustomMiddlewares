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
            //throw new Exception("Test Hatas�");
            return "OK";
        }

        [HttpGet("Student")]
        public Student GetStudent()
        {
            return new Student() 
            {
                Fullname = "Muhammed Y�ceda�",
                Id = 1,
            };
        }

        [HttpPost("Student")]
        public String CreateStudent([FromBody] Student student)
        {
            return "��renci olu�turudlu";
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public String Fullname { get; set; }
    }
}
