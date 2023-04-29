using Desafio.TecnicoLLip.Application.ViewModels.Base;
using Desafio.TecnicoLLip.Application.ViewModels.Corporativo.STI;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos.Base;
using System;

namespace Desafio.TecnicoLLip.Application.ViewModels.Corporativo.Gestor
{
    public class ServicoViewModel : TipoViewModel<int>
    {
        public Atendimento Atendimento { get; set; }
        public Int16? NaturezaServicoId { get; set; }
        public NaturezaServicoViewModel NaturezaServico { get; set; }
        public string Objetivo { get; set; }
        public string Procedimento { get; set; }
        public Flag MarcaHora { get; set; }
        public string AreaId { get; set; }
        public AreaViewModel Area { get; set; }
    }
}
