using System;

namespace Api.Domain.Dtos.Usuario
{
    public class UsuarioDtoCreateResult
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
