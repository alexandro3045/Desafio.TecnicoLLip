using System;
using System.Collections.Generic;
using System.Data;

namespace Desafio.TecnicoLLip.Infrastructure.Data.Utils
{
    public static class SqlHelper
    {

        /// <summary>
        /// Gets the underlying enum type for this instance.
        /// </summary>
        /// <value></value>
        private static Dictionary<Type, SqlDbType> typeMap
        {
            get { return new Dictionary<Type, SqlDbType>
                    {
                        [typeof(string)] = SqlDbType.NVarChar,
                        [typeof(char[])] = SqlDbType.NVarChar,
                        [typeof(byte)] = SqlDbType.TinyInt,
                        [typeof(short)] = SqlDbType.SmallInt,
                        [typeof(int)] = SqlDbType.Int,
                        [typeof(long)] = SqlDbType.BigInt,
                        [typeof(byte[])] = SqlDbType.Image,
                        [typeof(bool)] = SqlDbType.Bit,
                        [typeof(DateTime)] = SqlDbType.DateTime2,
                        [typeof(DateTimeOffset)] = SqlDbType.DateTimeOffset,
                        [typeof(decimal)] = SqlDbType.Decimal,
                        [typeof(float)] = SqlDbType.Real,
                        [typeof(double)] = SqlDbType.Float,
                        [typeof(TimeSpan)] = SqlDbType.Time,
                        [typeof(char)] = SqlDbType.Char
                    };  
            }
        }

        public static SqlDbType GetDbType(object prameters)
        {
            return GetDbType(prameters.GetType());
        }

        public static SqlDbType GetDbType(Type giveType)
        {
            giveType = Nullable.GetUnderlyingType(giveType) ?? giveType;

            if (typeMap.ContainsKey(giveType))
            {
                return typeMap[giveType];
            }

            throw new ArgumentException($"{giveType.FullName} is not a supported .NET class");
        }

        public static SqlDbType GetDbType<T>()
        {
            return GetDbType(typeof(T));
        }
    }
}
