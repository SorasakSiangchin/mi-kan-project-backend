namespace mi_kan_project_backend.Dtos.Ability
{
    public class AbilityDto
    {
        public Guid Id { get; set; } 
        public Guid MultipleIntelligencesId { get; set; } // พหุปัญญา
        public string SchoolYear { get; set; } // ปีการศึกษา
        public string? ReasonNote { get; set; }
        public int Score { get; set; }
        public bool IsActive { get; set; }
        public Guid StudentId { get; set; } // นักเรียน
        public Models.Student Student { get; set; }

        public Models.MultipleIntelligences MultipleIntelligences { get; set; }
    }
}
