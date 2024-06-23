using Microsoft.AspNetCore.Mvc;

namespace mi_kan_project_backend.Controllers
{
    public class MultipleIntelligencesController : BaseApiController
    {
        private readonly IMultipleIntelligencesService _multipleIntelligencesService;

        public MultipleIntelligencesController(IMultipleIntelligencesService multipleIntelligencesService)
        {
            _multipleIntelligencesService = multipleIntelligencesService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<MultipleIntelligencesDto>>>> GetMultipleIntelligences()
        {
            var response = new ServiceResponse<List<MultipleIntelligencesDto>>();
            try
            {
                response.Data = await _multipleIntelligencesService.GetMultipleIntelligences();

                return Ok(response);
            }
            catch (Exception e)
            {
                response.Message = e.Message;
                response.Success = false;
                return BadRequest(response);
            }
        }

        [HttpGet("[action]")]
        public async Task<ActionResult<ServiceResponse<List<MultipleIntelligencesDto>>>> GetMultipleIntelligencesBySchoolId(string? schoolId)
        {
            var response = new ServiceResponse<List<MultipleIntelligencesDto>>();
            try
            {
                response.Data = await _multipleIntelligencesService.GetMultipleIntelligencesBySchoolId(schoolId);

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
