namespace mi_kan_project_backend.Installers
{
    public class CorsInstaller : IInstallers
    {
        public static string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
        public void InstallServices(WebApplicationBuilder builder)
        {
            builder.Services.AddCors(options =>
            {
                options.AddPolicy(name: MyAllowSpecificOrigins, policy => {

                    policy
                        .WithOrigins("http://localhost:3000")
                        .AllowAnyHeader()
                        .AllowAnyMethod()
                        .AllowCredentials();
                });
            });
        }
    }
}
