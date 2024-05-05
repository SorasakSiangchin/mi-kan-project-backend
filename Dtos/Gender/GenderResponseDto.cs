using System.ComponentModel.DataAnnotations;

namespace mi_kan_project_backend.Dtos.Gender
{
    public class GenderResponseDto
    {
        public string Id { get; set; } 
        public string GenderNameTh { get; set; }
        public string? GenderNameEn { get; set; }
    }
}
