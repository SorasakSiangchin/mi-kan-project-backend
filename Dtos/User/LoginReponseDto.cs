

namespace mi_kan_project_backend.Dtos.User
{
    public class LoginReponseDto
    {
        public string Token { get; set; }
        public Models.User User { get; set; } 
    }
}
