using System;

namespace Api.Domain.Dtos.Jogador
{
    public class JogadorDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Cidade { get; set; }
    }
}
