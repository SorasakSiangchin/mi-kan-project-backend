
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
  //          modelBuilder.Entity<Class>().HasData(
  //              new Class
  //              {
  //                  ClassNameTh = "1"
  //              },
  //              new Class
  //              {
  //                  ClassNameTh = "2"
  //              });
  //          modelBuilder.Entity<ClassRoom>().HasData(
  //              new ClassRoom
  //              {
  //                 ClassRoomNameTh = "1"
  //              },
  //              new ClassRoom
  //              {
  //                  ClassRoomNameTh = "2"
  //              });
  //          modelBuilder.Entity<Gender>().HasData(
  //             new Gender
  //             {
  //                 GenderNameTh= "ชาย"
  //             },
  //             new Gender
  //             {
  //                 GenderNameTh = "หญิง"
  //             });
  //          modelBuilder.Entity<Role>().HasData(
  //             new Role
  //             {
  //                 RoleName = "ผู้ดูแลระบบ",
  //                 RoleCode = "admin"
  //             },
  //             new Role
  //             {
  //                 RoleName = "คุณครู",
  //                 RoleCode = "teacher"
  //             });
  //          modelBuilder.Entity<School>().HasData(
  //             new School
  //             {
  //                 SchoolNameTh = "โรงเรียน 1" ,
  //                 Address = "Address 1" ,
  //                 PhoneNumber = "0666666666" ,
  //                 Email = "school01@gmail.com",
  //             },
  //             new School
  //             {
  //                 SchoolNameTh = "โรงเรียน 2",
  //                 Address = "Address 2",
  //                 PhoneNumber = "0777777777",
  //                 Email = "school02@gmail.com",
  //             });
  //          modelBuilder.Entity<SchoolYear>().HasData(
  //             new SchoolYear
  //             {
  //                 SchoolYearNameTh = "ปีการศึกษา 1"  
  //             },
  //             new SchoolYear
  //             {
  //                 SchoolYearNameTh = "ปีการศึกษา 2"
  //             }
  //            );
  //          modelBuilder.Entity<Term>().HasData(
  //             new Term
  //             {
  //                 TermNameTh = "เทอม 1"
  //             },
  //             new Term
  //             {
  //                 TermNameTh = "เทอม 2"
  //             }
  //            );

  //          modelBuilder.Entity<Term>().HasData(
  // new Term
  // {
  //     TermNameTh = "เทอม 1"
  // },
  // new Term
  // {
  //     TermNameTh = "เทอม 2"
  // }
  //);
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
