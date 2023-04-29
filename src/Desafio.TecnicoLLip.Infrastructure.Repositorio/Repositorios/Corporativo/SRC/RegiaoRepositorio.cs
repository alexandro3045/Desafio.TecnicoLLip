using Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository.Corporativo.SRC;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.SRC;
using Desafio.TecnicoLLip.Infrastructure.Data.Contextos.Corporativo;
using Desafio.TecnicoLLip.Infrastructure.Data.Repositorios.Base;

namespace Desafio.TecnicoLLip.Infrastructure.Data.Repositorios.Corporativo.SRC
{
    public class RegiaoRepositorio : BaseRepositorio<Regiao>, IRegiaoRepository
    {
        public RegiaoRepositorio(CorporativoContext context) : base(context) { }
    }
}