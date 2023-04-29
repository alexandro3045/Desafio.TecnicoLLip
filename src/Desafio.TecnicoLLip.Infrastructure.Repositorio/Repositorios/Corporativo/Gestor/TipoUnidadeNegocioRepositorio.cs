using Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository.Corporativo.Gestor;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor;
using Desafio.TecnicoLLip.Infrastructure.Data.Contextos.Corporativo;
using Desafio.TecnicoLLip.Infrastructure.Data.Extensions;
using Desafio.TecnicoLLip.Infrastructure.Data.Repositorios.Base;
using FluentValidation.Results;
using System.Threading.Tasks;

namespace Desafio.TecnicoLLip.Infrastructure.Data.Repositorios.Corporativo.Gestor
{
    public class TipoUnidadeNegocioRepositorio : BaseRepositorio<TipoUnidadeNegocio>, ITipoUnidadeNegocioRepository
    {
        protected const string StoredProcedureExcluir = "[dbo].[sp_TipoUnidadeNegocioExcluir]";

        public TipoUnidadeNegocioRepositorio(CorporativoContext context) : base(context) { }

        public override Task<TipoUnidadeNegocio> Remover(TipoUnidadeNegocio item)
        {
            ClearParameters();
            AddParameters(item, nameof(Remover));
            AddParameters("si_sq_tipounidade", item.Id.GetDBNullOrValue());
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
