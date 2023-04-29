using Desafio.TecnicoLLip.Domain.Models.Base;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor
{
    public class Municipio : TipoModel<int>
    {
        public int? Codigo { get; set; }
        public string SiglaUF { get; set; }
        public UF UF { get; set; }
        public string CEP { get; set; }
    }
}