using System;
using System.ComponentModel.DataAnnotations;
using Api.Domain.Dtos.Jogador;

namespace Api.Domain.Dtos.Jogo
{
    public class JogoDtoCreate
    {
        [Required(ErrorMessage = "Nome do jogo é obrigatório.")]
        [StringLength(50, ErrorMessage = "Nome do jogo deve ter no máximo {1} caracteres;")]
        public string Nome { get; set; }
        public Guid JogadorId { get; set; }
        public string Descricao { get; set; }
        public string Tipo { get; set; }
    }
}
