using Desafio.TecnicoLLip.Application.ViewModels.Base;

namespace Desafio.TecnicoLLip.Application.ViewModels.Protheus
{
    public class FilialViewModel : TipoViewModel<string>
    {
        public string Empresa { get; set; }
    }
}