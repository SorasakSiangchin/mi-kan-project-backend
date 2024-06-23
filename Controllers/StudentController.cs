
using AutoMapper;
using mi_kan_project_backend.RequestHelpers;
using Microsoft.AspNetCore.Mvc;

namespace mi_kan_project_backend.Controllers
{
    public class StudentController : BaseApiController
    {
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;

        public StudentController(
            IStudentService studentService ,
            IMapper mapper)
        {
            _studentService = studentService;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<ActionResult<List<StudentDto>>> GetStudentAll(string? schoolId)
        {
            var response = new ServiceResponse<List<StudentDto>>();
            try
            {

              var reult = await _studentService
                    .GetStudentAll(schoolId);

                response.Data = reult;

              return Ok(response);
            }
            catch (Exception e)
            {
                response.Message = e.Message;
                response.Success = false;
                return BadRequest(response);
            }
        }


        [HttpPost("[action]")]
        public async Task<ActionResult<ServiceResponse<Student>>> CreateStudent([FromForm] CreateStudentDto dto)
        {
            var response = new ServiceResponse<Student>();
            try
            {
                (string errorMessage, string imageName) =  
                    await _studentService.UploadImage(dto.ImageFiles);

                if (!string.IsNullOrEmpty(errorMessage))
                {
                    response.Success = false;
                    response.Message = errorMessage;
                    return BadRequest(response);
                }

                var student = _mapper.Map<Student>(dto);
                student.ImageUrl = imageName;

                

                await _studentService.Create(student);

                response.Data = student;

                return Ok(response);
            }
            catch (Exception e)
            {
                response.Message = e.Message;
                response.Success = false;
                return BadRequest(response);
            }
        }

        [HttpPost("[action]")]
        public async Task<ActionResult<ServiceResponse<List<StudentDto>>>> GetStudents(StudentParams studentParams)
        {
            var response = new ServiceResponse<List<StudentDto>>();
            try
            {

                var result = await _studentService.GetStudents(studentParams);
          
                response.Data = result;

                return Ok(response);
            }
            catch (Exception e)
            {
                response.Message = e.Message;
                response.Success = false;
                return BadRequest(response);
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<StudentDto>>> GetStudentById(string id)
        {
            var response = new ServiceResponse<StudentDto>();
            try
            {

                var result = await _studentService.GetStudentById(id);

                response.Data = result;

                return Ok(response);
            }
            catch (Exception e)
            {
                response.Message = e.Message;
                response.Success = false;
                return BadRequest(response);
            }
        }



        [HttpPost("[action]")]
        public async Task<ActionResult<ServiceResponse<Student>>> UpdateStudent([FromForm] UpdateStudentDto dto)
        {
            var response = new ServiceResponse<Student>();
            try
            {
                var result = await _studentService.GetStudent(dto.Id);
                if(result == null) 
                { 
                    response.Message = "ไม่มีข้อมูลของนักเรียน";
                    response.Success = false;
                    return NotFound(response);
                }

                (string errorMessage, string imageName) =
                    await _studentService.UploadImage(dto.ImageFiles);

                if (!string.IsNullOrEmpty(errorMessage))
                {
                    response.Success = false;
                    response.Message = errorMessage;
                    return BadRequest(response);
                }

                var student = _mapper.Map(dto , result);

                if (!string.IsNullOrEmpty(imageName))
                {
                    await _studentService.DeleteImage(result.ImageUrl);
                    student.ImageUrl= imageName;
                }
                else
                {
                    student.ImageUrl = result.ImageUrl;
                }

                //student.Id = Guid.Parse(dto.Id);

                await _studentService.Update(student);

                response.Data = result;

                return Ok(response);
            }
            catch (Exception e)
            {
                response.Message = e.Message;
                response.Success = false;
                return BadRequest(response);
            }
        }

    }
}
