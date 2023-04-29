using Nancy.Json;

namespace Desafio.TecnicoLLip.Infrastructure.Data.Utils
{
    public static class JsonHelper
    {
        public static string ToJSON(this object obj)
        {
            return new JavaScriptSerializer().Serialize(obj);
        }
    }
}
