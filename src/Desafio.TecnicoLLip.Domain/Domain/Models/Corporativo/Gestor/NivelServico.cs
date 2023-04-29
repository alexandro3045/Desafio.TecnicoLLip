using Desafio.TecnicoLLip.Domain.Models.Base;
using System;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor
{
    public class NivelServico : TipoModel<Byte?>
    {
        public Int16? TabelaServicoId { get; set; }
        public TabelaServico TabelaServico { get; set; }
    }
}
