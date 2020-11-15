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

        }
    }
}
