#region Includes
using Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository;
using Desafio.TecnicoLLip.Domain.Models;
using Desafio.TecnicoLLip.Infrastructure.Data.Contextos.Corporativo;
using Desafio.TecnicoLLip.Infrastructure.Data.Repositorios.Base;
#endregion

namespace Desafio.TecnicoLLip.Infrastructure.Data.Repositorios.Corporativo
{
    public class UsersRepositorio : BaseRepositorio<Users>, IUsersRepository
    {
        public UsersRepositorio(DesafioLlipContext context) : base(context) { }
    }
}