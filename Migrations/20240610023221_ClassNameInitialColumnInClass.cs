using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mi_kan_project_backend.Migrations
{
    public partial class ClassNameInitialColumnInClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ClassNameInitial",
                table: "Classes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClassNameInitial",
                table: "Classes");
        }
    }
}
