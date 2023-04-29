using Desafio.TecnicoLLip.Domain.Models.Base;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo
{
    public class UnidadeFederativa : TipoModel<string>
    {
        public UnidadeFederativa(string id, string descricao)
        {
            Id = id;
            Descricao = descricao;
        }
    }
}
