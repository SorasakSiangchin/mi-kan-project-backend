
namespace mi_kan_project_backend.Services.MultipleIntelligencesService
{
    public interface IMultipleIntelligencesService
    {
        Task<List<MultipleIntelligencesDto>> GetMultipleIntelligences();
        Task<List<MultipleIntelligencesDto>> GetMultipleIntelligencesBySchoolId(string? schoolId);
    }
}
