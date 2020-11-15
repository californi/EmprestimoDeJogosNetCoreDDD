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
        }
    }
}
