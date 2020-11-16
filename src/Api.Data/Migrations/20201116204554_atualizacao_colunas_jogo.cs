using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class atualizacao_colunas_jogo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tabJogo_tabJogador_JogadorDonoId",
                table: "tabJogo");

            migrationBuilder.AlterColumn<Guid>(
                name: "JogadorDonoId",
                table: "tabJogo",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "char(36)");

            migrationBuilder.AddColumn<Guid>(
                name: "JogadorId",
                table: "tabJogo",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddForeignKey(
                name: "FK_tabJogo_tabJogador_JogadorDonoId",
                table: "tabJogo",
                column: "JogadorDonoId",
                principalTable: "tabJogador",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tabJogo_tabJogador_JogadorDonoId",
                table: "tabJogo");

            migrationBuilder.DropColumn(
                name: "JogadorId",
                table: "tabJogo");

            migrationBuilder.AlterColumn<Guid>(
                name: "JogadorDonoId",
                table: "tabJogo",
                type: "char(36)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_tabJogo_tabJogador_JogadorDonoId",
                table: "tabJogo",
                column: "JogadorDonoId",
                principalTable: "tabJogador",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
