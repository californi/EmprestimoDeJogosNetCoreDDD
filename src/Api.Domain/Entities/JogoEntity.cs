using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entities
{
    public class JogoEntity : BaseEntity
    {
        [MaxLength(50)]
        public string Nome { get; set; }

        public Guid JogadorId { get; set; }

        public JogadorEntity Jogador { get; set; }

        public string Descricao { get; set; }
        public string Tipo { get; set; }

        public IEnumerable<EmprestimoJogoEntity> Emprestimos { get; set; }
    }
}
