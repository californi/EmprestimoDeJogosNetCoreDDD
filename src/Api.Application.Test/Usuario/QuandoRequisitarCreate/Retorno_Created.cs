using System.Threading.Tasks;
using Api.Application.Controllers;
using Api.Domain.Interfaces.Services.Usuario;
using Xunit;
using Moq;
using Api.Domain.Dtos.Usuario;
using System;
using Microsoft.AspNetCore.Mvc;

namespace Api.Application.Test.Usuario.QuandoRequisitarCreate
{
    public class Retorno_Created
    {
        private UsuariosController _controller;
        [Fact(DisplayName = "É possivel Realizar o Created.")]
        public async Task PodeInvocarControllerCreate()
        {
            var serviceMock = new Mock<IUsuarioService>();
            var nome = Faker.Name.FullName();
            var email = Faker.Internet.Email();

            serviceMock.Setup(m => m.Post(It.IsAny<UsuarioDtoCreate>())).ReturnsAsync(
                new UsuarioDtoCreateResult
                {
                    Id = Guid.NewGuid(),
                    Nome = nome,
                    Email = email,
                    CreateAt = DateTime.UtcNow
                }
            );

            _controller = new UsuariosController(serviceMock.Object);
            Mock<IUrlHelper> url = new Mock<IUrlHelper>();
            url.Setup(x => x.Link(It.IsAny<string>(), It.IsAny<object>())).Returns("http://localhost:5000");
            _controller.Url = url.Object;

            var usuarioDtoCreate = new UsuarioDtoCreate()
            {
                Nome = nome,
                Email = email
            };
            var result = await _controller.Post(usuarioDtoCreate);
            Assert.True(result is CreatedResult);

            var resultValue = ((CreatedResult)result).Value as UsuarioDtoCreateResult;
            Assert.NotNull(resultValue);
            Assert.Equal(usuarioDtoCreate.Email, resultValue.Email);
        }
    }
}
