using mi_kan_project_backend.Services.UploadFileService;
using mi_kan_project_backend.Settings;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;


namespace mi_kan_project_backend.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly DataContext _context;
        private readonly JwtSetting _jwtSetting;
        private readonly IUploadFileService _uploadFileService;

        public UserService(
            DataContext context , 
            JwtSetting jwtSetting ,
            IUploadFileService uploadFileService)
        {
            _context = context;
            _jwtSetting = jwtSetting;
            _uploadFileService = uploadFileService;
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

        public async Task Register(User user)
        {
            try
            {
                var result = await _context.Users.SingleOrDefaultAsync(e => e.Email == user.Email);
                if (result != null) throw new Exception("Existing Account");
                user.Password = CreateHashPassword(user.Password);
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
                        new Claim(ClaimTypes.Name ,user.Email),
                        new Claim(ClaimTypes.Role , user.Role.RoleName)
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
            
            var role = token.Claims.First(claim => claim.Type == "role").Value;

            var account = new User
            {
                Id = Guid.Parse(id),
                Role = new Role
                {
                    RoleName = role,
                }
            };

            return account;
        }
    }
}
