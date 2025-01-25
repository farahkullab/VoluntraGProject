using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VoluntraGProject.Migrations
{
    /// <inheritdoc />
    public partial class editing12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "NGOs");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "NGOs",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
