namespace mi_kan_project_backend.Services.ClassRoomService
{
    public interface IClassRoomService
    {
        Task<List<ClassRoom>> GetClassRoomAll();
    }
}
