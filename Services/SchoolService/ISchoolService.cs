
namespace mi_kan_project_backend.Services.SchoolService
{
    public interface ISchoolService
    {
        Task<List<School>> GetSchoolAll();
    }
}
