global using mi_kan_project_backend.Models;
global using mi_kan_project_backend.Datas;
global using mi_kan_project_backend.Services.StudentService;
global using mi_kan_project_backend.Dtos.School;
global using mi_kan_project_backend.Dtos.SchoolYear;
global using mi_kan_project_backend.Services.SchoolYearService;
global using mi_kan_project_backend.Dtos.Class;
global using mi_kan_project_backend.Dtos.ClassRoom;
global using mi_kan_project_backend.Dtos.Gender;
global using mi_kan_project_backend.Dtos.Term;
global using mi_kan_project_backend.Dtos.User;
global using mi_kan_project_backend.Dtos.Student;

using Microsoft.EntityFrameworkCore;
using mi_kan_project_backend.Installers;
using mi_kan_project_backend;
using AutoMapper;

var builder = WebApplication.CreateBuilder(args);
builder.Services.MyInstallerExtensions(builder);
builder.Services.AddAutoMapper(typeof(MappingConfig));
//builder.Services.AddHttpContextAccessor();

var app = builder.Build();

#region  // √È”ß¢ÈÕ¡Ÿ≈®”≈Õß Fake data 
using var scope = app.Services.CreateScope(); //using À≈—ß∑”ß”π‡ √Á®®–∂Ÿ°∑≈”¬®”°Memory 
var context = scope.ServiceProvider.GetRequiredService<DataContext>();
var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();
try
{
    // orm
    await context.Database.MigrateAsync();
    await DbInitializer.Initialize(context);
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

app.UseAuthentication();

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();
