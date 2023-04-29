﻿using Desafio.TecnicoLLip.Domain.Models.Base;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor.Tipos;
using System;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor
{
    public class Faixa : TipoModel<int>
    {
        public string Codigo { get; set; }
        public TipoCliente Qualificador { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
        public CancelamentoFaixa CancelamentoFaixa { get; set; }
        public Tipos.TipoRegimento TipoRegimento { get; set; }
        public TipoMatriz TipoMatriz { get; set; }
        public TipoCliente TipoCliente { get; set; }
    }
}
