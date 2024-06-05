using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace semana4.Migrations
{
    /// <inheritdoc />
    public partial class cineportada : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Portada",
                table: "Peliculas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Portada",
                table: "Peliculas");
        }
    }
}
