using Microsoft.EntityFrameworkCore;

namespace mi_kan_project_backend.Services.RoleService
{
    public class RoleService : IRoleService
    {
        private readonly DataContext _context;

        public RoleService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Role>> GetRoleAll()
        {
            try
            {
                var result = await _context.Roles.ToListAsync();
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
