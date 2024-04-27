using System.ComponentModel.DataAnnotations;

namespace mi_kan_project_backend.Models
{
    public class Role
    {
        public int Id { get; set; }
        [Required]
        public string RoleName { get; set; } 

    }
}
