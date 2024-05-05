using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mi_kan_project_backend.Models
{
    public class Class
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        public string ClassNameTh { get; set; }
        public string? ClassNameEn { get; set; }
        public string? CreatedAt { get; set; }
        public DateTime? CreatedBy { get; set; } = DateTime.Now;
        public string? UpdatedAt { get; set; }
        public DateTime? UpdatedBy { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
