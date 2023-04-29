using Desafio.TecnicoLLip.Application.ViewModels.Base;
using System.Runtime.Serialization;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor
{
    [DataContract]
    public class TussViewModel : TipoViewModel<int>
    {
        [DataMember]
        public string Codigo { get; set; }
    }
}
