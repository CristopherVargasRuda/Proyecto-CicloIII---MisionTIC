using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Impresoras3D.App.Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Auxiliar",
                columns: table => new
                {
                    Identificacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrimerNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SegundoNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrimerApellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SegundoApellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auxiliar", x => x.Identificacion);
                });

            migrationBuilder.CreateTable(
                name: "Jefe_operaciones",
                columns: table => new
                {
                    Identificacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrimerNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SegundoNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrimerApellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SegundoApellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jefe_operaciones", x => x.Identificacion);
                });

            migrationBuilder.CreateTable(
                name: "Seguro",
                columns: table => new
                {
                    Identificacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seguro", x => x.Identificacion);
                });

            migrationBuilder.CreateTable(
                name: "Socio_empresa",
                columns: table => new
                {
                    Identificacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrimerNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SegundoNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrimerApellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SegundoApellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Socio_empresa", x => x.Identificacion);
                });

            migrationBuilder.CreateTable(
                name: "Tipo_cubrimiento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipo_cubrimiento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Compra_seguro",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCompra = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaVencimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImpresoraPlacaInventario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeguroId = table.Column<int>(type: "int", nullable: false),
                    SocioEmpresaDocumento = table.Column<int>(type: "int", nullable: false),
                    SocioEmpresaIdentificacion = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compra_seguro", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Compra_seguro_Seguro_SeguroId",
                        column: x => x.SeguroId,
                        principalTable: "Seguro",
                        principalColumn: "Identificacion",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Compra_seguro_Socio_empresa_SocioEmpresaIdentificacion",
                        column: x => x.SocioEmpresaIdentificacion,
                        principalTable: "Socio_empresa",
                        principalColumn: "Identificacion",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SeguroyTipoCubrimiento",
                columns: table => new
                {
                    SeguroId = table.Column<int>(type: "int", nullable: false),
                    TipoCubrimientoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeguroyTipoCubrimiento", x => new { x.SeguroId, x.TipoCubrimientoId });
                    table.ForeignKey(
                        name: "FK_SeguroyTipoCubrimiento_Seguro_SeguroId",
                        column: x => x.SeguroId,
                        principalTable: "Seguro",
                        principalColumn: "Identificacion",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SeguroyTipoCubrimiento_Tipo_cubrimiento_TipoCubrimientoId",
                        column: x => x.TipoCubrimientoId,
                        principalTable: "Tipo_cubrimiento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Compra_seguro_SeguroId",
                table: "Compra_seguro",
                column: "SeguroId");

            migrationBuilder.CreateIndex(
                name: "IX_Compra_seguro_SocioEmpresaIdentificacion",
                table: "Compra_seguro",
                column: "SocioEmpresaIdentificacion");

            migrationBuilder.CreateIndex(
                name: "IX_SeguroyTipoCubrimiento_TipoCubrimientoId",
                table: "SeguroyTipoCubrimiento",
                column: "TipoCubrimientoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Auxiliar");

            migrationBuilder.DropTable(
                name: "Compra_seguro");

            migrationBuilder.DropTable(
                name: "Jefe_operaciones");

            migrationBuilder.DropTable(
                name: "SeguroyTipoCubrimiento");

            migrationBuilder.DropTable(
                name: "Socio_empresa");

            migrationBuilder.DropTable(
                name: "Seguro");

            migrationBuilder.DropTable(
                name: "Tipo_cubrimiento");
        }
    }
}
