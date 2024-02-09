using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NZwalks.API.Controllers
{
    //https://localhost:portnumber/api/students
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        // GET: https://localhost:portnumber/api/students
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            string[] studentNames = new String[] { "hardik", "hiral", "tutu" };
            return Ok(studentNames);

        }
    }
}
