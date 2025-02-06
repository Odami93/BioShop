using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BioShopDB.Migrations
{
    /// <inheritdoc />
    public partial class RenameTableToProducto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Tiendas_TiendaId",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_Productos_TiendaId",
                table: "Productos");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "TiendaId",
                keyValue: null,
                column: "TiendaId",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "TiendaId",
                table: "Productos",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "TiendaId1",
                table: "Productos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Productos_TiendaId1",
                table: "Productos",
                column: "TiendaId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Tiendas_TiendaId1",
                table: "Productos",
                column: "TiendaId1",
                principalTable: "Tiendas",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Tiendas_TiendaId1",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_Productos_TiendaId1",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "TiendaId1",
                table: "Productos");

            migrationBuilder.AlterColumn<int>(
                name: "TiendaId",
                table: "Productos",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_TiendaId",
                table: "Productos",
                column: "TiendaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Tiendas_TiendaId",
                table: "Productos",
                column: "TiendaId",
                principalTable: "Tiendas",
                principalColumn: "Id");
        }
    }
}
