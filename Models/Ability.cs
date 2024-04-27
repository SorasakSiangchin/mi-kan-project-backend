using System.ComponentModel.DataAnnotations;

namespace mi_kan_project_backend.Models
{
    public class Ability
    {
        public int Id { get; set; }

        public int StudentId { get; set; } // นักเรียน
        public int MultipleIntelligencesId { get; set; } // พหุปัญญา
        public string SchoolYear { get; set; } // ปีการศึกษา
        public int Score { get; set; }
        public string CreatedAt { get; set; } = string.Empty;
        public DateTime CreatedBy { get; set; } = DateTime.Now;
        public string UpdatedAt { get; set; } = string.Empty;
        public DateTime UpdatedBy { get; set; }
        public bool IsActive { get; set; } = true;

        public MultipleIntelligences MultipleIntelligences { get; set; }
        public Student Student { get; set; }


    }
}
