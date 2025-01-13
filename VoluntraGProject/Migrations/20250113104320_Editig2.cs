using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VoluntraGProject.Migrations
{
    /// <inheritdoc />
    public partial class Editig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NGOId",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NGOId",
                table: "Events");
        }
    }
}
