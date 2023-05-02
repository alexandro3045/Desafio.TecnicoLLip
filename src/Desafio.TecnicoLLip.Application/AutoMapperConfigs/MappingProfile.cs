#region Includes
using AutoMapper;
using Desafio.TecnicoLLip.Application.ViewModels;
using Desafio.TecnicoLLip.Domain.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
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
                .ReverseMap();

            CreateMap<Projects, ProjetoViewModel>()
                .ForMember(dest => dest.DataCriacao, opt => opt.MapFrom(src => src.CreationDate))
                .ForMember(dest => dest.Descricao, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.Titulo, opt => opt.MapFrom(src => src.Title))
                .ReverseMap();
        }
    }
}

