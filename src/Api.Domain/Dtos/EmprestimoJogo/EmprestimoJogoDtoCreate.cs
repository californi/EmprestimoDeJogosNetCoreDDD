using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.EmprestimoJogo
{
    public class EmprestimoJogoDtoCreate
    {
        [Required(ErrorMessage = "Id do jogo é obrigatório.")]
        public Guid JogoId { get; set; }

        [Required(ErrorMessage = "Id do jogador é obrigatório.")]
        public Guid JogadorId { get; set; }

        public bool Devolvido { get; set; }
    }
}
