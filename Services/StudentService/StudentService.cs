using Microsoft.EntityFrameworkCore;

namespace mi_kan_project_backend.Services.StudentService
{
    public class StudentService : IStudentService
    {
        private readonly DataContext _context;

        public StudentService(DataContext context)
        {
            _context = context;
        }

        public async Task Create(Student student)
        {
            await _context.AddAsync(student);
            await _context.SaveChangesAsync();
        }

        public Task DeleteImage(string fileName)
        {
            throw new NotImplementedException();
        }

        public async Task<Student> GetStudent(string id, bool tracked = true)
        {
            IQueryable<Student> query = _context.Students;
            if (!tracked) query = query.AsNoTracking();
            return await query.FirstOrDefaultAsync(e => e.Id.Equals(Guid.Parse(id)));

        }

        public async Task<List<Student>> GetStudentAll()
        {
            return await _context.Students.ToListAsync();
        }

        public async Task Update(Student student)
        {
             _context.Update(student);
            await _context.SaveChangesAsync();
        }

        public Task<(string errorMessage, string imageName)> UploadImage(IFormFileCollection formFiles)
        {
            throw new NotImplementedException();
        }
    }
}
