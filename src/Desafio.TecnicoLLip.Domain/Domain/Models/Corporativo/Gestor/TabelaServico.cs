using Desafio.TecnicoLLip.Domain.Models.Base;
using System;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor
{
    public class TabelaServico : TipoModel<Int16?>
    {
        public string CodigoTipoEntidadeVinculo { get; set; }
        public TipoEntidadeVinculo TipoEntidadeVinculo { get; set; }
        public char? IsAtendimento { get; set; }
        public char? TipoPreco { get; set; }
    }
}
