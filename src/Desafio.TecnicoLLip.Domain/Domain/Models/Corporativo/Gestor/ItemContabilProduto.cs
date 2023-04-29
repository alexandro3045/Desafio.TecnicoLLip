﻿using System;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.Gestor
{
    public class ItemContabilProduto : Base.Base
    {
        private string codigoEmpresa;
        public string CodigoEmpresa { get => codigoEmpresa.Trim(); set => codigoEmpresa = value; }
        private string codigoCentroResponsabilidade;
        public string CodigoCentroResponsabilidade { get => codigoCentroResponsabilidade.Trim(); set => codigoCentroResponsabilidade = value; }
        public int? ProdutoId { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime? Fim { get; set; }
        public char? IsAssistencial { get; set; }
        public int? GrupoClassifId { get; set; }
    }
}
