
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace mi_kan_project_backend.Services.AbilityService
{
    public class AbilityService : IAbilityService
    {
        private readonly DataContext _context;
        private readonly IMultipleIntelligencesService _multipleIntelligencesService;
        private readonly ISchoolService _schoolService;
        private readonly IMapper _mapper;

        public AbilityService(
            DataContext context ,
            IMultipleIntelligencesService multipleIntelligencesService ,
            ISchoolService schoolService ,
            IMapper mapper)
        {
            _context = context;
            _multipleIntelligencesService = multipleIntelligencesService;
            _schoolService = schoolService;
            _mapper = mapper;
        }
        public async Task Create(Ability ability)
        {
            try
            {
                await _context.Abilities.AddAsync(ability);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

        }

        public async Task<Ability> GetAbility(string id, bool tracked = true)
        {
            try
            {
                IQueryable<Ability> query = _context.Abilities;
                if (!tracked) query = query.AsNoTracking();
                return await query.FirstOrDefaultAsync(e => e.Id == Guid.Parse(id));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<AbilityDto> GetAbilityById(string id)
        {
            try
            {
               var result = await _context.Abilities
                    .Include(e => e.Student)
                    .Include(e => e.MultipleIntelligences)
                    .FirstOrDefaultAsync(e => e.Id == Guid.Parse(id));

                return _mapper.Map<AbilityDto>(result) ;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        // TODO : เพื่อดึงข้อมูลนักเรียนพร้อมกับพหุปัญญา 8 ด้าน
        public async Task<List<AbilityDto>> GetAbilityBySchoolId(string? schoolId = "")
        {
            try
            {
               var result = await _context.Abilities
                    .Include(a => a.Student)
                    .Include(a => a.MultipleIntelligences)
                    .FilterBySchoolId(schoolId) 
                    .ToListAsync();

              return  _mapper.Map<List<AbilityDto>>(result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<List<ReportBySchoolAbilityDto>> ReportAbilityBySchoolAll()
        {
            try
            {
                // ทั้งหมด
                // ดึงพหุปัญญา 8 ด้านพร้อมกับนักเรียนที่มีความสามารถนั้น ๆ
                var multipleIntelligences = await _multipleIntelligencesService
                     .GetMultipleIntelligencesBySchoolId("");

                // ทั้งหมด
                // นักเรียนทั้งหมด
                var abilityBySchoolIds = await GetAbilityBySchoolId("");

                // โรงเรียนทั้งหมด
                var schools = await _schoolService.GetSchoolAll();

                // เอาโรงเรียนลูป
                var result = schools.Select((s) => {
                    var reportAbilityMultipleIntelligences = new List<ReportAbilityMultipleIntelligencesDto>();

                    var response = new ReportBySchoolAbilityDto();

                    // set ข้อมูลโรงเรียน
                    response.Id = s.Id.ToString();
                    response.SchoolNameTh = s.SchoolNameTh;
                    response.SchoolNameEn = s.SchoolNameEn;
                    response.Email = s.Email;
                    response.Address = s.Address;
                    response.PhoneNumber = s.PhoneNumber;

                    // นักเรียนที่มีความสามารถทั้งหมดของโรงเรียนนั้น ๆ
                    var abilityBySchoolIdFilter = abilityBySchoolIds.Where(a => a.Student.SchoolId == s.Id).ToList();
                    var abilityBySchoolIdFilterCount = abilityBySchoolIdFilter.Count;

                    // ลูปความสามารถนั้น ๆ
                    foreach (var multiple in multipleIntelligences)
                    {
                        var abilityMultipleIntelligences = new ReportAbilityMultipleIntelligencesDto();

                        // นักเรียนที่เก่ง 1 ทั้งหมด
                        var ability = multiple.Abilities.Where(a => a.Student.SchoolId == s.Id).ToList();

                        abilityMultipleIntelligences.Students = _mapper.Map<List<StudentDto>>(ability.Select(a => a.Student).ToList());
                        abilityMultipleIntelligences.MultipleIntelligencesId = multiple.Id;
                        abilityMultipleIntelligences.MultipleIntelligencesName = multiple.MultipleIntelligencesName;
                        abilityMultipleIntelligences.MultipleIntelligencesCode = multiple.MultipleIntelligencesCode;

                        if (schools.Count > 0)
                        {
                            double percentage = 0;

                            if(abilityBySchoolIdFilterCount > 0)
                                percentage = ((double)ability.Count / (double)abilityBySchoolIdFilter.Count) * 100;
                            
                            abilityMultipleIntelligences.Percentage = percentage;
                        }
                        else abilityMultipleIntelligences.Percentage = 0.0;

                        reportAbilityMultipleIntelligences.Add(abilityMultipleIntelligences);
                    }

                    response.ReportAbilityMultipleIntelligences = reportAbilityMultipleIntelligences;

                    return response;
                }).ToList();

                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        //TODO : ยังไม่สมบูณ
        public async Task<List<ReportAbilityMultipleIntelligencesDto>> ReportAbilityBySchoolId(string? schoolId = "")
        {
            try
            {
                // ดึงพหุปัญญา 8 ด้านพร้อมกับนักเรียนที่มีความสามารถนั้น ๆ
               var multipleIntelligences = await _multipleIntelligencesService
                    .GetMultipleIntelligencesBySchoolId(schoolId);

               // นักเรียน (ทั้งหมด)
               var abilityBySchoolIds = await GetAbilityBySchoolId(schoolId);

               var result = multipleIntelligences.Select(multipleIntelligence => {

                    var responseReport = new ReportAbilityMultipleIntelligencesDto();

                    // นักเรียน (ที่มีความสามารถนั้น ๆ)
                    var abilityFilter = abilityBySchoolIds
                        .Where(a => a.MultipleIntelligencesId == Guid.Parse(multipleIntelligence.Id))
                    .ToList();

                   responseReport.MultipleIntelligencesId = multipleIntelligence.Id;
                   responseReport.MultipleIntelligencesName = multipleIntelligence.MultipleIntelligencesName;
                   responseReport.Detail = multipleIntelligence.Detail;
                   responseReport.Students = _mapper.Map<List<StudentDto>>(abilityFilter.Select(a => a.Student).ToList());

                   // หาร้อยละ
                   if (abilityFilter.Count > 0)
                   {
                       double percentage = ((double)abilityFilter.Count / (double)abilityBySchoolIds.Count) * 100;
                       responseReport.Percentage = percentage;
                   }
                   else responseReport.Percentage = 0.0;

                   return responseReport;

                }).ToList();

                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task Update(Ability ability)
        {
            try
            {
                _context.Update(ability);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<List<AbilityDto>> GetAbilities(AbilityParams abilityParam)
        {
            try
            {
                var result = await _context.Abilities
                     .Include(a => a.Student)
                        .ThenInclude(a => a.School)
                    .Include(a => a.Student)
                        .ThenInclude(a => a.ClassRoom)
                    .Include(a => a.Student)
                        .ThenInclude(a => a.Class)
         
                    .Include(a => a.MultipleIntelligences)
                    .FilterBySchoolId(abilityParam.SchoolId)
                    .FilterByClassRoomId(abilityParam.ClassRoomId)
                    .FilterByGenderId(abilityParam.GenderId)
                    .FilterByStudentName(abilityParam.StudentName)
                    .FilterByMultipleIntelligencesId(abilityParam.MultipleIntelligencesId)
                    .FilterByClassId(abilityParam.ClassId)
                    .ToListAsync();

                return _mapper.Map<List<AbilityDto>>(result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<bool> VerifiCreateAbility(CreateAbilityDto createAbilityDto)
        {
            try
            {
                var result = await _context
                    .Abilities
                    .FirstOrDefaultAsync(a => a.StudentId == Guid.Parse(createAbilityDto.StudentId)
                    && a.MultipleIntelligencesId == Guid.Parse(createAbilityDto.MultipleIntelligencesId));

                if (result != null) return false;

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
