using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaComprasBackend.Migrations
{
    public partial class v100 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    id_producto = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    nombre_producto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    caracteristica = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    medida = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.id_producto);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Producto");
        }
    }
}
