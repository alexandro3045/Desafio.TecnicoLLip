using Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository.Corporativo.Gestor.Odontograma;
using Desafio.TecnicoLLip.Infrastructure.Data.Contextos.Corporativo;
using Desafio.TecnicoLLip.Infrastructure.Data.Extensions;
using Desafio.TecnicoLLip.Infrastructure.Data.Repositorios.Base;
using FluentValidation.Results;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Desafio.TecnicoLLip.Infrastructure.Data.Repositorios.Corporativo.Gestor.Odontograma
{
    public class FiguraOdontogramaRepositorio : BaseRepositorio<Domain.Models.Corporativo.Gestor.Odontograma.FiguraOdontograma>, IFiguraOdontogramaRepository
    {
        public FiguraOdontogramaRepositorio(CorporativoContext context) : base(context) { }

        public override Task<Domain.Models.Corporativo.Gestor.Odontograma.FiguraOdontograma> Remover(Domain.Models.Corporativo.Gestor.Odontograma.FiguraOdontograma item)
        {
            ClearParameters();
            AddParameters(item, nameof(Remover));
            AddParameters("in_sq_figuraodontograma", item.Id.GetDBNullOrValue());
            AddStroredProcedure("[dbo].[spExcluirFiguraOdontograma]");

            var ret = ExecuteStoredProcedure();
            if (ret.ErrorCod > 0)
            {
                item.ValidationResult = new ValidationResult(new List<ValidationFailure> { new ValidationFailure("Error", ret.Message) });
            }

            return Task.FromResult(item);
        }
    }
}