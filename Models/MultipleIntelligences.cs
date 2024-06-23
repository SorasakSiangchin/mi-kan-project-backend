using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mi_kan_project_backend.Models
{
    // พหุปัญญา 
    public class MultipleIntelligences
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        [StringLength(200)]
        public string MultipleIntelligencesName { get; set; }
        [StringLength(200)]
        public string? MultipleIntelligencesCode { get; set; }
        public string? Detail { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        public string? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? UpdatedBy { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
