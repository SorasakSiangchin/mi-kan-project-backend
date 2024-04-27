
using Microsoft.EntityFrameworkCore;

namespace mi_kan_project_backend.Datas
{
    public class DataContext : DbContext
    {
        public DataContext()
        {

        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-6TJ4MKL;Database=mi-kan-project;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True");
        }

        public DbSet<Ability> Abilities { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<ClassRoom> ClassRooms { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<MultipleIntelligences> MultipleIntelligences { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<SchoolYear> SchoolYears { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Term> Terms { get; set; }
        public DbSet<Training> Trainings { get; set; }
        public DbSet<TrainingCategory> TrainingCategories { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
