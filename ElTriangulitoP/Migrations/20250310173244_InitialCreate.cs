using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElTriangulitoP.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "combos",
                columns: table => new
                {
                    id_combo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    tipo_plato_c = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_combos", x => x.id_combo);
                });

            migrationBuilder.CreateTable(
                name: "mesas",
                columns: table => new
                {
                    id_mesa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    estado_mesa = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    nombre_mesa = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mesas", x => x.id_mesa);
                });

            migrationBuilder.CreateTable(
                name: "platos",
                columns: table => new
                {
                    id_plato = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    tipo_plato = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_platos", x => x.id_plato);
                });

            migrationBuilder.CreateTable(
                name: "promociones",
                columns: table => new
                {
                    id_promocion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_plato = table.Column<int>(type: "int", nullable: true),
                    id_combo = table.Column<int>(type: "int", nullable: true),
                    fecha_inicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fecha_fin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    descuento = table.Column<decimal>(type: "decimal(10,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_promociones", x => x.id_promocion);
                    table.ForeignKey(
                        name: "FK_promociones_combos_id_combo",
                        column: x => x.id_combo,
                        principalTable: "combos",
                        principalColumn: "id_combo");
                    table.ForeignKey(
                        name: "FK_promociones_platos_id_plato",
                        column: x => x.id_plato,
                        principalTable: "platos",
                        principalColumn: "id_plato");
                });

            migrationBuilder.CreateTable(
                name: "detalle_orden",
                columns: table => new
                {
                    id_detalle = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_plato = table.Column<int>(type: "int", nullable: true),
                    id_combo = table.Column<int>(type: "int", nullable: true),
                    id_promocion = table.Column<int>(type: "int", nullable: true),
                    cantidad = table.Column<int>(type: "int", nullable: false),
                    subtotal = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_detalle_orden", x => x.id_detalle);
                    table.ForeignKey(
                        name: "FK_detalle_orden_combos_id_combo",
                        column: x => x.id_combo,
                        principalTable: "combos",
                        principalColumn: "id_combo");
                    table.ForeignKey(
                        name: "FK_detalle_orden_platos_id_plato",
                        column: x => x.id_plato,
                        principalTable: "platos",
                        principalColumn: "id_plato");
                    table.ForeignKey(
                        name: "FK_detalle_orden_promociones_id_promocion",
                        column: x => x.id_promocion,
                        principalTable: "promociones",
                        principalColumn: "id_promocion");
                });

            migrationBuilder.CreateTable(
                name: "ordenes",
                columns: table => new
                {
                    id_orden = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_mesa = table.Column<int>(type: "int", nullable: false),
                    id_detalle = table.Column<int>(type: "int", nullable: false),
                    nombre_cliente = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    estado = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    comentario = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ordenes", x => x.id_orden);
                    table.ForeignKey(
                        name: "FK_ordenes_detalle_orden_id_detalle",
                        column: x => x.id_detalle,
                        principalTable: "detalle_orden",
                        principalColumn: "id_detalle",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ordenes_mesas_id_mesa",
                        column: x => x.id_mesa,
                        principalTable: "mesas",
                        principalColumn: "id_mesa",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_detalle_orden_id_combo",
                table: "detalle_orden",
                column: "id_combo");

            migrationBuilder.CreateIndex(
                name: "IX_detalle_orden_id_plato",
                table: "detalle_orden",
                column: "id_plato");

            migrationBuilder.CreateIndex(
                name: "IX_detalle_orden_id_promocion",
                table: "detalle_orden",
                column: "id_promocion");

            migrationBuilder.CreateIndex(
                name: "IX_ordenes_id_detalle",
                table: "ordenes",
                column: "id_detalle");

            migrationBuilder.CreateIndex(
                name: "IX_ordenes_id_mesa",
                table: "ordenes",
                column: "id_mesa");

            migrationBuilder.CreateIndex(
                name: "IX_promociones_id_combo",
                table: "promociones",
                column: "id_combo");

            migrationBuilder.CreateIndex(
                name: "IX_promociones_id_plato",
                table: "promociones",
                column: "id_plato");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ordenes");

            migrationBuilder.DropTable(
                name: "detalle_orden");

            migrationBuilder.DropTable(
                name: "mesas");

            migrationBuilder.DropTable(
                name: "promociones");

            migrationBuilder.DropTable(
                name: "combos");

            migrationBuilder.DropTable(
                name: "platos");
        }
    }
}
