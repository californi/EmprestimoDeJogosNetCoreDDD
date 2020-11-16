using Api.Domain.Dtos.EmprestimoJogo;
using Api.Domain.Dtos.Jogador;
using Api.Domain.Dtos.Jogo;
using Api.Domain.Dtos.Usuario;
using Api.Domain.Entities;
using AutoMapper;

namespace Api.CrossCutting.Mappings
{
    public class EntityToDtoProfile : Profile
    {
        public EntityToDtoProfile()
        {
            CreateMap<UsuarioDto, UsuarioEntity>()
                .ReverseMap();

            CreateMap<UsuarioDtoCreateResult, UsuarioEntity>()
                .ReverseMap();

            CreateMap<UsuarioDtoUpdateResult, UsuarioEntity>()
                .ReverseMap();

            CreateMap<JogadorDto, JogadorEntity>()
                .ReverseMap();

            CreateMap<JogadorDtoCreateResult, JogadorEntity>()
                .ReverseMap();

            CreateMap<JogadorDtoUpdateResult, JogadorEntity>()
                .ReverseMap();

            CreateMap<JogoDto, JogoEntity>()
                .ReverseMap();

            CreateMap<JogoDtoCreateResult, JogoEntity>()
                .ReverseMap();

            CreateMap<JogoDtoUpdateResult, JogoEntity>()
                .ReverseMap();

            CreateMap<EmprestimoJogoDto, EmprestimoJogoEntity>()
                .ReverseMap();

            CreateMap<EmprestimoJogoDtoCreateResult, EmprestimoJogoEntity>()
                .ReverseMap();

            CreateMap<EmprestimoJogoDtoUpdateResult, EmprestimoJogoEntity>()
                .ReverseMap();
        }
    }
}
