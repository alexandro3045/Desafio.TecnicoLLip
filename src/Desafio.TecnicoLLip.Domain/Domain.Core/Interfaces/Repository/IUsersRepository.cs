#region Includes
using Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository.BaseRepository;
using Desafio.TecnicoLLip.Domain.Models;
#endregion

namespace Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository
{
    public interface IUsersRepository : IBaseRepository<Users> { }
}
