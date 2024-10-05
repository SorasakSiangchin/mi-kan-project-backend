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
                        .WithOrigins("http://localhost:3000", "https://tee.kru.ac.th/cs63/s09/mi-kan-project/mi-kan-project-frontend" , "https://tee.kru.ac.th/cs63/s09/mi-kan-project/mi-kan-project-frontend-uat")
                        .AllowAnyHeader()
                        .AllowAnyMethod().AllowCredentials();
                });
            });
        }
    }
}
