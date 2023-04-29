using Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository.Corporativo.Gestor;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor;
using Desafio.TecnicoLLip.Domain.Models.Utility;
using Desafio.TecnicoLLip.Infrastructure.Data.Contextos.Corporativo;
using Desafio.TecnicoLLip.Infrastructure.Data.Repositorios.Base;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.TecnicoLLip.Infrastructure.Data.Repositorios.Corporativo.Gestor
{
    public class ClassificacaoRepositorio : BaseRepositorio<Classificacao>, IClassificacaoRepository
    {
        public ClassificacaoRepositorio(CorporativoContext context) : base(context) { }

        public async Task<IEnumerable<Classificacao>> GetTabelasServicos(string CodigoTipoServicoOficial, string CodigoTipoEntidadeVinculo)
        {
            ClearParameters();
            AddParameters("ch_ql_servoficial_grupoclassif", CodigoTipoServicoOficial);
            AddParameters("ch_tp_entidade_vinculo", CodigoTipoEntidadeVinculo);
            var Classificacoes = new List<Classificacao>();
            await base.ExecuteStoredQuery("[dbo].[SPConsultarSubTipoPorAreaNegocio] ")
                .Result.ForEachAsync(4, body: classificacao =>
                {
                    classificacao.GrupoClassificacao = (Contexto as CorporativoContext).GruposClassificacoes.FirstOrDefault(g => g.Id == classificacao.GrupoClassificacaoId);
                    classificacao.Produto = (Contexto as CorporativoContext).Produtos.FirstOrDefault(p => p.Id == classificacao.ProdutoId);
                    Classificacoes.Add(classificacao);

                    return Task.FromResult(classificacao);
                });

            return Classificacoes;
        }
    }
}