using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Karnika_Panoriya_Assignment.Migrations
{
    public partial class FivthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Ideal");

            migrationBuilder.RenameTable(
                name: "Student_data",
                newName: "Student_data",
                newSchema: "Ideal");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                schema: "Ideal",
                table: "Student_data",
                newName: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Student_data",
                schema: "Ideal",
                newName: "Student_data");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Student_data",
                newName: "FirstName");
        }
    }
}
