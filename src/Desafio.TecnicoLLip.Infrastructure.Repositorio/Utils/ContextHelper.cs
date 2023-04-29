using Desafio.TecnicoLLip.Domain.Models.Corporativo;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Desafio.TecnicoLLip.Infrastructure.Data.Utils
{
    public static class ContextHelper
    {
        public static Task OnAfterSaveChanges(this DbContext dbContext, Logger logger)
        {
            dbContext.Entry(logger).State = EntityState.Added;
            return dbContext.SaveChangesAsync();
        }
    }
}
