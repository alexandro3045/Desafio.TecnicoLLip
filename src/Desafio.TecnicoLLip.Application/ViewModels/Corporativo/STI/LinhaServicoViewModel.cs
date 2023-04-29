using Desafio.TecnicoLLip.Application.ViewModels.Base;
using System.Runtime.Serialization;

namespace Desafio.TecnicoLLip.Application.ViewModels.Corporativo.STI
{
    public class LinhaServicoViewModel : TipoViewModel<int>
    {
        //<summary>
        //Codigo da função.
        //</summary>
        [DataMember]
        public string CodigoFuncao { get; set; }
        //<summary>
        //Categoria.
        //</summary>
        [DataMember]
        public FuncaoViewModel FuncaoViewModel { get; set; }
    }
}