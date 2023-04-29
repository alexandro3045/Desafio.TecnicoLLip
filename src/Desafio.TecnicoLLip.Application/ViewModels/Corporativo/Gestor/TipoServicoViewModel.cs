using Desafio.TecnicoLLip.Application.ViewModels.Base;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos;
using System.Runtime.Serialization;

namespace Desafio.TecnicoLLip.Application.ViewModels.Corporativo.Gestor
{
    [DataContract]
    public class TipoServicoViewModel : TipoViewModel<char?>
    {
        [DataMember]
        public string Sigla { get; set; }
        [DataMember]
        public ObrigaArea ObrigaArea { get; set; }
        [DataMember]
        public ObrigaCusto ObrigaCusto { get; set; }
    }
}
