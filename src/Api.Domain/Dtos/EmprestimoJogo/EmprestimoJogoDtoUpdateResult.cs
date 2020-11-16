using System;
using Api.Domain.Dtos.Jogador;
using Api.Domain.Dtos.Jogo;

namespace Api.Domain.Dtos.EmprestimoJogo
{
    public class EmprestimoJogoDtoUpdateResult
    {
        public Guid Id { get; set; }
        public Guid JogoId { get; set; }
        public Guid JogadorId { get; set; }
        public bool Devolvido { get; set; }
        public JogoDto Jogo { get; set; }
        public JogadorDto Jogador { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}
