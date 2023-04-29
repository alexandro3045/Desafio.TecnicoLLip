using Desafio.TecnicoLLip.Domain.Models.Base;
using System;

namespace Desafio.TecnicoLLip.Domain.Models.Corporativo.SRC
{
    public class UnidadeNegocio : TipoModel<Int16>
    {
        public DateTime? Inicio { get; set; } = null;
        public DateTime? Fim { get; set; } = null;
        public string EnderecoProprio { get; set; }
        public string EnderecadoProprio { get; set; }
        public string DiscadoProprio { get; set; }
        public string SiglaSerie { get; set; }
        public string SiglaTitulo { get; set; }
        public bool AceitaPreco { get; set; }
        public bool AutorizaDivulgacao { get; set; }
        public bool AtendimentoCentralizado { get; set; }
        public bool AtivoAssistMarca { get; set; }
        public bool AtivoOcupMarca { get; set; }
        public bool AtivoOcupDesMarca { get; set; }
        public Int16 TipoUnidadeId { get; set; }
        public bool FazFaturamento { get; set; }
        public int? EmpresaSistemaCNICoordenadoraId { get; set; }
        public string DescricaoAbreviado { get; set; }
        public string NomeCogecor { get; set; }
        public string Sigla { get; set; }
        public string Prestador { get; set; }
        public string Corporativo { get; set; }
    }
}