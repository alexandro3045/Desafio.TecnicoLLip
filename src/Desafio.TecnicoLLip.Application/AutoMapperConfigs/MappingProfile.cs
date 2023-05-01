#region Includes
using AutoMapper;
using Desafio.TecnicoLLip.Application.ViewModels;
using Desafio.TecnicoLLip.Domain.Models;
#endregion

namespace Desafio.TecnicoLLip.Application.AutoMapperConfigs
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Domain.Models.Base.Base, ViewModels.Base.Base>()
                .ReverseMap();

            CreateMap<Domain.Models.Base.BaseModel<object>, ViewModels.Base.BaseViewModel<object>>()
                .ReverseMap();

            CreateMap<Users, UsuarioViewModel>()
                //.ForMember(dest => dest.Nome, opt => opt.MapFrom(src => src.Name))
                .ReverseMap();
        }
    }
}

