using Desafio.TecnicoLLip.Domain.Models.Base;
using System;

namespace Desafio.TecnicoLLip.Domain.Models.SGE
{
    public class AreaDN : TipoModel<Int32>
    {
        public DateTime? Inicio { get; set; }
        public DateTime? Fim { get; set; }
    }
}