using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.SRC;
using System;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor
{
    public class EnderecoUnidade: Base.Base
    {
        public int Id { get; set; }
        public int? MunicipioId { get; set; }
        public Municipio Municipio { get; set; }
        public Int16 UnidadeNegocioId { get; set; }
        public UnidadeNegocio UnidadeNegocio { get; set; }
        public string Logradouro { get; set; }
        public int? BairroId { get; set; }
        public Bairro Bairro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string CEP { get; set; }
        public string PontoReferencia { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public TipoEndereco TipoEndereco { get; set; }
    }
}
