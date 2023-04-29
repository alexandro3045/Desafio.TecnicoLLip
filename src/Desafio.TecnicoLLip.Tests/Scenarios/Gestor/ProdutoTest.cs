using LlipTests.Scenarios.Base.CRUD;
using System;
using Xunit.Extensions.Ordering;

namespace Desafio.TecnicoLLip.Tests.Scenarios.Gestor
{
    [Order(13)]
    public class ProdutoTest  : Operations
    {
        public ProdutoTest()
        {
            Body = new
            {
                Inicio = DateTime.ParseExact("2020-02-17 14:43:52", "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture),
                Fim = DateTime.ParseExact("2024-02-17 14:43:52", "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture),
                Divulgado = new { Id = "S", Name = "Sim" },
                DivulgadoSite = new { Id = "N", Name = "Não" },
                NivelServicoId =  byte.Parse("1"),
                TabelaServicoId = Int32.Parse("12"),
                TipoEntidadeVinculoId = "44",
                TipoServicoId = "E",
                Dedutivel = new { Id = "N", Name = "Não" },
                AreaId = "63",
                ServicoOficialId = 841,
                PlataformaId = 35,
                TUSSId = 375,
                ClassificacaoServicoId = 10,
                LinhaServicoId = 9,
                ExigeCPF = true,
                Descricao = $"TESTE TDD {RandTest}",
                NomeResumido = $"TESTE TDD {RandTest}",
                Categoria = new { Id = 'M', Name = "Material" },
                Especialidade = new { Id = 'S', Name = "Sim" },
                ValeCultura = new { Id = 'S', Name = "Sim" },
                Atendimento = new { Id = 'S', Name = "Sim" },
                NumeroAgente = "1596",
                Validade = DateTime.ParseExact("2020-02-17 14:40:52", "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture),
                ExigeContrato = new { Id = 'A', Name = "Ambos" },
                TipoCliente = new { Id = 'F', Name = "Física" }
            };

            Configure("Gestor/Produtos", "31");
        }
    }
}