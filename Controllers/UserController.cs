using AutoMapper;
using mi_kan_project_backend.Services.UserService;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace mi_kan_project_backend.Controllers
{
    public class UserController : BaseApiController
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserController(IUserService userService , IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpPost("[action]")]
        public async Task<ActionResult<ServiceResponse<LoginReponseDto>>> Login([FromForm] LoginRequestDto login)
        {
            var response = new ServiceResponse<LoginReponseDto>();
            try
            {
                var result = await _userService.Login(login);
                if (result == null) 
                {
                    response.Success = false;
                    response.Message = "ไม่มีผู้ใช้งานนี้";
                    return BadRequest(response);
                };

                var tokent = _userService.GenerateToken(result);

                response.Data = new LoginReponseDto
                {
                    Token = tokent,
                    User = _mapper.Map<UserResponseDto>(result) 
                };

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
        public async Task<ActionResult<ServiceResponse<string>>> Register([FromForm] RegisterRequestDto register)
        {
            var response = new ServiceResponse<string>();

            try
            {
                (string errorMessage, string imageName) = await _userService.UploadImage(register.ImageFiles);

                if (!string.IsNullOrEmpty(errorMessage))
                {
                    response.Success = false;
                    response.Message = errorMessage;
                    return BadRequest(response);
                }
                
                var user = _mapper.Map<User>(register);
                user.ImageUrl = imageName;

                await _userService.Register(user);

                response.Data = "OK";

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
        public async Task<ActionResult<ServiceResponse<UserResponseDto>>> Info()
        {
            var response = new ServiceResponse<UserResponseDto>();
            try
            {
                var accessToken = await HttpContext.GetTokenAsync("access_token");
                if (accessToken == null) return Unauthorized();

                var account = _userService.GetInfo(accessToken);

                response.Data =  _mapper.Map<UserResponseDto>(account);

                return Ok(response);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
