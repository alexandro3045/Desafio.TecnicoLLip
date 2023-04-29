using System;
using Desafio.TecnicoLLip.Domain.Models.Base;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos;


namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor
{
    public class Colaborador : TipoModel<int>
    {
        public int PessoaId { get; set; }
        public Pessoa Pessoa { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
        public Qualificador Qualificador { get; set; }
        public DateTime Cancelamento { get; set; }
    }
}
