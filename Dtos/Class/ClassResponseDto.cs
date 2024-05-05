using System.ComponentModel.DataAnnotations;

namespace mi_kan_project_backend.Dtos.Class
{
    public class ClassResponseDto
    {
        public string Id { get; set; } 
        public string ClassNameTh { get; set; }
        public string? ClassNameEn { get; set; }
    }
}
