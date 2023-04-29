using Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository.Corporativo;
using Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository.Corporativo.Gestor;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor;
using Desafio.TecnicoLLip.Infrastructure.Data.Contextos.Corporativo;
using Desafio.TecnicoLLip.Infrastructure.Data.Repositorios.Base;

namespace Desafio.TecnicoLLip.Infrastructure.Data.Repositorios.Corporativo
{
    public class CodigoMunicipalRepositorio : BaseRepositorio<CodigoMunicipal>, ICodigoMunicipalRepository
    {
        public CodigoMunicipalRepositorio(CorporativoContext context, ILoggerRepository logger) : base(context, logger) { }
    }
}