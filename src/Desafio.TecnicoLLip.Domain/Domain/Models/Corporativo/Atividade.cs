using Desafio.TecnicoLLip.Domain.Models.Base;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo
{
    public class Atividade : TipoModel<string>
    {
        public Atividade(string id, string descricao)
        {
            Id = id;
            Descricao = descricao;
        }
    }
}
