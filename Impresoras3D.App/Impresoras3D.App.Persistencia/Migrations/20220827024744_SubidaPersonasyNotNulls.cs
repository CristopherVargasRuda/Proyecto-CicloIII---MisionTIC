using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Impresoras3D.App.Persistencia.Migrations
{
    public partial class SubidaPersonasyNotNulls : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SeguroyTipoCubrimiento_Seguro_SeguroId",
                table: "SeguroyTipoCubrimiento");

            migrationBuilder.DropForeignKey(
                name: "FK_SeguroyTipoCubrimiento_Tipo_cubrimiento_TipoCubrimientoId",
                table: "SeguroyTipoCubrimiento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SeguroyTipoCubrimiento",
                table: "SeguroyTipoCubrimiento");

            migrationBuilder.RenameTable(
                name: "SeguroyTipoCubrimiento",
                newName: "Seguro_tipoCubrimiento");

            migrationBuilder.RenameIndex(
                name: "IX_SeguroyTipoCubrimiento_TipoCubrimientoId",
                table: "Seguro_tipoCubrimiento",
                newName: "IX_Seguro_tipoCubrimiento_TipoCubrimientoId");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Tipo_cubrimiento",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Tipo_cubrimiento",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "telefono",
                table: "Socio_empresa",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "SegundoNombre",
                table: "Socio_empresa",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "SegundoApellido",
                table: "Socio_empresa",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PrimerNombre",
                table: "Socio_empresa",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PrimerApellido",
                table: "Socio_empresa",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "telefono",
                table: "Jefe_operaciones",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "SegundoNombre",
                table: "Jefe_operaciones",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "SegundoApellido",
                table: "Jefe_operaciones",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PrimerNombre",
                table: "Jefe_operaciones",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PrimerApellido",
                table: "Jefe_operaciones",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ImpresoraPlacaInventario",
                table: "Compra_seguro",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "telefono",
                table: "Auxiliar",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "SegundoNombre",
                table: "Auxiliar",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "SegundoApellido",
                table: "Auxiliar",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PrimerNombre",
                table: "Auxiliar",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PrimerApellido",
                table: "Auxiliar",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Seguro_tipoCubrimiento",
                table: "Seguro_tipoCubrimiento",
                columns: new[] { "SeguroId", "TipoCubrimientoId" });

            migrationBuilder.CreateTable(
                name: "Operario",
                columns: table => new
                {
                    Identificacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrimerNombre = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    SegundoNombre = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    PrimerApellido = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    SegundoApellido = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operario", x => x.Identificacion);
                });

            migrationBuilder.CreateTable(
                name: "Tecnico",
                columns: table => new
                {
                    Identificacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Direccion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NivelEstudios = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PrimerNombre = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    SegundoNombre = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    PrimerApellido = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    SegundoApellido = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tecnico", x => x.Identificacion);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Seguro_tipoCubrimiento_Seguro_SeguroId",
                table: "Seguro_tipoCubrimiento",
                column: "SeguroId",
                principalTable: "Seguro",
                principalColumn: "Identificacion",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Seguro_tipoCubrimiento_Tipo_cubrimiento_TipoCubrimientoId",
                table: "Seguro_tipoCubrimiento",
                column: "TipoCubrimientoId",
                principalTable: "Tipo_cubrimiento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seguro_tipoCubrimiento_Seguro_SeguroId",
                table: "Seguro_tipoCubrimiento");

            migrationBuilder.DropForeignKey(
                name: "FK_Seguro_tipoCubrimiento_Tipo_cubrimiento_TipoCubrimientoId",
                table: "Seguro_tipoCubrimiento");

            migrationBuilder.DropTable(
                name: "Operario");

            migrationBuilder.DropTable(
                name: "Tecnico");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Seguro_tipoCubrimiento",
                table: "Seguro_tipoCubrimiento");

            migrationBuilder.RenameTable(
                name: "Seguro_tipoCubrimiento",
                newName: "SeguroyTipoCubrimiento");

            migrationBuilder.RenameIndex(
                name: "IX_Seguro_tipoCubrimiento_TipoCubrimientoId",
                table: "SeguroyTipoCubrimiento",
                newName: "IX_SeguroyTipoCubrimiento_TipoCubrimientoId");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Tipo_cubrimiento",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Tipo_cubrimiento",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "telefono",
                table: "Socio_empresa",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "SegundoNombre",
                table: "Socio_empresa",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "SegundoApellido",
                table: "Socio_empresa",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "PrimerNombre",
                table: "Socio_empresa",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "PrimerApellido",
                table: "Socio_empresa",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "telefono",
                table: "Jefe_operaciones",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "SegundoNombre",
                table: "Jefe_operaciones",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "SegundoApellido",
                table: "Jefe_operaciones",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "PrimerNombre",
                table: "Jefe_operaciones",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "PrimerApellido",
                table: "Jefe_operaciones",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "ImpresoraPlacaInventario",
                table: "Compra_seguro",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "telefono",
                table: "Auxiliar",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "SegundoNombre",
                table: "Auxiliar",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "SegundoApellido",
                table: "Auxiliar",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "PrimerNombre",
                table: "Auxiliar",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "PrimerApellido",
                table: "Auxiliar",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SeguroyTipoCubrimiento",
                table: "SeguroyTipoCubrimiento",
                columns: new[] { "SeguroId", "TipoCubrimientoId" });

            migrationBuilder.AddForeignKey(
                name: "FK_SeguroyTipoCubrimiento_Seguro_SeguroId",
                table: "SeguroyTipoCubrimiento",
                column: "SeguroId",
                principalTable: "Seguro",
                principalColumn: "Identificacion",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SeguroyTipoCubrimiento_Tipo_cubrimiento_TipoCubrimientoId",
                table: "SeguroyTipoCubrimiento",
                column: "TipoCubrimientoId",
                principalTable: "Tipo_cubrimiento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
