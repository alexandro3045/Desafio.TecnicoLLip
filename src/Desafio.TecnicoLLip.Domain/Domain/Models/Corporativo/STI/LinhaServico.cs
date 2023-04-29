using Desafio.TecnicoLLip.Domain.Models.Base;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.STI
{
    public class LinhaServico : TipoModel<int>
    {
        public string CodigoFuncao { get; set; }
        public Funcao Funcao { get; set; }
    }
}