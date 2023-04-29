using Desafio.TecnicoLLip.Domain.Models.Base;
using System;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo
{
    public class RamoAtividade : TipoModel<Byte?>
    {
        public string Codigo { get; set; }
    }
}