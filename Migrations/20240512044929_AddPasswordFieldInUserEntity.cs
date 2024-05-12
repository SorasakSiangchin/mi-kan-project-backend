using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mi_kan_project_backend.Migrations
{
    public partial class AddPasswordFieldInUserEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumn: "Id",
                keyValue: new Guid("a41d7d77-f753-41c7-8398-d63517a0dee3"));

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumn: "Id",
                keyValue: new Guid("cf7e4c43-1c38-4251-9b68-d319eb963d19"));

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("0b91244a-9087-45a5-a80a-9d4c88bb091d"));

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("1124cf5a-6d96-4a05-844c-8a3a80c8e81c"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("62d17cf4-9130-4c0d-b7b7-66e6bc11079c"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("99ea90e8-c8ef-45e2-86f4-0ce3df6660e1"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("7789c1b7-d8a8-484f-976b-f1d84c96e577"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e82d41dd-1060-4953-9992-ac328e07e8e1"));

            migrationBuilder.DeleteData(
                table: "SchoolYears",
                keyColumn: "Id",
                keyValue: new Guid("6122db77-715b-45fc-b1cf-255b06d53549"));

            migrationBuilder.DeleteData(
                table: "SchoolYears",
                keyColumn: "Id",
                keyValue: new Guid("d414ae8f-37ac-46e0-bb32-ca52aff65c25"));

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: new Guid("7ceed84b-0e3f-4d85-aeeb-ef92f1e8be38"));

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: new Guid("c3e93ba4-c4ef-40a5-8d1b-cc80f6dc8cf6"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("4a2f3794-e971-4155-bdf4-7306c22d188c"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("8fa58d00-5c34-4263-bd44-4961d04a8a52"));

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "ClassRooms",
                columns: new[] { "Id", "ClassRoomNameEn", "ClassRoomNameTh", "CreatedAt", "CreatedBy", "IsActive", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("4049aba5-3396-46e6-bbe8-9f32666b9af5"), null, "1", null, new DateTime(2024, 5, 12, 11, 49, 28, 483, DateTimeKind.Local).AddTicks(3420), true, null, null },
                    { new Guid("a1f88413-6583-42be-90e3-f04f52c19f02"), null, "2", null, new DateTime(2024, 5, 12, 11, 49, 28, 483, DateTimeKind.Local).AddTicks(3423), true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "ClassNameEn", "ClassNameTh", "CreatedAt", "CreatedBy", "IsActive", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("3482f085-1120-49a8-a6c6-8cda51f3ed42"), null, "2", null, new DateTime(2024, 5, 12, 11, 49, 28, 483, DateTimeKind.Local).AddTicks(3246), true, null, null },
                    { new Guid("bb57c605-a22f-46b7-8462-3969864b91f1"), null, "1", null, new DateTime(2024, 5, 12, 11, 49, 28, 483, DateTimeKind.Local).AddTicks(3216), true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "GenderNameEn", "GenderNameTh" },
                values: new object[,]
                {
                    { new Guid("10c89d4e-097f-43e4-930d-7e575e400909"), null, "หญิง" },
                    { new Guid("87185e70-67b2-4f1c-90c7-a4569acfa968"), null, "ชาย" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "RoleCode", "RoleName" },
                values: new object[,]
                {
                    { new Guid("68fa4b1c-ec54-4417-9aa5-4b73702e8158"), "teacher", "คุณครู" },
                    { new Guid("867f8d12-2e5b-4f60-b251-7b30cfb74879"), "admin", "ผู้ดูแลระบบ" }
                });

            migrationBuilder.InsertData(
                table: "SchoolYears",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsActive", "SchoolYearNameEn", "SchoolYearNameTh", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("2c28703e-492d-4a81-bab1-51315c57a1af"), null, new DateTime(2024, 5, 12, 11, 49, 28, 483, DateTimeKind.Local).AddTicks(3505), true, null, "ปีการศึกษา 2", null, null },
                    { new Guid("6d62ebaf-896e-4f6e-be26-b8e66055c93b"), null, new DateTime(2024, 5, 12, 11, 49, 28, 483, DateTimeKind.Local).AddTicks(3503), true, null, "ปีการศึกษา 1", null, null }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "Address", "CreatedAt", "CreatedBy", "Email", "IsActive", "PhoneNumber", "SchoolNameEn", "SchoolNameTh", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("53674b85-9308-458c-b8f0-a72c0eced83c"), "Address 2", null, new DateTime(2024, 5, 12, 11, 49, 28, 483, DateTimeKind.Local).AddTicks(3485), "school02@gmail.com", true, "0777777777", null, "โรงเรียน 2", null, null },
                    { new Guid("ee103e28-c40d-4245-b81e-56f26b4d59d0"), "Address 1", null, new DateTime(2024, 5, 12, 11, 49, 28, 483, DateTimeKind.Local).AddTicks(3481), "school01@gmail.com", true, "0666666666", null, "โรงเรียน 1", null, null }
                });

            migrationBuilder.InsertData(
                table: "Terms",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsActive", "TermNameEn", "TermNameTh", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("0b03d678-bcd0-49c5-88c9-59b096cdeb06"), null, new DateTime(2024, 5, 12, 11, 49, 28, 483, DateTimeKind.Local).AddTicks(3523), true, null, "เทอม 2", null, null },
                    { new Guid("d7a3fa32-0a17-47a8-b64c-404b5c8e2e93"), null, new DateTime(2024, 5, 12, 11, 49, 28, 483, DateTimeKind.Local).AddTicks(3521), true, null, "เทอม 1", null, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumn: "Id",
                keyValue: new Guid("4049aba5-3396-46e6-bbe8-9f32666b9af5"));

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumn: "Id",
                keyValue: new Guid("a1f88413-6583-42be-90e3-f04f52c19f02"));

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("3482f085-1120-49a8-a6c6-8cda51f3ed42"));

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: new Guid("bb57c605-a22f-46b7-8462-3969864b91f1"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("10c89d4e-097f-43e4-930d-7e575e400909"));

            migrationBuilder.DeleteData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: new Guid("87185e70-67b2-4f1c-90c7-a4569acfa968"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("68fa4b1c-ec54-4417-9aa5-4b73702e8158"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("867f8d12-2e5b-4f60-b251-7b30cfb74879"));

            migrationBuilder.DeleteData(
                table: "SchoolYears",
                keyColumn: "Id",
                keyValue: new Guid("2c28703e-492d-4a81-bab1-51315c57a1af"));

            migrationBuilder.DeleteData(
                table: "SchoolYears",
                keyColumn: "Id",
                keyValue: new Guid("6d62ebaf-896e-4f6e-be26-b8e66055c93b"));

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: new Guid("53674b85-9308-458c-b8f0-a72c0eced83c"));

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: new Guid("ee103e28-c40d-4245-b81e-56f26b4d59d0"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("0b03d678-bcd0-49c5-88c9-59b096cdeb06"));

            migrationBuilder.DeleteData(
                table: "Terms",
                keyColumn: "Id",
                keyValue: new Guid("d7a3fa32-0a17-47a8-b64c-404b5c8e2e93"));

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Users");

            migrationBuilder.InsertData(
                table: "ClassRooms",
                columns: new[] { "Id", "ClassRoomNameEn", "ClassRoomNameTh", "CreatedAt", "CreatedBy", "IsActive", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("a41d7d77-f753-41c7-8398-d63517a0dee3"), null, "2", null, new DateTime(2024, 5, 5, 11, 39, 21, 240, DateTimeKind.Local).AddTicks(7173), true, null, null },
                    { new Guid("cf7e4c43-1c38-4251-9b68-d319eb963d19"), null, "1", null, new DateTime(2024, 5, 5, 11, 39, 21, 240, DateTimeKind.Local).AddTicks(7171), true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "ClassNameEn", "ClassNameTh", "CreatedAt", "CreatedBy", "IsActive", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("0b91244a-9087-45a5-a80a-9d4c88bb091d"), null, "1", null, new DateTime(2024, 5, 5, 11, 39, 21, 240, DateTimeKind.Local).AddTicks(7076), true, null, null },
                    { new Guid("1124cf5a-6d96-4a05-844c-8a3a80c8e81c"), null, "2", null, new DateTime(2024, 5, 5, 11, 39, 21, 240, DateTimeKind.Local).AddTicks(7087), true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "GenderNameEn", "GenderNameTh" },
                values: new object[,]
                {
                    { new Guid("62d17cf4-9130-4c0d-b7b7-66e6bc11079c"), null, "ชาย" },
                    { new Guid("99ea90e8-c8ef-45e2-86f4-0ce3df6660e1"), null, "หญิง" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "RoleCode", "RoleName" },
                values: new object[,]
                {
                    { new Guid("7789c1b7-d8a8-484f-976b-f1d84c96e577"), "teacher", "คุณครู" },
                    { new Guid("e82d41dd-1060-4953-9992-ac328e07e8e1"), "admin", "ผู้ดูแลระบบ" }
                });

            migrationBuilder.InsertData(
                table: "SchoolYears",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsActive", "SchoolYearNameEn", "SchoolYearNameTh", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("6122db77-715b-45fc-b1cf-255b06d53549"), null, new DateTime(2024, 5, 5, 11, 39, 21, 240, DateTimeKind.Local).AddTicks(7228), true, null, "ปีการศึกษา 1", null, null },
                    { new Guid("d414ae8f-37ac-46e0-bb32-ca52aff65c25"), null, new DateTime(2024, 5, 5, 11, 39, 21, 240, DateTimeKind.Local).AddTicks(7229), true, null, "ปีการศึกษา 2", null, null }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "Address", "CreatedAt", "CreatedBy", "Email", "IsActive", "PhoneNumber", "SchoolNameEn", "SchoolNameTh", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("7ceed84b-0e3f-4d85-aeeb-ef92f1e8be38"), "Address 2", null, new DateTime(2024, 5, 5, 11, 39, 21, 240, DateTimeKind.Local).AddTicks(7218), "school02@gmail.com", true, "0777777777", null, "โรงเรียน 2", null, null },
                    { new Guid("c3e93ba4-c4ef-40a5-8d1b-cc80f6dc8cf6"), "Address 1", null, new DateTime(2024, 5, 5, 11, 39, 21, 240, DateTimeKind.Local).AddTicks(7215), "school01@gmail.com", true, "0666666666", null, "โรงเรียน 1", null, null }
                });

            migrationBuilder.InsertData(
                table: "Terms",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsActive", "TermNameEn", "TermNameTh", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("4a2f3794-e971-4155-bdf4-7306c22d188c"), null, new DateTime(2024, 5, 5, 11, 39, 21, 240, DateTimeKind.Local).AddTicks(7244), true, null, "เทอม 2", null, null },
                    { new Guid("8fa58d00-5c34-4263-bd44-4961d04a8a52"), null, new DateTime(2024, 5, 5, 11, 39, 21, 240, DateTimeKind.Local).AddTicks(7242), true, null, "เทอม 1", null, null }
                });
        }
    }
}
