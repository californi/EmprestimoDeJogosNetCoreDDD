using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class atualizacao_colunas_jogo4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tabJogo_tabJogador_JogadorDonoId",
                table: "tabJogo");

            migrationBuilder.DropIndex(
                name: "IX_tabJogo_JogadorDonoId",
                table: "tabJogo");

            migrationBuilder.DropColumn(
                name: "JogadorDonoId",
                table: "tabJogo");

            migrationBuilder.AddColumn<Guid>(
                name: "JogadorId",
                table: "tabJogo",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_tabJogo_JogadorId",
                table: "tabJogo",
                column: "JogadorId");

            migrationBuilder.AddForeignKey(
                name: "FK_tabJogo_tabJogador_JogadorId",
                table: "tabJogo",
                column: "JogadorId",
                principalTable: "tabJogador",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tabJogo_tabJogador_JogadorId",
                table: "tabJogo");

            migrationBuilder.DropIndex(
                name: "IX_tabJogo_JogadorId",
                table: "tabJogo");

            migrationBuilder.DropColumn(
                name: "JogadorId",
                table: "tabJogo");

            migrationBuilder.AddColumn<Guid>(
                name: "JogadorDonoId",
                table: "tabJogo",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_tabJogo_JogadorDonoId",
                table: "tabJogo",
                column: "JogadorDonoId");

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
