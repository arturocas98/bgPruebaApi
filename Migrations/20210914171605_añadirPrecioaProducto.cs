using Microsoft.EntityFrameworkCore.Migrations;

namespace bdpPruebaApi.Migrations
{
    public partial class añadirPrecioaProducto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "precio",
                table: "Producto",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "precio",
                table: "Producto");
        }
    }
}
