using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Karnika_Panoriya_Assignment.Migrations
{
    public partial class FourthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_studentModels",
                table: "studentModels");

            migrationBuilder.RenameTable(
                name: "studentModels",
                newName: "Student_data");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student_data",
                table: "Student_data",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Student_data",
                table: "Student_data");

            migrationBuilder.RenameTable(
                name: "Student_data",
                newName: "studentModels");

            migrationBuilder.AddPrimaryKey(
                name: "PK_studentModels",
                table: "studentModels",
                column: "Id");
        }
    }
}
