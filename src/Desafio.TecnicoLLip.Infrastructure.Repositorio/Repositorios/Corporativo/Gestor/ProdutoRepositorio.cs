using Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository.Corporativo.Gestor;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor;
using Desafio.TecnicoLLip.Domain.Models.Utility;
using Desafio.TecnicoLLip.Infrastructure.Data.Contextos.Corporativo;
using Desafio.TecnicoLLip.Infrastructure.Data.Contextos.SGE;
using Desafio.TecnicoLLip.Infrastructure.Data.Extensions;
using Desafio.TecnicoLLip.Infrastructure.Data.Repositorios.Base;
using FluentValidation.Results;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Desafio.TecnicoLLip.Infrastructure.Data.Repositorios.Corporativo.Gestor
{
    public class ProdutoRepositorio : BaseRepositorio<Produto>, IProdutoRepository
    {
        public ProdutoRepositorio(CorporativoContext context, SgeContext sgeContexto) : base(context, sgeContexto) { }

        public override async Task<Produto> FirstOrDefault(Expression<Func<Produto, bool>> expression, IEnumerable<string> includes)
        {
            return await base.FirstOrDefault(expression, includes).ContinueWith((produto) => { return BindProduto(produto.Result).Result; });
        }

        public override async Task<IEnumerable<Produto>> ComFiltros(string colunaOrdenacao, bool? asc, Expression<Func<Produto, bool>> filtro, int qtd, int pule, IEnumerable<string> includes)
        {
            return await base.ComFiltros(colunaOrdenacao, asc, filtro, qtd, pule, includes)
                .ContinueWith((produtos) => { return produtos.Result.ForEach(async n => await BindProduto(n)).AsParallel(); });
        }

        public async Task<Produto> BindProduto(Produto result)
        {
            if (result != null)
            {
                if (!String.IsNullOrEmpty(result.CodigoAreaDN))
                    result.AreaDN = ((CorporativoContext)Contexto)
                        .AreasDNs
                        .FirstOrDefault(t => t.Id == Convert.ToInt32(result.CodigoAreaDN));

                result.Lazer = ((CorporativoContext)Contexto)
                    .Lazeres
                    .Include(b => b.Produto)
                    .FirstOrDefault(g => g.Id == result.Id);

                result.Saude = ((CorporativoContext)Contexto)
                    .Saudes
                    .FirstOrDefault(g => g.ProdutoId == result.Id);

                if (result.ModalidadeId.HasValue)
                    result.Modalidade = _SGEContexto
                    .ModalidadesCursos
                    .FirstOrDefault(g => g.Id == result.ModalidadeId.ToString());
            }

            return await Task.FromResult(result);
        }

        public override Task<Produto> Atualizar(Produto item)
        {
            ClearParameters();
            AddParameters(item, nameof(Atualizar));
            AddParameters("in_sq_classifservofic", item.Id.GetDBNullOrValue());
            AddParameters("vc_ds_servoficial_classif", item.Descricao.GetDBNullOrValue());
            AddParameters("ch_fg_atendimento_classifservofic", item.Atendimento?.Id.GetDBNullOrValue());
            AddParameters("ch_ql_servoficial", item.TipoServicoId?.GetDBNullOrValue());
            AddParameters("vc_cd_classifservofic", item.CodigoServico.GetDBNullOrValue());
            AddParameters("ch_fg_divulgado_classifservofic", item.Divulgado?.Id.GetDBNullOrValue());
            AddParameters("ch_cd_area", item.AreaId.GetDBNullOrValue());
            AddParameters("vc_nm_resumido_classifservofic", item.NomeResumido.GetDBNullOrValue());
            AddParameters("ch_fg_especialidade_grupoclassif", item.Especialidade?.Id.GetDBNullOrValue());
            AddParameters("ch_fg_divulgado_site_classifservofic", item.DivulgadoSite?.Id.GetDBNullOrValue());
            AddParameters("ch_fg_valecultura_classifservofic", item.ValeCultura?.Id.GetDBNullOrValue());
            AddParameters("in_sq_classificacaoservicost", item.ClassificacaoServicoId?.GetDBNullOrValue());
            AddParameters("in_sq_linhaservicost", item.LinhaServicoId?.GetDBNullOrValue());
            AddParameters("in_sq_plataformast", item.PlataformaId?.GetDBNullOrValue());
            AddParameters("in_sq_TUSS", item.TUSSId?.GetDBNullOrValue());
            AddParameters("sd_dt_validade_classifservofic", item.Validade?.GetDBNullOrValue());
            AddStroredProcedure("[dbo].[SPAlterarClassifServicoOficial]");

            var ret = ExecuteStoredProcedure();
            
            if (ret.ErrorCod > 0)
            {
                item.ValidationResult = new ValidationResult(new List<ValidationFailure> { new ValidationFailure("Error", ret.Message) });
            }

            return Task.FromResult(item);
        }

        public override Task<Produto> Adicionar(Produto item)
        {
            ClearParameters();
            AddParameters(item, nameof(Adicionar));
            AddParameters("vc_ds_servoficial_classif", item.Descricao.GetDBNullOrValue());
            AddParameters("ch_fg_atendimento_classifservofic", item.Atendimento?.Id.GetDBNullOrValue());
            AddParameters("ch_ql_servoficial", item.TipoServicoId.GetDBNullOrValue());
            AddParameters("ch_tp_entidade_vinculo", item.TipoEntidadeVinculoId.GetDBNullOrValue());
            AddParameters("ch_cd_area", item.AreaId.GetDBNullOrValue());
            AddParameters("vc_nm_resumido_classifservofic", item.NomeResumido.GetDBNullOrValue());
            AddParameters("si_sq_tabservico", item.TabelaServicoId.GetDBNullOrValue());
            AddParameters("ti_nr_nivelservico", item.NivelServicoId.GetDBNullOrValue());
            AddParameters("vc_sq_classifservofic_especialidade", item.CodigoServicoEspecialidade.GetDBNullOrValue());
            AddParameters("in_sq_grupoclassif_primeironivel", item.GrupoClassificacaoPrimeiroNivelId.GetDBNullOrValue());
            AddParameters("in_sq_grupoclassif", item.GrupoClassificacaoId.GetDBNullOrValue());
            AddParameters("ch_cd_funcaoservtec", item.FuncaoServicoTecnologicoCodigo.GetDBNullOrValue());
            AddParameters("vc_cd_classifservofic", item.CodigoServico.GetDBNullOrValue());
            AddParameters("ch_fg_divulgado_classifservofic", item.Divulgado?.Id.GetDBNullOrValue());
            AddParameters("ch_ql_categoria_classifservofic", item.Categoria?.Id.GetValueOrDefault());
            AddParameters("sd_dt_fim_classifservofic", item.Fim?.GetDBNullOrValue());
            AddParameters("ch_fg_especialidade_grupoclassif", item.Especialidade?.Id.GetDBNullOrValue());
            AddParameters("in_sq_classifservofic", item.Id.GetDBNullOrValue(), System.Data.ParameterDirection.Output);
            AddParameters("ch_fg_divulgado_site_classifservofic", item.DivulgadoSite?.Id.GetDBNullOrValue());
            AddParameters("ch_fg_valecultura_classifservofic", item.ValeCultura?.Id.GetDBNullOrValue());
            AddParameters("in_sq_classificacaoservicost", item.ClassificacaoServicoId.GetDBNullOrValue());
            AddParameters("in_sq_linhaservicost", item.LinhaServicoId.GetDBNullOrValue());
            AddParameters("in_sq_plataformast", item.PlataformaId.GetDBNullOrValue());
            AddParameters("in_sq_TUSS", item.TUSSId.GetDBNullOrValue());
            AddParameters("sd_dt_validade_classifservofic", item.Validade?.GetDBNullOrValue());
            AddParameters("ch_fg_exigecontrato_classifservofic", item.ExigeContrato?.Id.GetDBNullOrValue());
            AddParameters("ch_tp_cliente_classifservofic", item.TipoCliente?.Id.GetDBNullOrValue());
            AddParameters("sd_dt_criacao_classifservofic", item.Inicio.GetDBNullOrValue());
            AddStroredProcedure("[dbo].[SPIncluirClassifServicoOficial]");

            var result = ExecuteStoredProcedure();
            
            item.Id = GetParamOutPutValue<int>();

            return Task.FromResult(result.Entity);
        }

        public override Task<Produto> Remover(Produto item)
        {
            ClearParameters();
            AddParameters(item, nameof(Remover));
            AddParameters("in_sq_classifservofic", item.Id.GetDBNullOrValue());
            AddStroredProcedure("[dbo].[SPExcluirClassifServicoOficial]");

            var ret = ExecuteStoredProcedure();
            if (ret.ErrorCod > 0)
            {
                item.ValidationResult = new ValidationResult(new List<ValidationFailure> { new ValidationFailure("Error", ret.Message) });
            }

            return Task.FromResult(item);
        }
    }
}