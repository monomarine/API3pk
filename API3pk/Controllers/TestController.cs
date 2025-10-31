using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API3pk.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly ILogger _logger;
        private List<Student> students = new()
        {
            new Student{Id = 1, Name ="Иванов Иван", AverageMark = 3.5 },
            new Student{Id = 2, Name ="Петров Петр", AverageMark = 4.6 },
            new Student{Id = 3, Name ="Сергеев Сергей", AverageMark = 4.9 },
        };

        public TestController(ILogger<TestController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return students;
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public double AverageMark { get; set; }
    }
}
