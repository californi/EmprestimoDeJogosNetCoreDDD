using System;
using Api.Domain.Dtos.Jogador;

namespace Api.Domain.Dtos.Jogo
{
    public class JogoDtoCreateResult
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public Guid JogadorId { get; set; }
        public JogadorDto Jogador { get; set; }
        public string Descricao { get; set; }
        public string Tipo { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
