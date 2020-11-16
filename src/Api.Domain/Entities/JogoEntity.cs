using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entities
{
    public class JogoEntity : BaseEntity
    {
        [Required]
        [MaxLength(20)]
        public string Nome { get; set; }
        [Required]
        public Guid JogadorId { get; set; }
        public JogadorEntity JogadorDono { get; set; }
        public string Descricao { get; set; }
        public string Tipo { get; set; }
    }
}
