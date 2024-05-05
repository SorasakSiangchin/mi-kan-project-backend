
using AutoMapper;
using mi_kan_project_backend.Services.GenderService;
using Microsoft.AspNetCore.Mvc;

namespace mi_kan_project_backend.Controllers
{
    public class GenderController : BaseApiController
    {
        private readonly IGenderService _genderService;
        private readonly IMapper _mapper;

        public GenderController(IGenderService genderService , IMapper mapper)
        {
            _genderService = genderService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<GenderResponseDto>>>> GetGenderAll()
        {
            var response = new ServiceResponse<List<GenderResponseDto>>();
            try
            {
                var result = await _genderService.GetGenderAll();
                response.Data = _mapper.Map<List<GenderResponseDto>>(result);
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
