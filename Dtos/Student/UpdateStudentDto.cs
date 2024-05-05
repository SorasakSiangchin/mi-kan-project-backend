namespace mi_kan_project_backend.Dtos.Student
{
    public class UpdateStudentDto
    {
        public string Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public IFormFileCollection? ImageFiles { get; set; }
        public DateTime? Birthday { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public string? IdCard { get; set; }
        public string? Religion { get; set; }
        public string? Hobby { get; set; }
        public int? SchoolId { get; set; }
        public int? ClassId { get; set; }
        public int? ClassRoomId { get; set; }
        public int? SchoolYearId { get; set; }
        public int? TermId { get; set; }
        public int? GenderId { get; set; }
    }
}
