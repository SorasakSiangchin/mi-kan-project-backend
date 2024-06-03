namespace mi_kan_project_backend.RequestHelpers
{
    public class StudentParams
    {
        public string? SchoolId { get; set; }
        public string? ClassId { get; set; }
        public string? ClassRoomId { get; set; }
        public string? SchoolYearId { get; set; }
        public string? TermId { get; set; }
        public string? GenderId { get; set; }
        public string? SearchName { get; set; }
        public bool? IsAction { get; set; } 
    }
}
