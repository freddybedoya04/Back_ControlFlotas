using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiRestControlFlota.Migrations
{
    /// <inheritdoc />
    public partial class change_Column_VIA_Destino : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "VIA_Destino",
                table: "Viajes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "VIA_Destino",
                table: "Viajes",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
