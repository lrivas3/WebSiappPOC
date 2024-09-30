using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebSiapp.Infrastructure.DrivenAdapters.Database.Migrations
{
    /// <inheritdoc />
    public partial class algo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "PRUEBA");

            migrationBuilder.RenameTable(
                name: "PersonaEmpresa",
                newName: "PersonaEmpresa",
                newSchema: "PRUEBA");

            migrationBuilder.RenameTable(
                name: "Persona",
                newName: "Persona",
                newSchema: "PRUEBA");

            migrationBuilder.RenameTable(
                name: "Empresa",
                newName: "Empresa",
                newSchema: "PRUEBA");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "PersonaEmpresa",
                schema: "PRUEBA",
                newName: "PersonaEmpresa");

            migrationBuilder.RenameTable(
                name: "Persona",
                schema: "PRUEBA",
                newName: "Persona");

            migrationBuilder.RenameTable(
                name: "Empresa",
                schema: "PRUEBA",
                newName: "Empresa");
        }
    }
}
