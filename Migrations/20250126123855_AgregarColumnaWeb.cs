using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BioShopDB.Migrations
{
    /// <inheritdoc />
    public partial class AgregarColumnaWeb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Teléfono",
                table: "Tiendas",
                newName: "Telefono");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Telefono",
                table: "Tiendas",
                newName: "Teléfono");
        }
    }
}
