using Desafio.TecnicoLLip.Application.ViewModels.Base;
using System.Runtime.Serialization;

namespace Desafio.TecnicoLLip.Application.ViewModels.Corporativo.Gestor
{
    ///<summary>
    ///Objeto Genero"/>
    ///</summary>
    [DataContract]
    public class GeneroViewModel : TipoViewModel<string>
    {
        public RamoAtividadeViewModel RamoAtividade { get; set; }
    }
}