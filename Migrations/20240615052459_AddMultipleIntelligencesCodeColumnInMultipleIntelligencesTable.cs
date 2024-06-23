using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mi_kan_project_backend.Migrations
{
    public partial class AddMultipleIntelligencesCodeColumnInMultipleIntelligencesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MultipleIntelligencesCode",
                table: "MultipleIntelligences",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MultipleIntelligencesCode",
                table: "MultipleIntelligences");
        }
    }
}
