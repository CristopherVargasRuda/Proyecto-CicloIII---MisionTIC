using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Impresoras3D.App.Persistencia.Migrations
{
    public partial class Secreananotacionesrequeridas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Impresora_Operario_OperarioIdentificacion",
                table: "Impresora");

            migrationBuilder.DropForeignKey(
                name: "FK_Impresora_Tecnico_TecnicoIdentificacion",
                table: "Impresora");

            migrationBuilder.DropForeignKey(
                name: "FK_Servicio_Tecnico_Tecnico_TecnicoIdentificacion",
                table: "Servicio_Tecnico");

            migrationBuilder.DropIndex(
                name: "IX_Servicio_Tecnico_TecnicoIdentificacion",
                table: "Servicio_Tecnico");

            migrationBuilder.DropIndex(
                name: "IX_Impresora_OperarioIdentificacion",
                table: "Impresora");

            migrationBuilder.DropIndex(
                name: "IX_Impresora_TecnicoIdentificacion",
                table: "Impresora");

            migrationBuilder.DropColumn(
                name: "TecnicoIdentificacion",
                table: "Servicio_Tecnico");

            migrationBuilder.DropColumn(
                name: "OperarioIdentificacion",
                table: "Impresora");

            migrationBuilder.DropColumn(
                name: "TecnicoIdentificacion",
                table: "Impresora");

            migrationBuilder.RenameColumn(
                name: "Identificacion",
                table: "Tecnico",
                newName: "Documento");

            migrationBuilder.RenameColumn(
                name: "Identificacion",
                table: "Socio_empresa",
                newName: "Documento");

            migrationBuilder.RenameColumn(
                name: "Identificacion",
                table: "Operario",
                newName: "Documento");

            migrationBuilder.RenameColumn(
                name: "Identificacion",
                table: "Jefe_operaciones",
                newName: "Documento");

            migrationBuilder.RenameColumn(
                name: "Identificacion",
                table: "Auxiliar",
                newName: "Documento");

            migrationBuilder.CreateIndex(
                name: "IX_Servicio_Tecnico_TecnicoDocumento",
                table: "Servicio_Tecnico",
                column: "TecnicoDocumento");

            migrationBuilder.CreateIndex(
                name: "IX_Impresora_OperarioDocumento",
                table: "Impresora",
                column: "OperarioDocumento");

            migrationBuilder.CreateIndex(
                name: "IX_Impresora_TecnicoDocumento",
                table: "Impresora",
                column: "TecnicoDocumento");

            migrationBuilder.AddForeignKey(
                name: "FK_Impresora_Operario_OperarioDocumento",
                table: "Impresora",
                column: "OperarioDocumento",
                principalTable: "Operario",
                principalColumn: "Documento",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Impresora_Tecnico_TecnicoDocumento",
                table: "Impresora",
                column: "TecnicoDocumento",
                principalTable: "Tecnico",
                principalColumn: "Documento",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Servicio_Tecnico_Tecnico_TecnicoDocumento",
                table: "Servicio_Tecnico",
                column: "TecnicoDocumento",
                principalTable: "Tecnico",
                principalColumn: "Documento",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Impresora_Operario_OperarioDocumento",
                table: "Impresora");

            migrationBuilder.DropForeignKey(
                name: "FK_Impresora_Tecnico_TecnicoDocumento",
                table: "Impresora");

            migrationBuilder.DropForeignKey(
                name: "FK_Servicio_Tecnico_Tecnico_TecnicoDocumento",
                table: "Servicio_Tecnico");

            migrationBuilder.DropIndex(
                name: "IX_Servicio_Tecnico_TecnicoDocumento",
                table: "Servicio_Tecnico");

            migrationBuilder.DropIndex(
                name: "IX_Impresora_OperarioDocumento",
                table: "Impresora");

            migrationBuilder.DropIndex(
                name: "IX_Impresora_TecnicoDocumento",
                table: "Impresora");

            migrationBuilder.RenameColumn(
                name: "Documento",
                table: "Tecnico",
                newName: "Identificacion");

            migrationBuilder.RenameColumn(
                name: "Documento",
                table: "Socio_empresa",
                newName: "Identificacion");

            migrationBuilder.RenameColumn(
                name: "Documento",
                table: "Operario",
                newName: "Identificacion");

            migrationBuilder.RenameColumn(
                name: "Documento",
                table: "Jefe_operaciones",
                newName: "Identificacion");

            migrationBuilder.RenameColumn(
                name: "Documento",
                table: "Auxiliar",
                newName: "Identificacion");

            migrationBuilder.AddColumn<int>(
                name: "TecnicoIdentificacion",
                table: "Servicio_Tecnico",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OperarioIdentificacion",
                table: "Impresora",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TecnicoIdentificacion",
                table: "Impresora",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Servicio_Tecnico_TecnicoIdentificacion",
                table: "Servicio_Tecnico",
                column: "TecnicoIdentificacion");

            migrationBuilder.CreateIndex(
                name: "IX_Impresora_OperarioIdentificacion",
                table: "Impresora",
                column: "OperarioIdentificacion");

            migrationBuilder.CreateIndex(
                name: "IX_Impresora_TecnicoIdentificacion",
                table: "Impresora",
                column: "TecnicoIdentificacion");

            migrationBuilder.AddForeignKey(
                name: "FK_Impresora_Operario_OperarioIdentificacion",
                table: "Impresora",
                column: "OperarioIdentificacion",
                principalTable: "Operario",
                principalColumn: "Identificacion",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Impresora_Tecnico_TecnicoIdentificacion",
                table: "Impresora",
                column: "TecnicoIdentificacion",
                principalTable: "Tecnico",
                principalColumn: "Identificacion",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Servicio_Tecnico_Tecnico_TecnicoIdentificacion",
                table: "Servicio_Tecnico",
                column: "TecnicoIdentificacion",
                principalTable: "Tecnico",
                principalColumn: "Identificacion",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
