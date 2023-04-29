using Desafio.TecnicoLLip.Domain.Models.Base;

namespace Desafio.TecnicoLLip.Domain.Models.Protheus
{
    public class Filial : TipoModel<string>
    {
        public string Empresa { get; set; }
    }
}