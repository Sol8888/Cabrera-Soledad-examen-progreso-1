using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cabrera_Soledad_examen_progreso_1.Migrations
{
    /// <inheritdoc />
    public partial class nombresito : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Proedio",
                table: "SCabrera",
                newName: "Promedio");

            migrationBuilder.RenameColumn(
                name: "precio",
                table: "Celular",
                newName: "Precio");

            migrationBuilder.RenameColumn(
                name: "año",
                table: "Celular",
                newName: "Anio");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Promedio",
                table: "SCabrera",
                newName: "Proedio");

            migrationBuilder.RenameColumn(
                name: "Precio",
                table: "Celular",
                newName: "precio");

            migrationBuilder.RenameColumn(
                name: "Anio",
                table: "Celular",
                newName: "año");
        }
    }
}
