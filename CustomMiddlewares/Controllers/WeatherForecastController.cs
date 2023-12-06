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
            //throw new Exception("Test Hatasý");
            return "OK";
        }

        [HttpGet("Student")]
        public Student GetStudent()
        {
            return new Student() 
            {
                Fullname = "Muhammed Yücedað",
                Id = 1,
            };
        }

        [HttpPost("Student")]
        public String CreateStudent([FromBody] Student student)
        {
            return "Öðrenci oluþturudlu";
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public String Fullname { get; set; }
    }
}
