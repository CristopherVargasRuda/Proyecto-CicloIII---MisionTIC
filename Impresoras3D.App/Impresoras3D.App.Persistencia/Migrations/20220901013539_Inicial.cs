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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Documento = table.Column<int>(type: "int", nullable: false),
                    PrimerNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SegundoNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimerApellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SegundoApellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auxiliar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Componente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Componente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estado", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Jefe_operaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Documento = table.Column<int>(type: "int", nullable: false),
                    PrimerNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SegundoNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimerApellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SegundoApellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jefe_operaciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Operario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Documento = table.Column<int>(type: "int", nullable: false),
                    PrimerNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SegundoNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimerApellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SegundoApellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Seguro",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aseguradora = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seguro", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Socio_empresa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Documento = table.Column<int>(type: "int", nullable: false),
                    PrimerNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SegundoNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimerApellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SegundoApellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Socio_empresa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tecnico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NivelEstudios = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Documento = table.Column<int>(type: "int", nullable: false),
                    PrimerNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SegundoNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimerApellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SegundoApellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tecnico", x => x.Id);
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
                name: "Impresora_componente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImpresoraId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComponenteId = table.Column<int>(type: "int", nullable: false),
                    EstadoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Impresora_componente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Impresora_componente_Componente_ComponenteId",
                        column: x => x.ComponenteId,
                        principalTable: "Componente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Impresora_componente_Estado_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Software",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Version = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Licencia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstadoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Software", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Software_Estado_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Seguro_tipoCubrimiento",
                columns: table => new
                {
                    SeguroId = table.Column<int>(type: "int", nullable: false),
                    TipoCubrimientoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seguro_tipoCubrimiento", x => new { x.SeguroId, x.TipoCubrimientoId });
                    table.ForeignKey(
                        name: "FK_Seguro_tipoCubrimiento_Seguro_SeguroId",
                        column: x => x.SeguroId,
                        principalTable: "Seguro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Seguro_tipoCubrimiento_Tipo_cubrimiento_TipoCubrimientoId",
                        column: x => x.TipoCubrimientoId,
                        principalTable: "Tipo_cubrimiento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Impresora",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlacaInventario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modelo = table.Column<int>(type: "int", nullable: false),
                    VelocidaImpresion = table.Column<int>(type: "int", nullable: false),
                    VolumenImpresionX = table.Column<int>(type: "int", nullable: false),
                    VolumenImpresionY = table.Column<int>(type: "int", nullable: false),
                    VolumenImpresionZ = table.Column<int>(type: "int", nullable: false),
                    PaisOrigen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstadoID = table.Column<int>(type: "int", nullable: false),
                    OperarioId = table.Column<int>(type: "int", nullable: false),
                    TecnicoId = table.Column<int>(type: "int", nullable: false),
                    SoftwareId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Impresora", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Impresora_Estado_EstadoID",
                        column: x => x.EstadoID,
                        principalTable: "Estado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Impresora_Operario_OperarioId",
                        column: x => x.OperarioId,
                        principalTable: "Operario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Impresora_Software_SoftwareId",
                        column: x => x.SoftwareId,
                        principalTable: "Software",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Impresora_Tecnico_TecnicoId",
                        column: x => x.TecnicoId,
                        principalTable: "Tecnico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Compra_seguro",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaCompra = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaVencimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImpresoraId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImpresoraId1 = table.Column<int>(type: "int", nullable: false),
                    SeguroId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compra_seguro", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Compra_seguro_Impresora_ImpresoraId1",
                        column: x => x.ImpresoraId1,
                        principalTable: "Impresora",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Compra_seguro_Seguro_SeguroId",
                        column: x => x.SeguroId,
                        principalTable: "Seguro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Servicio_Tecnico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImpresoraId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImpresoraId1 = table.Column<int>(type: "int", nullable: false),
                    SoftwareId = table.Column<int>(type: "int", nullable: false),
                    TecnicoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicio_Tecnico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Servicio_Tecnico_Impresora_ImpresoraId1",
                        column: x => x.ImpresoraId1,
                        principalTable: "Impresora",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Servicio_Tecnico_Software_SoftwareId",
                        column: x => x.SoftwareId,
                        principalTable: "Software",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Servicio_Tecnico_Tecnico_TecnicoId",
                        column: x => x.TecnicoId,
                        principalTable: "Tecnico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cambio_componente",
                columns: table => new
                {
                    ServicioTecnicoId = table.Column<int>(type: "int", nullable: false),
                    ImpresoraComponenteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cambio_componente", x => new { x.ServicioTecnicoId, x.ImpresoraComponenteId });
                    table.ForeignKey(
                        name: "FK_Cambio_componente_Impresora_componente_ImpresoraComponenteId",
                        column: x => x.ImpresoraComponenteId,
                        principalTable: "Impresora_componente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cambio_componente_Servicio_Tecnico_ServicioTecnicoId",
                        column: x => x.ServicioTecnicoId,
                        principalTable: "Servicio_Tecnico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Mantenimiento_componente",
                columns: table => new
                {
                    ServicioTecnicoId = table.Column<int>(type: "int", nullable: false),
                    ImpresoraComponenteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mantenimiento_componente", x => new { x.ServicioTecnicoId, x.ImpresoraComponenteId });
                    table.ForeignKey(
                        name: "FK_Mantenimiento_componente_Impresora_componente_ImpresoraComponenteId",
                        column: x => x.ImpresoraComponenteId,
                        principalTable: "Impresora_componente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mantenimiento_componente_Servicio_Tecnico_ServicioTecnicoId",
                        column: x => x.ServicioTecnicoId,
                        principalTable: "Servicio_Tecnico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cambio_componente_ImpresoraComponenteId",
                table: "Cambio_componente",
                column: "ImpresoraComponenteId");

            migrationBuilder.CreateIndex(
                name: "IX_Compra_seguro_ImpresoraId1",
                table: "Compra_seguro",
                column: "ImpresoraId1");

            migrationBuilder.CreateIndex(
                name: "IX_Compra_seguro_SeguroId",
                table: "Compra_seguro",
                column: "SeguroId");

            migrationBuilder.CreateIndex(
                name: "IX_Impresora_EstadoID",
                table: "Impresora",
                column: "EstadoID");

            migrationBuilder.CreateIndex(
                name: "IX_Impresora_OperarioId",
                table: "Impresora",
                column: "OperarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Impresora_SoftwareId",
                table: "Impresora",
                column: "SoftwareId");

            migrationBuilder.CreateIndex(
                name: "IX_Impresora_TecnicoId",
                table: "Impresora",
                column: "TecnicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Impresora_componente_ComponenteId",
                table: "Impresora_componente",
                column: "ComponenteId");

            migrationBuilder.CreateIndex(
                name: "IX_Impresora_componente_EstadoId",
                table: "Impresora_componente",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Mantenimiento_componente_ImpresoraComponenteId",
                table: "Mantenimiento_componente",
                column: "ImpresoraComponenteId");

            migrationBuilder.CreateIndex(
                name: "IX_Seguro_tipoCubrimiento_TipoCubrimientoId",
                table: "Seguro_tipoCubrimiento",
                column: "TipoCubrimientoId");

            migrationBuilder.CreateIndex(
                name: "IX_Servicio_Tecnico_ImpresoraId1",
                table: "Servicio_Tecnico",
                column: "ImpresoraId1");

            migrationBuilder.CreateIndex(
                name: "IX_Servicio_Tecnico_SoftwareId",
                table: "Servicio_Tecnico",
                column: "SoftwareId");

            migrationBuilder.CreateIndex(
                name: "IX_Servicio_Tecnico_TecnicoId",
                table: "Servicio_Tecnico",
                column: "TecnicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Software_EstadoId",
                table: "Software",
                column: "EstadoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Auxiliar");

            migrationBuilder.DropTable(
                name: "Cambio_componente");

            migrationBuilder.DropTable(
                name: "Compra_seguro");

            migrationBuilder.DropTable(
                name: "Jefe_operaciones");

            migrationBuilder.DropTable(
                name: "Mantenimiento_componente");

            migrationBuilder.DropTable(
                name: "Seguro_tipoCubrimiento");

            migrationBuilder.DropTable(
                name: "Socio_empresa");

            migrationBuilder.DropTable(
                name: "Impresora_componente");

            migrationBuilder.DropTable(
                name: "Servicio_Tecnico");

            migrationBuilder.DropTable(
                name: "Seguro");

            migrationBuilder.DropTable(
                name: "Tipo_cubrimiento");

            migrationBuilder.DropTable(
                name: "Componente");

            migrationBuilder.DropTable(
                name: "Impresora");

            migrationBuilder.DropTable(
                name: "Operario");

            migrationBuilder.DropTable(
                name: "Software");

            migrationBuilder.DropTable(
                name: "Tecnico");

            migrationBuilder.DropTable(
                name: "Estado");
        }
    }
}
