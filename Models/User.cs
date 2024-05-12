using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mi_kan_project_backend.Models
{
    public class User
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

        [Required]
        public string PhoneNumber { get; set; } 
        public Guid SchoolId { get; set; }
        public Guid RoleId { get; set; }
        public string? CreatedAt { get; set; }
        public DateTime? CreatedBy { get; set; } = DateTime.Now;
        public string? UpdatedAt { get; set; }
        public DateTime? UpdatedBy { get; set; }
        public bool IsActive { get; set; } = true;
        public Role Role { get; set; }
        public School School { get; set; }
    }
}
