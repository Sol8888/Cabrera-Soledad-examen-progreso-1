using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cabrera_Soledad_examen_progreso_1.Migrations
{
    /// <inheritdoc />
    public partial class migra1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Celular",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Modelo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    año = table.Column<int>(type: "int", maxLength: 10000, nullable: false),
                    precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Celular", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SCabrera",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Edad = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SabeIngles = table.Column<bool>(type: "bit", nullable: false),
                    Proedio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Cumpleanios = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdCelular = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SCabrera", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SCabrera_Celular_IdCelular",
                        column: x => x.IdCelular,
                        principalTable: "Celular",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SCabrera_IdCelular",
                table: "SCabrera",
                column: "IdCelular");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SCabrera");

            migrationBuilder.DropTable(
                name: "Celular");
        }
    }
}
