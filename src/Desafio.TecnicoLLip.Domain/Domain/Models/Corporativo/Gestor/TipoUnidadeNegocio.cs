using Desafio.TecnicoLLip.Domain.Models.Base;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos;
using System;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor
{
    public class TipoUnidadeNegocio : TipoModel<Int16>
    {
        public string Sigla { get; set; }
        public UnidadeVinculada UnidadeVinculada { get; set; }
    }
}
