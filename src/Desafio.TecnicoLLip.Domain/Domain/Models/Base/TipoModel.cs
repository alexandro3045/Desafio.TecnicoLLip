namespace Desafio.TecnicoLLip.Domain.Models.Base
{
    public abstract class TipoModel<T> : BaseModel<T>
    {
        public string Descricao { get; set; }
        protected TipoModel() { }
    }
}
