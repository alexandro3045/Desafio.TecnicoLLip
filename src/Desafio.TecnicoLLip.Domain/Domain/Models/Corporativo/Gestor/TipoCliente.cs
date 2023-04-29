
using Desafio.TecnicoLLip.Domain.Models.Base;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor
{
    public class TipoCliente : TipoModel<string>
    {
        public TipoPessoa Qualificador { get; set; }
        public EmpresaSistema EmpresaSistema { get; set; }
    }
}
