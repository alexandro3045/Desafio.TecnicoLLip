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
    public class ClasseValorProdutoRepositorio : BaseRepositorio<ClasseValorProduto>, IClasseValorProdutoRepository
    {
        public ClasseValorProdutoRepositorio(CorporativoContext context) : base(context) { ClearParameters(); }

        public override Task<ClasseValorProduto> Atualizar(ClasseValorProduto item)
        {
            ClearParameters();
            AddParameters(item, nameof(Atualizar));
            AddParameters("Empresa", item.CodigoEmpresa.GetDBNullOrValue());
            AddParameters("CodSub2", item.CodigoCentroResponsabilidade.GetDBNullOrValue());
            AddParameters("in_sq_classifservofic", item.ProdutoId.GetDBNullOrValue());
            AddParameters("sd_dt_ini_clservsubconta2", item.Inicio.GetDBNullOrValue());
            AddParameters("sd_dt_fim_clservsubconta2", item.Fim.GetDBNullOrValue());
            AddParameters("in_sq_grupoclassif", item.GrupoClassifId.GetDBNullOrValue());
            AddStroredProcedure("[dbo].[sp_ClServSubConta2Alterar]");

            var res = ExecuteStoredProcedure();
            if (res.ErrorCod > 0)
            {
                item.ValidationResult = new ValidationResult(new List<ValidationFailure> { new ValidationFailure("Error", res.Message) });
                return Task.FromResult(item);
            }

            return Task.FromResult(item);
        }

        public override Task<ClasseValorProduto> Adicionar(ClasseValorProduto item)
        {
            ClearParameters();
            AddParameters(item, nameof(Adicionar));
            AddParameters("Empresa", item.CodigoEmpresa.GetDBNullOrValue());
            AddParameters("CodSub2", item.CodigoCentroResponsabilidade.GetDBNullOrValue());
            AddParameters("in_sq_classifservofic", item.ProdutoId.GetDBNullOrValue());
            AddParameters("sd_dt_ini_clservsubconta2", item.Inicio.GetDBNullOrValue());
            AddParameters("in_sq_grupoclassif", item.GrupoClassifId.GetDBNullOrValue());
            AddStroredProcedure("[dbo].[sp_ClServSubConta2Incluir]");

            var res = ExecuteStoredProcedure();
            if (res.ErrorCod > 0)
            {
                item.ValidationResult = new ValidationResult(new List<ValidationFailure> { new ValidationFailure("Error", res.Message) });
                return Task.FromResult(item);
            }

            return Task.FromResult(item);
        }

        public override Task<ClasseValorProduto> Remover(ClasseValorProduto item)
        {
            ClearParameters();
            AddParameters(item, nameof(Remover));
            AddParameters("Empresa", item.CodigoEmpresa.GetDBNullOrValue());
            AddParameters("CodSub2", item.CodigoCentroResponsabilidade.GetDBNullOrValue());
            AddParameters("in_sq_classifservofic", item.ProdutoId.GetDBNullOrValue());
            AddParameters("sd_dt_ini_clservsubconta2", item.Inicio.GetDBNullOrValue());
            AddParameters("sd_dt_fim_clservsubconta2", item.Fim.GetDBNullOrValue());
            AddStroredProcedure("[dbo].[sp_ClServSubConta2Excluir] ");

            var ret = ExecuteStoredProcedure();
            if (ret.ErrorCod > 0)
            {
                item.ValidationResult = new ValidationResult(new List<ValidationFailure> { new ValidationFailure("Error", ret.Message) });
            }
            return Task.FromResult(item);
        }
    }
}