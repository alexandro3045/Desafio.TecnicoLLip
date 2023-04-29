using Desafio.TecnicoLLip.Domain.Models.Base;
using System;

namespace Desafio.TecnicoLLip.Domain.Models.Protheus
{
    public class BaseProtheus<T> : TipoModel<T>
    {
        public string Empresa { get; set; }
        public DateTime? Inicio { get; set; }
        public DateTime? Fim { get; set; }
    }
}
