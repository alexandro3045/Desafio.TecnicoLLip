namespace Desafio.TecnicoLLip.Infrastructure.Data.Utils
{
    public class PropetyStruct<T>
    {
        public T Value { get; set; }

        public static implicit operator T(PropetyStruct<T> value)
        {
            return value.Value;
        }

        public static implicit operator PropetyStruct<T>(T value)
        {
            return new PropetyStruct<T> { Value = value };
        }
    }
}
