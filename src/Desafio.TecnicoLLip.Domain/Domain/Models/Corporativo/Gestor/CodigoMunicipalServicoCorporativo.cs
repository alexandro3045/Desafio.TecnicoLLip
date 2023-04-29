using System;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor
{
    public class CodigoMunicipalServicoCorporativo : Base.Base
    {
        public int CodigoServicoOficial { get; set; }
        public string CodigoMunicipalId { get; set; }
        public CodigoMunicipal CodigoMunicipal { get; set; }
        public DateTime Inicio { get; set; }
        public string CodigoMunicipio { get; set; }
        public Municipio Municipio { get; set; }
        public DateTime? Fim { get; set; }
        public int SeqMunicipio { get; set; }
    }
}
