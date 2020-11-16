using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entities
{
    public class JogadorEntity : BaseEntity
    {
        [MaxLength(100)]
        public string Nome { get; set; }
        public string Cidade { get; set; }

        public IEnumerable<JogoEntity> Jogos { get; set; }

        public IEnumerable<EmprestimoJogoEntity> Emprestimos { get; set; }
    }
}
