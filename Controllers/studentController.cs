
using dotnetreact.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebApiMongoDB.Controllers{

[Route("api/student")]
[ApiController]
public class StudentController : ControllerBase
{

private readonly StudentServices _studentServices;

public StudentController(StudentServices studentServices)
{
    _studentServices = studentServices;
}

   //GET: api/student
    [HttpGet]
    public async Task<List<Student>> Get() => await _studentServices.GetAllStudents();
    

    // GET: api/student/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // POST: api/student
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }


}
}