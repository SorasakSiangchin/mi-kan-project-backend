using AutoMapper;
using mi_kan_project_backend.Extenstions;
using mi_kan_project_backend.Services.UploadFileService;
using Microsoft.EntityFrameworkCore;

namespace mi_kan_project_backend.Services.StudentService
{
    public class StudentService : IStudentService
    {
        private readonly DataContext _context;
        private readonly IUploadFileService _uploadFileService;
        private readonly IMapper _mapper;

        public StudentService(
            DataContext context ,
            IUploadFileService uploadFileService ,
            IMapper mapper)
        {
            _context = context;
            _uploadFileService = uploadFileService;
            _mapper = mapper;
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

        public async Task<List<StudentDto>> GetStudentAll(string? schoolId)
        {
            try
            {
               var result = await _context.Students.Include(s => s.School)
                    .Include(s => s.Class)
                    .Include(s => s.ClassRoom)
                    .Include(s => s.SchoolYear)
                    .Include(s => s.Term)
                    .Include(s => s.Gender)
                    .Where(s => s.IsActive)
                    .FilterBySchoolId(schoolId)
                    .ToListAsync();

                return _mapper.Map<List<StudentDto>>(result);
            }
             catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
        }

        public async Task<StudentDto> GetStudentById(string id)
        {
            try
            {
                var result = await _context.Students
                    .Include(s => s.School)
                    .Include(s => s.Class)
                    .Include(s => s.ClassRoom)
                    .Include(s => s.SchoolYear)
                    .Include(s => s.Term)
                    .Include(s => s.Gender)  
                    .Where(s => s.Id == Guid.Parse(id))
                    .FirstOrDefaultAsync();

                return _mapper.Map<StudentDto>(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }

        }


        public async Task<List<StudentDto>> GetStudents(StudentParams studentParams)
        {
            try
            {

              var result = await _context.Students
                    .Include(s => s.School)
                    .Include(s => s.Class)
                    .Include(s => s.ClassRoom)
                    .Include(s => s.SchoolYear)
                    .Include(s => s.Term)
                    .Include(s => s.Gender)
                    .FilterBySchoolId(studentParams.SchoolId)
                    .FilterBySchoolYearId(studentParams.SchoolYearId)
                    .FilterByTermId(studentParams.TermId)
                    .FilterByGenderId(studentParams.GenderId)
                    .FilterByClassRoomId(studentParams.ClassRoomId)
                    .FilterByClassId(studentParams.ClassId)
                    .SearchName(studentParams.SearchName)
                    .FilterIsAction(studentParams.IsAction)
                    .ToListAsync();

                return _mapper.Map<List<StudentDto>>(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
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
