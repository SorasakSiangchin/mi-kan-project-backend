

namespace mi_kan_project_backend.Dtos.User
{
    public class UserResponseDto
    {
        public string Id { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string SchoolId { get; set; }
        public string RoleId { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        public string? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? UpdatedBy { get; set; }
        public Models.Role Role { get; set; }
        public Models.School School { get; set; }
    }
}
