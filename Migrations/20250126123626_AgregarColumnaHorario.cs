using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BioShopDB.Migrations
{
    /// <inheritdoc />
    public partial class AgregarColumnaHorario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Dirección",
                table: "Tiendas",
                newName: "Direccion");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Direccion",
                table: "Tiendas",
                newName: "Dirección");
        }
    }
}
