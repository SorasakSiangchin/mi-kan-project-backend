

namespace mi_kan_project_backend.Dtos.Student
{
    public class StudentDto
    {
        public string Id { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Title { get; set; }
        public string FullName { get { return Title + " " + FirstName + " " + LastName; }  } 
        public string ImageUrl { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; } 
        public string Address { get; set; } 
        public string IdCard { get; set; } // บัตรประชาชน
        public string Religion { get; set; } // ศาสนา
        public string Hobby { get; set; } // งานอดิเรก 
        public Guid SchoolId { get; set; }
        public Guid ClassId { get; set; }
        public Guid ClassRoomId { get; set; }
        public Guid SchoolYearId { get; set; }
        public Guid TermId { get; set; }
        public Guid GenderId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? UpdatedBy { get; set; }
        public bool? IsActive { get; set; }

        public Models.School? School { get; set; }
        public Models.Class? Class { get; set; }
        public Models.ClassRoom? ClassRoom { get; set; }
        public Models.SchoolYear? SchoolYear { get; set; }
        public Models.Term? Term { get; set; }
        public Models.Gender? Gender { get; set; }
    }
}
