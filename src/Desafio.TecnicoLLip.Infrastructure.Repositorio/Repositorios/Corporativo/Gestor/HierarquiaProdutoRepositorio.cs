using Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository.Corporativo.Gestor;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos;
using Desafio.TecnicoLLip.Infrastructure.Data.Contextos.Corporativo;
using Desafio.TecnicoLLip.Infrastructure.Data.Extensions;
using Desafio.TecnicoLLip.Infrastructure.Data.Repositorios.Base;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Desafio.TecnicoLLip.Infrastructure.Data.Repositorios.Corporativo.Gestor
{
    public class HierarquiaProdutoRepositorio : BaseRepositorio<GrupoClassificacao>, IHierarquiaProdutoRepository
    {
        public IEnumerable<GrupoClassificacao> GruposClassificacoes { get; set; }

        public HierarquiaProdutoRepositorio(CorporativoContext context) : base(context)
        {
            GruposClassificacoes = new List<GrupoClassificacao>();
        }

        public override async Task<IEnumerable<GrupoClassificacao>> ComFiltros(string colunaOrdenacao, bool? asc, Expression<Func<GrupoClassificacao, bool>> filtro, int qtd, int pule, IEnumerable<string> includes)
        {
            return await base.ComFiltros(colunaOrdenacao, asc, filtro, qtd, pule, includes)
                .ContinueWith((g) =>
                {
                    if (g.Result.Any())
                        Traverse(g.Result);

                    return GruposClassificacoes;
                });
        }

        public override async Task<GrupoClassificacao> FirstOrDefault(Expression<Func<GrupoClassificacao, bool>> expression, IEnumerable<string> includes)
        {
            return await base.FirstOrDefault(expression, includes)
                 .ContinueWith((grupo) =>
                 {
                     Traverse(grupo.Result);
                     return grupo.Result;
                 });
        }

        private void Traverse(GrupoClassificacao grupoClassificacao)
        {
            grupoClassificacao.GruposClassificacoes = ((CorporativoContext)Contexto).GruposClassificacoes.Where(e => e.GrupoClassificacaoPaiId == grupoClassificacao.Id);
            foreach (var item in grupoClassificacao.GruposClassificacoes)
            {
                Traverse(item);
            }
        }

        private void Traverse(IEnumerable<GrupoClassificacao> gruposClassificacoes)
        {
            var areasNegocios = gruposClassificacoes.Where(c => c.NivelServico == NivelGrupo.Primeiro && (c.Fim ?? Convert.ToDateTime("2079-06-06")) > DateTime.Now);

            if (!areasNegocios.Any())
            {
                ((List<GrupoClassificacao>)GruposClassificacoes).AddRange(gruposClassificacoes);
                return;
            }

            foreach (var areaNegocio in areasNegocios)
            {
                areaNegocio.GruposClassificacoes = gruposClassificacoes.Where(c => c.TipoServicoId == areaNegocio.TipoServicoId && c.NivelServico == NivelGrupo.Segundo && (c.Fim ?? Convert.ToDateTime("2079-06-06")) > DateTime.Now);

                foreach (var classificacao in areaNegocio.GruposClassificacoes)
                {
                    if (gruposClassificacoes.Any(b => b.GrupoClassificacaoPaiId == classificacao.Id))
                        Traverse(gruposClassificacoes, classificacao);
                }

                ((List<GrupoClassificacao>)GruposClassificacoes).Add(areaNegocio);
            }
        }

        private IEnumerable<GrupoClassificacao> Traverse(IEnumerable<GrupoClassificacao> gruposClassificacoes, GrupoClassificacao grupoCliassificacao)
        {
            grupoCliassificacao.GruposClassificacoes = gruposClassificacoes.Where(b => b.GrupoClassificacaoPaiId == grupoCliassificacao.Id && b.TipoServicoId == grupoCliassificacao.TipoServicoId);

            foreach (var item in grupoCliassificacao.GruposClassificacoes)
            {
                item.GruposClassificacoes = Traverse(gruposClassificacoes, item);
            }

            return grupoCliassificacao.GruposClassificacoes;
        }

        public override Task<GrupoClassificacao> Remover(GrupoClassificacao item)
        {
            ClearParameters();
            AddParameters(item, nameof(Remover));
            AddParameters("in_sq_grupoclassif", item.Id.GetDBNullOrValue());
            AddStroredProcedure("[dbo].[SPGrupoclassifExcluir] ");
            var ret = ExecuteStoredProcedure();
            if (ret.ErrorCod > 0)
            {
                item.ValidationResult = new ValidationResult(new List<ValidationFailure> { new ValidationFailure("Error", ret.Message) });
            }
            return Task.FromResult(item);
        }
    }
}
