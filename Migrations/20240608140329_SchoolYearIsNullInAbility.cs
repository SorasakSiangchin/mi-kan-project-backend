using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mi_kan_project_backend.Migrations
{
    public partial class SchoolYearIsNullInAbility : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "SchoolYear",
                table: "Abilities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "SchoolYear",
                table: "Abilities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
    }
}
