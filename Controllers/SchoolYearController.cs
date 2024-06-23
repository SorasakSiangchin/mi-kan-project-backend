using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace mi_kan_project_backend.Controllers
{
    public class SchoolYearController : BaseApiController
    {
        private readonly ISchoolYearService _schoolYearService;
        private readonly IMapper _mapper;

        public SchoolYearController(ISchoolYearService schoolYearService , IMapper mapper)
        {
            _schoolYearService = schoolYearService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<SchoolYearResponseDto>>>> GetSchoolYearAll()
        {
            var response = new ServiceResponse<List<SchoolYearResponseDto>>();
            try
            {
                var result = await _schoolYearService.GetSchoolYearAll();
                response.Data = _mapper.Map<List<SchoolYearResponseDto>>(result);
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
