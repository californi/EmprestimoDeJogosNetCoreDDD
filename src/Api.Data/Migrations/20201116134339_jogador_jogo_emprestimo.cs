using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class jogador_jogo_emprestimo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tabJogador",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    Nome = table.Column<string>(maxLength: 20, nullable: false),
                    Cidade = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tabJogador", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tabJogo",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    Nome = table.Column<string>(maxLength: 20, nullable: false),
                    JogadorId = table.Column<Guid>(nullable: false),
                    JogadorDonoId = table.Column<Guid>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    Tipo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tabJogo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tabJogo_tabJogador_JogadorDonoId",
                        column: x => x.JogadorDonoId,
                        principalTable: "tabJogador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tabEmprestimoJogo",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    JogoId = table.Column<Guid>(nullable: false),
                    JogadorId = table.Column<Guid>(nullable: false),
                    Devolvido = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tabEmprestimoJogo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tabEmprestimoJogo_tabJogador_JogadorId",
                        column: x => x.JogadorId,
                        principalTable: "tabJogador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tabEmprestimoJogo_tabJogo_JogoId",
                        column: x => x.JogoId,
                        principalTable: "tabJogo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tabEmprestimoJogo_JogadorId",
                table: "tabEmprestimoJogo",
                column: "JogadorId");

            migrationBuilder.CreateIndex(
                name: "IX_tabEmprestimoJogo_JogoId",
                table: "tabEmprestimoJogo",
                column: "JogoId");

            migrationBuilder.CreateIndex(
                name: "IX_tabJogo_JogadorDonoId",
                table: "tabJogo",
                column: "JogadorDonoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tabEmprestimoJogo");

            migrationBuilder.DropTable(
                name: "tabJogo");

            migrationBuilder.DropTable(
                name: "tabJogador");
        }
    }
}
