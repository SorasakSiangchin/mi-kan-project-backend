using AutoMapper;
using mi_kan_project_backend.AppHelper;
using mi_kan_project_backend.Models;
using mi_kan_project_backend.Services.UploadFileService;
using mi_kan_project_backend.Settings;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;


namespace mi_kan_project_backend.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly DataContext _context;
        private readonly JwtSetting _jwtSetting;
        private readonly IUploadFileService _uploadFileService;
        private readonly IMapper _mapper;

        public UserService(
            DataContext context , 
            JwtSetting jwtSetting ,
            IUploadFileService uploadFileService ,
            IMapper mapper)
        {
            _context = context;
            _jwtSetting = jwtSetting;
            _uploadFileService = uploadFileService;
            _mapper = mapper;
        }
        public async Task<User> Login(LoginRequestDto login)
        {
            try
            {
                var user = await _context
                    .Users
                    .Include(u => u.Role)
                    .Include(u => u.School)
                    .SingleOrDefaultAsync(p => p.Email == login.Email);
                
                if(user != null && VerifyPassword(user.Password , login.Password)) 
                { 
                    return user;
                }
                
                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<User> ChangePassword(ChangePasswordRequestDto dto)
        {
            try
            {
                var user = await _context.Users.SingleOrDefaultAsync(e => e.Id == Guid.Parse(dto.Id));

                user.Password = CreateHashPassword(dto.Password);

                await _context.SaveChangesAsync();

                return user;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task Register(User user)
        {
            try
            {
                var result = await _context.Users.SingleOrDefaultAsync(e => e.Email == user.Email);
                if (result != null) throw new Exception("Existing Account");
                user.Password = CreateHashPassword(user.Password);

                user.RoleId = (await _context
                    .Roles
                    .AsNoTracking()
                    .SingleOrDefaultAsync(e => e.RoleCode == RoleCode.Teacher))
                    .Id;

                await _context.Users.AddAsync(user);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw e;
            }
        }

        private string CreateHashPassword(string password)
        {
            byte[] salt = new byte[128 / 8];
            using (var rngCsp = new RNGCryptoServiceProvider())
            {
                rngCsp.GetNonZeroBytes(salt);
            }
            //Console.WriteLine($"Salt: {Convert.ToBase64String(salt)}");

            // derive a 256-bit subkey (use HMACSHA256 with 100,000 iterations)
            var hashed = HashPassword(password, salt);

            var hpw = $"{Convert.ToBase64String(salt)}.{hashed}";
            return hpw;
        }

        private bool VerifyPassword(string saltAndHashFromDB, string password)
        {
            // ทำการแยกส่วนเป็น 2 สว่น เป็นอเร
            var parts = saltAndHashFromDB.Split('.', 2);
            if (parts.Length != 2) return false;
            // ไปเอาเกลือมา
            // Convert.FromBase64String ให้กลับเหมือนเดิมปกติมันเป็นไบต์
            var salt = Convert.FromBase64String(parts[0]);

            var passwordHash = parts[1];

            string hashed = HashPassword(password, salt);

            return hashed == passwordHash;
        }

        private string HashPassword(string password, Byte[] salt)
        {
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
              password: password,
              salt: salt,
              prf: KeyDerivationPrf.HMACSHA256,
              iterationCount: 100000,
              numBytesRequested: 256 / 8));
            return hashed;
        }

        public string GenerateToken(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes(_jwtSetting.Key);
            var expires = DateTime.Now.AddDays(Convert.ToDouble(_jwtSetting.Expire));
            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Issuer = _jwtSetting.Issuer,
                Subject = new ClaimsIdentity(
                    new Claim[]
                    {
                        new Claim(ClaimTypes.NameIdentifier , user.Id.ToString()),
                        new Claim(ClaimTypes.Email ,user.Email),
                        new Claim(ClaimTypes.Role , user.Role.RoleName),
                        new Claim("roleid" , user.Role.Id.ToString()),
                        new Claim("imageurl" , user.ImageUrl),
                        new Claim("firstname" , user.FirstName),
                        new Claim("lastname" , user.LastName),
                        new Claim("phonenumber" , user.PhoneNumber),
                        new Claim("schoolid" , user.SchoolId != Guid.Empty ? user.SchoolId.ToString() : ""),
                        new Claim("schoolnameth" , user.School.SchoolNameTh),

                    }),
                Expires = expires,
                Audience= _jwtSetting.Audience,
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }

        public async Task<(string errorMessage, string imageName)> UploadImage(IFormFileCollection formFiles)
        {
            var errorMessage = string.Empty;
            //var imageName = new List<string>();
            var imageName = string.Empty;
            if (_uploadFileService.IsUpload(formFiles))
            {
                errorMessage = _uploadFileService.Validation(formFiles);
                if (string.IsNullOrEmpty(errorMessage))
                {
                    imageName = (await _uploadFileService.UploadImages(formFiles, "user"))[0];
                }
            };

            return (errorMessage, imageName);
        }

        public async Task DeleteImage(string fileName)
        {
            await _uploadFileService.DeleteImage(fileName, "user");
        }

        public User GetInfo(string accessToken)
        {
            var token = new JwtSecurityTokenHandler().ReadToken(accessToken) as JwtSecurityToken;

        
            var id = token.Claims.First(claim => claim.Type == "nameid").Value;

            var email = token.Claims.First(claim => claim.Type == "email").Value;

            var roleName = token.Claims.First(claim => claim.Type == "role").Value;

            var roleId = token.Claims.First(claim => claim.Type == "roleid").Value;

            var imageUrl = token.Claims.First(claim => claim.Type == "imageurl").Value;

            var firstName = token.Claims.First(claim => claim.Type == "firstname").Value;

            var lastName = token.Claims.First(claim => claim.Type == "lastname").Value;

            var phoneNumber = token.Claims.First(claim => claim.Type == "phonenumber").Value;

            var schoolId = token.Claims.First(claim => claim.Type == "schoolid").Value;

            var schoolNameTh = token.Claims.First(claim => claim.Type == "schoolnameth").Value;

            var account = new User
            {
                Id = Guid.Parse(id),
                Email = email,
                ImageUrl = imageUrl,
                FirstName = firstName,
                LastName = lastName,
                PhoneNumber = phoneNumber,
                SchoolId = Guid.Parse(schoolId),
                School = new School
                {
                    Id = Guid.Parse(schoolId),
                    SchoolNameTh = schoolNameTh
                },
                Role = new Role
                {
                    Id = Guid.Parse(roleId),
                    RoleName = roleName
                }
            };

            return account;
        }

        public async Task Update(User user)
        {
            try
            {
                _context.Update(user);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<User> GetUser(string id, bool tracked = true)
        {
            try
            {
                IQueryable<User> query = _context.Users;
                if (!tracked) query = query.AsNoTracking();
                return await query.FirstOrDefaultAsync(e => e.Id.Equals(Guid.Parse(id)));
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<UserResponseDto> GetUserById(Guid id)
        {
            try
            {
                var result = await _context.Users
                    .Include(s => s.School)
                    .Include(s => s.Role)
                    .Where(s => s.Id == id)
                    .FirstOrDefaultAsync();

                return _mapper.Map<UserResponseDto>(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }

        }

        public async Task<User?> ForgotPassword(ForgotPasswordDto dto)
        {
            try
            {
                var result = await _context.Users.SingleOrDefaultAsync(e => e.Email == dto.Email);
                
                if (result == null) return null;

                result.Password = CreateHashPassword(dto.Password);

                await _context.SaveChangesAsync();

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
        }
    }
}
