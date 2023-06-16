using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiRestControlFlota.Migrations
{
    /// <inheritdoc />
    public partial class PrimeraMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vehiculos",
                columns: table => new
                {
                    VEI_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VEI_CodigoVehiculo = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    VEI_PlacaVehiculo = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    VEI_Habilitado = table.Column<bool>(type: "bit", maxLength: 250, nullable: false),
                    VEI_Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VEI_Modelo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VEI_PesoLimite = table.Column<int>(type: "int", nullable: false),
                    VEI_KmInicial = table.Column<int>(type: "int", nullable: false),
                    VEI_FechaIngreso = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VEI_TimeStand = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculos", x => x.VEI_Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehiculos");
        }
    }
}
