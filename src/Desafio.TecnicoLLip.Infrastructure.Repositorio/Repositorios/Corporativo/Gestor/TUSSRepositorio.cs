using Desafio.TecnicoLLip.Infrastructure.Data.Repositorios.Base;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor;
using Desafio.TecnicoLLip.Infrastructure.Data.Extensions;
using FluentValidation.Results;
using System.Threading.Tasks;
using Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository.Corporativo.Gestor;
using Desafio.TecnicoLLip.Infrastructure.Data.Contextos.Corporativo;

namespace Desafio.TecnicoLLip.Infrastructure.Data.Repositorios.Corporativo.Gestor
{
    public class TussRepositorio : BaseRepositorio<Tuss>, ITussRepository
    {
        protected const string StoredProcedureExcluir = "[dbo].[spTUSSExcluir] ";

        public TussRepositorio(CorporativoContext context) : base(context) { }

        public override Task<Tuss> Remover(Tuss item)
        {
            ClearParameters();
            AddParameters(item, nameof(Remover));
            AddParameters("in_sq_TUSS", item.Id.GetDBNullOrValue());
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