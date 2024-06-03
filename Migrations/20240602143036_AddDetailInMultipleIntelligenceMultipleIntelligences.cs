using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mi_kan_project_backend.Migrations
{
    public partial class AddDetailInMultipleIntelligenceMultipleIntelligences : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumn: "Id",
                keyValue: new Guid("2747d6a6-c58e-4d82-9c76-e17971965921"));

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumn: "Id",
                keyValue: new Guid("66a933ca-2d15-4407-b0c4-5311fe8a5b2c"));

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("d259fce9-1a8d-4bce-8758-37fc0189f8e6"));

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("f3355f53-1d76-4092-8315-a2e65ca7fe94"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("1bc9f8ef-d9aa-40a9-98ee-4ca146d807cb"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("dfc2f95f-a22a-4c77-a500-9afdabb13529"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("62bafb8f-84df-4850-970f-f47ddc557787"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("fd7b2ecf-6652-456c-9fee-6c0df9c09c74"));

            migrationBuilder.DeleteData(
                table: "SchoolYears",
                keyColumn: "Id",
                keyValue: new Guid("ef3c8246-35d8-4b08-9ad5-ef7f70cb0337"));

            migrationBuilder.DeleteData(
                table: "SchoolYears",
                keyColumn: "Id",
                keyValue: new Guid("f8307230-95aa-4b4f-91a5-d1910eb2da38"));

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: new Guid("4ffa2268-9b08-4d19-89b2-c05f5ba4ca22"));

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: new Guid("ccf7ce31-3e0e-41f6-aa3e-e9d1c1e52126"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("211fbbaa-a7a8-4cf3-a8be-f96027527ad0"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("835079e8-5f10-42f6-bae7-67fdbbb72811"));

            migrationBuilder.AddColumn<string>(
                name: "Detail",
                table: "MultipleIntelligences",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Detail",
                table: "MultipleIntelligences");

            migrationBuilder.InsertData(
                table: "ClassRooms",
                columns: new[] { "Id", "ClassRoomNameEn", "ClassRoomNameTh", "CreatedAt", "CreatedBy", "IsActive", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("2747d6a6-c58e-4d82-9c76-e17971965921"), null, "2", new DateTime(2024, 5, 18, 20, 37, 42, 185, DateTimeKind.Local).AddTicks(4970), null, true, null, null },
                    { new Guid("66a933ca-2d15-4407-b0c4-5311fe8a5b2c"), null, "1", new DateTime(2024, 5, 18, 20, 37, 42, 185, DateTimeKind.Local).AddTicks(4968), null, true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "ClassNameEn", "ClassNameTh", "CreatedAt", "CreatedBy", "IsActive", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("d259fce9-1a8d-4bce-8758-37fc0189f8e6"), null, "1", new DateTime(2024, 5, 18, 20, 37, 42, 185, DateTimeKind.Local).AddTicks(4836), null, true, null, null },
                    { new Guid("f3355f53-1d76-4092-8315-a2e65ca7fe94"), null, "2", new DateTime(2024, 5, 18, 20, 37, 42, 185, DateTimeKind.Local).AddTicks(4852), null, true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "GenderNameEn", "GenderNameTh" },
                values: new object[,]
                {
                    { new Guid("1bc9f8ef-d9aa-40a9-98ee-4ca146d807cb"), null, "หญิง" },
                    { new Guid("dfc2f95f-a22a-4c77-a500-9afdabb13529"), null, "ชาย" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "RoleCode", "RoleName" },
                values: new object[,]
                {
                    { new Guid("62bafb8f-84df-4850-970f-f47ddc557787"), "teacher", "คุณครู" },
                    { new Guid("fd7b2ecf-6652-456c-9fee-6c0df9c09c74"), "admin", "ผู้ดูแลระบบ" }
                });

            migrationBuilder.InsertData(
                table: "SchoolYears",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsActive", "SchoolYearNameEn", "SchoolYearNameTh", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("ef3c8246-35d8-4b08-9ad5-ef7f70cb0337"), new DateTime(2024, 5, 18, 20, 37, 42, 185, DateTimeKind.Local).AddTicks(5037), null, true, null, "ปีการศึกษา 1", null, null },
                    { new Guid("f8307230-95aa-4b4f-91a5-d1910eb2da38"), new DateTime(2024, 5, 18, 20, 37, 42, 185, DateTimeKind.Local).AddTicks(5038), null, true, null, "ปีการศึกษา 2", null, null }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "Address", "CreatedAt", "CreatedBy", "Email", "IsActive", "PhoneNumber", "SchoolNameEn", "SchoolNameTh", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("4ffa2268-9b08-4d19-89b2-c05f5ba4ca22"), "Address 1", new DateTime(2024, 5, 18, 20, 37, 42, 185, DateTimeKind.Local).AddTicks(5019), null, "school01@gmail.com", true, "0666666666", null, "โรงเรียน 1", null, null },
                    { new Guid("ccf7ce31-3e0e-41f6-aa3e-e9d1c1e52126"), "Address 2", new DateTime(2024, 5, 18, 20, 37, 42, 185, DateTimeKind.Local).AddTicks(5021), null, "school02@gmail.com", true, "0777777777", null, "โรงเรียน 2", null, null }
                });

            migrationBuilder.InsertData(
                table: "Terms",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsActive", "TermNameEn", "TermNameTh", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("211fbbaa-a7a8-4cf3-a8be-f96027527ad0"), new DateTime(2024, 5, 18, 20, 37, 42, 185, DateTimeKind.Local).AddTicks(5050), null, true, null, "เทอม 2", null, null },
                    { new Guid("835079e8-5f10-42f6-bae7-67fdbbb72811"), new DateTime(2024, 5, 18, 20, 37, 42, 185, DateTimeKind.Local).AddTicks(5048), null, true, null, "เทอม 1", null, null }
                });
        }
    }
}
