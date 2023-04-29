using Desafio.TecnicoLLip.Domain.Models.Base;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor
{
    public class CodigoMunicipal : TipoModel<string>
    {
        public string CoodigoMunicipio { get; set; }
        public int MunicipioId { get; set; }
        public Municipio Municipio { get; set; }
        public decimal? AliqISS { get; set; }
        public string CNAE { get; set; }
    }
}