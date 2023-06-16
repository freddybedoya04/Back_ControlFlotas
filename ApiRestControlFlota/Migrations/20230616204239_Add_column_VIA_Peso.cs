using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiRestControlFlota.Migrations
{
    /// <inheritdoc />
    public partial class Add_column_VIA_Peso : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "VIA_Peso",
                table: "Viajes",
                type: "bit",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VIA_Peso",
                table: "Viajes");
        }
    }
}
