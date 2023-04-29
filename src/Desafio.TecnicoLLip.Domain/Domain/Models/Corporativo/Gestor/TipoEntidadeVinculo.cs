using Desafio.TecnicoLLip.Domain.Models.Base;
using System.Collections.Generic;
using System.Linq;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor
{
    public class TipoEntidadeVinculo : TipoModel<string>
    {
        private IEnumerable<GrupoClassificacao> gruposClassificacoes;
        public IEnumerable<GrupoClassificacao> GruposClassificacoes
        {
            get => gruposClassificacoes ?? Enumerable.Empty<GrupoClassificacao>();
            set => gruposClassificacoes = value;
        }
    }
}
