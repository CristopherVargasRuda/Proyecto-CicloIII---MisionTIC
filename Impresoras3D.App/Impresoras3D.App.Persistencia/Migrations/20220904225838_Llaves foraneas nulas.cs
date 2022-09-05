using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Impresoras3D.App.Persistencia.Migrations
{
    public partial class Llavesforaneasnulas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Impresora_Estado_EstadoID",
                table: "Impresora");

            migrationBuilder.DropForeignKey(
                name: "FK_Impresora_Operario_OperarioId",
                table: "Impresora");

            migrationBuilder.DropForeignKey(
                name: "FK_Impresora_Tecnico_TecnicoId",
                table: "Impresora");

            migrationBuilder.DropForeignKey(
                name: "FK_Impresora_componente_Estado_EstadoId",
                table: "Impresora_componente");

            migrationBuilder.DropForeignKey(
                name: "FK_Software_Estado_EstadoId",
                table: "Software");

            migrationBuilder.AlterColumn<int>(
                name: "EstadoId",
                table: "Software",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "EstadoId",
                table: "Impresora_componente",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TecnicoId",
                table: "Impresora",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "OperarioId",
                table: "Impresora",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "EstadoID",
                table: "Impresora",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Impresora_Estado_EstadoID",
                table: "Impresora",
                column: "EstadoID",
                principalTable: "Estado",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Impresora_Operario_OperarioId",
                table: "Impresora",
                column: "OperarioId",
                principalTable: "Operario",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Impresora_Tecnico_TecnicoId",
                table: "Impresora",
                column: "TecnicoId",
                principalTable: "Tecnico",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Impresora_componente_Estado_EstadoId",
                table: "Impresora_componente",
                column: "EstadoId",
                principalTable: "Estado",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Software_Estado_EstadoId",
                table: "Software",
                column: "EstadoId",
                principalTable: "Estado",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Impresora_Estado_EstadoID",
                table: "Impresora");

            migrationBuilder.DropForeignKey(
                name: "FK_Impresora_Operario_OperarioId",
                table: "Impresora");

            migrationBuilder.DropForeignKey(
                name: "FK_Impresora_Tecnico_TecnicoId",
                table: "Impresora");

            migrationBuilder.DropForeignKey(
                name: "FK_Impresora_componente_Estado_EstadoId",
                table: "Impresora_componente");

            migrationBuilder.DropForeignKey(
                name: "FK_Software_Estado_EstadoId",
                table: "Software");

            migrationBuilder.AlterColumn<int>(
                name: "EstadoId",
                table: "Software",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EstadoId",
                table: "Impresora_componente",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TecnicoId",
                table: "Impresora",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OperarioId",
                table: "Impresora",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EstadoID",
                table: "Impresora",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Impresora_Estado_EstadoID",
                table: "Impresora",
                column: "EstadoID",
                principalTable: "Estado",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Impresora_Operario_OperarioId",
                table: "Impresora",
                column: "OperarioId",
                principalTable: "Operario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Impresora_Tecnico_TecnicoId",
                table: "Impresora",
                column: "TecnicoId",
                principalTable: "Tecnico",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Impresora_componente_Estado_EstadoId",
                table: "Impresora_componente",
                column: "EstadoId",
                principalTable: "Estado",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Software_Estado_EstadoId",
                table: "Software",
                column: "EstadoId",
                principalTable: "Estado",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
