using Desafio.TecnicoLLip.Domain.Models.Utility;
using System.Runtime.Serialization;

namespace Desafio.TecnicoLLip.Application.ViewModels.Corporativo.Gestor.Tipos
{
    [DataContract]
    public class TipoModuloView : Enums<char?>
    {
        [DataMember]
        public static readonly TipoModuloView Presencial = new TipoModuloView('P', "Presencial");
        [DataMember]
        public static readonly TipoModuloView Distancia = new TipoModuloView('D', "Distancia");
        [DataMember]
        public static readonly TipoModuloView Web = new TipoModuloView('W', "Web");
        [DataMember]
        public static readonly TipoModuloView Movel = new TipoModuloView('M', "Movel");
        public TipoModuloView(char? key, string displayName) : base(key, displayName) { }
    }
}
