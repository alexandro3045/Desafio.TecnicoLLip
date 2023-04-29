using AutoMapper;
using System.ComponentModel;

namespace Desafio.TecnicoLLip.Application.AutoMapperConfigs
{
    public class AutoMapperConfig
    {
        protected AutoMapperConfig() { }

        public static MapperConfiguration RegisterMappings() =>
            new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());                
            });
    }

    public class NoMapAttribute : System.Attribute
    {
    }

    public static class IgnoreNoMapExtensions
    {
        public static IMappingExpression<TSource, TDestination> IgnoreMap<TSource, TDestination>(
            this IMappingExpression<TSource, TDestination> expression)
        {
            var sourceType = typeof(TSource);
            foreach (var property in sourceType.GetProperties())
            {
                PropertyDescriptor descriptor = TypeDescriptor.GetProperties(sourceType)[property.Name];

                NoMapAttribute attribute = (NoMapAttribute)descriptor.Attributes[typeof(NoMapAttribute)];

                if (attribute != null)
                    expression.ForMember(property.Name, opt => opt.Ignore());
            }
            return expression;
        }
    }
}
