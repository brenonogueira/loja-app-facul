using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LojaApp.Migrations
{
    public partial class Cliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nome = table.Column<string>(type: "TEXT", maxLength: 255, nullable: true),
                    cpf = table.Column<int>(type: "INTEGER", maxLength: 15, nullable: false),
                    telefone = table.Column<string>(type: "TEXT", nullable: false),
                    email = table.Column<string>(type: "TEXT", nullable: false),
                    sexo = table.Column<string>(type: "TEXT", nullable: false),
                    estadoCivil = table.Column<string>(type: "TEXT", nullable: false),
                    escolaridade = table.Column<string>(type: "TEXT", nullable: true),
                    dataNascimento = table.Column<string>(type: "TEXT", nullable: true),
                    Endereço = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
