using System.ComponentModel.DataAnnotations;

namespace mi_kan_project_backend.Dtos.Term
{
    public class TermResponseDto
    {
        public string Id { get; set; }
        public string TermNameTh { get; set; }
        public string? TermNameEn { get; set; }
    }
}
