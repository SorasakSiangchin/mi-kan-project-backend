using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mi_kan_project_backend.Migrations
{
    public partial class ScoreIsNullInAbility : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumn: "Id",
                keyValue: new Guid("88ff2fd0-9d84-4807-a61a-674aecb26636"));

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumn: "Id",
                keyValue: new Guid("fe355cdf-2fdc-4563-b217-e84b85ac91ce"));

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("4638882e-de73-4560-8537-bbb73d075250"));

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("6ed2b734-7931-4e1a-89db-86b1e594a297"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("4b97c891-d691-4b8e-86c8-51e2769a16a0"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("9ae1428d-9fe4-4f71-ae2d-36192a0c9315"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("0d035d4a-4284-4f8f-aa33-424be96e31e2"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("61c50c4c-22bf-4ceb-93f4-94afd3064e4f"));

            migrationBuilder.DeleteData(
                table: "SchoolYears",
                keyColumn: "Id",
                keyValue: new Guid("932e05b8-e2bc-49c4-b3d6-40fab2017ccf"));

            migrationBuilder.DeleteData(
                table: "SchoolYears",
                keyColumn: "Id",
                keyValue: new Guid("ef8cb1bb-646e-4859-aa94-c6ac76d662bd"));

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: new Guid("5e586436-ab75-47b7-8b5a-e32b2f7350ab"));

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: new Guid("653cb398-b593-41b1-8105-2300cb2ac389"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("24bdcdc7-21f3-44f4-ad72-ee08235efef6"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("92e59d18-2fcc-4d57-91d4-104b7461fd5a"));

            migrationBuilder.AlterColumn<int>(
                name: "Score",
                table: "Abilities",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "ClassRooms",
                columns: new[] { "Id", "ClassRoomNameEn", "ClassRoomNameTh", "CreatedAt", "CreatedBy", "IsActive", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("7198a8f9-3a74-40c3-b169-54d7ec4c7307"), null, "1", new DateTime(2024, 6, 8, 20, 45, 4, 180, DateTimeKind.Local).AddTicks(4170), null, true, null, null },
                    { new Guid("e5972bc1-0078-4827-b330-cfa983e9f3a4"), null, "2", new DateTime(2024, 6, 8, 20, 45, 4, 180, DateTimeKind.Local).AddTicks(4171), null, true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "ClassNameEn", "ClassNameTh", "CreatedAt", "CreatedBy", "IsActive", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("637bdff0-befc-4f2b-85a7-8f816e18c7cb"), null, "2", new DateTime(2024, 6, 8, 20, 45, 4, 180, DateTimeKind.Local).AddTicks(4080), null, true, null, null },
                    { new Guid("ac06b478-74a1-4ed9-9129-526bd44bedf4"), null, "1", new DateTime(2024, 6, 8, 20, 45, 4, 180, DateTimeKind.Local).AddTicks(4066), null, true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "GenderNameEn", "GenderNameTh" },
                values: new object[,]
                {
                    { new Guid("b2f17c73-2146-44d2-9977-58d69fd97b1f"), null, "หญิง" },
                    { new Guid("e23506c5-61c4-4ce2-ac15-748d4c3a7d23"), null, "ชาย" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "RoleCode", "RoleName" },
                values: new object[,]
                {
                    { new Guid("9446eb65-a753-4616-bda7-5bb8cf0beac0"), "teacher", "คุณครู" },
                    { new Guid("b5b5f6bd-03df-4a52-a0a0-92e99d69e9f3"), "admin", "ผู้ดูแลระบบ" }
                });

            migrationBuilder.InsertData(
                table: "SchoolYears",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsActive", "SchoolYearNameEn", "SchoolYearNameTh", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("9edbd89e-e9f1-49f9-9353-d4a502a3e25b"), new DateTime(2024, 6, 8, 20, 45, 4, 180, DateTimeKind.Local).AddTicks(4224), null, true, null, "ปีการศึกษา 1", null, null },
                    { new Guid("b1eea80a-d39d-4b5f-b7f2-58c98a92eb67"), new DateTime(2024, 6, 8, 20, 45, 4, 180, DateTimeKind.Local).AddTicks(4226), null, true, null, "ปีการศึกษา 2", null, null }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "Address", "CreatedAt", "CreatedBy", "Email", "IsActive", "PhoneNumber", "SchoolNameEn", "SchoolNameTh", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("9fa0035c-3f9f-4ee0-8467-44595f2d7d19"), "Address 1", new DateTime(2024, 6, 8, 20, 45, 4, 180, DateTimeKind.Local).AddTicks(4213), null, "school01@gmail.com", true, "0666666666", null, "โรงเรียน 1", null, null },
                    { new Guid("cbee6f33-74ee-4380-a0fa-baf8f7e16fa3"), "Address 2", new DateTime(2024, 6, 8, 20, 45, 4, 180, DateTimeKind.Local).AddTicks(4215), null, "school02@gmail.com", true, "0777777777", null, "โรงเรียน 2", null, null }
                });

            migrationBuilder.InsertData(
                table: "Terms",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsActive", "TermNameEn", "TermNameTh", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("43ce20fa-53ad-44a2-b4cf-ad453d06992d"), new DateTime(2024, 6, 8, 20, 45, 4, 180, DateTimeKind.Local).AddTicks(4236), null, true, null, "เทอม 1", null, null },
                    { new Guid("6e4083fa-2e87-4f1b-9b05-377658cdc2e4"), new DateTime(2024, 6, 8, 20, 45, 4, 180, DateTimeKind.Local).AddTicks(4237), null, true, null, "เทอม 2", null, null },
                    { new Guid("c23696aa-daa0-489e-90e6-c8b74495e0bd"), new DateTime(2024, 6, 8, 20, 45, 4, 180, DateTimeKind.Local).AddTicks(4245), null, true, null, "เทอม 1", null, null },
                    { new Guid("de0c0009-e745-4dd6-8bd6-9e7eaa58f5b1"), new DateTime(2024, 6, 8, 20, 45, 4, 180, DateTimeKind.Local).AddTicks(4246), null, true, null, "เทอม 2", null, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumn: "Id",
                keyValue: new Guid("7198a8f9-3a74-40c3-b169-54d7ec4c7307"));

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumn: "Id",
                keyValue: new Guid("e5972bc1-0078-4827-b330-cfa983e9f3a4"));

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("637bdff0-befc-4f2b-85a7-8f816e18c7cb"));

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("ac06b478-74a1-4ed9-9129-526bd44bedf4"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("b2f17c73-2146-44d2-9977-58d69fd97b1f"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("e23506c5-61c4-4ce2-ac15-748d4c3a7d23"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9446eb65-a753-4616-bda7-5bb8cf0beac0"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b5b5f6bd-03df-4a52-a0a0-92e99d69e9f3"));

            migrationBuilder.DeleteData(
                table: "SchoolYears",
                keyColumn: "Id",
                keyValue: new Guid("9edbd89e-e9f1-49f9-9353-d4a502a3e25b"));

            migrationBuilder.DeleteData(
                table: "SchoolYears",
                keyColumn: "Id",
                keyValue: new Guid("b1eea80a-d39d-4b5f-b7f2-58c98a92eb67"));

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: new Guid("9fa0035c-3f9f-4ee0-8467-44595f2d7d19"));

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: new Guid("cbee6f33-74ee-4380-a0fa-baf8f7e16fa3"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("43ce20fa-53ad-44a2-b4cf-ad453d06992d"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("6e4083fa-2e87-4f1b-9b05-377658cdc2e4"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("c23696aa-daa0-489e-90e6-c8b74495e0bd"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("de0c0009-e745-4dd6-8bd6-9e7eaa58f5b1"));

            migrationBuilder.AlterColumn<int>(
                name: "Score",
                table: "Abilities",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "ClassRooms",
                columns: new[] { "Id", "ClassRoomNameEn", "ClassRoomNameTh", "CreatedAt", "CreatedBy", "IsActive", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("88ff2fd0-9d84-4807-a61a-674aecb26636"), null, "1", new DateTime(2024, 6, 2, 21, 30, 36, 193, DateTimeKind.Local).AddTicks(7067), null, true, null, null },
                    { new Guid("fe355cdf-2fdc-4563-b217-e84b85ac91ce"), null, "2", new DateTime(2024, 6, 2, 21, 30, 36, 193, DateTimeKind.Local).AddTicks(7069), null, true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "ClassNameEn", "ClassNameTh", "CreatedAt", "CreatedBy", "IsActive", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("4638882e-de73-4560-8537-bbb73d075250"), null, "2", new DateTime(2024, 6, 2, 21, 30, 36, 193, DateTimeKind.Local).AddTicks(6986), null, true, null, null },
                    { new Guid("6ed2b734-7931-4e1a-89db-86b1e594a297"), null, "1", new DateTime(2024, 6, 2, 21, 30, 36, 193, DateTimeKind.Local).AddTicks(6965), null, true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "GenderNameEn", "GenderNameTh" },
                values: new object[,]
                {
                    { new Guid("4b97c891-d691-4b8e-86c8-51e2769a16a0"), null, "ชาย" },
                    { new Guid("9ae1428d-9fe4-4f71-ae2d-36192a0c9315"), null, "หญิง" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "RoleCode", "RoleName" },
                values: new object[,]
                {
                    { new Guid("0d035d4a-4284-4f8f-aa33-424be96e31e2"), "teacher", "คุณครู" },
                    { new Guid("61c50c4c-22bf-4ceb-93f4-94afd3064e4f"), "admin", "ผู้ดูแลระบบ" }
                });

            migrationBuilder.InsertData(
                table: "SchoolYears",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsActive", "SchoolYearNameEn", "SchoolYearNameTh", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("932e05b8-e2bc-49c4-b3d6-40fab2017ccf"), new DateTime(2024, 6, 2, 21, 30, 36, 193, DateTimeKind.Local).AddTicks(7141), null, true, null, "ปีการศึกษา 2", null, null },
                    { new Guid("ef8cb1bb-646e-4859-aa94-c6ac76d662bd"), new DateTime(2024, 6, 2, 21, 30, 36, 193, DateTimeKind.Local).AddTicks(7140), null, true, null, "ปีการศึกษา 1", null, null }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "Address", "CreatedAt", "CreatedBy", "Email", "IsActive", "PhoneNumber", "SchoolNameEn", "SchoolNameTh", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("5e586436-ab75-47b7-8b5a-e32b2f7350ab"), "Address 1", new DateTime(2024, 6, 2, 21, 30, 36, 193, DateTimeKind.Local).AddTicks(7098), null, "school01@gmail.com", true, "0666666666", null, "โรงเรียน 1", null, null },
                    { new Guid("653cb398-b593-41b1-8105-2300cb2ac389"), "Address 2", new DateTime(2024, 6, 2, 21, 30, 36, 193, DateTimeKind.Local).AddTicks(7102), null, "school02@gmail.com", true, "0777777777", null, "โรงเรียน 2", null, null }
                });

            migrationBuilder.InsertData(
                table: "Terms",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsActive", "TermNameEn", "TermNameTh", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("24bdcdc7-21f3-44f4-ad72-ee08235efef6"), new DateTime(2024, 6, 2, 21, 30, 36, 193, DateTimeKind.Local).AddTicks(7153), null, true, null, "เทอม 2", null, null },
                    { new Guid("92e59d18-2fcc-4d57-91d4-104b7461fd5a"), new DateTime(2024, 6, 2, 21, 30, 36, 193, DateTimeKind.Local).AddTicks(7152), null, true, null, "เทอม 1", null, null }
                });
        }
    }
}
