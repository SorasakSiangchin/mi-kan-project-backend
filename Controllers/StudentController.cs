


using Microsoft.AspNetCore.Mvc;

namespace mi_kan_project_backend.Controllers
{
    public class StudentController : BaseApiController
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Student>>> GetStudentAll()
        {
            var res = new ServiceResponse<List<Student>>();
            try
            {
              var reult = await _studentService.GetStudentAll();
              res.Data = reult;

              return Ok(reult);
            }
            catch (Exception e)
            {

                throw;
            }
        }


    }
}
