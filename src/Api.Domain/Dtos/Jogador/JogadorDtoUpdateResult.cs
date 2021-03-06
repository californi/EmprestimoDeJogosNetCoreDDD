using System;

namespace Api.Domain.Dtos.Jogador
{
    public class JogadorDtoUpdateResult
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}
