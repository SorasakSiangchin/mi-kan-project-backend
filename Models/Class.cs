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
        [StringLength(100)]
        public string ClassNameTh { get; set; }
        [StringLength(100)]
        public string? ClassNameEn { get; set; }
        [StringLength(100)]
        public string ClassNameInitial { get; set; } // ชื่อย่อ
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        public string? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? UpdatedBy { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
