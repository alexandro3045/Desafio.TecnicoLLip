﻿using Desafio.TecnicoLLip.Domain.Models.Base;
using Desafio.TecnicoLLip.Domain.Models.Corporativo.SRC;
using System;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor
{
    public class ProdutoUnidadeNegocio : TipoModel<int>
    {
        public int? ProdutoId { get; set; }
        public Produto Produto { get; set; }
        public Int16 UnidadeNegocioId { get; set; }
        public UnidadeNegocio UnidadeNegocio { get; set; }
        public DateTime? Inicio { get; set; }
        public DateTime? Fim { get; set; }
        public char? ExecutaServicoOferecido { get; set; } = 'N';
        public char? EmEstudoAtendimentoProduto { get; set; } = 'N';
        public decimal? PercentualMaximoDesconto { get; set; }
    }
}
