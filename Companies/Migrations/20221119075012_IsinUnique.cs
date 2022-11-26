using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Companies.Migrations
{
    /// <inheritdoc />
    public partial class IsinUnique : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Companies_Isin",
                table: "Companies",
                column: "Isin",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Companies_Isin",
                table: "Companies");
        }
    }
}
