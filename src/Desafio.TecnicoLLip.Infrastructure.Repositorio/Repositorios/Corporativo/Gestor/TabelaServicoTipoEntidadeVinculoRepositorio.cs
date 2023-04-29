using Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository.Corporativo.Gestor;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor;
using Desafio.TecnicoLLip.Infrastructure.Data.Contextos.Corporativo;
using Desafio.TecnicoLLip.Infrastructure.Data.Repositorios.Base;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.TecnicoLLip.Infrastructure.Data.Repositorios.Corporativo.Gestor
{
    public class TabelaServicoTipoEntidadeVinculoRepositorio : BaseRepositorio<TabelaServicoTipoEntidadeVinculo>, ITabelaServicoTipoEntidadeVinculoRepository
    {
        public TabelaServicoTipoEntidadeVinculoRepositorio(CorporativoContext context) : base(context) { }

        public async Task<IEnumerable<TabelaServicoTipoEntidadeVinculo>> GetTabelasServicos(string CodigoTipoEntidade)
        {
            ClearParameters();
            AddParameters("ch_tp_entidade_vinculo", CodigoTipoEntidade);
            var TabelasServicosTiposEntidadesVinculos = new List<TabelaServicoTipoEntidadeVinculo>();
            var list = base.ExecuteStoredQuery("[dbo].[SPTabelaServicoTpEntCons] ").Result.ToList();
            foreach (var tabelaServicoTipoEntidade in list)
            {
                tabelaServicoTipoEntidade.GrupoClassificacaoPai = ((CorporativoContext)Contexto).GruposClassificacoes.FirstOrDefault(g => g.Id == tabelaServicoTipoEntidade.GrupoClassificacaoPaiId);
                tabelaServicoTipoEntidade.GrupoClassificacao = ((CorporativoContext)Contexto).GruposClassificacoes.FirstOrDefault(g => g.Id == tabelaServicoTipoEntidade.GrupoClassificacaoId);
                tabelaServicoTipoEntidade.TipoServico = ((CorporativoContext)Contexto).TiposServicos.FirstOrDefault(g => g.Id == tabelaServicoTipoEntidade.CodigoTipoServico);
                tabelaServicoTipoEntidade.Produto = ((CorporativoContext)Contexto).Produtos.FirstOrDefault(g => g.Id == tabelaServicoTipoEntidade.ProdutoId);
                TabelasServicosTiposEntidadesVinculos.Add(tabelaServicoTipoEntidade);
            }

            return await Task.FromResult(TabelasServicosTiposEntidadesVinculos);
        }
    }
}