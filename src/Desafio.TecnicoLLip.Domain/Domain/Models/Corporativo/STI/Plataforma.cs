using Desafio.TecnicoLLip.Domain.Models.Base;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.STI
{
    public class Plataforma : TipoModel<int>
    {
        public string CodigoArea { get; set; }
        public Area Area { get; set; }
    }
}