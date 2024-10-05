using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mi_kan_project_backend.Models
{
    public class Ability
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid MultipleIntelligencesId { get; set; } // พหุปัญญา
        public string? SchoolYear { get; set; } // ปีการศึกษา
        public string? ReasonNote { get; set; } // เหตุผลที่เก่ง
        public int? Score { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        public string? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? UpdatedBy { get; set; }
        public bool IsActive { get; set; } = true;
        public Guid StudentId { get; set; } // นักเรียน

        [ForeignKey("StudentId")]
        [ValidateNever]
        public Student Student { get; set; }
        public MultipleIntelligences MultipleIntelligences { get; set; }
 


    }
}
