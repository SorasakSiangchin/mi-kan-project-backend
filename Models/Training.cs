using System.ComponentModel.DataAnnotations;

namespace mi_kan_project_backend.Models
{
    public class Training
    {
        public int Id { get; set; }

        [Required]
        public string TrainingName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [Required]
        public string Location { get; set; }
        public int TrainingCategoryId { get; set; }
        public int UserId { get; set; }
        public string CreatedAt { get; set; } = string.Empty;
        public DateTime CreatedBy { get; set; } = DateTime.Now;
        public string UpdatedAt { get; set; } = string.Empty;
        public DateTime UpdatedBy { get; set; }
        public bool IsActive { get; set; } = true;

        public TrainingCategory TrainingCategory { get; set; }
        public User User { get; set; }

    }
}
