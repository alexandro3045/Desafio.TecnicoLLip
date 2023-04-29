using Desafio.TecnicoLLip.Domain.Models.Base;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo
{
    public class ServicoFederal : TipoModel<string>
    {
        public string CodigoCNAE { get; set; }

        public ServicoFederal(string id, string descricao, string codigoCNAE)
        {
            Id = id;
            Descricao = descricao;
            CodigoCNAE = codigoCNAE;
        }
    }
}
