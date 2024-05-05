using System.ComponentModel.DataAnnotations;

namespace mi_kan_project_backend.Dtos.School
{
    public class SchoolResponseDto
    {
        public string Id { get; set; } 
        public string? SchoolNameTh { get; set; }
        public string? SchoolNameEn { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
