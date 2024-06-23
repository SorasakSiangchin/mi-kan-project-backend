namespace mi_kan_project_backend.Dtos.Ability
{
    public class ReportBySchoolAbilityDto
    {
        public string Id { get; set; }
        public string? SchoolNameTh { get; set; }
        public string? SchoolNameEn { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public List<ReportAbilityMultipleIntelligencesDto> ReportAbilityMultipleIntelligences { get; set; } = new();
        public int StudentAmountAll { get { return ReportAbilityMultipleIntelligences.Select(r => r.StudentAmount).Sum(); } }
    }
}
