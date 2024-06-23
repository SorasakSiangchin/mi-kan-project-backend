using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mi_kan_project_backend.Models
{
    public class Gender
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        [StringLength(100)]
        public string GenderNameTh { get; set; }
        [StringLength(100)]
        public string? GenderNameEn { get; set; }

        [StringLength(100)]
        public string GenderNameInitial { get; set; } // ชื่อย่อ
    }
}
