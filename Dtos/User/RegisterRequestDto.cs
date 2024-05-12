using System.ComponentModel.DataAnnotations;

namespace mi_kan_project_backend.Dtos.User
{
    public class RegisterRequestDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IFormFileCollection? ImageFiles { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string SchoolId { get; set; }
        public string RoleId { get; set; }
    }
}
