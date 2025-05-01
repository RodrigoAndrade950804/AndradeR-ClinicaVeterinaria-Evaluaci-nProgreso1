using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AndradeR_ClinicaVeterinaria_EvaluaciónProgreso1.Migrations
{
    /// <inheritdoc />
    public partial class RodrigoAndrade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DueñoMascota",
                columns: table => new
                {
                    DueñoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SaldoPendiente = table.Column<float>(type: "real", nullable: false),
                    EsClienteFrecuente = table.Column<bool>(type: "bit", nullable: false),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DueñoMascota", x => x.DueñoId);
                });

            migrationBuilder.CreateTable(
                name: "Mascota",
                columns: table => new
                {
                    MascotaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Especie = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    Peso = table.Column<float>(type: "real", nullable: false),
                    DueñoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mascota", x => x.MascotaId);
                });

            migrationBuilder.CreateTable(
                name: "VisitaVeterinaria",
                columns: table => new
                {
                    VisitaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaVisita = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Motivo = table.Column<int>(type: "int", nullable: false),
                    RequiereMedicación = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitaVeterinaria", x => x.VisitaId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DueñoMascota");

            migrationBuilder.DropTable(
                name: "Mascota");

            migrationBuilder.DropTable(
                name: "VisitaVeterinaria");
        }
    }
}
