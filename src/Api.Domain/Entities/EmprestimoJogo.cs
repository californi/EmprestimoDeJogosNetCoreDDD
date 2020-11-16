using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entities
{
    public class EmprestimoJogo : BaseEntity
    {
        [Required]
        public Guid JogoId { get; set; }
        [Required]
        public Guid JogadorId { get; set; }
        public bool Devolvido { get; set; }
        public JogoEntity Jogo { get; set; }
        public JogadorEntity Jogador { get; set; }
    }
}
