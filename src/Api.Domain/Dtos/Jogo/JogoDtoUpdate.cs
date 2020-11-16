using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.Jogo
{
    public class JogoDtoUpdate
    {
        [Required(ErrorMessage = "Id do jogo é obrigatório.")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Nome do jogo é obrigatório.")]
        [StringLength(20, ErrorMessage = "Nome do jogo deve ter no máximo {1} caracteres;")]
        public string Nome { get; set; }
        public Guid JogadorId { get; set; }
        public string Descricao { get; set; }
        public string Tipo { get; set; }
    }
}
