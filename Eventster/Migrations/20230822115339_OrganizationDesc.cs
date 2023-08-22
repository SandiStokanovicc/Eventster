using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eventster.Migrations
{
    /// <inheritdoc />
    public partial class OrganizationDesc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Organizations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Organizations");
        }
    }
}
