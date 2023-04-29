using Desafio.TecnicoLLip.Domain.Models.Base;
using System;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor
{
    public class Genero : TipoModel<string>
    {
        public Byte? RamoAtividadeId { get; set; }
        public RamoAtividade RamoAtividade { get; set; }
    }
}