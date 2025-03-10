using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ElTriangulitoP.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreateV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ordenes_detalle_orden_id_detalle",
                table: "ordenes");

            migrationBuilder.DropForeignKey(
                name: "FK_ordenes_mesas_id_mesa",
                table: "ordenes");

            migrationBuilder.DropForeignKey(
                name: "FK_promociones_combos_id_combo",
                table: "promociones");

            migrationBuilder.DropForeignKey(
                name: "FK_promociones_platos_id_plato",
                table: "promociones");

            migrationBuilder.DropTable(
                name: "detalle_orden");

            migrationBuilder.DropIndex(
                name: "IX_promociones_id_combo",
                table: "promociones");

            migrationBuilder.DropIndex(
                name: "IX_promociones_id_plato",
                table: "promociones");

            migrationBuilder.DropIndex(
                name: "IX_ordenes_id_detalle",
                table: "ordenes");

            migrationBuilder.DropIndex(
                name: "IX_ordenes_id_mesa",
                table: "ordenes");

            migrationBuilder.DropColumn(
                name: "descuento",
                table: "promociones");

            migrationBuilder.DropColumn(
                name: "tipo_plato",
                table: "platos");

            migrationBuilder.DropColumn(
                name: "id_detalle",
                table: "ordenes");

            migrationBuilder.DropColumn(
                name: "estado_mesa",
                table: "mesas");

            migrationBuilder.DropColumn(
                name: "nombre_mesa",
                table: "mesas");

            migrationBuilder.DropColumn(
                name: "tipo_plato_c",
                table: "combos");

            migrationBuilder.AlterColumn<decimal>(
                name: "precio",
                table: "promociones",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "fecha_inicio",
                table: "promociones",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "fecha_fin",
                table: "promociones",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "platos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "nombre_cliente",
                table: "ordenes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "estado",
                table: "ordenes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "comentario",
                table: "ordenes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "id_combo",
                table: "ordenes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "id_plato",
                table: "ordenes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "id_promocion",
                table: "ordenes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "total",
                table: "ordenes",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "estado",
                table: "mesas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nombre",
                table: "mesas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "combos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "id_combo",
                table: "ordenes");

            migrationBuilder.DropColumn(
                name: "id_plato",
                table: "ordenes");

            migrationBuilder.DropColumn(
                name: "id_promocion",
                table: "ordenes");

            migrationBuilder.DropColumn(
                name: "total",
                table: "ordenes");

            migrationBuilder.DropColumn(
                name: "estado",
                table: "mesas");

            migrationBuilder.DropColumn(
                name: "nombre",
                table: "mesas");

            migrationBuilder.AlterColumn<decimal>(
                name: "precio",
                table: "promociones",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "fecha_inicio",
                table: "promociones",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "fecha_fin",
                table: "promociones",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "descuento",
                table: "promociones",
                type: "decimal(10,2)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "platos",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "tipo_plato",
                table: "platos",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "nombre_cliente",
                table: "ordenes",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "estado",
                table: "ordenes",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "comentario",
                table: "ordenes",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "id_detalle",
                table: "ordenes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "estado_mesa",
                table: "mesas",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "nombre_mesa",
                table: "mesas",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "combos",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tipo_plato_c",
                table: "combos",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "detalle_orden",
                columns: table => new
                {
                    id_detalle = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_combo = table.Column<int>(type: "int", nullable: true),
                    id_plato = table.Column<int>(type: "int", nullable: true),
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

            migrationBuilder.CreateIndex(
                name: "IX_promociones_id_combo",
                table: "promociones",
                column: "id_combo");

            migrationBuilder.CreateIndex(
                name: "IX_promociones_id_plato",
                table: "promociones",
                column: "id_plato");

            migrationBuilder.CreateIndex(
                name: "IX_ordenes_id_detalle",
                table: "ordenes",
                column: "id_detalle");

            migrationBuilder.CreateIndex(
                name: "IX_ordenes_id_mesa",
                table: "ordenes",
                column: "id_mesa");

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

            migrationBuilder.AddForeignKey(
                name: "FK_ordenes_detalle_orden_id_detalle",
                table: "ordenes",
                column: "id_detalle",
                principalTable: "detalle_orden",
                principalColumn: "id_detalle",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ordenes_mesas_id_mesa",
                table: "ordenes",
                column: "id_mesa",
                principalTable: "mesas",
                principalColumn: "id_mesa",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_promociones_combos_id_combo",
                table: "promociones",
                column: "id_combo",
                principalTable: "combos",
                principalColumn: "id_combo");

            migrationBuilder.AddForeignKey(
                name: "FK_promociones_platos_id_plato",
                table: "promociones",
                column: "id_plato",
                principalTable: "platos",
                principalColumn: "id_plato");
        }
    }
}
