﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using mi_kan_project_backend.Datas;

#nullable disable

namespace mi_kan_project_backend.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240608134504_ScoreIsNullInAbility")]
    partial class ScoreIsNullInAbility
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("mi_kan_project_backend.Models.Ability", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<Guid>("MultipleIntelligencesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SchoolYear")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Score")
                        .HasColumnType("int");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MultipleIntelligencesId");

                    b.HasIndex("StudentId");

                    b.ToTable("Abilities");
                });

            modelBuilder.Entity("mi_kan_project_backend.Models.Class", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ClassNameEn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClassNameTh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Classes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ac06b478-74a1-4ed9-9129-526bd44bedf4"),
                            ClassNameTh = "1",
                            CreatedAt = new DateTime(2024, 6, 8, 20, 45, 4, 180, DateTimeKind.Local).AddTicks(4066),
                            IsActive = true
                        },
                        new
                        {
                            Id = new Guid("637bdff0-befc-4f2b-85a7-8f816e18c7cb"),
                            ClassNameTh = "2",
                            CreatedAt = new DateTime(2024, 6, 8, 20, 45, 4, 180, DateTimeKind.Local).AddTicks(4080),
                            IsActive = true
                        });
                });

            modelBuilder.Entity("mi_kan_project_backend.Models.ClassRoom", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ClassRoomNameEn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClassRoomNameTh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ClassRooms");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7198a8f9-3a74-40c3-b169-54d7ec4c7307"),
                            ClassRoomNameTh = "1",
                            CreatedAt = new DateTime(2024, 6, 8, 20, 45, 4, 180, DateTimeKind.Local).AddTicks(4170),
                            IsActive = true
                        },
                        new
                        {
                            Id = new Guid("e5972bc1-0078-4827-b330-cfa983e9f3a4"),
                            ClassRoomNameTh = "2",
                            CreatedAt = new DateTime(2024, 6, 8, 20, 45, 4, 180, DateTimeKind.Local).AddTicks(4171),
                            IsActive = true
                        });
                });

            modelBuilder.Entity("mi_kan_project_backend.Models.Gender", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("GenderNameEn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GenderNameTh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genders");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e23506c5-61c4-4ce2-ac15-748d4c3a7d23"),
                            GenderNameTh = "ชาย"
                        },
                        new
                        {
                            Id = new Guid("b2f17c73-2146-44d2-9977-58d69fd97b1f"),
                            GenderNameTh = "หญิง"
                        });
                });

            modelBuilder.Entity("mi_kan_project_backend.Models.MultipleIntelligences", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Detail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("MultipleIntelligencesName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MultipleIntelligences");
                });

            modelBuilder.Entity("mi_kan_project_backend.Models.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("RoleCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b5b5f6bd-03df-4a52-a0a0-92e99d69e9f3"),
                            RoleCode = "admin",
                            RoleName = "ผู้ดูแลระบบ"
                        },
                        new
                        {
                            Id = new Guid("9446eb65-a753-4616-bda7-5bb8cf0beac0"),
                            RoleCode = "teacher",
                            RoleName = "คุณครู"
                        });
                });

            modelBuilder.Entity("mi_kan_project_backend.Models.School", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SchoolNameEn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SchoolNameTh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Schools");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9fa0035c-3f9f-4ee0-8467-44595f2d7d19"),
                            Address = "Address 1",
                            CreatedAt = new DateTime(2024, 6, 8, 20, 45, 4, 180, DateTimeKind.Local).AddTicks(4213),
                            Email = "school01@gmail.com",
                            IsActive = true,
                            PhoneNumber = "0666666666",
                            SchoolNameTh = "โรงเรียน 1"
                        },
                        new
                        {
                            Id = new Guid("cbee6f33-74ee-4380-a0fa-baf8f7e16fa3"),
                            Address = "Address 2",
                            CreatedAt = new DateTime(2024, 6, 8, 20, 45, 4, 180, DateTimeKind.Local).AddTicks(4215),
                            Email = "school02@gmail.com",
                            IsActive = true,
                            PhoneNumber = "0777777777",
                            SchoolNameTh = "โรงเรียน 2"
                        });
                });

            modelBuilder.Entity("mi_kan_project_backend.Models.SchoolYear", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("SchoolYearNameEn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SchoolYearNameTh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SchoolYears");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9edbd89e-e9f1-49f9-9353-d4a502a3e25b"),
                            CreatedAt = new DateTime(2024, 6, 8, 20, 45, 4, 180, DateTimeKind.Local).AddTicks(4224),
                            IsActive = true,
                            SchoolYearNameTh = "ปีการศึกษา 1"
                        },
                        new
                        {
                            Id = new Guid("b1eea80a-d39d-4b5f-b7f2-58c98a92eb67"),
                            CreatedAt = new DateTime(2024, 6, 8, 20, 45, 4, 180, DateTimeKind.Local).AddTicks(4226),
                            IsActive = true,
                            SchoolYearNameTh = "ปีการศึกษา 2"
                        });
                });

            modelBuilder.Entity("mi_kan_project_backend.Models.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ClassId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClassRoomId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("GenderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Hobby")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdCard")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Religion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SchoolId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SchoolYearId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TermId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.HasIndex("ClassRoomId");

                    b.HasIndex("GenderId");

                    b.HasIndex("SchoolId");

                    b.HasIndex("SchoolYearId");

                    b.HasIndex("TermId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("mi_kan_project_backend.Models.Term", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("TermNameEn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TermNameTh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Terms");

                    b.HasData(
                        new
                        {
                            Id = new Guid("43ce20fa-53ad-44a2-b4cf-ad453d06992d"),
                            CreatedAt = new DateTime(2024, 6, 8, 20, 45, 4, 180, DateTimeKind.Local).AddTicks(4236),
                            IsActive = true,
                            TermNameTh = "เทอม 1"
                        },
                        new
                        {
                            Id = new Guid("6e4083fa-2e87-4f1b-9b05-377658cdc2e4"),
                            CreatedAt = new DateTime(2024, 6, 8, 20, 45, 4, 180, DateTimeKind.Local).AddTicks(4237),
                            IsActive = true,
                            TermNameTh = "เทอม 2"
                        },
                        new
                        {
                            Id = new Guid("c23696aa-daa0-489e-90e6-c8b74495e0bd"),
                            CreatedAt = new DateTime(2024, 6, 8, 20, 45, 4, 180, DateTimeKind.Local).AddTicks(4245),
                            IsActive = true,
                            TermNameTh = "เทอม 1"
                        },
                        new
                        {
                            Id = new Guid("de0c0009-e745-4dd6-8bd6-9e7eaa58f5b1"),
                            CreatedAt = new DateTime(2024, 6, 8, 20, 45, 4, 180, DateTimeKind.Local).AddTicks(4246),
                            IsActive = true,
                            TermNameTh = "เทอม 2"
                        });
                });

            modelBuilder.Entity("mi_kan_project_backend.Models.Training", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("TrainingCategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TrainingNameEn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrainingNameTh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TrainingCategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Trainings");
                });

            modelBuilder.Entity("mi_kan_project_backend.Models.TrainingCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("TrainingCategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TrainingCategories");
                });

            modelBuilder.Entity("mi_kan_project_backend.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SchoolId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("SchoolId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("mi_kan_project_backend.Models.Ability", b =>
                {
                    b.HasOne("mi_kan_project_backend.Models.MultipleIntelligences", "MultipleIntelligences")
                        .WithMany()
                        .HasForeignKey("MultipleIntelligencesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("mi_kan_project_backend.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MultipleIntelligences");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("mi_kan_project_backend.Models.Student", b =>
                {
                    b.HasOne("mi_kan_project_backend.Models.Class", "Class")
                        .WithMany()
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("mi_kan_project_backend.Models.ClassRoom", "ClassRoom")
                        .WithMany()
                        .HasForeignKey("ClassRoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("mi_kan_project_backend.Models.Gender", "Gender")
                        .WithMany()
                        .HasForeignKey("GenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("mi_kan_project_backend.Models.School", "School")
                        .WithMany()
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("mi_kan_project_backend.Models.SchoolYear", "SchoolYear")
                        .WithMany()
                        .HasForeignKey("SchoolYearId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("mi_kan_project_backend.Models.Term", "Term")
                        .WithMany()
                        .HasForeignKey("TermId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");

                    b.Navigation("ClassRoom");

                    b.Navigation("Gender");

                    b.Navigation("School");

                    b.Navigation("SchoolYear");

                    b.Navigation("Term");
                });

            modelBuilder.Entity("mi_kan_project_backend.Models.Training", b =>
                {
                    b.HasOne("mi_kan_project_backend.Models.TrainingCategory", "TrainingCategory")
                        .WithMany()
                        .HasForeignKey("TrainingCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("mi_kan_project_backend.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TrainingCategory");

                    b.Navigation("User");
                });

            modelBuilder.Entity("mi_kan_project_backend.Models.User", b =>
                {
                    b.HasOne("mi_kan_project_backend.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("mi_kan_project_backend.Models.School", "School")
                        .WithMany()
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("School");
                });
#pragma warning restore 612, 618
        }
    }
}
