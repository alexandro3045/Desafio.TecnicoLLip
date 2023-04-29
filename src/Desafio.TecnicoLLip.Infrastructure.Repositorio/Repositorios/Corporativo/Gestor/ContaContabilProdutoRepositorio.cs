using Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository.Corporativo.Gestor;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor;
using Desafio.TecnicoLLip.Infrastructure.Data.Contextos.Corporativo;
using Desafio.TecnicoLLip.Infrastructure.Data.Extensions;
using Desafio.TecnicoLLip.Infrastructure.Data.Repositorios.Base;
using FluentValidation.Results;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Desafio.TecnicoLLip.Infrastructure.Data.Repositorios.Corporativo.Gestor
{
    public class ContaContabilProdutoRepositorio : BaseRepositorio<ContaContabilProduto>, IContaContabilProdutoRepository
    {
        public ContaContabilProdutoRepositorio(CorporativoContext context) : base(context) { }

        private void AddParameters(ContaContabilProduto item, bool addDataFim, string method)
        {
            ClearParameters();
            AddParameters(item, method);
            AddParameters("Empresa", item.CodigoEmpresa.GetDBNullOrValue());
            AddParameters("Conta", item.CodigoConta.GetDBNullOrValue());
            AddParameters("in_sq_classifservofic", item.ProdutoId.GetDBNullOrValue());
            AddParameters("sd_dt_ini_clservplanocta", item.Inicio.GetDBNullOrValue());
            if(addDataFim)
                AddParameters("sd_dt_fim_clservplanocta", item.Fim.GetDBNullOrValue());
            AddParameters("ch_fg_assistencial_planocta", item.IsAssistencial.GetDBNullOrValue());
            AddParameters("in_sq_grupoclassif", item.GrupoClassifId.GetDBNullOrValue());
        }

        public override Task<ContaContabilProduto> Atualizar(ContaContabilProduto item)
        {
            ClearParameters();
            AddParameters(item, true, nameof(Atualizar));
            AddStroredProcedure("[dbo].[sp_ClServCtaEstAlterar]");

            var res = ExecuteStoredProcedure();
            if (res.ErrorCod > 0)
            {
                item.ValidationResult = new ValidationResult(new List<ValidationFailure> { new ValidationFailure("Error", res.Message) });
                return Task.FromResult(item);
            }

            return Task.FromResult(item);
        }

        public override Task<ContaContabilProduto> Adicionar(ContaContabilProduto item)
        {
            ClearParameters();
            AddParameters(item, false, nameof(Adicionar));
            AddStroredProcedure("[dbo].[Sp_ClServCtaEstIncluir]");

            var res = ExecuteStoredProcedure();
            if (res.ErrorCod > 0)
            {
                item.ValidationResult = new ValidationResult(new List<ValidationFailure> { new ValidationFailure("Error", res.Message) });
                return Task.FromResult(item);
            }

            return Task.FromResult(item);
        }

        public override Task<ContaContabilProduto> Remover(ContaContabilProduto item)
        {
            ClearParameters();
            AddParameters(item,true, nameof(Remover));
            AddStroredProcedure("[dbo].[sp_ClServCtaEstExcluir]");

            var res = ExecuteStoredProcedure();
            if (res.ErrorCod > 0)
            {
                item.ValidationResult = new ValidationResult(new List<ValidationFailure> { new ValidationFailure("Error", res.Message) });
                return Task.FromResult(item);
            }

            return Task.FromResult(item);
        }

    }
}