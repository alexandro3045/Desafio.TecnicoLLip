using Desafio.TecnicoLLip.Domain.Models.Base;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos.Base;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.STI;
using System;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor
{
    public class Servico : TipoModel<int>
    {
        public Atendimento Atendimento { get; set; }
        public Int16? NaturezaServicoId { get; set; }
        public NaturezaServico NaturezaServico { get; set; }
        public string Objetivo { get; set; }
        public string Procedimento { get; set; }
        public Flag MarcaHora { get; set; }
        public string AreaId { get; set; }
        public Area Area { get; set; }
    }
}
