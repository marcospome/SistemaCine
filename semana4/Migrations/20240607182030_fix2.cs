using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace semana4.Migrations
{
    /// <inheritdoc />
    public partial class fix2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Funcion_Peliculas_IdPelicula",
                table: "Funcion");

            migrationBuilder.DropIndex(
                name: "IX_Funcion_IdPelicula",
                table: "Funcion");

            migrationBuilder.AddColumn<int>(
                name: "PeliculaId",
                table: "Funcion",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Funcion_PeliculaId",
                table: "Funcion",
                column: "PeliculaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Funcion_Peliculas_PeliculaId",
                table: "Funcion",
                column: "PeliculaId",
                principalTable: "Peliculas",
                principalColumn: "PeliculaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Funcion_Peliculas_PeliculaId",
                table: "Funcion");

            migrationBuilder.DropIndex(
                name: "IX_Funcion_PeliculaId",
                table: "Funcion");

            migrationBuilder.DropColumn(
                name: "PeliculaId",
                table: "Funcion");

            migrationBuilder.CreateIndex(
                name: "IX_Funcion_IdPelicula",
                table: "Funcion",
                column: "IdPelicula");

            migrationBuilder.AddForeignKey(
                name: "FK_Funcion_Peliculas_IdPelicula",
                table: "Funcion",
                column: "IdPelicula",
                principalTable: "Peliculas",
                principalColumn: "PeliculaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
