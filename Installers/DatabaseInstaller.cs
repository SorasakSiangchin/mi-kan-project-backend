namespace mi_kan_project_backend.Installers
{
    public class DatabaseInstaller : IInstallers
    {
        public void InstallServices(WebApplicationBuilder builder)
        {
            builder.Services.AddDbContext<DataContext>();
        }
    }
}
