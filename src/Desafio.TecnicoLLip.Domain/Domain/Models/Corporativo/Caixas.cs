using Desafio.TecnicoLLip.Domain.Models.Base;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo
{
    public class Caixas : TipoModel<string>
    {
        public Caixas(string id, string descricao)
        {
            Id = id;
            Descricao = descricao;
        }
    }
}
