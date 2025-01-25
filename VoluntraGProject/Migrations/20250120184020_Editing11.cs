using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VoluntraGProject.Migrations
{
    /// <inheritdoc />
    public partial class Editing11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TStatus",
                table: "NGOs",
                newName: "Status");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "NGOs",
                newName: "TStatus");
        }
    }
}
