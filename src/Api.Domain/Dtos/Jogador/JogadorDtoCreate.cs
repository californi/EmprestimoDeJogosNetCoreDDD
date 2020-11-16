using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.Jogador
{
    public class JogadorDtoCreate
    {
        [Required(ErrorMessage = "Nome do jogador é obrigatório.")]
        [StringLength(100, ErrorMessage = "Nome do jogador deve ter no máximo {1} caracteres;")]
        public string Nome { get; set; }
        public string Cidade { get; set; }
    }
}
