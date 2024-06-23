using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mi_kan_project_backend.Migrations
{
    public partial class SchoolTestColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumn: "Id",
                keyValue: new Guid("147d58ea-f729-462d-b3df-0c437836b2e8"));

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumn: "Id",
                keyValue: new Guid("b59fc659-9e33-4c9a-9ca0-13d0d1092a33"));

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("80239ca8-a90e-4fd3-829d-e494b0a51879"));

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("8d28bdf3-8a15-466c-ab16-ddff8a0f47cd"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("7eda7b74-4c09-43ca-b9d4-5219a644a153"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("93d14a1f-5acb-423e-8dc5-9e46d2c387bc"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("37ecb0b9-8b30-4a11-8047-5fbb6cba0d98"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("75645f0c-6efb-4e8d-9197-ca61badf5080"));

            migrationBuilder.DeleteData(
                table: "SchoolYears",
                keyColumn: "Id",
                keyValue: new Guid("38f25c60-07d0-4706-af73-94365a6e1fdb"));

            migrationBuilder.DeleteData(
                table: "SchoolYears",
                keyColumn: "Id",
                keyValue: new Guid("7cdd6742-7e14-4c8a-b42a-cad3305f5f79"));

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: new Guid("d35c8b95-ba4b-4ae3-921a-f57353508cb3"));

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: new Guid("effebfd5-ecbe-4993-bf31-20fab7be13ad"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("3c04f412-a264-42a6-90f0-aac47e7f5edd"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("3f654bd2-4303-41d5-a4a3-ede8a4f80c41"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("52f22eab-c82d-451c-b919-87af5796e6d9"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("bcab1f1e-4bcc-4776-b701-d363cc2341dc"));

            migrationBuilder.AddColumn<string>(
                name: "Test",
                table: "Schools",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Test",
                table: "Schools");

            migrationBuilder.InsertData(
                table: "ClassRooms",
                columns: new[] { "Id", "ClassRoomNameEn", "ClassRoomNameTh", "CreatedAt", "CreatedBy", "IsActive", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("147d58ea-f729-462d-b3df-0c437836b2e8"), null, "1", new DateTime(2024, 6, 8, 21, 3, 29, 95, DateTimeKind.Local).AddTicks(3660), null, true, null, null },
                    { new Guid("b59fc659-9e33-4c9a-9ca0-13d0d1092a33"), null, "2", new DateTime(2024, 6, 8, 21, 3, 29, 95, DateTimeKind.Local).AddTicks(3661), null, true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "ClassNameEn", "ClassNameTh", "CreatedAt", "CreatedBy", "IsActive", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("80239ca8-a90e-4fd3-829d-e494b0a51879"), null, "1", new DateTime(2024, 6, 8, 21, 3, 29, 95, DateTimeKind.Local).AddTicks(3555), null, true, null, null },
                    { new Guid("8d28bdf3-8a15-466c-ab16-ddff8a0f47cd"), null, "2", new DateTime(2024, 6, 8, 21, 3, 29, 95, DateTimeKind.Local).AddTicks(3574), null, true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "GenderNameEn", "GenderNameTh" },
                values: new object[,]
                {
                    { new Guid("7eda7b74-4c09-43ca-b9d4-5219a644a153"), null, "ชาย" },
                    { new Guid("93d14a1f-5acb-423e-8dc5-9e46d2c387bc"), null, "หญิง" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "RoleCode", "RoleName" },
                values: new object[,]
                {
                    { new Guid("37ecb0b9-8b30-4a11-8047-5fbb6cba0d98"), "admin", "ผู้ดูแลระบบ" },
                    { new Guid("75645f0c-6efb-4e8d-9197-ca61badf5080"), "teacher", "คุณครู" }
                });

            migrationBuilder.InsertData(
                table: "SchoolYears",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsActive", "SchoolYearNameEn", "SchoolYearNameTh", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("38f25c60-07d0-4706-af73-94365a6e1fdb"), new DateTime(2024, 6, 8, 21, 3, 29, 95, DateTimeKind.Local).AddTicks(3720), null, true, null, "ปีการศึกษา 1", null, null },
                    { new Guid("7cdd6742-7e14-4c8a-b42a-cad3305f5f79"), new DateTime(2024, 6, 8, 21, 3, 29, 95, DateTimeKind.Local).AddTicks(3721), null, true, null, "ปีการศึกษา 2", null, null }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "Address", "CreatedAt", "CreatedBy", "Email", "IsActive", "PhoneNumber", "SchoolNameEn", "SchoolNameTh", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("d35c8b95-ba4b-4ae3-921a-f57353508cb3"), "Address 2", new DateTime(2024, 6, 8, 21, 3, 29, 95, DateTimeKind.Local).AddTicks(3702), null, "school02@gmail.com", true, "0777777777", null, "โรงเรียน 2", null, null },
                    { new Guid("effebfd5-ecbe-4993-bf31-20fab7be13ad"), "Address 1", new DateTime(2024, 6, 8, 21, 3, 29, 95, DateTimeKind.Local).AddTicks(3699), null, "school01@gmail.com", true, "0666666666", null, "โรงเรียน 1", null, null }
                });

            migrationBuilder.InsertData(
                table: "Terms",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsActive", "TermNameEn", "TermNameTh", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("3c04f412-a264-42a6-90f0-aac47e7f5edd"), new DateTime(2024, 6, 8, 21, 3, 29, 95, DateTimeKind.Local).AddTicks(3767), null, true, null, "เทอม 2", null, null },
                    { new Guid("3f654bd2-4303-41d5-a4a3-ede8a4f80c41"), new DateTime(2024, 6, 8, 21, 3, 29, 95, DateTimeKind.Local).AddTicks(3766), null, true, null, "เทอม 1", null, null },
                    { new Guid("52f22eab-c82d-451c-b919-87af5796e6d9"), new DateTime(2024, 6, 8, 21, 3, 29, 95, DateTimeKind.Local).AddTicks(3758), null, true, null, "เทอม 2", null, null },
                    { new Guid("bcab1f1e-4bcc-4776-b701-d363cc2341dc"), new DateTime(2024, 6, 8, 21, 3, 29, 95, DateTimeKind.Local).AddTicks(3756), null, true, null, "เทอม 1", null, null }
                });
        }
    }
}
