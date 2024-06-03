
using AutoMapper;
using mi_kan_project_backend.Services.TermService;
using Microsoft.AspNetCore.Mvc;

namespace mi_kan_project_backend.Controllers
{
    public class TermController : BaseApiController
    {
        private readonly ITermService _termService;
        private readonly IMapper _mapper;

        public TermController(ITermService termService , IMapper mapper)
        {
            _termService = termService;
            _mapper = mapper;
        }

        [HttpGet] 
        public async Task<ActionResult<ServiceResponse<List<TermResponseDto>>>> GetTermAll()
        {
            var response = new ServiceResponse<List<TermResponseDto>>();
            try
            {
               var result = await _termService.GetTermAll();
               response.Data = _mapper.Map<List<TermResponseDto>>(result);
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
