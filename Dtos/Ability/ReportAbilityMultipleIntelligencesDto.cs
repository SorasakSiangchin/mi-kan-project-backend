namespace mi_kan_project_backend.Dtos.Ability
{
    // พหุปัญญา 8 ด้าน พร้อมนักเรียนที่มีความสามารถด้านนั้น ๆ 
    public class ReportAbilityMultipleIntelligencesDto
    {
        public string MultipleIntelligencesId { get; set; }
        public string MultipleIntelligencesName { get; set; }
        public string? MultipleIntelligencesCode { get; set; }
        public double Percentage { get; set; }
        public string? Detail { get; set; }
        public List<StudentDto> Students { get; set; } = new();
        public int StudentAmount { get { return Students.Count; } }
    }
}
