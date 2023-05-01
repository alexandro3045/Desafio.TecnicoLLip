#region Includes
using Desafio.TecnicoLLip.Domain.Core.Interfaces.Repository;
using Desafio.TecnicoLLip.Domain.Core.Interfaces.Services;
using Desafio.TecnicoLLip.Domain.Models;
using Desafio.TecnicoLLip.Domain.Services.Base;
using Desafio.TecnicoLLip.Domain.Services.Validations;
#endregion

namespace Desafio.TecnicoLLip.Domain.Services.Services
{
    public class UsersService : BaseService<Users>, IUsersService
    {
        public UsersService(IUsersRepository repository, UsersValidator validator) : base(repository, validator) { }
    }
}
