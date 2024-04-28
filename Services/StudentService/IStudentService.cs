
namespace mi_kan_project_backend.Services.StudentService
{
    public interface IStudentService
    {
        Task<List<Student>> GetStudentAll();
        Task<Student> GetStudent(string id, bool tracked = true);
        Task Create (Student student);
        Task Update(Student student);
        Task<(string errorMessage, string imageName)> UploadImage(IFormFileCollection formFiles);
        Task DeleteImage(string fileName);
    }
}
