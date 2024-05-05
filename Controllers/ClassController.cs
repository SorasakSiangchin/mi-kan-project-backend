using AutoMapper;
using mi_kan_project_backend.Services.ClassService;
using Microsoft.AspNetCore.Mvc;

namespace mi_kan_project_backend.Controllers
{
    public class ClassController : BaseApiController
    {
        private readonly IClassService _classService;
        private readonly IMapper _mapper;

        public ClassController(IClassService classService , IMapper mapper)
        {
            _classService = classService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<ClassResponseDto>>>> GetClassAll()
        {
            var response = new ServiceResponse<List<ClassResponseDto>>();
            try
            {
                var result = await _classService.GetClassAll();
                response.Data = _mapper.Map<List<ClassResponseDto>>(result);
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
