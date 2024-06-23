namespace mi_kan_project_backend.Dtos.Role
{
    public class RoleResponseDto
    {
        public string Id { get; set; }
        public string RoleName { get; set; }
        public string RoleCode { get; set; }
        public string? RoleNameInitial { get; set; } // ชื่อย่อ
    }
}
