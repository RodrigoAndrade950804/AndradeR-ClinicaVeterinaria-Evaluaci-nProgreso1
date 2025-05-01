using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AndradeR_ClinicaVeterinaria_EvaluaciónProgreso1.Migrations
{
    /// <inheritdoc />
    public partial class RodrigoAndrade2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Mascota_DueñoId",
                table: "Mascota",
                column: "DueñoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Mascota_DueñoMascota_DueñoId",
                table: "Mascota",
                column: "DueñoId",
                principalTable: "DueñoMascota",
                principalColumn: "DueñoId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mascota_DueñoMascota_DueñoId",
                table: "Mascota");

            migrationBuilder.DropIndex(
                name: "IX_Mascota_DueñoId",
                table: "Mascota");
        }
    }
}
