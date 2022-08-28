using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Impresoras3D.App.Persistencia.Migrations
{
    public partial class Seeliminarelaciónentrecompraysocio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compra_seguro_Socio_empresa_SocioEmpresaIdentificacion",
                table: "Compra_seguro");

            migrationBuilder.DropForeignKey(
                name: "FK_Servicio_Tecnico_Software_SoftwareId",
                table: "Servicio_Tecnico");

            migrationBuilder.DropIndex(
                name: "IX_Compra_seguro_SocioEmpresaIdentificacion",
                table: "Compra_seguro");

            migrationBuilder.DropColumn(
                name: "SocioEmpresaDocumento",
                table: "Compra_seguro");

            migrationBuilder.DropColumn(
                name: "SocioEmpresaIdentificacion",
                table: "Compra_seguro");

            migrationBuilder.AlterColumn<string>(
                name: "SegundoNombre",
                table: "Tecnico",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "SegundoApellido",
                table: "Tecnico",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "SegundoNombre",
                table: "Socio_empresa",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "SegundoApellido",
                table: "Socio_empresa",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "SoftwareId",
                table: "Servicio_Tecnico",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SegundoNombre",
                table: "Operario",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "SegundoApellido",
                table: "Operario",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "SegundoNombre",
                table: "Jefe_operaciones",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "SegundoApellido",
                table: "Jefe_operaciones",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "TecnicoDocumento",
                table: "Impresora",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OperarioDocumento",
                table: "Impresora",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SegundoNombre",
                table: "Auxiliar",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "SegundoApellido",
                table: "Auxiliar",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_Servicio_Tecnico_Software_SoftwareId",
                table: "Servicio_Tecnico",
                column: "SoftwareId",
                principalTable: "Software",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Servicio_Tecnico_Software_SoftwareId",
                table: "Servicio_Tecnico");

            migrationBuilder.AlterColumn<string>(
                name: "SegundoNombre",
                table: "Tecnico",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SegundoApellido",
                table: "Tecnico",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SegundoNombre",
                table: "Socio_empresa",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SegundoApellido",
                table: "Socio_empresa",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SoftwareId",
                table: "Servicio_Tecnico",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "SegundoNombre",
                table: "Operario",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SegundoApellido",
                table: "Operario",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SegundoNombre",
                table: "Jefe_operaciones",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SegundoApellido",
                table: "Jefe_operaciones",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TecnicoDocumento",
                table: "Impresora",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "OperarioDocumento",
                table: "Impresora",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "SocioEmpresaDocumento",
                table: "Compra_seguro",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SocioEmpresaIdentificacion",
                table: "Compra_seguro",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "SegundoNombre",
                table: "Auxiliar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SegundoApellido",
                table: "Auxiliar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Compra_seguro_SocioEmpresaIdentificacion",
                table: "Compra_seguro",
                column: "SocioEmpresaIdentificacion");

            migrationBuilder.AddForeignKey(
                name: "FK_Compra_seguro_Socio_empresa_SocioEmpresaIdentificacion",
                table: "Compra_seguro",
                column: "SocioEmpresaIdentificacion",
                principalTable: "Socio_empresa",
                principalColumn: "Identificacion",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Servicio_Tecnico_Software_SoftwareId",
                table: "Servicio_Tecnico",
                column: "SoftwareId",
                principalTable: "Software",
                principalColumn: "Id");
        }
    }
}
