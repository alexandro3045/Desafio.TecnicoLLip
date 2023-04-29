using System;
using EntityFrameworkCore.Triggers;

namespace Desafio.TecnicoLLip.Domain.Models.Utility
{
	public abstract class EntityInsertTracking : Base.Base
	{
		public DateTime Inserted { get; private set; }
		public Int32 Number { get; private set; }

		static EntityInsertTracking()
		{
			Triggers<EntityInsertTracking>.Inserting += e => e.Entity.Inserted = DateTime.UtcNow;
			Triggers<EntityInsertTracking>.Inserting += e => e.Entity.Number = 42;
		}
	}
	public abstract class EntityTracking : EntityInsertTracking
	{
		public DateTime Updated { get; private set; }

		static EntityTracking()
		{
			Triggers<EntityTracking>.Inserting += e => e.Entity.Updated = DateTime.UtcNow;
			Triggers<EntityTracking>.Updating += e => e.Entity.Updated = DateTime.UtcNow;
		}
	}
}