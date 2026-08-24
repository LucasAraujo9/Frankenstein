using AutoMapper;
using Frankenstein.Application.DTOs;
using Frankenstein.Application.Entities;

namespace Frankenstein.Application.Mappings;

public class FrankwnstreinProfile : Profile
{
    public FrankwnstreinProfile()
    {
        #region Usuario
        CreateMap<UsuarioDTO, Usuario>();
        CreateMap<Usuario, UsuarioDTO>();
        #endregion
    }
}
