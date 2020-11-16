using System;

namespace Api.Domain.Dtos.Jogo
{
    public class JogoDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public Guid JogadorId { get; set; }
        public string Descricao { get; set; }
        public string Tipo { get; set; }
    }
}
