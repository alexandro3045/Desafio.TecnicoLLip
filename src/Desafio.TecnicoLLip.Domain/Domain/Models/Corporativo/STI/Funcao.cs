using System;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.STI
{
    public class Funcao : Base.Base
    {
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public string Sigla { get; set; }
        public bool ParticipantePF { get; set; }
        public bool ParticipantePJ { get; set; }
        public bool ValidaFavorecidoContratoPF { get; set; }
        public DateTime? Inicio { get; set; }
        public DateTime? Fim { get; set; }
    }
}