using AutoMapper;
using mi_kan_project_backend.Services.ClassRoomService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace mi_kan_project_backend.Controllers
{
    public class ClassRoomController : BaseApiController
    {
        private readonly IClassRoomService _classRoomService;
        private readonly IMapper _mapper;

        public ClassRoomController(IClassRoomService classRoomService , IMapper mapper)
        {
            _classRoomService = classRoomService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<ClassRoomResponseDto>>>> GetClassRoomAll()
        {
            var response = new ServiceResponse<List<ClassRoomResponseDto>>();
            try
            {
                var result = await _classRoomService.GetClassRoomAll();
                response.Data = _mapper.Map<List<ClassRoomResponseDto>>(result);
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
