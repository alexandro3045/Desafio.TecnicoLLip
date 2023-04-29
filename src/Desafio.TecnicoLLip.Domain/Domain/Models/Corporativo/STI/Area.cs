using Desafio.TecnicoLLip.Domain.Models.Base;
using System;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.STI
{
    public class Area : TipoModel<string>
    {
        public DateTime? Fim { get; set; }
        public string CodigoDnaArea { get; set; }
    }
}