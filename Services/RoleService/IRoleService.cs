namespace mi_kan_project_backend.Services.RoleService
{
    public interface IRoleService
    {
        Task<List<Role>> GetRoleAll();
    }
}
