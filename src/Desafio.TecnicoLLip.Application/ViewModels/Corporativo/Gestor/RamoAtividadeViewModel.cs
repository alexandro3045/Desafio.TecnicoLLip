using Desafio.TecnicoLLip.Application.ViewModels.Base;
using System;
using System.Runtime.Serialization;

namespace Desafio.TecnicoLLip.Application.ViewModels.Corporativo.Gestor
{
    ///<summary>
    ///Objeto RamoAtividade"/>
    ///</summary>
    [DataContract]
    public class RamoAtividadeViewModel : TipoViewModel<Byte>
    {
        public string Codigo { get; set; }
    }
}