using System.ComponentModel.DataAnnotations;

namespace mi_kan_project_backend.Models
{
    public class Student
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public DateTime Birthday { get; set; }
        [Required]
        public string Email { get; set; } 
        [Phone]
        public string PhoneNumber { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string IdCard { get; set; } // บัตรประชาชน
        public string Religion { get; set; } // ศาสนา
        public string Hobby { get; set; } // งานอดิเรก 
        public int SchoolId { get; set; }
        public int ClassId { get; set; }
        public int ClassRoomId { get; set; }
        public int SchoolYearId { get; set; }
        public int TermId { get; set; }
        public int GenderId { get; set; }

        public string CreatedAt { get; set; } = string.Empty;
        public DateTime CreatedBy { get; set; } = DateTime.Now;
        public string UpdatedAt { get; set; } = string.Empty;
        public DateTime UpdatedBy { get; set; }
        public bool IsActive { get; set; } = true;

        public School School { get; set; }
        public Class Class { get; set; }
        public ClassRoom ClassRoom { get; set; }
        public SchoolYear SchoolYear { get; set; }
        public Term Term { get; set; }
        public Gender Gender { get; set; }

    }
}
