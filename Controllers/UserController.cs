using AutoMapper;
using mi_kan_project_backend.Services.UserService;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;

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
                    ExpToken = GetExpToken(tokent) ,
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

        private string GetExpToken (string tokenString)
        {
            var token = new JwtSecurityTokenHandler().ReadToken(tokenString) as JwtSecurityToken;
            var exp = token.Claims.First(claim => claim.Type == "exp").Value;

            return exp;
        }

        // เปลี่ยน password
        [HttpPost("[action]")]
        public async Task<ActionResult<ServiceResponse<UserResponseDto>>> ChangePassword(ChangePasswordRequestDto dto)
        {
            var response = new ServiceResponse<UserResponseDto>();
            try
            {
                var result = await _userService.ChangePassword(dto);
                response.Data = _mapper.Map<UserResponseDto>(result);
                return Ok(response);
            }
            catch (Exception e)
            {
                response.Message = e.Message;
                response.Success = false;
                return BadRequest(response);
            }
        }

        // ลืม password
        [HttpPost("[action]")]
        public async Task<ActionResult<ServiceResponse<UserResponseDto>>> ForgotPassword(ForgotPasswordDto dto)
        {
            var response = new ServiceResponse<UserResponseDto>();
            try
            {
                var result = await _userService.ForgotPassword(dto);

                if(result == null)
                {
                    response.Message = "อีเมลนี้ไม่มีในระบบ!";
                    response.Success = false;
                    return Ok(response);
                }

                response.Data = _mapper.Map<UserResponseDto>(result);
                return Ok(response);
            }
            catch (Exception e)
            {
                response.Message = e.Message;
                response.Success = false;
                return BadRequest(response);
            }
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<ServiceResponse<UserResponseDto>>> GetUserById(Guid id)
        {
            var response = new ServiceResponse<UserResponseDto>();
            try
            {

                var result = await _userService.GetUserById(id);

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

        [HttpPost("[action]")]
        public async Task<ActionResult<ServiceResponse<UpdateUserDto>>> UpdateUser([FromForm] UpdateUserDto dto) 
        {
            var response = new ServiceResponse<UpdateUserDto>();
            try
            {
                var result = await _userService.GetUser(dto.Id);

                if (result == null)
                {
                    response.Message = "ไม่มีข้อมูลของผู้ใช้งาน";
                    response.Success = false;
                    return NotFound(response);
                }

                (string errorMessage, string imageName) =
                    await _userService.UploadImage(dto.ImageFiles);

                if (!string.IsNullOrEmpty(errorMessage))
                {
                    response.Success = false;
                    response.Message = errorMessage;
                    return BadRequest(response);
                }

                var student = _mapper.Map(dto, result);

                if (!string.IsNullOrEmpty(imageName))
                {
                    await _userService.DeleteImage(result.ImageUrl);
                    student.ImageUrl = imageName;
                }
                else
                {
                    student.ImageUrl = result.ImageUrl;
                }

                //student.Id = Guid.Parse(dto.Id);

                await _userService.Update(student);

                response.Data = dto;

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

                var respnseAccount =  await _userService.GetUserById(Guid.Parse(account.Id));

                response.Data = respnseAccount;

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
