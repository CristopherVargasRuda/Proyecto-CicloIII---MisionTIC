using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Impresoras3D.App.Persistencia.Migrations
{
    public partial class Llavesforaneasnulass2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "SoftwareId",
                table: "Impresora",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "SoftwareId",
                table: "Impresora",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
