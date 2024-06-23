using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mi_kan_project_backend.Models
{
    public class Role
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        [StringLength(100)]
        public string RoleName { get; set; }
        [Required]
        [StringLength(100)]
        public string RoleCode { get; set; }
        [StringLength(100)]
        public string? RoleNameInitial { get; set; } // ชื่อย่อ

    }
}
