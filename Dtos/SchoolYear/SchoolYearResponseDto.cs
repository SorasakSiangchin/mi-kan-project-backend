using System.ComponentModel.DataAnnotations;

namespace mi_kan_project_backend.Dtos.SchoolYear
{
    public class SchoolYearResponseDto
    {
        public string Id { get; set; } 
        public string? SchoolYearNameTh { get; set; }
        public string? SchoolYearNameEn { get; set; }
    }
}
