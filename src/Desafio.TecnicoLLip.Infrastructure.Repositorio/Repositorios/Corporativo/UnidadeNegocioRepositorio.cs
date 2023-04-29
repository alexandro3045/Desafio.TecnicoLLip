using Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository.Corporativo.Gestor;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.SRC;
using Desafio.TecnicoLLip.Infrastructure.Data.Contextos.Corporativo;
using Desafio.TecnicoLLip.Infrastructure.Data.Extensions;
using Desafio.TecnicoLLip.Infrastructure.Data.Repositorios.Base;
using FluentValidation.Results;
using System.Threading.Tasks;

namespace Desafio.TecnicoLLip.Infrastructure.Data.Repositorios.Corporativo
{
    public class UnidadeNegocioRepositorio : BaseRepositorio<UnidadeNegocio>, IUnidadeNegocioRepository
    {
        protected const string StoredProcedureExcluir = "[dbo].[SPUnidadeNegocioExcluir]";

        public UnidadeNegocioRepositorio(CorporativoContext context) : base(context) { }

        public override Task<UnidadeNegocio> Remover(UnidadeNegocio item)
        {
            ClearParameters();
            AddParameters(item, nameof(Remover));
            AddParameters("si_sq_unidnegocio", item.Id.GetDBNullOrValue());
            AddStroredProcedure(StoredProcedureExcluir);
            var result = ExecuteStoredProcedure();
            if (result.ErrorCod > 0)
            {
                item.ValidationResult.Errors.Add(new ValidationFailure("Error", result.Message));
            }
            return Task.FromResult(item);
        }
    }
}