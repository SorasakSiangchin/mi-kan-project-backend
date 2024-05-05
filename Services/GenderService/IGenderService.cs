
namespace mi_kan_project_backend.Services.GenderService
{
    public interface IGenderService
    {
        Task<List<Gender>> GetGenderAll();
    }
}
