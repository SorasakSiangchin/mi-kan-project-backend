
namespace mi_kan_project_backend.Services.AbilityService
{
    public interface IAbilityService
    {
        Task<List<AbilityDto>> GetAbilities(AbilityParams abilityParam);
        Task<bool> VerifiCreateAbility(CreateAbilityDto dto);
        Task<bool> VerifiUpdateAbility(UpdateAbilityDto dto);
        Task<List<AbilityDto>> GetAbilityBySchoolId(string? schoolId = "");
        Task<AbilityDto> GetAbilityById(string id);
        Task<Ability> GetAbility(string id, bool tracked = true);
        Task<List<ReportAbilityMultipleIntelligencesDto>> ReportAbilityBySchoolId(string? schoolId = "");
        Task<List<ReportBySchoolAbilityDto>> ReportAbilityBySchoolAll();
        Task Create(Ability ability);
        Task Update(Ability ability);
        
    }
}
