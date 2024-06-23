using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mi_kan_project_backend.Migrations
{
    public partial class SchoolTestColumnRemove : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Test",
                table: "Schools");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Test",
                table: "Schools",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
