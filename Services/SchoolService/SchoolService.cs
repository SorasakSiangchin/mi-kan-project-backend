using Microsoft.EntityFrameworkCore;

namespace mi_kan_project_backend.Services.SchoolService
{
    public class SchoolService : ISchoolService
    {
        private readonly DataContext _context;

        public SchoolService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<School>> GetSchoolAll()
        {
            try
            {
                var result = await _context.Schools.Where(s => s.IsActive).ToListAsync();
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
