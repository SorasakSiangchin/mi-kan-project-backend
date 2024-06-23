using AutoMapper;
using mi_kan_project_backend.Dtos.Role;
using mi_kan_project_backend.Services.RoleService;
using Microsoft.AspNetCore.Mvc;

namespace mi_kan_project_backend.Controllers
{
    public class RoleController : BaseApiController
    {
        private readonly IRoleService _roleService;
        private readonly IMapper _mapper;

        public RoleController(IRoleService roleService , IMapper mapper)
        {
            _roleService = roleService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<ClassResponseDto>>>> GetRoleAll()
        {
            var response = new ServiceResponse<List<RoleResponseDto>>();
            try
            {
                var result = await _roleService.GetRoleAll();
                response.Data = _mapper.Map<List<RoleResponseDto>>(result);
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
