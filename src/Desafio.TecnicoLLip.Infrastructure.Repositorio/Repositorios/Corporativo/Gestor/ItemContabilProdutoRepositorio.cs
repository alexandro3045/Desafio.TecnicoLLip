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
    public class ItemContabilProdutoRepositorio : BaseRepositorio<ItemContabilProduto>, IItemContabilProdutoRepository
    {
        public ItemContabilProdutoRepositorio(CorporativoContext context) : base(context) { }

        public override Task<ItemContabilProduto> Atualizar(ItemContabilProduto item)
        {
            ClearParameters();
            AddParameters(item, nameof(Atualizar));
            AddParameters("Empresa", item.CodigoEmpresa.GetDBNullOrValue());
            AddParameters("CodSub1", item.CodigoCentroResponsabilidade.GetDBNullOrValue());
            AddParameters("in_sq_classifservofic", item.ProdutoId.GetDBNullOrValue());
            AddParameters("sd_dt_ini_clservsubconta1", item.Inicio.GetDBNullOrValue());
            AddParameters("sd_dt_fim_clservsubconta1", item.Fim.GetDBNullOrValue());
            AddParameters("in_sq_grupoclassif", item.GrupoClassifId.GetDBNullOrValue());
            AddStroredProcedure("[dbo].[sp_ClServCRespAlterar]");

            var res = ExecuteStoredProcedure();
            if (res.ErrorCod > 0)
            {
                item.ValidationResult = new ValidationResult(new List<ValidationFailure> { new ValidationFailure("Error", res.Message) });
                return Task.FromResult(item);
            }

            return Task.FromResult(item);
        }

        public override Task<ItemContabilProduto> Adicionar(ItemContabilProduto item)
        {
            ClearParameters();
            AddParameters(item, nameof(Adicionar));
            AddParameters("Empresa", item.CodigoEmpresa.GetDBNullOrValue());
            AddParameters("CodSub1", item.CodigoCentroResponsabilidade.GetDBNullOrValue());
            AddParameters("in_sq_classifservofic", item.ProdutoId.GetDBNullOrValue());
            AddParameters("sd_dt_ini_clservsubconta1", item.Inicio.GetDBNullOrValue());
            AddParameters("ch_fg_assistencial_ClSrvSubCta1", item.IsAssistencial.GetDBNullOrValue());
            AddParameters("in_sq_grupoclassif", item.GrupoClassifId.GetDBNullOrValue());
            AddStroredProcedure("[dbo].[sp_ClServCRespIncluir]");

            var res = ExecuteStoredProcedure();
            if (res.ErrorCod > 0)
            {
                item.ValidationResult = new ValidationResult(new List<ValidationFailure> { new ValidationFailure("Error", res.Message) });
                return Task.FromResult(item);
            }

            return Task.FromResult(item);
        }

        public override Task<ItemContabilProduto> Remover(ItemContabilProduto item)
        {
            ClearParameters();
            AddParameters(item, nameof(Remover));
            AddParameters("Empresa", item.CodigoEmpresa.GetDBNullOrValue());
            AddParameters("CodSub1", item.CodigoCentroResponsabilidade.GetDBNullOrValue());
            AddParameters("in_sq_classifservofic", item.ProdutoId.GetDBNullOrValue());
            AddParameters("sd_dt_ini_clservsubconta1", item.Inicio.GetDBNullOrValue());
            AddParameters("sd_dt_fim_clservsubconta1", item.Fim.GetDBNullOrValue());
            AddStroredProcedure("[dbo].[sp_ClServCRespExcluir]");

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