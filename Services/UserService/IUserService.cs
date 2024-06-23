namespace mi_kan_project_backend.Services.UserService
{
    public interface IUserService
    {
        Task<User?> ForgotPassword(ForgotPasswordDto dto);
        Task<User> Login(LoginRequestDto login);
        Task<User> ChangePassword(ChangePasswordRequestDto dto);
        Task Register(User user);
        string GenerateToken(User user);
        Task<(string errorMessage, string imageName)> UploadImage(IFormFileCollection formFiles);
        Task DeleteImage(string fileName);
        Task<UserResponseDto> GetUserById(Guid id);
        User GetInfo(string accessToken);
        Task Update(User user);
        Task<User> GetUser(string id, bool tracked = true);
    }
}
