namespace mi_kan_project_backend.Dtos.MultipleIntelligences
{
    public class MultipleIntelligencesDto
    {
        public string Id { get; set; }
        public string MultipleIntelligencesName { get; set; }
        public string? MultipleIntelligencesCode { get; set; }
        public string? Detail { get; set; }

        // จุดประสงค์เพื่อเอาข้อมูลนักเรียน 
        public List<AbilityDto>? Abilities { get; set; } = new();
    }
}
