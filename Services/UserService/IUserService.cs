

using System.Security.Principal;

namespace mi_kan_project_backend.Services.UserService
{
    public interface IUserService
    {
        Task<User> Login(LoginRequestDto login);
        Task Register(User user);
        string GenerateToken(User user);
        Task<(string errorMessage, string imageName)> UploadImage(IFormFileCollection formFiles);
        Task DeleteImage(string fileName);

        User GetInfo(string accessToken);

    }
}
