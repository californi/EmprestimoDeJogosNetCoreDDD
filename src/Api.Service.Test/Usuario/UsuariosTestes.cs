using System;
using System.Collections.Generic;
using Api.Domain.Dtos.Usuario;

namespace Api.Service.Test.Usuario
{
    public class UsuariosTestes
    {
        public static string NomeUsuario { get; set; }
        public static string EmailUsuario { get; set; }
        public static string NomeUsuarioAlterado { get; set; }
        public static string EmailUsuarioAlterado { get; set; }

        public static Guid IdUsuario { get; set; }

        public List<UsuarioDto> listaUsuarioDto = new List<UsuarioDto>();

        public UsuarioDto usuarioDto;
        public UsuarioDtoCreate usuarioDtoCreate;

        public UsuarioDtoCreateResult usuarioDtoCreateResult;

        public UsuarioDtoUpdate usuarioDtoUpdate;

        public UsuarioDtoUpdateResult usuarioDtoUpdateResult;

        public UsuariosTestes()
        {
            IdUsuario = Guid.NewGuid();
            NomeUsuario = Faker.Name.FullName();
            EmailUsuario = Faker.Internet.Email();
            NomeUsuarioAlterado = Faker.Name.FullName();
            EmailUsuarioAlterado = Faker.Internet.Email();

            for (int i = 0; i < 10; i++)
            {
                var dto = new UsuarioDto(){
                    Id = Guid.NewGuid(),
                    Nome = Faker.Name.FullName(),
                    Email = Faker.Internet.Email()
                };
                listaUsuarioDto.Add(dto);
            }

            usuarioDto = new UsuarioDto{
                Id = IdUsuario,
                Nome = NomeUsuario,
                Email = EmailUsuario
            };
            usuarioDtoCreate = new UsuarioDtoCreate{
                Nome = NomeUsuario,
                Email = EmailUsuario
            };

            usuarioDtoCreateResult = new UsuarioDtoCreateResult{
                Id = IdUsuario,
                Nome = NomeUsuario,
                Email = EmailUsuario,
                CreateAt = DateTime.UtcNow
            };

            usuarioDtoUpdate = new UsuarioDtoUpdate{
                Id = IdUsuario,
                Nome = NomeUsuario,
                Email = EmailUsuario
            };
            
            usuarioDtoUpdateResult = new UsuarioDtoUpdateResult{
                Id = IdUsuario,
                Nome = NomeUsuario,
                Email = EmailUsuario,
                UpdateAt = DateTime.UtcNow
            };
        
        }
    }
}
