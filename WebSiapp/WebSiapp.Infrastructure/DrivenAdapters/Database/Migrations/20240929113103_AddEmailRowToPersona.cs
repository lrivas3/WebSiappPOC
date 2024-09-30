using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebSiapp.Infrastructure.DrivenAdapters.Database.Migrations
{
    /// <inheritdoc />
    public partial class AddEmailRowToPersona : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Persona",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Persona");
        }
    }
}
