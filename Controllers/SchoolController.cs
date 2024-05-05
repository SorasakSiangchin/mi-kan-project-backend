
using AutoMapper;
using mi_kan_project_backend.Services.SchoolService;
using Microsoft.AspNetCore.Mvc;

namespace mi_kan_project_backend.Controllers
{
    public class SchoolController : BaseApiController
    {
        private readonly ISchoolService _schoolService;
        private readonly IMapper _mapper;

        public SchoolController(ISchoolService schoolService , IMapper mapper)
        {
            _schoolService = schoolService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<SchoolResponseDto>>>> GetSchoolAll()
        {
            var response = new ServiceResponse<List<SchoolResponseDto>>();
            try
            {
                var result = await _schoolService.GetSchoolAll();
                response.Data = _mapper.Map<List<SchoolResponseDto>>(result);
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
