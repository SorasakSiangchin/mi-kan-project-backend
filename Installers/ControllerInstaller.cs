namespace mi_kan_project_backend.Installers
{
    public class ControllerInstaller : IInstallers
    {
        public void InstallServices(WebApplicationBuilder builder)
        {
            builder.Services.AddControllers();
        }
    }
}
