using Desafio.TecnicoLLip.Domain.Models.Base;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos;
using System;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor
{
    public class Modalidade : TipoModel<Int16?>
    {
        public TipoEntidade TipoEntidade { get; set; }
        public DateTime Fim { get; set; }
    }
}
