using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mi_kan_project_backend.Models
{
    public class School
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        public string SchoolNameTh { get; set; }
        public string? SchoolNameEn { get; set; }
        [Required]
        public string Address { get;set;}
        [Required]
        public string Email { get; set; }
        [Phone]
        public string PhoneNumber { get; set; } = string.Empty;
        public string? CreatedAt { get; set; }
        public DateTime? CreatedBy { get; set; } = DateTime.Now;
        public string? UpdatedAt { get; set; }
        public DateTime? UpdatedBy { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
