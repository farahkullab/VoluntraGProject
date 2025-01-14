using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VoluntraGProject.Migrations
{
    /// <inheritdoc />
    public partial class editing7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Events_NGOId",
                table: "Events",
                column: "NGOId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_NGOs_NGOId",
                table: "Events",
                column: "NGOId",
                principalTable: "NGOs",
                principalColumn: "NGOId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_NGOs_NGOId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_NGOId",
                table: "Events");
        }
    }
}
