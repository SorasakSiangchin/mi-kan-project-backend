using mi_kan_project_backend.Services.UploadFileService;
using Microsoft.EntityFrameworkCore;

namespace mi_kan_project_backend.Services.StudentService
{
    public class StudentService : IStudentService
    {
        private readonly DataContext _context;
        private readonly IUploadFileService _uploadFileService;

        public StudentService(
            DataContext context ,
            IUploadFileService uploadFileService)
        {
            _context = context;
            _uploadFileService = uploadFileService;
        }

        public async Task Create(Student student)
        {
            await _context.AddAsync(student);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteImage(string fileName)
        {
           await _uploadFileService.DeleteImage(fileName , "student");
         
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

        public async Task<(string errorMessage, string imageName)> UploadImage(IFormFileCollection formFiles)
        {
            var errorMessage = string.Empty;
            //var imageName = new List<string>();
            var imageName = string.Empty;
            if (_uploadFileService.IsUpload(formFiles))
            {
                errorMessage = _uploadFileService.Validation(formFiles);
                if (string.IsNullOrEmpty(errorMessage))
                {
                    imageName = (await _uploadFileService.UploadImages(formFiles , "student"))[0];
                }
            }
            return (errorMessage, imageName);
        }
    }
}
