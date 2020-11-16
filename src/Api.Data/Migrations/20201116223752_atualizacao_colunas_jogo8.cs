using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class atualizacao_colunas_jogo8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Devolvido",
                table: "tabEmprestimoJogo",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Devolvido",
                table: "tabEmprestimoJogo",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);
        }
    }
}
