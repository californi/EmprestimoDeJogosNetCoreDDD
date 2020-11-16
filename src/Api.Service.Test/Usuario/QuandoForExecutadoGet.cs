using System.Threading.Tasks;
using Api.Domain.Interfaces.Services.Usuario;
using Moq;
using Xunit;

namespace Api.Service.Test.Usuario
{
    public class QuandoForExecutadoGet : UsuariosTestes
    {
        private IUsuarioService _service;
        private Mock<IUsuarioService> _serviceMock;

        [Fact(DisplayName = "É possível executar o Método GET.")]
        public async Task PodeExecutarMetodoGet()
        {
            _serviceMock = new Mock<IUsuarioService>();
            _serviceMock.Setup(m => m.Get(IdUsuario)).ReturnsAsync(usuarioDto);
            _service = _serviceMock.Object;

            var result = await _service.Get(IdUsuario);
            Assert.NotNull(result);
            Assert.True(result.Id == IdUsuario);
        }
    }
}
