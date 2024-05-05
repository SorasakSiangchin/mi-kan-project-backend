namespace mi_kan_project_backend.Services.SchoolYearService
{
    public interface ISchoolYearService
    {
        Task<List<SchoolYear>> GetSchoolYearAll();
    }
}
