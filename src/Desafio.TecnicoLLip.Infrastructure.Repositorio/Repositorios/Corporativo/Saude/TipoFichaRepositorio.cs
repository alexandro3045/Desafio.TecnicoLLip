using Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository.Corporativo.Saude;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor;
using Desafio.TecnicoLLip.Infrastructure.Data.Contextos.Corporativo;
using Desafio.TecnicoLLip.Infrastructure.Data.Extensions;
using Desafio.TecnicoLLip.Infrastructure.Data.Repositorios.Base;
using FluentValidation.Results;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Desafio.TecnicoLLip.Infrastructure.Data.Repositorios.Corporativo.Saude
{
    public class TipoFichaRepositorio : BaseRepositorio<TipoFicha>, ITipoFichaRepository
    {
        public TipoFichaRepositorio(CorporativoContext context) : base(context) { }

        public override Task<TipoFicha> Remover(TipoFicha item)
        {
            ClearParameters();
            AddParameters(item, nameof(Remover));
            AddParameters("in_sq_tpregatend", item.Id.GetDBNullOrValue());
            AddStroredProcedure("[dbo].[sp_TipoRegAtendExcluir]");
            var ret = ExecuteStoredProcedure();
            if (ret.ErrorCod > 0)
            {
                item.ValidationResult = new ValidationResult(new List<ValidationFailure> { new ValidationFailure("Error", ret.Message) });
            }
            return Task.FromResult(item);
        }
    }
}