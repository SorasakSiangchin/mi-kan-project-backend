using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace mi_kan_project_backend.Services.TermService
{
    public class TermService : ITermService
    {
        private readonly DataContext _context;

        public TermService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Term>> GetTermAll()
        {
            try
            {
                var result = await _context.Terms.Where(t => t.IsActive).ToListAsync();
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
