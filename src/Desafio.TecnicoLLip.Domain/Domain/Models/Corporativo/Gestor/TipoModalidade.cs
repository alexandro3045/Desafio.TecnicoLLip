using Desafio.TecnicoLLip.Domain.Models.Base;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos;
using System;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor
{
    public class TipoModalidade : TipoModel<Int16?>
    {
        public string Codigo { get; set; }
        public string CodigoDN { get; set; }
        public Int16 ModalidadeId { get; set; }
        public Modalidade Modalidade { get; set; }
        public Acao Acao { get; set; }
    }
}
