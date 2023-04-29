using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.TecnicoLLip.Domain.Models.Utility
{
    public static class GenericExtension
    {
        public static T? GetValueOrNull<T>(this string valueAsString) where T : struct
        {
            if (string.IsNullOrEmpty(valueAsString))
                return null;
            return (T)Convert.ChangeType(valueAsString, typeof(T));
        }

        public static Nullable<T> ToNullable<T>(this string s) where T : struct
        {
            Nullable<T> result = new Nullable<T>();
            if (!string.IsNullOrEmpty(s) && s.Trim().Length > 0)
            {
                TypeConverter conv = TypeDescriptor.GetConverter(typeof(T));
                result = (T)conv.ConvertFrom(s);
            }
            return result;
        }
    }

    public static  class ForEachAsyncExtension
    {
        public static  Task ForEachAsync<T>(this IEnumerable<T> source, int dop, Func<T, Task> body)
        {
            return Task.WhenAll(
                    from partition in Partitioner.Create(source).GetPartitions(dop)
                    select Task.Run(async delegate
                    {
                        using (partition)
                            while (partition.MoveNext())
                                await body(partition.Current).ConfigureAwait(false);
                    })
                  );
        }
    }
}
