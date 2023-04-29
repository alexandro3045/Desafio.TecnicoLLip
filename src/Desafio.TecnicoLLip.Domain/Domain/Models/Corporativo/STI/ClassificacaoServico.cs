using Desafio.TecnicoLLip.Domain.Models.Base;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.STI
{
    public class ClassificacaoServico : TipoModel<int>
    {
        public int LinhaServicoId { get; set; }
        public LinhaServico LinhaServico { get; set; }

        public string AreaDN { get; set; }
    }
}