
using Microsoft.EntityFrameworkCore;

namespace mi_kan_project_backend.Services.GenderService
{
    public class GenderService : IGenderService
    {
        private readonly DataContext _context;

        public GenderService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Models.Gender>> GetGenderAll()
        {
            try
            {
               var result = await _context.Genders.ToListAsync();
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
