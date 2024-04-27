namespace mi_kan_project_backend.Installers
{
    public interface IInstallers
    {
        // WebApplicationBuilder คือ WebApplication.CreateBuilder(args); ใน Program.cs
        void InstallServices(WebApplicationBuilder builder);
    }
}
