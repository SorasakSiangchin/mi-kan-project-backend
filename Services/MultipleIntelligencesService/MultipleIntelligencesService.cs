
using AutoMapper;
using mi_kan_project_backend.Extenstions;
using mi_kan_project_backend.Models;
using Microsoft.EntityFrameworkCore;

namespace mi_kan_project_backend.Services.MultipleIntelligencesService
{
    public class MultipleIntelligencesService : IMultipleIntelligencesService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public MultipleIntelligencesService(
            DataContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<List<MultipleIntelligencesDto>> GetMultipleIntelligences()
        {
            try
            {
                var multipleIntelligences = await _context
                      .MultipleIntelligences
                      .Where(mi => mi.IsActive)
                      .ToListAsync();

                var abilities = await _context.Abilities
                    .Include(a => a.Student)
                    .Include(a => a.MultipleIntelligences)
                    .ToListAsync();

                var multipleIntelligencesDto = _mapper.Map<List<MultipleIntelligencesDto>>(multipleIntelligences);

                multipleIntelligencesDto = await SetAbilityInMultipleIntelligences(_mapper.Map<List<AbilityDto>>(abilities) , multipleIntelligencesDto);

                return multipleIntelligencesDto;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<List<MultipleIntelligencesDto>> GetMultipleIntelligencesBySchoolId(string? schoolId)
        {
            try
            {
                var multipleIntelligences = await _context
                    .MultipleIntelligences
                    .Where(mi => mi.IsActive)
                    .ToListAsync();

                var abilities = await _context.Abilities
                 .Include(a => a.Student)
                 .Include(a => a.MultipleIntelligences)
                 .FilterBySchoolId(schoolId)
                 .ToListAsync();


                var multipleIntelligencesDto = _mapper.Map<List<MultipleIntelligencesDto>>(multipleIntelligences);

                multipleIntelligencesDto = await SetAbilityInMultipleIntelligences(_mapper.Map<List<AbilityDto>>(abilities), multipleIntelligencesDto);

                return multipleIntelligencesDto;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private async Task<List<MultipleIntelligencesDto>> SetAbilityInMultipleIntelligences
            (List<AbilityDto> abilities, List<MultipleIntelligencesDto> multipleIntelligences)
        {
            multipleIntelligences = multipleIntelligences.Select(ni =>
            {
                ni.Abilities = abilities
            .Where(a => a.MultipleIntelligencesId == Guid.Parse(ni.Id))
            .ToList();

                return ni;

            }).ToList();

            return multipleIntelligences;
        }
    }
}
