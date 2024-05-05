using Microsoft.EntityFrameworkCore;

namespace mi_kan_project_backend.Services.SchoolYearService
{
    public class SchoolYearService : ISchoolYearService
    {
        private readonly DataContext _context;

        public SchoolYearService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<SchoolYear>> GetSchoolYearAll()
        {
            try
            {
                var result = await _context.SchoolYears.Where(sy => sy.IsActive).ToListAsync();
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
