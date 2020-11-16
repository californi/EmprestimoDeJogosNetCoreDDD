using Api.Domain.Dtos.EmprestimoJogo;
using Api.Domain.Dtos.Jogador;
using Api.Domain.Dtos.Jogo;
using Api.Domain.Dtos.Usuario;
using Api.Domain.Models;
using AutoMapper;

namespace Api.CrossCutting.Mappings
{
    public class DtoToModelProfile : Profile
    {
        public DtoToModelProfile()
        {
            CreateMap<UsuarioModel, UsuarioDto>()
                .ReverseMap();
            CreateMap<UsuarioModel, UsuarioDtoCreate>()
                .ReverseMap();
            CreateMap<UsuarioModel, UsuarioDtoUpdate>()
                .ReverseMap();

            CreateMap<JogadorModel, JogadorDto>()
                .ReverseMap();
            CreateMap<JogadorModel, JogadorDtoCreate>()
                .ReverseMap();
            CreateMap<JogadorModel, JogadorDtoUpdate>()
                .ReverseMap();

            CreateMap<JogoModel, JogoDto>()
                .ReverseMap();
            CreateMap<JogoModel, JogoDtoCreate>()
                .ReverseMap();
            CreateMap<JogoModel, JogoDtoUpdate>()
                .ReverseMap();

            CreateMap<EmprestimoJogoModel, EmprestimoJogoDto>()
                .ReverseMap();
            CreateMap<EmprestimoJogoModel, EmprestimoJogoDtoCreate>()
                .ReverseMap();
            CreateMap<EmprestimoJogoModel, EmprestimoJogoDtoUpdate>()
                .ReverseMap();

        }
    }
}
