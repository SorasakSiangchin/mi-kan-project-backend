global using mi_kan_project_backend.Models;
global using mi_kan_project_backend.Datas;
global using mi_kan_project_backend.Services.StudentService;
using Microsoft.EntityFrameworkCore;
using mi_kan_project_backend.Installers;

var builder = WebApplication.CreateBuilder(args);

builder.Services.MyInstallerExtensions(builder);

var app = builder.Build();

#region  // √È”ß¢ÈÕ¡Ÿ≈®”≈Õß Fake data 
using var scope = app.Services.CreateScope(); //using À≈—ß∑”ß”π‡ √Á®®–∂Ÿ°∑≈”¬®”°Memory 
var context = scope.ServiceProvider.GetRequiredService<DataContext>();
var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();
try
{
    // orm
    await context.Database.MigrateAsync();
}
catch (Exception ex)
{
    logger.LogError(ex, "Problem migrating data");
}
#endregion

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(CorsInstaller.MyAllowSpecificOrigins);  

app.UseDefaultFiles();

app.UseStaticFiles();

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();
