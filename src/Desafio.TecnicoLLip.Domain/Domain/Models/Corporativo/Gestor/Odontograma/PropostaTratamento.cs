using Desafio.TecnicoLLip.Domain.Models.Base;
using System;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Odontograma
{
    public class PropostaTratamento : TipoModel<int>
    {
        public string CodigoPlanoTratamentoOdontologico { get; set; }
        public Byte QtdModulosPrevistoConsulta { get; set; }
        public DateTime DataAgenda { get; set; }
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
    }
}
