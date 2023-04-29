using System;
using System.Reflection;

namespace Desafio.TecnicoLLip.Infrastructure.Data.Utils
{
    public static class ObjectClass
    {
        public static T Property<T>(this object obj, string property)
            where T : class
        {
            Type type = obj.GetType();

            PropertyInfo propertyInfo = type.GetProperty(property);

            return (T)Convert.ChangeType(propertyInfo.GetValue(obj, null), typeof(T));
        }
    }

    public static class ObjectHelper
    {
        public static T Property<T>(this object obj, string property) 
            where T : struct
        {
            Type type = obj.GetType() ;

            PropertyInfo propertyInfo = type.GetProperty(property);

            return (T)Convert.ChangeType(propertyInfo.GetValue(obj, null), typeof(T));
        }
    }
}
