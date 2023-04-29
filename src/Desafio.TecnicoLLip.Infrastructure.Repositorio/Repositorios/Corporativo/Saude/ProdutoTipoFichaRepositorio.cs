using Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository.Corporativo.Saude;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.Saude;
using Desafio.TecnicoLLip.Infrastructure.Data.Contextos.Corporativo;
using Desafio.TecnicoLLip.Infrastructure.Data.Repositorios.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Desafio.TecnicoLLip.Infrastructure.Data.Repositorios.Corporativo.Saude
{
    public class ProdutoTipoFichaRepositorio : BaseRepositorio<ProdutoTipoFicha>, IProdutoTipoFichaRepository
    {
        public ProdutoTipoFichaRepositorio(CorporativoContext context) : base(context) { }

        public override async Task<IEnumerable<ProdutoTipoFicha>> ComFiltros(string colunaOrdenacao, bool? asc, Expression<Func<ProdutoTipoFicha, bool>> filtro, int qtd, int pule, IEnumerable<string> includes)
        {
            return await base.ComFiltros(colunaOrdenacao, asc, filtro, qtd, pule, includes)
                .ContinueWith((g) =>
                {
                    return g.Result.Where(c => (c.Produto.Fim ?? Convert.ToDateTime("2079-06-06")) > DateTime.Now);
                });
        }

        public override Task<ProdutoTipoFicha> FirstOrDefault(Expression<Func<ProdutoTipoFicha, bool>> expression, IEnumerable<string> includes)
        {
            return base.ComFiltros(null, null, expression, 1, 0, includes)
                .ContinueWith((g) =>
                {
                    return g.Result.FirstOrDefault(c => (c.Produto.Fim ?? Convert.ToDateTime("2079-06-06")) > DateTime.Now);
                });
        }
    }
}