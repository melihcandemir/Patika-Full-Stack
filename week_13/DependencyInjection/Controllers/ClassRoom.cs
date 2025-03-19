using DependencyInjection.Services;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClassRoom : ControllerBase
    {
        private readonly ITeacher _teacher;

        public ClassRoom(ITeacher teacher)
        {
            _teacher = teacher;
        }

        [HttpGet]
        public IActionResult GetTeacherInfo(string firstName, string lastName)
        {
            return Ok(_teacher.GetInfo(firstName, lastName));
        }
    }
}