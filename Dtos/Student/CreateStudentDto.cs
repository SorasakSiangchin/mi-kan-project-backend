using System.ComponentModel.DataAnnotations;

namespace mi_kan_project_backend.Dtos.Student
{
    public class CreateStudentDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IFormFileCollection? ImageFiles { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; } 
        public string Address { get; set; } 
        public string IdCard { get; set; } 
        public string Religion { get; set; } 
        public string Hobby { get; set; } 
        public string SchoolId { get; set; }
        public string ClassId { get; set; }
        public string ClassRoomId { get; set; }
        public string SchoolYearId { get; set; }
        public string TermId { get; set; }
        public string GenderId { get; set; }
    }
}
