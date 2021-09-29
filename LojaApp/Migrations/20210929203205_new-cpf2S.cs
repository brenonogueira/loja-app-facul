using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LojaApp.Migrations
{
    public partial class newcpf2S : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "cpf",
                table: "Clientes",
                newName: "Cpf");

            migrationBuilder.AlterColumn<string>(
                name: "Cpf",
                table: "Clientes",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Cpf",
                table: "Clientes",
                newName: "cpf");

            migrationBuilder.AlterColumn<int>(
                name: "cpf",
                table: "Clientes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);
        }
    }
}
