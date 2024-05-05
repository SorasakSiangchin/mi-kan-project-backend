using Microsoft.EntityFrameworkCore;

namespace mi_kan_project_backend.Services.ClassService
{
    public class ClassService : IClassService
    {
        private readonly DataContext _context;

        public ClassService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Class>> GetClassAll()
        {
            try
            {
                var result = await _context.Classes.Where(c => c.IsActive).ToListAsync();
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
