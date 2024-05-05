namespace mi_kan_project_backend.Services.ClassService
{
    public interface IClassService
    {
        Task<List<Class>> GetClassAll();
    }
}
