using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mi_kan_project_backend.Models
{
    public class Student
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; } = Guid.NewGuid();
        [StringLength(50)]
        public string? Title { get; set; }
        [Required]
        [StringLength(200)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(200)]
        public string LastName { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public DateTime Birthday { get; set; }
        //[Required]
        [StringLength(200)]
        public string? Email { get; set; } 
        [Phone]
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; } 
        [StringLength(200)]
        public string IdCard { get; set; } // บัตรประชาชน
        [StringLength(200)]
        public string Religion { get; set; } // ศาสนา
        [StringLength(200)]
        public string Hobby { get; set; } // งานอดิเรก 
        public Guid SchoolId { get; set; }
        public Guid ClassId { get; set; }
        public Guid ClassRoomId { get; set; }
        public Guid SchoolYearId { get; set; }
        public Guid TermId { get; set; }
        public Guid GenderId { get; set; }

        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        public string? CreatedBy { get; set; } 
        public DateTime? UpdatedAt { get; set; } 
        public string? UpdatedBy { get; set; }
        public bool IsActive { get; set; } = true;

        public School School { get; set; }
        public Class Class { get; set; }
        public ClassRoom ClassRoom { get; set; }
        public SchoolYear SchoolYear { get; set; }
        public Term Term { get; set; }
        public Gender Gender { get; set; }

    }
}
