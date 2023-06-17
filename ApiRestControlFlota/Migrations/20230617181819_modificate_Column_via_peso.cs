using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiRestControlFlota.Migrations
{
    /// <inheritdoc />
    public partial class modificate_Column_via_peso : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "VIA_Peso",
                table: "Viajes",
                type: "float",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "VIA_Peso",
                table: "Viajes",
                type: "bit",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);
        }
    }
}
