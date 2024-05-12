using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LAB4_2.Migrations
{
    /// <inheritdoc />
    public partial class migr222 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Book",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Url",
                table: "Book");
        }
    }
}
