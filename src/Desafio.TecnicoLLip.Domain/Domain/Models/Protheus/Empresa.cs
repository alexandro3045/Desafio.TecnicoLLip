using Desafio.TecnicoLLip.Domain.Models.Base;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor;
using System.Collections.Generic;

namespace Desafio.TecnicoLLip.Domain.Models.Protheus
{
    public class Empresa : TipoModel<string>
    {
        public string Nome { get; set; }

        public IEnumerable<EmpresaEntidadeVinculo> EmpresasEntidadesVinculos { get; set; }
    }
}