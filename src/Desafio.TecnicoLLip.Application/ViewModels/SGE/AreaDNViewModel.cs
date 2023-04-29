using Desafio.TecnicoLLip.Application.ViewModels.Base;
using System;
using System.Runtime.Serialization;

namespace Desafio.TecnicoLLip.Application.ViewModels.SGE
{
    public class AreaDNViewModel : TipoViewModel<int>
    {
        [DataMember]
        public DateTime? Inicio { get; set; }
        [DataMember]
        public DateTime? Fim { get; set; }
    }
}