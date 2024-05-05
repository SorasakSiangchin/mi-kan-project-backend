using Microsoft.EntityFrameworkCore;

namespace mi_kan_project_backend.Services.ClassRoomService
{
    public class ClassRoomService : IClassRoomService
    {
        private readonly DataContext _context;

        public ClassRoomService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<ClassRoom>> GetClassRoomAll()
        {
            try
            {
                var result = await _context.ClassRooms.Where(cr => cr.IsActive).ToListAsync();
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
