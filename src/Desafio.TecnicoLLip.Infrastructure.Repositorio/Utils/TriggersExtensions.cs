using System;
using EntityFrameworkCore.Triggers;
using Microsoft.AspNetCore.Builder;

namespace Desafio.TecnicoLLip.Infrastructure.Data.Utils
{
	public static class TriggersExtensions
	{
		public static IApplicationBuilder UseTriggers(this IApplicationBuilder app, Action<ITriggersBuilder> configureTriggers)
		{
			if (configureTriggers == null)
				throw new ArgumentNullException(nameof(configureTriggers));
			var triggersBuilder = TriggersBuilderFactory.Create(app.ApplicationServices);
			configureTriggers.Invoke(triggersBuilder);
			return app;
		}
	}
}