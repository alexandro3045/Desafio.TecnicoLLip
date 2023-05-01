
namespace Desafio.TecnicoLLip.Infrastructure.Data.Utils
{
    using Desafio.TecnicoLLip.Domain.Models.Base;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Data.SqlClient;
    using System.Text;

	public static class ExceptionExtensions
	{
		public static string ExceptionToString(this Exception ex)
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine("Date/Time: " + DateTime.UtcNow.ToString());
			sb.AppendLine("Exception Type: " + ex.GetType().FullName);
			sb.AppendLine("Message: " + ex.Message);
			sb.AppendLine("Source: " + ex.Source);
			foreach (var key in ex.Data.Keys)
			{
				sb.AppendLine(key.ToString() + ": " + ex.Data[key].ToString());
			}

			if (String.IsNullOrEmpty(ex.StackTrace))
			{
				sb.AppendLine("Environment Stack Trace: " + ex.StackTrace);
			}
			else
			{
				sb.AppendLine("Stack Trace: " + ex.StackTrace);
			}
			if (ex.InnerException != null)
			{
				sb.AppendLine("Inner Exception: " + ex.InnerException.ExceptionToString());
			}

			return sb.ToString();
		}

		public static void SetException<TEntity>(this Exception ex, ref ObjectResult<TEntity> objResult, string action) 
			where TEntity : Base
		{
			if (ex.GetBaseException().GetType() == typeof(SqlException))
			{
				Int32 ErrorCode = 0;

				if (ex.InnerException != null)
					ErrorCode = ((SqlException)ex.InnerException).Number;
				else
					ErrorCode = ((SqlException)ex).Number;

				switch (ErrorCode)
				{
					case 2627:
						objResult.Append($"{action} validation exception Unique constraint error");
						break;
					case 547:
						objResult.Append($"{action} validation exception Constraint check violation");
						break;
					case 2601:
						objResult.Append($"{action} validation exception Duplicated key row error");
						break;
					case 229:
						objResult.Append($"{action} The UPDATE OR DELETE permission was denied on the object");
						break;
					case 50001:
						objResult.Append($"{action}  - {ex.InnerException.Message}");
						break;
					default:
						break;
				}
			}

			if ((ex.GetBaseException().GetType() == typeof(DbUpdateConcurrencyException)))
			{
				objResult.Append($"{action} Database operation expected to affect 1 row(s) but actually affected 0 row(s)");
			}

			if ((ex.GetType() == typeof(DbUpdateException)))
			{
				objResult.Append("A DbUpdateException was caught while saving changes.");

				try
				{
					foreach (var result in ((DbUpdateException)ex).Entries)
					{
						objResult.Append($"Type: {result.Entity.GetType().Name} was part of the problem.");
					}
				}
				catch (Exception e)
				{
					objResult.Append("Error parsing DbUpdateException: " + e.ToString());
				}

				objResult.Append($"{action} validation exception: {((DbUpdateException)ex)?.InnerException?.Message}");

				objResult.Append(((DbUpdateException)ex));
			}
		}
	}
}
