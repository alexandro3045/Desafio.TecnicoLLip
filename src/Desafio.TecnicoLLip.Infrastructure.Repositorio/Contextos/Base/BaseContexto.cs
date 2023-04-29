using EntityFrameworkCore.Triggers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Desafio.TecnicoLLip.Infrastructure.Data.Contextos.Base
{
    public abstract class BaseContexto : DbContext
    {
        public Boolean TriggersEnabled { get; set; } = true;

        private readonly IServiceProvider serviceProvider;

        protected BaseContexto() : base() { }

        protected BaseContexto(IServiceProvider serviceProvider) : base() => this.serviceProvider = serviceProvider;

        protected BaseContexto(DbContextOptions options) : base(options) { }

        protected BaseContexto(IServiceProvider serviceProvider, DbContextOptions options) : base(options) => this.serviceProvider = serviceProvider;

		public override Int32 SaveChanges()
		{
			return TriggersEnabled ? this.SaveChangesWithTriggers(base.SaveChanges, serviceProvider) : base.SaveChanges();
		}

		public override Int32 SaveChanges(Boolean acceptAllChangesOnSuccess)
		{
			return TriggersEnabled ? this.SaveChangesWithTriggers(base.SaveChanges, serviceProvider, acceptAllChangesOnSuccess) : base.SaveChanges(acceptAllChangesOnSuccess);
		}

		public override Task<Int32> SaveChangesAsync(CancellationToken cancellationToken = default)
		{
			return TriggersEnabled ? this.SaveChangesWithTriggersAsync(base.SaveChangesAsync, serviceProvider, cancellationToken) : base.SaveChangesAsync(cancellationToken);
		}

		public override Task<Int32> SaveChangesAsync(Boolean acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
		{
			return TriggersEnabled ? this.SaveChangesWithTriggersAsync(base.SaveChangesAsync, serviceProvider, acceptAllChangesOnSuccess, cancellationToken) : base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
		}
	}
}
