using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LAB4_2.Migrations
{
    /// <inheritdoc />
    public partial class migr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "rate",
                table: "Book",
                newName: "Rate");

            migrationBuilder.AddColumn<int>(
                name: "RateCount",
                table: "Book",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RateCount",
                table: "Book");

            migrationBuilder.RenameColumn(
                name: "Rate",
                table: "Book",
                newName: "rate");
        }
    }
}
