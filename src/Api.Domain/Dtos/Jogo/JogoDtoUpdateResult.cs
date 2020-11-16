using System;
using Api.Domain.Dtos.Jogador;

namespace Api.Domain.Dtos.Jogo
{
    public class JogoDtoUpdateResult
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public Guid JogadorId { get; set; }
        public string Descricao { get; set; }
        public string Tipo { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}
