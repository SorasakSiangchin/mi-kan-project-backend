using System.ComponentModel.DataAnnotations;

namespace mi_kan_project_backend.Models
{
    public class Gender
    {
        public int Id { get; set; }
        [Required]
        public string GenderName { get; set; }
    }
}
