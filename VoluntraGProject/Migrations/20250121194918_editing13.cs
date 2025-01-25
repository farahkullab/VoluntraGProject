using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VoluntraGProject.Migrations
{
    /// <inheritdoc />
    public partial class editing13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Experince",
                table: "Applications",
                newName: "Yourfield");

            migrationBuilder.AddColumn<string>(
                name: "Age",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Experience",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsExpereinced",
                table: "Applications",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "TravelingAbility",
                table: "Applications",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "YearsOfExperience",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "Experience",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "IsExpereinced",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "TravelingAbility",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "YearsOfExperience",
                table: "Applications");

            migrationBuilder.RenameColumn(
                name: "Yourfield",
                table: "Applications",
                newName: "Experince");
        }
    }
}
