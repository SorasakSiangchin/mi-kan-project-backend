using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace mi_kan_project_backend.Controllers
{
    public class AbilityController : BaseApiController
    {
        private readonly IAbilityService _abilityService;
        private readonly IMapper _mapper;

        public AbilityController(IAbilityService abilityService , IMapper mapper)
        {
            _abilityService = abilityService;
            _mapper = mapper;
        }

        // ดึงนักเรียนที่มีความสามารถ 
        // TODO ทุกโรงเรียน หรือโรงเรียนเดียว ก็ได้
        [HttpPost("[action]")]
        public async Task<ActionResult<ServiceResponse<List<AbilityDto>>>> GetAbilities(AbilityParams abilityParams)
        {
            var response = new ServiceResponse<List<AbilityDto>>();
            try
            {
                var result = await _abilityService.GetAbilities(abilityParams);

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
        public async Task<ActionResult<ServiceResponse<AbilityDto>>> GetStudentById(string id)
        {
            var response = new ServiceResponse<AbilityDto>();
            try
            {

                var result = await _abilityService.GetAbilityById(id);

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

        
        [HttpGet("[action]")]
        public async Task<ActionResult<ServiceResponse<List<ReportAbilityMultipleIntelligencesDto>>>> ReportAbilityBySchoolId(string? schoolId)
        {
            var response = new ServiceResponse<List<ReportAbilityMultipleIntelligencesDto>>();
            try
            {
                var result = await _abilityService.ReportAbilityBySchoolId(schoolId);

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

        [HttpGet("[action]")]
        public async Task<ActionResult<ServiceResponse<List<ReportBySchoolAbilityDto>>>> ReportAbilityBySchoolAll()
        {
            var response = new ServiceResponse<List<ReportBySchoolAbilityDto>>();
            try
            {
                var result = await _abilityService.ReportAbilityBySchoolAll();

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
        public async Task<ActionResult<ServiceResponse<Ability>>> CreateAbility(CreateAbilityDto dto)
        {
            var response = new ServiceResponse<Ability>();
            try
            {
                var verified = await _abilityService.VerifiCreateAbility(dto);

                if(!verified)
                {
                    response.Message = "นักเรียนมีความสามารถนี้แล้ว!";
                    response.Success = false;
                    response.Data = null;
                    return Ok(response);
                }

               var ability = _mapper.Map<Ability>(dto);
               await _abilityService.Create(ability);

               response.Data = ability;

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
        public async Task<ActionResult<ServiceResponse<Ability>>> UpdateAbility(UpdateAbilityDto dto)
        {
            var response = new ServiceResponse<Ability>();
            try
            {
                var result = await _abilityService.GetAbility(dto.Id , false);

                if(result == null)
                {
                    response.Message = "ไม่มีข้อมูลของนักเรียน";
                    response.Success = false;
                    return NotFound(response);
                }

                var verified = await _abilityService.VerifiUpdateAbility(dto);

                if (!verified)
                {
                    response.Message = "นักเรียนมีความสามารถนี้แล้ว!";
                    response.Success = false;
                    response.Data = null;
                    return Ok(response);
                }

                var ability = _mapper.Map<Ability>(dto);
                await _abilityService.Update(ability);

                response.Data = ability;

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
