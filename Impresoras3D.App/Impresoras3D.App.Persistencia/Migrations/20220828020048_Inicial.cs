﻿using System;
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
                name: "Operario",
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
                    table.PrimaryKey("PK_Operario", x => x.Identificacion);
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
                name: "Tecnico",
                columns: table => new
                {
                    Identificacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NivelEstudios = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrimerNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SegundoNombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrimerApellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SegundoApellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tecnico", x => x.Identificacion);
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
                    ImpresoraPlacaInventario = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                        principalColumn: "Identificacion",
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
                    PlacaInventario = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Marca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modelo = table.Column<int>(type: "int", nullable: false),
                    VelocidaImpresion = table.Column<int>(type: "int", nullable: false),
                    VolumenImpresionX = table.Column<int>(type: "int", nullable: false),
                    VolumenImpresionY = table.Column<int>(type: "int", nullable: false),
                    VolumenImpresionZ = table.Column<int>(type: "int", nullable: false),
                    PaisOrigen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstadoID = table.Column<int>(type: "int", nullable: false),
                    OperarioDocumento = table.Column<int>(type: "int", nullable: true),
                    OperarioIdentificacion = table.Column<int>(type: "int", nullable: false),
                    TecnicoDocumento = table.Column<int>(type: "int", nullable: true),
                    TecnicoIdentificacion = table.Column<int>(type: "int", nullable: false),
                    SoftwareId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Impresora", x => x.PlacaInventario);
                    table.ForeignKey(
                        name: "FK_Impresora_Estado_EstadoID",
                        column: x => x.EstadoID,
                        principalTable: "Estado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Impresora_Operario_OperarioIdentificacion",
                        column: x => x.OperarioIdentificacion,
                        principalTable: "Operario",
                        principalColumn: "Identificacion",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Impresora_Software_SoftwareId",
                        column: x => x.SoftwareId,
                        principalTable: "Software",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Impresora_Tecnico_TecnicoIdentificacion",
                        column: x => x.TecnicoIdentificacion,
                        principalTable: "Tecnico",
                        principalColumn: "Identificacion",
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
                    ImpresoraPlacaInventario = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SeguroId = table.Column<int>(type: "int", nullable: false),
                    SocioEmpresaDocumento = table.Column<int>(type: "int", nullable: false),
                    SocioEmpresaIdentificacion = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compra_seguro", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Compra_seguro_Impresora_ImpresoraPlacaInventario",
                        column: x => x.ImpresoraPlacaInventario,
                        principalTable: "Impresora",
                        principalColumn: "PlacaInventario",
                        onDelete: ReferentialAction.Cascade);
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
                name: "Servicio_Tecnico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImpresoraPlacaInventario = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SoftwareId = table.Column<int>(type: "int", nullable: true),
                    TecnicoDocumento = table.Column<int>(type: "int", nullable: false),
                    TecnicoIdentificacion = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicio_Tecnico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Servicio_Tecnico_Impresora_ImpresoraPlacaInventario",
                        column: x => x.ImpresoraPlacaInventario,
                        principalTable: "Impresora",
                        principalColumn: "PlacaInventario",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Servicio_Tecnico_Software_SoftwareId",
                        column: x => x.SoftwareId,
                        principalTable: "Software",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Servicio_Tecnico_Tecnico_TecnicoIdentificacion",
                        column: x => x.TecnicoIdentificacion,
                        principalTable: "Tecnico",
                        principalColumn: "Identificacion",
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
                name: "IX_Compra_seguro_ImpresoraPlacaInventario",
                table: "Compra_seguro",
                column: "ImpresoraPlacaInventario");

            migrationBuilder.CreateIndex(
                name: "IX_Compra_seguro_SeguroId",
                table: "Compra_seguro",
                column: "SeguroId");

            migrationBuilder.CreateIndex(
                name: "IX_Compra_seguro_SocioEmpresaIdentificacion",
                table: "Compra_seguro",
                column: "SocioEmpresaIdentificacion");

            migrationBuilder.CreateIndex(
                name: "IX_Impresora_EstadoID",
                table: "Impresora",
                column: "EstadoID");

            migrationBuilder.CreateIndex(
                name: "IX_Impresora_OperarioIdentificacion",
                table: "Impresora",
                column: "OperarioIdentificacion");

            migrationBuilder.CreateIndex(
                name: "IX_Impresora_SoftwareId",
                table: "Impresora",
                column: "SoftwareId");

            migrationBuilder.CreateIndex(
                name: "IX_Impresora_TecnicoIdentificacion",
                table: "Impresora",
                column: "TecnicoIdentificacion");

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
                name: "IX_Servicio_Tecnico_ImpresoraPlacaInventario",
                table: "Servicio_Tecnico",
                column: "ImpresoraPlacaInventario");

            migrationBuilder.CreateIndex(
                name: "IX_Servicio_Tecnico_SoftwareId",
                table: "Servicio_Tecnico",
                column: "SoftwareId");

            migrationBuilder.CreateIndex(
                name: "IX_Servicio_Tecnico_TecnicoIdentificacion",
                table: "Servicio_Tecnico",
                column: "TecnicoIdentificacion");

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
