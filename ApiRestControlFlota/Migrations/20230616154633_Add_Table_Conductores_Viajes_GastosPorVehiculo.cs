using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiRestControlFlota.Migrations
{
    /// <inheritdoc />
    public partial class Add_Table_Conductores_Viajes_GastosPorVehiculo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "VEI_TimeStand",
                table: "Vehiculos",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "VEI_PesoLimite",
                table: "Vehiculos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "VEI_KmInicial",
                table: "Vehiculos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "VEI_FechaIngreso",
                table: "Vehiculos",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.CreateTable(
                name: "Conductores",
                columns: table => new
                {
                    CON_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CON_CedulaConductor = table.Column<int>(type: "int", nullable: false),
                    CON_NombresConductor = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CON_ApellidosConductor = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CON_Habilitado = table.Column<bool>(type: "bit", maxLength: 250, nullable: false),
                    CON_FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CON_TipoLicencia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CON_FechaIngreso = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CON_TimeStand = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conductores", x => x.CON_Id);
                });

            migrationBuilder.CreateTable(
                name: "GastoPorVehiculos",
                columns: table => new
                {
                    GPV_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VEI_CodigoVehiculo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GPV_Valor = table.Column<double>(type: "float", nullable: false),
                    GPV_Detalle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GPV_Habilitado = table.Column<bool>(type: "bit", nullable: false),
                    GPV_FechaIngreso = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GPV_TimeStand = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GastoPorVehiculos", x => x.GPV_Id);
                });

            migrationBuilder.CreateTable(
                name: "Viajes",
                columns: table => new
                {
                    VIA_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VIA_FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VIA_Empresa = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    VIA_Manifiesto = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CON_CedulaConductor = table.Column<int>(type: "int", nullable: false),
                    VEI_CodigoVehiculo = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    VIA_Origen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VIA_Destino = table.Column<int>(type: "int", nullable: false),
                    VIA_KmRecorridos = table.Column<int>(type: "int", nullable: false),
                    VIA_PagoConductor = table.Column<double>(type: "float", nullable: true),
                    VIA_PagoCombustible = table.Column<double>(type: "float", nullable: true),
                    VIA_PagoPeajes = table.Column<double>(type: "float", nullable: true),
                    VIA_PagoOtros = table.Column<double>(type: "float", nullable: true),
                    VIA_DetallesViaje = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VIA_ValorViaje = table.Column<double>(type: "float", nullable: true),
                    VIA_Utilidades = table.Column<double>(type: "float", nullable: true),
                    VIA_Habilitado = table.Column<bool>(type: "bit", nullable: true),
                    VIA_TimeStand = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Viajes", x => x.VIA_Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Conductores");

            migrationBuilder.DropTable(
                name: "GastoPorVehiculos");

            migrationBuilder.DropTable(
                name: "Viajes");

            migrationBuilder.AlterColumn<DateTime>(
                name: "VEI_TimeStand",
                table: "Vehiculos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "VEI_PesoLimite",
                table: "Vehiculos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "VEI_KmInicial",
                table: "Vehiculos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "VEI_FechaIngreso",
                table: "Vehiculos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);
        }
    }
}
