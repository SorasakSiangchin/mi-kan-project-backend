using System.ComponentModel.DataAnnotations;

namespace mi_kan_project_backend.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        [Required]
        public string Email { get; set; }

        [Required]
        public string PhoneNumber { get; set; } 
        public int SchoolId { get; set; }
        public int RoleId { get; set; }
        public string CreatedAt { get; set; } = string.Empty;
        public DateTime CreatedBy { get; set; } = DateTime.Now;
        public string UpdatedAt { get; set; } = string.Empty;
        public DateTime UpdatedBy { get; set; }
        public bool IsActive { get; set; } = true;
        public Role Role { get; set; }
        public School School { get; set; }
    }
}
