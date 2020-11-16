using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entities
{
    public class EmprestimoJogoEntity : BaseEntity
    {

        public Guid JogoId { get; set; }

        public Guid JogadorId { get; set; }
        public bool? Devolvido { get; set; }
        public JogoEntity Jogo { get; set; }
        public JogadorEntity Jogador { get; set; }
    }
}
