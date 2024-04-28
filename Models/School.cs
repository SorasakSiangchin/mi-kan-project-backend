using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace mi_kan_project_backend.Models
{
    public class School
    {
        public int Id { get; set; }
        [Required]
        public string SchoolName { get; set; }
        [Required]
        public string Address { get;set;}
        [Required]
        public string Email { get; set; }
        [Phone]
        public string PhoneNumber { get; set; } = string.Empty;
        public string? CreatedAt { get; set; } = string.Empty;
        public DateTime? CreatedBy { get; set; } = DateTime.Now;
        public string? UpdatedAt { get; set; } = string.Empty;
        public DateTime? UpdatedBy { get; set; }
        [DefaultValue(true)]
        public bool IsActive { get; set; }
    }
}
