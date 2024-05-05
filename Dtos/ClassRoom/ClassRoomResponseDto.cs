using System.ComponentModel.DataAnnotations;

namespace mi_kan_project_backend.Dtos.ClassRoom
{
    public class ClassRoomResponseDto
    {
        public string Id { get; set; } 
        public string ClassRoomNameTh { get; set; }
        public string? ClassRoomNameEn { get; set; }
    }
}
